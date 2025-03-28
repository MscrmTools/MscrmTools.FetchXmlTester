using CSRichTextBoxSyntaxHighlighting;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using MsCrmTools.FetchXmlTester.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace MsCrmTools.FetchXmlTester
{
    public partial class FetchXmlTester : PluginControlBase
    {
        private int currentsColumnOrder;
        private List<QueryInfo> Queries = new List<QueryInfo>();
        private Thread searchThread;
        private int selectedQueryIndex = -1;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of class <see cref="FetchXmlTester"/>
        /// </summary>
        public FetchXmlTester()
        {
            InitializeComponent();

            XMLViewerSettings viewerSetting = new XMLViewerSettings
            {
                AttributeKey = Color.Red,
                AttributeValue = Color.Blue,
                Tag = Color.Blue,
                Element = Color.DarkRed,
                Value = Color.Black,
                Comment = Color.Green
            };

            //viewer.Settings = viewerSetting;
        }

        #endregion Constructor

        #region Methods

        public override void ClosingPlugin(PluginCloseInfo info)
        {
            foreach (ListViewItem item in lvQueries.Items)
            {
                QueryInfo qi = item.Tag as QueryInfo;
                if (QueryInfo.PrintXML(qi.FetchXml) == QueryInfo.PrintXML(txtRequest.Text))
                {
                    qi.Delete();
                    qi.Date = DateTime.Now;
                    qi.Save(ConnectionDetail);
                    break;
                }
            }

            base.ClosingPlugin(info);
        }

        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            LoadQueriesHistory();
            ToolStripButton1Click(this, new EventArgs());
        }

        private void DisplayQueries(object filter = null)
        {
            Thread.Sleep(200);

            Invoke(new Action(() =>
            {
                lvQueries.Items.Clear();
                lvQueries.Items.AddRange(Queries
                    .Where(q => string.IsNullOrEmpty(filter?.ToString())
                    || q.Table.ToLower().IndexOf(filter?.ToString()?.ToLower()) >= 0
                    || q.Description.ToLower().IndexOf(filter?.ToString()?.ToLower()) >= 0
                    || q.FetchXml.ToLower().IndexOf(filter?.ToString()?.ToLower()) >= 0
                    || q.Environment.ToLower().IndexOf(filter?.ToString()?.ToLower()) >= 0
                    )
                    .OrderByDescending(q => q.Date).Select(q =>
                    {
                        var lvi = new ListViewItem(q.Table);
                        lvi.SubItems.Add(q.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                        lvi.SubItems.Add(q.Environment);
                        lvi.Tag = q;
                        lvi.ToolTipText = $"{(string.IsNullOrEmpty(q.Description) ? "" : q.Description + "\n\n")}{q.FetchXml}{(string.IsNullOrEmpty(q.Environment) ? "" : "\n\nEnvironment: " + q.Environment)}";
                        return lvi;
                    }).ToArray());
            }));
        }

        private DataTable GetDataTable(EntityCollection ec)
        {
            DataTable dTable = new DataTable();
            int iElement = 0;

            if (ec.Entities.Count == 0)
            {
                return dTable;
            }

            var attributeNames = ec.Entities.SelectMany(e => e.Attributes.Select(a => a.Key)).Distinct().OrderBy(a => a).ToList();

            //Defining the ColumnName for the datatable
            for (iElement = 0; iElement <= attributeNames.Count - 1; iElement++)
            {
                dTable.Columns.Add(attributeNames[iElement]);
            }

            foreach (Entity entity in ec.Entities)
            {
                DataRow dRow = dTable.NewRow();
                for (int i = 0; i <= entity.Attributes.Count - 1; i++)
                {
                    string colName = entity.Attributes.Keys.ElementAt(i);
                    dRow[colName] = tsbShowFormatted.Checked ? (entity.FormattedValues.Contains(colName) ? entity.FormattedValues[colName] : GetValue(entity.Attributes.Values.ElementAt(i))) : GetValue(entity.Attributes.Values.ElementAt(i));
                }
                dTable.Rows.Add(dRow);
            }
            return dTable;
        }

        private object GetValue(object o)
        {
            if (o is EntityReference er)
            {
                return er.Id.ToString();
            }
            else if (o is OptionSetValue osv)
            {
                return osv.Value;
            }
            else if (o is Money m)
            {
                return m.Value;
            }
            else if (o is OptionSetValueCollection osvc)
            {
                return string.Join(",", osvc.Select(opt => opt.Value));
            }
            else if (o is AliasedValue av)
            {
                return GetValue(av.Value);
            }
            else
            {
                return o;
            }
        }

        private void LoadQueriesHistory()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "",
                Work = (bw, e) =>
                {
                    Queries = QueryInfo.LoadQueries(tsbAllEnvs.Checked ? Guid.Empty : ConnectionDetail.ConnectionId.Value).ToList();
                },
                PostWorkCallBack = e =>
                {
                    if (e.Error != null) return;

                    DisplayQueries();
                }
            });
        }

        private void ProcessFetchXml()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Executing request...",
                AsyncArgument = txtRequest.Text,
                Work = (bw, e) =>
                {
                    var response = Service.RetrieveMultiple(new FetchExpression(e.Argument.ToString()));

                    e.Result = response;
                },
                PostWorkCallBack = e =>
                {
                    if (e.Error != null)
                    {
                        MessageBox.Show(this, @"An error occured: " + e.Error.Message, @"Error", MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return;
                    }

                    dgvResult.DataSource = GetDataTable((EntityCollection)e.Result);
                    tabControl1.SelectedTab = tabPage2;

                    lblCountResult.Visible = true;
                    lblCountResult.Text = $"Number of rows returned: {((EntityCollection)e.Result).Entities.Count} (More records: {((EntityCollection)e.Result).MoreRecords})";
                }
            });
        }

        private void TsbExecuteClick(object sender, EventArgs e)
        {
            if (txtRequest.Text.Length == 0)
            {
                MessageBox.Show(this, @"Please provide a fetchXml query before trying to execute it!", @"Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExecuteMethod(ProcessFetchXml);
        }

        #endregion Methods

        private void lvQueries_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != currentsColumnOrder)
            {
                currentsColumnOrder = e.Column;
                lvQueries.Sorting = SortOrder.Descending;
            }

            lvQueries.Sorting = lvQueries.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            lvQueries.ListViewItemSorter = new ListViewItemComparer(e.Column, lvQueries.Sorting);

            lvQueries.Sort();
        }

        private void lvQueries_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvQueries.SelectedItems.Count == 0) return;

            txtRequest.Text = ((QueryInfo)lvQueries.SelectedItems[0].Tag).FetchXml;
            txtDescription.Text = ((QueryInfo)lvQueries.SelectedItems[0].Tag).Description;
            ToolStripButton1Click(this, new EventArgs());
            tabControl1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchThread?.Abort();
            searchThread = new Thread(DisplayQueries);
            searchThread.Start(textBox1.Text);
        }

        private void ToolStripButton1Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRequest.Text.Length == 0)
                {
                    MessageBox.Show(this, @"Please provide a valid Xml before trying to format it!", @"Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtRequest.Process(true);
            }
            catch (Exception error)
            {
                MessageBox.Show(this, @"An error occured: " + error.Message, @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tsbAllEnvs_Click(object sender, EventArgs e)
        {
            tsbAllEnvs.Image = tsbAllEnvs.Checked ? Properties.Resources.approved : Properties.Resources._unchecked;
            LoadQueriesHistory();
        }

        private void tsbDeleteQuery_Click(object sender, EventArgs e)
        {
            if (lvQueries.SelectedItems.Count == 0) return;

            ((QueryInfo)lvQueries.SelectedItems[0].Tag).Delete();
            lvQueries.Items.Remove(lvQueries.SelectedItems[0]);
        }

        private void tsbReload_Click(object sender, EventArgs e)
        {
            LoadQueriesHistory();
        }

        private void tsbSaveQuery_Click(object sender, EventArgs e)
        {
            var qi = new QueryInfo(txtRequest.Text);
            qi.Description = txtDescription.Text;
            qi.Save(ConnectionDetail);

            foreach (ListViewItem item in lvQueries.Items)
            {
                QueryInfo i = item.Tag as QueryInfo;
                if (QueryInfo.PrintXML(i.FetchXml) == QueryInfo.PrintXML(qi.FetchXml))
                {
                    i.Delete();
                    break;
                }
            }

            LoadQueriesHistory();
        }

        private void tsbShowFormatted_Click(object sender, EventArgs e)
        {
            tsbShowFormatted.Image = tsbShowFormatted.Checked ? Properties.Resources.approved : Properties.Resources._unchecked;
        }

        private void tsbShowHideQueries_Click(object sender, EventArgs e)
        {
            scMain.Panel2Collapsed = !scMain.Panel2Collapsed;
            scMain.SplitterDistance = scMain.Width - 400;
        }
    }
}
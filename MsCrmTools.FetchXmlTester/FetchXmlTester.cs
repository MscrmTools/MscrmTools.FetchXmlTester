using CSRichTextBoxSyntaxHighlighting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace MsCrmTools.FetchXmlTester
{
    public partial class FetchXmlTester : PluginControlBase
    {
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
            };

            //viewer.Settings = viewerSetting;
        }

        #endregion Constructor

        #region Methods

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
                    dRow[colName] = GetValue(entity.Attributes.Values.ElementAt(i));
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
                }
            });
        }

        private void TsbCloseClick(object sender, EventArgs e)
        {
            CloseTool();
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

        private void ToolStripButton1Click(object sender, EventArgs e)
        {
            try
            {
                if ((tabControl1.SelectedTab.Controls[0]).Text.Length == 0)
                {
                    MessageBox.Show(this, @"Please provide a valid Xml before trying to format it!", @"Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ((XMLViewer)tabControl1.SelectedTab.Controls[0]).Process(true);
            }
            catch (Exception error)
            {
                MessageBox.Show(this, @"An error occured: " + error.Message, @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
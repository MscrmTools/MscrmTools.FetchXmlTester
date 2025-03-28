namespace MsCrmTools.FetchXmlTester
{
    partial class FetchXmlTester
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FetchXmlTester));
            CSRichTextBoxSyntaxHighlighting.XMLViewerSettings xmlViewerSettings1 = new CSRichTextBoxSyntaxHighlighting.XMLViewerSettings();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbExecute = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbShowFormatted = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSaveQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbShowHideQueries = new System.Windows.Forms.ToolStripButton();
            this.toolImageList = new System.Windows.Forms.ImageList(this.components);
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRequest = new CSRichTextBoxSyntaxHighlighting.XMLViewer();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.lblCountResult = new System.Windows.Forms.Label();
            this.gbQueries = new System.Windows.Forms.GroupBox();
            this.lvQueries = new System.Windows.Forms.ListView();
            this.chTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEnv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlRightTop = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tsbLoadQuery = new System.Windows.Forms.ToolStrip();
            this.tsbDeleteQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.tsbAllEnvs = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbDescription.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.gbQueries.SuspendLayout();
            this.pnlRightTop.SuspendLayout();
            this.tsbLoadQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExecute,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.tsbShowFormatted,
            this.toolStripSeparator4,
            this.tsbSaveQuery,
            this.toolStripSeparator1,
            this.tsbShowHideQueries});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1759, 41);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbExecute
            // 
            this.tsbExecute.Image = global::MsCrmTools.FetchXmlTester.Properties.Resources.Connect32;
            this.tsbExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExecute.Name = "tsbExecute";
            this.tsbExecute.Size = new System.Drawing.Size(107, 36);
            this.tsbExecute.Text = "Execute";
            this.tsbExecute.Click += new System.EventHandler(this.TsbExecuteClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::MsCrmTools.FetchXmlTester.Properties.Resources.Development32;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(141, 36);
            this.toolStripButton1.Text = "Format Xml";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
            // 
            // tsbShowFormatted
            // 
            this.tsbShowFormatted.CheckOnClick = true;
            this.tsbShowFormatted.Image = global::MsCrmTools.FetchXmlTester.Properties.Resources._unchecked;
            this.tsbShowFormatted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowFormatted.Name = "tsbShowFormatted";
            this.tsbShowFormatted.Size = new System.Drawing.Size(235, 36);
            this.tsbShowFormatted.Text = "Show Formatted Values";
            this.tsbShowFormatted.Click += new System.EventHandler(this.tsbShowFormatted_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 41);
            // 
            // tsbSaveQuery
            // 
            this.tsbSaveQuery.Image = global::MsCrmTools.FetchXmlTester.Properties.Resources.save;
            this.tsbSaveQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveQuery.Name = "tsbSaveQuery";
            this.tsbSaveQuery.Size = new System.Drawing.Size(85, 36);
            this.tsbSaveQuery.Text = "Save";
            this.tsbSaveQuery.ToolTipText = "Save the current query";
            this.tsbSaveQuery.Click += new System.EventHandler(this.tsbSaveQuery_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // tsbShowHideQueries
            // 
            this.tsbShowHideQueries.Image = global::MsCrmTools.FetchXmlTester.Properties.Resources.Hide32;
            this.tsbShowHideQueries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowHideQueries.Name = "tsbShowHideQueries";
            this.tsbShowHideQueries.Size = new System.Drawing.Size(201, 36);
            this.tsbShowHideQueries.Text = "Show/Hide Queries";
            this.tsbShowHideQueries.Click += new System.EventHandler(this.tsbShowHideQueries_Click);
            // 
            // toolImageList
            // 
            this.toolImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolImageList.ImageStream")));
            this.toolImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.toolImageList.Images.SetKeyName(0, "Icon.png");
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 41);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tabControl1);
            this.scMain.Panel1MinSize = 500;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.gbQueries);
            this.scMain.Size = new System.Drawing.Size(1759, 1055);
            this.scMain.SplitterDistance = 1349;
            this.scMain.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1349, 1055);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRequest);
            this.tabPage1.Controls.Add(this.gbDescription);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1341, 1022);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRequest
            // 
            this.txtRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequest.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequest.Location = new System.Drawing.Point(4, 5);
            this.txtRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRequest.Name = "txtRequest";
            xmlViewerSettings1.AttributeKey = System.Drawing.Color.Red;
            xmlViewerSettings1.AttributeValue = System.Drawing.Color.Blue;
            xmlViewerSettings1.Comment = System.Drawing.Color.Green;
            xmlViewerSettings1.Element = System.Drawing.Color.DarkRed;
            xmlViewerSettings1.Tag = System.Drawing.Color.Blue;
            xmlViewerSettings1.Value = System.Drawing.Color.Black;
            this.txtRequest.Settings = xmlViewerSettings1;
            this.txtRequest.Size = new System.Drawing.Size(1333, 912);
            this.txtRequest.TabIndex = 6;
            this.txtRequest.Text = "<fetch mapping=\"logical\" >\n    <entity name=\"account\" >\n        <attribute name=\"" +
    "name\" />\n    </entity>\n</fetch>";
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.txtDescription);
            this.gbDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDescription.Location = new System.Drawing.Point(4, 917);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(1333, 100);
            this.gbDescription.TabIndex = 5;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(3, 22);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1327, 75);
            this.txtDescription.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvResult);
            this.tabPage2.Controls.Add(this.lblCountResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1341, 1022);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Response";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(4, 45);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 62;
            this.dgvResult.RowTemplate.Height = 28;
            this.dgvResult.Size = new System.Drawing.Size(1333, 972);
            this.dgvResult.TabIndex = 2;
            // 
            // lblCountResult
            // 
            this.lblCountResult.BackColor = System.Drawing.SystemColors.Info;
            this.lblCountResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCountResult.Location = new System.Drawing.Point(4, 5);
            this.lblCountResult.Name = "lblCountResult";
            this.lblCountResult.Size = new System.Drawing.Size(1333, 40);
            this.lblCountResult.TabIndex = 1;
            this.lblCountResult.Text = "X rows were returned";
            this.lblCountResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCountResult.Visible = false;
            // 
            // gbQueries
            // 
            this.gbQueries.Controls.Add(this.lvQueries);
            this.gbQueries.Controls.Add(this.pnlRightTop);
            this.gbQueries.Controls.Add(this.tsbLoadQuery);
            this.gbQueries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQueries.Location = new System.Drawing.Point(0, 0);
            this.gbQueries.Name = "gbQueries";
            this.gbQueries.Size = new System.Drawing.Size(406, 1055);
            this.gbQueries.TabIndex = 0;
            this.gbQueries.TabStop = false;
            this.gbQueries.Text = "Queries";
            // 
            // lvQueries
            // 
            this.lvQueries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTable,
            this.chDate,
            this.chEnv});
            this.lvQueries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvQueries.FullRowSelect = true;
            this.lvQueries.HideSelection = false;
            this.lvQueries.Location = new System.Drawing.Point(3, 93);
            this.lvQueries.Name = "lvQueries";
            this.lvQueries.ShowItemToolTips = true;
            this.lvQueries.Size = new System.Drawing.Size(400, 959);
            this.lvQueries.TabIndex = 4;
            this.lvQueries.UseCompatibleStateImageBehavior = false;
            this.lvQueries.View = System.Windows.Forms.View.Details;
            this.lvQueries.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvQueries_ColumnClick);
            this.lvQueries.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvQueries_MouseDoubleClick);
            // 
            // chTable
            // 
            this.chTable.Text = "Table";
            this.chTable.Width = 100;
            // 
            // chDate
            // 
            this.chDate.Text = "Date";
            this.chDate.Width = 120;
            // 
            // chEnv
            // 
            this.chEnv.Text = "Environment";
            this.chEnv.Width = 150;
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.Controls.Add(this.textBox1);
            this.pnlRightTop.Controls.Add(this.lblSearch);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(3, 63);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(400, 30);
            this.pnlRightTop.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(83, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearch.Location = new System.Drawing.Point(0, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(83, 30);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbLoadQuery
            // 
            this.tsbLoadQuery.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsbLoadQuery.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDeleteQuery,
            this.toolStripSeparator3,
            this.tsbReload,
            this.tsbAllEnvs});
            this.tsbLoadQuery.Location = new System.Drawing.Point(3, 22);
            this.tsbLoadQuery.Name = "tsbLoadQuery";
            this.tsbLoadQuery.Size = new System.Drawing.Size(400, 41);
            this.tsbLoadQuery.TabIndex = 1;
            this.tsbLoadQuery.Text = "toolStrip1";
            // 
            // tsbDeleteQuery
            // 
            this.tsbDeleteQuery.Image = global::MsCrmTools.FetchXmlTester.Properties.Resources.delete;
            this.tsbDeleteQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteQuery.Name = "tsbDeleteQuery";
            this.tsbDeleteQuery.Size = new System.Drawing.Size(98, 36);
            this.tsbDeleteQuery.Text = "Delete";
            this.tsbDeleteQuery.Click += new System.EventHandler(this.tsbDeleteQuery_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 41);
            // 
            // tsbReload
            // 
            this.tsbReload.Image = global::MsCrmTools.FetchXmlTester.Properties.Resources.Restart;
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(102, 36);
            this.tsbReload.Text = "Reload";
            this.tsbReload.Click += new System.EventHandler(this.tsbReload_Click);
            // 
            // tsbAllEnvs
            // 
            this.tsbAllEnvs.CheckOnClick = true;
            this.tsbAllEnvs.Image = global::MsCrmTools.FetchXmlTester.Properties.Resources._unchecked;
            this.tsbAllEnvs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAllEnvs.Name = "tsbAllEnvs";
            this.tsbAllEnvs.Size = new System.Drawing.Size(113, 36);
            this.tsbAllEnvs.Text = "All Envs.";
            this.tsbAllEnvs.ToolTipText = "Load all environments queries (not only the ones related to the current connectio" +
    "n)";
            this.tsbAllEnvs.Click += new System.EventHandler(this.tsbAllEnvs_Click);
            // 
            // FetchXmlTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FetchXmlTester";
            this.Size = new System.Drawing.Size(1759, 1096);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbDescription.ResumeLayout(false);
            this.gbDescription.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.gbQueries.ResumeLayout(false);
            this.gbQueries.PerformLayout();
            this.pnlRightTop.ResumeLayout(false);
            this.pnlRightTop.PerformLayout();
            this.tsbLoadQuery.ResumeLayout(false);
            this.tsbLoadQuery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ImageList toolImageList;
        private System.Windows.Forms.ToolStripButton tsbExecute;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.GroupBox gbQueries;
        private System.Windows.Forms.ToolStrip tsbLoadQuery;
        private System.Windows.Forms.ToolStripButton tsbDeleteQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbShowHideQueries;
        private System.Windows.Forms.ToolStripButton tsbShowFormatted;
        private System.Windows.Forms.ListView lvQueries;
        private System.Windows.Forms.ColumnHeader chTable;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chEnv;
        private System.Windows.Forms.Panel pnlRightTop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolStripButton tsbAllEnvs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label lblCountResult;
        private System.Windows.Forms.ToolStripButton tsbSaveQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private CSRichTextBoxSyntaxHighlighting.XMLViewer txtRequest;
        private System.Windows.Forms.GroupBox gbDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

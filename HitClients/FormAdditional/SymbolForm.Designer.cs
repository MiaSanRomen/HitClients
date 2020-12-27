namespace HitClients.FormControls
{
    partial class SymbolForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnETH = new System.Windows.Forms.ToolStripButton();
            this.btnBTC = new System.Windows.Forms.ToolStripButton();
            this.btnUSDT = new System.Windows.Forms.ToolStripButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.listView = new BrightIdeasSoftware.FastObjectListView();
            this.NameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ChangeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCreateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReload,
            this.toolStripSeparator1,
            this.btnETH,
            this.btnBTC,
            this.btnUSDT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = global::HitClients.Properties.Resources.arrow_refresh;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(23, 22);
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnETH
            // 
            this.btnETH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnETH.Image = global::HitClients.Properties.Resources.ETH16;
            this.btnETH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnETH.Name = "btnETH";
            this.btnETH.Size = new System.Drawing.Size(23, 22);
            this.btnETH.Text = "ETH";
            this.btnETH.Click += new System.EventHandler(this.btnETH_Click);
            // 
            // btnBTC
            // 
            this.btnBTC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBTC.Image = global::HitClients.Properties.Resources.BTC16;
            this.btnBTC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBTC.Name = "btnBTC";
            this.btnBTC.Size = new System.Drawing.Size(23, 22);
            this.btnBTC.Text = "BTC";
            this.btnBTC.Click += new System.EventHandler(this.btnBTC_Click);
            // 
            // btnUSDT
            // 
            this.btnUSDT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUSDT.Image = global::HitClients.Properties.Resources.usdt16;
            this.btnUSDT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUSDT.Name = "btnUSDT";
            this.btnUSDT.Size = new System.Drawing.Size(23, 22);
            this.btnUSDT.Text = "USDT";
            this.btnUSDT.Click += new System.EventHandler(this.btnUSDT_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timerTickers_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.NameColumn);
            this.listView.AllColumns.Add(this.PriceColumn);
            this.listView.AllColumns.Add(this.ChangeColumn);
            this.listView.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.PriceColumn,
            this.ChangeColumn});
            this.listView.ContextMenuStrip = this.contextMenuStrip;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(0, 25);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(284, 236);
            this.listView.TabIndex = 2;
            this.listView.UseAlternatingBackColors = true;
            this.listView.UseCellFormatEvents = true;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.VirtualMode = true;
            this.listView.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.listView_FormatCell);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // NameColumn
            // 
            this.NameColumn.CellPadding = null;
            this.NameColumn.Text = "Symbol";
            this.NameColumn.Width = 100;
            // 
            // PriceColumn
            // 
            this.PriceColumn.CellPadding = null;
            this.PriceColumn.Text = "Price";
            this.PriceColumn.Width = 100;
            // 
            // ChangeColumn
            // 
            this.ChangeColumn.CellPadding = null;
            this.ChangeColumn.FillsFreeSpace = true;
            this.ChangeColumn.Text = "Change";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreateOrder});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(140, 26);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // miCreateOrder
            // 
            this.miCreateOrder.Image = global::HitClients.Properties.Resources.lightning_add;
            this.miCreateOrder.Name = "miCreateOrder";
            this.miCreateOrder.Size = new System.Drawing.Size(139, 22);
            this.miCreateOrder.Text = "Create order";
            this.miCreateOrder.Click += new System.EventHandler(this.miCreateOrder_Click);
            // 
            // SymbolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SymbolForm";
            this.Text = "Symbols";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SymbolForm_FormClosed);
            this.Load += new System.EventHandler(this.SymbolControl_Load);
            this.Shown += new System.EventHandler(this.SymbolForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.Timer timer;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private BrightIdeasSoftware.FastObjectListView listView;
        private BrightIdeasSoftware.OLVColumn NameColumn;
        private BrightIdeasSoftware.OLVColumn PriceColumn;
        private BrightIdeasSoftware.OLVColumn ChangeColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnETH;
        private System.Windows.Forms.ToolStripButton btnBTC;
        private System.Windows.Forms.ToolStripButton btnUSDT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem miCreateOrder;
    }
}

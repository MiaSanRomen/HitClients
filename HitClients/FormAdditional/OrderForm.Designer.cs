namespace HitClients.FormControls
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.listView = new BrightIdeasSoftware.FastObjectListView();
            this.CancelColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TimeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SideColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AmountColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(251, 25);
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
            // listView
            // 
            this.listView.AllColumns.Add(this.CancelColumn);
            this.listView.AllColumns.Add(this.TimeColumn);
            this.listView.AllColumns.Add(this.NameColumn);
            this.listView.AllColumns.Add(this.SideColumn);
            this.listView.AllColumns.Add(this.PriceColumn);
            this.listView.AllColumns.Add(this.AmountColumn);
            this.listView.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CancelColumn,
            this.TimeColumn,
            this.NameColumn,
            this.SideColumn,
            this.PriceColumn,
            this.AmountColumn});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(0, 25);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(251, 236);
            this.listView.SmallImageList = this.ImgList;
            this.listView.TabIndex = 3;
            this.listView.UseAlternatingBackColors = true;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.VirtualMode = true;
            this.listView.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.listView_CellClick);
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // CancelColumn
            // 
            this.CancelColumn.CellPadding = null;
            this.CancelColumn.Text = "";
            this.CancelColumn.Width = 25;
            // 
            // TimeColumn
            // 
            this.TimeColumn.CellPadding = null;
            this.TimeColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeColumn.Text = "Time";
            this.TimeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeColumn.Width = 100;
            // 
            // NameColumn
            // 
            this.NameColumn.CellPadding = null;
            this.NameColumn.Text = "Symbol";
            this.NameColumn.Width = 64;
            // 
            // SideColumn
            // 
            this.SideColumn.CellPadding = null;
            this.SideColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SideColumn.Text = "Side";
            this.SideColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SideColumn.Width = 61;
            // 
            // PriceColumn
            // 
            this.PriceColumn.CellPadding = null;
            this.PriceColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PriceColumn.Text = "Price";
            this.PriceColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AmountColumn
            // 
            this.AmountColumn.CellPadding = null;
            this.AmountColumn.FillsFreeSpace = true;
            this.AmountColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountColumn.Text = "Amount";
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "cross-circle.png");
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 261);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OrderForm";
            this.Text = "Orders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SymbolForm_FormClosed);
            this.Shown += new System.EventHandler(this.SymbolForm_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnReload;
        private BrightIdeasSoftware.FastObjectListView listView;
        private BrightIdeasSoftware.OLVColumn NameColumn;
        private BrightIdeasSoftware.OLVColumn SideColumn;
        private BrightIdeasSoftware.OLVColumn PriceColumn;
        private BrightIdeasSoftware.OLVColumn TimeColumn;
        private BrightIdeasSoftware.OLVColumn AmountColumn;
        private System.Windows.Forms.Timer timer;
        private BrightIdeasSoftware.OLVColumn CancelColumn;
        private System.Windows.Forms.ImageList ImgList;
    }
}

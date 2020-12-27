namespace HitClients.FormControls
{
    partial class HistoryForm
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
            this.tsReload = new System.Windows.Forms.ToolStripButton();
            this.listView = new BrightIdeasSoftware.FastObjectListView();
            this.TimeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.NameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SideColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PriceColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AmountColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsReload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(288, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsReload
            // 
            this.tsReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsReload.Image = global::HitClients.Properties.Resources.arrow_refresh;
            this.tsReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReload.Name = "tsReload";
            this.tsReload.Size = new System.Drawing.Size(23, 22);
            this.tsReload.Text = "Reload";
            this.tsReload.Click += new System.EventHandler(this.tsReload_Click);
            // 
            // listView
            // 
            this.listView.AllColumns.Add(this.TimeColumn);
            this.listView.AllColumns.Add(this.NameColumn);
            this.listView.AllColumns.Add(this.SideColumn);
            this.listView.AllColumns.Add(this.PriceColumn);
            this.listView.AllColumns.Add(this.AmountColumn);
            this.listView.AllColumns.Add(this.olvColumn1);
            this.listView.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeColumn,
            this.NameColumn,
            this.SideColumn,
            this.PriceColumn,
            this.AmountColumn,
            this.olvColumn1});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(0, 25);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(288, 236);
            this.listView.TabIndex = 4;
            this.listView.UseAlternatingBackColors = true;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.VirtualMode = true;
            // 
            // TimeColumn
            // 
            this.TimeColumn.CellPadding = null;
            this.TimeColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeColumn.Text = "Time";
            this.TimeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeColumn.Width = 130;
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
            this.AmountColumn.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountColumn.Text = "Amount";
            this.AmountColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AmountColumn.Width = 80;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.CellPadding = null;
            this.olvColumn1.FillsFreeSpace = true;
            this.olvColumn1.Text = "";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 261);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "HistoryForm";
            this.Text = "Trades";
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
        private System.Windows.Forms.ToolStripButton tsReload;
        private BrightIdeasSoftware.FastObjectListView listView;
        private BrightIdeasSoftware.OLVColumn TimeColumn;
        private BrightIdeasSoftware.OLVColumn NameColumn;
        private BrightIdeasSoftware.OLVColumn SideColumn;
        private BrightIdeasSoftware.OLVColumn PriceColumn;
        private BrightIdeasSoftware.OLVColumn AmountColumn;
        private System.Windows.Forms.Timer timer;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
    }
}

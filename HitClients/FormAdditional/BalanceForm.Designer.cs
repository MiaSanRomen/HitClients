namespace HitClients.FormControls
{
    partial class BalanceForm
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
            this.tsBalance = new System.Windows.Forms.ToolStrip();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.listView = new BrightIdeasSoftware.FastObjectListView();
            this.CurrencyColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AvailiableColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tsBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // tsBalance
            // 
            this.tsBalance.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBalance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReload});
            this.tsBalance.Location = new System.Drawing.Point(0, 0);
            this.tsBalance.Name = "tsBalance";
            this.tsBalance.Size = new System.Drawing.Size(284, 25);
            this.tsBalance.TabIndex = 0;
            this.tsBalance.Text = "toolStrip1";
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
            this.listView.AllColumns.Add(this.CurrencyColumn);
            this.listView.AllColumns.Add(this.AvailiableColumn);
            this.listView.AlternateRowBackColor = System.Drawing.Color.WhiteSmoke;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CurrencyColumn,
            this.AvailiableColumn});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Location = new System.Drawing.Point(0, 25);
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(284, 236);
            this.listView.TabIndex = 3;
            this.listView.UseAlternatingBackColors = true;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.VirtualMode = true;
            this.listView.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.listView_FormatRow);
            // 
            // CurrencyColumn
            // 
            this.CurrencyColumn.CellPadding = null;
            this.CurrencyColumn.Text = "Currency";
            this.CurrencyColumn.Width = 100;
            // 
            // AvailiableColumn
            // 
            this.AvailiableColumn.CellPadding = null;
            this.AvailiableColumn.FillsFreeSpace = true;
            this.AvailiableColumn.Text = "Availiable";
            this.AvailiableColumn.Width = 100;
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tsBalance);
            this.Name = "BalanceForm";
            this.Text = "Balance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SymbolForm_FormClosed);
            this.Load += new System.EventHandler(this.BalanceForm_Load);
            this.Shown += new System.EventHandler(this.SymbolForm_Shown);
            this.tsBalance.ResumeLayout(false);
            this.tsBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBalance;
        private System.Windows.Forms.ToolStripButton btnReload;
        private BrightIdeasSoftware.FastObjectListView listView;
        private BrightIdeasSoftware.OLVColumn CurrencyColumn;
        private BrightIdeasSoftware.OLVColumn AvailiableColumn;
        private System.Windows.Forms.Timer timer;
    }
}

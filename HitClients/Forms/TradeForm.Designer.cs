namespace HitClients.Forms
{
    partial class TradeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradeForm));
            this.nmAmount = new System.Windows.Forms.NumericUpDown();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSymbols = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nmAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nmAmount
            // 
            this.nmAmount.DecimalPlaces = 2;
            this.nmAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nmAmount.Location = new System.Drawing.Point(111, 86);
            this.nmAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmAmount.Name = "nmAmount";
            this.nmAmount.Size = new System.Drawing.Size(70, 20);
            this.nmAmount.TabIndex = 0;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(111, 59);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // nmPrice
            // 
            this.nmPrice.Location = new System.Drawing.Point(111, 112);
            this.nmPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(70, 20);
            this.nmPrice.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(21, 152);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(97, 23);
            this.btnBuy.TabIndex = 6;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(138, 152);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(94, 23);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Symbol:";
            // 
            // cbSymbols
            // 
            this.cbSymbols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSymbols.FormattingEnabled = true;
            this.cbSymbols.Location = new System.Drawing.Point(111, 28);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(121, 21);
            this.cbSymbols.TabIndex = 9;
            this.cbSymbols.SelectedIndexChanged += new System.EventHandler(this.cbSymbols_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 191);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(252, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // TradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 213);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbSymbols);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmPrice);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.nmAmount);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Float;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create order";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TradeForm_Load);
            this.Shown += new System.EventHandler(this.TradeForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nmAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmAmount;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSymbols;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
    }
}
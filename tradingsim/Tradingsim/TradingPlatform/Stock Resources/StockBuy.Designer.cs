namespace TradingPlatform
{
    partial class StockBuy
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
            this.Symboltxt = new System.Windows.Forms.TextBox();
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.Stocktxt = new System.Windows.Forms.TextBox();
            this.Buybtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getpricebtn = new System.Windows.Forms.Button();
            this.SellStockbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Symboltxt
            // 
            this.Symboltxt.Location = new System.Drawing.Point(18, 94);
            this.Symboltxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Symboltxt.Name = "Symboltxt";
            this.Symboltxt.Size = new System.Drawing.Size(136, 26);
            this.Symboltxt.TabIndex = 0;
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(18, 195);
            this.Pricetxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(136, 26);
            this.Pricetxt.TabIndex = 0;
            // 
            // Stocktxt
            // 
            this.Stocktxt.Location = new System.Drawing.Point(244, 94);
            this.Stocktxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Stocktxt.Name = "Stocktxt";
            this.Stocktxt.Size = new System.Drawing.Size(136, 26);
            this.Stocktxt.TabIndex = 0;
            // 
            // Buybtn
            // 
            this.Buybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Buybtn.Location = new System.Drawing.Point(244, 171);
            this.Buybtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Buybtn.Name = "Buybtn";
            this.Buybtn.Size = new System.Drawing.Size(120, 32);
            this.Buybtn.TabIndex = 2;
            this.Buybtn.Text = "Purchase";
            this.Buybtn.UseVisualStyleBackColor = false;
            this.Buybtn.Click += new System.EventHandler(this.Buybtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(240, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the number of stocks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(18, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Price ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock Name";
            // 
            // getpricebtn
            // 
            this.getpricebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getpricebtn.Location = new System.Drawing.Point(22, 134);
            this.getpricebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getpricebtn.Name = "getpricebtn";
            this.getpricebtn.Size = new System.Drawing.Size(112, 35);
            this.getpricebtn.TabIndex = 4;
            this.getpricebtn.Text = "Get Price";
            this.getpricebtn.UseVisualStyleBackColor = false;
            this.getpricebtn.Click += new System.EventHandler(this.Getpricebtn_Click);
            // 
            // SellStockbtn
            // 
            this.SellStockbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SellStockbtn.Location = new System.Drawing.Point(244, 212);
            this.SellStockbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellStockbtn.Name = "SellStockbtn";
            this.SellStockbtn.Size = new System.Drawing.Size(120, 32);
            this.SellStockbtn.TabIndex = 5;
            this.SellStockbtn.Text = "Sell";
            this.SellStockbtn.UseVisualStyleBackColor = false;
            this.SellStockbtn.Click += new System.EventHandler(this.SellStockbtn_Click);
            // 
            // StockBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(506, 328);
            this.Controls.Add(this.SellStockbtn);
            this.Controls.Add(this.getpricebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buybtn);
            this.Controls.Add(this.Stocktxt);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.Symboltxt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockBuy";
            this.Text = "StockBuy";
            this.Load += new System.EventHandler(this.StockBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Symboltxt;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.TextBox Stocktxt;
        private System.Windows.Forms.Button Buybtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getpricebtn;
        private System.Windows.Forms.Button SellStockbtn;
    }
}
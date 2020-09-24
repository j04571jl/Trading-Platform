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
            this.components = new System.ComponentModel.Container();
            this.Symboltxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Pricetxt = new System.Windows.Forms.TextBox();
            this.Stocktxt = new System.Windows.Forms.TextBox();
            this.Buybtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getpricebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Symboltxt
            // 
            this.Symboltxt.Location = new System.Drawing.Point(12, 61);
            this.Symboltxt.Name = "Symboltxt";
            this.Symboltxt.Size = new System.Drawing.Size(92, 20);
            this.Symboltxt.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Pricetxt
            // 
            this.Pricetxt.Location = new System.Drawing.Point(12, 127);
            this.Pricetxt.Name = "Pricetxt";
            this.Pricetxt.Size = new System.Drawing.Size(92, 20);
            this.Pricetxt.TabIndex = 0;
            // 
            // Stocktxt
            // 
            this.Stocktxt.Location = new System.Drawing.Point(163, 61);
            this.Stocktxt.Name = "Stocktxt";
            this.Stocktxt.Size = new System.Drawing.Size(92, 20);
            this.Stocktxt.TabIndex = 0;
            // 
            // Buybtn
            // 
            this.Buybtn.Location = new System.Drawing.Point(175, 146);
            this.Buybtn.Name = "Buybtn";
            this.Buybtn.Size = new System.Drawing.Size(80, 21);
            this.Buybtn.TabIndex = 2;
            this.Buybtn.Text = "Purchase";
            this.Buybtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the number of stocks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Price ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock Name";
            // 
            // getpricebtn
            // 
            this.getpricebtn.Location = new System.Drawing.Point(15, 87);
            this.getpricebtn.Name = "getpricebtn";
            this.getpricebtn.Size = new System.Drawing.Size(75, 23);
            this.getpricebtn.TabIndex = 4;
            this.getpricebtn.Text = "Get Price";
            this.getpricebtn.UseVisualStyleBackColor = true;
            this.getpricebtn.Click += new System.EventHandler(this.getpricebtn_Click);
            // 
            // StockBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 213);
            this.Controls.Add(this.getpricebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buybtn);
            this.Controls.Add(this.Stocktxt);
            this.Controls.Add(this.Pricetxt);
            this.Controls.Add(this.Symboltxt);
            this.Name = "StockBuy";
            this.Text = "StockBuy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Symboltxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Pricetxt;
        private System.Windows.Forms.TextBox Stocktxt;
        private System.Windows.Forms.Button Buybtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getpricebtn;
    }
}
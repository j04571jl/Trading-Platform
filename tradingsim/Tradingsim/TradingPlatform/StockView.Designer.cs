namespace TradingPlatform
{
    partial class StockView
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
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.GetQuotesBtn = new System.Windows.Forms.Button();
            this.ChartImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartImg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(25, 38);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(111, 20);
            this.txtSymbol.TabIndex = 0;
            // 
            // GetQuotesBtn
            // 
            this.GetQuotesBtn.Location = new System.Drawing.Point(142, 38);
            this.GetQuotesBtn.Name = "GetQuotesBtn";
            this.GetQuotesBtn.Size = new System.Drawing.Size(87, 21);
            this.GetQuotesBtn.TabIndex = 2;
            this.GetQuotesBtn.Text = "Get Quote";
            this.GetQuotesBtn.UseVisualStyleBackColor = true;
            // 
            // ChartImg
            // 
            this.ChartImg.Location = new System.Drawing.Point(34, 111);
            this.ChartImg.Name = "ChartImg";
            this.ChartImg.Size = new System.Drawing.Size(484, 286);
            this.ChartImg.TabIndex = 3;
            this.ChartImg.TabStop = false;
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 433);
            this.Controls.Add(this.ChartImg);
            this.Controls.Add(this.GetQuotesBtn);
            this.Controls.Add(this.txtSymbol);
            this.Name = "StockView";
            this.Text = "StockView";
            this.Load += new System.EventHandler(this.StockView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button GetQuotesBtn;
        private System.Windows.Forms.PictureBox ChartImg;
    }
}
namespace TradingPlatform
{
    partial class Deposit
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
            this.Depositbtn = new System.Windows.Forms.Button();
            this.Availabletxt = new System.Windows.Forms.TextBox();
            this.Deposittxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Depositbtn
            // 
            this.Depositbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Depositbtn.Location = new System.Drawing.Point(140, 225);
            this.Depositbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Depositbtn.Name = "Depositbtn";
            this.Depositbtn.Size = new System.Drawing.Size(112, 35);
            this.Depositbtn.TabIndex = 0;
            this.Depositbtn.Text = "DEPOSIT";
            this.Depositbtn.UseVisualStyleBackColor = false;
            this.Depositbtn.Click += new System.EventHandler(this.Depositbtn_Click);
            // 
            // Availabletxt
            // 
            this.Availabletxt.Location = new System.Drawing.Point(134, 43);
            this.Availabletxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Availabletxt.Name = "Availabletxt";
            this.Availabletxt.ReadOnly = true;
            this.Availabletxt.Size = new System.Drawing.Size(148, 26);
            this.Availabletxt.TabIndex = 1;
            // 
            // Deposittxt
            // 
            this.Deposittxt.Location = new System.Drawing.Point(134, 143);
            this.Deposittxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Deposittxt.Name = "Deposittxt";
            this.Deposittxt.Size = new System.Drawing.Size(148, 26);
            this.Deposittxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "AMOUNT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "AVAILABLE";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(343, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deposittxt);
            this.Controls.Add(this.Availabletxt);
            this.Controls.Add(this.Depositbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Depositbtn;
        private System.Windows.Forms.TextBox Availabletxt;
        private System.Windows.Forms.TextBox Deposittxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
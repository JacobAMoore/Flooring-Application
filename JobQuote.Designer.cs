namespace FinalSemesterProject
{
    partial class JobQuote
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
            this.TxtCustomerAddress = new System.Windows.Forms.TextBox();
            this.TxtQuoteAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtCustomerAddress
            // 
            this.TxtCustomerAddress.Location = new System.Drawing.Point(221, 12);
            this.TxtCustomerAddress.Multiline = true;
            this.TxtCustomerAddress.Name = "TxtCustomerAddress";
            this.TxtCustomerAddress.Size = new System.Drawing.Size(272, 164);
            this.TxtCustomerAddress.TabIndex = 0;
            // 
            // TxtQuoteAddress
            // 
            this.TxtQuoteAddress.Location = new System.Drawing.Point(221, 223);
            this.TxtQuoteAddress.Multiline = true;
            this.TxtQuoteAddress.Name = "TxtQuoteAddress";
            this.TxtQuoteAddress.Size = new System.Drawing.Size(272, 164);
            this.TxtQuoteAddress.TabIndex = 1;
            // 
            // JobQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtQuoteAddress);
            this.Controls.Add(this.TxtCustomerAddress);
            this.Name = "JobQuote";
            this.Text = "Job Quote";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtCustomerAddress;
        private TextBox TxtQuoteAddress;
    }
}
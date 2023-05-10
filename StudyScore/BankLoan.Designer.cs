namespace StudyScore
{
    partial class BankLoan
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
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.labLoanAmt = new System.Windows.Forms.Label();
            this.labMaturity = new System.Windows.Forms.Label();
            this.labIntRate = new System.Windows.Forms.Label();
            this.labUpPay = new System.Windows.Forms.Label();
            this.txtLoanAmt = new System.Windows.Forms.TextBox();
            this.txtMaturity = new System.Windows.Forms.TextBox();
            this.txtIntRate = new System.Windows.Forms.TextBox();
            this.txtUpPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(141, 351);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(153, 44);
            this.btnPMT.TabIndex = 0;
            this.btnPMT.Text = "月付金額";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPayment.Location = new System.Drawing.Point(323, 351);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(153, 44);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "總付款";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(588, 351);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(153, 44);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // labLoanAmt
            // 
            this.labLoanAmt.AutoSize = true;
            this.labLoanAmt.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanAmt.Location = new System.Drawing.Point(113, 76);
            this.labLoanAmt.Name = "labLoanAmt";
            this.labLoanAmt.Size = new System.Drawing.Size(127, 36);
            this.labLoanAmt.TabIndex = 3;
            this.labLoanAmt.Text = "貸款金額";
            // 
            // labMaturity
            // 
            this.labMaturity.AutoSize = true;
            this.labMaturity.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMaturity.Location = new System.Drawing.Point(113, 133);
            this.labMaturity.Name = "labMaturity";
            this.labMaturity.Size = new System.Drawing.Size(119, 36);
            this.labMaturity.TabIndex = 4;
            this.labMaturity.Text = "期限(年)";
            // 
            // labIntRate
            // 
            this.labIntRate.AutoSize = true;
            this.labIntRate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labIntRate.Location = new System.Drawing.Point(113, 192);
            this.labIntRate.Name = "labIntRate";
            this.labIntRate.Size = new System.Drawing.Size(116, 36);
            this.labIntRate.TabIndex = 5;
            this.labIntRate.Text = "利率(%)";
            // 
            // labUpPay
            // 
            this.labUpPay.AutoSize = true;
            this.labUpPay.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labUpPay.Location = new System.Drawing.Point(113, 245);
            this.labUpPay.Name = "labUpPay";
            this.labUpPay.Size = new System.Drawing.Size(99, 36);
            this.labUpPay.TabIndex = 6;
            this.labUpPay.Text = "頭期款";
            // 
            // txtLoanAmt
            // 
            this.txtLoanAmt.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanAmt.Location = new System.Drawing.Point(269, 73);
            this.txtLoanAmt.Name = "txtLoanAmt";
            this.txtLoanAmt.Size = new System.Drawing.Size(207, 45);
            this.txtLoanAmt.TabIndex = 7;
            // 
            // txtMaturity
            // 
            this.txtMaturity.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMaturity.Location = new System.Drawing.Point(269, 130);
            this.txtMaturity.Name = "txtMaturity";
            this.txtMaturity.Size = new System.Drawing.Size(207, 45);
            this.txtMaturity.TabIndex = 8;
            // 
            // txtIntRate
            // 
            this.txtIntRate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIntRate.Location = new System.Drawing.Point(269, 186);
            this.txtIntRate.Name = "txtIntRate";
            this.txtIntRate.Size = new System.Drawing.Size(207, 45);
            this.txtIntRate.TabIndex = 9;
            // 
            // txtUpPay
            // 
            this.txtUpPay.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUpPay.Location = new System.Drawing.Point(269, 240);
            this.txtUpPay.Name = "txtUpPay";
            this.txtUpPay.Size = new System.Drawing.Size(207, 45);
            this.txtUpPay.TabIndex = 10;
            // 
            // BankLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUpPay);
            this.Controls.Add(this.txtIntRate);
            this.Controls.Add(this.txtMaturity);
            this.Controls.Add(this.txtLoanAmt);
            this.Controls.Add(this.labUpPay);
            this.Controls.Add(this.labIntRate);
            this.Controls.Add(this.labMaturity);
            this.Controls.Add(this.labLoanAmt);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnPMT);
            this.Name = "BankLoan";
            this.Text = "BankLoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label labLoanAmt;
        private System.Windows.Forms.Label labMaturity;
        private System.Windows.Forms.Label labIntRate;
        private System.Windows.Forms.Label labUpPay;
        private System.Windows.Forms.TextBox txtLoanAmt;
        private System.Windows.Forms.TextBox txtMaturity;
        private System.Windows.Forms.TextBox txtIntRate;
        private System.Windows.Forms.TextBox txtUpPay;
    }
}
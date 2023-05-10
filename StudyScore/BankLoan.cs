using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyScore
{
    public partial class BankLoan : Form
    {

        public BankLoan()
        {
            InitializeComponent();
            txtLoanAmt.Text = "100000";
            txtMaturity.Text = "2";
            txtIntRate.Text = "10%";
            txtUpPay.Text = "0";
        }

        double Amount = 100000;
        int Maturity = 2;
        double Rate = 0.1;
        double Payment = 0; // 頭期款
        
        

        private void btnPMT_Click(object sender, EventArgs e)
        {
            double IntPayment;
            IntPayment = ((Amount - Payment) * (Rate / 12)) / (1 - Math.Pow((1 + Rate / 12), -24));
            //IntPayment = (Amount - Payment) * Math.Pow(( Rate / 12), (Maturity*12));
            String IntResult = $"月付額： {IntPayment}。";
            MessageBox.Show(IntResult);

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            double AmtResult;
            AmtResult = (Amount - Payment) + (Amount - Payment) * (Math.Pow((Rate), (Maturity / 12))); ; //公式: 本利和 = 本金 * (1 + 利率) ^ 期數
            MessageBox.Show("總貸款須繳金額為(含利息)為" + AmtResult + "元整");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            BankReport br = new BankReport();
            br.Show();
        }
    }
}

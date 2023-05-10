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
    public partial class BankReport : Form
    {
        public BankReport()
        {
            InitializeComponent();
            cal();
        }

        int Amount= 100000;
        int Maturity = 2;
        double Rate = 0.1;
        double Payment = 0; // 頭期款
               

        void cal()
        {
            labLoanAmt.Text = "100000";
            labMaturity.Text = "2";
            labIntRat.Text = "10%";
            double IntPayment = IntPayment = ((Amount - Payment) * (Rate / 12)) / (1 - Math.Pow((1 + Rate / 12), -24));
            double AmtResult = (Amount - Payment) + (Amount - Payment)*(Math.Pow((Rate), (Maturity /12)));
            labMthPay.Text = IntPayment.ToString();
            labPayAmt.Text = AmtResult.ToString();

        }


        private void btnEmail_Click(object sender, EventArgs e)
        {

        }

    }
}

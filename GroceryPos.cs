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
    public partial class GroceryPos : Form
    {
        public GroceryPos()
        {
            InitializeComponent();
        }

        int BeerQ = 0;
        int BeerP = 120;
        int TequilaQ = 0;
        int TequilaP = 180;
        int WhiskyQ = 0;
        int WhiskyP = 350;
        int RedWineQ = 0;
        int RedWineP = 320;
        int CalAmount = 0;
        String Display, BeerDisplay, TequilaDisplay, WhiskyDisplay, RedWineDisplay;       
        // string[] List = { "BeerAmt", "TequilaAmt", "WhiskyAmt", "RedWineAmt" };

        void btnBeer_Click(object sender, EventArgs e)
        {
            CalAmount += BeerP; // Beer 啤酒
            ++BeerQ;
            int BeerAmt = BeerP*BeerQ;
            txtTotalPrice.Text = "NTD$" + CalAmount.ToString();
            BeerDisplay = "啤酒 Beer 數量：" + BeerQ + ", 共" + BeerAmt + "元"+Environment.NewLine;
            Display = BeerDisplay + TequilaDisplay + WhiskyDisplay + RedWineDisplay;
            txtList.Text = Display;
            // $"啤酒 Beer 數量： {BeerQ} ,共 {BeerAmt}元\n";              
            
            //if (txtList == null)
            //{
            //    txtList.Text = $"\n啤酒 Beer 數量： {BeerQ} ,共 {BeerAmt}元";
            //}
            //else 
            //{
            //    txtList.Text = Environment.NewLine+ $"\n啤酒 Beer 數量： {BeerQ} ,共 {BeerAmt}元";
            //}
            //txtList.Text += "\n啤酒 Beer x" + BeerQ.ToString() + "共" + BeerAmt.ToString()+ "元";
            //MessageBox.Show("啤酒數量："+BeerQ + "啤酒價格："+(BeerP*BeerQ));
        }

        void btnTequila_Click(object sender, EventArgs e)
        {
            CalAmount += TequilaP; // Tequila 龍舌蘭
            ++TequilaQ;
            int TequilaAmt = TequilaP*TequilaQ;
            txtTotalPrice.Text = "NTD$" + CalAmount.ToString();
            TequilaDisplay = "龍舌蘭 Tequila 數量：" + TequilaQ + ", 共" + TequilaAmt + "元" + Environment.NewLine;
            Display = BeerDisplay + TequilaDisplay + WhiskyDisplay + RedWineDisplay;
            txtList.Text = Display;
            //txtList.Text += "\n龍舌蘭 Tequila x" + TequilaQ.ToString() + "共" + TequilaAmt.ToString() + "元";            
        }

        void btnWhisky_Click(object sender, EventArgs e)
        {
            CalAmount += WhiskyP; // Whisky 威士忌
            ++WhiskyQ;
            int WhiskyAmt = WhiskyP * WhiskyQ;
            txtTotalPrice.Text = "NTD$" + CalAmount.ToString();
            WhiskyDisplay = "威士忌 Whisky 數量：" + WhiskyQ + ", 共" + WhiskyAmt + "元" + Environment.NewLine;
            Display = BeerDisplay + TequilaDisplay + WhiskyDisplay + RedWineDisplay;
            txtList.Text = Display;
            //txtList.Text += "\n威士忌 Whisky x" + WhiskyQ.ToString() + "共" + WhiskyAmt.ToString() + "元";         
        }

        void btnRedWine_Click(object sender, EventArgs e)
        {
            CalAmount += RedWineP; // 紅酒
            ++RedWineQ;
            int RedWineAmt = RedWineP * RedWineQ;
            txtTotalPrice.Text = "NTD$" + CalAmount.ToString();
            RedWineDisplay = "紅酒 Red Wine 數量：" + RedWineQ + ", 共" + RedWineAmt + "元" + Environment.NewLine;
            Display = BeerDisplay + TequilaDisplay + WhiskyDisplay + RedWineDisplay;
            txtList.Text = Display;
            //txtList.Text += "\n紅酒 Red Wine x" + RedWineQ.ToString() + "共" + RedWineAmt.ToString() + "元";            
        }
        
        private void btnCash_Click(object sender, EventArgs e)
        {
            DialogResult CashResult = MessageBox.Show
                ("總金額： NT$" + CalAmount+ "。", "現金付款金額確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CashResult == DialogResult.Yes)
            {
                MessageBox.Show("已結帳 謝謝惠顧!");
                txtTotalPrice.Text = null;
                txtList.Text = "尚未點餐。" ;               
                CalAmount = 0;
                BeerQ = 0;
                TequilaQ = 0;
                RedWineQ = 0;
                WhiskyQ = 0;
                BeerDisplay = null;
                TequilaDisplay = null;
                WhiskyDisplay = null;
                RedWineDisplay = null;
                Display = null;
            }
            else
            {
            
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            this.txtList.Text = "尚未點餐。";
            this.txtTotalPrice.Text = null;
            CalAmount = 0;
            BeerQ = 0;
            TequilaQ = 0;
            RedWineQ = 0;
            WhiskyQ = 0;
            BeerDisplay = null;
            TequilaDisplay = null;
            WhiskyDisplay = null;
            RedWineDisplay = null;
            Display = null;
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            DialogResult CreditResult = MessageBox.Show
                            ("總金額： NT$" + CalAmount*0.9 + "。", "信用卡付款金額確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CreditResult == DialogResult.Yes)
            {
                MessageBox.Show("已結帳 謝謝惠顧!");
                txtTotalPrice.Text = null;
                txtList.Text = "尚未點餐。";               
                CalAmount = 0;
                BeerQ = 0;
                TequilaQ = 0;
                RedWineQ = 0;
                WhiskyQ = 0;
                BeerDisplay = null;
                TequilaDisplay = null;
                WhiskyDisplay = null;
                RedWineDisplay = null;
                Display = null;
            }
            else
            {
            
            }
        }
    }
}

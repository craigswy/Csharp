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
    public partial class StudyScore : Form
    {


        public StudyScore()
        {
            InitializeComponent();
        }
        Score score = new Score();
        int ChiScore;
        int EngScore;
        int MathScore;



        // Score score = new Score(int.Parse(txtChinese), int.Parse(txtEnglish), int.Parse(txtMath));

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnShowSave.Click += new System.EventHandler(btnShowSave_Click); //點下儲存才能觸發顯示儲存成績
        }

        void btnShowSave_Click(object sender, EventArgs e)
        {
            this.btnHighLow.Click += new System.EventHandler(btnHighLow_Click); //點下儲存才能觸發顯示平均成績
            TextBox tb = txtScoreBoard;
            ChiScore = Convert.ToInt32(txtChinese.Text);
            EngScore = Convert.ToInt32(txtEnglish.Text);
            MathScore = Convert.ToInt32(txtMath.Text);
                      
            //TextBox ChiScore = txtChinese; // Bug  
            //TextBox EngScore = txtEnglish;
            //TextBox MathScore = txtMath;

            tb.Text = "姓名：" + txtName.Text
            + Environment.NewLine + "國文：" + ChiScore + "分"
            + Environment.NewLine + "英文：" + EngScore + "分"
            + Environment.NewLine + "數學：" + MathScore + "分";

        }


        void btnHighLow_Click(object sender, EventArgs e)
        {
            //int ChiScore;
            //int EngScore;
            //int MathScore;           
            int MaxScore;
            int MinScore;
            String Display = "";
            MaxScore = Math.Max(ChiScore, Math.Max(EngScore, MathScore));
            MinScore = Math.Min(ChiScore, Math.Min(EngScore, MathScore));
         
            Display = "最高科目成績為" + MaxScore + "分。"
                + Environment.NewLine + "最低科目成績為" + MinScore + "分。";
            txtHighLow.Text = Display;


            //con.Text = Math.Min(ChiScore, EngScore, MathScore);
        }
    }
       
}


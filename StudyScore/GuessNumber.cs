using StudyScore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyScore
{
    public partial class GuessNumber : Form
    {
        public static GuessNumber instance;
        public Label lab1;
        
        public GuessNumber()
        {
            InitializeComponent();
           
            GuessNumberPanel GNP = new GuessNumberPanel();
            instance = this;
                     
            lab1 = lab1to100;
                     

        }            
        //void labShow()
        //{
        //    String Result = "";

        //    GuessNum = int.Parse(InputNum.Text);
        //    GuessNumber ranNum = new GuessNumber();


        //    if (GuessNum > RanNum)
        //    {
        //        GuessNum = MaxNum;
        //        Result = $"Too Big \n Between {MinNum} to {MaxNum}。";
        //    }

        //    else if (GuessNum < RanNum)
        //    {
        //        GuessNum = MinNum;
        //        Result = $"Too Small! \n Between {MinNum} to {MaxNum}。";
        //    }
        //    else if (GuessNum == RanNum)
        //    {
        //        MessageBox.Show("Congradulation! You got the answer :" + RanNum + "。");
        //        return;
        //    }
        //}

        void btnGuess_Click(object sender, EventArgs e)
        {
            GuessNumberPanel guesspanel = new GuessNumberPanel();
            guesspanel.Show();
        }



        void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if (btnGuess.Enabled == true) 
            {
                MessageBox.Show($"答案是 {ranNum}。");
            }
            

        }


    }
}

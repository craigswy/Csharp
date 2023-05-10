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
    public partial class Guess : Form
    {
        public static Guess instance;
        public int ranNum;
        int MaxNum;
        int MinNum;
        public Guess()
        {
            InitializeComponent();
            Guess GS = new Guess();
            instance = this;

            Random random = new Random(); // Make a random number
            ranNum = random.Next(1, 100);
            Answer.instance.RN = ranNum;
        }

        void Showlab()
        {
            String Result = "";
            int GuessNum = Convert.ToInt32(txtInput.Text);


            if (GuessNum > ranNum)
            {
                GuessNum = MaxNum;
                Result = $"Too Big \n Between {MinNum} to {MaxNum}。";
            }

            else if (GuessNum < ranNum)
            {
                GuessNum = MinNum;
                Result = $"Too Small! \n Between {MinNum} to {MaxNum}。";
            }
            else if (GuessNum == ranNum)
            {
                DialogResult.ToString($"Congradulation! You got the answer : + {ranNum} + 。");

            }
            Answer.instance.lab1.Text = Result;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Showlab();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

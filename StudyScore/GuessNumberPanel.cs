using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudyScore
{
    public partial class GuessNumberPanel : Form
    {
        public static GuessNumberPanel instance;
        public int ranNum;
        int MaxNum;
        int MinNum;
        public GuessNumberPanel()        
        {
            InitializeComponent();
            GuessNumber GN = new GuessNumber();
            instance = this;

            Random random = new Random(); // Make a random number
            ranNum = random.Next(1, 100);                



        }
                

        void Showlab() 
        {
            String Result = "" ;
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
                Result = $"Congradulation! You got the answer : + {ranNum} + 。";
                return;
            }
            GuessNumber.instance.lab1 =result;
        }

        


        void btnEnter_Click(object sender, EventArgs e)
        {

        }

    }
}

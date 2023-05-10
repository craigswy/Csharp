using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyScore
{
    
    
    public partial class Answer : Form
    {
        public static Answer instance;
        public Label lab1;
        public int RN;

        public Answer()
        {
            InitializeComponent();
            Answer answer = new Answer();
            instance = this;
            lab1 = lab1to100;
            

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess guess = new Guess();
            guess.Show();
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if (btnGuess.Enabled == false) 
            {
                MessageBox.Show("Press 'Guess' key to start the game!");
            }
            else 
            { 
            MessageBox.Show($"The answer is {RN}。");
            }
        }
    }
}

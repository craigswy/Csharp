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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();            
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            ClientInfo Client = new ClientInfo();
            Client.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(Client);
            Client.Show();

        }

        private void btnBankLoan_Click(object sender, EventArgs e)
        {
            BankLoan bankloan = new BankLoan();
            bankloan.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(bankloan);
            bankloan.Show();
        }

        private void btnGroceryPos_Click(object sender, EventArgs e)
        {
            GroceryPos grocery = new GroceryPos();
            grocery.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(grocery);
            grocery.Show();
        }

        private void btnStudyScore_Click(object sender, EventArgs e)
        {
            StudyScore studyScore = new StudyScore();
            studyScore.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(studyScore);
            studyScore.Show();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(calculator);
            calculator.Show();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            Array array = new Array();
            array.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(array);
            array.Show();
        }

        private void btnForDoWhile_Click(object sender, EventArgs e)
        {
            Array_Plus arrayplus = new Array_Plus();
            arrayplus.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(arrayplus) ;
            arrayplus.Show();
        }

        private void btnOX_Click(object sender, EventArgs e)
        {
            OXGame ox = new OXGame();
            ox.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(ox);
            ox.Show();            
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            ScreenSave screenSave = new ScreenSave(); 
            screenSave.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(screenSave);
            screenSave.Show();
        }

        private void btnDrawing_Click(object sender, EventArgs e)
        {
            Drawing drawing = new Drawing();
            drawing.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(drawing);
            drawing.Show();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Answer answer = new Answer();
            answer.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(answer);
            answer.Show();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Clock clock = new Clock();
            clock.TopLevel = false;
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(clock);
            clock.Show();
        }
    }
}

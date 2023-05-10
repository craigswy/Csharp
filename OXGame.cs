using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyScore
{
    public partial class OXGame : Form
    {
        public OXGame()
        {
            InitializeComponent();            
        }

        
        Button[] btnControls = new Button[9];

        static private int[,] WinCombination = new int[8, 3] //列出雙方可以贏的條件 共8種勝利條件
        {
        {1,2,3},
        {4,5,6},
        {7,8,9},
        {1,4,7},
        {2,5,8},
        {3,6,9},
        {1,5,9},
        {3,5,7},
        };
        int OT1, OT2, OT3, OT4, OT5, OT6, OT7, OT8, OT9;
        int XT1, XT2, XT3, XT4, XT5, XT6, XT7, XT8, XT9;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void OXGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R) 
            {
               GameReset();
            }
            if (e.KeyCode == Keys.Escape) 
            {
                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GameReset();
        }

        int turncount = 0;
        bool Click = true;

        void OWin()
        {
            MessageBox.Show($"O獲勝!");
            GameReset();
        }

        void XWin()
        {
            MessageBox.Show($"X獲勝!");
            GameReset();
        }

        void WinCondition()
        {
            if (OT1 * OT2 * OT3 == 1)
            {
                OWin();
            }
            else if (OT4 * OT5 * OT6 == 1)
            {
                OWin();
            }
            else if (OT7 * OT8 * OT9 == 1)
            {
                OWin();
            }
            else if (OT1 * OT4 * OT7 == 1)
            {
                OWin();
            }
            else if (OT2 * OT5 * OT8 == 1)
            {
                OWin();
            }
            else if (OT3 * OT6 * OT9 == 1)
            {
                OWin();
            }
            else if (OT1 * OT5 * OT9 == 1)
            {
                OWin();
            }
            else if (OT3 * OT5 * OT7 == 1)
            {
                OWin();
            }
            else if (XT1 * XT2 * XT3 == 1)
            {
                XWin();
            }
            else if (XT4 * XT5 * XT6 == 1)
            {
                XWin();
            }
            else if (XT7 * XT8 * XT9 == 1)
            {
                XWin();
            }
            else if (XT1 * XT4 * XT7 == 1)
            {
                XWin();
            }
            else if (XT2 * XT5 * XT8 == 1)
            {
                XWin();
            }
            else if (XT3 * XT6 * XT9 == 1)
            {
                XWin();
            }
            else if (XT1 * XT5 * XT9 == 1)
            {
                XWin();
            }
            else if (XT3 * XT5 * XT7 == 1)
            {
                XWin();
            }
            else if (turncount == 9) 
            {
                MessageBox.Show($"沒輸沒贏! 請重新再戰");
                GameReset();
            }
            
        }

        void GameReset() 
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.Image = null;
            btn2.Image = null;
            btn3.Image = null;
            btn4.Image = null;
            btn5.Image = null;
            btn6.Image = null;
            btn7.Image = null;
            btn8.Image = null;
            btn9.Image = null;
            turncount = 0;
            Click = true;
            OT1 = OT2 = OT3 = OT4 = OT5 = OT6 = OT7 = OT8 = OT9 = 0;
            XT1 = XT2 = XT3 = XT4 = XT5 = XT6 = XT7 = XT8 = XT9 = 0;
        }
               

        

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.Image = Click ? Properties.Resources.O50 : Properties.Resources.X50;
            btn1.Enabled = false;
            Click = !Click;
            if (turncount%2 ==0)
            {
                OT1++;
                turncount++;
                WinCondition();
                
            }
            else
            {
                XT1++;
                turncount++;
                WinCondition();
            }
                        
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.Image = Click ? Properties.Resources.O50 : Properties.Resources.X50;
            btn2.Enabled = false;
            Click = !Click;

            if (turncount % 2 == 0)
            {
                OT2++;
                turncount++;
                WinCondition();
            }
            else
            {
                XT2++;
                turncount++;
                WinCondition();
            }

            //MessageBox.Show($" OT2: {OT2}, XT2: {XT2}");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.Image = Click ? Properties.Resources.O50 : Properties.Resources.X50; 
            btn3.Enabled = false;
            Click = !Click;
            if (turncount % 2 == 0)
            {
                OT3++;
                turncount++;
                WinCondition();

            }
            else
            {
                XT3++;
                turncount++;
                WinCondition();
            }

            //MessageBox.Show($" OT3: {OT3}, XT3: {XT3}");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.Image = Click ? Properties.Resources.O50 : Properties.Resources.X50;
            btn4.Enabled = false;
            Click = !Click;
            if (turncount % 2 == 0)
            {
                OT4++;
                turncount++;
                WinCondition();

            }
            else
            {
                XT4++;
                turncount++;
                WinCondition();
            }
            
            //MessageBox.Show($" OT4: {OT4}, XT4: {XT4}");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.Image = Click ? Properties.Resources.O50 : Properties.Resources.X50;
            btn5.Enabled = false;
            Click = !Click;
            if (turncount % 2 == 0)
            {
                OT5++;
                turncount++;
                WinCondition();
            }
            else
            {
                XT5++;
                turncount++;
                WinCondition();
            }
            
            //MessageBox.Show($" OT5: {OT5}, XT5: {XT5}");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.Image = Click ? Properties.Resources.O50 : Properties.Resources.X50;
            btn6.Enabled = false;
            Click = !Click;
            if (turncount % 2 == 0)
            {
                OT6++;
                turncount++;
                WinCondition();
            }
            else
            {
                XT6++;
                turncount++;
                WinCondition();
            }
            
            //MessageBox.Show($" OT6: {OT6}, XT6: {XT6}");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.Image = Click ? Properties.Resources.O50 : Properties.Resources.X50;
            btn7.Enabled = false;
            Click = !Click;
            if (turncount % 2 == 0)
            {
                OT7++;
                turncount++;
                WinCondition();
            }
            else
            {
                XT7++;
                turncount++;
                WinCondition();
            }
            
            //MessageBox.Show($" OT7: {OT7}, XT7: {XT7}");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.Image = Click ? Properties.Resources.O50 : Properties.Resources.X50;
            btn8.Enabled = false;
            Click = !Click;
            if (turncount % 2 == 0)
            {
                OT8++;
                turncount++;
                WinCondition();
            }
            else
            {
                XT8++;
                turncount++;
                WinCondition();
            }
            
            //MessageBox.Show($" OT8: {OT8}, XT8: {XT8}");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.Image = Click ? Properties.Resources.O50 : Properties.Resources.X50;
            btn9.Enabled = false;
            Click = !Click;
            if (turncount % 2 == 0)
            {
                OT9++;
                turncount++;
                WinCondition();
            }
            else
            {
                XT9++;
                turncount++;
                WinCondition();
            }
            
            //MessageBox.Show($" OT9: {OT9}, XT9: {XT9}");
        }
    }
}

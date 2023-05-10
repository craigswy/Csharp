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
    public partial class ScreenSave : Form
    {
        public ScreenSave()
        {
            InitializeComponent();
            timer1.Start();
        }

        int SizeWidth = 10;
        int SizeHeight = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnPic.Left += SizeWidth;
            btnPic.Top += SizeHeight;
            if (btnPic.Location.X + btnPic.Width > Screen.PrimaryScreen.Bounds.Width || btnPic.Location.X < 0)
            {
                SizeWidth *= -1;
            }
            if (btnPic.Location.Y + btnPic.Height > Screen.PrimaryScreen.Bounds.Height || btnPic.Location.Y < 0)
            {
                SizeHeight *= -1;
            }
        }

        private void ScreenSave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

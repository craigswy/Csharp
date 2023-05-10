using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyScore
{
    public partial class ScreenSaver : Form
    {               
        
        int SizeWidth = 10;
        int SizeHeight = 10;


        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //Background = Color.Black;
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            btnPic.Left += SizeWidth;
            btnPic.Top += SizeHeight;
            if (btnPic.Location.X + btnPic.Width > Screen.PrimaryScreen.Bounds.Width || btnPic.Location.X < 0) 
            {
                SizeWidth *= -1;
            }
            if (btnPic.Location.Y + btnPic.Width > Screen.PrimaryScreen.Bounds.Height || btnPic.Location.Y < 0)
            {
                SizeHeight *= -1;
            }
        }                  

        private void ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}

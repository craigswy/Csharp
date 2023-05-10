using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace StudyScore
{
    public partial class Drawing : Form
    {
        private Pen pen;
        bool drawing;
        private Point prevPoint;
        private Graphics g;
        private Bitmap bmp;

        public Drawing()
        {
            InitializeComponent();
            //picDrawing.Image = new Bitmap(800, 600);
            //Graphics g = Graphics.FromImage(picDrawing.Image);
            bmp = new Bitmap(picDrawing.Width, picDrawing.Height);
            pen = new Pen(Color.Black, 1);
            //g.Clear(Color.White);
            PicboxColor.BackColor = Color.Black;
        }

        //void PenChange() 
        //{
        //    ColorDialog dialog = new ColorDialog();
        //    Pen newpen = new Pen(dialog.Color); 
        //    newpen.Color = dialog.Color;
        //}

        int x0, y0;


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
            //x0 = e.X;
            //y0 = e.Y;
            drawing = true;
            //Graphics g = Graphics.FromImage(picDrawing.Image);
            //g.DrawLine(Pens.Black, x0, y0, e.X, e.Y);
        }

        private void picDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            //dialog.ShowDialog();
            //Pen newpen = new Pen(dialog.Color);
            //newpen.Color = dialog.Color;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = dialog.Color;
            }
            PicboxColor.BackColor = dialog.Color;
        }

        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing) 
            {
                //switch (picDrawing.ContextMenu)
                //{
                //    case 0:
                //        g.DrawLine(pen, prevPoint, e.Location);
                //        prevPoint = e.Location;
                //        break;
                //    case 1:
                //        g.DrawRectangle(pen, Math.Min(prevPoint.X, e.X), Math.Min(prevPoint.Y, e.Y), Math.Abs(prevPoint.X - e.X), Math.Abs(prevPoint.Y - e.Y));
                //        break;
                //    case 2:
                //        g.DrawEllipse(pen, Math.Min(prevPoint.X, e.X), Math.Min(prevPoint.Y, e.Y), Math.Abs(prevPoint.X - e.X), Math.Abs(prevPoint.Y - e.Y));
                //        break;
                //    case 3:
                //        g.DrawLine(pen, prevPoint, e.Location);
                //        break;
                //    case 4:
                //        g.DrawLine(new Pen(picDrawing.BackColor, pen.Width), prevPoint, e.Location);
                //        prevPoint = e.Location;
                //        break;
                //    default:
                //        break;
                //}
                picDrawing.Image = bmp;
            }
        }

        private void BarWidth_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (float)BarWidth.Value;
        }

        //ColorDialog dialog = new ColorDialog();
        //Pen newpen = new Pen(dialog.Color);
        //newpen.Color = dialog.Color;            

        //if (e.Button == MouseButtons.Left) 
        //{
        //    Graphics g = Graphics.FromImage(picDrawing.Image);
        //    g.DrawLine(Pens.Black, x0, y0, e.X, e.Y);
        //    pen.Color = dialog.Color;

        //    PicboxColor.BackColor = dialog.Color;
        //    x0 = e.X;
        //    y0 = e.Y;
        //    picDrawing.Refresh();

        //}

    }

        //private void BarWidth_Scroll(object sender, EventArgs e)
        //{
        //    int value = BarWidth.Value;
        //    pen.Width = value;
        //}

        
    
}

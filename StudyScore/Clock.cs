using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace StudyScore
{
    public partial class Clock : Form
    {
        private System.Timers.Timer timer;
        private DateTime alarmTime;
        private bool alarmSet;
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            labTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        public Clock()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 100;
            timer1.Enabled = true;
            //初始化 ComboBox 的選項
            for (int i = 0; i < 24; i++)
            {
                cbHH.Items.Add(i.ToString().PadLeft(2, '0'));
            }
            for (int i = 0; i < 60; i++)
            {
                cbMM.Items.Add(i.ToString().PadLeft(2, '0'));
                cbSS.Items.Add(i.ToString().PadLeft(2, '0'));
            }

        }

        //void AlarmTime() 
        //{
        //    int HH = int.Parse(cbHH.Text);
        //    int MM = int.Parse(cbMM.Text);
        //    int SS = int.Parse(cbSS.Text);

        //    if (HH > 12)
        //    {
        //        if (alarmSet && DateTime.Now.Hour == (HH - 12) && DateTime.Now.Minute == MM && DateTime.Now.Second == SS)
        //        {
        //            MessageBox.Show("時間到了！");
        //            alarmSet = false;
        //        }
        //    }
        //    else if (alarmSet && DateTime.Now.Hour == HH && DateTime.Now.Minute == MM && DateTime.Now.Second == SS)
        //        {
        //            MessageBox.Show("時間到了！");
        //            alarmSet = false;
        //        }
        //}
        

        private DateTimePicker timePicker;

        
        

        private void InitializeTimePicker()
        {
            //timePicker = new DateTimePicker();
            //timePicker.Format = DateTimePickerFormat.Time;
            //dateTimePicker1.CustomFormat = "hh:mm:ss tt";
            //timePicker.ShowUpDown = false;
            //timePicker.Location = new Point(10, 10);
            //timePicker.Width = 100;
            //Controls.Add(timePicker);
        }


        private void cbSetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            alarmSet = true;
            int HH = int.Parse(cbHH.Text);
            int MM = int.Parse(cbMM.Text);
            int SS = int.Parse(cbSS.Text);
            int ClockHour = DateTime.Now.Hour;
            int ClockMinute = DateTime.Now.Minute;
            int ClockSecond = DateTime.Now.Second;

            if (HH > 12)
            {
                if (alarmSet = true && ClockHour == HH-12 && ClockMinute == MM && ClockSecond == SS)
                {
                    MessageBox.Show("時間到了！");
                    alarmSet = false;
                }
            }
            if (alarmSet = true && ClockHour == HH && ClockMinute == MM && ClockSecond == SS)
            {
                MessageBox.Show("時間到了！");
                alarmSet = false;
            }
            
        }
    }
}

namespace StudyScore
{
    partial class Clock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labTime = new System.Windows.Forms.Label();
            this.labAlarm = new System.Windows.Forms.Label();
            this.cbSetAlarm = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.cbHH = new System.Windows.Forms.ComboBox();
            this.cbMM = new System.Windows.Forms.ComboBox();
            this.cbSS = new System.Windows.Forms.ComboBox();
            this.labH = new System.Windows.Forms.Label();
            this.labM = new System.Windows.Forms.Label();
            this.labS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTime.Location = new System.Drawing.Point(59, 70);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(55, 24);
            this.labTime.TabIndex = 0;
            this.labTime.Text = "Time";
            // 
            // labAlarm
            // 
            this.labAlarm.AutoSize = true;
            this.labAlarm.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAlarm.Location = new System.Drawing.Point(59, 37);
            this.labAlarm.Name = "labAlarm";
            this.labAlarm.Size = new System.Drawing.Size(124, 24);
            this.labAlarm.TabIndex = 2;
            this.labAlarm.Text = "多重宇宙時間";
            // 
            // cbSetAlarm
            // 
            this.cbSetAlarm.AutoSize = true;
            this.cbSetAlarm.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbSetAlarm.Location = new System.Drawing.Point(72, 147);
            this.cbSetAlarm.Name = "cbSetAlarm";
            this.cbSetAlarm.Size = new System.Drawing.Size(103, 25);
            this.cbSetAlarm.TabIndex = 3;
            this.cbSetAlarm.Text = "Set Alarm";
            this.cbSetAlarm.UseVisualStyleBackColor = true;
            this.cbSetAlarm.CheckedChanged += new System.EventHandler(this.cbSetAlarm_CheckedChanged);
            // 
            // cbHH
            // 
            this.cbHH.FormattingEnabled = true;
            this.cbHH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbHH.Location = new System.Drawing.Point(42, 119);
            this.cbHH.Name = "cbHH";
            this.cbHH.Size = new System.Drawing.Size(39, 20);
            this.cbHH.TabIndex = 5;
            // 
            // cbMM
            // 
            this.cbMM.FormattingEnabled = true;
            this.cbMM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbMM.Location = new System.Drawing.Point(107, 119);
            this.cbMM.Name = "cbMM";
            this.cbMM.Size = new System.Drawing.Size(39, 20);
            this.cbMM.TabIndex = 6;
            // 
            // cbSS
            // 
            this.cbSS.FormattingEnabled = true;
            this.cbSS.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbSS.Location = new System.Drawing.Point(173, 119);
            this.cbSS.Name = "cbSS";
            this.cbSS.Size = new System.Drawing.Size(39, 20);
            this.cbSS.TabIndex = 7;
            // 
            // labH
            // 
            this.labH.AutoSize = true;
            this.labH.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labH.Location = new System.Drawing.Point(19, 122);
            this.labH.Name = "labH";
            this.labH.Size = new System.Drawing.Size(21, 17);
            this.labH.TabIndex = 8;
            this.labH.Text = "時";
            // 
            // labM
            // 
            this.labM.AutoSize = true;
            this.labM.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labM.Location = new System.Drawing.Point(83, 122);
            this.labM.Name = "labM";
            this.labM.Size = new System.Drawing.Size(21, 17);
            this.labM.TabIndex = 9;
            this.labM.Text = "分";
            // 
            // labS
            // 
            this.labS.AutoSize = true;
            this.labS.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labS.Location = new System.Drawing.Point(149, 122);
            this.labS.Name = "labS";
            this.labS.Size = new System.Drawing.Size(21, 17);
            this.labS.TabIndex = 10;
            this.labS.Text = "秒";
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 224);
            this.Controls.Add(this.labS);
            this.Controls.Add(this.labM);
            this.Controls.Add(this.labH);
            this.Controls.Add(this.cbSS);
            this.Controls.Add(this.cbMM);
            this.Controls.Add(this.cbHH);
            this.Controls.Add(this.cbSetAlarm);
            this.Controls.Add(this.labAlarm);
            this.Controls.Add(this.labTime);
            this.Name = "Clock";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label labAlarm;
        private System.Windows.Forms.CheckBox cbSetAlarm;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ComboBox cbHH;
        private System.Windows.Forms.ComboBox cbMM;
        private System.Windows.Forms.ComboBox cbSS;
        private System.Windows.Forms.Label labH;
        private System.Windows.Forms.Label labM;
        private System.Windows.Forms.Label labS;
    }
}
namespace StudyScore
{
    partial class ScreenSaver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSaver));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnPic = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPic
            // 
            this.btnPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPic.BackgroundImage")));
            this.btnPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPic.Location = new System.Drawing.Point(373, 160);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(147, 192);
            this.btnPic.TabIndex = 0;
            this.btnPic.UseVisualStyleBackColor = true;
            // 
            // ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(949, 547);
            this.ControlBox = false;
            this.Controls.Add(this.btnPic);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSaver";
            this.Text = "ScreenSaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.timer1_Tick);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ScreenSaver_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Timer timer3;
    }
}
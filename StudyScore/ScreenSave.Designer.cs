namespace StudyScore
{
    partial class ScreenSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSave));
            this.btnPic = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPic
            // 
            this.btnPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPic.BackgroundImage")));
            this.btnPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPic.FlatAppearance.BorderSize = 0;
            this.btnPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPic.Location = new System.Drawing.Point(212, 93);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(183, 243);
            this.btnPic.TabIndex = 0;
            this.btnPic.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScreenSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenSave";
            this.Text = "ScreenSave";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.ScreenSave_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Timer timer1;
    }
}
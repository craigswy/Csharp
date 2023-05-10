namespace StudyScore
{
    partial class Drawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drawing));
            this.picDrawing = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BarWidth = new System.Windows.Forms.TrackBar();
            this.btnColor = new System.Windows.Forms.Button();
            this.PicboxColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // picDrawing
            // 
            this.picDrawing.Location = new System.Drawing.Point(0, 0);
            this.picDrawing.Margin = new System.Windows.Forms.Padding(2);
            this.picDrawing.Name = "picDrawing";
            this.picDrawing.Size = new System.Drawing.Size(768, 374);
            this.picDrawing.TabIndex = 0;
            this.picDrawing.TabStop = false;
            this.picDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.picDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.picDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDrawing_MouseUp);
            // 
            // BarWidth
            // 
            this.BarWidth.Location = new System.Drawing.Point(700, 107);
            this.BarWidth.Minimum = 1;
            this.BarWidth.Name = "BarWidth";
            this.BarWidth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BarWidth.Size = new System.Drawing.Size(45, 156);
            this.BarWidth.TabIndex = 1;
            this.BarWidth.Value = 1;
            this.BarWidth.ValueChanged += new System.EventHandler(this.BarWidth_ValueChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.Control;
            this.btnColor.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnColor.Location = new System.Drawing.Point(675, 27);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(83, 31);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // PicboxColor
            // 
            this.PicboxColor.Location = new System.Drawing.Point(675, 64);
            this.PicboxColor.Name = "PicboxColor";
            this.PicboxColor.Size = new System.Drawing.Size(83, 45);
            this.PicboxColor.TabIndex = 3;
            this.PicboxColor.TabStop = false;
            // 
            // Drawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(770, 382);
            this.Controls.Add(this.PicboxColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.BarWidth);
            this.Controls.Add(this.picDrawing);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Drawing";
            this.Text = "Drawing";
            ((System.ComponentModel.ISupportInitialize)(this.picDrawing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicboxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDrawing;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar BarWidth;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox PicboxColor;
    }
}
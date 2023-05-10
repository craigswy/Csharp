namespace StudyScore
{
    partial class ClientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfo));
            this.btnSayHi = new System.Windows.Forms.Button();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.comStar = new System.Windows.Forms.ComboBox();
            this.comGender = new System.Windows.Forms.ComboBox();
            this.labStar = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labEngName = new System.Windows.Forms.Label();
            this.txtEngName = new System.Windows.Forms.TextBox();
            this.labCnName = new System.Windows.Forms.Label();
            this.txtChiName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.Color.Transparent;
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.Location = new System.Drawing.Point(302, 227);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(121, 32);
            this.btnSayHi.TabIndex = 21;
            this.btnSayHi.Text = "Say Hi";
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.Color.Transparent;
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.Location = new System.Drawing.Point(165, 227);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(121, 32);
            this.btnSayHello.TabIndex = 20;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // comStar
            // 
            this.comStar.FormattingEnabled = true;
            this.comStar.Items.AddRange(new object[] {
            "牡羊座",
            "金牛座",
            "天蠍座",
            "巨蟹座",
            "雙魚座",
            "處女座",
            "獅子座",
            "射手座",
            "雙子座",
            "魔羯座",
            "水瓶座",
            "天枰座"});
            this.comStar.Location = new System.Drawing.Point(280, 184);
            this.comStar.Name = "comStar";
            this.comStar.Size = new System.Drawing.Size(121, 20);
            this.comStar.TabIndex = 19;
            // 
            // comGender
            // 
            this.comGender.FormattingEnabled = true;
            this.comGender.Items.AddRange(new object[] {
            "男生",
            "女生"});
            this.comGender.Location = new System.Drawing.Point(280, 133);
            this.comGender.Name = "comGender";
            this.comGender.Size = new System.Drawing.Size(121, 20);
            this.comGender.TabIndex = 18;
            // 
            // labStar
            // 
            this.labStar.AutoSize = true;
            this.labStar.BackColor = System.Drawing.Color.Transparent;
            this.labStar.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labStar.Location = new System.Drawing.Point(160, 184);
            this.labStar.Name = "labStar";
            this.labStar.Size = new System.Drawing.Size(48, 24);
            this.labStar.TabIndex = 17;
            this.labStar.Text = "星座";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.BackColor = System.Drawing.Color.Transparent;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labGender.Location = new System.Drawing.Point(160, 129);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(48, 24);
            this.labGender.TabIndex = 16;
            this.labGender.Text = "性別";
            // 
            // labEngName
            // 
            this.labEngName.AutoSize = true;
            this.labEngName.BackColor = System.Drawing.Color.Transparent;
            this.labEngName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEngName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labEngName.Location = new System.Drawing.Point(160, 77);
            this.labEngName.Name = "labEngName";
            this.labEngName.Size = new System.Drawing.Size(86, 24);
            this.labEngName.TabIndex = 15;
            this.labEngName.Text = "英文姓名";
            // 
            // txtEngName
            // 
            this.txtEngName.Location = new System.Drawing.Point(280, 77);
            this.txtEngName.Name = "txtEngName";
            this.txtEngName.Size = new System.Drawing.Size(100, 22);
            this.txtEngName.TabIndex = 14;
            // 
            // labCnName
            // 
            this.labCnName.AutoSize = true;
            this.labCnName.BackColor = System.Drawing.Color.Transparent;
            this.labCnName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCnName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labCnName.Location = new System.Drawing.Point(160, 25);
            this.labCnName.Name = "labCnName";
            this.labCnName.Size = new System.Drawing.Size(86, 24);
            this.labCnName.TabIndex = 13;
            this.labCnName.Text = "中文姓名";
            // 
            // txtChiName
            // 
            this.txtChiName.Location = new System.Drawing.Point(280, 25);
            this.txtChiName.Name = "txtChiName";
            this.txtChiName.Size = new System.Drawing.Size(100, 22);
            this.txtChiName.TabIndex = 12;
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Controls.Add(this.comStar);
            this.Controls.Add(this.comGender);
            this.Controls.Add(this.labStar);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.labEngName);
            this.Controls.Add(this.txtEngName);
            this.Controls.Add(this.labCnName);
            this.Controls.Add(this.txtChiName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientInfo";
            this.Text = "ClientInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHi;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.ComboBox comStar;
        private System.Windows.Forms.ComboBox comGender;
        private System.Windows.Forms.Label labStar;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labEngName;
        private System.Windows.Forms.TextBox txtEngName;
        private System.Windows.Forms.Label labCnName;
        private System.Windows.Forms.TextBox txtChiName;
    }
}
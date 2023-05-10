namespace StudyScore
{
    partial class StudyScore
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowSave = new System.Windows.Forms.Button();
            this.txtScoreBoard = new System.Windows.Forms.TextBox();
            this.txtHighLow = new System.Windows.Forms.TextBox();
            this.btnHighLow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(54, 69);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(54, 26);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名";
            // 
            // labChinese
            // 
            this.labChinese.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(54, 111);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(54, 26);
            this.labChinese.TabIndex = 1;
            this.labChinese.Text = "國文";
            // 
            // labEnglish
            // 
            this.labEnglish.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(54, 153);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(54, 26);
            this.labEnglish.TabIndex = 2;
            this.labEnglish.Text = "英文";
            // 
            // labMath
            // 
            this.labMath.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(54, 199);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(54, 26);
            this.labMath.TabIndex = 3;
            this.labMath.Text = "數學";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(114, 115);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(100, 22);
            this.txtChinese.TabIndex = 5;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(114, 161);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 22);
            this.txtEnglish.TabIndex = 6;
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(114, 203);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(100, 22);
            this.txtMath.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(50, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 52);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowSave
            // 
            this.btnShowSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowSave.Location = new System.Drawing.Point(170, 266);
            this.btnShowSave.Name = "btnShowSave";
            this.btnShowSave.Size = new System.Drawing.Size(99, 52);
            this.btnShowSave.TabIndex = 9;
            this.btnShowSave.Text = "顯示儲存內容";
            this.btnShowSave.UseVisualStyleBackColor = true;
            this.btnShowSave.Click += new System.EventHandler(this.btnShowSave_Click);
            // 
            // txtScoreBoard
            // 
            this.txtScoreBoard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScoreBoard.Location = new System.Drawing.Point(416, 15);
            this.txtScoreBoard.Multiline = true;
            this.txtScoreBoard.Name = "txtScoreBoard";
            this.txtScoreBoard.Size = new System.Drawing.Size(320, 210);
            this.txtScoreBoard.TabIndex = 10;
            // 
            // txtHighLow
            // 
            this.txtHighLow.Location = new System.Drawing.Point(416, 236);
            this.txtHighLow.Multiline = true;
            this.txtHighLow.Name = "txtHighLow";
            this.txtHighLow.Size = new System.Drawing.Size(320, 82);
            this.txtHighLow.TabIndex = 11;
            // 
            // btnHighLow
            // 
            this.btnHighLow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHighLow.Location = new System.Drawing.Point(561, 324);
            this.btnHighLow.Name = "btnHighLow";
            this.btnHighLow.Size = new System.Drawing.Size(175, 52);
            this.btnHighLow.TabIndex = 12;
            this.btnHighLow.Text = "最高分/最低分科目";
            this.btnHighLow.UseVisualStyleBackColor = true;
            this.btnHighLow.Click += new System.EventHandler(this.btnHighLow_Click);
            // 
            // StudyScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHighLow);
            this.Controls.Add(this.txtHighLow);
            this.Controls.Add(this.txtScoreBoard);
            this.Controls.Add(this.btnShowSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labName);
            this.Name = "StudyScore";
            this.Text = "StudyScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowSave;
        private System.Windows.Forms.TextBox txtScoreBoard;
        private System.Windows.Forms.TextBox txtHighLow;
        private System.Windows.Forms.Button btnHighLow;
    }
}


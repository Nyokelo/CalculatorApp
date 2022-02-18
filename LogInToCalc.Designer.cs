namespace CalculatorApp
{
    partial class LogInToCalc
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
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_PassWord = new System.Windows.Forms.Label();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.check_Male = new System.Windows.Forms.CheckBox();
            this.check_Female = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(53, 53);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(56, 13);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "user name";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(169, 289);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(75, 23);
            this.btn_LogIn.TabIndex = 1;
            this.btn_LogIn.Text = "log in";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(305, 288);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 23);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(169, 53);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(176, 20);
            this.txt_UserName.TabIndex = 3;
            // 
            // lbl_PassWord
            // 
            this.lbl_PassWord.AutoSize = true;
            this.lbl_PassWord.Location = new System.Drawing.Point(53, 103);
            this.lbl_PassWord.Name = "lbl_PassWord";
            this.lbl_PassWord.Size = new System.Drawing.Size(52, 13);
            this.lbl_PassWord.TabIndex = 4;
            this.lbl_PassWord.Text = "password";
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(169, 96);
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.PasswordChar = '.';
            this.txt_PassWord.Size = new System.Drawing.Size(176, 20);
            this.txt_PassWord.TabIndex = 5;
            // 
            // check_Male
            // 
            this.check_Male.AutoSize = true;
            this.check_Male.Location = new System.Drawing.Point(56, 159);
            this.check_Male.Name = "check_Male";
            this.check_Male.Size = new System.Drawing.Size(48, 17);
            this.check_Male.TabIndex = 6;
            this.check_Male.Text = "male";
            this.check_Male.UseVisualStyleBackColor = true;
            this.check_Male.CheckedChanged += new System.EventHandler(this.check_Male_CheckedChanged);
            // 
            // check_Female
            // 
            this.check_Female.AutoSize = true;
            this.check_Female.Location = new System.Drawing.Point(56, 193);
            this.check_Female.Name = "check_Female";
            this.check_Female.Size = new System.Drawing.Size(57, 17);
            this.check_Female.TabIndex = 7;
            this.check_Female.Text = "female";
            this.check_Female.UseVisualStyleBackColor = true;
            this.check_Female.CheckedChanged += new System.EventHandler(this.check_Female_CheckedChanged);
            // 
            // LogInToCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.check_Female);
            this.Controls.Add(this.check_Male);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.lbl_PassWord);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.lbl_UserName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInToCalc";
            this.Text = "LogInToCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_PassWord;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.CheckBox check_Male;
        private System.Windows.Forms.CheckBox check_Female;
    }
}
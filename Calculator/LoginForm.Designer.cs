namespace Calculator
{
    partial class LoginForm
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
            this.theLogin = new System.Windows.Forms.Button();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.RememberPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.againLabel = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelAdministrator = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // theLogin
            // 
            this.theLogin.BackColor = System.Drawing.Color.MediumAquamarine;
            this.theLogin.FlatAppearance.BorderSize = 0;
            this.theLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theLogin.Font = new System.Drawing.Font("宋体", 12F);
            this.theLogin.Location = new System.Drawing.Point(162, 258);
            this.theLogin.Name = "theLogin";
            this.theLogin.Size = new System.Drawing.Size(90, 35);
            this.theLogin.TabIndex = 0;
            this.theLogin.Text = "登录";
            this.theLogin.UseVisualStyleBackColor = false;
            this.theLogin.Click += new System.EventHandler(this.TheLogin_Click);
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.BackColor = System.Drawing.Color.White;
            this.labelAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAccount.Font = new System.Drawing.Font("宋体", 15F);
            this.labelAccount.Location = new System.Drawing.Point(78, 115);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(64, 27);
            this.labelAccount.TabIndex = 1;
            this.labelAccount.Text = "账号";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.White;
            this.labelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPassword.Font = new System.Drawing.Font("宋体", 15F);
            this.labelPassword.Location = new System.Drawing.Point(78, 182);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 27);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "密码";
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxAccount.Location = new System.Drawing.Point(162, 115);
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(207, 30);
            this.textBoxAccount.TabIndex = 3;
            this.textBoxAccount.TextChanged += new System.EventHandler(this.textBoxAccount_TextChanged);
            this.textBoxAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAccount_KeyPress);
            this.textBoxAccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAccount_KeyUp);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxPassword.Location = new System.Drawing.Point(162, 182);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(207, 30);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
            this.textBoxPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyUp);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.MediumAquamarine;
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("宋体", 12F);
            this.register.Location = new System.Drawing.Point(258, 258);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(111, 35);
            this.register.TabIndex = 0;
            this.register.Text = "忘记密码";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.forgotPassword_Click);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelErrorMessage.Font = new System.Drawing.Font("宋体", 10F);
            this.labelErrorMessage.Location = new System.Drawing.Point(159, 59);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.labelErrorMessage.TabIndex = 7;
            this.labelErrorMessage.TextChanged += new System.EventHandler(this.labelErrorMessage_TextChanged);
            // 
            // RememberPasswordCheckBox
            // 
            this.RememberPasswordCheckBox.AutoSize = true;
            this.RememberPasswordCheckBox.BackColor = System.Drawing.Color.White;
            this.RememberPasswordCheckBox.Location = new System.Drawing.Point(162, 223);
            this.RememberPasswordCheckBox.Name = "RememberPasswordCheckBox";
            this.RememberPasswordCheckBox.Size = new System.Drawing.Size(89, 19);
            this.RememberPasswordCheckBox.TabIndex = 8;
            this.RememberPasswordCheckBox.Text = "记住密码";
            this.RememberPasswordCheckBox.UseVisualStyleBackColor = false;
            this.RememberPasswordCheckBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.theLogin_KeyDown);
            // 
            // againLabel
            // 
            this.againLabel.AutoSize = true;
            this.againLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.againLabel.Font = new System.Drawing.Font("宋体", 10F);
            this.againLabel.Location = new System.Drawing.Point(159, 86);
            this.againLabel.Name = "againLabel";
            this.againLabel.Size = new System.Drawing.Size(0, 17);
            this.againLabel.TabIndex = 9;
            this.againLabel.TextChanged += new System.EventHandler(this.againLabel_TextChanged);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(335, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 25);
            this.btnMin.TabIndex = 10;
            this.btnMin.TabStop = false;
            this.btnMin.Text = "─";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMax.Enabled = false;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(385, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 25);
            this.btnMax.TabIndex = 11;
            this.btnMax.Text = "□";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(435, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 25);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // labelAdministrator
            // 
            this.labelAdministrator.AutoSize = true;
            this.labelAdministrator.BackColor = System.Drawing.Color.GhostWhite;
            this.labelAdministrator.Font = new System.Drawing.Font("宋体", 15F);
            this.labelAdministrator.Location = new System.Drawing.Point(184, 59);
            this.labelAdministrator.Name = "labelAdministrator";
            this.labelAdministrator.Size = new System.Drawing.Size(0, 25);
            this.labelAdministrator.TabIndex = 13;
            this.labelAdministrator.TextChanged += new System.EventHandler(this.labelAdministrator_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 18F);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(147)))), ((int)(((byte)(88)))));
            this.labelTitle.Location = new System.Drawing.Point(39, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(103, 30);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "计算器";
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelTitle_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::Calculator.Properties.Resources.竹子背景;
            this.ClientSize = new System.Drawing.Size(485, 339);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelAdministrator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.againLabel);
            this.Controls.Add(this.RememberPasswordCheckBox);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAccount);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.register);
            this.Controls.Add(this.theLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "系统管理员登录";
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button theLogin;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.CheckBox RememberPasswordCheckBox;
        private System.Windows.Forms.Label againLabel;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelAdministrator;
        private System.Windows.Forms.Label labelTitle;
    }
}
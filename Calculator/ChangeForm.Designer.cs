namespace Calculator
{
    partial class ChangeForm
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
            this.btnChange = new System.Windows.Forms.Button();
            this.NewAccountTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ChangeAccountLabel = new System.Windows.Forms.Label();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.SkyBlue;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("宋体", 12F);
            this.btnChange.Location = new System.Drawing.Point(123, 168);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(95, 37);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            this.btnChange.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnChange_KeyUp);
            // 
            // NewAccountTextBox
            // 
            this.NewAccountTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.NewAccountTextBox.Location = new System.Drawing.Point(140, 61);
            this.NewAccountTextBox.Name = "NewAccountTextBox";
            this.NewAccountTextBox.Size = new System.Drawing.Size(150, 30);
            this.NewAccountTextBox.TabIndex = 1;
            this.NewAccountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewAccountTextBox_KeyPress);
            this.NewAccountTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NewAccountTextBox_KeyUp);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Font = new System.Drawing.Font("宋体", 12F);
            this.NewPasswordTextBox.Location = new System.Drawing.Point(140, 115);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(150, 30);
            this.NewPasswordTextBox.TabIndex = 2;
            this.NewPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewPasswordTextBox_KeyPress);
            this.NewPasswordTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NewPasswordTextBox_KeyUp);
            // 
            // ChangeAccountLabel
            // 
            this.ChangeAccountLabel.AutoSize = true;
            this.ChangeAccountLabel.Font = new System.Drawing.Font("宋体", 13F);
            this.ChangeAccountLabel.Location = new System.Drawing.Point(48, 62);
            this.ChangeAccountLabel.Name = "ChangeAccountLabel";
            this.ChangeAccountLabel.Size = new System.Drawing.Size(76, 22);
            this.ChangeAccountLabel.TabIndex = 3;
            this.ChangeAccountLabel.Text = "新账号";
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Font = new System.Drawing.Font("宋体", 13F);
            this.ChangePasswordLabel.Location = new System.Drawing.Point(48, 116);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(76, 22);
            this.ChangePasswordLabel.TabIndex = 4;
            this.ChangePasswordLabel.Text = "新密码";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(278, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 28);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMax.Enabled = false;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(218, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(60, 28);
            this.btnMax.TabIndex = 17;
            this.btnMax.Text = "□";
            this.btnMax.UseVisualStyleBackColor = false;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(158, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(60, 28);
            this.btnMin.TabIndex = 16;
            this.btnMin.TabStop = false;
            this.btnMin.Text = "─";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(231)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(338, 239);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.ChangePasswordLabel);
            this.Controls.Add(this.ChangeAccountLabel);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.NewAccountTextBox);
            this.Controls.Add(this.btnChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ChangeForm";
            this.Text = "修改信息";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChangeForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox NewAccountTextBox;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.Label ChangeAccountLabel;
        private System.Windows.Forms.Label ChangePasswordLabel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
    }
}
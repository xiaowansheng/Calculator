namespace Calculator
{
    partial class ResetForm
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
            this.InitialAccountLabel = new System.Windows.Forms.Label();
            this.InitialPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InitialAccountLabel
            // 
            this.InitialAccountLabel.AutoSize = true;
            this.InitialAccountLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.InitialAccountLabel.Location = new System.Drawing.Point(75, 70);
            this.InitialAccountLabel.Name = "InitialAccountLabel";
            this.InitialAccountLabel.Size = new System.Drawing.Size(106, 24);
            this.InitialAccountLabel.TabIndex = 0;
            this.InitialAccountLabel.Text = "初始账号";
            // 
            // InitialPasswordLabel
            // 
            this.InitialPasswordLabel.AutoSize = true;
            this.InitialPasswordLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.InitialPasswordLabel.Location = new System.Drawing.Point(75, 113);
            this.InitialPasswordLabel.Name = "InitialPasswordLabel";
            this.InitialPasswordLabel.Size = new System.Drawing.Size(106, 24);
            this.InitialPasswordLabel.TabIndex = 1;
            this.InitialPasswordLabel.Text = "初始密码";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.ConfirmButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.ConfirmButton.FlatAppearance.BorderSize = 0;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("宋体", 12F);
            this.ConfirmButton.Location = new System.Drawing.Point(78, 179);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 35);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("宋体", 12F);
            this.ResetButton.Location = new System.Drawing.Point(210, 179);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 35);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "重置";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.AccountLabel.Location = new System.Drawing.Point(204, 70);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(0, 24);
            this.AccountLabel.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("宋体", 14F);
            this.PasswordLabel.Location = new System.Drawing.Point(204, 113);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(0, 24);
            this.PasswordLabel.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(308, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 25);
            this.btnClose.TabIndex = 15;
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
            this.btnMax.Location = new System.Drawing.Point(258, -2);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 25);
            this.btnMax.TabIndex = 14;
            this.btnMax.Text = "□";
            this.btnMax.UseVisualStyleBackColor = false;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(208, -2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 25);
            this.btnMin.TabIndex = 13;
            this.btnMin.TabStop = false;
            this.btnMin.Text = "─";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            // 
            // ResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(356, 234);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.InitialPasswordLabel);
            this.Controls.Add(this.InitialAccountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ResetForm";
            this.Text = "ResetForm";
            this.Activated += new System.EventHandler(this.ResetForm_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResetForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResetForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResetForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InitialAccountLabel;
        private System.Windows.Forms.Label InitialPasswordLabel;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
    }
}
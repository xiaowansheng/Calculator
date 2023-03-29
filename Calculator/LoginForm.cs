using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Calculator
{
    public partial class LoginForm : Form
    {
        private int count = 1;
        string[] password = null;
        private static bool IsDragging = false;
        private Point StartPoint = new Point(0, 0);
        private Point OffsetPoint = new Point(0, 0);
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            labelTitle.BackColor = Color.Transparent;
            if (File.Exists("Calculator//CodeBook.txt"))
            {
                string date = File.ReadAllText("Calculator//CodeBook.txt");
                if (date != null)
                {
                    password = date.Trim().Split(',');
                    textBoxAccount.Text = password[0];
                    textBoxPassword.Text = password[1];
                    RememberPasswordCheckBox.Checked = true;
                }
            }
        }

        private void TheLogin_Click(object sender, EventArgs e)
        {
            if (User.Account.ToString() == textBoxAccount.Text && User.Password == textBoxPassword.Text && textBoxAccount.Text != null && textBoxPassword.Text != null)
            {
                if (RememberPasswordCheckBox.Checked == true)
                {
                    if (!Directory.Exists("Calculator"))
                        Directory.CreateDirectory("Calculator");
                    File.WriteAllText("Calculator//CodeBook.txt", textBoxAccount.Text + "," + textBoxPassword.Text);
                }
                else
                {
                    if (!Directory.Exists("Calculator"))
                        Directory.CreateDirectory("Calculator");
                    File.WriteAllText("Calculator//CodeBook.txt",textBoxAccount.Text+","+"");
                }

                this.DialogResult = DialogResult.OK;
                InitializeComponent();
                return;
            }
            else if (textBoxAccount.Text=="" || textBoxPassword.Text == "")
            {
                labelAdministrator.Text = "";
                labelErrorMessage.Text = "账号或密码不能为空，请重新输入...";
                textBoxAccount.Focus();
            }
            else
            {
                labelAdministrator.Text = "";
                labelErrorMessage.Text = "账号或密码错误,"+"您还有"+(3-count).ToString()+"次机会";
                againLabel.Text = "请重新输入...";
                textBoxAccount.Focus();
            }
            if(count++==3)
            {
                MessageBox.Show("你已经输错了3次！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.DialogResult = DialogResult.Cancel;
                return;
            }
        }

        private void theLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.TheLogin_Click(sender, e);
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            ResetForm resetForm = new ResetForm();
            resetForm.StartPosition = FormStartPosition.CenterParent;
            resetForm.ShowDialog();
        }

        private void LoginForm_Activated(object sender, EventArgs e)
        {
            if (textBoxAccount.Text == "")
            {
                textBoxAccount.Focus();
                textBoxAccount.TabIndex = 0;
                textBoxPassword.TabIndex = 1;
                theLogin.TabIndex = 2;
            }
            else if (textBoxAccount.Text != ""&& textBoxPassword.Text == "")
            {
                textBoxPassword.Focus();
                theLogin.TabIndex = 0;
            }
            else
                theLogin.Focus();

        }

        private void textBoxAccount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBoxPassword.Focus();
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                theLogin.Focus();
                this.TheLogin_Click(sender, e);
            }
        }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
            againLabel.Text = "";
            if (textBoxAccount.Text == User.Account.ToString())
                labelAdministrator.Text = "管理员登录";
            else
                labelAdministrator.Text = "";

        }

        private void textBoxAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)||e.KeyChar==(char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)||char.IsLetter(e.KeyChar)||char.IsPunctuation(e.KeyChar)|| e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            labelErrorMessage.Text = "";
            againLabel.Text = "";
            if (textBoxAccount.Text == User.Account.ToString())
                labelAdministrator.Text = "管理员登录";
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            IsDragging = true;
            StartPoint.X = e.X;
            StartPoint.Y = e.Y;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging == true)
            {
                OffsetPoint.X = e.X - StartPoint.X;
                OffsetPoint.Y = e.Y - StartPoint.Y;
                Location = PointToScreen(OffsetPoint);
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(0, 200,200,200);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(15,10,10,10);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(0, 200, 200, 200);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(15,10,10,10);
        }

        private void labelAdministrator_TextChanged(object sender, EventArgs e)
        {
            if (labelAdministrator.Text != "")
                labelAdministrator.BorderStyle = BorderStyle.FixedSingle;
            else
                labelAdministrator.BorderStyle = BorderStyle.None;
        }

        private void againLabel_TextChanged(object sender, EventArgs e)
        {
            if (againLabel.Text != "")
                againLabel.BorderStyle = BorderStyle.FixedSingle;
            else
                againLabel.BorderStyle = BorderStyle.None;
        }

        private void labelErrorMessage_TextChanged(object sender, EventArgs e)
        {
            if (labelErrorMessage.Text != "")
                labelErrorMessage.BorderStyle = BorderStyle.FixedSingle;
            else
                labelErrorMessage.BorderStyle = BorderStyle.None;
        }

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            IsDragging = true;
            StartPoint.X = e.X;
            StartPoint.Y = e.Y;
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging == true)
            {
                OffsetPoint.X = e.X - StartPoint.X;
                OffsetPoint.Y = e.Y - StartPoint.Y;
                Location = PointToScreen(OffsetPoint);
            }
        }

        private void labelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }
    }
}

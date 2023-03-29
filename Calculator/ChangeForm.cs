using System;
using System.Windows.Forms;
using System.Drawing;

namespace Calculator
{
    public partial class ChangeForm : Form
    {
        private static bool IsDragging = false;
        private Point StartPoint = new Point(0, 0);
        private Point OffsetPoint = new Point(0, 0);
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //if (NewAccountTextBox.Text != "" && NewPasswordTextBox.Text != "")
            //{
            //    User.Account = int.Parse(NewAccountTextBox.Text);
            //    User.Password = NewPasswordTextBox.Text;
            //    if (User.Account == int.Parse(NewAccountTextBox.Text) && User.Password == NewPasswordTextBox.Text)
            //    {
            //        if (!Directory.Exists("Calculator"))
            //        {
            //            Directory.CreateDirectory("Calculator");
            //        }
            //        File.WriteAllText("Calculator//CodeBook.txt", NewAccountTextBox.Text+","+"");
            //        MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        Close();
            //    }
            //    else
            //        MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("账号或密码不能为空，请重新输入..", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            MessageBox.Show("该功能还不完善，请关注下一版本！", "小提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnChange_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnChange_Click(sender, e);
        }

        private void NewAccountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)|| e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void NewAccountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                NewPasswordTextBox.Focus();
        }

        private void NewPasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnChange.Focus();
                btnChange_Click(sender, e);
            }
        }

        private void NewPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            IsDragging = true;
            StartPoint.X = e.X;
            StartPoint.Y = e.Y;
        }

        private void ChangeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging == true)
            {
                OffsetPoint.X = e.X - StartPoint.X;
                OffsetPoint.Y = e.Y - StartPoint.Y;
                Location = PointToScreen(OffsetPoint);
            }
        }

        private void ChangeForm_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void btnMin_MouseEnter(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(0, 200, 200, 200);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.BackColor = Color.FromArgb(15, 10, 10, 10);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(0, 200, 200, 200);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(15, 10, 10, 10);
        }
    }
}

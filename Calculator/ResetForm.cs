using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Calculator
{
    public partial class ResetForm : Form
    {
        private static bool IsDragging = false;
        private Point StartPoint = new Point(0, 0);
        private Point OffsetPoint = new Point(0, 0);
        public ResetForm()
        {
            InitializeComponent();
            AccountLabel.Text = User.Account.ToString();
            PasswordLabel.Text = User.Password;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Calculator"))
            {
                if (File.Exists("Calculator//CodeBook.txt"))
                    File.Delete("Calculator//CodeBook.txt");
                if (File.Exists("Calculator//CountingProcess.txt"))
                    File.Delete("Calculator//CountingProcess.txt");
                Directory.Delete("Calculator");
            }
            User.Account = 1234;
            User.Password = "1234";
            Close();
        }

        private void ResetForm_Activated(object sender, EventArgs e)
        {
            ConfirmButton.Focus();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            IsDragging = true;
            StartPoint.X = e.X;
            StartPoint.Y = e.Y;
        }

        private void ResetForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging == true)
            {
                OffsetPoint.X = e.X - StartPoint.X;
                OffsetPoint.Y = e.Y - StartPoint.Y;
                Location = PointToScreen(OffsetPoint);
            }
        }

        private void ResetForm_MouseUp(object sender, MouseEventArgs e)
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

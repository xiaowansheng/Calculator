using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Calculator
{
    public partial class ShowForm : Form
    {
        private static bool IsDragging = false;
        private Point StartPoint = new Point(0, 0);
        private Point OffsetPoint = new Point(0, 0);
        public ShowForm()
        {
            InitializeComponent();
            if (File.Exists("Calculator//CountingProcess.txt"))
                ShowDatarichTextBox.Text = File.ReadAllText("Calculator//CountingProcess.txt");
            else
            {
                ShowDatarichTextBox.Text = "没有数据可以查看！";
                ShowDatarichTextBox.Font = new Font("黑体", 20);
            }
        }

        private void btnMin_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
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

        private void ShowForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            IsDragging = true;
            StartPoint.X = e.X;
            StartPoint.Y = e.Y;
        }

        private void ShowForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging == true)
            {
                OffsetPoint.X = e.X - StartPoint.X;
                OffsetPoint.Y = e.Y - StartPoint.Y;
                Location = PointToScreen(OffsetPoint);
            }
        }

        private void ShowForm_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }
    }
}

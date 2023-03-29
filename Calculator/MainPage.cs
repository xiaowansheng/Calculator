using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Calculator
{

    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            labelTitle.BackColor = Color.Transparent;
            displayBoxResult.SelectionAlignment = HorizontalAlignment.Right;
            displayBoxContect.SelectionAlignment = HorizontalAlignment.Right;
            if (!Directory.Exists("Calculator"))
                Directory.CreateDirectory("Calculator");
        }
        public static List<char> inputStr = new List<char>(1000);
        private static bool IsDragging = false;
        private Point StartPoint = new Point(0, 0); 
        private Point OffsetPoint = new Point(0, 0);
        private void MainPage_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            if(loginForm.ShowDialog()!=DialogResult.OK)
            {
                Close();
                return;
            }
        }

        private void btnNumberZero_Click(object sender, EventArgs e)
        {
            inputStr.Add('0');
            displayBoxResult.AppendText("0");
        }

        private void btnRadixPoint_Click(object sender, EventArgs e)
        {
            inputStr.Add('.');
            displayBoxResult.AppendText(".");
        }

        private void btnNumberOne_Click(object sender, EventArgs e)
        {
            inputStr.Add('1');
            displayBoxResult.AppendText("1");
        }

        private void btnNumberTwo_Click(object sender, EventArgs e)
        {
            inputStr.Add('2');
            displayBoxResult.AppendText("2");
        }

        private void btnNumberThree_Click(object sender, EventArgs e)
        {
            inputStr.Add('3');
            displayBoxResult.AppendText("3");
        }

        private void btnNumberFour_Click(object sender, EventArgs e)
        {
            inputStr.Add('4');
            displayBoxResult.AppendText("4");
        }

        private void btnNumberFive_Click(object sender, EventArgs e)
        {
            inputStr.Add('5');
            displayBoxResult.AppendText("5");
        }

        private void btnNumberSix_Click(object sender, EventArgs e)
        {
            inputStr.Add('6');
            displayBoxResult.AppendText("6");
        }

        private void btnNumberSeven_Click(object sender, EventArgs e)
        {
            inputStr.Add('7');
            displayBoxResult.AppendText("7");
        }

        private void btnNumberEight_Click(object sender, EventArgs e)
        {
            inputStr.Add('8');
            displayBoxResult.AppendText("8");
        }

        private void btnNumberNine_Click(object sender, EventArgs e)
        {
            inputStr.Add('9');
            displayBoxResult.AppendText("9");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            inputStr.Add('+');
            displayBoxResult.AppendText("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            inputStr.Add('-');
            displayBoxResult.AppendText("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            inputStr.Add('*');
            displayBoxResult.AppendText("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            inputStr.Add('/');
            displayBoxResult.AppendText("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string result = null;
            result = Compute.DataMain();
            displayBoxResult.AppendText("=");
            displayBoxContect.Text = displayBoxResult.Text + result;
            displayBoxResult.Text = result;
            if (!File.Exists("Calculator//CountingProcess.txt"))
            {
                if(!Directory.Exists("Calculator"))
                    Directory.CreateDirectory("Calculator");
            }
            FileStream fileStream = new FileStream("Calculator//CountingProcess.txt", FileMode.OpenOrCreate);
            fileStream.Position=fileStream.Length;
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(displayBoxContect.Text);
            streamWriter.Close();
            string temp = Compute.DataMain();
            inputStr.Clear();
            for (int i = 0; i < temp.Length; i++)
            {
                inputStr.Add(temp[i]);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (displayBoxResult.Text == "")
                displayBoxContect.Text = "";
            displayBoxResult.Text = "";
            inputStr.Clear(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (inputStr.Count > 0)
                inputStr.RemoveAt(inputStr.Count - 1);
            displayBoxResult.Text = "";
            for (int i = 0; i < inputStr.Count; i++)
            {
                displayBoxResult.Text += inputStr[i];
            }
        }

        private void btnRightBracket_Click(object sender, EventArgs e)
        {
            inputStr.Add(')');
            displayBoxResult.AppendText(")");
        }

        private void btnLeftBracket_Click(object sender, EventArgs e)
        {
            inputStr.Add('(');
            displayBoxResult.AppendText("(");
        }

        private void btnEqual_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnEqual_Click(sender, e);
        }

        private void MainPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Show(AdministratorContextMenuStrip, 0, 0);
            }
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            IsDragging = true;
            StartPoint.X = e.X;
            StartPoint.Y = e.Y;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm changeForm = new ChangeForm();
            changeForm.StartPosition = FormStartPosition.CenterParent;
            changeForm.ShowDialog();
        }

        private void 清除账号密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Calculator"))
            {
                if (File.Exists("Calculator//CodeBook.txt"))
                    File.Delete("Calculator//CodeBook.txt");
            }
            MessageBox.Show("账号密码已清除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 清除运算数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Calculator"))
            {
                if (File.Exists("Calculator//CountingProcess.txt"))
                {
                    File.Delete("Calculator//CountingProcess.txt");
                    MessageBox.Show("数据已清除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("没有数据可以清除了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 关闭程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 运算数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm showForm = new ShowForm();
            showForm.StartPosition = FormStartPosition.CenterParent;
            showForm.ShowDialog();
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Directory.Exists("Calculator"))
                System.Diagnostics.Process.Start("Explorer", "Calculator");
            else
                MessageBox.Show("文件路径不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainPage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.D0: case Keys.NumPad0: btnNumberZero_Click(sender, e); break;
                case Keys.D1: case Keys.NumPad1: btnNumberOne_Click(sender, e); break;
                case Keys.D2: case Keys.NumPad2: btnNumberTwo_Click(sender, e); break;
                case Keys.D3: case Keys.NumPad3: btnNumberThree_Click(sender, e); break;
                case Keys.D4: case Keys.NumPad4: btnNumberFour_Click(sender, e); break;
                case Keys.D5: case Keys.NumPad5: btnNumberFive_Click(sender, e); break;
                case Keys.D6: case Keys.NumPad6: btnNumberSix_Click(sender, e); break;
                case Keys.D7: case Keys.NumPad7: btnNumberSeven_Click(sender, e); break;
                case Keys.D8: case Keys.NumPad8: btnNumberEight_Click(sender, e); break;
                case Keys.D9: case Keys.NumPad9: btnNumberNine_Click(sender, e); break;
                case Keys.Decimal: btnRadixPoint_Click(sender, e); break;
                case Keys.Add: btnAdd_Click(sender, e); break;
                case Keys.Subtract: btnMinus_Click(sender, e); break;
                case Keys.Multiply: btnMultiply_Click(sender, e); break;
                case Keys.Divide: btnDivide_Click(sender, e); break;
                case Keys.Back: btnDelete_Click(sender, e); break;
                case Keys.Oemplus: btnEqual_Click(sender, e); break;
                //case Keys.Enter: btnEqual_Click(sender, e); break;
                default:
                    break;
            }
        }

        private void 清空所有数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Calculator"))
            {
                if (File.Exists("Calculator//CodeBook.txt"))
                    File.Delete("Calculator//CodeBook.txt");
                if (File.Exists("Calculator//CountingProcess.txt"))
                    File.Delete("Calculator//CountingProcess.txt");
                if (Directory.Exists("Calculator//CodeBook"))
                {
                    File.Delete("Calculator//CodeBook//CodeBook.txt");
                    Directory.Delete("Calculator//CodeBook");
                }
                Directory.Delete("Calculator");
            }
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

        private void MainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging == true)
            {
                OffsetPoint.X = e.X - StartPoint.X;
                OffsetPoint.Y = e.Y - StartPoint.Y;
                Location = PointToScreen(OffsetPoint);
            }
        }

        private void MainPage_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
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

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我们的邮箱xiaowansheng@foxmail.com", "关于我们", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    static class User
    {
        static User()
        {
            Name = "管理员";
            Account = 1234;
            Password = "1234";
        }
        public static string Name { get; set; }//名字
        public static int Account { get; set; }//账号
        public static string Password { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int step = 1, stepMax = 30;
        private void linkLabel2_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe",
                "http://www.baidu.com");
        }

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe",
                "http://www.baidu.com");
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"C:\Users\李侯爵\Desktop\桌面应用开发\Project1-QQ\imageANDicon\tdcode1.png");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"C:\Users\李侯爵\Desktop\桌面应用开发\Project1-QQ\imageANDicon\tdcode.png");
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile(@"C:\Users\李侯爵\Desktop\桌面应用开发\Project1-QQ\imageANDicon\keyboard1.png");
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile(@"C:\Users\李侯爵\Desktop\桌面应用开发\Project1-QQ\imageANDicon\keyboard.png");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\李侯爵\Desktop\桌面应用开发\Project1-QQ\imageANDicon\down_en.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\李侯爵\Desktop\桌面应用开发\Project1-QQ\imageANDicon\down_dis.png");
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            timerChangeUserIn.Enabled = false;
            timerChangeUserOut.Enabled = true;  //开启定时器“换头像出”
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            timerChangeUserOut.Enabled = false;
            timerChangeUserIn.Enabled = true;  //开启定时器“换头像进”
        }

        private void timerChangeUserIn_Tick(object sender, EventArgs e)
        {
            int origin = picChangeUser.Location.X;
            picChangeUser.Location = new Point(picChangeUser.Location.X - step, picChangeUser.Location.Y);
            if (picChangeUser.Location.X <= origin - stepMax)
            {
                timerChangeUserIn.Enabled = false;  //到位即关闭定时器“换头像进”
            }
        }

        private void timerChangeUserOut_Tick(object sender, EventArgs e)
        {
            int origin = picChangeUser.Location.X;
            picChangeUser.Location = new Point(picChangeUser.Location.X + step, picChangeUser.Location.Y);
            if (picChangeUser.Location.X >= origin + stepMax)
            {
                timerChangeUserOut.Enabled = false;  //到位即关闭定时器“换头像出”
            }
        }
    }
}

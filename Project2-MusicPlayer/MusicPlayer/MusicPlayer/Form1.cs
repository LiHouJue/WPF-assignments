using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            //MediaPlayerMy
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MediaPlayerMy.URL =
                    "D:\\sourse_storage\\code_storage\\C#\\WinFormProgram_zuoye\\Project2-MusicPlayer\\sourse\\大壮-我们不一样.mp3";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

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
                    "C:\\Users\\李侯爵\\Desktop\\桌面应用开发\\新建文件夹\\sourse\\大壮-我们不一样";
        }
    }
}

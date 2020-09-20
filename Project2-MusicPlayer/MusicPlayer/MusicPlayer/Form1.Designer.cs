namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMin = new System.Windows.Forms.PictureBox();
            this.picSet = new System.Windows.Forms.PictureBox();
            this.panelDown = new System.Windows.Forms.Panel();
            this.picCircle = new System.Windows.Forms.PictureBox();
            this.picDown = new System.Windows.Forms.PictureBox();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.MediaPlayerMy = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSet)).BeginInit();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerMy)).BeginInit();
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(1073, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(20, 20);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            // 
            // picMin
            // 
            this.picMin.BackColor = System.Drawing.Color.Transparent;
            this.picMin.Image = ((System.Drawing.Image)(resources.GetObject("picMin.Image")));
            this.picMin.Location = new System.Drawing.Point(1035, 12);
            this.picMin.Name = "picMin";
            this.picMin.Size = new System.Drawing.Size(20, 20);
            this.picMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMin.TabIndex = 1;
            this.picMin.TabStop = false;
            // 
            // picSet
            // 
            this.picSet.BackColor = System.Drawing.Color.Transparent;
            this.picSet.Image = ((System.Drawing.Image)(resources.GetObject("picSet.Image")));
            this.picSet.Location = new System.Drawing.Point(995, 12);
            this.picSet.Name = "picSet";
            this.picSet.Size = new System.Drawing.Size(20, 20);
            this.picSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSet.TabIndex = 2;
            this.picSet.TabStop = false;
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181)))));
            this.panelDown.Controls.Add(this.picCircle);
            this.panelDown.Controls.Add(this.picDown);
            this.panelDown.Controls.Add(this.picUp);
            this.panelDown.Controls.Add(this.picPlay);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 701);
            this.panelDown.Margin = new System.Windows.Forms.Padding(0);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1105, 60);
            this.panelDown.TabIndex = 3;
            // 
            // picCircle
            // 
            this.picCircle.BackColor = System.Drawing.Color.Transparent;
            this.picCircle.Image = ((System.Drawing.Image)(resources.GetObject("picCircle.Image")));
            this.picCircle.Location = new System.Drawing.Point(14, 5);
            this.picCircle.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.picCircle.Name = "picCircle";
            this.picCircle.Padding = new System.Windows.Forms.Padding(10);
            this.picCircle.Size = new System.Drawing.Size(50, 50);
            this.picCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCircle.TabIndex = 4;
            this.picCircle.TabStop = false;
            // 
            // picDown
            // 
            this.picDown.BackColor = System.Drawing.Color.Transparent;
            this.picDown.Image = ((System.Drawing.Image)(resources.GetObject("picDown.Image")));
            this.picDown.Location = new System.Drawing.Point(194, 5);
            this.picDown.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(50, 50);
            this.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDown.TabIndex = 6;
            this.picDown.TabStop = false;
            // 
            // picUp
            // 
            this.picUp.BackColor = System.Drawing.Color.Transparent;
            this.picUp.Image = ((System.Drawing.Image)(resources.GetObject("picUp.Image")));
            this.picUp.Location = new System.Drawing.Point(74, 5);
            this.picUp.Margin = new System.Windows.Forms.Padding(5, 20, 5, 50);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(50, 50);
            this.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUp.TabIndex = 5;
            this.picUp.TabStop = false;
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.Image = ((System.Drawing.Image)(resources.GetObject("picPlay.Image")));
            this.picPlay.Location = new System.Drawing.Point(134, 5);
            this.picPlay.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(50, 50);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlay.TabIndex = 4;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // MediaPlayerMy
            // 
            this.MediaPlayerMy.Enabled = true;
            this.MediaPlayerMy.Location = new System.Drawing.Point(248, 357);
            this.MediaPlayerMy.Name = "MediaPlayerMy";
            this.MediaPlayerMy.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayerMy.OcxState")));
            this.MediaPlayerMy.Size = new System.Drawing.Size(166, 89);
            this.MediaPlayerMy.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 761);
            this.Controls.Add(this.MediaPlayerMy);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.picSet);
            this.Controls.Add(this.picMin);
            this.Controls.Add(this.picClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSet)).EndInit();
            this.panelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayerMy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMin;
        private System.Windows.Forms.PictureBox picSet;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.PictureBox picCircle;
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.PictureBox picPlay;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayerMy;
    }
}


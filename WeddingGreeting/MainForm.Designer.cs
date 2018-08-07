namespace WeddingGreeting
{
    partial class MainForm
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
            this.picbVideoContainer = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStopVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.guestViewer = new EAlbums.ImageViewer();
            this.hostViewer = new EAlbums.ImageViewer();
            this.tsmiConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfigVideoWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picbVideoContainer)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbVideoContainer
            // 
            this.picbVideoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picbVideoContainer.Location = new System.Drawing.Point(2, 24);
            this.picbVideoContainer.Name = "picbVideoContainer";
            this.picbVideoContainer.Size = new System.Drawing.Size(128, 96);
            this.picbVideoContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbVideoContainer.TabIndex = 0;
            this.picbVideoContainer.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem,
            this.tsmiRegister,
            this.tsmiVideo,
            this.tsmiRefresh,
            this.tsmiConfig});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(916, 25);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.MouseEnter += new System.EventHandler(this.menuStrip_MouseEnter);
            this.menuStrip.MouseLeave += new System.EventHandler(this.menuStrip_MouseLeave);
            // 
            // tsmiRegister
            // 
            this.tsmiRegister.Name = "tsmiRegister";
            this.tsmiRegister.Size = new System.Drawing.Size(77, 21);
            this.tsmiRegister.Text = "录入人员...";
            this.tsmiRegister.Click += new System.EventHandler(this.tsmiRegister_Click);
            // 
            // tsmiVideo
            // 
            this.tsmiVideo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPlayVideo,
            this.tsmiStopVideo});
            this.tsmiVideo.Name = "tsmiVideo";
            this.tsmiVideo.Size = new System.Drawing.Size(44, 21);
            this.tsmiVideo.Text = "视频";
            // 
            // tsmiPlayVideo
            // 
            this.tsmiPlayVideo.Name = "tsmiPlayVideo";
            this.tsmiPlayVideo.Size = new System.Drawing.Size(100, 22);
            this.tsmiPlayVideo.Text = "开启";
            this.tsmiPlayVideo.Click += new System.EventHandler(this.tsmiPlayVideo_Click);
            // 
            // tsmiStopVideo
            // 
            this.tsmiStopVideo.Name = "tsmiStopVideo";
            this.tsmiStopVideo.Size = new System.Drawing.Size(100, 22);
            this.tsmiStopVideo.Text = "停止";
            this.tsmiStopVideo.Click += new System.EventHandler(this.tsmiStopVideo_Click);
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(44, 21);
            this.tsmiRefresh.Text = "刷新";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // guestViewer
            // 
            this.guestViewer.AllowDrop = true;
            this.guestViewer.Alpha = 0.1F;
            this.guestViewer.AutoScroll = true;
            this.guestViewer.AutoSize = true;
            this.guestViewer.BackColor = System.Drawing.Color.Black;
            this.guestViewer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guestViewer.CircleCapacity = 4;
            this.guestViewer.CircleVerInterval = 100;
            this.guestViewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestViewer.DestinationSize = new System.Drawing.Size(0, 0);
            this.guestViewer.DisplayCenterOffset = new System.Drawing.Point(100, 0);
            this.guestViewer.ImagePreviewMode = EAlbums.PreviewMode.None;
            this.guestViewer.Location = new System.Drawing.Point(2, 28);
            this.guestViewer.MaxCapacityInCircle = 360;
            this.guestViewer.MaxImageLength = 120;
            this.guestViewer.Name = "guestViewer";
            this.guestViewer.Pattern = EAlbums.ViewPatterns.Pending;
            this.guestViewer.ScalingOption = EgoDevil.Utilities.ThumbnailCreator.ScalingOptions.MaintainAspect;
            this.guestViewer.Size = new System.Drawing.Size(858, 307);
            this.guestViewer.SourceFolder = "";
            this.guestViewer.TabIndex = 5;
            // 
            // hostViewer
            // 
            this.hostViewer.AllowDrop = true;
            this.hostViewer.Alpha = 0.1F;
            this.hostViewer.AutoScroll = true;
            this.hostViewer.AutoSize = true;
            this.hostViewer.BackColor = System.Drawing.Color.Black;
            this.hostViewer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hostViewer.CircleCapacity = 1;
            this.hostViewer.CircleVerInterval = 100;
            this.hostViewer.DestinationSize = new System.Drawing.Size(80, 120);
            this.hostViewer.DisplayCenterOffset = new System.Drawing.Point(0, 0);
            this.hostViewer.ImagePreviewMode = EAlbums.PreviewMode.None;
            this.hostViewer.Location = new System.Drawing.Point(12, 341);
            this.hostViewer.MaxCapacityInCircle = 360;
            this.hostViewer.MaxImageLength = 160;
            this.hostViewer.Name = "hostViewer";
            this.hostViewer.Pattern = EAlbums.ViewPatterns.Pending;
            this.hostViewer.ScalingOption = EgoDevil.Utilities.ThumbnailCreator.ScalingOptions.MaintainAspect;
            this.hostViewer.Size = new System.Drawing.Size(858, 255);
            this.hostViewer.SourceFolder = "HostImages";
            this.hostViewer.TabIndex = 5;
            // 
            // tsmiConfig
            // 
            this.tsmiConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConfigVideoWindow});
            this.tsmiConfig.Name = "tsmiConfig";
            this.tsmiConfig.Size = new System.Drawing.Size(44, 21);
            this.tsmiConfig.Text = "配置";
            // 
            // tsmiConfigVideoWindow
            // 
            this.tsmiConfigVideoWindow.Name = "tsmiConfigVideoWindow";
            this.tsmiConfigVideoWindow.Size = new System.Drawing.Size(152, 22);
            this.tsmiConfigVideoWindow.Text = "视频窗口...";
            this.tsmiConfigVideoWindow.Click += new System.EventHandler(this.tsmiConfigVideoWindow_Click);
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(44, 21);
            this.tsmiSystem.Text = "系统";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 593);
            this.Controls.Add(this.picbVideoContainer);
            this.Controls.Add(this.guestViewer);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.hostViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "婚礼签到指引";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picbVideoContainer)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbVideoContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegister;
        private System.Windows.Forms.ToolStripMenuItem tsmiVideo;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayVideo;
        private System.Windows.Forms.ToolStripMenuItem tsmiStopVideo;
        private EAlbums.ImageViewer guestViewer;
        private EAlbums.ImageViewer hostViewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfigVideoWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}


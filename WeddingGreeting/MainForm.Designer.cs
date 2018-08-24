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
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuestManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportGuest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecognise = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiControlVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVideoSource = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetThreshold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfigVideoWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.guestViewer = new EAlbums.ImageViewer();
            this.hostViewer = new EAlbums.ImageViewer();
            this.dmAttendance = new EgoDevil.Utilities.UI.IndustrialCtrls.Meters.LBDigitalMeter();
            this.cbbVideoSource = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbVideoContainer)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbVideoContainer
            // 
            this.picbVideoContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.picbVideoContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.tsmiManagement,
            this.tsmiRecognise,
            this.tsmiConfig});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(580, 25);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.MouseEnter += new System.EventHandler(this.menuStrip_MouseEnter);
            this.menuStrip.MouseLeave += new System.EventHandler(this.menuStrip_MouseLeave);
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
            this.tsmiExit.Size = new System.Drawing.Size(100, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiManagement
            // 
            this.tsmiManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGuestManagement,
            this.tsmiImportGuest,
            this.tsmiRefresh});
            this.tsmiManagement.Name = "tsmiManagement";
            this.tsmiManagement.Size = new System.Drawing.Size(44, 21);
            this.tsmiManagement.Text = "管理";
            // 
            // tsmiGuestManagement
            // 
            this.tsmiGuestManagement.Name = "tsmiGuestManagement";
            this.tsmiGuestManagement.Size = new System.Drawing.Size(109, 22);
            this.tsmiGuestManagement.Text = "宾客...";
            this.tsmiGuestManagement.Click += new System.EventHandler(this.tsmiGuestManagement_Click);
            // 
            // tsmiImportGuest
            // 
            this.tsmiImportGuest.Name = "tsmiImportGuest";
            this.tsmiImportGuest.Size = new System.Drawing.Size(109, 22);
            this.tsmiImportGuest.Text = "导入...";
            this.tsmiImportGuest.Click += new System.EventHandler(this.tsmiImportGuest_Click);
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(109, 22);
            this.tsmiRefresh.Text = "刷新";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // tsmiRecognise
            // 
            this.tsmiRecognise.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiControlVideo,
            this.tsmiVideoSource,
            this.tsmiSetThreshold,
            this.tsmiConfigVideoWindow});
            this.tsmiRecognise.Name = "tsmiRecognise";
            this.tsmiRecognise.Size = new System.Drawing.Size(44, 21);
            this.tsmiRecognise.Text = "识别";
            // 
            // tsmiControlVideo
            // 
            this.tsmiControlVideo.Name = "tsmiControlVideo";
            this.tsmiControlVideo.Size = new System.Drawing.Size(133, 22);
            this.tsmiControlVideo.Text = "开始";
            this.tsmiControlVideo.Click += new System.EventHandler(this.tsmiControlVideo_Click);
            // 
            // tsmiVideoSource
            // 
            this.tsmiVideoSource.Name = "tsmiVideoSource";
            this.tsmiVideoSource.Size = new System.Drawing.Size(133, 22);
            this.tsmiVideoSource.Text = "视频源";
            // 
            // tsmiSetThreshold
            // 
            this.tsmiSetThreshold.Name = "tsmiSetThreshold";
            this.tsmiSetThreshold.Size = new System.Drawing.Size(133, 22);
            this.tsmiSetThreshold.Text = "阈值";
            // 
            // tsmiConfigVideoWindow
            // 
            this.tsmiConfigVideoWindow.Name = "tsmiConfigVideoWindow";
            this.tsmiConfigVideoWindow.Size = new System.Drawing.Size(133, 22);
            this.tsmiConfigVideoWindow.Text = "视频窗口...";
            this.tsmiConfigVideoWindow.Click += new System.EventHandler(this.tsmiConfigVideoWindow_Click);
            // 
            // tsmiConfig
            // 
            this.tsmiConfig.Name = "tsmiConfig";
            this.tsmiConfig.Size = new System.Drawing.Size(44, 21);
            this.tsmiConfig.Text = "配置";
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
            this.guestViewer.Location = new System.Drawing.Point(2, 126);
            this.guestViewer.MaxCapacityInCircle = 360;
            this.guestViewer.MaxImageLength = 120;
            this.guestViewer.Name = "guestViewer";
            this.guestViewer.Pattern = EAlbums.ViewPatterns.Pending;
            this.guestViewer.ScalingOption = EgoDevil.Utilities.ThumbnailCreator.ScalingOptions.MaintainAspect;
            this.guestViewer.ShownTitle = false;
            this.guestViewer.Size = new System.Drawing.Size(473, 109);
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
            this.hostViewer.Location = new System.Drawing.Point(2, 241);
            this.hostViewer.MaxCapacityInCircle = 360;
            this.hostViewer.MaxImageLength = 160;
            this.hostViewer.Name = "hostViewer";
            this.hostViewer.Pattern = EAlbums.ViewPatterns.Pending;
            this.hostViewer.ScalingOption = EgoDevil.Utilities.ThumbnailCreator.ScalingOptions.MaintainAspect;
            this.hostViewer.ShownTitle = true;
            this.hostViewer.Size = new System.Drawing.Size(473, 97);
            this.hostViewer.SourceFolder = "HostImages";
            this.hostViewer.TabIndex = 5;
            // 
            // dmAttendance
            // 
            this.dmAttendance.BackColor = System.Drawing.Color.Black;
            this.dmAttendance.ForeColor = System.Drawing.Color.Red;
            this.dmAttendance.Format = "000";
            this.dmAttendance.Location = new System.Drawing.Point(344, 87);
            this.dmAttendance.Name = "dmAttendance";
            this.dmAttendance.Renderer = null;
            this.dmAttendance.Signed = false;
            this.dmAttendance.Size = new System.Drawing.Size(131, 33);
            this.dmAttendance.TabIndex = 6;
            this.dmAttendance.Value = 0D;
            // 
            // cbbVideoSource
            // 
            this.cbbVideoSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVideoSource.FormattingEnabled = true;
            this.cbbVideoSource.Location = new System.Drawing.Point(447, 37);
            this.cbbVideoSource.Name = "cbbVideoSource";
            this.cbbVideoSource.Size = new System.Drawing.Size(121, 20);
            this.cbbVideoSource.TabIndex = 7;
            this.cbbVideoSource.SelectedIndexChanged += new System.EventHandler(this.cbbVideoSource_SelectedIndexChanged);
            this.cbbVideoSource.Click += new System.EventHandler(this.cbbVideoSource_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 373);
            this.Controls.Add(this.cbbVideoSource);
            this.Controls.Add(this.dmAttendance);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiRecognise;
        private System.Windows.Forms.ToolStripMenuItem tsmiControlVideo;
        private EAlbums.ImageViewer guestViewer;
        private EAlbums.ImageViewer hostViewer;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmiConfigVideoWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetThreshold;
        private System.Windows.Forms.ToolStripMenuItem tsmiManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuestManagement;
        private EgoDevil.Utilities.UI.IndustrialCtrls.Meters.LBDigitalMeter dmAttendance;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportGuest;
        private System.Windows.Forms.ToolStripMenuItem tsmiVideoSource;
        private System.Windows.Forms.ComboBox cbbVideoSource;
    }
}


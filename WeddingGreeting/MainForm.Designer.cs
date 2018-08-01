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
            this.picbRecognisedFace = new System.Windows.Forms.PictureBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.picbCapturedFace = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStopVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.imageViewer = new EAlbums.ImageViewer();
            ((System.ComponentModel.ISupportInitialize)(this.picbVideoContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRecognisedFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbCapturedFace)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbVideoContainer
            // 
            this.picbVideoContainer.BackColor = System.Drawing.Color.Black;
            this.picbVideoContainer.Location = new System.Drawing.Point(12, 39);
            this.picbVideoContainer.Name = "picbVideoContainer";
            this.picbVideoContainer.Size = new System.Drawing.Size(446, 303);
            this.picbVideoContainer.TabIndex = 0;
            this.picbVideoContainer.TabStop = false;
            // 
            // picbRecognisedFace
            // 
            this.picbRecognisedFace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picbRecognisedFace.Location = new System.Drawing.Point(623, 39);
            this.picbRecognisedFace.Name = "picbRecognisedFace";
            this.picbRecognisedFace.Size = new System.Drawing.Size(153, 177);
            this.picbRecognisedFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbRecognisedFace.TabIndex = 2;
            this.picbRecognisedFace.TabStop = false;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(464, 222);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(312, 120);
            this.rtbMessage.TabIndex = 3;
            this.rtbMessage.Text = "";
            // 
            // picbCapturedFace
            // 
            this.picbCapturedFace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picbCapturedFace.Location = new System.Drawing.Point(464, 39);
            this.picbCapturedFace.Name = "picbCapturedFace";
            this.picbCapturedFace.Size = new System.Drawing.Size(153, 177);
            this.picbCapturedFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbCapturedFace.TabIndex = 2;
            this.picbCapturedFace.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRegister,
            this.tsmiVideo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(892, 25);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
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
            // imageViewer
            // 
            this.imageViewer.AllowDrop = true;
            this.imageViewer.Alpha = 0F;
            this.imageViewer.AutoScroll = true;
            this.imageViewer.AutoSize = true;
            this.imageViewer.BackColor = System.Drawing.Color.Black;
            this.imageViewer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.imageViewer.ImagePreviewMode = EAlbums.PreviewMode.None;
            this.imageViewer.Location = new System.Drawing.Point(22, 362);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Pattern = EAlbums.ViewPatterns.Pending;
            this.imageViewer.Size = new System.Drawing.Size(858, 381);
            this.imageViewer.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 882);
            this.Controls.Add(this.imageViewer);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.picbCapturedFace);
            this.Controls.Add(this.picbRecognisedFace);
            this.Controls.Add(this.picbVideoContainer);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "婚礼签到指引";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picbVideoContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbRecognisedFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbCapturedFace)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbVideoContainer;
        private System.Windows.Forms.PictureBox picbRecognisedFace;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.PictureBox picbCapturedFace;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegister;
        private System.Windows.Forms.ToolStripMenuItem tsmiVideo;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayVideo;
        private System.Windows.Forms.ToolStripMenuItem tsmiStopVideo;
        private EAlbums.ImageViewer imageViewer;
    }
}


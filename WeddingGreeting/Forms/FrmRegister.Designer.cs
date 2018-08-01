namespace WeddingGreeting.Forms
{
    partial class FrmRegister
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lbTableNo = new System.Windows.Forms.Label();
            this.txtTableNo = new System.Windows.Forms.TextBox();
            this.picbFacePicture = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbUserId = new System.Windows.Forms.Label();
            this.txtNamePinyin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbFacePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(25, 78);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 12);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 21);
            this.txtName.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(25, 105);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(35, 12);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "身份:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(66, 102);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(174, 21);
            this.txtStatus.TabIndex = 1;
            // 
            // lbTableNo
            // 
            this.lbTableNo.AutoSize = true;
            this.lbTableNo.Location = new System.Drawing.Point(25, 132);
            this.lbTableNo.Name = "lbTableNo";
            this.lbTableNo.Size = new System.Drawing.Size(35, 12);
            this.lbTableNo.TabIndex = 0;
            this.lbTableNo.Text = "桌号:";
            // 
            // txtTableNo
            // 
            this.txtTableNo.Location = new System.Drawing.Point(66, 129);
            this.txtTableNo.Name = "txtTableNo";
            this.txtTableNo.Size = new System.Drawing.Size(174, 21);
            this.txtTableNo.TabIndex = 1;
            // 
            // picbFacePicture
            // 
            this.picbFacePicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picbFacePicture.Location = new System.Drawing.Point(246, 28);
            this.picbFacePicture.Name = "picbFacePicture";
            this.picbFacePicture.Size = new System.Drawing.Size(131, 153);
            this.picbFacePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbFacePicture.TabIndex = 2;
            this.picbFacePicture.TabStop = false;
            this.picbFacePicture.DoubleClick += new System.EventHandler(this.picbFacePicture_DoubleClick);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(153, 285);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbUserId
            // 
            this.lbUserId.AutoSize = true;
            this.lbUserId.Location = new System.Drawing.Point(37, 38);
            this.lbUserId.Name = "lbUserId";
            this.lbUserId.Size = new System.Drawing.Size(23, 12);
            this.lbUserId.TabIndex = 0;
            this.lbUserId.Text = "ID:";
            // 
            // txtNamePinyin
            // 
            this.txtNamePinyin.Location = new System.Drawing.Point(66, 29);
            this.txtNamePinyin.Name = "txtNamePinyin";
            this.txtNamePinyin.Size = new System.Drawing.Size(174, 21);
            this.txtNamePinyin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "(英文名或中文拼音)";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 351);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.picbFacePicture);
            this.Controls.Add(this.txtTableNo);
            this.Controls.Add(this.lbTableNo);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtNamePinyin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUserId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "人员录入";
            ((System.ComponentModel.ISupportInitialize)(this.picbFacePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lbTableNo;
        private System.Windows.Forms.TextBox txtTableNo;
        private System.Windows.Forms.PictureBox picbFacePicture;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbUserId;
        private System.Windows.Forms.TextBox txtNamePinyin;
        private System.Windows.Forms.Label label1;
    }
}
namespace WeddingGreeting.Forms
{
    partial class FrmStatistics
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
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.plQuery = new System.Windows.Forms.Panel();
            this.cbbFilter = new System.Windows.Forms.ComboBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.colTableNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colLabels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntourageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsAttend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttendTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.plQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGuests
            // 
            this.dgvGuests.AllowUserToAddRows = false;
            this.dgvGuests.AllowUserToDeleteRows = false;
            this.dgvGuests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableNo,
            this.colName,
            this.colImage,
            this.colLabels,
            this.colEntourageNum,
            this.colIsAttend,
            this.colAttendTime});
            this.dgvGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGuests.Location = new System.Drawing.Point(0, 43);
            this.dgvGuests.MultiSelect = false;
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.ReadOnly = true;
            this.dgvGuests.RowTemplate.Height = 23;
            this.dgvGuests.RowTemplate.ReadOnly = true;
            this.dgvGuests.Size = new System.Drawing.Size(979, 467);
            this.dgvGuests.TabIndex = 0;
            // 
            // plQuery
            // 
            this.plQuery.Controls.Add(this.lbInfo);
            this.plQuery.Controls.Add(this.cbbFilter);
            this.plQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.plQuery.Location = new System.Drawing.Point(0, 0);
            this.plQuery.Name = "plQuery";
            this.plQuery.Size = new System.Drawing.Size(979, 43);
            this.plQuery.TabIndex = 1;
            // 
            // cbbFilter
            // 
            this.cbbFilter.FormattingEnabled = true;
            this.cbbFilter.Items.AddRange(new object[] {
            "全部",
            "已签到",
            "未签到"});
            this.cbbFilter.Location = new System.Drawing.Point(12, 12);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(121, 20);
            this.cbbFilter.TabIndex = 0;
            this.cbbFilter.SelectedIndexChanged += new System.EventHandler(this.cbbFilter_SelectedIndexChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInfo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbInfo.Location = new System.Drawing.Point(162, 9);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(322, 24);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "总数:{0} 已到:{1} 未到:{2}";
            // 
            // colTableNo
            // 
            this.colTableNo.HeaderText = "桌号";
            this.colTableNo.Name = "colTableNo";
            this.colTableNo.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "姓名";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colImage
            // 
            this.colImage.HeaderText = "相片";
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            // 
            // colLabels
            // 
            this.colLabels.HeaderText = "身份";
            this.colLabels.Name = "colLabels";
            this.colLabels.ReadOnly = true;
            // 
            // colEntourageNum
            // 
            this.colEntourageNum.HeaderText = "随行人数";
            this.colEntourageNum.Name = "colEntourageNum";
            this.colEntourageNum.ReadOnly = true;
            // 
            // colIsAttend
            // 
            this.colIsAttend.HeaderText = "是否签到";
            this.colIsAttend.Name = "colIsAttend";
            this.colIsAttend.ReadOnly = true;
            // 
            // colAttendTime
            // 
            this.colAttendTime.HeaderText = "签到时间";
            this.colAttendTime.Name = "colAttendTime";
            this.colAttendTime.ReadOnly = true;
            // 
            // FrmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 510);
            this.Controls.Add(this.dgvGuests);
            this.Controls.Add(this.plQuery);
            this.MinimizeBox = false;
            this.Name = "FrmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "统计";
            this.Load += new System.EventHandler(this.FrmStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.plQuery.ResumeLayout(false);
            this.plQuery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Panel plQuery;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.ComboBox cbbFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLabels;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntourageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsAttend;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttendTime;
    }
}
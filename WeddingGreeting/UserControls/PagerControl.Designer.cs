namespace WeddingGreeting.UserControls
{
    partial class PagerControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.lbPageSize = new System.Windows.Forms.Label();
            this.cbbPageSize = new System.Windows.Forms.ComboBox();
            this.lbCurrentTotal = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHomePage
            // 
            this.btnHomePage.Location = new System.Drawing.Point(193, 3);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(75, 23);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "首页";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(274, 3);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 23);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = "上一页";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(355, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 0;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(436, 3);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 23);
            this.btnLastPage.TabIndex = 0;
            this.btnLastPage.Text = "末页";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // lbPageSize
            // 
            this.lbPageSize.AutoSize = true;
            this.lbPageSize.Location = new System.Drawing.Point(0, 8);
            this.lbPageSize.Name = "lbPageSize";
            this.lbPageSize.Size = new System.Drawing.Size(35, 12);
            this.lbPageSize.TabIndex = 1;
            this.lbPageSize.Text = "每页:";
            // 
            // cbbPageSize
            // 
            this.cbbPageSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbPageSize.FormattingEnabled = true;
            this.cbbPageSize.Items.AddRange(new object[] {
            "20",
            "50",
            "100",
            "1000"});
            this.cbbPageSize.Location = new System.Drawing.Point(32, 4);
            this.cbbPageSize.Name = "cbbPageSize";
            this.cbbPageSize.Size = new System.Drawing.Size(62, 20);
            this.cbbPageSize.TabIndex = 2;
            this.cbbPageSize.SelectedIndexChanged += new System.EventHandler(this.cbbPageSize_SelectedIndexChanged);
            // 
            // lbCurrentTotal
            // 
            this.lbCurrentTotal.AutoSize = true;
            this.lbCurrentTotal.Location = new System.Drawing.Point(517, 8);
            this.lbCurrentTotal.Name = "lbCurrentTotal";
            this.lbCurrentTotal.Size = new System.Drawing.Size(47, 12);
            this.lbCurrentTotal.TabIndex = 3;
            this.lbCurrentTotal.Text = "{0}/{1}";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(100, 8);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(23, 12);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "{0}";
            // 
            // PagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbCurrentTotal);
            this.Controls.Add(this.cbbPageSize);
            this.Controls.Add(this.lbPageSize);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnHomePage);
            this.Name = "PagerControl";
            this.Size = new System.Drawing.Size(629, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Label lbPageSize;
        private System.Windows.Forms.ComboBox cbbPageSize;
        private System.Windows.Forms.Label lbCurrentTotal;
        private System.Windows.Forms.Label lbTotal;
    }
}

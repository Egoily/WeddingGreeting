namespace WeddingGreeting.Forms
{
    partial class FrmTableLayout
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
            this.tableControl1 = new WeddingGreeting.UserControls.TableControl();
            this.SuspendLayout();
            // 
            // tableControl1
            // 
            this.tableControl1.BackColor = System.Drawing.Color.Transparent;
            this.tableControl1.GuestNameColor = System.Drawing.Color.Black;
            this.tableControl1.Location = new System.Drawing.Point(188, 38);
            this.tableControl1.Name = "tableControl1";
            this.tableControl1.NameList.Add("黄广毅");
            this.tableControl1.NameList.Add("高小娜");
            this.tableControl1.NameList.Add("黄盛");
            this.tableControl1.NameList.Add("罗桂珍");
            this.tableControl1.NameList.Add("张春端");
            this.tableControl1.NameList.Add("秋娣");
            this.tableControl1.NameList.Add("秋银");
            this.tableControl1.NameList.Add("景浩");
            this.tableControl1.NameList.Add("丽珠");
            this.tableControl1.NameList.Add("建全");
            this.tableControl1.Size = new System.Drawing.Size(271, 237);
            this.tableControl1.TabIndex = 0;
            this.tableControl1.TableColor = System.Drawing.Color.PeachPuff;
            this.tableControl1.TableName = null;
            this.tableControl1.TableNameColor = System.Drawing.Color.Red;
            this.tableControl1.TableNo = null;
            // 
            // FrmTableLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 383);
            this.Controls.Add(this.tableControl1);
            this.Name = "FrmTableLayout";
            this.Text = "FrmTableLayout";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.TableControl tableControl1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingGreeting.UserControls
{
    public partial class PagerControl : UserControl
    {
        public delegate void PageChangedEvent(int pageIndex, int pageSize);
        public int Total { get; set; }
        public int PageSize { get; protected set; }

        private int pageIndex = 0;
        public int PageIndex
        {
            get => pageIndex;
            protected set
            {
                if (pageIndex != value)
                {
                    pageIndex = value;
                    if (pageIndex > 0)
                    {
                        PageChanged?.Invoke(pageIndex, PageSize);
                    }
                }
            }
        }

        public int PageCount { get; protected set; }

        public event PageChangedEvent PageChanged;

        private bool isInit = false;
        public PagerControl()
        {
            InitializeComponent();
            cbbPageSize.SelectedIndex = 0;
            PageSize = Int32.Parse(cbbPageSize.Text);
        }
        public void SetTotal(int total)
        {
            isInit = false;
            pageIndex = 0;
            Total = total;
            if (total > 0)
            {
                PageCount = (Total - 1) / PageSize + 1;
            }
            else
            {
                PageCount = 0;
            }
            PageIndex = 1;
            lbTotal.Text = $" {Total} 条记录";
            lbCurrentTotal.Text = $"{PageIndex}/{PageCount}";
            if (PageCount > 0)
            {
                btnHomePage.Enabled = true;
                btnLastPage.Enabled = true;
                btnPrevPage.Enabled = true;
                btnNextPage.Enabled = true;
                lbCurrentTotal.Visible = true;
            }
            else
            {
                btnHomePage.Enabled = false;
                btnLastPage.Enabled = false;
                btnPrevPage.Enabled = false;
                btnNextPage.Enabled = false;
                lbCurrentTotal.Visible = false;
            }
            isInit = true;
        }

        public void RefreshData()
        {
            PageChanged?.Invoke(PageIndex, PageSize);
        }
        private void ChangeToPage(int index)
        {
            btnHomePage.Enabled = true;
            btnLastPage.Enabled = true;
            btnPrevPage.Enabled = true;
            btnNextPage.Enabled = true;
            if (index == 1)
            {
                btnHomePage.Enabled = false;
                btnPrevPage.Enabled = false;
            }
            if (index >= PageCount)
            {
                btnLastPage.Enabled = false;
                btnNextPage.Enabled = false;
            }
            if (index <= PageCount && index > 0)
            {
                PageIndex = index;
                lbCurrentTotal.Text = $"{PageIndex}/{PageCount}";

            }


        }
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            ChangeToPage(1);

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            ChangeToPage(PageCount);
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            ChangeToPage(PageIndex - 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            ChangeToPage(PageIndex + 1);
        }

        private void cbbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInit) return;
            PageSize = Int32.Parse(cbbPageSize.Text);
            SetTotal(Total);
            ChangeToPage(1);
        }
    }
}

using ee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeddingGreeting.Forms
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
            cbbFilter.SelectedIndex = 0;
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            dgvGuests.DataSource = QueryGuests();
            var total = GlobalConfig.Guests.Count();
            var attendance = GlobalConfig.Guests.Count(x => x.IsAttend);

            lbInfo.Text = $"总数:{total} 已到:{attendance} 未到:{total - attendance}";
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFilter.Text == "已签到")
            {
                dgvGuests.DataSource = QueryGuests(true);
               
            }
            else if (cbbFilter.Text == "未签到")
            {
                dgvGuests.DataSource = QueryGuests(false);
            }
            else
            {
                dgvGuests.DataSource = QueryGuests();
            }
            dgvGuests.Refresh();
        }

        private List<GuestInfo> QueryGuests(bool? isAttend=null)
        {
            if (isAttend.HasValue)
            {
                return GlobalConfig.Guests.Where(x => x.IsAttend == isAttend.Value).OrderBy(x => x.TableNo).ToList();
            }
            return GlobalConfig.Guests.OrderBy(x => x.TableNo).ToList();
        }
    }
}

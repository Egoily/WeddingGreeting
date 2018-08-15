using ee.Models;
using EgoDevil.Utilities.UI.MessageForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WeddingGreeting.Forms
{
    public partial class FrmGuestManagement : Form
    {

        private bool isLoaded = false;
        public FrmGuestManagement()
        {
            InitializeComponent();
            dgvGuests.AutoGenerateColumns = false;
            tscbbFilter.SelectedIndex = 0;
            splitContainer.Panel2Collapsed = true;
        }


        private void SetAttendInformation()
        {

            var total = GlobalConfig.Guests.Count();
            var attendance = GlobalConfig.Guests.Count(x => x.IsAttend);

            tspbPercentage.Value = attendance * 100 / total;
            tspbPercentage.Text = $"{attendance}/{total}";
            tslbStatisticInfo.Text = $"总数:{total} 已到:{attendance} 未到:{attendance - attendance}";
        }
        private void FrmGuestManagement_Load(object sender, EventArgs e)
        {

            dgvGuests.DataSource = QueryGuests();

            SetAttendInformation();
            isLoaded = true;
        }




        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            if (tscbbFilter.Text == "已签到")
            {
                dgvGuests.DataSource = QueryGuests(true);

            }
            else if (tscbbFilter.Text == "未签到")
            {
                dgvGuests.DataSource = QueryGuests(false);
            }
            else
            {
                dgvGuests.DataSource = QueryGuests();
            }
            dgvGuests.Refresh();
        }

        private List<GuestInfo> QueryGuests(bool? isAttend = null)
        {
            if (isAttend.HasValue)
            {
                return GlobalConfig.Guests.Where(x => x.IsAttend == isAttend.Value).OrderBy(x => x.TableNo).ToList();
            }
            return GlobalConfig.Guests.OrderBy(x => x.TableNo).ToList();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {

            splitContainer.Panel2Collapsed = false;
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows == null) return;
            splitContainer.Panel2Collapsed = false;

            var obj = dgvGuests.SelectedRows[0];

            var information = obj.DataBoundItem as GuestInfo;
            guestInfoCtrl.Information = information;
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            if (dgvGuests.SelectedRows == null) return;
        }

        private void tsbQuery_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterOrUpdate_Click(object sender, EventArgs e)
        {
            var val = guestInfoCtrl.Validation();
            if (val)
            {
                var para = guestInfoCtrl.Information;
                var thread = new EgoDevil.Utilities.BkWorker.BackgroundThread(Register);
                thread.RunWorkerCompleted += Thread_RunWorkerCompleted;
                thread.Start(para);
            }

        }

        private void Thread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bool success = (bool)(e.Result);

            var message = success ? "录入成功" : "录入失败";
            MsgForm.Show(message, "提示", success ? MessageBoxIcon.None : MessageBoxIcon.Error);
            splitContainer.InvokeIfRequired(c => c.Panel2Collapsed = success);
        }

        private void btnCancelRegisterOrUpdate_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2Collapsed = true;
        }

        private object Register(object obj)
        {
            var success = GuestManagement.SaveOrUpdate(obj as GuestInfo);

            return success;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClinicManager.Common;

namespace ClinicManager.Presentation
{
    public partial class ConfigForm : DevExpress.XtraEditors.XtraForm
    {
        private bool success;
        private const string ConnectCaption = "Thông tin kết nối";
        public ConfigForm()
        {
            InitializeComponent();
            success = false;
        }

        private void buttonCheckServer_Click(object sender, EventArgs e)
        {
            comboboxDatabase.Properties.Items.Clear();
            var databases = ConfigService.GetDatabase(textServer.Text, textUserName.Text, textPassword.Text);

            if (databases.Count > 0)
            {
                comboboxDatabase.Properties.Items.AddRange(databases);
                XtraMessageBox.Show(this, @"Kết nối thành công",
                    ConnectCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Không thể kết nối tới server",
                    ConnectCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboboxDatabase.SelectedIndex < 0)
            {
                XtraMessageBox.Show(this, @"Chưa chọn Cơ sở dữ liệu",
                   ConnectCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (ConfigService.TryConnect(textServer.Text, comboboxDatabase.Text, 
                                        textUserName.Text, textPassword.Text))
            {
                if (XtraMessageBox.Show(this,
                        "Kết nối thành công.\nBạn có muốn lưu cấu hình và bắt đầu sử dụng hệ thống không?",
                        ConnectCaption,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)
                        .Equals(DialogResult.No)) return;

                ConfigService.ChangeConnectionString(textServer.Text, comboboxDatabase.Text,
                                                    textUserName.Text, textPassword.Text);
                success = true;
                Close();
            }
            else
            {
                XtraMessageBox.Show(@"Không thể kết nối tới cơ sở dữ liệu. \nVui lòng thử lại",
                    ConnectCaption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (success)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
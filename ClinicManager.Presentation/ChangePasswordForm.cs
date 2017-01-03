using ClinicManager.Common;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class ChangePasswordForm : Form
    {
        private User user;
        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!CheckInput()) return;

            user.Password = Security.Md5Hash(textEditNewPassword.Text);

            Close();
        }

        private bool CheckInput()
        {
            string message = "";

            if (string.IsNullOrEmpty(textEditOldPassword.Text))
            {
                message = "Chưa nhập mật khẩu cũ";
            }
            else if (string.IsNullOrEmpty(textEditNewPassword.Text))
            {
                message = "Chưa nhập mật khẩu mới";
            }
            else if (string.IsNullOrEmpty(textEditConfirm.Text))
            {
                message = "Chưa xác nhận mật khẩu";
            }
            else if (textEditNewPassword.Text != textEditConfirm.Text)
            {
                message = "Mật khẩu xác nhận không đúng";
            }
            else if (user.Password != Security.Md5Hash(textEditOldPassword.Text))
            {
                message = "Mật khẩu cũ không đúng";
            }
            if (message != "")
            {
                XtraMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK);
                return false;
            }


            return true;
        }
    }
}

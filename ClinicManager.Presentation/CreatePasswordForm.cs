using ClinicManager.Common;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class CreatePasswordForm : Form
    {
        private User user;
        public CreatePasswordForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!CheckInput()) return;
            user.Password = Security.Md5Hash(textEditPassword.Text);
            Close();
        }

        private bool CheckInput()
        {
            string message = "";
            if (string.IsNullOrEmpty(textEditConfirm.Text))
            {
                message = "Chưa nhập mật khẩu xác nhận";
            }
            else if (string.IsNullOrEmpty(textEditPassword.Text))
            {
                message = "Chưa nhập mật khẩu";
            }
            else if (textEditPassword.Text != textEditConfirm.Text)
            {
                message = "Mật khẩu xác nhận không đúng";
            }

            if (message != "")
            {
                XtraMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}

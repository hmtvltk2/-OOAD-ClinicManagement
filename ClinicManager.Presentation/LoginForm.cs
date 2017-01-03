using ClinicManager.DataBusiness;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class LoginForm : Form
    {
        private UserBusiness userBusiness;
        private bool success;
        public LoginForm()
        {
            InitializeComponent();
            userBusiness = new UserBusiness();
            success = false;
        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textUsername.Text))
            {
                XtraMessageBox.Show(this, "Nhập tên đăng nhập",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                XtraMessageBox.Show(this, "Nhập mật mã",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textPassword.Focus();
                return;
            }
            var status = userBusiness.GetLoginUser(textUsername.Text, textPassword.Text);
            var message = string.Empty;
            switch (status)
            {
                case LoginStatus.LoginFail:
                    message = "Không thể đăng nhập lúc này";
                    break;
                case LoginStatus.NoAccount:
                    message = "Tài khoản không tồn tại";
                    break;
                case LoginStatus.WrongPassword:
                    message = "Sai mật mã";
                    break;
            }
            if (!string.IsNullOrEmpty(message))
            {
                XtraMessageBox.Show(message,
                    "Thông tin đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            success = true;
            Close();      
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (success)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}

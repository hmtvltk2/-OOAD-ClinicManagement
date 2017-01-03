using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class UserForm : DevExpress.XtraEditors.XtraForm
    {
        private User currentUser;
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, System.EventArgs e)
        {
            currentUser = UserBusiness.User;
            var userGroupBusiness = new UserGroupBusiness();
            textEditId.EditValue = UserBusiness.User.UserID;
            textEditFullName.EditValue = UserBusiness.User.FullName;
            textEditEmail.EditValue = UserBusiness.User.Email;
            textEditAddress.EditValue = UserBusiness.User.Address;
            textUserGroup.EditValue = userGroupBusiness.GetByUserGroupID(UserBusiness.User.UserGroupID).UserGroupName;
            textEditUsername.EditValue = UserBusiness.User.Username;
            dateDateOfBirth.EditValue = UserBusiness.User.DateOfBirth;
        }

        private void buttonClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonChagePassword_Click(object sender, System.EventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<ChangePasswordForm>())
            {
                form.Activate();
                return;
            }
            var f = new ChangePasswordForm(currentUser);
            f.Show();
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!CheckInput()) return;
            BindingData();
            var userBusiness = new UserBusiness();
            if (userBusiness.Update(currentUser))
            {
                XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void BindingData()
        {        
            currentUser.Address = textEditAddress.Text;
            currentUser.DateOfBirth = (DateTime)dateDateOfBirth.EditValue;
            currentUser.Email = textEditEmail.Text;
            currentUser.FullName = textEditFullName.Text;
        }

        private bool CheckInput()
        {
            string message = "";
            if (dateDateOfBirth.EditValue == null)
            {
                message = "Chưa chọn ngày sinh";
            }
            else if (string.IsNullOrWhiteSpace(textEditAddress.Text))
            {
                message = "Chưa nhập địa chỉ";
            }
            else if (string.IsNullOrWhiteSpace(textEditEmail.Text))
            {
                message = "Chưa nhập email";
            }
            else if (string.IsNullOrWhiteSpace(textEditFullName.Text))
            {
                message = "Chưa nhập họ tên";
            }
            else if (!Common.Helper.CheckEmail(textEditEmail.Text))
            {
                message = "Email không đúng";
            }
            else if (string.IsNullOrEmpty(currentUser.Password))
            {
                message = "Chưa tạo mật khẩu";
            }

            if (message != "")
            {
                XtraMessageBox.Show(this, message, "Lỗi", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}

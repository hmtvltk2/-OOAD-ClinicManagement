using ClinicManager.DataBusiness;
using ClinicManager.Common;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Windows.Forms;
using System.Linq;
using ClinicManager.DataModel;

namespace ClinicManager.Presentation
{
    public partial class UserManagerForm : DevExpress.XtraEditors.XtraForm
    {
        private SaveMode saveMode;
        private User userSelected;
        private UserBusiness userBusiness;

        public UserManagerForm()
        {
            InitializeComponent();
            saveMode = SaveMode.None;
            userSelected = new User();
            userBusiness = new UserBusiness();
        }

        private void UserManagerForm_Load(object sender, System.EventArgs e)
        {
            var users = userBusiness.GetAllWithUserGroupName();
            gridControl1.DataSource = users;

            var userGroupBusiness = new UserGroupBusiness();
            var lookup = lookUpEditUerGroup.Properties;
            lookup.DataSource = userGroupBusiness.GetAll();
            lookup.Columns.Add(new LookUpColumnInfo("UserGroupID", "Mã"));
            lookup.Columns.Add(new LookUpColumnInfo("UserGroupName", "Tên loại người dùng"));
            lookup.DisplayMember = "UserGroupName";
            lookup.ValueMember = "UserGroupID";      
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, System.EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn chắc chắc muốn xóa dòng này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var row = gridView1.GetFocusedDataRow();
                if (!userBusiness.Delete(int.Parse(row["Id"].ToString())))
                {
                    XtraMessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                gridView1.DeleteSelectedRows();

                var users = userBusiness.GetAllWithUserGroupName();
                gridControl1.DataSource = users;
                if (users.Rows.Count > 0)
                {
                    gridView1.SelectRow(0);
                }
                else
                {
                    ClearAll();
                }
            }
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!CheckInput()) return;
            BindingData();
            bool result = false;
            if (saveMode == SaveMode.Insert)
            {
                result = userBusiness.Insert(userSelected) > 0;

            }
            else if (saveMode == SaveMode.Update)
            {
                result = userBusiness.Update(userSelected);
            }

            if (result)
            {
                XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                XtraMessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK);
            }

            ClearAll();
            saveMode = SaveMode.Update;
            textEditUsername.ReadOnly = true;
            gridControl1.DataSource = userBusiness.GetAllWithUserGroupName();
        }

        private bool CheckInput()
        {
            string message = "";
           
            if (string.IsNullOrWhiteSpace(textEditFullName.Text))
            {
                message = "Chưa nhập họ tên";
            }
            else if (string.IsNullOrWhiteSpace(textEditUsername.Text))
            {
                message = "Chưa nhập tên đăng nhập";
            }
            else if (!string.IsNullOrWhiteSpace(textEditEmail.Text))
            {
                if (!Common.Helper.CheckEmail(textEditEmail.Text))
                {
                    message = "Email không đúng";
                }                   
            }
            else if (string.IsNullOrEmpty(userSelected.Password))
            {
                message = "Chưa tạo mật khẩu";
            }

            if (message != "")
            {
                XtraMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            if (saveMode == SaveMode.Insert)
            {
                if (XtraMessageBox.Show("Bạn có muốn xóa tất cả dữ liệu vừa nhập?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
            }
            saveMode = SaveMode.Insert;
            ClearAll();
        }

        private void ClearAll()
        {
            textEditAddress.Text = "";
            textEditEmail.Text = "";
            textEditFullName.Text = "";
            textEditUserID.Text = "";
            textEditUsername.Text = "";     
            textEditUsername.ReadOnly = false;
            dateEditBirthday.EditValue = null;
            lookUpEditUerGroup.EditValue = null;       
            userSelected = new User();
        }

        private void buttonCreatePassword_Click(object sender, System.EventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<CreatePasswordForm>())
            {
                form.Activate();
                return;
            }
            var f = new CreatePasswordForm(userSelected);
            f.Show();
        }

        private void BindingData()
        {
            if (saveMode == SaveMode.Update)
            {
                userSelected.UserID = int.Parse(textEditUserID.Text);
            }
         
            userSelected.Address = textEditAddress.Text;          
            userSelected.DateOfBirth = dateEditBirthday.EditValue as DateTime?;
            userSelected.Email = textEditEmail.Text;
            userSelected.Username = textEditUsername.Text;
            userSelected.FullName = textEditFullName.Text;
            userSelected.UserGroupID = (int)lookUpEditUerGroup.EditValue;        
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            if (saveMode == SaveMode.Insert) return;
            var row = gridView1.GetFocusedDataRow();
            
            userSelected = new User
            {
                UserID = (int)row["UserID"],
                Address = (string)row["Address"],          
                Email = (string)row["Email"],
                FullName = (string)row["FullName"],
                Password = (string)row["Password"],
                UserGroupID = (int)row["UserGroupId"],
                Username = (string)row["UserName"]
            };

            if(row["DateOfBirth"] != DBNull.Value)
            {
                userSelected.DateOfBirth = (DateTime)row["DateOfBirth"];
            }

            textEditAddress.Text = userSelected.Address;
            textEditEmail.Text = userSelected.Email;
            textEditFullName.Text = userSelected.FullName;
            textEditUsername.Text = userSelected.Username;
            textEditUserID.Text = userSelected.UserID.ToString();
            lookUpEditUerGroup.EditValue = row["UserGroupID"];
            dateEditBirthday.EditValue = userSelected.DateOfBirth;
            saveMode = SaveMode.Update;
        }
    }

    enum SaveMode
    {
        Insert,
        Update,
        None
    }
}
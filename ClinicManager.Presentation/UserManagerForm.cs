using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.Native;
using LibraryManager.Common;
using LibraryManager.DataBusiness;
using LibraryManager.DataModel;

namespace LibraryManager.Presentation.GUI
{
    public partial class UserManagerForm : XtraForm
    {
        private bool _isInsert;
        public UserManagerForm()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private bool CheckSave = false;
       
       
        private void textEditName_KeyPress(object sender, KeyPressEventArgs e)
        {
            StaticMethod.EnterOnlyLetter(e);
        }

        


        private void UserManagerForm_Load(object sender, EventArgs e)
        {
            lookUpEditUerGroup.Properties.DataSource = UserGroupService.LoadTable();
            lookUpEditUerGroup.Properties.ValueMember = "Id";
            lookUpEditUerGroup.Properties.DisplayMember = "Name";
            lookUpEditUerGroup.Properties.Columns.Add(new LookUpColumnInfo("Id", "Mã loại người dùng"));
            lookUpEditUerGroup.Properties.Columns.Add(new LookUpColumnInfo("Name", "Tên loại người dùng"));



            gridControl1.DataSource = UserService.GetByAll();
        }

        private bool CheckInput()
        {

            string message = "";
            if (textEditName.Text == "")
            {
                message = "Tên người dùng không được rỗng";
            }
            else if (lookUpEditUerGroup.EditValue== null)
            {
                message = "Loại người dùng không được rỗng";
            }
            else if (textBoAddress.Text == "")
            {
                message = "Địa chỉ không đươc rỗng";
            }
            else if (textEditEmail.Text == "")
            {
                message = "Email không được rỗng";
            }
            if (message != "")
            {
                XtraMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void textEditEmail_Validating_1(object sender, CancelEventArgs e)
        {
            if (!StaticMethod.CheckEmail(textEditEmail.Text))
               
                e.Cancel = true;

        }

        private void textEditEmail_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Email nhập chưa đúng";
        }

        private void textEditCheckPassword_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void textEditCheckPassword_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = " Mật khẩu xác nhận chưa đúng";
        }

        private void textEditUserName_Validating(object sender, CancelEventArgs e)
        {
            var users = UserService.GetByUserName(textEditUserName.Text);
            if (users.Rows.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void textEditUserName_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "UserName đã tồn tại";
        }

        private void simpleButtonAdd_Click(object sender, EventArgs e)
        {
            CheckSave = false;
            _isInsert = true;
        }

        private void simpleButtonDel_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void simpleButtonEdit_Click(object sender, EventArgs e)
        {
            _isInsert = false;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e)
        {
            var result = true;
            if (!CheckInput()) return;

            var user = new UserInfo();
            using (var stream = new MemoryStream())
            {
                if (pictureEditAvatar.Image == null)
                    user.Avatar = new byte[0];
                else
                {
                    pictureEditAvatar.Image.Save(stream, pictureEditAvatar.Image.RawFormat);
                    user.Avatar = stream.ToArray();
                }

                user.Id = int.Parse(lookUpEditUerGroup.EditValue.ToString());
                user.FullName = textEditName.Text;
                user.Email = textEditEmail.Text;
                user.Birthday = DateTime.Parse(dateEditBirthaday.EditValue.ToString());
                user.Address = textBoAddress.Text;
                user.UserGroupId = byte.Parse(lookUpEditUerGroup.EditValue.ToString());
                user.UserName = textEditUserName.Text;
                user.Password = textEditPassword.Text;
                if (_isInsert)
                {
                    if (UserService.Insert(new UserInfo()
                    {


                    })) result = false;
                }
                else
                {
                    if (UserService.Update(new UserInfo()
                    {

                    })) result = false;
                }


                if (result)
                {
                    XtraMessageBox.Show("Lưu thành công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    simpleButtonSave.Enabled = false;
                    CheckSave = true;

                }

                else
                {
                    XtraMessageBox.Show("Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
     

        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (CheckSave) return;
            else
                if (
                    XtraMessageBox.Show("Bảng quản lí người dùng chưa được lưu. Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
        }
        //public int Id { get; set; }
        //public byte UserGroupId { get; set; }
        //public string FullName { get; set; }
        //public string Address { get; set; }
        //public DateTime Birthday { get; set; }
        //public string Email { get; set; }
        //public byte[] Avatar { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var row = gridView1.GetFocusedRow() as DataRowView;
            if (row == null) return;
            pictureEditAvatar.EditValue = row["Avatar"];
            textEditName.Text = row["FullName"].ToString();
            textBoAddress.Text = row["Address"].ToString();
            textEditEmail.Text = row["Email"].ToString();
            textEditUserName.Text = row["UserName"].ToString();
            textEditUserName.Text = row["FullName"].ToString();
            dateEditBirthaday.Text = row["Birthday"].ToString();
            lookUpEditUerGroup.EditValue = row["UserGroupId"];
            

        }

        
    }
}

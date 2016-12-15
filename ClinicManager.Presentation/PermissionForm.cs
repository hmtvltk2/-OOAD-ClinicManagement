using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LibraryManager.DataBusiness;
using LibraryManager.DataModel;

namespace LibraryManager.Presentation.GUI
{
    public partial class PermissionForm : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _authorizations;
        private SaveMode _saveMode;
        public PermissionForm()
        {
            InitializeComponent();
            _saveMode = SaveMode.None;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _saveMode = SaveMode.Insert;
            ClearAll();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            bool result = false;
            if (_saveMode == SaveMode.Insert)
            {
                result = UserGroupService.Insert(new UserGroupInfo {
                    Name = textEditName.Text
                });

                var userGroupId = UserGroupService.GetLastId();

                if (result)
                {
                    for (int i = 0; i < checkedListPermission.Items.Count; i++)
                    {
                        if (checkedListPermission.GetItemChecked(i))
                        {
                            result = result && PermissionsService.Insert(new PermissionsInfo
                            {
                                AuthorizationId = int.Parse(_authorizations.Rows[i]["Id"].ToString()),
                                UserGroupId = userGroupId
                            });
                        }
                    }
                }
            }
            else if (_saveMode == SaveMode.Update)
            {
                result = UserGroupService.Update(new UserGroupInfo {
                    Id = byte.Parse(textEditId.Text),
                    Name = textEditName.Text
                });

                if (result)
                {
                    result = PermissionsService.DeleteAllAuthorization(int.Parse(textEditId.Text));
                    for (int i = 0; i < checkedListPermission.Items.Count; i++)
                    {
                        if (checkedListPermission.GetItemChecked(i))
                        {
                            result = result && PermissionsService.Insert(new PermissionsInfo
                            {
                                AuthorizationId = int.Parse(_authorizations.Rows[i]["Id"].ToString()),
                                UserGroupId = int.Parse(textEditId.Text)
                            });
                        }
                    }
                }
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
            _saveMode = SaveMode.Update;
            gridControl1.DataSource = UserGroupService.GetByAll();
        }

        private bool CheckInput()
        {
            string message = "";

            if (string.IsNullOrWhiteSpace(textEditName.Text))
            {
                message = "Tên nhóm người dùng không được trống";
            }

            if (message != "")
            {
               XtraMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắc muốn xóa dòng này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var row = gridView1.GetFocusedDataRow();
                int id = int.Parse(row["Id"].ToString());
                if (!(PermissionsService.DeleteAllAuthorization(id) && UserGroupService.Delete(id)))
                {
                   XtraMessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                gridView1.DeleteSelectedRows();

                var users = UserGroupService.GetByAll();
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

        private void ClearAll()
        {
            checkedListPermission.UnCheckAll();
            textEditId.Text = "";
            textEditName.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void PermissionForm_Load(object sender, EventArgs e)
        {
            _authorizations = AuthorizationService.GetByAll();
            for (int i = 0; i < _authorizations.Rows.Count; i++)
            {
                checkedListPermission.Items.Add(_authorizations.Rows[i]["Name"]);
            }

            var permission = UserGroupService.GetByAll();
            gridControl1.DataSource = permission;
            if (permission.Rows.Count > 0)
            {
                gridView1.SelectRow(0);
            }
            
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            if (_saveMode == SaveMode.Insert) return;
                     
            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            int userGroupId = int.Parse(row["Id"].ToString());

            var permissions = PermissionsService.GetByUserGroupId(userGroupId);
            checkedListPermission.UnCheckAll();
            for (int i = 0; i < permissions.Rows.Count; i++)
            {
                for (int j = 0; j < _authorizations.Rows.Count; j++)
                {
                    if (permissions.Rows[i]["AuthorizationId"].Equals(_authorizations.Rows[j]["Id"]))
                    {
                        checkedListPermission.SetItemChecked(j, true);
                    }
                }
            }

            textEditId.Text = row["Id"].ToString();
            textEditName.Text = row["Name"].ToString();

            _saveMode = SaveMode.Update;
        }
    }
}
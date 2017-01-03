using ClinicManager.DataBusiness;
using ClinicManager.Common;
using DevExpress.XtraEditors;
using System.Data;
using System.Windows.Forms;
using ClinicManager.DataModel;

namespace ClinicManager.Presentation
{
    public partial class PermissionForm : DevExpress.XtraEditors.XtraForm
    {
        private PermissionBusiness permissionBusiness;
        private UserGroupBusiness userGroupBusiness;
        private PermissionDetailBusiness perDetailBusiness;
        private DataTable permissions;
        private SaveMode saveMode;
        public PermissionForm()
        {
            InitializeComponent();
            saveMode = SaveMode.None;
            permissionBusiness = new PermissionBusiness();
            userGroupBusiness = new UserGroupBusiness();
            perDetailBusiness = new PermissionDetailBusiness();
        }

        private void PermissionForm_Load(object sender, System.EventArgs e)
        {
            permissions = permissionBusiness.GetAll();
            for (int i = 0; i < permissions.Rows.Count; i++)
            {
                checkedListPermission.Items.Add(permissions.Rows[i]["PermissionName"]);
            }

            var permission = userGroupBusiness.GetAll();
            gridControl1.DataSource = permission;
            if (permission.Rows.Count > 0)
            {
                gridView1.SelectRow(0);
            }
        }

        private void buttonClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắc muốn xóa dòng này?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var row = gridView1.GetFocusedDataRow();
                int id = int.Parse(row["UserGroupID"].ToString());
                if (!(perDetailBusiness.DeleteByUserGroupID(id) && userGroupBusiness.Delete(id)))
                {
                    XtraMessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                gridView1.DeleteSelectedRows();
               
                var permission = userGroupBusiness.GetAll();
                gridControl1.DataSource = permission;
                if (permission.Rows.Count > 0)
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
            bool result = false;
            if (saveMode == SaveMode.Insert)
            {
                var userGroupId = userGroupBusiness.Insert(new UserGroup
                {
                    UserGroupName = textEditName.Text
                });

                result = userGroupId > 0;

                if (result)
                {
                    for (int i = 0; i < checkedListPermission.Items.Count; i++)
                    {
                        if (checkedListPermission.GetItemChecked(i))
                        {
                            result = result && perDetailBusiness.Insert(new PermissionDetail
                            {
                                PermissionID = (int)permissions.Rows[i]["PermissionID"],
                                UserGroupID = userGroupId
                            });
                        }
                    }
                }
            }
            else if (saveMode == SaveMode.Update)
            {
                result = userGroupBusiness.Update(new UserGroup
                {
                    UserGroupID = byte.Parse(textEditId.Text),
                    UserGroupName = textEditName.Text
                });

                if (result)
                {
                    result = perDetailBusiness.DeleteByUserGroupID(int.Parse(textEditId.Text));
                    for (int i = 0; i < checkedListPermission.Items.Count; i++)
                    {
                        if (checkedListPermission.GetItemChecked(i))
                        {
                            result = result && perDetailBusiness.Insert(new PermissionDetail
                            {
                                PermissionID = int.Parse(permissions.Rows[i]["PermissionID"].ToString()),
                                UserGroupID = int.Parse(textEditId.Text)
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
            saveMode = SaveMode.Update;
            gridControl1.DataSource = userGroupBusiness.GetAll();
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

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            saveMode = SaveMode.Insert;
            ClearAll();
        }

        private void ClearAll()
        {
            checkedListPermission.UnCheckAll();
            textEditId.Text = "";
            textEditName.Text = "";
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            if (saveMode == SaveMode.Insert) return;

            var row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            int userGroupId = int.Parse(row["UserGroupID"].ToString());

            var permOfUserGroup = permissionBusiness.GetByUserGroupId(userGroupId);
            checkedListPermission.UnCheckAll();
            foreach (DataRow item in permOfUserGroup.Rows)
            {
                for (int j = 0; j < permissions.Rows.Count; j++)
                {
                    if (item["PermissionID"].Equals(permissions.Rows[j]["PermissionID"]))
                    {
                        checkedListPermission.SetItemChecked(j, true);
                    }
                }
            }

            textEditId.Text = row["UserGroupID"].ToString();
            textEditName.Text = row["UserGroupName"].ToString();

            saveMode = SaveMode.Update;
        }
    }
}
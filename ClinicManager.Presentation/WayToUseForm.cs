using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using System;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class WayToUseForm : XtraForm
    {
        private WayToUseBusiness wayToUseBusiness;
        public WayToUseForm()
        {
            InitializeComponent();
            wayToUseBusiness = new WayToUseBusiness();
        }

        private void WayToUseForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = wayToUseBusiness.GetAll();
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row["WayToUseName"].ToString() == "")
            {
                e.Valid = false;
                e.ErrorText = "Chưa nhập đường dùng";
                gridView1.SetColumnError(WayToUseName, e.ErrorText);
            }
            if (row["WayToUseName"].ToString() != "")
            {
                e.ErrorText = "";
                gridView1.SetColumnError(WayToUseName, e.ErrorText);
            }
                if (row.IsNull("WayToUseName"))
            {
                e.Valid = false;
                e.ErrorText = "Chưa nhập đường dùng";
                gridView1.SetColumnError(WayToUseName, e.ErrorText);
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Insert, update row
            var row = gridView1.GetFocusedDataRow();
            bool isInsert = row["WayToUseID"].ToString() == "";

            bool result;

            if (isInsert)
            {
                WayToUse wayToUse = new WayToUse()
                {
                    WayToUseName = (string)row["WayToUseName"]
                };

                int id = wayToUseBusiness.Insert(wayToUse);
                if (id == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                    row["WayToUseID"] = id;
                }
            }
            else
            {
                WayToUse wayToUse = new WayToUse()
                {
                    WayToUseID = (int)row["WayToUseID"],
                    WayToUseName = (string)row["WayToUseName"]
                };

                result = wayToUseBusiness.Update(wayToUse);
            }

            if (result)
            {
                XtraMessageBox.Show(this, "Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(this, "Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositoryItemDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle == GridControl.NewItemRowHandle)
            {
                return;
            }
            if (XtraMessageBox.Show(this, "Bạn chắc chắn xóa dòng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var row = gridView1.GetFocusedDataRow();

                bool result = wayToUseBusiness.Delete((int)row["WayToUseID"]);
                if (result)
                {
                    gridView1.DeleteSelectedRows();
                }
                else
                {
                    XtraMessageBox.Show(this, "Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


}
    }

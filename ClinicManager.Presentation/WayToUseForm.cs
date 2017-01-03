using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClinicManager.DataBusiness;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using ClinicManager.Common;
using DevExpress.XtraGrid.Columns;
using ClinicManager.DataModel;

namespace ClinicManager.Presentation
{
    public partial class WayToUseForm : DevExpress.XtraEditors.XtraForm
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

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            foreach (GridColumn col in gridView1.Columns)
            {
                if (col.ColumnEditName == repositoryItemDelete.Name)
                {
                    continue;
                }

                e.ErrorText = wayToUseBusiness.Validate(row[col.FieldName], col.FieldName);
                if (e.ErrorText != "")
                {
                    e.Valid = false;
                    gridView1.SetColumnError(col, e.ErrorText);
                }
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Insert, update row
            var row = (e.Row as System.Data.DataRowView).Row;
            bool result;

            if (gridView1.IsNewItemRow(e.RowHandle))
            {
                //insert
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
                //update
                WayToUse WayToUse = new WayToUse()
                {
                    WayToUseID = (int)row["WayToUseID"],
                    WayToUseName = (string)row["WayToUseName"]
                };

                result = wayToUseBusiness.Update(WayToUse);
            }

            if (result)
            {
                XtraMessageBox.Show(this, "Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridView1.FocusedRowHandle = GridControl.NewItemRowHandle;
            }
            else
            {
                XtraMessageBox.Show(this, "Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
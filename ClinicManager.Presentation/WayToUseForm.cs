using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
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

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            string error = "";
            if (gridView1.FocusedColumn.FieldName == "WayToUseName")
            {
                WayToUse data = new WayToUse()
                {
                    WayToUseName = (string)e.Value
                };

                //error = wayToUseBusiness.Validate(data, "WayToUseName");
            }


            if (error != "")
            {
                e.Valid = false;
                e.ErrorText = error;
            }
        }

        private void gridView1_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
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

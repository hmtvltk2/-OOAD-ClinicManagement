using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class UnitForm : XtraForm
    {
        private UnitBusiness unitBusiness;
        public UnitForm()
        {
            InitializeComponent();
            unitBusiness = new UnitBusiness();
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = unitBusiness.GetAll();
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

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
            bool isInsert = row["UnitID"].ToString() == "";

            bool result;

            if (isInsert)
            {
                Unit unit = new Unit()
                {
                    UnitName = (string)row["UnitName"]
                };

                int id = unitBusiness.Insert(unit);
                if (id == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                    row["UnitID"] = id;
                }
            }
            else
            {
                Unit unit = new Unit()
                {
                    UnitID = (int)row["UnitID"],
                    UnitName = (string)row["UnitName"]
                };

                result = unitBusiness.Update(unit);
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

                bool result = unitBusiness.Delete((int)row["UnitID"]);
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

        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {

        }
    }
}

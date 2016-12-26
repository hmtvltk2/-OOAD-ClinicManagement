using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClinicManager.DataBusiness;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using ClinicManager.DataModel;

namespace ClinicManager.Presentation
{
    public partial class UnitForm : DevExpress.XtraEditors.XtraForm
    {
        private UnitBusiness UnitBusiness;

        public UnitForm()
        {
            InitializeComponent();
            UnitBusiness = new UnitBusiness();

        }
        private void UnitForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = UnitBusiness.GetAll();
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

                bool result = UnitBusiness.Delete((int)row["UnitID"]);
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
            if (row["UnitName"].ToString() == "")
            {
                e.Valid = false;
                e.ErrorText = "Chưa nhập đường dùng";
                gridView1.SetColumnError(UnitName, e.ErrorText);
            }
            if (row["UnitName"].ToString() != "")
            {
                e.ErrorText = "";
                gridView1.SetColumnError(UnitName, e.ErrorText);
            }
            if (row.IsNull("UnitName"))
            {
                e.Valid = false;
                e.ErrorText = "Chưa nhập đường dùng";
                gridView1.SetColumnError(UnitName, e.ErrorText);
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
            bool isInsert = row["UnitID"].ToString() == "";

            bool result;

            if (isInsert)
            {
                Unit Unit = new Unit()
                {
                    UnitName = (string)row["UnitName"]
                };

                int id = UnitBusiness.Insert(Unit);
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
                Unit Unit = new Unit()
                {
                    UnitID = (int)row["UnitID"],
                    UnitName = (string)row["UnitName"]
                };

                result = UnitBusiness.Update(Unit);
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
    }
}
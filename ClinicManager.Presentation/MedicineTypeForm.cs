using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;

namespace ClinicManager.Presentation
{
    public partial class MedicineTypeForm : DevExpress.XtraEditors.XtraForm
    {
        private MedicineTypeBusiness medicineTypeBusiness;
        public MedicineTypeForm()
        {
            InitializeComponent();
            medicineTypeBusiness = new MedicineTypeBusiness();
        }

        private void MedicineTypeForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = medicineTypeBusiness.GetAll();
        }


        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row["MedicineTypeName"].ToString() == "")
            {
                e.Valid = false;
                e.ErrorText = "Chưa nhập tên thể loại";
                gridView1.SetColumnError(MedicineTypeName, e.ErrorText);
            }
            else if (row["MedicineTypeName"].ToString() != "")
            {
                e.ErrorText = "";
                gridView1.SetColumnError(MedicineTypeName, e.ErrorText);
            }
            if (row.IsNull("MedicineTypeName"))
            {
                e.Valid = false;
                e.ErrorText = "Chưa nhập tên thể loại";
                gridView1.SetColumnError(MedicineTypeName, e.ErrorText);
            }


        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
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
            bool isInsert = row["MedicineTypeID"].ToString() == "";
      
            bool result;

            if (isInsert)
            {
                MedicineType medicineType = new MedicineType()
                {
                    MedicineTypeName = (string)row["MedicineTypeName"]
                };

                int id = medicineTypeBusiness.Insert(medicineType);
                if(id == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                    row["MedicineTypeID"] = id;
                }
            }
            else
            {
                MedicineType medicineType = new MedicineType()
                {
                    MedicineTypeID = (int)row["MedicineTypeID"],
                    MedicineTypeName = (string)row["MedicineTypeName"]
                };

                result = medicineTypeBusiness.Update(medicineType);
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



                    bool result = medicineTypeBusiness.Delete((int)row["MedicineTypeID"]);
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
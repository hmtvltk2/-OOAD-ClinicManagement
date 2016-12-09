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

namespace ClinicManager.Presentation
{
    public partial class PharmacyTypeForm : DevExpress.XtraEditors.XtraForm
    {
        private PharmacyTypeBusiness pharmacyTypeBusiness;
        public PharmacyTypeForm()
        {
            InitializeComponent();
            pharmacyTypeBusiness = new PharmacyTypeBusiness();
        }

        private void PharmacyTypeForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = pharmacyTypeBusiness.GetAll();
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            string error = "";
            if (gridView1.FocusedColumn.FieldName == "PharmacyTypeName")
            {
                PharmacyTypeForm data = new PharmacyType()
                {
                    PharmacyTypeName = (string)e.Value
                };

                error = pharmacyTypeBusiness.Validate(data, "PharmacyTypeName");
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
            bool isInsert = row["PharmacyTypeID"].ToString() == "";
            var PharmacyTypeBusiness = new PharmacyTypeBusiness();
            bool result;

            if (isInsert)
            {
                PharmacyTypeForm PharmacyType = new PharmacyTypeForm()
                {
                    PharmacyTypeName = (string)row["PharmacyTypeName"]
                };

                int id = pharmacyTypeBusiness.Insert(PharmacyType);
                if (id == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                    row["PharmacyTypeID"] = id;
                }
            }
            else
            {
                PharmacyTypeForm PharmacyType = new PharmacyTypeForm()
                {
                    PharmacyTypeID = (int)row["PharmacyTypeID"],
                    PharmacyTypeName = (string)row["PharmacyTypeName"]
                };

                result = pharmacyTypeBusiness.Update(PharmacyType);
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

                bool result = pharmacyTypeBusiness.Delete((int)row["PharmacyTypeID"]);
                if (result == false)
                {
                    XtraMessageBox.Show(this, "Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                gridView1.DeleteSelectedRows();
            }
        }
    }
}
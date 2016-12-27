﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;

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
       

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            if (row["PharmacyTypeName"].ToString() == "")
            {
                e.Valid = false;
                e.ErrorText = "Chưa nhập dạng bào chế";
                gridView1.SetColumnError(PharmacyTypeName, e.ErrorText);
            }
            else if (row["PharmacyTypeName"].ToString() != "")
            {
                e.ErrorText = "";
                gridView1.SetColumnError(PharmacyTypeName, e.ErrorText);
            }
            if (row.IsNull("PharmacyTypeName"))
            {
                e.Valid = false;
                e.ErrorText = "Chưa nhập dạng bào chế";
                gridView1.SetColumnError(PharmacyTypeName, e.ErrorText);
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
            bool isInsert = row["PharmacyTypeID"].ToString() == "";
            bool result;

            if (isInsert)
            {
                PharmacyType PharmacyType = new PharmacyType()
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
                PharmacyType PharmacyType = new PharmacyType()
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
            if (gridView1.FocusedRowHandle == GridControl.NewItemRowHandle)
            {
                return;
            }
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
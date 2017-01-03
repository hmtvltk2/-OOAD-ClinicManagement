using ClinicManager.DataBusiness;
using ClinicManager.Common;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using System;
using System.Data;
using System.Windows.Forms;
using ClinicManager.DataModel;

namespace ClinicManager.Presentation
{
    public partial class MedicineManagerForm : XtraForm
    {
        private MedicineBusiness medicineBusiness;
        public MedicineManagerForm()
        {
            InitializeComponent();
            medicineBusiness = new MedicineBusiness();
        }

        private void MedicineManagerForm_Load(object sender, EventArgs e)
        {

            // Load Medicine table

            gridCMedicineList.DataSource = medicineBusiness.GetAll();
            //Load table to show on looktupedit MedicineType
            MedicineTypeBusiness medicineTypeBusiness = new MedicineTypeBusiness();
            LookUpType.DataSource = medicineTypeBusiness.GetAll(); // Set data source
            LookUpType.ValueMember = "MedicineTypeID"; // Set value to save db
            LookUpType.DisplayMember = "MedicineTypeName"; //Set value to display
                                                           //Add column to chose
                                                           //LookUpType.Columns.Add(new LookUpColumnInfo("MedicineTypeID", "Mã loại thuốc"));
            LookUpType.Columns.Add(new LookUpColumnInfo("MedicineTypeName", "Tên loại thuốc"));
            //WaytoUse
            WayToUseBusiness wayToUse = new WayToUseBusiness();
            LookUpWay.DataSource = wayToUse.GetAll();
            LookUpWay.ValueMember = "WayToUseID";
            LookUpWay.DisplayMember = "WayToUseName";
            LookUpWay.Columns.Add(new LookUpColumnInfo("WayToUseName", "Đường dùng"));
            //Pharamcy
            PharmacyTypeBusiness medicine = new PharmacyTypeBusiness();
            LookUpPharmacy.DataSource = medicine.GetAll();
            LookUpPharmacy.ValueMember = "PharmacyTypeID";
            LookUpPharmacy.DisplayMember = "PharmacyTypeName";
            LookUpPharmacy.Columns.Add(new LookUpColumnInfo("PharmacyTypeName", "Dạng bào chế"));
            //Unit
            UnitBusiness unit = new UnitBusiness();
            LookUpUnit.DataSource = unit.GetAll();
            LookUpUnit.ValueMember = "UnitID";
            LookUpUnit.DisplayMember = "UnitName";
            LookUpUnit.Columns.Add(new LookUpColumnInfo("UnitName", "Đơn vị"));
            // Load data for comboboxedit MedicinType
            // Add default row "Tất cả"
            DataTable datasource = medicineTypeBusiness.GetAll();
            var row = datasource.NewRow();
            row["MedicineTypeID"] = 0;
            row["MedicineTypeName"] = "Tất cả";
            datasource.Rows.Add(row);
           
            lookUpEditType.Properties.DataSource = datasource; // Set data source
            lookUpEditType.Properties.ValueMember = "MedicineTypeID"; // Set value to save db
            lookUpEditType.Properties.DisplayMember = "MedicineTypeName"; //Set value to display
                                                               //Add column to chose
                                                               //LookUpType.Columns.Add(new LookUpColumnInfo("MedicineTypeID", "Mã loại thuốc"));
            lookUpEditType.Properties.Columns.Add(new LookUpColumnInfo("MedicineTypeName", "Chọn"));
        }

        // Draw index column
        private void gridViewMedicineList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void repositoryItemDelete_Click(object sender, EventArgs e)
        {
            if (gridViewMedicineList.FocusedRowHandle == GridControl.NewItemRowHandle)
            {
                return;
            }

            if (XtraMessageBox.Show(this, "Bạn chắn chắn xóa dòng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var row = gridViewMedicineList.GetFocusedDataRow(); // get data on one row
                bool result = medicineBusiness.Delete((int)row["MedicineID"]); // delete in medicine database with paramater (datatype)row["ColumnName"]
                if (result)
                {
                    gridViewMedicineList.DeleteSelectedRows();
                }
                else
                {
                    XtraMessageBox.Show(this, "Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void gridViewMedicineList_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var row = gridViewMedicineList.GetFocusedDataRow();
            foreach (GridColumn col in gridViewMedicineList.Columns)
            {
                if (col.ColumnEditName == repositoryItemDelete.Name)
                {
                    continue;
                }
                var a = row[col.FieldName];
                e.ErrorText = medicineBusiness.Validate(row[col.FieldName], col.FieldName);
                if (e.ErrorText != "")
                {
                    e.Valid = false;     
                }
  
                gridViewMedicineList.SetColumnError(col, e.ErrorText);
            }
        }

        private void gridViewMedicineList_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Get data in focus row
            var row = (e.Row as DataRowView).Row;
            if (row == null)
            {
                return;
            }
            // status of upate/insert into db
            bool isInsert = row["MedicineID"].ToString() == "";
            bool result;
            //insert
            if (isInsert)
            {
                Medicine medicine = new Medicine()
                {
                    MedicineName = (string)row["MedicineName"],
                    MedicineTypeID = (int)row["MedicineTypeID"],
                    WayToUseID = (int)row["WayToUseID"],
                    PharmacyTypeID = (int)row["PharmacyTypeID"],
                    UnitID = (int)row["UnitID"],
                    Price = (decimal)row["Price"]
                };
                //get ID after save into db
                int id = medicineBusiness.Insert(medicine);
                if (id == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                    row["MedicineID"] = id;
                }

            }
            else // update row
            {
                Medicine medicine = new Medicine()
                {
                    MedicineID = (int)row["MedicineID"],
                    MedicineName = (string)row["MedicineName"],
                    MedicineTypeID = (int)row["MedicineTypeID"],
                    WayToUseID = (int)row["WayToUseID"],
                    PharmacyTypeID = (int)row["PharmacyTypeID"],
                    UnitID = (int)row["UnitID"],
                    Price = (decimal)row["Price"]
                };

                result = medicineBusiness.Update(medicine);
            }

            if (result)
            {
                XtraMessageBox.Show(this, "Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridViewMedicineList.FocusedRowHandle = GridControl.NewItemRowHandle;
            }
            else
            {
                XtraMessageBox.Show(this, "Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewMedicineList_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction; // Donn't show any acction except error text display
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // select all
            if (textMedicineName.Text == "" && lookUpEditType.EditValue == null)
            {
                gridCMedicineList.DataSource = medicineBusiness.GetAll();
            }
            // select with name and all Type (begin as null)
            else if (textMedicineName.Text != "" && lookUpEditType.EditValue == null)
            {
                gridCMedicineList.DataSource = medicineBusiness.GetByCondition(textMedicineName.Text.ToString());

            }
            // select with all;
            else if (textMedicineName.Text == "" && (int)lookUpEditType.EditValue == 0)
            {
                gridCMedicineList.DataSource = medicineBusiness.GetAll();

            }
            // Select name with all type (chose "tất cả")
            else if (textMedicineName.Text != "" && (int)lookUpEditType.EditValue == 0)
            {
                gridCMedicineList.DataSource = medicineBusiness.GetByCondition(textMedicineName.Text.ToString());

            }
            // select with 2 parameter
            else if (textMedicineName.Text != "" && lookUpEditType.EditValue != null)
            {
                gridCMedicineList.DataSource = medicineBusiness.GetByCondition(textMedicineName.Text.ToString(), int.Parse(lookUpEditType.EditValue.ToString()));
            }
          
          
           
            
            //select with all name belong one Type
            else if (textMedicineName.Text == "" && lookUpEditType.EditValue != null)
            {
                gridCMedicineList.DataSource = medicineBusiness.GetByCondition(int.Parse(lookUpEditType.EditValue.ToString()));

            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }    
}


using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class MedicineManagerForm : XtraForm
    {
        private MedicineBusiness medicineBusiness ;
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
            PharmacyTypeBusiness pharmacyType = new PharmacyTypeBusiness();
            LookUpPharmacy.DataSource = pharmacyType.GetAll();
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
            MedicineTypeBusiness medicineTypeBusinessLoopkup = new MedicineTypeBusiness();
            DataTable datasource = medicineTypeBusinessLoopkup.GetAll();
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
           
            var row = gridViewMedicineList.GetFocusedDataRow(); // Get data from focusrow
            //Check null one column in row variable
            if (row.IsNull("MedicineName"))
            {
                e.ErrorText = "Chưa nhập tên"; // Value to display when error.An empty string to clear the assigned error. 
                gridViewMedicineList.SetColumnError(gridColumnName, e.ErrorText); // Set error
                e.Valid = false;

            }
            // Condition when user type input and delete all character, so this is string = "",
            else if (!row.IsNull("MedicineName"))
            {

                e.ErrorText = "";
                gridViewMedicineList.SetColumnError(gridColumnName, e.ErrorText); 
            }
             if (row["MedicineName"].ToString() == "")
            {
                e.ErrorText = "Chưa nhập tên";
                gridViewMedicineList.SetColumnError(gridColumnName, e.ErrorText);
                e.Valid = false;
            }

            if (row.IsNull("MedicineTypeID"))
            {
                e.Valid = false;
                e.ErrorText = "Chưa chọn loại thuốc";
                gridViewMedicineList.SetColumnError(gridColumnType, e.ErrorText);
            }
            else if (!row.IsNull("MedicineTypeID"))
            {     
                e.ErrorText = "";
                gridViewMedicineList.SetColumnError(gridColumnType, e.ErrorText);
            }

            if (row.IsNull("WayToUseID"))
            {
                e.Valid = false;
                e.ErrorText = "Chưa chọn đường dùng";
                gridViewMedicineList.SetColumnError(gridColumnWay, e.ErrorText);

            }
            else if (!row.IsNull("WayToUseID"))
            {              
                e.ErrorText = "";
                gridViewMedicineList.SetColumnError(gridColumnWay, e.ErrorText);
            }

            if (row.IsNull("PharmacyTypeID"))
            {
                e.Valid = false;
                e.ErrorText = "Chưa chọng dạng điều chế";
                gridViewMedicineList.SetColumnError(gridColumnPhramacy, e.ErrorText);
            }
            else if (!row.IsNull("PharmacyTypeID"))
            {
                e.ErrorText = "";
                gridViewMedicineList.SetColumnError(gridColumnPhramacy, e.ErrorText);
            }
            if (row.IsNull("UnitID"))
            {
                e.Valid = false;
                e.ErrorText = "Chưa chọn đơn vị tính";
                gridViewMedicineList.SetColumnError(gridColumnUnit, e.ErrorText);
            }
            else if (!row.IsNull("UnitID"))
            {             
                e.ErrorText = "";
                gridViewMedicineList.SetColumnError(gridColumnUnit, e.ErrorText);
            }

        }





 

        private void gridViewMedicineList_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Get data in focus row
            var row = gridViewMedicineList.GetFocusedDataRow();
            // if isInsert ="" mean focusrow at add new row else at edit row
            bool isInsert = row["MedicineID"].ToString() == "";
            // status of upate/insert into db
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
                    UnitID = (int)row["UnitID"]
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
                    UnitID = (int)row["UnitID"]
                };

                result = medicineBusiness.Update(medicine);



            }

            if (result)
            {
                XtraMessageBox.Show(this, "Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


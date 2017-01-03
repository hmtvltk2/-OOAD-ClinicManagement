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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using ClinicManager.DataModel;
using DevExpress.XtraReports.UI;

namespace ClinicManager.Presentation
{
    public partial class PrescriptionForm : DevExpress.XtraEditors.XtraForm
    {
        private int prescriptionID;
        private PrescriptionDetailBusiness preDetailBusiness;
        private PrescriptionBusiness prescriptionBusiness;
        private DataTable medicineDT;
        private MedicineBusiness medicineBusiness;
        public PrescriptionForm(int prescriptionID)
        {
            InitializeComponent();
            this.prescriptionID = prescriptionID;
            preDetailBusiness = new PrescriptionDetailBusiness();
            prescriptionBusiness = new PrescriptionBusiness();
            medicineBusiness = new MedicineBusiness();
        }

        private void repositoryItemDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            //Load medical record infomation
            var prescriptionBusiness = new PrescriptionBusiness();
            DataRow row = prescriptionBusiness.GetMedicalRecordInfo(prescriptionID);
            if(row != null)
            {
                textPatientName.Text = (string)row["PatientName"];
                textDoctorName.Text = (string)row["DoctorName"];
                textExamineDate.Text = ((DateTime)row["ExamineDate"]).ToShortDateString();
                textDiagnostic.Text = (string)row["Diagnostic"];
                textNote.Text = row["Note"] as string;
            }

            //Load Prescription Detail
            gridControl1.DataSource = preDetailBusiness.GetDetailByPrescriptionID(prescriptionID);

            //Load lookupMedicine
            medicineDT = medicineBusiness.GetAllWithUnit();
            medicineDT.PrimaryKey = new DataColumn[] { medicineDT.Columns["MedicineID"] };
            repositoryLookUpMedicine.DataSource = medicineDT;
            repositoryLookUpMedicine.Columns.Add(new LookUpColumnInfo("MedicineName", "Tên thuốc"));
            repositoryLookUpMedicine.DisplayMember = "MedicineName";
            repositoryLookUpMedicine.ValueMember = "MedicineID";
        }

        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var presDetail = gridControl1.DataSource as DataTable;
            var result = preDetailBusiness.DeteleByPrescriptionID(prescriptionID);
            decimal amount = 0;
            foreach (DataRow item in presDetail.Rows)
            {
                var preDetail = new PrescriptionDetail
                {
                    HowToUse = (string)item["HowToUse"],
                    MedicineID = (int)item["MedicineID"],
                    Quantity = (int)item["Quantity"],
                    PrescriptionID = prescriptionID,
                    MedicineFee = medicineBusiness.GetByMedicineID((int)item["MedicineID"]).Price * (int)item["Quantity"]
                };
                result = result && preDetailBusiness.Insert(preDetail) > 0;
                if (!result)
                {
                    break;
                }
                amount += preDetail.MedicineFee;
            }

            var prescription = prescriptionBusiness.GetByPrescriptionID(prescriptionID);
            prescription.Amount = amount;
            result = result && prescriptionBusiness.Update(prescription);

            if (result)
            {
                XtraMessageBox.Show(this, "Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(this, "Có lỗi trong quá trình lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var dt = gridControl1.DataSource as DataTable;
            int i = 1;
            List<ReportPrescription> reportData = new List<ReportPrescription>();
            DataRow medicine;
            foreach (DataRow item in dt.Rows)
            {
                medicine = medicineDT.Rows.Find(item["MedicineID"]);
                reportData.Add(new ReportPrescription
                {
                    HowToUse = (string)item["HowToUse"],
                    MedicineName = i.ToString() + ". " + (string)medicine["MedicineName"],
                    Quantity = (int)item["Quantity"],
                    UnitName = (string)item["UnitName"]
                });
                i++;
            }
            PrescriptionRP report = new PrescriptionRP(reportData, textPatientName.Text, textDoctorName.Text,
                textExamineDate.Text, textNote.Text, textDiagnostic.Text);
            using (var reportTool = new ReportPrintTool(report))
            {
                reportTool.ShowPreviewDialog();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "MedicineID")
            {
                var row = gridView1.GetFocusedDataRow();
                var medicine = medicineDT.Rows.Find(e.Value);
                row["UnitName"] = medicine["UnitName"];
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
                var a = row[col.FieldName];
                e.ErrorText = prescriptionBusiness.Validate(row[col.FieldName], col.FieldName);
                if (e.ErrorText != "")
                {
                    e.Valid = false;
                }

                gridView1.SetColumnError(col, e.ErrorText);
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}
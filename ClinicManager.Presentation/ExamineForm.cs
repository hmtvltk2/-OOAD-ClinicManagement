using ClinicManager.DataBusiness;
using ClinicManager.Common;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using ClinicManager.DataModel;

namespace ClinicManager.Presentation
{
    public partial class ExamineForm : Form
    {
        private DataRow selecteRow;
        private QueueBusiness queueBusiness;
        private MedicalRecordBusiness medicalRecordBusiness;
        private ServiceDetailBusiness serviceDetailBusiness;
        private int prescriptionID;

        public ExamineForm()
        {
            InitializeComponent();
            queueBusiness = new QueueBusiness();
            medicalRecordBusiness = new MedicalRecordBusiness();
            serviceDetailBusiness = new ServiceDetailBusiness();           
        }

        private void ExamineForm_Load(object sender, EventArgs e)
        {
            LoadQueueByDoctor();
            LoadExaminedList();

            var serviceBusiness = new ServiceBusiness();
            repositoryLookUpService.DataSource = serviceBusiness.GetAll();
            repositoryLookUpService.Columns.Add(new LookUpColumnInfo("ServiceName", "Tên dịch vụ"));
            repositoryLookUpService.DisplayMember = "ServiceName";
            repositoryLookUpService.ValueMember = "ServiceID";

            //gridViewQueue.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Red;
        }

        private void LoadQueueByDoctor()
        {
            gridQueue.DataSource = queueBusiness.GetQueueByDoctorId(UserBusiness.User.UserID);
        }

        private void LoadExaminedList()
        {
            gridExaminedList.DataSource = medicalRecordBusiness.GetByDoctorId(UserBusiness.User.UserID);
        }

        private void gridExamined_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadQueueByDoctor();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            //Insert new medical record 
            var medicalRecord = new MedicalRecord {
                DoctorID = UserBusiness.User.UserID,
                PatientID = (int)selecteRow["PatientID"],
                Diagnostic = "",
                ExamineDate = (DateTime)dateExamineDay.EditValue,
                ExamineReason = (string)selecteRow["ExamineReason"]
            };

            var medicalRecordID = medicalRecordBusiness.Insert(medicalRecord);
            
            //Load service detail
            gridService.DataSource = serviceDetailBusiness.GetByMedicalRecordID(medicalRecordID);

            //Create Prescription
            var prescriptionBusiness = new PrescriptionBusiness();
            var prescription = new Prescription
            {
                MedicalRecordID = medicalRecordID
            };
            prescriptionID = prescriptionBusiness.Insert(prescription);

            textMedicalRecordID.EditValue = medicalRecordID;
            buttonUpdate.Enabled = true;
            buttonCreate.Enabled = false;
            UpdateUI();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool result = UpdateMedicalRecord();
            if (!result)
            {
                XtraMessageBox.Show(this, "Có lỗi trong quá trình lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show(this, "Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCreatePrescription_Click(object sender, EventArgs e)
        {
            if(prescriptionID == 0)
            {
                return;
            }
            var f = new PrescriptionForm(prescriptionID);
            f.Show();
        }

        private bool UpdateMedicalRecord()
        {
            bool result;
            //Update medical record
            MedicalRecord medicalRecord = new MedicalRecord
            {
                MedicalRecordID = (int)textMedicalRecordID.EditValue,
                DoctorID = UserBusiness.User.UserID,
                Diagnostic = memoDiagnostic.Text,
                ExamineDate = (DateTime)dateExamineDay.EditValue,
                ExamineReason = memoExamineReason.Text,
                Note = textNote.Text,
                PatientID = (int)textPatientID.EditValue,
            };

            if (dateReExamineDay.EditValue != null)
            {
                medicalRecord.ReExamineDate = (DateTime)dateReExamineDay.EditValue;
            }

            result = medicalRecordBusiness.Update(medicalRecord);

            //Delete old service detail 
            result = result && serviceDetailBusiness.DeleteByMedicalRecordID(medicalRecord.MedicalRecordID);

            //Insert new Service detail
            DataTable services = gridService.DataSource as DataTable;
            ServiceDetail serviceDetail = new ServiceDetail
            {
                MedicalRecordID = medicalRecord.MedicalRecordID
            };

            foreach (DataRow row in services.Rows)
            {
                serviceDetail.ServiceID = (int)row["ServiceID"];
                result = result && (serviceDetailBusiness.Insert(serviceDetail) > 0);
            }

            return result;
        }

        private void buttonFinishExamine_Click(object sender, EventArgs e)
        {
            if (selecteRow == null)
            {
                return;
            }
            bool result = true;

            if(textMedicalRecordID.Text != "")
            {
                result = UpdateMedicalRecord();
            }

            queueBusiness.UpdateStatus((int)selecteRow["QueueID"], "I");   

            if (!result)
            {
                XtraMessageBox.Show(this, "Có lỗi trong quá trình lưu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Refresh queue
                LoadQueueByDoctor();
                LoadExaminedList();
                ResetAll();
            }
        }

        private void ResetAll()
        {
            buttonUpdate.Enabled = false;
            buttonCreate.Enabled = true;
            UpdateUI();

            textFullName.ResetText();
            textPatientID.ResetText();
            textMedicalRecordID.ResetText();
            textDoctorName.ResetText();
            textNote.ResetText();
            memoDiagnostic.ResetText();
            memoExamineReason.ResetText();
            dateReExamineDay.EditValue = null;
            dateExamineDay.EditValue = null;
            gridService.DataSource = null;
        }

        private void gridViewQueue_DoubleClick(object sender, EventArgs e)
        {
            var row = gridViewQueue.GetFocusedDataRow();
            if(row == null)
            {
                return;
            }

            selecteRow = row;
            textFullName.Text = (string)row["FullName"];
            textPatientID.EditValue = (int)row["PatientID"];
            memoExamineReason.Text = (string)row["ExamineReason"];
            textDoctorName.Text = (string)row["DoctorName"];
            dateExamineDay.EditValue = DateTime.Today;
            
            //Check patient is examined or not
            var medicalRecord = medicalRecordBusiness.GetByPatientID((int)row["PatientID"]);
            
            if(medicalRecord == null)
            {
                buttonCreate.Enabled = true;
                buttonUpdate.Enabled = false;
            }
            else
            {
                var prescriptionBusiness = new PrescriptionBusiness();
                var pres = prescriptionBusiness.GetByMedicalRecordID(medicalRecord.MedicalRecordID);
                this.prescriptionID = pres.PrescriptionID;
                gridService.DataSource = serviceDetailBusiness.GetByMedicalRecordID(medicalRecord.MedicalRecordID);
                textMedicalRecordID.EditValue = medicalRecord.MedicalRecordID;
                memoDiagnostic.EditValue = medicalRecord.Diagnostic;
                dateExamineDay.EditValue = medicalRecord.ExamineDate;
                dateReExamineDay.EditValue = medicalRecord.ReExamineDate;
                textNote.EditValue = medicalRecord.Note;
                
                buttonCreate.Enabled = false;
                buttonUpdate.Enabled = true;
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            bool readOnly = buttonCreate.Enabled;
            memoDiagnostic.ReadOnly = readOnly;
            textNote.ReadOnly = readOnly;
            dateExamineDay.ReadOnly = readOnly;
            dateReExamineDay.ReadOnly = readOnly;
            gridViewService.OptionsBehavior.ReadOnly = readOnly;
        }

        private void repositoryItemDelete_Click(object sender, EventArgs e)
        {
            gridViewService.DeleteSelectedRows();
        }
    }
}

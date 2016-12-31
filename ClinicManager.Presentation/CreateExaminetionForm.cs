using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class CreateExaminetionForm : Form
    {
        private Patient patient;
        private QueueBusiness queueBusiness;
        private ReceivePatientForm parentsForm;
        public CreateExaminetionForm(ReceivePatientForm parentsForm,Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
            this.parentsForm = parentsForm;
            queueBusiness = new QueueBusiness();
        }

        private void CreateExaminetionForm_Load(object sender, EventArgs e)
        {
            textFullName.Text = patient.FullName;
            textGender.Text = patient.Gender;
            textJob.Text = patient.Job;
            textDateOfBirth.Text = patient.DateOfBirth.ToShortDateString();
            memoAddress.Text = patient.Address;

            dateExamineDay.EditValue = DateTime.Today;
            dateExamineDay.Properties.MaxValue = DateTime.Today;

            UserBusiness userBusiness = new UserBusiness();           
            lookupDoctor.Properties.DataSource = userBusiness.GetAllDoctorWithQueue();
            lookupDoctor.Properties.Columns.Add(new LookUpColumnInfo("FullName", "Tên bác sĩ"));
            lookupDoctor.Properties.Columns.Add(new LookUpColumnInfo("Queue", "Số bệnh nhân"));
            lookupDoctor.Properties.ValueMember = "UserID";
            lookupDoctor.Properties.DisplayMember = "FullName";
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!IsValidated())
            {
                return;
            }

            var queue = new Queue
            {
                DoctorID = (int)lookupDoctor.EditValue,
                ExamineDate = (DateTime)dateExamineDay.EditValue,
                ExamineReason = memoExamineReason.Text,
                PatientID = patient.PatientID
            };

            int result = queueBusiness.Insert(queue);

            if (result != 0)
            {
                Close();
            }
            else
            {
                XtraMessageBox.Show(this, "Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidated()
        {
            string error = "";
            bool result = true;

            error = queueBusiness.Validate(memoExamineReason.Text, "ExamineReason");
            if (error != "")
            {
                memoExamineReason.ErrorText = error;
                memoExamineReason.Invalidate();
                result = false;
            }

            error = queueBusiness.Validate(lookupDoctor.EditValue, "DoctorID");
            if (error != "")
            {
                lookupDoctor.ErrorText = error;
                lookupDoctor.Invalidate();
                result = false;
            }

            return result;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void memoExamineReason_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string error = queueBusiness.Validate(memoExamineReason.Text, "ExamineReason");
            if (error != "")
            {
                memoExamineReason.ErrorText = error;
                e.Cancel = true;
            }
        }

        private void memoExamineReason_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        private void lookupDoctor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string error = queueBusiness.Validate(lookupDoctor.EditValue, "DoctorID");
            if (error != "")
            {
                lookupDoctor.ErrorText = error;
                e.Cancel = true;
            }
        }

        private void lookupDoctor_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.DisplayError;
        }

        private void CreateExaminetionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentsForm.LoadQueueList();
        }
    }
}

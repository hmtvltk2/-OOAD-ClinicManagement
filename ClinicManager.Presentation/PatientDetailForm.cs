using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
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
    public partial class PatientDetailForm : Form
    {
        private MedicalRecordBusiness medicalRecordBusines;
        private Patient _patient;
        private PatientBusiness patientBusiness;
        public PatientDetailForm()
        {
            InitializeComponent();
        }
        public PatientDetailForm(int id)
        {
            InitializeComponent();
            medicalRecordBusines = new MedicalRecordBusiness();
            patientBusiness = new PatientBusiness();
            _patient = patientBusiness.GetbyId(id);
            textFullName.Text = _patient.FullName;
            textGender.Text = _patient.Gender;
            memoAddress.Text = _patient.Address;
            textDateOfBirth.Text = _patient.DateOfBirth.ToShortDateString();
            textJob.Text = _patient.Job;
            textPhone.Text = _patient.Phone;
            memoNote.Text = _patient.Note;
            textCreateDay.Text = _patient.CreateDate.ToShortDateString();
            this.Text = "BN: "+_patient.FullName;
        }

     
        private void buttonCreateSchedule_Click(object sender, EventArgs e)
        {       
            foreach (var form in Application.OpenForms.OfType<CreateScheduleForm>())
            {
                var fr = form as Form;
                fr.Activate();
                return;
            }
            var f = new CreateScheduleForm(_patient);
            f.ShowDialog();
             
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PatientDetailForm_Load(object sender, EventArgs e)
        {
            gridHistory.DataSource = medicalRecordBusines.GetAllByPatientId(_patient.PatientID);
        }

        private void gridViewHistory_DoubleClick(object sender, EventArgs e)
        {
            var row = gridViewHistory.GetFocusedDataRow();
            var medicalRecord = new MedicalRecord()
            {
                MedicalRecordID = (int)row["MedicalRecordID"],
                PatientID = (int)row["PatientID"],
                DoctorID = (int)row["DoctorID"],
                ExamineReason = (string)row["ExamineReason"],
                Diagnostic = (string)row["Diagnostic"],
                ExamineDate = (DateTime)row["ExamineDate"],
                Note = (string)row["Note"]
            };

            if (row["ReExamineDate"] != DBNull.Value)
            {
                medicalRecord.ReExamineDate = (DateTime)row["ReExamineDate"];
            }
        
            var f = new MedicalRecordForm(medicalRecord);
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == f.Text)
                {
                    form.Activate();
                    return;
                }
            }

            if (f == null) return;
            f.MdiParent = this.ParentForm;
            f.Show();
        }

        private void gridViewHistory_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}

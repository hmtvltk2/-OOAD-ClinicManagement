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
        private MedicalRecordBusiness medicalRecordBusines = new MedicalRecordBusiness();
        private Patient _patient = new Patient();
       private  PatientBusiness patientBusiness = new PatientBusiness();
        public PatientDetailForm()
        {
            InitializeComponent();
        }
        public PatientDetailForm(int id)
        {

            InitializeComponent();
        
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

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void gridHistory_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PatientDetailForm_Load(object sender, EventArgs e)
        {
            gridHistory.DataSource = medicalRecordBusines.GetById(_patient.PatientID);
            UserBusiness user = new UserBusiness();
            LookUpDoctor.DataSource = user.GetByUserGroup(2);
            LookUpDoctor.ValueMember = "UserID";
            LookUpDoctor.DisplayMember = "FullName";
            //LookUpDoctor.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DoctorID", "Bác sỹ"));
        }

        private void gridViewHistory_DoubleClick(object sender, EventArgs e)
        {
            var row = gridViewHistory.GetFocusedDataRow();
            var medicalRecord = new MedicalRecord()
            {MedicalRecordID = (int)row["MedicalRecordID"],
             PatientID = (int)row["PatientID"],
              DoctorID = (int)row["DoctorID"],
              ExamineReason  = row["ExamineReason"].ToString(),
             Diagnostic= row["Diagnostic"].ToString(),
            ExamineDate = (DateTime)row["ExamineDate"],
             Note= row["Note"].ToString(),
            PrescriptionsID = (int)row["PrescriptionsID"],
            ReExamineDate = (DateTime)row["ReExamineDate"]
            
          
        };  
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
    }
}

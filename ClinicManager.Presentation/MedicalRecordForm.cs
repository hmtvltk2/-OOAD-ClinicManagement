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
    public partial class MedicalRecordForm : Form
    {
        MedicalRecordBusiness mediclRecordBusiness = new MedicalRecordBusiness();
        PatientBusiness patientBusiness = new PatientBusiness();
        public MedicalRecordForm()
        {
            InitializeComponent();
        }
        public MedicalRecordForm(MedicalRecord medicalRecord)
        {
            InitializeComponent();
            textFullName.Text = patientBusiness.GetbyId(medicalRecord.PatientID).FullName;
            textPatientID.Text = medicalRecord.PatientID.ToString();
            textMedicalRecordID.Text = medicalRecord.MedicalRecordID.ToString();
            memoExamineReason.Text = medicalRecord.ExamineReason;
            memoDiagnostic.Text = medicalRecord.Diagnostic;
            textDoctor.Text = medicalRecord.DoctorID.ToString();
            textExamineDay.Text = medicalRecord.ExamineDate.ToShortDateString();
            textReExamineDay.Text = medicalRecord.ReExamineDate.ToShortDateString();
                
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

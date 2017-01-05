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
        MedicalRecordBusiness mediclRecordBusiness  ;
        PatientBusiness patientBusiness;
        MedicalRecord _medicalRecord = new MedicalRecord();
        PrescriptionDetailBusiness pretBusiness;
        public MedicalRecordForm()
        {
            InitializeComponent();
        }
        public MedicalRecordForm(MedicalRecord medicalRecord)
        {
            InitializeComponent();
            mediclRecordBusiness = new MedicalRecordBusiness();
            patientBusiness = new PatientBusiness();
            
            pretBusiness = new PrescriptionDetailBusiness();
            _medicalRecord = medicalRecord;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicalRecordForm_Load(object sender, EventArgs e)
        {
            textFullName.Text = patientBusiness.GetbyId(_medicalRecord.PatientID).FullName;
            textPatientID.Text = _medicalRecord.PatientID.ToString();
            textMedicalRecordID.Text = _medicalRecord.MedicalRecordID.ToString();
            memoExamineReason.Text = _medicalRecord.ExamineReason;
            memoDiagnostic.Text = _medicalRecord.Diagnostic;
            textDoctor.Text = _medicalRecord.DoctorID.ToString();
            textExamineDay.Text = _medicalRecord.ExamineDate.ToShortDateString();
            if(_medicalRecord.ReExamineDate != null)
            {
                textReExamineDay.Text = ((DateTime)_medicalRecord.ReExamineDate).ToShortDateString();
            }

            gridExminedList.DataSource = pretBusiness.GetByPrescriptionID(_medicalRecord.MedicalRecordID);
        }
    }
}

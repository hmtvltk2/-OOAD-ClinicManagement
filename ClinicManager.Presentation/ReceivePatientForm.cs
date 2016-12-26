using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class ReceivePatientForm : Form
    {
        private PatientBusiness patientBusiness;
        private QueueBusiness queueBusiness;
        public ReceivePatientForm()
        {
            InitializeComponent();
            patientBusiness = new PatientBusiness();
            queueBusiness = new QueueBusiness();
        }

        private void gridviewSearchList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void ReceivePatientForm_Load(object sender, EventArgs e)
        {
            LoadPatientList();
            LoadQueueList();
        }

        private void gridViewExamineList_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        // Search patient (PatientName, DateOfBirth, Gender) order by CreateDate desc
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            gridSearchList.DataSource = patientBusiness.Search(
                                                textPatientName.Text,
                                                (DateTime)dateDateOfBirth.EditValue,
                                                comboGender.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Open "CreatePatientForm"
        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            var patientForm = new CreatePatientForm();
            patientForm.Show();
            LoadPatientList();
        }

        // Open "CreateExamnineForm" with param is the selected Patient
        private void buttonCreateExamine_Click(object sender, EventArgs e)
        {
            var row = gridviewSearchList.GetFocusedDataRow();

            if(row == null)
            {
                XtraMessageBox.Show(this, "Bạn chưa chọn bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //var examineForm = new CreateExaminetionForm(new Patient(row));
            //examineForm.Show();

            LoadQueueList();
        }

        // Load patient list order by CreateDate desc
        private void LoadPatientList()
        {
            gridSearchList.DataSource = patientBusiness.GetAll();
        }

        private void LoadQueueList()
        {
            gridSearchList.DataSource = queueBusiness.GetByDate(DateTime.Today);
        }
    }
}

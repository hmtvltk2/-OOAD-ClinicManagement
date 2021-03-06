﻿using ClinicManager.DataBusiness;
using ClinicManager.Common;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using ClinicManager.DataModel;

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
                                                dateDateOfBirth.EditValue,
                                                comboGender.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Open "CreatePatientForm"
        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            var patientForm = new CreatePatientForm(this);
            patientForm.Show();
            
            //LoadPatientList();
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

            var examineForm = new CreateExaminetionForm(this, Helper.ConvertDataRowTo<Patient>(row));
            examineForm.Show();
        }

        // Load patient list order by CreateDate desc
        public void LoadPatientList()
        {
            gridSearchList.DataSource = patientBusiness.GetAll();
        }

        public void LoadQueueList()
        {
            GridExamineList.DataSource = queueBusiness.GetByDate(DateTime.Today);
        }
    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using ClinicManager.DataModel;
using System.Collections.Generic;

namespace ClinicManager.Presentation
{
    public partial class PrescriptionRP : DevExpress.XtraReports.UI.XtraReport
    {
        public PrescriptionRP(List<ReportPrescription> datasource, string patientName, 
            string doctorName, string examineDate, string note, string diagnostic)
        {
            InitializeComponent();
            xrDiagnostic.Text = diagnostic;
            xrDoctorName.Text = doctorName;
            xrExamineDate.Text = examineDate;
            xrNote.Text = note;
            xrPatientName.Text = patientName;
            this.DataSource = datasource;         
        }

    }
}

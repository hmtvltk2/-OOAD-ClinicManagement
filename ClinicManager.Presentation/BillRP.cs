using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using ClinicManager.DataModel;
using ClinicManager.DataBusiness;

namespace ClinicManager.Presentation
{
    public partial class BillRP : DevExpress.XtraReports.UI.XtraReport
    {
        public BillRP(List<ReportPayment> datasource, string patientName, string totalFee)
        {
            InitializeComponent();
            this.DataSource = datasource;
            xrDate.Text = "Ngày " + DateTime.Today.ToShortDateString();
            xrPatientName.Text = patientName;
            xrUserName.Text = UserBusiness.User.FullName;
            xrTotalFee.Text = totalFee;
        }

    }
}

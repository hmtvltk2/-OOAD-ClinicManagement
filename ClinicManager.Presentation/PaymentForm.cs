using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class PaymentForm : Form
    {
        MedicalRecordBusiness medicalRecordBusiness ;
      
       
        decimal totalFee;
        decimal medicineFee;
        decimal serviceFee;
        public PaymentForm()
        {
            InitializeComponent();
            medicalRecordBusiness = new MedicalRecordBusiness();
          
        }

        private void PaymentForm_Load(object sender, System.EventArgs e)
        {
            gridQueue.DataSource = medicalRecordBusiness.GetByStatus("NotPayment");
            buttonPayment.Enabled = false;
            buttonPrint.Enabled = false;
            dateDateOfBill.EditValue = DateTime.Today;
            
        }

        private void gridViewQueue_DoubleClick(object sender, System.EventArgs e)
        {
            buttonPayment.Enabled = true;
            PrescriptionBusiness presBsn = new PrescriptionBusiness();
            var row = gridViewQueue.GetFocusedDataRow();
            textMedicalRecordID.Text = row["MedicalRecordID"].ToString();
            textPatientName.Text = row["FullName"].ToString();
            textPatientID.Text = row["PatientID"].ToString();
            textDateOfBirth.Text = ((DateTime)row["DateOfBirth"]).ToShortDateString();
            ServiceDetailBusiness serviceDetainBns = new ServiceDetailBusiness();
            DataTable ServiceListTable = serviceDetainBns.GetById((int)row["MedicalRecordID"]);
            ServiceListTable.Columns.Add("NotCalFee", typeof(bool));
             medicineFee = presBsn.GetMedicineFee((int)row["MedicalRecordID"]);
            var rowService = ServiceListTable.NewRow();
            rowService["ServiceID"] = ServiceListTable.Rows.Count+1;
            rowService["ServiceName"] = "Tiền thuốc";
            rowService["ServiceFee"] = medicineFee;
            ServiceListTable.Rows.Add(rowService);
            foreach (DataRow addrow in ServiceListTable.Rows)
            {
                addrow["NotCalFee"] = false;
            }

            
            gridServiceList.DataSource = ServiceListTable;
            // Get total fee
             serviceFee = serviceDetainBns.GetTotalFee((int)row["MedicalRecordID"]);
             totalFee   = (serviceFee + medicineFee)  ;
            textTotalFee.Text = totalFee.ToString();
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            buttonPrint.Enabled = true;
            buttonPayment.Enabled = false;
            bool result;
            BillBusiness billBusiness = new BillBusiness();
            Bill bill = new Bill()
            {
                MedicalRecordID = int.Parse(textMedicalRecordID.Text),
                MedicineFee = medicineFee,
                ServiceFee = serviceFee,
                DateOfBill = (DateTime)dateDateOfBill.EditValue,
                Amount = totalFee,
                UserID = 1
            };


            int id = billBusiness.Insert(bill);
            if (id == 0)
            {
                result = false;
            }
            else
            {
                result = true;

            }
            var row = gridViewQueue.GetFocusedDataRow();
            var medicalRecord = new MedicalRecord()
            {
                MedicalRecordID = (int)row["MedicalRecordID"],
                PatientID = (int)row["PatientID"],
                DoctorID = (int)row["DoctorID"],
                ExamineReason = row["ExamineReason"].ToString(),
                Diagnostic = row["Diagnostic"].ToString(),
                ExamineDate = (DateTime)row["ExamineDate"],
                Note = row["Note"].ToString(),
                PrescriptionsID = (int)row["PrescriptionsID"],
                ReExamineDate = (DateTime)row["ReExamineDate"],
                Status = "Payment"


            };
            result = medicalRecordBusiness.Update(medicalRecord);
            if (id == 0)
            {
                result = false;
            }
            else
            {
                result = true;

            }

            if (result)
            {
                XtraMessageBox.Show(this, "Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                XtraMessageBox.Show(this, "Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            gridQueue.DataSource = medicalRecordBusiness.GetByStatus("NotPayment");
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
       

        

        private void checkEditNotCalcFee_CheckedChanged(object sender, EventArgs e)
        {

            var row = gridViewServiceList.GetFocusedDataRow();
            var checkEdit = (CheckEdit)sender;
            row["NotCalFee"] = checkEdit.Checked;
            var check = row["NotCalFee"];
          //  var check = checkEditNotCalcFee.ValueUnchecked;

            if ((bool)check)
            {
                totalFee -= (decimal)row["ServiceFee"];
                textTotalFee.Text = totalFee.ToString();
                serviceFee -= (decimal)row["ServiceFee"];
            }
            if (!(bool)check)
            {
                totalFee += (decimal)row["ServiceFee"];
                textTotalFee.Text = totalFee.ToString();
                serviceFee  += (decimal)row["ServiceFee"];
            }


        }

        private void checkEditNotCalcFee_CheckStateChanged(object sender, EventArgs e)
        {
            //var checkEdit = (CheckEdit)sender;

        }
    }
    
    
}

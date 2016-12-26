using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class CreatePatientForm : Form
    {
        public CreatePatientForm()
        {
            InitializeComponent();
        }

        private void CreatePatientForm_Load(object sender, EventArgs e)
        {
            dateCreateDate.Properties.MaxValue = DateTime.Today;
            dateDateOfBirth.Properties.MaxValue = DateTime.Today;
            dateCreateDate.EditValue = DateTime.Today;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!IsValidated())
            {
                return;
            }

            PatientBusiness patientBusiness = new PatientBusiness();
            var patient = new Patient
            {
                Address = memoAddress.Text,
                CreateDate = (DateTime)dateCreateDate.EditValue,
                DateOfBirth = (DateTime)dateDateOfBirth.EditValue,
                FullName = textFullName.Text,
                Gender = comboGender.Text,
                Job = textJob.Text,
                Note = memoNote.Text,
                Phone = textPhone.Text
            };

            int result = patientBusiness.Insert(patient);

            if(result != 0)
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
            string message = "";
            if(string.IsNullOrWhiteSpace(textFullName.Text))
            {
                message = "Tên bệnh nhân không được trống";
            }
            else if (dateDateOfBirth.EditValue == null)
            {
                message = "Ngày sinh không được trống";
            }
            else if (string.IsNullOrWhiteSpace(memoAddress.Text))
            {
                message = "Địa chỉ không được trống";
            }
            
            if(message != "")
            {
                XtraMessageBox.Show(this, message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
       
    }
}

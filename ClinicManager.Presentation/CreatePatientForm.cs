using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class CreatePatientForm : Form
    {
        private PatientBusiness patientBusiness;
        private ReceivePatientForm parentsForm;
        public CreatePatientForm(ReceivePatientForm parentsForm)
        {
            InitializeComponent();
            patientBusiness = new PatientBusiness();
            this.parentsForm = parentsForm;
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
            string error = "";
            bool result = true;

            error = patientBusiness.Validate(textFullName.Text, "FullName");
            if(error != "")
            {
                textFullName.ErrorText = error;
                textFullName.Invalidate();
                result = false;
            }

            error = patientBusiness.Validate(dateDateOfBirth.EditValue, "DateOfBirth");
            if (error != "")
            {
                dateDateOfBirth.ErrorText = error;
                dateDateOfBirth.Invalidate();
                result = false;
            }

            error = patientBusiness.Validate(memoAddress.EditValue, "Address");
            if (error != "")
            {
                memoAddress.ErrorText = error;
                memoAddress.Invalidate();
                result = false;
            }

            return result;
        }

        private void textFullName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string error = patientBusiness.Validate(textFullName.Text, "FullName");
            if (error != "")
            {
                textFullName.ErrorText = error;
                e.Cancel = true;
            } 
        }

        private void textFullName_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }

        private void dateDateOfBirth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string error = patientBusiness.Validate(dateDateOfBirth.EditValue, "DateOfBirth");
            if(error != "")
            {
                dateDateOfBirth.ErrorText = error;
                e.Cancel = true;
            }
        }

        private void dateDateOfBirth_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }

        private void memoAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string error = patientBusiness.Validate(memoAddress.Text, "DateOfBirth");
            if (error != "")
            {
                memoAddress.ErrorText = error;
                e.Cancel = true;
            }
        }

        private void memoAddress_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError;
        }

        private void CreatePatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentsForm.LoadPatientList();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPhone_Validated(object sender, EventArgs e)
        {

        }

        private void textPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Regex.IsMatch(textPhone.Text, "[^0-9-+]"))
            {
                Regex regex = new Regex("[^0-9-+]");
                string output = regex.Replace(Clipboard.GetText(), "");
                textPhone.Text = output;
            }

        }
    }
}

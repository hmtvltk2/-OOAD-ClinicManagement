using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class CreateScheduleForm : Form
       
    {

        private ScheduleBusiness scheduleBusiness;
        // use for invalidvaule (controlname)event
       // private int textFullNameCheck;
        //private int textPhoneCheck;
        public CreateScheduleForm()
        {
            InitializeComponent();
            scheduleBusiness = new ScheduleBusiness();
        }
        public CreateScheduleForm(Patient patient)
        {
            InitializeComponent();
            textPhone.Text = patient.Phone;
            textFullName.Text = patient.FullName;
            memoAddress.Text = patient.Address;
            
            scheduleBusiness = new ScheduleBusiness();
        }
        
        private void CreateScheduleForm_Load(object sender, EventArgs e)
        {
            UserBusiness userbusiness = new UserBusiness();
            lookUpDoctor.Properties.DataSource = userbusiness.GetByUserGroup(2);
            lookUpDoctor.Properties.ValueMember = "UserID";
            lookUpDoctor.Properties.DisplayMember = "FullName";
            lookUpDoctor.Properties.Columns.Add(new LookUpColumnInfo ( "FullName","Bác sỹ"));
            dateDateSchedule.Properties.MinValue = DateTime.Now;
            dateDateSchedule.EditValue = DateTime.Today.AddDays(1);
        }


        //private string Validate(string property, object sender, System.ComponentModel.CancelEventArgs e)
        //{
            
        //    string message = scheduleBusiness.Validate( property); 
        //    if(message != "")
        //    {
        //        e.Cancel = true;
        //        return message;
        //    }
        //    else
        //    {
        //        return "";
        //    }

        //}

        //private bool Validate()
        //{
        //    string message = "";
        //    message = scheduleBusiness.Validate(textFullName.Text, property);
        //    return true;
        //}

        private void textFullName_Validating  (object sender, System.ComponentModel.CancelEventArgs e)
        {
           // textFullName.ErrorText = Validate("FullName", e);
            
            //if (textFullName.Text == "")
            //{
            //    e.Cancel = true;
            //    textFullNameCheck = 1;
               

            //}
            //if (textFullName.Text.Length > 50)
            //{
            //    e.Cancel = true;
            //    textFullNameCheck = 2;

            //}          
        }

        private void textFullName_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            //if (textFullNameCheck == 1)
            //{ e.ErrorText = "Chưa nhập tên"; }
            //else if (textFullNameCheck == 2)
            //{
            //    e.ErrorText = "Độ dài tên không được vượt quá 50 kí tự";
            //}

        }
    
        private void textPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (textPhone.Value == 0)
            //{
            //    e.Cancel = true;
            //    textPhoneCheck = 1;
            //}
            //if (textPhone.Text.Length > 15)
            //{
            //    e.Cancel = true;
            //    textPhoneCheck = 2;
            //}

        }

        private void textPhone_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            //if (textPhoneCheck == 1)
            //{ e.ErrorText = "Chưa nhập số điện thoại"; }
            //else if (textPhoneCheck == 2)
            //{
            //    e.ErrorText = "Độ dài sđt không được vượt quá 15 kí tự";
            //}
        }

        private void lookUpDoctor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void lookUpDoctor_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {

        }

        private void dateDateSchedule_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void dateDateSchedule_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {

        }

        private void memoNote_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void memoNote_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {

        }


        private bool CheckInput()
        {
            string message = "";
            
           message = scheduleBusiness.Validate(textFullName.EditValue, "FullName"); 
           if (message =="")
            {
                  message = scheduleBusiness.Validate(textPhone.Text, "Phone");
                {
                    if (message == "")
                        message = scheduleBusiness.Validate(lookUpDoctor.EditValue, "DoctorID");
                }
            }
            if (message !="")
            {
                XtraMessageBox.Show(this, message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }
            return true;
        }       

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            bool result;
            Schedule schedule = new Schedule()
            {
                FullName = textFullName.Text,
                Phone = textPhone.Text,
                Address = memoAddress.Text,
                DoctorID = (int)lookUpDoctor.EditValue,
                Note = memoNote.Text,
                ScheduleDate = (DateTime)dateDateSchedule.EditValue,
                ScheduleType = radioGroup.Properties.Items[radioGroup.SelectedIndex].Description
                            
            };
           int id = scheduleBusiness.Insert(schedule);
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

            buttonCreate.Enabled = false;
           
            
        }
        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textFullName_Validated(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textFullName.Text = "";
            textPhone.Text = "";
            memoAddress.Text = "";
            lookUpDoctor.EditValue = null;
            dateDateSchedule.EditValue = null;
            memoNote.Text = "";
            buttonCreate.Enabled = true;
            dateDateSchedule.Properties.MinValue = DateTime.Now;
            dateDateSchedule.EditValue = DateTime.Now.AddDays(1);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textPhone_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPhone_Validating_1(object sender, System.ComponentModel.CancelEventArgs e)
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

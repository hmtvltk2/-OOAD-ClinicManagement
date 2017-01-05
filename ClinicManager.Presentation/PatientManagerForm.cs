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
    public partial class PatientManagerForm : Form
    {
        private PatientBusiness patientBusiness;
        public PatientManagerForm()
        {
            InitializeComponent();
            patientBusiness = new PatientBusiness();
        }

         

        private void PatientManagerForm_Load(object sender, EventArgs e)
        {
            gridSearchList.DataSource = patientBusiness.GetAll();
            dateDateOfBirth.EditValue = null;
            comboGender.SelectedIndex = 0;        
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewSearchList_DoubleClick(object sender, EventArgs e)
        {
            var row = gridViewSearchList.GetFocusedDataRow();
            int id = (int)row["PatientID"];
     
            var f = new PatientDetailForm(id);
            foreach(Form form in Application.OpenForms)
            {
                if (form.Text == f.Text)
                {
                    form.Activate();
                    return;
                }
            }
          
            if (f == null) return;
            f.MdiParent = this.ParentForm;
            f.Show();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
          if (textFullName.Text =="" && dateDateOfBirth.Text == "Tất cả" && comboGender.Text =="Tất cả")
            {
                gridSearchList.DataSource = patientBusiness.GetAll();
                return;
            }
            if (dateDateOfBirth.EditValue == null)
            {
                
                gridSearchList.DataSource = patientBusiness.GetByCondition(textFullName.Text,  DateTime.Today, comboGender.EditValue.ToString());
            }
            else
            {
                gridSearchList.DataSource = patientBusiness.GetByCondition(textFullName.Text, (DateTime)dateDateOfBirth.EditValue, comboGender.EditValue.ToString());

            }
        }
    }
}

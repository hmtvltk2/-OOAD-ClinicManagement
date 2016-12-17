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
    public partial class ReceivePatientForm : Form
    {
        public ReceivePatientForm()
        {
            InitializeComponent();
        }

        private void buttonCretePatien_Click(object sender, EventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<CreatePatientForm>())
            {
                var fr = form as Form;
                fr.Activate();
                return;
            }
            var f = new CreatePatientForm();
            f.ShowDialog();
        }

        private void buttonCreateExamine_Click(object sender, EventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<CreateExaminetionForm>())
            {
                var fr = form as Form;
                fr.Activate();
                return;
            }
            var f = new CreateExaminetionForm();
            f.ShowDialog();
        }
    }
}

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
    public partial class PatientDetailForm : Form
    {
        public PatientDetailForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateSchedule_Click(object sender, EventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<CreateScheduleForm>())
            {
                var fr = form as Form;
                fr.Activate();
                return;
            }
            var f = new CreateScheduleForm();
            f.ShowDialog();
        }

        private void gridHistory_Click(object sender, EventArgs e)
        {

        }
    }
}

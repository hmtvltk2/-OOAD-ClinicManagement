using DevExpress.XtraEditors;
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
    public partial class CreateScheduleForm : Form
    {
        public CreateScheduleForm()
        {
            InitializeComponent();
        }

        private void CreateScheduleForm_Load(object sender, EventArgs e)
        { 
        }

        private void radioReExamine_MouseClick(object sender, MouseEventArgs e)
        {
            CheckEdit ce = sender as CheckEdit;
            if (ce.Checked)
            {
                radioExamine.Checked = false;
                radioResult.Checked = false;
            }
            else
            {
                //your code if the status is changed to Checked
            }
        }

        private void radioReExamine_EditValueChanged(object sender, EventArgs e)
        {
            CheckEdit ce = sender as CheckEdit;
            if (ce.Checked)
            {
                radioExamine.Checked = false;
                radioResult.Checked = false;
            }
            
        }

        private void radioExamine_EditValueChanged(object sender, EventArgs e)
        {
            CheckEdit ce = sender as CheckEdit;
            if (ce.Checked)
            {
                radioReExamine.Checked = false;
                radioResult.Checked = false;
            }
        }

        private void radioResult_EditValueChanged(object sender, EventArgs e)
        {
            CheckEdit ce = sender as CheckEdit;
            if (ce.Checked)
            {
                radioReExamine.Checked = false;
                radioExamine.Checked = false;
            }
        }
    }
}

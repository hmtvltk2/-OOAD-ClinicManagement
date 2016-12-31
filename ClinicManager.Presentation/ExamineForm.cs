using ClinicManager.DataBusiness;
using System;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class ExamineForm : Form
    {
        private QueueBusiness queueBusiness;
        public ExamineForm()
        {
            InitializeComponent();
            queueBusiness = new QueueBusiness();
        }

        private void ExamineForm_Load(object sender, System.EventArgs e)
        {
            LoadQueueByDoctor();
        }

        private void LoadQueueByDoctor()
        {
            
        }

        private void gridExamined_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void buttonRefresh_Click(object sender, System.EventArgs e)
        {
            LoadQueueByDoctor();
        }

        private void buttonCreate_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonCreatePrescription_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonFinishExamine_Click(object sender, System.EventArgs e)
        {

        }
    }
}

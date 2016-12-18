using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class ScheduleManagerForm : Form
    {
        public ScheduleManagerForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
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
    }
}

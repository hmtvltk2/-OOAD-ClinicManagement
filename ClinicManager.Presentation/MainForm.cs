using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraEditors;

namespace ClinicManager.Presentation
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            XtraTabbedMdiManager mdiManager = new XtraTabbedMdiManager();
            mdiManager.MdiParent = this;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!TryConnect()) return;
            if (!Login()) return;
            ShowSystemInfo();
            SetRule();
        }

        private void SetRule()
        {
            
        }

        private void ShowSystemInfo()
        {
            throw new NotImplementedException();
        }

        private bool Login()
        {
            var login = new LoginForm();
            do
            {
                if (login.ShowDialog().Equals(DialogResult.OK))
                {
                    return true;
                }
                if (XtraMessageBox.Show("Bạn muốn thoát chương trình",
                    "Thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    .Equals(DialogResult.No)) continue;
                Application.Exit();
                return false;
            } while (true);
        }

        private static bool TryConnect()
        {
            if (ConfigService.TryConnect())
                return true;
            var ciForm = new ConfigForm();
            do
            {
                if (ciForm.ShowDialog().Equals(DialogResult.OK))
                    return true;

                if (XtraMessageBox.Show(@"Bạn muốn thoát chương trình",
                    @"Thoát",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    .Equals(DialogResult.No)) continue;
                break;
            } while (true);
            return false;
        }

        private void OpenMDIForm<T>()
        {

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    return;
                }      
            }
            var f = Activator.CreateInstance<T>() as Form;
            if (f == null) return;
            f.MdiParent = this;
            f.Show();
        }

        private void OpenOtherForm<T>()
        {
            foreach (var form in Application.OpenForms.OfType<T>())
            {
                var fr = form as Form;
                fr.Activate();
                return;
            }
            var f = Activator.CreateInstance<T>() as Form;
            f.Show();
        }
        private void barButtonReceivePatient_ItemClick(object sender, ItemClickEventArgs e)
        {
           
           OpenMDIForm<ReceivePatientForm>();
            
        }

        private void barButtonExamine_ItemClick(object sender, ItemClickEventArgs e)
        {
           OpenMDIForm<ExamineForm>();
        }

        private void barButtonPayment_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMDIForm<PaymentForm>();
        }

        private void barButtonPatientManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMDIForm<PatientManagerForm>();
        }

        private void barButtonMedicine_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMDIForm<MedicineManagerForm>();
        }

        private void barButtonMedicineType_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOtherForm<MedicineTypeForm>();
        }

        private void barButtonPharmacyType_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOtherForm<PharmacyTypeForm>();
        }

        private void barButtonWayToUse_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOtherForm<WayToUseForm>();
        }

        private void barButtonUnit_ItemClick(object sender, ItemClickEventArgs e)
        {

            OpenOtherForm<UnitForm>();
        }

        private void barButtonSchedule_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMDIForm<ScheduleManagerForm>();
        }

        private void barButtonMedicineExport_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonNumberOfExamine_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonRevenue_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        

        private void barButtonUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMDIForm<UserForm>();
        }

        private void barButtonUserManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMDIForm<UserManagerForm>();
        }

        private void barButtonPermission_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMDIForm<PermissionForm>();
        }

        
    }
}
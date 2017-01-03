using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraEditors;
using ClinicManager.Common;
using ClinicManager.DataBusiness;

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
            var permissionBusiness = new PermissionBusiness();
            var permissions = permissionBusiness.GetPermissionByUserGroupID(UserBusiness.User.UserGroupID);

            pageGroupReceivePatient.Visible = permissions.Contains("Tiếp nhận bệnh nhân");

            pageGroupExamine.Visible = permissions.Contains("Khám bệnh");

            pageGroupPayment.Visible = permissions.Contains("Thanh toán");

            pageGroupPatientManager.Visible = permissions.Contains("Quản lý bệnh nhân");

            pageGroupScheduleManager.Visible = permissions.Contains("Quản lý lịch hẹn");

            pageGroupService.Visible = permissions.Contains("Dịch vụ");

            pageGroupDatabase.Visible = permissions.Contains("Thay đổi cơ sở dữ liệu");

            barButtonMedicine.Visibility = permissions.Contains("Quản lý thuốc") 
                                        ? BarItemVisibility.Always 
                                        : BarItemVisibility.Never;

            barButtonMedicineType.Visibility = permissions.Contains("Loại thuốc") 
                                        ? BarItemVisibility.Always 
                                        : BarItemVisibility.Never;

            barButtonPharmacyType.Visibility = permissions.Contains("Dạng bào chế") 
                                        ? BarItemVisibility.Always 
                                        : BarItemVisibility.Never;

            barButtonWayToUse.Visibility = permissions.Contains("Đường dùng") 
                                        ? BarItemVisibility.Always 
                                        : BarItemVisibility.Never;

            barButtonUnit.Visibility = permissions.Contains("Đơn vị tính") 
                                        ? BarItemVisibility.Always 
                                        : BarItemVisibility.Never;

            pageGroupMedicineManager.Visible = 
                permissions.Contains("Quản lý thuốc") 
                || permissions.Contains("Loại thuốc") 
                || permissions.Contains("Dạng bào chế") 
                || permissions.Contains("Đường dùng") 
                || permissions.Contains("Đơn vị tính");

            barButtonUserManager.Visibility = permissions.Contains("Quản lý người dùng") 
                                        ? BarItemVisibility.Always : 
                                        BarItemVisibility.Never;

            barButtonPermission.Visibility = permissions.Contains("Phân quyền") 
                                        ? BarItemVisibility.Always 
                                        : BarItemVisibility.Never;

            pageGroupUserManager.Visible = permissions.Contains("Quản lý người dùng") 
                                        || permissions.Contains("Phân quyền");

            barButtonNumberOfExamine.Visibility = permissions.Contains("Báo cáo lượt khám") 
                                        ? BarItemVisibility.Always 
                                        : BarItemVisibility.Never;

            barButtonRevenue.Visibility = permissions.Contains("Báo cáo doanh thu") 
                                        ? BarItemVisibility.Always 
                                        : BarItemVisibility.Never;

            pageGroupReport.Visible = permissions.Contains("Báo cáo doanh thu") 
                                    || permissions.Contains("Báo cáo lượt khám");
        }

        private void ShowSystemInfo()
        {
            barStaticUser.Caption = UserBusiness.User.FullName;
         
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
            var f = MdiChildren.FirstOrDefault(i => i is T);

            if (f == null)
            {
                foreach (var form in MdiChildren)
                {
                    form.Close();
                }
                f = Activator.CreateInstance<T>() as Form;
                if (f == null) return;
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.Activate();
            }
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

        private void barButtonAccountManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenMDIForm<UserForm>();
        }

        private void barButtonLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            docManager.View.Controller.CloseAll();
            barStaticUser.Caption = "________";
            
            MainForm_Shown(sender, e);
        }

        private void barButtonConfigDatabase_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenOtherForm<ConfigForm>();
        }

        private void barButtonService_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
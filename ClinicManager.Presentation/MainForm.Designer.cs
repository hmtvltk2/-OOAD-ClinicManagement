namespace ClinicManager.Presentation
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonReceivePatient = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonExamine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPayment = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPatientManager = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMedicine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMedicineType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPharmacyType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonWayToUse = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUnit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSchedule = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUserManager = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPermission = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonNumberOfExamine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRevenue = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barStaticUser = new DevExpress.XtraBars.BarStaticItem();
            this.barUserMenu = new DevExpress.XtraBars.BarSubItem();
            this.barButtonAccountManager = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLogout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonConfigDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonService = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageGroupReceivePatient = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupExamine = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupPayment = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageGroupPatientManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupScheduleManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupMedicineManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupService = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageGroupUserManager = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageGroupDatabase = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pageGroupReport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.docManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonReceivePatient,
            this.barButtonExamine,
            this.barButtonPayment,
            this.barButtonPatientManager,
            this.barButtonMedicine,
            this.barButtonMedicineType,
            this.barButtonPharmacyType,
            this.barButtonWayToUse,
            this.barButtonUnit,
            this.barButtonSchedule,
            this.barButtonUserManager,
            this.barButtonPermission,
            this.barButtonNumberOfExamine,
            this.barButtonRevenue,
            this.skinRibbonGalleryBarItem1,
            this.skinRibbonGalleryBarItem2,
            this.barStaticUser,
            this.barUserMenu,
            this.barButtonAccountManager,
            this.barButtonLogout,
            this.barButtonConfigDatabase,
            this.barButtonService});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 26;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barStaticUser);
            this.ribbon.PageHeaderItemLinks.Add(this.barUserMenu);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(1220, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonReceivePatient
            // 
            this.barButtonReceivePatient.Caption = "Tiếp nhận bệnh nhân";
            this.barButtonReceivePatient.Glyph = global::ClinicManager.Presentation.Properties.Resources.receive_patient16x16;
            this.barButtonReceivePatient.Id = 1;
            this.barButtonReceivePatient.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.receive_patient32x32x;
            this.barButtonReceivePatient.Name = "barButtonReceivePatient";
            this.barButtonReceivePatient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonReceivePatient_ItemClick);
            // 
            // barButtonExamine
            // 
            this.barButtonExamine.Caption = "Khám bệnh";
            this.barButtonExamine.Glyph = global::ClinicManager.Presentation.Properties.Resources.examine_16x16;
            this.barButtonExamine.Id = 2;
            this.barButtonExamine.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.examine_32x32;
            this.barButtonExamine.Name = "barButtonExamine";
            this.barButtonExamine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonExamine_ItemClick);
            // 
            // barButtonPayment
            // 
            this.barButtonPayment.Caption = "Thanh toán";
            this.barButtonPayment.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonPayment.Glyph")));
            this.barButtonPayment.Id = 3;
            this.barButtonPayment.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonPayment.LargeGlyph")));
            this.barButtonPayment.Name = "barButtonPayment";
            this.barButtonPayment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPayment_ItemClick);
            // 
            // barButtonPatientManager
            // 
            this.barButtonPatientManager.Caption = "Quản lý bệnh nhân";
            this.barButtonPatientManager.Glyph = global::ClinicManager.Presentation.Properties.Resources.patient16x16;
            this.barButtonPatientManager.Id = 4;
            this.barButtonPatientManager.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.patient32x32;
            this.barButtonPatientManager.Name = "barButtonPatientManager";
            this.barButtonPatientManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPatientManager_ItemClick);
            // 
            // barButtonMedicine
            // 
            this.barButtonMedicine.Caption = "Thuốc";
            this.barButtonMedicine.Glyph = global::ClinicManager.Presentation.Properties.Resources.medicine16x16;
            this.barButtonMedicine.Id = 5;
            this.barButtonMedicine.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.medicine32x32;
            this.barButtonMedicine.Name = "barButtonMedicine";
            this.barButtonMedicine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMedicine_ItemClick);
            // 
            // barButtonMedicineType
            // 
            this.barButtonMedicineType.Caption = "Loại thuốc";
            this.barButtonMedicineType.Glyph = global::ClinicManager.Presentation.Properties.Resources.MedicineType16x16;
            this.barButtonMedicineType.Id = 6;
            this.barButtonMedicineType.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.MedicineType32x32;
            this.barButtonMedicineType.Name = "barButtonMedicineType";
            this.barButtonMedicineType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMedicineType_ItemClick);
            // 
            // barButtonPharmacyType
            // 
            this.barButtonPharmacyType.Caption = "Dạng bào chế";
            this.barButtonPharmacyType.Glyph = global::ClinicManager.Presentation.Properties.Resources.pharmacy16x16;
            this.barButtonPharmacyType.Id = 7;
            this.barButtonPharmacyType.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.pharmacy32x32;
            this.barButtonPharmacyType.Name = "barButtonPharmacyType";
            this.barButtonPharmacyType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPharmacyType_ItemClick);
            // 
            // barButtonWayToUse
            // 
            this.barButtonWayToUse.Caption = "Đường dùng";
            this.barButtonWayToUse.Glyph = global::ClinicManager.Presentation.Properties.Resources.WaytoUse_16x16;
            this.barButtonWayToUse.Id = 8;
            this.barButtonWayToUse.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.WaytoUse_32x32;
            this.barButtonWayToUse.Name = "barButtonWayToUse";
            this.barButtonWayToUse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonWayToUse_ItemClick);
            // 
            // barButtonUnit
            // 
            this.barButtonUnit.Caption = "Đơn vị tính";
            this.barButtonUnit.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonUnit.Glyph")));
            this.barButtonUnit.Id = 9;
            this.barButtonUnit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonUnit.LargeGlyph")));
            this.barButtonUnit.Name = "barButtonUnit";
            this.barButtonUnit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUnit_ItemClick);
            // 
            // barButtonSchedule
            // 
            this.barButtonSchedule.Caption = "Lịch hẹn";
            this.barButtonSchedule.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonSchedule.Glyph")));
            this.barButtonSchedule.Id = 10;
            this.barButtonSchedule.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonSchedule.LargeGlyph")));
            this.barButtonSchedule.Name = "barButtonSchedule";
            this.barButtonSchedule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSchedule_ItemClick);
            // 
            // barButtonUserManager
            // 
            this.barButtonUserManager.Caption = "Quản lí người dùng";
            this.barButtonUserManager.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonUserManager.Glyph")));
            this.barButtonUserManager.Id = 11;
            this.barButtonUserManager.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonUserManager.LargeGlyph")));
            this.barButtonUserManager.Name = "barButtonUserManager";
            this.barButtonUserManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUserManager_ItemClick);
            // 
            // barButtonPermission
            // 
            this.barButtonPermission.Caption = "Phân quyền";
            this.barButtonPermission.Glyph = global::ClinicManager.Presentation.Properties.Resources.permission16x16;
            this.barButtonPermission.Id = 13;
            this.barButtonPermission.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.permission32x32;
            this.barButtonPermission.Name = "barButtonPermission";
            this.barButtonPermission.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPermission_ItemClick);
            // 
            // barButtonNumberOfExamine
            // 
            this.barButtonNumberOfExamine.Caption = "Báo cáo lượt khám";
            this.barButtonNumberOfExamine.Glyph = global::ClinicManager.Presentation.Properties.Resources.examineturn16x16;
            this.barButtonNumberOfExamine.Id = 15;
            this.barButtonNumberOfExamine.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.examineturn32x32;
            this.barButtonNumberOfExamine.Name = "barButtonNumberOfExamine";
            this.barButtonNumberOfExamine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNumberOfExamine_ItemClick);
            // 
            // barButtonRevenue
            // 
            this.barButtonRevenue.Caption = "Báo cáo doanh thu";
            this.barButtonRevenue.Glyph = global::ClinicManager.Presentation.Properties.Resources.receive_patient16x16;
            this.barButtonRevenue.Id = 16;
            this.barButtonRevenue.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.revenue32x32_;
            this.barButtonRevenue.Name = "barButtonRevenue";
            this.barButtonRevenue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonRevenue_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 17;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Caption = "skinRibbonGalleryBarItem2";
            this.skinRibbonGalleryBarItem2.Id = 18;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // barStaticUser
            // 
            this.barStaticUser.Caption = "__________";
            this.barStaticUser.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticUser.Glyph")));
            this.barStaticUser.Id = 19;
            this.barStaticUser.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barStaticUser.LargeGlyph")));
            this.barStaticUser.Name = "barStaticUser";
            this.barStaticUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barUserMenu
            // 
            this.barUserMenu.Id = 20;
            this.barUserMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonAccountManager),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonLogout)});
            this.barUserMenu.Name = "barUserMenu";
            // 
            // barButtonAccountManager
            // 
            this.barButtonAccountManager.Caption = "Quản lý tài khoản";
            this.barButtonAccountManager.Id = 21;
            this.barButtonAccountManager.Name = "barButtonAccountManager";
            this.barButtonAccountManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAccountManager_ItemClick);
            // 
            // barButtonLogout
            // 
            this.barButtonLogout.Caption = "Đăng xuất";
            this.barButtonLogout.Id = 22;
            this.barButtonLogout.Name = "barButtonLogout";
            this.barButtonLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLogout_ItemClick);
            // 
            // barButtonConfigDatabase
            // 
            this.barButtonConfigDatabase.Caption = "Thay đổi cơ sở dữ liệu";
            this.barButtonConfigDatabase.Id = 24;
            this.barButtonConfigDatabase.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.database_32x32;
            this.barButtonConfigDatabase.Name = "barButtonConfigDatabase";
            this.barButtonConfigDatabase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonConfigDatabase_ItemClick);
            // 
            // barButtonService
            // 
            this.barButtonService.Caption = "Dịch vụ";
            this.barButtonService.Id = 25;
            this.barButtonService.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.service32x32;
            this.barButtonService.Name = "barButtonService";
            this.barButtonService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonService_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageGroupReceivePatient,
            this.pageGroupExamine,
            this.pageGroupPayment});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nghiệp vụ";
            // 
            // pageGroupReceivePatient
            // 
            this.pageGroupReceivePatient.AllowTextClipping = false;
            this.pageGroupReceivePatient.ItemLinks.Add(this.barButtonReceivePatient);
            this.pageGroupReceivePatient.Name = "pageGroupReceivePatient";
            this.pageGroupReceivePatient.ShowCaptionButton = false;
            this.pageGroupReceivePatient.Text = "Tiếp nhận bệnh nhân";
            // 
            // pageGroupExamine
            // 
            this.pageGroupExamine.AllowTextClipping = false;
            this.pageGroupExamine.ItemLinks.Add(this.barButtonExamine);
            this.pageGroupExamine.Name = "pageGroupExamine";
            this.pageGroupExamine.ShowCaptionButton = false;
            this.pageGroupExamine.Text = "Khám bệnh";
            // 
            // pageGroupPayment
            // 
            this.pageGroupPayment.AllowTextClipping = false;
            this.pageGroupPayment.ItemLinks.Add(this.barButtonPayment);
            this.pageGroupPayment.Name = "pageGroupPayment";
            this.pageGroupPayment.ShowCaptionButton = false;
            this.pageGroupPayment.Text = "Thanh toán";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageGroupPatientManager,
            this.pageGroupScheduleManager,
            this.pageGroupMedicineManager,
            this.pageGroupService});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý";
            // 
            // pageGroupPatientManager
            // 
            this.pageGroupPatientManager.AllowTextClipping = false;
            this.pageGroupPatientManager.ItemLinks.Add(this.barButtonPatientManager);
            this.pageGroupPatientManager.Name = "pageGroupPatientManager";
            this.pageGroupPatientManager.ShowCaptionButton = false;
            this.pageGroupPatientManager.Text = "Quản lý bệnh nhân";
            // 
            // pageGroupScheduleManager
            // 
            this.pageGroupScheduleManager.AllowTextClipping = false;
            this.pageGroupScheduleManager.ItemLinks.Add(this.barButtonSchedule);
            this.pageGroupScheduleManager.Name = "pageGroupScheduleManager";
            this.pageGroupScheduleManager.ShowCaptionButton = false;
            this.pageGroupScheduleManager.Text = "Quản lý lịch hẹn";
            // 
            // pageGroupMedicineManager
            // 
            this.pageGroupMedicineManager.AllowTextClipping = false;
            this.pageGroupMedicineManager.ItemLinks.Add(this.barButtonMedicine);
            this.pageGroupMedicineManager.ItemLinks.Add(this.barButtonMedicineType);
            this.pageGroupMedicineManager.ItemLinks.Add(this.barButtonPharmacyType);
            this.pageGroupMedicineManager.ItemLinks.Add(this.barButtonWayToUse);
            this.pageGroupMedicineManager.ItemLinks.Add(this.barButtonUnit);
            this.pageGroupMedicineManager.Name = "pageGroupMedicineManager";
            this.pageGroupMedicineManager.ShowCaptionButton = false;
            this.pageGroupMedicineManager.Text = "Quản lý thuốc";
            // 
            // pageGroupService
            // 
            this.pageGroupService.AllowTextClipping = false;
            this.pageGroupService.ItemLinks.Add(this.barButtonService);
            this.pageGroupService.Name = "pageGroupService";
            this.pageGroupService.ShowCaptionButton = false;
            this.pageGroupService.Text = "Quản lý dịch vụ";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageGroupUserManager,
            this.pageGroupDatabase,
            this.ribbonPageGroup9});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hệ thống";
            // 
            // pageGroupUserManager
            // 
            this.pageGroupUserManager.AllowTextClipping = false;
            this.pageGroupUserManager.ItemLinks.Add(this.barButtonUserManager);
            this.pageGroupUserManager.ItemLinks.Add(this.barButtonPermission);
            this.pageGroupUserManager.Name = "pageGroupUserManager";
            this.pageGroupUserManager.ShowCaptionButton = false;
            this.pageGroupUserManager.Text = "Quản lý người dùng";
            // 
            // pageGroupDatabase
            // 
            this.pageGroupDatabase.AllowTextClipping = false;
            this.pageGroupDatabase.ItemLinks.Add(this.barButtonConfigDatabase);
            this.pageGroupDatabase.Name = "pageGroupDatabase";
            this.pageGroupDatabase.ShowCaptionButton = false;
            this.pageGroupDatabase.Text = "Cơ sở dữ liệu";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.AllowTextClipping = false;
            this.ribbonPageGroup9.ItemLinks.Add(this.skinRibbonGalleryBarItem2);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.ShowCaptionButton = false;
            this.ribbonPageGroup9.Text = "Giao diện";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pageGroupReport});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // pageGroupReport
            // 
            this.pageGroupReport.AllowTextClipping = false;
            this.pageGroupReport.ItemLinks.Add(this.barButtonNumberOfExamine);
            this.pageGroupReport.ItemLinks.Add(this.barButtonRevenue);
            this.pageGroupReport.Name = "pageGroupReport";
            this.pageGroupReport.ShowCaptionButton = false;
            this.pageGroupReport.Text = "Xem báo cáo";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1220, 31);
            // 
            // docManager
            // 
            this.docManager.MdiParent = this;
            this.docManager.MenuManager = this.ribbon;
            this.docManager.View = this.tabbedView1;
            this.docManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 699);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupReceivePatient;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonReceivePatient;
        private DevExpress.XtraBars.BarButtonItem barButtonExamine;
        private DevExpress.XtraBars.BarButtonItem barButtonPayment;
        private DevExpress.XtraBars.BarButtonItem barButtonPatientManager;
        private DevExpress.XtraBars.BarButtonItem barButtonMedicine;
        private DevExpress.XtraBars.BarButtonItem barButtonMedicineType;
        private DevExpress.XtraBars.BarButtonItem barButtonPharmacyType;
        private DevExpress.XtraBars.BarButtonItem barButtonWayToUse;
        private DevExpress.XtraBars.BarButtonItem barButtonUnit;
        private DevExpress.XtraBars.BarButtonItem barButtonSchedule;
        private DevExpress.XtraBars.BarButtonItem barButtonUserManager;
        private DevExpress.XtraBars.BarButtonItem barButtonPermission;
        private DevExpress.XtraBars.BarButtonItem barButtonNumberOfExamine;
        private DevExpress.XtraBars.BarButtonItem barButtonRevenue;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupExamine;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupPayment;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupPatientManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupMedicineManager;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupScheduleManager;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupUserManager;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupReport;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarStaticItem barStaticUser;
        private DevExpress.XtraBars.BarSubItem barUserMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonAccountManager;
        private DevExpress.XtraBars.BarButtonItem barButtonLogout;
        private DevExpress.XtraBars.Docking2010.DocumentManager docManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonConfigDatabase;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupDatabase;
        private DevExpress.XtraBars.BarButtonItem barButtonService;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pageGroupService;
    }
}
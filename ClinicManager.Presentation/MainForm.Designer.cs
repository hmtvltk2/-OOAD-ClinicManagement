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
            this.barButtonUser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPermission = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMedicineExport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonNumberOfExamine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRevenue = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
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
            this.barButtonUser,
            this.barButtonPermission,
            this.barButtonMedicineExport,
            this.barButtonNumberOfExamine,
            this.barButtonRevenue,
            this.skinRibbonGalleryBarItem1,
            this.skinRibbonGalleryBarItem2,
            this.barStaticItem1,
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 24;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barStaticItem1);
            this.ribbon.PageHeaderItemLinks.Add(this.barSubItem1);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(1074, 143);
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
            // barButtonUser
            // 
            this.barButtonUser.Caption = "Tài khoản";
            this.barButtonUser.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonUser.Glyph")));
            this.barButtonUser.Id = 12;
            this.barButtonUser.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonUser.LargeGlyph")));
            this.barButtonUser.Name = "barButtonUser";
            this.barButtonUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUser_ItemClick);
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
            // barButtonMedicineExport
            // 
            this.barButtonMedicineExport.Caption = "Báo cáo thuốc đã xuất";
            this.barButtonMedicineExport.Glyph = global::ClinicManager.Presentation.Properties.Resources.MedicineType16x16;
            this.barButtonMedicineExport.Id = 14;
            this.barButtonMedicineExport.LargeGlyph = global::ClinicManager.Presentation.Properties.Resources.medinceExport32x32;
            this.barButtonMedicineExport.Name = "barButtonMedicineExport";
            this.barButtonMedicineExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMedicineExport_ItemClick);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonReceivePatient);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tiếp nhận bệnh nhân";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonExamine);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Khám bệnh";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonPayment);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Thanh toán";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonPatientManager);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Quản lý bệnh nhân";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonMedicine);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonMedicineType);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonPharmacyType);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonWayToUse);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonUnit);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Quản lý thuốc";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonSchedule);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            this.ribbonPageGroup6.Text = "Quản lý lịch hẹn";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup9});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hệ thống";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonUser);
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonUserManager);
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonPermission);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            this.ribbonPageGroup7.Text = "Quản lý người dùng";
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
            this.ribbonPageGroup8});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonMedicineExport);
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonNumberOfExamine);
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonRevenue);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.ShowCaptionButton = false;
            this.ribbonPageGroup8.Text = "Xem báo cáo";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1074, 31);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "__________";
            this.barStaticItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.Glyph")));
            this.barStaticItem1.Id = 19;
            this.barStaticItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.LargeGlyph")));
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 20;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Quản lý tài khoản";
            this.barButtonItem1.Id = 21;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đăng xuất";
            this.barButtonItem2.Id = 22;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 699);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
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
        private DevExpress.XtraBars.BarButtonItem barButtonUser;
        private DevExpress.XtraBars.BarButtonItem barButtonPermission;
        private DevExpress.XtraBars.BarButtonItem barButtonMedicineExport;
        private DevExpress.XtraBars.BarButtonItem barButtonNumberOfExamine;
        private DevExpress.XtraBars.BarButtonItem barButtonRevenue;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}
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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.barButtonReceivePatient = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonExamine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPayment = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonPatientManager = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMedicine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMedicineType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPharmacyType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonWayToUse = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUnit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSchedule = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonUserManager = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPermission = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonMedicineExport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonNumberOfExamine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRevenue = new DevExpress.XtraBars.BarButtonItem();
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
            this.barButtonRevenue});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(1074, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1074, 31);
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
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hệ thống";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // barButtonReceivePatient
            // 
            this.barButtonReceivePatient.Caption = "Tiếp nhận bệnh nhân";
            this.barButtonReceivePatient.Id = 1;
            this.barButtonReceivePatient.Name = "barButtonReceivePatient";
            this.barButtonReceivePatient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonReceivePatient_ItemClick);
            // 
            // barButtonExamine
            // 
            this.barButtonExamine.Caption = "Khám bệnh";
            this.barButtonExamine.Id = 2;
            this.barButtonExamine.Name = "barButtonExamine";
            this.barButtonExamine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonExamine_ItemClick);
            // 
            // barButtonPayment
            // 
            this.barButtonPayment.Caption = "Thanh toán";
            this.barButtonPayment.Id = 3;
            this.barButtonPayment.Name = "barButtonPayment";
            this.barButtonPayment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPayment_ItemClick);
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
            // barButtonPatientManager
            // 
            this.barButtonPatientManager.Caption = "Quản lý bệnh nhân";
            this.barButtonPatientManager.Id = 4;
            this.barButtonPatientManager.Name = "barButtonPatientManager";
            this.barButtonPatientManager.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPatientManager_ItemClick);
            // 
            // barButtonMedicine
            // 
            this.barButtonMedicine.Caption = "Thuốc";
            this.barButtonMedicine.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonMedicine.Glyph")));
            this.barButtonMedicine.Id = 5;
            this.barButtonMedicine.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonMedicine.LargeGlyph")));
            this.barButtonMedicine.Name = "barButtonMedicine";
            this.barButtonMedicine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMedicine_ItemClick);
            // 
            // barButtonMedicineType
            // 
            this.barButtonMedicineType.Caption = "Loại thuốc";
            this.barButtonMedicineType.Id = 6;
            this.barButtonMedicineType.Name = "barButtonMedicineType";
            this.barButtonMedicineType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMedicineType_ItemClick);
            // 
            // barButtonPharmacyType
            // 
            this.barButtonPharmacyType.Caption = "Dạng bào chế";
            this.barButtonPharmacyType.Id = 7;
            this.barButtonPharmacyType.Name = "barButtonPharmacyType";
            this.barButtonPharmacyType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPharmacyType_ItemClick);
            // 
            // barButtonWayToUse
            // 
            this.barButtonWayToUse.Caption = "Đường dùng";
            this.barButtonWayToUse.Id = 8;
            this.barButtonWayToUse.Name = "barButtonWayToUse";
            this.barButtonWayToUse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonWayToUse_ItemClick);
            // 
            // barButtonUnit
            // 
            this.barButtonUnit.Caption = "Đơn vị tính";
            this.barButtonUnit.Id = 9;
            this.barButtonUnit.Name = "barButtonUnit";
            this.barButtonUnit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUnit_ItemClick);
            // 
            // barButtonSchedule
            // 
            this.barButtonSchedule.Caption = "Lịch hẹn";
            this.barButtonSchedule.Id = 10;
            this.barButtonSchedule.Name = "barButtonSchedule";
            this.barButtonSchedule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSchedule_ItemClick);
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
            // barButtonUserManager
            // 
            this.barButtonUserManager.Caption = "Quản lí người dùng";
            this.barButtonUserManager.Id = 11;
            this.barButtonUserManager.Name = "barButtonUserManager";
            // 
            // barButtonUser
            // 
            this.barButtonUser.Caption = "Tài khoản";
            this.barButtonUser.Id = 12;
            this.barButtonUser.Name = "barButtonUser";
            // 
            // barButtonPermission
            // 
            this.barButtonPermission.Caption = "Phân quyền";
            this.barButtonPermission.Id = 13;
            this.barButtonPermission.Name = "barButtonPermission";
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
            // barButtonMedicineExport
            // 
            this.barButtonMedicineExport.Caption = "Báo cáo thuốc đã xuất";
            this.barButtonMedicineExport.Id = 14;
            this.barButtonMedicineExport.Name = "barButtonMedicineExport";
            this.barButtonMedicineExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMedicineExport_ItemClick);
            // 
            // barButtonNumberOfExamine
            // 
            this.barButtonNumberOfExamine.Caption = "Báo cáo lượt khám";
            this.barButtonNumberOfExamine.Id = 15;
            this.barButtonNumberOfExamine.Name = "barButtonNumberOfExamine";
            this.barButtonNumberOfExamine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNumberOfExamine_ItemClick);
            // 
            // barButtonRevenue
            // 
            this.barButtonRevenue.Caption = "Báo cáo doanh thu";
            this.barButtonRevenue.Id = 16;
            this.barButtonRevenue.Name = "barButtonRevenue";
            this.barButtonRevenue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonRevenue_ItemClick);
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
    }
}
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
            DevExpress.Utils.Animation.PushTransition pushTransition2 = new DevExpress.Utils.Animation.PushTransition();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonCreatePatient = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCreateExamination = new DevExpress.XtraBars.BarButtonItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager();
            this.barButtonExamine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPayment = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonCreatePatient,
            this.barButtonCreateExamination,
            this.barWorkspaceMenuItem1,
            this.barButtonExamine,
            this.barButtonPayment});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(1064, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonCreatePatient
            // 
            this.barButtonCreatePatient.Caption = "Tạo hồ sơ mới";
            this.barButtonCreatePatient.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonCreatePatient.Glyph")));
            this.barButtonCreatePatient.Id = 1;
            this.barButtonCreatePatient.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonCreatePatient.LargeGlyph")));
            this.barButtonCreatePatient.Name = "barButtonCreatePatient";
            // 
            // barButtonCreateExamination
            // 
            this.barButtonCreateExamination.Caption = "Tạo phiên khám";
            this.barButtonCreateExamination.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonCreateExamination.Glyph")));
            this.barButtonCreateExamination.Id = 2;
            this.barButtonCreateExamination.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonCreateExamination.LargeGlyph")));
            this.barButtonCreateExamination.Name = "barButtonCreateExamination";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 3;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition2;
            // 
            // barButtonExamine
            // 
            this.barButtonExamine.Caption = "Khám bệnh";
            this.barButtonExamine.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonExamine.Glyph")));
            this.barButtonExamine.Id = 4;
            this.barButtonExamine.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonExamine.LargeGlyph")));
            this.barButtonExamine.Name = "barButtonExamine";
            this.barButtonExamine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonExamine_ItemClick);
            // 
            // barButtonPayment
            // 
            this.barButtonPayment.Caption = "Thanh toán";
            this.barButtonPayment.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonPayment.Glyph")));
            this.barButtonPayment.Id = 5;
            this.barButtonPayment.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonPayment.LargeGlyph")));
            this.barButtonPayment.Name = "barButtonPayment";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonCreatePatient);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonCreateExamination);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tiếp nhận bệnh nhân";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonExamine);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Khám bệnh";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonPayment);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thanh toán";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hệ thống";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo cáo";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1064, 31);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 699);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem barButtonCreatePatient;
        private DevExpress.XtraBars.BarButtonItem barButtonCreateExamination;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonExamine;
        private DevExpress.XtraBars.BarButtonItem barButtonPayment;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}
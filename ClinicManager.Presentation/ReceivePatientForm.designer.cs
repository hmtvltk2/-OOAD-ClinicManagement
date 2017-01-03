namespace ClinicManager.Presentation
{
    partial class ReceivePatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivePatientForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridSearchList = new DevExpress.XtraGrid.GridControl();
            this.gridviewSearchList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.comboGender = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateDateOfBirth = new DevExpress.XtraEditors.DateEdit();
            this.textPatientName = new DevExpress.XtraEditors.TextEdit();
            this.GridExamineList = new DevExpress.XtraGrid.GridControl();
            this.gridViewExamineList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FullNameToday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GenderToday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddressToday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateOfBirthToday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhoneToday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExamineReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Doctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAddPatient = new DevExpress.XtraEditors.SimpleButton();
            this.buttonCreateExamine = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem11 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSearchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateOfBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPatientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridExamineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExamineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridSearchList);
            this.layoutControl1.Controls.Add(this.buttonSearch);
            this.layoutControl1.Controls.Add(this.comboGender);
            this.layoutControl1.Controls.Add(this.dateDateOfBirth);
            this.layoutControl1.Controls.Add(this.textPatientName);
            this.layoutControl1.Controls.Add(this.GridExamineList);
            this.layoutControl1.Controls.Add(this.buttonClose);
            this.layoutControl1.Controls.Add(this.buttonAddPatient);
            this.layoutControl1.Controls.Add(this.buttonCreateExamine);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(685, 463, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1058, 506);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridSearchList
            // 
            this.gridSearchList.Location = new System.Drawing.Point(24, 78);
            this.gridSearchList.MainView = this.gridviewSearchList;
            this.gridSearchList.Name = "gridSearchList";
            this.gridSearchList.Size = new System.Drawing.Size(1010, 154);
            this.gridSearchList.TabIndex = 10;
            this.gridSearchList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewSearchList});
            // 
            // gridviewSearchList
            // 
            this.gridviewSearchList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn2});
            this.gridviewSearchList.GridControl = this.gridSearchList;
            this.gridviewSearchList.IndicatorWidth = 50;
            this.gridviewSearchList.Name = "gridviewSearchList";
            this.gridviewSearchList.OptionsBehavior.ReadOnly = true;
            this.gridviewSearchList.OptionsView.ShowGroupPanel = false;
            this.gridviewSearchList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridviewSearchList_CustomDrawRowIndicator);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Họ tên";
            this.gridColumn1.FieldName = "FullName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 221;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giới tính";
            this.gridColumn3.FieldName = "Gender";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ngày sinh";
            this.gridColumn4.FieldName = "DateOfBirth";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 113;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Địa chỉ";
            this.gridColumn2.FieldName = "Address";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 524;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(771, 42);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(108, 22);
            this.buttonSearch.StyleController = this.layoutControl1;
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Tìm";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboGender
            // 
            this.comboGender.Location = new System.Drawing.Point(622, 42);
            this.comboGender.Name = "comboGender";
            this.comboGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboGender.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboGender.Size = new System.Drawing.Size(135, 20);
            this.comboGender.StyleController = this.layoutControl1;
            this.comboGender.TabIndex = 3;
            // 
            // dateDateOfBirth
            // 
            this.dateDateOfBirth.EditValue = null;
            this.dateDateOfBirth.Location = new System.Drawing.Point(385, 42);
            this.dateDateOfBirth.Name = "dateDateOfBirth";
            this.dateDateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateOfBirth.Size = new System.Drawing.Size(148, 20);
            this.dateDateOfBirth.StyleController = this.layoutControl1;
            this.dateDateOfBirth.TabIndex = 2;
            // 
            // textPatientName
            // 
            this.textPatientName.Location = new System.Drawing.Point(99, 42);
            this.textPatientName.Name = "textPatientName";
            this.textPatientName.Size = new System.Drawing.Size(197, 20);
            this.textPatientName.StyleController = this.layoutControl1;
            this.textPatientName.TabIndex = 0;
            // 
            // GridExamineList
            // 
            this.GridExamineList.Location = new System.Drawing.Point(24, 304);
            this.GridExamineList.MainView = this.gridViewExamineList;
            this.GridExamineList.Name = "GridExamineList";
            this.GridExamineList.Size = new System.Drawing.Size(1010, 178);
            this.GridExamineList.TabIndex = 9;
            this.GridExamineList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewExamineList});
            // 
            // gridViewExamineList
            // 
            this.gridViewExamineList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FullNameToday,
            this.GenderToday,
            this.AddressToday,
            this.DateOfBirthToday,
            this.PhoneToday,
            this.ExamineReason,
            this.Doctor});
            this.gridViewExamineList.GridControl = this.GridExamineList;
            this.gridViewExamineList.IndicatorWidth = 50;
            this.gridViewExamineList.Name = "gridViewExamineList";
            this.gridViewExamineList.OptionsBehavior.ReadOnly = true;
            this.gridViewExamineList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewExamineList_CustomDrawRowIndicator);
            // 
            // FullNameToday
            // 
            this.FullNameToday.Caption = "Họ tên";
            this.FullNameToday.FieldName = "FullName";
            this.FullNameToday.Name = "FullNameToday";
            this.FullNameToday.Visible = true;
            this.FullNameToday.VisibleIndex = 0;
            this.FullNameToday.Width = 163;
            // 
            // GenderToday
            // 
            this.GenderToday.Caption = "Giới tính";
            this.GenderToday.FieldName = "Gender";
            this.GenderToday.Name = "GenderToday";
            this.GenderToday.Visible = true;
            this.GenderToday.VisibleIndex = 1;
            this.GenderToday.Width = 78;
            // 
            // AddressToday
            // 
            this.AddressToday.Caption = "Địa chỉ";
            this.AddressToday.FieldName = "Address";
            this.AddressToday.Name = "AddressToday";
            this.AddressToday.Visible = true;
            this.AddressToday.VisibleIndex = 4;
            this.AddressToday.Width = 153;
            // 
            // DateOfBirthToday
            // 
            this.DateOfBirthToday.Caption = "Ngày sinh";
            this.DateOfBirthToday.FieldName = "DateOfBirth";
            this.DateOfBirthToday.Name = "DateOfBirthToday";
            this.DateOfBirthToday.Visible = true;
            this.DateOfBirthToday.VisibleIndex = 2;
            this.DateOfBirthToday.Width = 91;
            // 
            // PhoneToday
            // 
            this.PhoneToday.Caption = "Điện thoại";
            this.PhoneToday.FieldName = "Phone";
            this.PhoneToday.Name = "PhoneToday";
            this.PhoneToday.Visible = true;
            this.PhoneToday.VisibleIndex = 3;
            this.PhoneToday.Width = 153;
            // 
            // ExamineReason
            // 
            this.ExamineReason.Caption = "Lý do khám";
            this.ExamineReason.FieldName = "ExamineReason";
            this.ExamineReason.Name = "ExamineReason";
            this.ExamineReason.Visible = true;
            this.ExamineReason.VisibleIndex = 5;
            this.ExamineReason.Width = 153;
            // 
            // Doctor
            // 
            this.Doctor.Caption = "Bác sĩ khám";
            this.Doctor.FieldName = "DoctorName";
            this.Doctor.Name = "Doctor";
            this.Doctor.Visible = true;
            this.Doctor.VisibleIndex = 6;
            this.Doctor.Width = 167;
            // 
            // buttonClose
            // 
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(936, 248);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(110, 22);
            this.buttonClose.StyleController = this.layoutControl1;
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPatient.Image")));
            this.buttonAddPatient.Location = new System.Drawing.Point(713, 248);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(110, 22);
            this.buttonAddPatient.StyleController = this.layoutControl1;
            this.buttonAddPatient.TabIndex = 6;
            this.buttonAddPatient.Text = "Thêm bệnh nhân";
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // buttonCreateExamine
            // 
            this.buttonCreateExamine.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateExamine.Image")));
            this.buttonCreateExamine.Location = new System.Drawing.Point(827, 248);
            this.buttonCreateExamine.Name = "buttonCreateExamine";
            this.buttonCreateExamine.Size = new System.Drawing.Size(105, 22);
            this.buttonCreateExamine.StyleController = this.layoutControl1;
            this.buttonCreateExamine.TabIndex = 7;
            this.buttonCreateExamine.Text = "Tạo phiên khám";
            this.buttonCreateExamine.Click += new System.EventHandler(this.buttonCreateExamine_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlGroup4,
            this.layoutControlGroup2,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1058, 506);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.buttonCreateExamine;
            this.layoutControlItem4.Location = new System.Drawing.Point(815, 236);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(109, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.buttonAddPatient;
            this.layoutControlItem5.Location = new System.Drawing.Point(701, 236);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(114, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.buttonClose;
            this.layoutControlItem6.Location = new System.Drawing.Point(924, 236);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(114, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 262);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1038, 224);
            this.layoutControlGroup4.Text = "Danh sách phiên khám trong ngày";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GridExamineList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1014, 182);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem2,
            this.emptySpaceItem9,
            this.emptySpaceItem10,
            this.emptySpaceItem11,
            this.layoutControlItem3,
            this.emptySpaceItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1038, 236);
            this.layoutControlGroup2.Text = "Tìm kiếm bệnh nhân";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textPatientName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(276, 26);
            this.layoutControlItem2.Text = "Tên bệnh nhân";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.dateDateOfBirth;
            this.layoutControlItem7.Location = new System.Drawing.Point(286, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(227, 26);
            this.layoutControlItem7.Text = "Ngày sinh";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.comboGender;
            this.layoutControlItem8.Location = new System.Drawing.Point(523, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(214, 26);
            this.layoutControlItem8.Text = "Giới tính";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.buttonSearch;
            this.layoutControlItem9.Location = new System.Drawing.Point(747, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(112, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(859, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(155, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(276, 0);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(513, 0);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem11
            // 
            this.emptySpaceItem11.AllowHotTrack = false;
            this.emptySpaceItem11.Location = new System.Drawing.Point(737, 0);
            this.emptySpaceItem11.Name = "emptySpaceItem11";
            this.emptySpaceItem11.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem11.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridSearchList;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1014, 158);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 26);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(1014, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 236);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(701, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ReceivePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 506);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReceivePatientForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiếp nhận bệnh nhân";
            this.Load += new System.EventHandler(this.ReceivePatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewSearchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateOfBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPatientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridExamineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExamineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

    //#endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton buttonClose;
        private DevExpress.XtraEditors.SimpleButton buttonAddPatient;
        private DevExpress.XtraEditors.SimpleButton buttonCreateExamine;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.TextEdit textPatientName;
        private DevExpress.XtraGrid.GridControl GridExamineList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewExamineList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.DateEdit dateDateOfBirth;
        private DevExpress.XtraEditors.SimpleButton buttonSearch;
        private DevExpress.XtraEditors.ComboBoxEdit comboGender;
        private DevExpress.XtraGrid.Columns.GridColumn FullNameToday;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem11;
        private DevExpress.XtraGrid.Columns.GridColumn GenderToday;
        private DevExpress.XtraGrid.Columns.GridColumn AddressToday;
        private DevExpress.XtraGrid.Columns.GridColumn DateOfBirthToday;
        private DevExpress.XtraGrid.Columns.GridColumn PhoneToday;
        private DevExpress.XtraGrid.Columns.GridColumn ExamineReason;
        private DevExpress.XtraGrid.Columns.GridColumn Doctor;
        private DevExpress.XtraGrid.GridControl gridSearchList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridviewSearchList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
    }
}
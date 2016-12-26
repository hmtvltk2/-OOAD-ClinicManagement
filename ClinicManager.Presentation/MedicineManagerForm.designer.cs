namespace ClinicManager.Presentation
{
    partial class MedicineManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineManagerForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lookUpEditType = new DevExpress.XtraEditors.LookUpEdit();
            this.gridCMedicineList = new DevExpress.XtraGrid.GridControl();
            this.gridViewMedicineList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.Xóa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnWay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpWay = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnPhramacy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpPharmacy = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpUnit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemComboType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.buttonExit = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSearch = new DevExpress.XtraEditors.SimpleButton();
            this.textMedicineName = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem10 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCMedicineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedicineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpWay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpPharmacy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lookUpEditType);
            this.layoutControl1.Controls.Add(this.gridCMedicineList);
            this.layoutControl1.Controls.Add(this.buttonExit);
            this.layoutControl1.Controls.Add(this.buttonSearch);
            this.layoutControl1.Controls.Add(this.textMedicineName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1058, 518);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lookUpEditType
            // 
            this.lookUpEditType.Location = new System.Drawing.Point(312, 52);
            this.lookUpEditType.Name = "lookUpEditType";
            this.lookUpEditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditType.Properties.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch;
            this.lookUpEditType.Properties.NullText = "--Tất cả--";
            this.lookUpEditType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditType.Size = new System.Drawing.Size(162, 20);
            this.lookUpEditType.StyleController = this.layoutControl1;
            this.lookUpEditType.TabIndex = 10;
            // 
            // gridCMedicineList
            // 
            this.gridCMedicineList.Location = new System.Drawing.Point(24, 140);
            this.gridCMedicineList.MainView = this.gridViewMedicineList;
            this.gridCMedicineList.Name = "gridCMedicineList";
            this.gridCMedicineList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDelete,
            this.repositoryItemComboType,
            this.LookUpType,
            this.LookUpWay,
            this.LookUpPharmacy,
            this.LookUpUnit});
            this.gridCMedicineList.Size = new System.Drawing.Size(1010, 354);
            this.gridCMedicineList.TabIndex = 9;
            this.gridCMedicineList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMedicineList});
            // 
            // gridViewMedicineList
            // 
            this.gridViewMedicineList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.Xóa,
            this.gridColumnName,
            this.gridColumnType,
            this.gridColumnWay,
            this.gridColumnPhramacy,
            this.gridColumnUnit});
            this.gridViewMedicineList.GridControl = this.gridCMedicineList;
            this.gridViewMedicineList.IndicatorWidth = 50;
            this.gridViewMedicineList.Name = "gridViewMedicineList";
            this.gridViewMedicineList.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewMedicineList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewMedicineList_CustomDrawRowIndicator);
            this.gridViewMedicineList.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewMedicineList_InvalidRowException);
            this.gridViewMedicineList.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewMedicineList_ValidateRow);
            this.gridViewMedicineList.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewMedicineList_RowUpdated);
            // 
            // gridColumn7
            // 
            this.gridColumn7.ColumnEdit = this.repositoryItemDelete;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 43;
            // 
            // repositoryItemDelete
            // 
            this.repositoryItemDelete.AutoHeight = false;
            this.repositoryItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemDelete.Image")));
            this.repositoryItemDelete.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDelete.Name = "repositoryItemDelete";
            this.repositoryItemDelete.Click += new System.EventHandler(this.repositoryItemDelete_Click);
            // 
            // Xóa
            // 
            this.Xóa.Caption = "Mã thuốc";
            this.Xóa.FieldName = "MedicineID";
            this.Xóa.Name = "Xóa";
            this.Xóa.OptionsColumn.ReadOnly = true;
            this.Xóa.Visible = true;
            this.Xóa.VisibleIndex = 1;
            this.Xóa.Width = 70;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Tên thuốc";
            this.gridColumnName.FieldName = "MedicineName";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 2;
            this.gridColumnName.Width = 248;
            // 
            // gridColumnType
            // 
            this.gridColumnType.Caption = "Loại thuốc";
            this.gridColumnType.ColumnEdit = this.LookUpType;
            this.gridColumnType.FieldName = "MedicineTypeID";
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.Visible = true;
            this.gridColumnType.VisibleIndex = 3;
            this.gridColumnType.Width = 161;
            // 
            // LookUpType
            // 
            this.LookUpType.AutoHeight = false;
            this.LookUpType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpType.Name = "LookUpType";
            // 
            // gridColumnWay
            // 
            this.gridColumnWay.Caption = "Đường dùng";
            this.gridColumnWay.ColumnEdit = this.LookUpWay;
            this.gridColumnWay.FieldName = "WayToUseID";
            this.gridColumnWay.Name = "gridColumnWay";
            this.gridColumnWay.Visible = true;
            this.gridColumnWay.VisibleIndex = 4;
            this.gridColumnWay.Width = 147;
            // 
            // LookUpWay
            // 
            this.LookUpWay.AutoHeight = false;
            this.LookUpWay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpWay.Name = "LookUpWay";
            // 
            // gridColumnPhramacy
            // 
            this.gridColumnPhramacy.Caption = "Dạng bào chế";
            this.gridColumnPhramacy.ColumnEdit = this.LookUpPharmacy;
            this.gridColumnPhramacy.FieldName = "PharmacyTypeID";
            this.gridColumnPhramacy.Name = "gridColumnPhramacy";
            this.gridColumnPhramacy.Visible = true;
            this.gridColumnPhramacy.VisibleIndex = 5;
            this.gridColumnPhramacy.Width = 157;
            // 
            // LookUpPharmacy
            // 
            this.LookUpPharmacy.AutoHeight = false;
            this.LookUpPharmacy.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpPharmacy.Name = "LookUpPharmacy";
            // 
            // gridColumnUnit
            // 
            this.gridColumnUnit.Caption = "Đơn vị ";
            this.gridColumnUnit.ColumnEdit = this.LookUpUnit;
            this.gridColumnUnit.FieldName = "UnitID";
            this.gridColumnUnit.Name = "gridColumnUnit";
            this.gridColumnUnit.Visible = true;
            this.gridColumnUnit.VisibleIndex = 6;
            this.gridColumnUnit.Width = 132;
            // 
            // LookUpUnit
            // 
            this.LookUpUnit.AutoHeight = false;
            this.LookUpUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpUnit.Name = "LookUpUnit";
            // 
            // repositoryItemComboType
            // 
            this.repositoryItemComboType.AutoHeight = false;
            this.repositoryItemComboType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboType.Name = "repositoryItemComboType";
            // 
            // buttonExit
            // 
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(927, 52);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 22);
            this.buttonExit.StyleController = this.layoutControl1;
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Đóng";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(488, 52);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(107, 22);
            this.buttonSearch.StyleController = this.layoutControl1;
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textMedicineName
            // 
            this.textMedicineName.Location = new System.Drawing.Point(76, 52);
            this.textMedicineName.Name = "textMedicineName";
            this.textMedicineName.Size = new System.Drawing.Size(170, 20);
            this.textMedicineName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.emptySpaceItem10});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1058, 518);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.emptySpaceItem4,
            this.layoutControlItem3,
            this.emptySpaceItem7,
            this.emptySpaceItem6,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.emptySpaceItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1038, 88);
            this.layoutControlGroup2.Text = "Tìm kiếm thuốc";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(575, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(328, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textMedicineName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 10);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(226, 26);
            this.layoutControlItem1.Text = "Tên thuốc";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(49, 13);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(226, 10);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.buttonSearch;
            this.layoutControlItem3.Location = new System.Drawing.Point(464, 10);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(111, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 36);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(1014, 10);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(1014, 10);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.buttonExit;
            this.layoutControlItem5.Location = new System.Drawing.Point(903, 10);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(111, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpEditType;
            this.layoutControlItem2.Location = new System.Drawing.Point(236, 10);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(218, 26);
            this.layoutControlItem2.Text = "Loại thuốc";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(49, 13);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(454, 10);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 98);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1038, 400);
            this.layoutControlGroup3.Text = "Danh sách thuốc";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridCMedicineList;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(1014, 358);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem10
            // 
            this.emptySpaceItem10.AllowHotTrack = false;
            this.emptySpaceItem10.Location = new System.Drawing.Point(0, 88);
            this.emptySpaceItem10.Name = "emptySpaceItem10";
            this.emptySpaceItem10.Size = new System.Drawing.Size(1038, 10);
            this.emptySpaceItem10.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MedicineManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 518);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MedicineManagerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thuốc";
            this.Load += new System.EventHandler(this.MedicineManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCMedicineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMedicineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpWay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpPharmacy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridCMedicineList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMedicineList;
        private DevExpress.XtraGrid.Columns.GridColumn Xóa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnWay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhramacy;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnUnit;
        private DevExpress.XtraEditors.SimpleButton buttonExit;
        private DevExpress.XtraEditors.SimpleButton buttonSearch;
        private System.Windows.Forms.TextBox textMedicineName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpWay;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpPharmacy;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpUnit;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
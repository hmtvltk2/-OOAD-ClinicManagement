namespace ClinicManager.Presentation
{
    partial class PrescriptionForm
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
            DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.buttonPrint = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
            this.textExamineDate = new DevExpress.XtraEditors.TextEdit();
            this.textNote = new DevExpress.XtraEditors.TextEdit();
            this.textDoctorName = new DevExpress.XtraEditors.TextEdit();
            this.textDiagnostic = new DevExpress.XtraEditors.TextEdit();
            this.textPatientName = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryLookUpMedicine = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textExamineDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDoctorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDiagnostic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPatientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Cách dùng";
            gridColumn5.FieldName = "HowToUse";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 358;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.buttonPrint);
            this.layoutControl1.Controls.Add(this.buttonSave);
            this.layoutControl1.Controls.Add(this.buttonClose);
            this.layoutControl1.Controls.Add(this.textExamineDate);
            this.layoutControl1.Controls.Add(this.textNote);
            this.layoutControl1.Controls.Add(this.textDoctorName);
            this.layoutControl1.Controls.Add(this.textDiagnostic);
            this.layoutControl1.Controls.Add(this.textPatientName);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(874, 455);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.Location = new System.Drawing.Point(614, 421);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(123, 22);
            this.buttonPrint.StyleController = this.layoutControl1;
            this.buttonPrint.TabIndex = 12;
            this.buttonPrint.Text = "In đơn thuốc";
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(488, 421);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 22);
            this.buttonSave.StyleController = this.layoutControl1;
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(741, 421);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(121, 22);
            this.buttonClose.StyleController = this.layoutControl1;
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textExamineDate
            // 
            this.textExamineDate.Location = new System.Drawing.Point(85, 90);
            this.textExamineDate.Name = "textExamineDate";
            this.textExamineDate.Properties.ReadOnly = true;
            this.textExamineDate.Size = new System.Drawing.Size(349, 20);
            this.textExamineDate.StyleController = this.layoutControl1;
            this.textExamineDate.TabIndex = 9;
            this.textExamineDate.TabStop = false;
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(499, 90);
            this.textNote.Name = "textNote";
            this.textNote.Properties.ReadOnly = true;
            this.textNote.Size = new System.Drawing.Size(351, 20);
            this.textNote.StyleController = this.layoutControl1;
            this.textNote.TabIndex = 8;
            this.textNote.TabStop = false;
            // 
            // textDoctorName
            // 
            this.textDoctorName.Location = new System.Drawing.Point(499, 42);
            this.textDoctorName.Name = "textDoctorName";
            this.textDoctorName.Properties.ReadOnly = true;
            this.textDoctorName.Size = new System.Drawing.Size(351, 20);
            this.textDoctorName.StyleController = this.layoutControl1;
            this.textDoctorName.TabIndex = 7;
            this.textDoctorName.TabStop = false;
            // 
            // textDiagnostic
            // 
            this.textDiagnostic.EditValue = "";
            this.textDiagnostic.Location = new System.Drawing.Point(85, 66);
            this.textDiagnostic.Name = "textDiagnostic";
            this.textDiagnostic.Properties.ReadOnly = true;
            this.textDiagnostic.Size = new System.Drawing.Size(765, 20);
            this.textDiagnostic.StyleController = this.layoutControl1;
            this.textDiagnostic.TabIndex = 6;
            this.textDiagnostic.TabStop = false;
            // 
            // textPatientName
            // 
            this.textPatientName.Location = new System.Drawing.Point(85, 42);
            this.textPatientName.Name = "textPatientName";
            this.textPatientName.Properties.ReadOnly = true;
            this.textPatientName.Size = new System.Drawing.Size(349, 20);
            this.textPatientName.StyleController = this.layoutControl1;
            this.textPatientName.TabIndex = 5;
            this.textPatientName.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(24, 156);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDelete,
            this.repositoryLookUpMedicine});
            this.gridControl1.Size = new System.Drawing.Size(826, 249);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gridView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView1_InvalidRowException);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 35;
            // 
            // repositoryItemDelete
            // 
            this.repositoryItemDelete.AutoHeight = false;
            this.repositoryItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemDelete.Image")));
            this.repositoryItemDelete.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDelete.Name = "repositoryItemDelete";
            this.repositoryItemDelete.Click += new System.EventHandler(this.repositoryItemDelete_Click);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên thuốc";
            this.gridColumn2.ColumnEdit = this.repositoryLookUpMedicine;
            this.gridColumn2.FieldName = "MedicineID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 260;
            // 
            // repositoryLookUpMedicine
            // 
            this.repositoryLookUpMedicine.AutoHeight = false;
            this.repositoryLookUpMedicine.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryLookUpMedicine.Name = "repositoryLookUpMedicine";
            this.repositoryLookUpMedicine.NullText = "";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số lượng";
            this.gridColumn3.FieldName = "Quantity";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 68;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn vị";
            this.gridColumn4.FieldName = "UnitName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.OptionsColumn.TabStop = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 63;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(874, 455);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 114);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(854, 295);
            this.layoutControlGroup2.Text = "Đơn thuốc";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(830, 253);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(854, 114);
            this.layoutControlGroup3.Text = "Thông tin bệnh án";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textPatientName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(414, 24);
            this.layoutControlItem2.Text = "Bệnh nhân";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textDiagnostic;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(830, 24);
            this.layoutControlItem3.Text = "Chuẩn đoán";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textDoctorName;
            this.layoutControlItem4.Location = new System.Drawing.Point(414, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(416, 24);
            this.layoutControlItem4.Text = "Bác sĩ khám";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textNote;
            this.layoutControlItem5.Location = new System.Drawing.Point(414, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(416, 24);
            this.layoutControlItem5.Text = "Ghi chú";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textExamineDate;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(414, 24);
            this.layoutControlItem6.Text = "Ngày khám";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.buttonClose;
            this.layoutControlItem7.Location = new System.Drawing.Point(729, 409);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(125, 26);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.buttonSave;
            this.layoutControlItem8.Location = new System.Drawing.Point(476, 409);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(126, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.buttonPrint;
            this.layoutControlItem9.Location = new System.Drawing.Point(602, 409);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(127, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 409);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(476, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 455);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PrescriptionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textExamineDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDoctorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textDiagnostic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPatientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryLookUpMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton buttonPrint;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraEditors.SimpleButton buttonClose;
        private DevExpress.XtraEditors.TextEdit textExamineDate;
        private DevExpress.XtraEditors.TextEdit textNote;
        private DevExpress.XtraEditors.TextEdit textDoctorName;
        private DevExpress.XtraEditors.TextEdit textDiagnostic;
        private DevExpress.XtraEditors.TextEdit textPatientName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryLookUpMedicine;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
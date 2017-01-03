namespace ClinicManager.Presentation
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDelete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.UnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ServiceFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemServiceFee = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemServiceFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(515, 493);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDelete,
            this.repositoryItemServiceFee});
            this.gridControl1.Size = new System.Drawing.Size(491, 469);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.UnitID,
            this.UnitName,
            this.ServiceFee});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 50;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView1_InvalidRowException);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // gridColumn1
            // 
            this.gridColumn1.ColumnEdit = this.repositoryItemDelete;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.TabStop = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 31;
            // 
            // repositoryItemDelete
            // 
            this.repositoryItemDelete.Appearance.Options.UseImage = true;
            this.repositoryItemDelete.AutoHeight = false;
            this.repositoryItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("repositoryItemDelete.Image")));
            this.repositoryItemDelete.ImageAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDelete.Name = "repositoryItemDelete";
            this.repositoryItemDelete.Click += new System.EventHandler(this.repositoryItemDelete_Click);
            // 
            // UnitID
            // 
            this.UnitID.Caption = "Mã dịch vụ";
            this.UnitID.FieldName = "ServiceID";
            this.UnitID.Name = "UnitID";
            this.UnitID.OptionsColumn.AllowFocus = false;
            this.UnitID.OptionsColumn.ReadOnly = true;
            this.UnitID.OptionsColumn.TabStop = false;
            this.UnitID.Visible = true;
            this.UnitID.VisibleIndex = 1;
            this.UnitID.Width = 86;
            // 
            // UnitName
            // 
            this.UnitName.Caption = "Tên dịch vụ";
            this.UnitName.FieldName = "ServiceName";
            this.UnitName.Name = "UnitName";
            this.UnitName.Visible = true;
            this.UnitName.VisibleIndex = 2;
            this.UnitName.Width = 211;
            // 
            // ServiceFee
            // 
            this.ServiceFee.Caption = "Phí dịch vụ";
            this.ServiceFee.ColumnEdit = this.repositoryItemServiceFee;
            this.ServiceFee.DisplayFormat.FormatString = "N000";
            this.ServiceFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ServiceFee.FieldName = "ServiceFee";
            this.ServiceFee.Name = "ServiceFee";
            this.ServiceFee.Visible = true;
            this.ServiceFee.VisibleIndex = 3;
            this.ServiceFee.Width = 111;
            // 
            // repositoryItemServiceFee
            // 
            this.repositoryItemServiceFee.AutoHeight = false;
            this.repositoryItemServiceFee.DisplayFormat.FormatString = "N000";
            this.repositoryItemServiceFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemServiceFee.EditFormat.FormatString = "N000";
            this.repositoryItemServiceFee.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemServiceFee.Name = "repositoryItemServiceFee";
            this.repositoryItemServiceFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.repositoryItemServiceFee_KeyPress);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(515, 493);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(495, 473);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 493);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServiceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dịch vụ";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemServiceFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemDelete;
        private DevExpress.XtraGrid.Columns.GridColumn UnitID;
        private DevExpress.XtraGrid.Columns.GridColumn UnitName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ServiceFee;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemServiceFee;
    }
}
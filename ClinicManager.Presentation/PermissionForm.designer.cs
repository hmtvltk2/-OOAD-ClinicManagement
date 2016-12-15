namespace LibraryManager.Presentation.GUI
{
    partial class PermissionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.checkedListPermission = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.textEditId = new DevExpress.XtraEditors.TextEdit();
            this.buttonClose = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSave = new DevExpress.XtraEditors.SimpleButton();
            this.buttonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.buttonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.checkedListPermission);
            this.layoutControl1.Controls.Add(this.textEditName);
            this.layoutControl1.Controls.Add(this.textEditId);
            this.layoutControl1.Controls.Add(this.buttonClose);
            this.layoutControl1.Controls.Add(this.buttonSave);
            this.layoutControl1.Controls.Add(this.buttonAdd);
            this.layoutControl1.Controls.Add(this.buttonDelete);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1026, 547);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // checkedListPermission
            // 
            this.checkedListPermission.CheckOnClick = true;
            this.checkedListPermission.ColumnWidth = 500;
            this.checkedListPermission.Location = new System.Drawing.Point(24, 66);
            this.checkedListPermission.MultiColumn = true;
            this.checkedListPermission.Name = "checkedListPermission";
            this.checkedListPermission.Size = new System.Drawing.Size(978, 222);
            this.checkedListPermission.StyleController = this.layoutControl1;
            this.checkedListPermission.TabIndex = 13;
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(490, 42);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(512, 20);
            this.textEditName.StyleController = this.layoutControl1;
            this.textEditName.TabIndex = 12;
            // 
            // textEditId
            // 
            this.textEditId.Location = new System.Drawing.Point(138, 42);
            this.textEditId.Name = "textEditId";
            this.textEditId.Properties.ReadOnly = true;
            this.textEditId.Size = new System.Drawing.Size(234, 20);
            this.textEditId.StyleController = this.layoutControl1;
            this.textEditId.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(929, 304);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(85, 22);
            this.buttonClose.StyleController = this.layoutControl1;
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(737, 304);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 22);
            this.buttonSave.StyleController = this.layoutControl1;
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(642, 304);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 22);
            this.buttonAdd.StyleController = this.layoutControl1;
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(837, 304);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 22);
            this.buttonDelete.StyleController = this.layoutControl1;
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Xóa";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(24, 360);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(978, 163);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnId,
            this.columnName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // columnId
            // 
            this.columnId.Caption = "Mã nhóm người dùng";
            this.columnId.FieldName = "Id";
            this.columnId.Name = "columnId";
            this.columnId.OptionsColumn.ReadOnly = true;
            this.columnId.Visible = true;
            this.columnId.VisibleIndex = 0;
            this.columnId.Width = 179;
            // 
            // columnName
            // 
            this.columnName.Caption = "Tên nhóm người dùng";
            this.columnName.FieldName = "Name";
            this.columnName.Name = "columnName";
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 1;
            this.columnName.Width = 757;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1026, 547);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 318);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1006, 209);
            this.layoutControlGroup2.Text = "Danh sách nhóm người dùng";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(982, 167);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1006, 292);
            this.layoutControlGroup3.Text = "Danh sách quyền";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEditId;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(352, 24);
            this.layoutControlItem7.Text = "Mã nhóm người dùng :";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.checkedListPermission;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(982, 226);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEditName;
            this.layoutControlItem3.Location = new System.Drawing.Point(352, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(630, 24);
            this.layoutControlItem3.Text = "Tên nhóm người dùng :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(111, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.buttonAdd;
            this.layoutControlItem4.Location = new System.Drawing.Point(630, 292);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(95, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.buttonDelete;
            this.layoutControlItem2.Location = new System.Drawing.Point(825, 292);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(92, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.buttonClose;
            this.layoutControlItem6.Location = new System.Drawing.Point(917, 292);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(89, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.buttonSave;
            this.layoutControlItem5.Location = new System.Drawing.Point(725, 292);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(100, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 292);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(630, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PermissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 547);
            this.Controls.Add(this.layoutControl1);
            this.Name = "PermissionForm";
            this.Text = "Phân quyền";
            this.Load += new System.EventHandler(this.PermissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkedListPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton buttonClose;
        private DevExpress.XtraEditors.SimpleButton buttonSave;
        private DevExpress.XtraEditors.SimpleButton buttonAdd;
        private DevExpress.XtraEditors.SimpleButton buttonDelete;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn columnId;
        private DevExpress.XtraGrid.Columns.GridColumn columnName;
        private DevExpress.XtraEditors.CheckedListBoxControl checkedListPermission;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.TextEdit textEditId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
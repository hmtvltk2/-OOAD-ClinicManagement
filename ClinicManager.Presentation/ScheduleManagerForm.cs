using ClinicManager.DataBusiness;
using ClinicManager.DataModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManager.Presentation
{
    public partial class ScheduleManagerForm : Form
    {
        ScheduleBusiness schedulueBusiness;
        public ScheduleManagerForm()
        { 
            InitializeComponent();
            schedulueBusiness = new ScheduleBusiness();
            }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<CreateScheduleForm>())
            {
                var fr = form as Form;
                fr.Activate();
                return;
            }
            var f = new CreateScheduleForm();
            f.ShowDialog();
            gridControl1.DataSource = schedulueBusiness.GetAll();
        }

        private void ScheduleManagerForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = schedulueBusiness.GetAll();
            // Load lookupedit for search for edit
            UserBusiness user = new UserBusiness();
            LookUpDoctor.DataSource = user.GetAll();
            LookUpDoctor.ValueMember = "UserID";
            LookUpDoctor.DisplayMember = "FullName";
            LookUpDoctor.Columns.Add(new LookUpColumnInfo("FullName", "Bác sỹ"));
            // Load lookupedit for search
            UserBusiness userSearch = new UserBusiness();
            DataTable datasource = userSearch.GetAll();
            var row = datasource.NewRow();
            row["UserID"] = 0;
            row["FullName"] = "Tất cả";
            datasource.Rows.Add(row);
            lookUpDoctorSearch.Properties.DataSource = datasource;
            lookUpDoctorSearch.Properties.ValueMember = "UserID";
            lookUpDoctorSearch.Properties.DisplayMember = "FullName";
            lookUpDoctorSearch.Properties.Columns.Add(new LookUpColumnInfo("FullName", "Bác sỹ"));
            lookUpDoctorSearch.ItemIndex = datasource.Rows.IndexOf(row);
            //set date for search
            dateFromDay.EditValue = DateTime.Today;
            dateToDay.EditValue = DateTime.Today;
        }

        private void dateFromDay_Validating(object sender, CancelEventArgs e)
        {
            dateToDay.Properties.MinValue = (DateTime)dateFromDay.EditValue;
        }

       

        private void dateToDay_Validating(object sender, CancelEventArgs e)
        {
            dateFromDay.Properties.MaxValue = (DateTime)dateToDay.EditValue;
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            foreach (GridColumn col in gridView1.Columns)
            {
                if (col.ColumnEditName == repositoryItemDelete.Name)
                {
                    continue;
                }
                var a = row[col.FieldName];
                e.ErrorText = schedulueBusiness.Validate(row[col.FieldName], col.FieldName);
                if (e.ErrorText != "")
                {
                    e.Valid = false;
                }

                gridView1.SetColumnError(col, e.ErrorText);
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Get data in focus row
            var row = (e.Row as DataRowView).Row;
            // if isInsert ="" mean focusrow at add new row else at edit row
            bool result;
            Schedule schedule = new Schedule()
            {
                PatientScheduleID = (int)row["PatientScheduleID"],
                FullName = row["FullName"].ToString(),
                Address = row["Address"].ToString(),
                DoctorID = (int)row["DoctorID"],
                Note = row["Note"].ToString(),
                Phone = row["Phone"].ToString(),
                ScheduleDate = (DateTime)row["ScheduleDate"],
                ScheduleType = row["ScheduleType"].ToString()
          };
            result = schedulueBusiness.Update(schedule);
            if (result)
            {
                XtraMessageBox.Show(this, "Lưu thành công","Thông báo" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(this, "Lưu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void repositoryItemDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle == GridControl.NewItemRowHandle)
            { return; }
            
             
                if (XtraMessageBox.Show(this, "Bạn chắn chắn xóa dòng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var row = gridView1.GetFocusedDataRow(); // get data on one row
                    bool result = schedulueBusiness.Delete((int)row["PatientScheduleID"]); // delete in schedule paramater (datatype)row["ScheduleID"]
                    if (result)
                    {
                        gridView1.DeleteSelectedRows();
                    }
                    else
                    {
                        XtraMessageBox.Show(this, "Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if ((int)lookUpDoctorSearch.EditValue == 0)
            {
                gridControl1.DataSource = schedulueBusiness.GetByCondition((DateTime)dateFromDay.EditValue, (DateTime)dateToDay.EditValue);
                
            }
            if ((int)lookUpDoctorSearch.EditValue != 0)
            {
                gridControl1.DataSource = schedulueBusiness.GetByCondition((DateTime)dateFromDay.EditValue, (DateTime)dateToDay.EditValue,(int)lookUpDoctorSearch.EditValue);

            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repositoryItemTextPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

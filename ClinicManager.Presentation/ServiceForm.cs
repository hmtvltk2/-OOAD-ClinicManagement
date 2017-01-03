using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClinicManager.DataBusiness;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using ClinicManager.DataModel;
using DevExpress.XtraGrid.Columns;
using System.Data;


namespace ClinicManager.Presentation
{
    public partial class ServiceForm : DevExpress.XtraEditors.XtraForm
    {
        private ServiceBusiness serviceBusiness;
        public ServiceForm()
        {
            InitializeComponent();
            serviceBusiness = new ServiceBusiness();
        }
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = serviceBusiness.GetAll();
        }       
        private void repositoryItemDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.FocusedRowHandle == GridControl.NewItemRowHandle)
            {
                return;
            }

            if (XtraMessageBox.Show(this, "Bạn chắc chắn xóa dòng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var row = gridView1.GetFocusedDataRow();

                bool result = serviceBusiness.Delete((int)row["ServiceID"]);
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

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var row = gridView1.GetFocusedDataRow();
            foreach (GridColumn col in gridView1.Columns)
            {
                if (col.ColumnEditName == repositoryItemDelete.Name)
                {
                    continue;
                }

                e.ErrorText = serviceBusiness.Validate(row[col.FieldName], col.FieldName);
                if (e.ErrorText != "")
                {
                    e.Valid = false;
                    gridView1.SetColumnError(col, e.ErrorText);
                }
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //Insert, update row
            var row = (e.Row as DataRowView).Row;
            bool result;

            if (gridView1.IsNewItemRow(e.RowHandle))
            {
                //insert
               Service  service = new Service()
                {
                    ServiceName = (string)row["ServiceName"],
                    ServiceFee = decimal.Parse(row["ServiceFee"].ToString()),
                    
                };

                int id = serviceBusiness.Insert(service);
                if (id == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                    row["ServiceID"] = id;
                }
            }
            else
            {
                //update
                Service service = new Service()
                {
                    ServiceID = (int)row["ServiceID"],
                    ServiceName = (string)row["ServiceName"],
                    ServiceFee = decimal.Parse(row["ServiceFee"].ToString()),


                };

                result = serviceBusiness.Update(service);
            }

            if (result)
            {
                XtraMessageBox.Show(this, "Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridView1.FocusedRowHandle = GridControl.NewItemRowHandle;
            }
            else
            {
                XtraMessageBox.Show(this, "Lưu thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void repositoryItemServiceFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
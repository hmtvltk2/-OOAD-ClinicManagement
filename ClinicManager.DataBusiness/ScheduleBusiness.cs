using ClinicManager.DataAccess;
using System;

namespace ClinicManager.DataBusiness
{
    public class ScheduleBusiness
    {
        #region Contructor
        private ScheduleAccess dataAccess;

        public ScheduleBusiness()
        {
            dataAccess = new ScheduleAccess();
        }

        #endregion

        public int Insert(object data)
        {
            return dataAccess.Insert(data);
        }

        public bool Update(object data)
        {
            return dataAccess.Update(data);
        }

        public bool Delete(int id)
        {
            return dataAccess.Delete(id);
        }

        public System.Data.DataTable GetAll()
        {
            return dataAccess.GetAll();
        }
        public System.Data.DataTable GetByCondition(DateTime dateForm, DateTime dateTo, int dotorID)
        {
            return dataAccess.GetByCondition(dateForm, dateTo, dotorID);
        }
        public System.Data.DataTable GetByCondition(DateTime dateForm, DateTime dateTo)
        {
            return dataAccess.GetByCondition(dateForm, dateTo);
        }

        public string Validate(object data, string property)
        {
            string message = "";

            switch (property)
            {
                case "FullName":
                    if (string.IsNullOrWhiteSpace((string)data))
                    {
                        message = "Chưa nhập tên bệnh nhân";
                    }               
                    break;
                case "Phone":
                    int n;           
                    if ((string)data =="")
                    {
                        message = "Chưa nhập số điện thoại";
                    }
                    
                    else if (!int.TryParse((string)data, out n))
                    {
                        message = "Số điện thoại không được chứa kí tự";
                    } 
                   
                    break;
                case "DoctorID":
                    if (data == null)
                    {
                        message = "Chưa chọn bác sỹ";
                    }
                    break;
                default:
                    break;
            }
            

           
         
            return message;
        }

    }
}

using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System;

namespace ClinicManager.DataBusiness
{
    public class ServiceBusiness
    {
        #region Contructor
        private ServiceAccess dataAccess;

        public ServiceBusiness()
        {
            dataAccess = new ServiceAccess();
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

        public string Validate(object data, string propertyName)
        {
            string result = "";

            if (propertyName == "ServiceName")
            {
                if (string.IsNullOrWhiteSpace((string)data))
                {
                    result = "Tên dịch vụ không được trống";
                }
            }
            if (propertyName =="ServiceFee")
            {
                if ( data == DBNull.Value)
                {
                    result = "Phí dịch vụ không được trống";
                }
            }
           
           
            return result;
        }

        public Service GetByServiceID(int serviceID)
        {
            return dataAccess.GetByServiceID(serviceID);
        }
    }
}

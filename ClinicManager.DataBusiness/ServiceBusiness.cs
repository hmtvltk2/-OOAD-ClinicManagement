using ClinicManager.DataAccess;

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
                    result = "Tên đơn vị tính không được trống";
                }
            }

            return result;
        }
    }
}

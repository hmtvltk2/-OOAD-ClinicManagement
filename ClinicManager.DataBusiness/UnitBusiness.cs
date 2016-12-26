using ClinicManager.DataAccess;

namespace ClinicManager.DataBusiness
{
    public class UnitBusiness
    {
        #region Contructor
        private UnitAccess dataAccess;

        public UnitBusiness()
        {
            dataAccess = new UnitAccess();
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

            if(propertyName == "UnitName")
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

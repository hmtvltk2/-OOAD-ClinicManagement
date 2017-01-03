using ClinicManager.DataAccess;
using ClinicManager.DataModel;

namespace ClinicManager.DataBusiness
{
    public class PharmacyTypeBusiness
    {
        #region Contructor
        private PharmacyTypeAccess dataAccess;

        public PharmacyTypeBusiness()
        {
            dataAccess = new PharmacyTypeAccess();
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

            if (propertyName == "PharmacyType")
            {
                if (string.IsNullOrWhiteSpace((string)data))
                {
                    result = "Tên dạng bào chế không được trống";
                }
            }

            return result;
        }
    }
}

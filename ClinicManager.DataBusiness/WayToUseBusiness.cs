using ClinicManager.DataAccess;

namespace ClinicManager.DataBusiness
{
    public class WayToUseBusiness
    {
        #region Contructor
        private WayToUseAccess dataAccess;

        public WayToUseBusiness()
        {
            dataAccess = new WayToUseAccess();
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

        public string Validate(object data, string property)
        {
            return dataAccess.Validate(data, property);
        }
    }
}

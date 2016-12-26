using ClinicManager.DataAccess;

namespace ClinicManager.DataBusiness
{
    public class MedicineTypeBusiness
    {
        #region Contructor
        private MedicineTypeAccess dataAccess;

        public MedicineTypeBusiness()
        {
            dataAccess = new MedicineTypeAccess();
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
    }
}

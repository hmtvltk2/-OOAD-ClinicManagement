using ClinicManager.DataAccess;

namespace ClinicManager.DataBusiness
{
    public class MedicineBusiness
    {
        #region Contructor
        private MedicineAccess dataAccess;

        public MedicineBusiness()
        {
            dataAccess = new MedicineAccess();
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
        public System.Data.DataTable GetByCondition(string medicineName, int medicineTypeID)
        {
            return dataAccess.GetByCondition(medicineName, medicineTypeID);
        }
        public System.Data.DataTable GetByCondition(string medicineName )
        {
            return dataAccess.GetByCondition(medicineName);
        }
        public System.Data.DataTable GetByCondition(int medicineTypeID)
        {
            return dataAccess.GetByCondition(medicineTypeID);
        }
    }
}

using ClinicManager.DataModel;

namespace ClinicManager.DataBusiness
{
    public class MedicalRecordBusiness
    {
        #region Contructor
        private MedicalRecordAccess dataAccess;

        public MedicalRecordBusiness()
        {
            dataAccess = new MedicalRecordAccess();
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


            return result;
        }
    }
}

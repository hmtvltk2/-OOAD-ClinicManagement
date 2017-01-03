using System;
using ClinicManager.DataAccess;

namespace ClinicManager.DataBusiness
{
    public class ServiceDetailBusiness
    {
        #region Contructor
        private ServiceDetailAccess dataAccess;

        public ServiceDetailBusiness()
        {
            dataAccess = new ServiceDetailAccess();
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

        public bool DeleteByMedicalRecordID(int medicalRecordID)
        {
            return dataAccess.DeleteByMedicalRecordID(medicalRecordID);
        }

        public System.Data.DataTable GetByMedicalRecordID(int medicalRecordID)
        {
            return dataAccess.GetByMedicalRecordID(medicalRecordID);
        }
    }
}

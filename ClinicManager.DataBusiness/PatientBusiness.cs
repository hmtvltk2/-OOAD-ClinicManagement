using ClinicManager.DataAccess;
using System;

namespace ClinicManager.DataBusiness
{
    public class PatientBusiness
    {
        #region Contructor
        private PatientAccess dataAccess;

        public PatientBusiness()
        {
            dataAccess = new PatientAccess();
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

        public System.Data.DataTable Search(string patientName, DateTime dateOfBirth, string gender)
        {
            return dataAccess.Search(patientName, dateOfBirth, gender);
        }
    }
}

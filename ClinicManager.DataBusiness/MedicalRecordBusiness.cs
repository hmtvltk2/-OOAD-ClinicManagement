using ClinicManager.DataAccess;
using ClinicManager.Common;
using System;
using ClinicManager.DataModel;
using System.Data;

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
        public System.Data.DataTable GetById(int Id)
        {
            return dataAccess.GetById(Id);
        }

        public System.Data.DataTable GetByStatus(string status)
        {
            return dataAccess.GetByStatus(status);
        }

		public string Validate(object data, string propertyName)
        {
            string result = "";


            return result;
        }

        public System.Data.DataTable GetByDoctorId(int id)
        {
            return dataAccess.GetByDoctorId(id);
        }

        public MedicalRecord GetByPatientID(int patientID)
        {
            return dataAccess.GetByPatientID(patientID);
        }

        public MedicalRecord GetByMedicalRecordID(int medicalRecordID)
        {
            return dataAccess.GetByMedicalRecordID(medicalRecordID);
        }
    }
}

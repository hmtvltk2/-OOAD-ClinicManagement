using System;
using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System.Data;

namespace ClinicManager.DataBusiness
{
    public class PrescriptionDetailBusiness
    {
        #region Contructor
        private PrescriptionDetailAccess dataAccess;

        public PrescriptionDetailBusiness()
        {
            dataAccess = new PrescriptionDetailAccess();
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

        public DataTable GetByPrescriptionID(int prescriptionID)
        {
            return dataAccess.GetByPrescriptionID(prescriptionID);
        }

        public bool DeteleByPrescriptionID(int prescriptionID)
        {
            return dataAccess.DeteleByPrescriptionID(prescriptionID);
        }

        public DataTable GetDetailByPrescriptionID(int prescriptionID)
        {
            return dataAccess.GetDetailByPrescriptionID(prescriptionID);
        }

        public DataTable GetByMedicalRecordID(int medicalRecordID)
        {
            return dataAccess.GetByMedicalRecordID(medicalRecordID);
        }
    }
}

using System;
using System.Data;
using ClinicManager.DataAccess;
using ClinicManager.DataModel;

namespace ClinicManager.DataBusiness
{
    public class PrescriptionBusiness
    {
        #region Contructor
        private PrescriptionAccess dataAccess;

        public PrescriptionBusiness()
        {
            dataAccess = new PrescriptionAccess();
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

        public decimal GetMedicineFee(int medicalReordID)
        {
            return dataAccess.GetMedicineFee(medicalReordID);
        }
        public string Validate(object data, string propertyName)
        {
            string result = "";

            switch (propertyName)
            {
                case "MedicineID":
                    if(data == DBNull.Value)
                    {
                        result = "Chưa chọn thuốc";
                    }
                    break;
                case "Quantity":
                    if(data == DBNull.Value)
                    {
                        result = "Chưa nhập số lượng";
                    }
                    break;
                case "HowToUse":
                    if(string.IsNullOrWhiteSpace(data as string))
                    {
                        result = "Chưa nhập cách dùng";
                    }
                    break;
                default:
                    break;
            }

            return result;
        }

        public DataRow GetMedicalRecordInfo(int prescriptionID)
        {
            return dataAccess.GetMedicalRecordInfo(prescriptionID);
        }

        public Prescription GetByMedicalRecordID(int medicalRecordID)
        {
            return dataAccess.GetByMedicalRecordID(medicalRecordID);
        }

        public Prescription GetByPrescriptionID(int prescriptionID)
        {
            return dataAccess.GetByPrescriptionID(prescriptionID);
        }
    }
}

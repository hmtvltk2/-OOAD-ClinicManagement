using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System;
using System.Data;

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

         public System.Data.DataTable GetByCondition(string name, DateTime dateOfBirth, string gender)
        {
            return dataAccess.GetByCondition(name,dateOfBirth,gender);
        }
        public Patient GetbyId(int id)
        {
            return dataAccess.GetById(id);
        }
         public System.Data.DataTable Search(string patientName, object dateOfBirth, string gender)
        {
            return dataAccess.Search(patientName, dateOfBirth, gender);
        }

        public string Validate(object data, string propertyName)
        {
            string result = "";

            switch (propertyName)
            {
                case "FullName":
                    if(string.IsNullOrWhiteSpace(data as string))
                    {
                        result = "Chưa nhập tên bệnh nhân";
                    }
                    break;
                case "Address":
                    if(string.IsNullOrWhiteSpace(data as string))
                    {
                        result = "Chưa nhập địa chỉ";
                    }
                    break;
                case "DateOfBirth":
                    if(data == null)
                    {
                        result = "Chưa nhập ngày sinh";
                    }
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}

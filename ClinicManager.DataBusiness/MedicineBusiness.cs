using ClinicManager.DataAccess;
using System;

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
            string error = "";
            switch (property)
            {
                case "MedicineName":
                    if (string.IsNullOrWhiteSpace(data as string))
                    {
                        error = "Chưa nhập tên thuốc";
                    }
                    break;
                case "MedicineTypeID":
                    if(data == DBNull.Value)
                    {
                        error = "Chưa chọn loại thuốc";
                    }
                    break;
                case "WayToUseID":
                    if(data == DBNull.Value)
                    {
                        error = "Chưa chọn đường dùng"; 
                    }
                    break;
                case "PharmacyTypeID":
                    if(data == DBNull.Value)
                    {
                        error = "Chưa chọng dạng điều chế"; 
                    }
                    break;
                case "UnitID":
                    if(data == DBNull.Value)
                    {
                        error = "Chưa chọn đơn vị tính";
                    }
                    break;
                default:
                    break;
            }

            return error;
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

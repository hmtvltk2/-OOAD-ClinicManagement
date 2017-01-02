using ClinicManager.DataAccess;
using ClinicManager.DataModel;

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

        public System.Data.DataTable GetById(int medicalRecordID)
        {
            return dataAccess.GetbyId(medicalRecordID);
        }
        public decimal GetTotalFee(int medicalReordID)
        {
            return dataAccess.GetTotalFee(medicalReordID);
        }

        public string Validate(object data, string propertyName)
        {
            string result = "";

            if (propertyName == "ServiceDetailName")
            {
                if (string.IsNullOrWhiteSpace((string)data))
                {
                    result = "Tên đơn vị tính không được trống";
                }
            }

            return result;
        }
    }
}

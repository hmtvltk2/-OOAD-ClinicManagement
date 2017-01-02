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

            if (propertyName == "PrescriptionName")
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

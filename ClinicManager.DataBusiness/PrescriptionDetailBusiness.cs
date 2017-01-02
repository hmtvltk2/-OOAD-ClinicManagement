using ClinicManager.DataAccess;
using ClinicManager.DataModel;

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

        public System.Data.DataTable GetByPrescriptionID( int id)
        {
            return dataAccess.GetByPrescriptionID(id);
        }

        
    }
}

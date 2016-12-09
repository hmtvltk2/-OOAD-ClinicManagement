using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.DataBusiness
{
    public class MedicineTypeBusiness
    {
        #region Contructor
        private MedicineTypeAccess medicineTypeAccess;

        public MedicineTypeBusiness()
        {
            medicineTypeAccess = new MedicineTypeAccess();
        }
        
        #endregion

        public int Insert(object data)
        {
            return medicineTypeAccess.Insert(data);
        }

        public bool Update(object data)
        {
            return medicineTypeAccess.Update(data);
        }

        public bool Delete(int id)
        {
            return medicineTypeAccess.Delete(id);
        }

        public System.Data.DataTable GetAll()
        {
            return medicineTypeAccess.GetAll();
        }

        public string Validate(object data, string property)
        {
            return medicineTypeAccess.Validate(data, property);
        }
    }
}

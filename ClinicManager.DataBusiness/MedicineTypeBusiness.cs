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
        private MedicineTypeAccess dataAccess;

        public MedicineTypeBusiness()
        {
            dataAccess = new MedicineTypeAccess();
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
            return dataAccess.Validate(data, property);
        }
    }
}

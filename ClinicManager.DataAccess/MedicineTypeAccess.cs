using ClinicManager.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.DataAccess
{
    public class MedicineTypeAccess: BaseDataAcess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if(result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.MEDICINE_TYPE orderby d.MedicineTypeID descending select d;
                    var last = query.First();
                    result = last.MedicineTypeID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            using (var db = new ClinicDB())
            {
                MedicineType medicineType = db.MEDICINE_TYPE.Find(id);

                if(medicineType == null)
                {
                    return false;
                }

                return base.Delete(medicineType);
            }
            
        }

        public DataTable GetAll()
        {
            using (var db = new ClinicDB())
            {
                return db.MEDICINE_TYPE.ToDataTable();
            }
        }
    }
}

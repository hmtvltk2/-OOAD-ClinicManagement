using ClinicManager.Common;
using ClinicManager.DataModel;
using System.Data;
using System.Linq;

namespace ClinicManager.DataAccess
{
    public class MedicineTypeAccess: BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if(result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.MedicineType orderby d.MedicineTypeID descending select d;
                    var last = query.First();
                    result = last.MedicineTypeID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            MedicineType model;
            using (var db = new ClinicDB())
            {
                model = db.MedicineType.Find(id);

                if(model == null)
                {
                    return false;
                }
            }

            return base.Delete(model);
        }

        public DataTable GetAll()
        {
            using (var db = new ClinicDB())
            {
                return db.MedicineType.ToDataTable();
            }
        }
    }
}

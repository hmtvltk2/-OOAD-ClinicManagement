using ClinicManager.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.DataAccess
{
    public class PharmacyTypeAccess : BaseDataAcess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.PharmacyType orderby d.PharmacyTypeID descending select d;
                    var last = query.First();
                    result = last.PharmacyTypeID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            PharmacyType model;
            using (var db = new ClinicDB())
            {
                model = db.PharmacyType.Find(id);

                if (model == null)
                {
                    return false;
                }
            }

            return base.Delete(model);
        }

        public System.Data.DataTable GetAll()
        {
            using (var db = new ClinicDB())
            {
                return db.PharmacyType.ToDataTable();
            }
        }
    }
}

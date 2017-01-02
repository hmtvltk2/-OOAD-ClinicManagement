using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System.Data;
using System.Linq;

namespace ClinicManager.DataAccess
{
    public class UnitAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.Unit orderby d.UnitID descending select d;
                    var last = query.First();
                    result = last.UnitID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            Unit model;
            using (var db = new ClinicDB())
            {
                model = db.Unit.Find(id);

                if (model == null)
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
                return db.Unit.ToDataTable();
            }
        }
    }
}

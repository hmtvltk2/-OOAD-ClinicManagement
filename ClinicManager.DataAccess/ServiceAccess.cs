using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System.Data;
using System.Linq;

namespace ClinicManager.DataAccess
{
    public class ServiceAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.Service orderby d.ServiceID descending select d;
                    var last = query.First();
                    result = last.ServiceID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            Service model;
            using (var db = new ClinicDB())
            {
                model = db.Service.Find(id);

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
                return db.Service.ToDataTable();
            }
        }
    }
}

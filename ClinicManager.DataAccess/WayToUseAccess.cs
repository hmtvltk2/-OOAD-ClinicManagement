using ClinicManager.DataModel;
using System.Data;
using System.Linq;

namespace ClinicManager.DataAccess
{
    public class WayToUseAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.WayToUse orderby d.WayToUseID descending select d;
                    var last = query.First();
                    result = last.WayToUseID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            WayToUse model;
            using (var db = new ClinicDB())
            {
                model = db.WayToUse.Find(id);

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
                return db.WayToUse.ToDataTable();
            }
        }
    }
}

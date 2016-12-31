using ClinicManager.DataModel;
using System.Data;
using System.Linq;

namespace ClinicManager.DataAccess
{
    public class UserAccess : BaseDataAcess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new  ClinicDB())
                {
                    var query = from d in db.User orderby d.UserID descending select d;
                    var last = query.First();
                    result = last.UserID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            User model;
            using (var db = new ClinicDB())
            {
                model = db.User.Find(id);

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
                return db.User.ToDataTable();
            }
        }
        public DataTable GetByUserGroup(int userGroupID)
        {
            using (var db = new ClinicDB())
            {
                var user = from u in db.User
                               where (u.UserGroupID == userGroupID)
                               select u;
                var u1 = user.ToList().ToDataTable();
                return user.ToDataTable();
            }
            
        }
    }
}

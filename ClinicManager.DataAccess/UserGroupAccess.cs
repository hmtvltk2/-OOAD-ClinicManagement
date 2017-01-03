using ClinicManager.Common;
using ClinicManager.DataModel;
using System.Data;
using System.Linq;
using System;

namespace ClinicManager.DataAccess
{
    public class UserGroupAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.UserGroup orderby d.UserGroupID descending select d;
                    var last = query.First();
                    result = last.UserGroupID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            UserGroup model;
            using (var db = new ClinicDB())
            {
                model = db.UserGroup.Find(id);

                if (model == null)
                {
                    return false;
                }
            }

            return base.Delete(model);
        }

        public UserGroup GetByUserGroupID(int userGroupID)
        {
            using (var db =new ClinicDB())
            {
                return db.UserGroup.Find(userGroupID);
            }
        }

        public DataTable GetAll()
        {
            using (var db = new ClinicDB())
            {
                return db.UserGroup.ToDataTable();
            }
        }
    }
}

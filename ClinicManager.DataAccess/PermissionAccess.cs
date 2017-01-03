using ClinicManager.Common;
using System.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using ClinicManager.DataModel;

namespace ClinicManager.DataAccess
{
    public class PermissionAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.Permission orderby d.PermissionID descending select d;
                    var last = query.First();
                    result = last.PermissionID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            Permission model;
            using (var db = new ClinicDB())
            {
                model = db.Permission.Find(id);

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
                return db.Permission.ToDataTable();
            }
        }

        public DataTable GetPermissionByUserGroupID(int userGroupID)
        {
            using (var db = new ClinicDB())
            {
                var query = from p in db.Permission
                            join pd in db.PermissionDetail on p.PermissionID equals pd.PermissionID
                            join ug in db.UserGroup on pd.UserGroupID equals ug.UserGroupID
                            where ug.UserGroupID == userGroupID
                            select new {p.PermissionID, p.PermissionName, ug.UserGroupID };

                return query.ToDataTable();
            }
        }
    }
}

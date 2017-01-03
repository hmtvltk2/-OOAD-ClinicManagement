using ClinicManager.Common;
using System.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using ClinicManager.DataModel;

namespace ClinicManager.DataAccess
{
    public class PermissionDetailAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.PermissionDetail orderby d.PermissionDetailID descending select d;
                    var last = query.First();
                    result = last.PermissionDetailID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            PermissionDetail model;
            using (var db = new ClinicDB())
            {
                model = db.PermissionDetail.Find(id);

                if (model == null)
                {
                    return false;
                }
            }

            return base.Delete(model);
        }

        public bool DeleteByUserGroupID(int userGroupID)
        {
            IQueryable<PermissionDetail> query;
            List<PermissionDetail> permissionDetails;
            using (var db = new ClinicDB())
            {
                query = from pd in db.PermissionDetail
                        where pd.UserGroupID == userGroupID
                        select pd;
                permissionDetails = query.ToList();
            }

            bool result = true;
            foreach (var item in permissionDetails)
            {
                result = result && base.Delete(item);
            }

            return result;
        }

        public DataTable GetAll()
        {
            using (var db = new ClinicDB())
            {
                return db.PermissionDetail.ToDataTable();
            }
        }
    }
}

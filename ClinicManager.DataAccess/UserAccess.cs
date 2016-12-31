using ClinicManager.DataModel;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System;

namespace ClinicManager.DataModel
{
    public class UserAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
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

        public DataTable GetAllDoctorWithQueue()
        {
            using (var db = new ClinicDB())
            {
                var doctors = from u in db.User
                        join ug in db.UserGroup on u.UserGroupID equals ug.UserGroupID
                        join q in db.Queue on u.UserID equals q.DoctorID
                        where ug.UserGroupName == "Doctor" && q.ExamineDate == DateTime.Today
                        select new { u.UserID, u.FullName, q.QueueID } into temp
                        group temp by new { temp.UserID, temp.FullName } into gr
                        select new
                        {
                            UserID = gr.Key.UserID,
                            FullName = gr.Key.FullName,
                            Queue = gr.Count(h => h.QueueID > 0)
                        };


                //var doctors = db.Database.SqlQuery<IEnumerable<string>>(query);
                return doctors.ToDataTable();
            }
        }

        public DataTable GetAllDoctor()
        {
            using (var db = new ClinicDB())
            {
                var query = from user in db.User
                            join userGroup in db.UserGroup on user.UserGroupID equals userGroup.UserGroupID
                            where userGroup.UserGroupName == "Doctor"
                            select user;
                return query.ToDataTable();
            }
        }
    }
}

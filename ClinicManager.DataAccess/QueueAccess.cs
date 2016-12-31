using ClinicManager.DataModel;
using System.Data;
using System.Linq;
using System;

namespace ClinicManager.DataModel
{
    public class QueueAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.Queue orderby d.QueueID descending select d;
                    var last = query.First();
                    result = last.QueueID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            Queue model;
            using (var db = new ClinicDB())
            {
                model = db.Queue.Find(id);

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
                return db.Queue.ToDataTable();
            }
        }

        public DataTable GetByDate(DateTime today)
        {
            using (var db = new ClinicDB())
            {
                var result = from q in db.Queue
                             join u in db.User on q.DoctorID equals u.UserID
                             join ug in db.UserGroup on u.UserGroupID equals ug.UserGroupID
                             join patient in db.Patient on q.PatientID equals patient.PatientID
                             where q.ExamineDate == today orderby q.QueueID descending
                             select new { q.ExamineReason, patient.FullName, patient.Gender,
                                 patient.DateOfBirth, patient.Address, patient.Phone,
                                 DoctorName = u.FullName};
                return result.ToDataTable();
            }
        }
    }
}

using System.Data;
using System.Linq;
using System;
using ClinicManager.Common;
using ClinicManager.DataModel;
using ClinicManager.DataAccess;

namespace ClinicManager.DataAccess
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

        public DataTable GetQueueByDoctorId(int id)
        {
            using (var db = new ClinicDB())
            {
                var query = from q in db.Queue
                            join p in db.Patient on q.PatientID equals p.PatientID
                            join u in db.User on q.DoctorID equals u.UserID
                            where q.DoctorID == id && q.Status == "A" && q.ExamineDate == DateTime.Today
                            select new {q.QueueID, q.PatientID, q.ExamineReason, p.FullName,
                            p.Gender, p.DateOfBirth, DoctorName = u.FullName};

                return query.ToDataTable();
            }
        }

        public DataTable GetAll()
        {
            using (var db = new ClinicDB())
            {
                return db.Queue.ToDataTable();
            }
        }

        public Queue GetQueueById(int queueID)
        {
            using (var db = new ClinicDB())
            {
                return db.Queue.Find(queueID);
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

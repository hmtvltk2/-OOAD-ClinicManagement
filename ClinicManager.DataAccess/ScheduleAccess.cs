using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System;
using System.Data;
using System.Linq;

namespace ClinicManager.DataAccess
{
    public class ScheduleAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.Schedule orderby d.PatientScheduleID descending select d;
                    var last = query.First();
                    result = last.PatientScheduleID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            Schedule model;
            using (var db = new ClinicDB())
            {
                model = db.Schedule.Find(id);

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

                return db.Schedule.ToDataTable();

            }
        }
        public DataTable GetByCondition(DateTime dateForm, DateTime dateTo, int dotorID)
        {
            using (var db = new ClinicDB())
            {
                var schedule = from sch in db.Schedule
                               where sch.ScheduleDate >= dateForm && sch.ScheduleDate <= dateTo && sch.DoctorID == dotorID
                               select sch;
                return schedule.ToDataTable();
            }

        }
        public DataTable GetByCondition(DateTime dateForm, DateTime dateTo)
        {
            using (var db = new ClinicDB())
            {
                var schedule = from sch in db.Schedule
                               where sch.ScheduleDate >= dateForm && sch.ScheduleDate<= dateTo
                               select sch;
                return schedule.ToDataTable();
            }

        }
    }
}

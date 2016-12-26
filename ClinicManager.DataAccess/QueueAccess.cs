using ClinicManager.DataModel;
using System.Data;
using System.Linq;
using System;

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
                var result = from d in db.Queue where d.ExamineDate == today orderby d.QueueID descending select d;
                return result.ToDataTable();
            }
        }
    }
}

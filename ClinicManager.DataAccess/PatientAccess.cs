using ClinicManager.DataModel;
using System.Data;
using System.Linq;
using System;

namespace ClinicManager.DataAccess
{
    public class PatientAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.Patient orderby d.PatientID descending select d;
                    var last = query.First();
                    result = last.PatientID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            Patient model;
            using (var db = new ClinicDB())
            {
                model = db.Patient.Find(id);

                if (model == null)
                {
                    return false;
                }
            }

            return base.Delete(model);
        }

        // Get all orderby CreateDate desc
        public DataTable GetAll()
        {
            using (var db = new ClinicDB())
            {
                var result = from d in db.Patient orderby d.CreateDate descending select d;
                return result.ToDataTable();
            }
        }

        public DataTable Search(string patientName, DateTime dateOfBirth, string gender)
        {
            throw new NotImplementedException();
            
        }
    }
}

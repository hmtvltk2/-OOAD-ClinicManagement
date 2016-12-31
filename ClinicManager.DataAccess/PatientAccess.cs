using ClinicManager.DataModel;
using System.Data;
using System.Linq;
using System;

namespace ClinicManager.DataAccess
{
    public class PatientAccess : BaseDataAcess
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
                var result = from d in db.Patient orderby d.PatientID descending select d;
                return result.ToDataTable();
            }
        }
        
        public DataTable GetById(int id)
        {
            using (var db = new ClinicDB())
            {
                var patient = from p in db.Patient
                              where p.PatientID == id
                              select p;
                return patient.ToDataTable();
            }
        }
        public DataTable GetByCondition(string name, DateTime dateOfBirth, string gender)
        {
            var result = new DataTable();
            using (var db = new ClinicDB())
            {

                if (name == "" && dateOfBirth != null && gender == "Tất cả")

                {
                    var patient = from p in db.Patient
                                  where p.DateOfBirth  ==  dateOfBirth 
                                  select p;
                    result = patient.ToDataTable();
                }
                if (name != "" && dateOfBirth != null && gender == "Tất cả")
                {
                    var patient = from p in db.Patient
                                  where p.DateOfBirth == dateOfBirth && p.FullName.Contains(name)
                                  select p;
                    result = patient.ToDataTable();
                }
                if (name == "" && dateOfBirth != null && gender != "Tất cả")
                {
                    var patient = from p in db.Patient
                                  where p.DateOfBirth == dateOfBirth &&  p.Gender ==gender
                                  select p;
                    result = patient.ToDataTable();
                }
                if (name != "" && dateOfBirth != null && gender != "Tất cả")
                {
                    var patient = from p in db.Patient
                                  where p.DateOfBirth == dateOfBirth && p.Gender == gender && p.FullName.Contains(name)
                                  select p;
                    result = patient.ToDataTable();
                }
                if (name =="" && dateOfBirth == DateTime.Today && gender != "Tất cả")
                {
                    var patient = from p in db.Patient
                                  where  p.Gender == gender   
                                  select p;
                    result = patient.ToDataTable();
                }
                if (name != "" && dateOfBirth == DateTime.Today && gender == "Tất cả")
                {
                    var patient = from p in db.Patient
                                  where p.FullName.Contains(name)
                                  select p;
                    result = patient.ToDataTable();
                }
                if (name != "" && dateOfBirth == DateTime.Today && gender != "Tất cả")
                {
                    var patient = from p in db.Patient
                                  where p.FullName.Contains(name) && p.Gender == gender
                                  select p;
                    result = patient.ToDataTable();
                }

            }
            return result;

              
            }
        }

        public DataTable Search(string patientName, object dateOfBirth, string gender)
        {
            using (var db = new ClinicDB())
            {
                if (dateOfBirth == null)
                {
                    var result = from d in db.Patient
                                 where d.FullName.Contains(patientName) && d.Gender.Contains(gender)
                                 select d;
                    return result.ToDataTable();
                }
                else
                {
                    var result = from d in db.Patient
                                 where d.FullName.Contains(patientName) && d.Gender.Contains(gender)
                                        && d.DateOfBirth == (DateTime)dateOfBirth
                                 select d;
                    return result.ToDataTable();
                }
            }
            

        }
    }
}

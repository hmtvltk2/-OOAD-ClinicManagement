using System.Data;
using System.Linq;
using System;
using ClinicManager.Common;
using ClinicManager.DataModel;

namespace ClinicManager.DataAccess
{
    public class MedicalRecordAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.MedicalRecord orderby d.MedicalRecordID descending select d;
                    var last = query.First();
                    result = last.MedicalRecordID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            MedicalRecord model;
            using (var db = new ClinicDB())
            {
                model = db.MedicalRecord.Find(id);

                if (model == null)
                {
                    return false;
                }
            }

            return base.Delete(model);
        }

        public DataTable GetByDoctorId(int id)
        {
            using (var db = new ClinicDB())
            {
                var query = from mr in db.MedicalRecord
                            join p in db.Patient on mr.PatientID equals p.PatientID
                            join d in db.User on mr.DoctorID equals d.UserID
                            where mr.DoctorID == id && mr.ExamineDate == DateTime.Today
                            select new {p.FullName, p.Gender, p.DateOfBirth, p.Address,
                            p.PatientID, mr.Diagnostic, DoctorName = d.FullName};

                return query.ToDataTable();
            }
        }

        public MedicalRecord GetByPatientID(int patientID)
        {
            using (var db = new ClinicDB())
            {
                var query = from mr in db.MedicalRecord
                            where mr.PatientID == patientID
                            select mr;
                if(query.Count() > 0)
                {
                    return query.First();
                }
                else
                {
                    return null;
                }
            }
        }

        public DataTable GetAll()
        {
            using (var db = new ClinicDB())
            {
                return db.MedicalRecord.ToDataTable();
            }
        }
    }
}

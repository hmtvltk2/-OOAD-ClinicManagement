using ClinicManager.Common;
using ClinicManager.DataModel;
using System.Data;
using System.Linq;
using System;

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
                    var query = from mr in db.MedicalRecord orderby mr.MedicalRecordID descending select mr;
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

        public DataTable GetAll()
        {
            using (var db = new ClinicDB())
            {
                return db.MedicalRecord.ToDataTable();

            }
        }

        public DataTable GetById(int Id)
        {
            using (var db = new ClinicDB())
            {
                var medicalRecord = from m in db.MedicalRecord
                                    where m.PatientID == Id
                                    select m;
                return medicalRecord.ToDataTable();
            }

        }
        public DataTable GetByStatus(string status)
        {
            using (var db = new ClinicDB())
            {
                var notPaymentTB = from notpm in db.MedicalRecord
                                   join patient in db.Patient on notpm.PatientID equals patient.PatientID
                                   where notpm.Status == status
                                   select new
                                   {
                                       notpm.MedicalRecordID,
                                       notpm.PatientID,
                                       notpm.DoctorID,
                                       notpm.ExamineReason,
                                       notpm.Diagnostic,
                                       notpm.Note,
                                       notpm.ExamineDate,
                                       notpm.ReExamineDate,
                                       notpm.Status,
                                       patient.FullName,
                                       patient.Gender,
                                       patient.DateOfBirth
                                   };
                return notPaymentTB.ToDataTable();
            }
        }

        public MedicalRecord GetByMedicalRecordID(int medicalRecordID)
        {
            using (var db =new ClinicDB())
            {
                return db.MedicalRecord.Find(medicalRecordID);          
            }
        }

        public DataTable GetByDoctorId(int id)
        {
            using (var db = new ClinicDB())
            {
                var query = from mr in db.MedicalRecord
                            join p in db.Patient on mr.PatientID equals p.PatientID
                            join d in db.User on mr.DoctorID equals d.UserID
                            where mr.DoctorID == id && mr.ExamineDate == DateTime.Today
                            && mr.Status == "NotPayment"
                            select new
                            {
                                p.FullName,
                                p.Gender,
                                p.DateOfBirth,
                                p.Address,
                                p.PatientID,
                                mr.Diagnostic,
                                DoctorName = d.FullName
                            };

                return query.ToDataTable();
            }
        }

        public MedicalRecord GetByPatientID(int patientID)
        {
            using (var db = new ClinicDB())
            {
                var query = from mr in db.MedicalRecord
                            where mr.PatientID == patientID && mr.ExamineDate == DateTime.Today
                            select mr;
                if (query.Count() > 0)
                {
                    return query.First();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}

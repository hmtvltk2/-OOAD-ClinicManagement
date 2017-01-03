using ClinicManager.Common;
using ClinicManager.DataModel;
using System.Data;
using System.Linq;
using System;

namespace ClinicManager.DataAccess
{
    public class PrescriptionAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.Prescription orderby d.PrescriptionID descending select d;
                    var last = query.First();
                    result = last.PrescriptionID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            Prescription model;
            using (var db = new ClinicDB())
            {
                model = db.Prescription.Find(id);

                if (model == null)
                {
                    return false;
                }
            }

            return base.Delete(model);
        }

        public DataRow GetMedicalRecordInfo(int prescriptionID)
        {
            using (var db = new ClinicDB())
            {
                var query = from pr in db.Prescription
                            join mr in db.MedicalRecord on pr.MedicalRecordID equals mr.MedicalRecordID
                            join p in db.Patient on mr.PatientID equals p.PatientID
                            join d in db.User on mr.DoctorID equals d.UserID
                            where pr.PrescriptionID == prescriptionID
                            select new
                            {
                                PatientName = p.FullName,
                                DoctorName = d.FullName,
                                mr.ExamineDate,
                                mr.DoctorID,
                                mr.PatientID,
                                mr.Diagnostic,
                                mr.Note
                            };
                var table = query.ToDataTable();

                return table.Rows.Count > 0 ? table.Rows[0] : null;
            }
        }

        public Prescription GetByPrescriptionID(int prescriptionID)
        {
            using (var db = new ClinicDB())
            {
                return db.Prescription.Find(prescriptionID);
            }
        }

        public Prescription GetByMedicalRecordID(int medicalRecordID)
        {
            using (var db = new ClinicDB())
            {
                var query = from pr in db.Prescription
                            where pr.MedicalRecordID == medicalRecordID
                            select pr;
                return query.First();
            }
        }

        public DataTable GetAll()
        {
            using (var db = new ClinicDB())
            {
                return db.Prescription.ToDataTable();
            }
        }
        public decimal GetMedicineFee(int medicalReordID)
        {
            using (var db = new ClinicDB())
            {
                var fees = from prescription in db.Prescription
                           where prescription.MedicalRecordID == medicalReordID
                           select prescription;
                var totalFee = fees.Sum(f => f.Amount);
                return totalFee;

            }
        }
    }
}

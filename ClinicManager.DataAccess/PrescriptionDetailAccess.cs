using ClinicManager.Common;
using ClinicManager.DataModel;
using System.Data;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ClinicManager.DataAccess
{
    public class PrescriptionDetailAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            return base.Insert(obj);
        }

        public bool Delete(int id)
        {
            PrescriptionDetail model;
            using (var db = new ClinicDB())
            {
                model = db.PrescriptionDetail.Find(id);

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
                return db.PrescriptionDetail.ToDataTable();
            }
        }

        public DataTable GetByPrescriptionID(int id)
        {
            using (var db = new ClinicDB())
            {
                var prescription = from pret in db.PrescriptionDetail
                                   join m in db.Medicine on pret.MedicineID equals m.MedicineID
                                   join Service in db.Service on pret.MedicineID equals Service.ServiceID
                                   where pret.PrescriptionID == id
                                   select new { pret.MedicineID, m.MedicineName, pret.Quantity, Service.ServiceName, pret.HowToUse };
                return prescription.ToDataTable(); 

            }
        }

        public DataTable GetByMedicalRecordID(int medicalRecordID)
        {
            using (var db = new ClinicDB())
            {
                var prescription = from pret in db.PrescriptionDetail
                                   join pr in db.Prescription on pret.PrescriptionID equals pr.PrescriptionID
                                   join mr in db.MedicalRecord on pr.MedicalRecordID equals mr.MedicalRecordID
                                   join m in db.Medicine on pret.MedicineID equals m.MedicineID
                                   join Service in db.Service on pret.MedicineID equals Service.ServiceID
                                   where pr.MedicalRecordID == medicalRecordID
                                   select new { pret.MedicineID, m.MedicineName, pret.Quantity, Service.ServiceName, pret.HowToUse };
                return prescription.ToDataTable();

            }
        }

        public DataTable GetDetailByPrescriptionID(int prescriptionID)
        {
            using (var db = new ClinicDB())
            {
                var query = from preD in db.PrescriptionDetail
                            join m in db.Medicine on preD.MedicineID equals m.MedicineID
                            join u in db.Unit on m.UnitID equals u.UnitID
                            where preD.PrescriptionID == prescriptionID
                            select new
                            {
                                preD.MedicineID,
                                preD.Quantity,
                                preD.HowToUse,
                                preD.MedicineFee,
                                u.UnitName,
                            };
                return query.ToDataTable();
            }
        }

        public bool DeteleByPrescriptionID(int prescriptionID)
        {
            IQueryable<PrescriptionDetail> query;
            List<PrescriptionDetail> preDetailList;
            using (var db = new ClinicDB())
            {
                query = from pd in db.PrescriptionDetail
                            where pd.PrescriptionID == prescriptionID
                            select pd;

                preDetailList = query.ToList();
            }

            bool result = true;
            foreach (var item in preDetailList)
            {
                result = result && base.Delete(item);
            }

            return result;
        }
    }
}

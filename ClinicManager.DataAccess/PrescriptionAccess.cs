using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System.Data;
using System.Linq;

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

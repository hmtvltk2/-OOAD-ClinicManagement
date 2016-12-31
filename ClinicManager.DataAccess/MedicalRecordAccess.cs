using ClinicManager.DataModel;
using System.Data;
using System.Linq;

namespace ClinicManager.DataAccess
{
    public class MedicalRecordAccess : BaseDataAcess
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
    }
}

using ClinicManager.DataModel;
using System.Data;
using System.Linq;

namespace ClinicManager.DataAccess
{
    public class MedicineAccess : BaseDataAcess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.Medicine orderby d.MedicineID descending select d;
                    var last = query.First();
                    result = last.MedicineID;
                }
            }

            return result;
        }

        public bool Delete(int id)
        {
            Medicine model;
            using (var db = new ClinicDB())
            {
                model = db.Medicine.Find(id);

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

                //var m = from medicine in db.Medicine
                //        join type in db.MedicineType on medicine.MedicineTypeID equals type.MedicineTypeID
                //        join way in db.WayToUse on medicine.MedicineID equals way.WayToUseID
                //        join pharmacy in db.PharmacyType on medicine.PharmacyTypeID equals pharmacy.PharmacyTypeID
                //        join unit in db.Unit on medicine.MedicineTypeID equals unit.UnitID

                //        select new { medicine.MedicineID, medicine.MedicineName, type.MedicineTypeName, way.WayToUseName, pharmacy.PharmacyTypeName,unit.UnitName };

                return db.Medicine.ToDataTable();
             //   return m.ToDataTable();
            }
        }
        public DataTable GetByCondition(string medicineName,int  medicineTypeID)
        {
            using (var db = new ClinicDB())
            {

                var medicine = from b in db.Medicine
                            where (b.MedicineName.Contains(medicineName) && b.MedicineTypeID == medicineTypeID)
                               //b.MedicineName.Contains(medicineName) is query same LIKE query
                            select b;
                return medicine.ToDataTable();
            }
        }
        // Chose all Tpye ( lookup null)
        public DataTable GetByCondition(string medicineName)
        {
            using (var db = new ClinicDB())
            {

                var medicine = from b in db.Medicine
                               where (b.MedicineName.Contains(medicineName))
                               select b;

                return medicine.ToDataTable();
            }
        }
        // Chose all medicin with type
        public DataTable GetByCondition(int medicineTypeID)
        {
            using (var db = new ClinicDB())
            {

                var medicine = from b in db.Medicine
                               where (b.MedicineTypeID == medicineTypeID)
                               select b;

                return medicine.ToDataTable();
            }
        }

    }
}

using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System.Data;
using System.Linq;

namespace ClinicManager.DataAccess
{
    public class PrescriptionDetailAccess : BaseDataAccess
    {
       

       
         
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
    }
}

using ClinicManager.Common;
using System.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using ClinicManager.DataModel;

namespace ClinicManager.DataAccess
{
    public class ServiceDetailAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            return base.Insert(obj);
        }

        public bool Delete(int id)
        {
            ServiceDetail model;
            using (var db = new ClinicDB())
            {
                model = db.ServiceDetail.Find(id);

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
                return db.ServiceDetail.ToDataTable();
            }
        }

        public bool DeleteByMedicalRecordID(int medicalRecordID)
        {
            IQueryable<ServiceDetail> query;
            List<ServiceDetail> serviceDetails;
            using (var db = new ClinicDB())
            {
                query = from sd in db.ServiceDetail
                            where sd.MedicalRecordID == medicalRecordID
                            select sd;
                serviceDetails = query.ToList();
            }

            bool result = true;

            foreach (var item in serviceDetails)
            {
                result = result && base.Delete(item);
            }

            return result;
        }

        public DataTable GetByMedicalRecordID(int medicalRecordID)
        {
            using (var db = new ClinicDB())
            {
                var query = from sd in db.ServiceDetail
                        where sd.MedicalRecordID == medicalRecordID
                        select sd;

                return query.ToDataTable();
            }
        }
    }
}

using ClinicManager.DataAccess;
using ClinicManager.DataModel;
using System.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using ClinicManager.DataModel;
using ClinicManager.Common;

namespace ClinicManager.DataAccess
{
    public class ServiceDetailAccess : BaseDataAccess
    {
        public override int Insert(object obj)
        {
            int result = base.Insert(obj);
            if (result > 0)
            {
                using (var db = new ClinicDB())
                {
                    var query = from d in db.ServiceDetail orderby d.ServiceID descending select d;
                    var last = query.First();
                    result = last.ServiceID;
                }
            }

            return result;
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

		public DataTable GetbyId(int medicalRecordID)
        {
            using (var db = new ClinicDB())
            {
                var serviceDt = from svd in db.ServiceDetail
                                join service in db.Service on svd.ServiceID equals service.ServiceID
                                where svd.MedicalRecordID== medicalRecordID
                                select new { svd.ServiceID, service.ServiceName, svd.ServiceFee };
                return serviceDt.ToDataTable();
            }
        }

        public decimal GetTotalFee(int medicalReordID)
        {
            using (var db = new ClinicDB())
            {
                var fees = from svd in db.ServiceDetail
                           where svd.MedicalRecordID == medicalReordID
                           select svd;
                var fee = fees.Sum(f => f.ServiceFee );
                return fee;

            }
        }
    }
}

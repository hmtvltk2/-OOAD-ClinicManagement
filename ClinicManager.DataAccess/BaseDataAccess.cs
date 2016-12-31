using System;

namespace ClinicManager.DataModel
{
    public class BaseDataAccess
    {
        public virtual int Insert(object obj)
        {
            try
            {
                using (var db = new ClinicDB())
                {
                    db.Entry(obj).State = System.Data.Entity.EntityState.Added;
                    return db.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public virtual bool Update(object obj)
        {
            try
            {
                using (var db = new ClinicDB())
                {
                    db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public virtual bool Delete(object obj)
        {
            try
            {
                using (var db = new ClinicDB())
                {
                    db.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //public virtual string Validate(object obj, string property)
        //{
        //    using (var db = new ClinicDB())
        //    {
        //        var validationErrors = db.Entry(obj).GetValidationResult().ValidationErrors;
        //        var errors = validationErrors.Where(e => e.PropertyName == property);

        //        return errors.Count() > 0 ? errors.First().ErrorMessage : "";
        //    }
        //}
    }
}

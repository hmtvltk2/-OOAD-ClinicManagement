using System;
using ClinicManager.DataAccess;
using System.Data;

namespace ClinicManager.DataBusiness
{
    public class QueueBusiness
    {
        #region Contructor
        private QueueAccess dataAccess;

        public QueueBusiness()
        {
            dataAccess = new QueueAccess();
        }

        #endregion

        public int Insert(object data)
        {
            return dataAccess.Insert(data);
        }

        public bool Update(object data)
        {
            return dataAccess.Update(data);
        }

        public bool Delete(int id)
        {
            return dataAccess.Delete(id);
        }

        public System.Data.DataTable GetAll()
        {
            return dataAccess.GetAll();
        }

        public DataTable GetByDate(DateTime today)
        {
            return dataAccess.GetByDate(today);
        }
    }
}

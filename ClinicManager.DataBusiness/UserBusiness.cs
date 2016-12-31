using System;
using ClinicManager.DataAccess;
using System.Data;

namespace ClinicManager.DataBusiness
{
    public class UserBusiness
    {
        #region Contructor
        private UserAccess dataAccess;

        public UserBusiness()
        {
            dataAccess = new UserAccess();
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

 		public System.Data.DataTable GetByUserGroup(int userGroupID)
        {
            return dataAccess.GetByUserGroup(userGroupID);
        }
        public string Validate(object data, string propertyName)
        {
            string result = "";


            return result;
        }

        public DataTable GetAllDoctor()
        {
            return dataAccess.GetAllDoctor();
        }

        public DataTable GetAllDoctorWithQueue()
        {
            return dataAccess.GetAllDoctorWithQueue();
        }
    }
}

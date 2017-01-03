using System;
using ClinicManager.DataAccess;
using ClinicManager.DataModel;

namespace ClinicManager.DataBusiness
{
    public class UserGroupBusiness
    {
        #region Contructor
        private UserGroupAccess dataAccess;

        public UserGroupBusiness()
        {
            dataAccess = new UserGroupAccess();
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

        public UserGroup GetByUserGroupID(int userGroupID)
        {
            return dataAccess.GetByUserGroupID(userGroupID);
        }

        public string Validate(object data, string propertyName)
        {
            string result = "";
            return result;
        }
    }
}

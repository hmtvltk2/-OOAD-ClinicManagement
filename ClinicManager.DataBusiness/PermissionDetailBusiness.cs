using System;
using ClinicManager.DataAccess;

namespace ClinicManager.DataBusiness
{
    public class PermissionDetailBusiness
    {
        #region Contructor
        private PermissionDetailAccess dataAccess;

        public PermissionDetailBusiness()
        {
            dataAccess = new PermissionDetailAccess();
        }

        #endregion

        public bool Insert(object data)
        {
            return dataAccess.Insert(data) > 0;
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

        public string Validate(object data, string propertyName)
        {
            string result = "";

          

            return result;
        }

        public bool DeleteByUserGroupID(int userGroupID)
        {
            return dataAccess.DeleteByUserGroupID(userGroupID);
        }
    }
}

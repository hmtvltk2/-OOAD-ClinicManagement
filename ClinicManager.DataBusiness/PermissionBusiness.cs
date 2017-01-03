using System;
using ClinicManager.DataAccess;
using System.Collections.Generic;
using System.Data;

namespace ClinicManager.DataBusiness
{
    public class PermissionBusiness
    {
        #region Contructor
        private PermissionAccess dataAccess;

        public PermissionBusiness()
        {
            dataAccess = new PermissionAccess();
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

        public string Validate(object data, string propertyName)
        {
            string result = "";

     
            return result;
        }

        public List<string> GetPermissionByUserGroupID(int userGroupID)
        {
            var permissions = dataAccess.GetPermissionByUserGroupID(userGroupID);
            var permList = new List<string>();
            foreach (DataRow item in permissions.Rows)
            {
                permList.Add((string)item["PermissionName"]);
            }

            return permList;
        }

        public DataTable GetByUserGroupId(int userGroupId)
        {
            return dataAccess.GetPermissionByUserGroupID(userGroupId);
        }
    }
}

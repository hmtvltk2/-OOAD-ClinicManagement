using ClinicManager.Common;
using System.Data;
using ClinicManager.DataAccess;
using ClinicManager.DataModel;

namespace ClinicManager.DataBusiness
{
    public class UserBusiness
    {
        public static User User { get; set; }
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

        public LoginStatus GetLoginUser(string username, string password)
        {
            User user = dataAccess.GetByUserName(username);
            if (user == null)
            {
                return LoginStatus.NoAccount;
            }

            if (Security.Md5Hash(password) != user.Password)
            {
                return LoginStatus.WrongPassword;
            }
            User = user;
            return LoginStatus.Success;
        }

        public DataTable GetAllWithUserGroupName()
        {
            return dataAccess.GetAllWithUserGroupName();
        }
    }

    public enum LoginStatus
    {
        LoginFail,
        NoAccount,
        WrongPassword,
        Success
    }
}

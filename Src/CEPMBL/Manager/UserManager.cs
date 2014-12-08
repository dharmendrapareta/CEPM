using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CEPMBL.DataAccess;

namespace CEPMBL.Manager
{
    public class UserManager: BaseManager
    {
        private UserDataAccess _dataAccess;
        public UserManager()
        {
            _dataAccess = new UserDataAccess();
        }

        public string GetUserLoginId(string userName, string password)
        {
            return _dataAccess.GetUserLoginId(userName,password);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEPMBL.DataAccess
{
    public class UserDataAccess : BaseDataAccess
    {
        public UserDataAccess()
        {
            
        }

        public string GetUserLoginId(string userName, string password )
        {
            var lstUsers = DataContext.Users.Where(l => l.UserName == userName && l.Password == password).ToList();
            if (lstUsers.Any())
                return lstUsers.Select(l => l.Id).FirstOrDefault().ToString();
            else
                return null;
        }
    }
}

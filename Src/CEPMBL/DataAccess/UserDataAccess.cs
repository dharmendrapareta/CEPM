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
            return DataContext.Users.Where(l => l.UserName == userName && l.Password == password).Select(l => l.Id).FirstOrDefault().ToString();
        }
    }
}

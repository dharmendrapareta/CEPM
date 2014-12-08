using System;
using System.Collections.Generic;
using System.Linq;
using CEPMDL;

namespace CEPMBL.DataAccess
{
    public class BaseDataAccess
    {
        public CEPMEF DataContext;
        public BaseDataAccess()
        {
            DataContext = new CEPMEF();
        }

        public void Commit()
        {
            DataContext.SaveChanges();
        }
    }
}
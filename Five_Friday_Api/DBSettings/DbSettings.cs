using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Five_Friday_Api.DBSettings
{
    public class DbSettings
    {
        public Database GetDatabase(string connectionStringName)
        {
            return new Database(connectionStringName);
        }
    }
}
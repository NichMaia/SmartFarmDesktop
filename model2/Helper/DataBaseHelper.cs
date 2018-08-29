using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smartfarmmodel.Helper
{
    public class DataBaseHelper
    {
        public static SmartFarmEntities1 getDataContext()
        {
            
            SmartFarmEntities1 Result = new SmartFarmEntities1();
            Result.Configuration.ProxyCreationEnabled = false;
            return Result;

        }
    }
}

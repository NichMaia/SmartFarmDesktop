using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smartfarmmodel
{
    public partial class Cargo
    {
        public static void incluir(tb_Cargo oCargo)
        {
            using (SmartFarmEntities oDB = Helper.DataBaseHelper.getDataContext())
            {
                oDB.tb_Cargo.Add(oCargo);
                oDB.SaveChanges();
            }


        }
    }
}
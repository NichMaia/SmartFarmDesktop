using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace smartfarmmodel
{
    public partial class Usuario
    {
        public static void incluir(tb_Usuario oUsuario)
        {
            using (SmartFarmEntities1 oDB = Helper.DataBaseHelper.getDataContext())
            {
                oDB.tb_Usuario.Add(oUsuario);
                oDB.SaveChanges();
            }
        }
    }
}

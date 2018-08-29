using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smartfarmmodel
{
    public partial class Funcionario
    {
        public static void incluir(tb_funcionario oFuncionario)
        {
            using (SmartFarmEntities1 oDB = Helper.DataBaseHelper.getDataContext())
            {
                oDB.tb_funcionario.Add(oFuncionario);
                oDB.SaveChanges();
            }
        }
    }
}

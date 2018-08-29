using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartfarmmodel
{
    public partial class Raca
    {
        public static void incluir(tb_Raca aRaca)
        {
            using (SmartFarmEntities1 oDB = Helper.DataBaseHelper.getDataContext())
            {
                oDB.tb_Raca.Add(aRaca);
                oDB.SaveChanges();
            }
        }
    }
}

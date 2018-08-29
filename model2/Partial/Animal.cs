using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartfarmmodel
{
    public partial class Animal
    {
        public static void incluir(tb_Animal oAnimal)
        {
            using (SmartFarmEntities1 oDb = Helper.DataBaseHelper.getDataContext())
            {
                oDb.tb_Animal.Add(oAnimal);
                oDb.SaveChanges();
            }
        }
    }
}

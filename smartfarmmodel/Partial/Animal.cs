using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace smartfarmmodel
{
    public partial class Animal
    {
        public static void incluir(tb_Animal oNovoAnimal)
        {
            using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
            {
                oDb.tb_Animal.Add(oNovoAnimal);
                oDb.SaveChanges();
            }
        }

        public static List<tb_Animal> getAnimal()
        {
            using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
            {
                List<tb_Animal> List = (from l in oDb.tb_Animal select l).ToList<tb_Animal>();
                return List;
            }
        }

        public static void Excluir(tb_Animal oNovoanimal)
        {
         using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
         {
            oDb.tb_Animal.Attach(oNovoanimal); // Anexa o cliente que eu quero com base nos atributos
             oDb.tb_Animal.Remove(oNovoanimal);
             oDb.SaveChanges();
          }
          }
        public static void alterar(tb_Animal oNovoanimal)
        {
            using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
            {
                oDb.Entry(oNovoanimal).State = System.Data.Entity.EntityState.Modified;
                oDb.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace smartfarmmodel
{
    public partial class Vacina

    {

        public static void incluir(Vacinação anovavacina)
        {
            using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
            {
                oDb.Vacinação.Add(anovavacina);
                oDb.SaveChanges();
            }
        }

        public static List<Vacinação> getvacinas()
        {
            using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
            {
                List<Vacinação> List = (from l in oDb.Vacinação select l).ToList<Vacinação>();
                return List;
            }
        }
        public static void Excluir(Vacinação anovavacinas)
        {
            using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
            {
                oDb.Vacinação.Attach(anovavacinas); // Anexa o cliente que eu quero com base nos atributos
                oDb.Vacinação.Remove(anovavacinas);
                oDb.SaveChanges();
            }
        }
    }
}

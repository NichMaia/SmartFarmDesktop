using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace smartfarmmodel
{
    public partial class Funcionario


    {
        public static void incluir(tb_funcionario oNovofuncionario)
        {
            using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
            {
                oDb.tb_funcionario.Add(oNovofuncionario);
                oDb.SaveChanges();
            }
        }

        public static List<tb_funcionario> getFuncionarios()
        {
            using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
            {
                List<tb_funcionario> List = (from l in oDb.tb_funcionario select l).ToList<tb_funcionario>();
                return List;
            }
        }
        public static void Excluir(tb_funcionario oNovofuncionario)
        {
            using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
            {
                oDb.tb_funcionario.Attach(oNovofuncionario); // Anexa o cliente que eu quero com base nos atributos
                oDb.tb_funcionario.Remove(oNovofuncionario);
                oDb.SaveChanges();
            }
        }
        public static void alterar(tb_funcionario oNovofuncionario)
        {
            using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
            {
                try
                {
                    oDb.tb_funcionario.Attach(oNovofuncionario);
                    oDb.Entry(oNovofuncionario).State = System.Data.Entity.EntityState.Modified;
                    oDb.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace smartfarmmodel
{
    public partial class  cadastroprodução
    {
       
        
            public static void incluir(Tb_Produção anovaprodução)
            {
                using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
                {
                    oDb.Tb_Produção.Add(anovaprodução);
                    oDb.SaveChanges();
                }
            }

            public static List<Tb_Produção> getProdução()
            {
                using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
                {
                    List<Tb_Produção> List = (from l in oDb.Tb_Produção select l).ToList<Tb_Produção>();
                return List;
                }
            }

            public static void Excluir(Tb_Produção  aNovaprodução )
            {
                using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
                {
                    oDb.Tb_Produção.Attach(aNovaprodução); // Anexa o cliente que eu quero com base nos atributos
                    oDb.Tb_Produção.Remove(aNovaprodução);
                    oDb.SaveChanges();
                }
            }
            public static void alterar(Tb_Produção aNovaprodução)
            {
                using (SmartFarmEntities oDb = Helper.DataBaseHelper.getDataContext())
                {

                oDb.Tb_Produção.Attach(aNovaprodução);
                oDb.Entry(aNovaprodução).State = System.Data.Entity.EntityState.Modified;
                    oDb.SaveChanges();
                }
            }
        }
    }




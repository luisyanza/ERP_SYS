using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Data.General
{
    public class tb_Catalogo_Data
    {

        public List<tb_Catalogo_Info> Get_List_Catalogo()
        {
            List<tb_Catalogo_Info> ListInfo = new List<tb_Catalogo_Info>();
            try
            {
                Entities_General OBase = new Entities_General();

                IQueryable<tb_catalogo>  selectq = from cat in OBase.tb_catalogo
                              where cat.estado == true
                              select cat;

                foreach ( tb_catalogo item in selectq)
                {
                    ListInfo.Add(new tb_Catalogo_Info(item.IdCatalogo, item.nom_catalogo, item.estado, item.IdCatalogo_tipo));
                }

            }
            catch (Exception)
            {
                return new List<tb_Catalogo_Info>();
            }
            return ListInfo;
        }

        public List<tb_Catalogo_Info> Get_List_Catalogo(string IdCatalogo_tipo)
        {
            List<tb_Catalogo_Info> ListInfo = new List<tb_Catalogo_Info>();
            try
            {
                Entities_General OBase = new Entities_General();

                var selectq = from cat in OBase.tb_catalogo
                              join tip in OBase.tb_catalogo_tipo
                              on cat.IdCatalogo_tipo equals tip.IdCatalogo_tipo
                              select new
                              {
                                  IdCat = cat.IdCatalogo,
                                  IdTip = cat.IdCatalogo_tipo,
                                  NomCatTip = tip.nom_catalogo_tipo,
                                  NomCat = cat.nom_catalogo,
                                  EstCat = cat.estado
                              };

                foreach (var item in selectq)
                {
                    if (item.IdTip == IdCatalogo_tipo)
                    {
                        ListInfo.Add(new tb_Catalogo_Info(item.IdCat, item.NomCat, item.EstCat, item.IdTip));
                    }
                }

            }
            catch (Exception)
            {
                return new List<tb_Catalogo_Info>();
            }
            return ListInfo;
        }

        public Boolean ModificarDB(tb_Catalogo_Info Info) {
            try
            {
                using(Entities_General context = new Entities_General())
                {
                     tb_catalogo contact = context.tb_catalogo.First(cot => cot.IdCatalogo_tipo == Info.IdCatalogo_tipo);
                
                    if(contact != null)
                    {
                        contact.nom_catalogo = Info.nom_catalogo;
                        context.SaveChanges();                    
                    }                
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        
        }

        public Boolean AnularDB(tb_Catalogo_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    tb_catalogo contact = context.tb_catalogo.First(cot => cot.IdCatalogo_tipo == Info.IdCatalogo_tipo);

                    if (contact != null)
                    {
                        
                        contact.estado = false ;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;

        }
         
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
namespace Core.ErpSys.Data.Facturacion
{
    public class fac_catalogo_Data
    {
        public List<fac_catalogo_Info> Get_List_Catalogo()
        {
            List<fac_catalogo_Info> ListInfo = new List<fac_catalogo_Info>();
            try
            {
                Entities_Facturacion OBase = new Entities_Facturacion();

                IQueryable<fac_catalogo> selectq = from cat in OBase.fac_catalogo
                                                  where cat.estado == true
                                                  select cat;

                foreach (fac_catalogo item in selectq)
                {
                    ListInfo.Add(new fac_catalogo_Info(item.IdCatalogo, item.cod_catalogo, item.IdCatalogo_tipo, item.nom_catalogo, item.estado, item.orden, item.IdUsuario,
                                                        item.IdUsuarioUltMod, item.FechaUltMod, item.nom_pc, item.ip, item.IdUsuarioUltAnu, item.Fecha_UltAnu, item.MotiAnula));
                }

            }
            catch (Exception)
            {
                return new List<fac_catalogo_Info>();
            }
            return ListInfo;
        }

        public List<fac_catalogo_Info> Get_List_Catalogo(int IdCatalogo_tipo)
        {
            List<fac_catalogo_Info> ListInfo = new List<fac_catalogo_Info>();
            try
            {
                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from cat in OBase.fac_catalogo
                              join tip in OBase.fac_catalogo_tipo
                              on cat.IdCatalogo_tipo equals tip.IdCatalogo_tipo 
                              orderby cat.orden ascending 
                              select new
                              {
                                  IdCat = cat.IdCatalogo,
                                  IdTip = cat.IdCatalogo_tipo,
                                  NomCatTip = tip.nom_Catalogo_tipo,
                                  NomCat = cat.nom_catalogo,
                                  EstCat = cat.estado
                              };

                foreach (var item in selectq)
                {
                    if (item.IdTip == IdCatalogo_tipo && item.EstCat == true)
                    {
                        ListInfo.Add(new fac_catalogo_Info(item.IdCat, item.NomCat, item.EstCat, item.IdTip));
                    }
                }

            }
            catch (Exception)
            {
                return new List<fac_catalogo_Info>();
            }
            return ListInfo;
        }

        public Boolean ModificarDB(fac_catalogo_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    fac_catalogo contact = context.fac_catalogo.First(cot => cot.IdCatalogo_tipo == Info.IdCatalogo_tipo);

                    if (contact != null)
                    {
                        contact.cod_catalogo = Info.cod_catalogo;
                        contact.nom_catalogo = Info.nom_catalogo;
                        contact.orden = Info.orden;
                        contact.IdUsuarioUltMod = Info.IdUsuarioUltMod;
                        contact.FechaUltMod = Info.FechaUltMod;
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;
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

        public Boolean AnularDB(fac_catalogo_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    fac_catalogo contact = context.fac_catalogo.First(cot => cot.IdCatalogo_tipo == Info.IdCatalogo_tipo);

                    if (contact != null)
                    {
                        
                        contact.nom_pc = Info.nom_pc;
                        contact.ip = Info.ip;
                        contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                        contact.MotiAnula = Info.MotiAnula;
                        contact.estado = false;
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

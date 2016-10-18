using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_TipoNota_x_tbsucursal_Data
    {
        public fac_TipoNota_x_tbsucursal_Info Get_Info_TipoNota_Sucursal(int IdEmpresa, int IdSucursal, int IdTipoNota)
        {
            fac_TipoNota_x_tbsucursal_Info Info = new fac_TipoNota_x_tbsucursal_Info  ();
            try
            {
                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_TipoNota_x_tbsucursal
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdTipoNota == IdTipoNota
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdTipoNota = item.IdTipoNota;
                    Info.IdCtaCble = item.IdCtaCble;

                }
            }
            catch (Exception)
            {

                return new fac_TipoNota_x_tbsucursal_Info();
            }


            return Info;

        }
        
        public Boolean GrabarDB(fac_TipoNota_x_tbsucursal_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var addressG = new fac_TipoNota_x_tbsucursal();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdSucursal = Info.IdSucursal;
                    addressG.IdTipoNota = Info.IdTipoNota;
                    addressG.IdCtaCble = Info.IdCtaCble;
                    context.fac_TipoNota_x_tbsucursal.Add(addressG);
                    context.SaveChanges();

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

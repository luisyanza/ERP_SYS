using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_pedido_estadoAprobacion_Data
    {

        public List<fac_pedido_estadoAprobacion_Info> Get_List_EstadoAprobacion(fac_pedido_estadoAprobacion_Info Info)
        {
            List<fac_pedido_estadoAprobacion_Info> ListInfo = new List<fac_pedido_estadoAprobacion_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_pedido_estadoAprobacion

                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_pedido_estadoAprobacion_Info(item.IdEstadoAprobacion,item.Descripcion,item.Estado,item.posicion));
                }

            }
            catch (Exception)
            {
                return new List<fac_pedido_estadoAprobacion_Info>();
            }

            return ListInfo;
        }

        public Boolean GrabarDB(fac_pedido_estadoAprobacion_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_pedido_estadoAprobacion();
                    addressG.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                    addressG.Descripcion = Info.Descripcion;
                    addressG.Estado = Info.Estado;
                    addressG.posicion = Info.posicion;
                    context.fac_pedido_estadoAprobacion.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_pedido_estadoAprobacion_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_pedido_estadoAprobacion.FirstOrDefault(cot => cot.IdEstadoAprobacion == Info.IdEstadoAprobacion);

                    if (contact != null)
                    {
                        contact.Descripcion = Info.Descripcion;
                        contact.Estado = Info.Estado;
                        contact.posicion = Info.posicion;
                        context.SaveChanges();
                    }
                    else
                        return false;
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

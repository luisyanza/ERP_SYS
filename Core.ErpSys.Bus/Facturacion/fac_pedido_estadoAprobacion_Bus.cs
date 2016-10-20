using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_pedido_estadoAprobacion_Bus
    {

        fac_pedido_estadoAprobacion_Data oData = new fac_pedido_estadoAprobacion_Data();
        public List<fac_pedido_estadoAprobacion_Info> Get_List_EstadoAprobacion(fac_pedido_estadoAprobacion_Info Info)
        {
            try
            {
                return oData.Get_List_EstadoAprobacion(Info);
            }
            catch (Exception)
            {

                return new List<fac_pedido_estadoAprobacion_Info>();
            }

        }
        public Boolean GrabarDB(fac_pedido_estadoAprobacion_Info Info)
        {
            try
            {
                return oData.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Boolean ModificarDB(fac_pedido_estadoAprobacion_Info Info)
        {
            try
            {
                return oData.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}

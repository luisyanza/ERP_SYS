using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_pedido_estadoAprobacion_Info
    {
        public string IdEstadoAprobacion { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public int posicion { get; set; }

        public fac_pedido_estadoAprobacion_Info()
        {

        }

        public fac_pedido_estadoAprobacion_Info(string _IdEstadoAprobacion,string _Descripcion,string _Estado,int _posicion)
        {
            IdEstadoAprobacion = _IdEstadoAprobacion;
            Descripcion = _Descripcion;
            Estado = _Estado;
            posicion = _posicion;

        }
    }
}

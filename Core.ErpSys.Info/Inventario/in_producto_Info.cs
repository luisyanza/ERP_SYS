using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Inventario
{
    public class in_producto_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdProducto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string IdCategoria { get; set; }
        public Boolean estado { get; set; }

        public in_producto_Info(int _IdEmpresa,	decimal _IdProducto,	string _cod_producto,	string _nom_producto,	string _IdCategoria,	Boolean _estado)
        {
            IdEmpresa = _IdEmpresa;
            IdProducto = _IdProducto;
            cod_producto = _cod_producto;
            nom_producto = _nom_producto;
            IdCategoria = _IdCategoria;
            estado = _estado;

        }
        public in_producto_Info()
        {

        }

    }
}

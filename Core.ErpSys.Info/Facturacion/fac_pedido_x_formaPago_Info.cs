using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_pedido_x_formaPago_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdPedido { get; set; }
        public string IdTipoFormaPago { get; set; }
        public int Secuencia { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Fecha_vct { get; set; }
        public int Dias_Plazo { get; set; }
        public double Por_Distribucion { get; set; }
        public double Valor { get; set; }

        public fac_pedido_x_formaPago_Info()
        {

        }

        public fac_pedido_x_formaPago_Info(int _IdEmpresa, int _IdSucursal, int _IdBodega, decimal _IdPedido, string _IdTipoFormaPago,
                                            int _Secuencia, DateTime _Fecha, DateTime _Fecha_vct, int _Dias_Plazo, double _Por_Distribucion,
                                            double _Valor)
        {
            IdEmpresa = _IdEmpresa;
            IdSucursal = _IdSucursal;
            IdBodega = _IdBodega;
            IdPedido = _IdPedido;
            IdTipoFormaPago = _IdTipoFormaPago;
            Secuencia = _Secuencia;
            Fecha = _Fecha;
            Fecha_vct = _Fecha_vct;
            Dias_Plazo = _Dias_Plazo;
            Por_Distribucion = _Por_Distribucion;
            Valor = _Valor;

        }
    }
}

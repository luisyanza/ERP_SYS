using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_pedido_x_formaPago_Bus
    {
        fac_pedido_x_formaPago_Data oData = new fac_pedido_x_formaPago_Data();

        public Boolean GrabarDB(List<fac_pedido_x_formaPago_Info> List_Info)
        {
            return oData.GrabarDB(List_Info);
        }
        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, string IdTipoFormaPago)
        {
            return oData.EliminarDB(IdEmpresa, IdSucursal, IdBodega, IdPedido, IdTipoFormaPago);
        }
        public List<fac_pedido_x_formaPago_Info> Get_List_OrdenPedidoDet(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, string IdTipoFormaPago)
        {
            return oData.Get_List_OrdenPedidoDet(IdEmpresa, IdSucursal, IdBodega, IdPedido, IdTipoFormaPago);
        }
    }
}

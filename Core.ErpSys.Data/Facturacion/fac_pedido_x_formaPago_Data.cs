using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_pedido_x_formaPago_Data
    {

        public Boolean GrabarDB(List<fac_pedido_x_formaPago_Info> List_Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    int i = 0;
                    foreach (var det in List_Info)
                    {
                        i = i++;
                        var addressG = new fac_pedido_x_formaPago();
                        addressG.IdEmpresa = det.IdEmpresa;
                        addressG.IdSucursal = det.IdSucursal;
                        addressG.IdBodega = det.IdBodega;
                        addressG.IdPedido = det.IdPedido;
                        addressG.IdTipoFormaPago = det.IdTipoFormaPago;
                        addressG.Secuencia = det.Secuencia;
                        addressG.Fecha = det.Fecha;
                        addressG.Fecha_vct = det.Fecha_vct;
                        addressG.Dias_Plazo = det.Dias_Plazo;
                        addressG.Por_Distribucion = det.Por_Distribucion;
                        addressG.Valor = det.Valor;
                        context.fac_pedido_x_formaPago.Add(addressG);
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

        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, string IdTipoFormaPago)
        {
            try
            {
                bool respuesta = false;
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    IQueryable<fac_pedido_x_formaPago> select = from x in context.fac_pedido_x_formaPago
                                                              where x.IdPedido == IdPedido && x.IdSucursal == IdSucursal
                                                              && x.IdBodega == IdBodega && x.IdEmpresa == IdEmpresa && IdTipoFormaPago == x.IdTipoFormaPago 
                                                              select x;

                    foreach (fac_pedido_x_formaPago item in select)
                    {
                        context.fac_pedido_x_formaPago.Remove(item);
                    }
                    respuesta = true;
                }
                return respuesta;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<fac_pedido_x_formaPago_Info> Get_List_OrdenPedidoDet(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, string IdTipoFormaPago)
        {

            try
            {
                List<fac_pedido_x_formaPago_Info> ListInfo = new List<fac_pedido_x_formaPago_Info>();
                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_pedido_x_formaPago
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdPedido == IdPedido && q.IdTipoFormaPago == IdTipoFormaPago 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_pedido_x_formaPago_Info(item.IdEmpresa, item.IdSucursal, item.IdBodega, item.IdPedido, item.IdTipoFormaPago,
                                                                    item.Secuencia, item.Fecha, item.Fecha_vct, item.Dias_Plazo, item.Por_Distribucion, item.Valor));
                }
                return ListInfo;
            }
            catch (Exception)
            {

                return new List<fac_pedido_x_formaPago_Info>(); 
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_orden_pedido_det_Data
    {

        public Boolean GrabarDB(List<fac_orden_pedido_det_Info> List_Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    int i = 0;
                    foreach (var det in List_Info)
                    {
                        i = i++;
                        var addressG = new fac_orden_pedido_det();
                        addressG.IdEmpresa = det.IdEmpresa;
                        addressG.IdSucursal = det.IdSucursal;
                        addressG.IdPuntoVta = det.IdPuntoVta;
                        addressG.IdPedido = det.IdPedido;
                        addressG.Secuencial = i;
                        addressG.IdProducto = det.IdProducto;
                        addressG.dp_cantidad = det.dp_cantidad;
                        addressG.dp_precio = det.dp_precio;
                        addressG.dp_Porc_descuento = det.dp_Porc_descuento;
                        addressG.cp_valor_desUni = det.cp_valor_desUni;
                        addressG.cp_PrecioFinal = det.cp_PrecioFinal;
                        addressG.dp_subtotal = det.dp_subtotal;
                        addressG.dp_valor_impuesto_iva = det.dp_valor_impuesto_iva;
                        addressG.dp_detallexItems = det.dp_detallexItems;
                        addressG.dp_por_impuesto_iva = det.dp_por_impuesto_iva;
                        addressG.IdImpuesto_Iva = det.IdImpuesto_Iva;
                        addressG.IdImpuesto_Ice = det.IdImpuesto_Ice;
                        addressG.valor_impuesto_ice = det.valor_impuesto_ice;
                        addressG.por_impuesto_ice = det.por_impuesto_ice;
                        addressG.dp_total = det.dp_total;
                        context.fac_orden_pedido_det.Add(addressG);
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

        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdPedido)
        {
            try
            {
                bool respuesta = false;
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    IQueryable<fac_orden_pedido_det> select = from cbte in context.fac_orden_pedido_det
                                                               where cbte.IdPedido == IdPedido && cbte.IdSucursal == IdSucursal
                                                               && cbte.IdPuntoVta == IdPuntoVta && cbte.IdEmpresa == IdEmpresa
                                                               select cbte;

                    foreach (fac_orden_pedido_det item in select)
                    {
                        context.fac_orden_pedido_det.Remove(item);
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

        public List<fac_orden_pedido_det_Info> Get_List_OrdenPedidoDet(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdPedido)
        {

            try
            {
                List<fac_orden_pedido_det_Info> ListInfo = new List<fac_orden_pedido_det_Info>();
                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_orden_pedido_det
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta && q.IdPedido == IdPedido
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_orden_pedido_det_Info(item.IdEmpresa, item.IdSucursal, item.IdPuntoVta, item.IdPedido, item.Secuencial,
                                                                item.IdProducto, item.dp_cantidad, item.dp_precio, item.dp_Porc_descuento, item.cp_valor_desUni,
                                                                item.cp_PrecioFinal, item.dp_subtotal, item.dp_valor_impuesto_iva, item.dp_detallexItems, item.dp_por_impuesto_iva,
                                                                item.IdImpuesto_Iva, item.IdImpuesto_Ice, item.valor_impuesto_ice, item.por_impuesto_ice, item.dp_total));

                }
                return ListInfo;
            }
            catch (Exception)
            {

                return new List<fac_orden_pedido_det_Info>();
            }
        }

    }
}

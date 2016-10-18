using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_cotizacion_det_Data
    {

        public Boolean GrabarDB(List<fac_cotizacion_det_Info> List_Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    int i = 0;
                    foreach (var item in List_Info)
                    {
                        i = i++;
                        var addressG = new fac_cotizacion_det();
                        addressG.IdEmpresa = item.IdEmpresa;
                        addressG.IdSucursal = item.IdSucursal;
                        addressG.IdPuntoVta = item.IdPuntoVta;
                        addressG.IdCotizacion = item.IdCotizacion;
                        addressG.Secuencial = i;
                        addressG.IdProducto = item.IdProducto;
                        addressG.dc_cantidad = item.dc_cantidad;
                        addressG.dc_precio = item.dc_precio;
                        addressG.dc_por_desUni = item.dc_por_desUni;
                        addressG.dc_valor_desUni = item.dc_valor_desUni;
                        addressG.dc_precioFinal = item.dc_precioFinal;
                        addressG.dc_subtotal = item.dc_subtotal;
                        addressG.dc_valor_impuesto_iva = item.dc_valor_impuesto_iva;
                        addressG.dc_detallexItems = item.dc_detallexItems;
                        addressG.dc_por_impuesto_iva = item.dc_por_impuesto_iva;
                        addressG.IdImpuesto_Iva = item.IdImpuesto_Iva;
                        addressG.dc_total = item.dc_total;

                        context.fac_cotizacion_det.Add(addressG);
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

        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, int IdPtoVenta , decimal IdCotizacion)
        {
            try
            {
                bool respuesta = false;
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    IQueryable<fac_cotizacion_det> select = from cot in context.fac_cotizacion_det
                                                         where cot.IdCotizacion == IdCotizacion && cot.IdPuntoVta == IdPtoVenta && cot.IdSucursal == IdSucursal && cot.IdEmpresa == IdEmpresa
                                                         select cot;

                    foreach (fac_cotizacion_det item in select)
                    {
                        context.fac_cotizacion_det.Remove(item);
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

    }
}

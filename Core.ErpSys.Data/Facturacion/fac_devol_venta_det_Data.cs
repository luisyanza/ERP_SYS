using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;


namespace Core.ErpSys.Data.Facturacion
{
    public class fac_devol_venta_det_Data
    {
        public Boolean GrabarDB(List<fac_devol_venta_det_Info> List_Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    int i = 0;
                    foreach (var item in List_Info)
                    {

                        i = i++;
                        var addressG = new fac_devol_venta_det();
                        addressG.IdEmpresa = item.IdEmpresa;
                        addressG.IdSucursal = item.IdSucursal;
                        addressG.IdPuntoVta = item.IdPuntoVta;
                        addressG.IdDevolucion = item.IdDevolucion;
                        addressG.Secuencia = i;
                        addressG.IdProducto = item.IdProducto;
                        addressG.dv_cantidad = item.dv_cantidad;
                        addressG.dv_Precio = item.dv_Precio;
                        addressG.dv_PorDescUni = item.dv_PorDescUni;
                        addressG.dv_ValordescUni = item.dv_ValordescUni;
                        addressG.dv_PrecioFinal = item.dv_PrecioFinal;
                        addressG.dv_subtotal = item.dv_subtotal;
                        addressG.dv_valor_impuesto_iva = item.dv_valor_impuesto_iva;
                        addressG.dv_costo_Uni = item.dv_costo_Uni;
                        addressG.dv_detallexItems = item.dv_detallexItems;
                        addressG.dv_por_impuesto_iva = item.dv_por_impuesto_iva;
                        addressG.IdImpuesto_Iva = item.IdImpuesto_Iva;
                        addressG.dv_total = item.dv_total;

                        context.fac_devol_venta_det.Add(addressG);
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

        public Boolean EliminarDB(int IdEmpresa, int IdSucursal, int IdPtoVenta, decimal IdDevolucion)
        {
            try
            {
                bool respuesta = false;
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    IQueryable<fac_devol_venta_det> select = from cot in context.fac_devol_venta_det
                                                            where cot.IdDevolucion == IdDevolucion && cot.IdPuntoVta == IdPtoVenta && cot.IdSucursal == IdSucursal && cot.IdEmpresa == IdEmpresa
                                                            select cot;

                    foreach (fac_devol_venta_det item in select)
                    {
                        context.fac_devol_venta_det.Remove(item);
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

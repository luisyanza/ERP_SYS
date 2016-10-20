using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;


namespace Core.ErpSys.Data.Facturacion
{
   public class fac_cbteVta_det_Data
    {

        public Boolean GrabarDB(List<fac_cbteVta_det_Info> List_Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    int i = 0;
                    foreach (var item in List_Info)
                    {
                        i= i++;
                        var addressG = new fac_cbteVta_det();
                        addressG.IdEmpresa = item.IdEmpresa;
                        addressG.IdCbteVtaTipo = item.IdCbteVtaTipo;
                        addressG.IdCbteVta = item.IdCbteVta;
                        addressG.secuencia = i;
                        addressG.IdProducto = item.IdProducto;
                        addressG.observacion_det = item.observacion_det;
                        addressG.cantidad = item.cantidad;
                        addressG.precio = item.precio;
                        addressG.por_descuento = item.por_descuento;
                        addressG.valor_descuento = item.valor_descuento;
                        addressG.precio_final = item.precio_final;
                        addressG.subtotal = item.subtotal;
                        addressG.valor_impuesto_iva = item.valor_impuesto_iva;
                        addressG.por_impuesto_iva = item.por_impuesto_iva;
                        addressG.IdImpuesto_Iva = item.IdImpuesto_Iva;
                        addressG.total = item.total;
                        addressG.IdPunto_Cargo = item.IdPunto_Cargo;
                        addressG.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        addressG.IdImpuesto_Ice = item.IdImpuesto_Ice;
                        addressG.valor_impuesto_ice = item.valor_impuesto_ice;
                        addressG.por_impuesto_ice = item.por_impuesto_ice;
                        context.fac_cbteVta_det.Add(addressG);
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

        public Boolean EliminarDB(int IdEmpresa, string IdTipoCbteVta, decimal IdCbte)
        {
            try
            {
                bool respuesta = false;
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    IQueryable<fac_cbteVta_det> select = from cbte in context.fac_cbteVta_det
                                                         where cbte.IdCbteVta == IdCbte && cbte.IdCbteVtaTipo == IdTipoCbteVta && cbte.IdEmpresa == IdEmpresa
                                                         select cbte;
                    
                    foreach (fac_cbteVta_det item in select)
                    {
                        context.fac_cbteVta_det.Remove(item);
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

        public List<fac_cbteVta_det_Info> Get_List_CbteVta(int IdEmpresa,  decimal IdCbteVta)
        {
           
             try
            {
                List<fac_cbteVta_det_Info> ListInfo = new List<fac_cbteVta_det_Info>();
                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cbteVta_det
                              where q.IdEmpresa == IdEmpresa &&  q.IdCbteVta == IdCbteVta
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_cbteVta_det_Info(item.IdEmpresa,item.IdCbteVtaTipo,item.IdCbteVta,item.secuencia,item.IdProducto,
                                                            item.observacion_det,item.cantidad,item.precio,item.por_descuento,item.valor_descuento,
                                                            item.precio_final,item.subtotal,item.valor_impuesto_iva,item.por_impuesto_iva,item.IdImpuesto_Iva,
                                                            item.total,item.IdPunto_Cargo,item.IdPunto_cargo_grupo,item.IdImpuesto_Ice,item.valor_impuesto_ice,
                                                            item.por_impuesto_ice));

                }
                return ListInfo;
            }
            catch (Exception)
            {
                
                return new List<fac_cbteVta_det_Info>();
            }
        }

    }
}

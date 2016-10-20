using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_guia_remision_det_Data
    {
        public Boolean GrabarDB(List<fac_guia_remision_det_Info> List_Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    int i = 0;
                    foreach (var item in List_Info)
                    {
                        i = i++;
                        var addressG = new fac_guia_remision_det();
                        addressG.IdEmpresa = item.IdEmpresa;
                        addressG.IdSucursal = item.IdSucursal;
                        addressG.IdPuntoVta = item.IdPuntoVta;
                        addressG.IdGuiaRemision = item.IdGuiaRemision;
                        addressG.Secuencia = i;
                        addressG.IdProducto = item.IdProducto;
                        addressG.gi_cantidad = item.gi_cantidad;
                        addressG.gi_Precio = item.gi_Precio;
                        addressG.gi_PorDescUnitario = item.gi_PorDescUnitario;
                        addressG.gi_DescUnitario = item.gi_DescUnitario;
                        addressG.gi_PrecioFinal = item.gi_PrecioFinal;
                        addressG.gi_Subtotal = item.gi_Subtotal;
                        addressG.gi_iva = item.gi_iva;
                        addressG.gi_total = item.gi_total;
                        addressG.gi_costo = item.gi_costo;
                        addressG.gi_tieneIVA = item.gi_tieneIVA;
                        addressG.gi_detallexItems = item.gi_detallexItems;

                        context.fac_guia_remision_det.Add(addressG);
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

        public Boolean EliminarDB(int IdEmpresa,int IdSucursal,int IdPuntoVta,decimal IdGuiaRemision)
        {
            try
            {
                bool respuesta = false;
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    IQueryable<fac_guia_remision_det> select = from cbte in context.fac_guia_remision_det
                                                               where cbte.IdGuiaRemision == IdGuiaRemision && cbte.IdSucursal == IdSucursal 
                                                               && cbte.IdPuntoVta == IdPuntoVta && cbte.IdEmpresa == IdEmpresa
                                                               select cbte;

                    foreach (fac_guia_remision_det item in select)
                    {
                        context.fac_guia_remision_det.Remove(item);
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

        public List<fac_guia_remision_det_Info> Get_List_GuiaRemision(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdGuiaRemision)
        {

            try
            {
                List<fac_guia_remision_det_Info> ListInfo = new List<fac_guia_remision_det_Info>();
                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_guia_remision_det
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta && q.IdGuiaRemision ==IdGuiaRemision 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_guia_remision_det_Info(item.IdEmpresa,item.IdSucursal,item.IdPuntoVta,item.IdGuiaRemision,item.Secuencia,
                                                                item.IdProducto,item.gi_cantidad,item.gi_Precio,item.gi_PorDescUnitario,item.gi_DescUnitario,
                                                                item.gi_PrecioFinal,item.gi_Subtotal,item.gi_iva,item.gi_total,item.gi_costo,
                                                                item.gi_tieneIVA,item.gi_detallexItems));

                }
                return ListInfo;
            }
            catch (Exception)
            {

                return new List<fac_guia_remision_det_Info>();
            }
        }


    }
}

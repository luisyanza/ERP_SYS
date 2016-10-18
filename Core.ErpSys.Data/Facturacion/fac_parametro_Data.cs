using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;


namespace Core.ErpSys.Data.Facturacion
{
    public class fac_parametro_Data
    {
        public fac_parametro_Info Get_Parametros(int idEmpresa)
        {
            fac_parametro_Info Info = new fac_parametro_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_parametro
                              where q.IdEmpresa == idEmpresa 
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdMovi_inven_tipo_Factura = item.IdMovi_inven_tipo_Factura;
                    Info.pa_porc_max_total_item_x_despa_Guia = item.pa_porc_max_total_item_x_despa_Guia;
                    Info.IdMovi_inven_tipo_Dev_Vta = item.IdMovi_inven_tipo_Dev_Vta;
                    Info.IdMovi_inven_tipo_Factura_Anulacion = item.IdMovi_inven_tipo_Factura_Anulacion;
                    Info.IdMovi_inven_tipo_Dev_Vta_Anulacion = item.IdMovi_inven_tipo_Dev_Vta_Anulacion;
                    Info.Tipo_NC_x_DevVta = item.Tipo_NC_x_DevVta;
                    Info.IdDepartamento_x_DevVta = item.IdDepartamento_x_DevVta;
                    Info.IdTipoCbteCble_Factura = item.IdTipoCbteCble_Factura;
                    Info.IdTipoCbteCble_Factura_Reverso = item.IdTipoCbteCble_Factura_Reverso;
                    Info.IdTipoCbteCble_Factura_Costo_VTA = item.IdTipoCbteCble_Factura_Costo_VTA;
                    Info.IdTipoCbteCble_Factura_Costo_VTA_Reverso = item.IdTipoCbteCble_Factura_Costo_VTA_Reverso;
                    Info.IdTipoCbteCble_NC = item.IdTipoCbteCble_NC;
                    Info.IdTipoCbteCble_NC_Reverso = item.IdTipoCbteCble_NC_Reverso;
                    Info.IdTipoCbteCble_ND = item.IdTipoCbteCble_ND;
                    Info.IdTipoCbteCble_ND_Reverso = item.IdTipoCbteCble_ND_Reverso;
                    Info.SeImprimiGuiaRemiAuto = item.SeImprimiGuiaRemiAuto;
                    Info.NumeroDeItemFact = item.NumeroDeItemFact;
                    Info.TipoCobroDafaultFactu = item.TipoCobroDafaultFactu;
                    Info.IdCaja_Default_Factura = item.IdCaja_Default_Factura;
                    Info.IdCtaCble_x_anticipo_cliente = item.IdCtaCble_x_anticipo_cliente;
                    Info.pa_IdTipoNota_NC_x_Anulacion = item.pa_IdTipoNota_NC_x_Anulacion;
                    Info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                    Info.pa_ruta_descarga_xml_fac_elct = item.pa_ruta_descarga_xml_fac_elct;
                    Info.File_Reporte_FacturaDiseño = item.File_Reporte_FacturaDiseño;
                    Info.File_Reporte_Nota_CRED_DEB = item.File_Reporte_Nota_CRED_DEB;
                    Info.IdCtaCble_IVA = item.IdCtaCble_IVA;
                    Info.IdCtaCble_SubTotal_Vtas_x_Default = item.IdCtaCble_SubTotal_Vtas_x_Default;
                    Info.IdCtaCble_CXC_Vtas_x_Default = item.IdCtaCble_CXC_Vtas_x_Default;
                    Info.pa_X_Defecto_la_factura_es_cbte_elect = item.pa_X_Defecto_la_factura_es_cbte_elect;
                    Info.pa_X_Defecto_la_guia_es_cbte_elect = item.pa_X_Defecto_la_guia_es_cbte_elect;
                    Info.pa_X_Defecto_la_ND_es_cbte_elect = item.pa_X_Defecto_la_ND_es_cbte_elect;
                    Info.pa_X_Defecto_la_NC_es_cbte_elect = item.pa_X_Defecto_la_NC_es_cbte_elect;
                }
            }
            catch (Exception)
            {
                return new fac_parametro_Info();
            }

            return Info;

        }
        public Boolean GrabarDB(fac_parametro_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_parametro();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdMovi_inven_tipo_Factura = Info.IdMovi_inven_tipo_Factura;
                    addressG.pa_porc_max_total_item_x_despa_Guia = Info.pa_porc_max_total_item_x_despa_Guia;
                    addressG.IdMovi_inven_tipo_Dev_Vta = Info.IdMovi_inven_tipo_Dev_Vta;
                    addressG.IdMovi_inven_tipo_Factura_Anulacion = Info.IdMovi_inven_tipo_Factura_Anulacion;
                    addressG.IdMovi_inven_tipo_Dev_Vta_Anulacion = Info.IdMovi_inven_tipo_Dev_Vta_Anulacion;
                    addressG.Tipo_NC_x_DevVta = Info.Tipo_NC_x_DevVta;
                    addressG.IdDepartamento_x_DevVta = Info.IdDepartamento_x_DevVta;
                    addressG.IdTipoCbteCble_Factura = Info.IdTipoCbteCble_Factura;
                    addressG.IdTipoCbteCble_Factura_Reverso = Info.IdTipoCbteCble_Factura_Reverso;
                    addressG.IdTipoCbteCble_Factura_Costo_VTA = Info.IdTipoCbteCble_Factura_Costo_VTA;
                    addressG.IdTipoCbteCble_Factura_Costo_VTA_Reverso = Info.IdTipoCbteCble_Factura_Costo_VTA_Reverso;
                    addressG.IdTipoCbteCble_NC = Info.IdTipoCbteCble_NC;
                    addressG.IdTipoCbteCble_NC_Reverso = Info.IdTipoCbteCble_NC_Reverso;
                    addressG.IdTipoCbteCble_ND = Info.IdTipoCbteCble_ND;
                    addressG.IdTipoCbteCble_ND_Reverso = Info.IdTipoCbteCble_ND_Reverso;
                    addressG.SeImprimiGuiaRemiAuto = Info.SeImprimiGuiaRemiAuto;
                    addressG.NumeroDeItemFact = Info.NumeroDeItemFact;
                    addressG.TipoCobroDafaultFactu = Info.TipoCobroDafaultFactu;
                    addressG.IdCaja_Default_Factura = Info.IdCaja_Default_Factura;
                    addressG.IdCtaCble_x_anticipo_cliente = Info.IdCtaCble_x_anticipo_cliente;
                    addressG.pa_IdTipoNota_NC_x_Anulacion = Info.pa_IdTipoNota_NC_x_Anulacion;
                    addressG.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                    addressG.pa_ruta_descarga_xml_fac_elct = Info.pa_ruta_descarga_xml_fac_elct;
                    addressG.File_Reporte_FacturaDiseño = Info.File_Reporte_FacturaDiseño;
                    addressG.File_Reporte_Nota_CRED_DEB = Info.File_Reporte_Nota_CRED_DEB;
                    addressG.IdCtaCble_IVA = Info.IdCtaCble_IVA;
                    addressG.IdCtaCble_SubTotal_Vtas_x_Default = Info.IdCtaCble_SubTotal_Vtas_x_Default;
                    addressG.IdCtaCble_CXC_Vtas_x_Default = Info.IdCtaCble_CXC_Vtas_x_Default;
                    addressG.pa_X_Defecto_la_factura_es_cbte_elect = Info.pa_X_Defecto_la_factura_es_cbte_elect;
                    addressG.pa_X_Defecto_la_guia_es_cbte_elect = Info.pa_X_Defecto_la_guia_es_cbte_elect;
                    addressG.pa_X_Defecto_la_ND_es_cbte_elect = Info.pa_X_Defecto_la_ND_es_cbte_elect;
                    addressG.pa_X_Defecto_la_NC_es_cbte_elect = Info.pa_X_Defecto_la_NC_es_cbte_elect;

                    context.fac_parametro.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_parametro_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_parametro.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa );

                    if (contact != null)
                    {
                        contact.IdMovi_inven_tipo_Factura = Info.IdMovi_inven_tipo_Factura;
                        contact.pa_porc_max_total_item_x_despa_Guia = Info.pa_porc_max_total_item_x_despa_Guia;
                        contact.IdMovi_inven_tipo_Dev_Vta = Info.IdMovi_inven_tipo_Dev_Vta;
                        contact.IdMovi_inven_tipo_Factura_Anulacion = Info.IdMovi_inven_tipo_Factura_Anulacion;
                        contact.IdMovi_inven_tipo_Dev_Vta_Anulacion = Info.IdMovi_inven_tipo_Dev_Vta_Anulacion;
                        contact.Tipo_NC_x_DevVta = Info.Tipo_NC_x_DevVta;
                        contact.IdDepartamento_x_DevVta = Info.IdDepartamento_x_DevVta;
                        contact.IdTipoCbteCble_Factura = Info.IdTipoCbteCble_Factura;
                        contact.IdTipoCbteCble_Factura_Reverso = Info.IdTipoCbteCble_Factura_Reverso;
                        contact.IdTipoCbteCble_Factura_Costo_VTA = Info.IdTipoCbteCble_Factura_Costo_VTA;
                        contact.IdTipoCbteCble_Factura_Costo_VTA_Reverso = Info.IdTipoCbteCble_Factura_Costo_VTA_Reverso;
                        contact.IdTipoCbteCble_NC = Info.IdTipoCbteCble_NC;
                        contact.IdTipoCbteCble_NC_Reverso = Info.IdTipoCbteCble_NC_Reverso;
                        contact.IdTipoCbteCble_ND = Info.IdTipoCbteCble_ND;
                        contact.IdTipoCbteCble_ND_Reverso = Info.IdTipoCbteCble_ND_Reverso;
                        contact.SeImprimiGuiaRemiAuto = Info.SeImprimiGuiaRemiAuto;
                        contact.NumeroDeItemFact = Info.NumeroDeItemFact;
                        contact.TipoCobroDafaultFactu = Info.TipoCobroDafaultFactu;
                        contact.IdCaja_Default_Factura = Info.IdCaja_Default_Factura;
                        contact.IdCtaCble_x_anticipo_cliente = Info.IdCtaCble_x_anticipo_cliente;
                        contact.pa_IdTipoNota_NC_x_Anulacion = Info.pa_IdTipoNota_NC_x_Anulacion;
                        contact.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                        contact.pa_ruta_descarga_xml_fac_elct = Info.pa_ruta_descarga_xml_fac_elct;
                        contact.File_Reporte_FacturaDiseño = Info.File_Reporte_FacturaDiseño;
                        contact.File_Reporte_Nota_CRED_DEB = Info.File_Reporte_Nota_CRED_DEB;
                        contact.IdCtaCble_IVA = Info.IdCtaCble_IVA;
                        contact.IdCtaCble_SubTotal_Vtas_x_Default = Info.IdCtaCble_SubTotal_Vtas_x_Default;
                        contact.IdCtaCble_CXC_Vtas_x_Default = Info.IdCtaCble_CXC_Vtas_x_Default;
                        contact.pa_X_Defecto_la_factura_es_cbte_elect = Info.pa_X_Defecto_la_factura_es_cbte_elect;
                        contact.pa_X_Defecto_la_guia_es_cbte_elect = Info.pa_X_Defecto_la_guia_es_cbte_elect;
                        contact.pa_X_Defecto_la_ND_es_cbte_elect = Info.pa_X_Defecto_la_ND_es_cbte_elect;
                        contact.pa_X_Defecto_la_NC_es_cbte_elect = Info.pa_X_Defecto_la_NC_es_cbte_elect;

                        context.SaveChanges();
                    }
                    else
                        return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

            return true;

        }

     

    }
}

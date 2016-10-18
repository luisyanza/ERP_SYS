using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Facturacion
{
    public class fac_parametro_Info
    {
        public int IdEmpresa { get; set; }
        public int? IdMovi_inven_tipo_Factura { get; set; }
        public double? pa_porc_max_total_item_x_despa_Guia { get; set; }
        public int? IdMovi_inven_tipo_Dev_Vta { get; set; }
        public int? IdMovi_inven_tipo_Factura_Anulacion { get; set; }
        public int? IdMovi_inven_tipo_Dev_Vta_Anulacion { get; set; }
        public int? Tipo_NC_x_DevVta { get; set; }
        public int? IdDepartamento_x_DevVta { get; set; }
        public int? IdTipoCbteCble_Factura { get; set; }
        public int? IdTipoCbteCble_Factura_Reverso { get; set; }
        public int? IdTipoCbteCble_Factura_Costo_VTA { get; set; }
        public int? IdTipoCbteCble_Factura_Costo_VTA_Reverso { get; set; }
        public int? IdTipoCbteCble_NC { get; set; }
        public int? IdTipoCbteCble_NC_Reverso { get; set; }
        public int? IdTipoCbteCble_ND { get; set; }
        public int? IdTipoCbteCble_ND_Reverso { get; set; }
        public string SeImprimiGuiaRemiAuto { get; set; }
        public int? NumeroDeItemFact { get; set; }
        public string TipoCobroDafaultFactu { get; set; }
        public int? IdCaja_Default_Factura { get; set; }
        public string IdCtaCble_x_anticipo_cliente { get; set; }
        public int? pa_IdTipoNota_NC_x_Anulacion { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string pa_ruta_descarga_xml_fac_elct { get; set; }
        public byte[] File_Reporte_FacturaDiseño { get; set; }
        public byte[] File_Reporte_Nota_CRED_DEB { get; set; }
        public string IdCtaCble_IVA { get; set; }
        public string IdCtaCble_SubTotal_Vtas_x_Default { get; set; }
        public string IdCtaCble_CXC_Vtas_x_Default { get; set; }
        public Boolean? pa_X_Defecto_la_factura_es_cbte_elect { get; set; }
        public Boolean? pa_X_Defecto_la_guia_es_cbte_elect { get; set; }
        public Boolean? pa_X_Defecto_la_ND_es_cbte_elect { get; set; }
        public Boolean? pa_X_Defecto_la_NC_es_cbte_elect { get; set; }


        public fac_parametro_Info()
        {

        }
        public fac_parametro_Info(int _IdEmpresa, int? _IdMovi_inven_tipo_Factura, double? _pa_porc_max_total_item_x_despa_Guia, int? _IdMovi_inven_tipo_Dev_Vta, int? _IdMovi_inven_tipo_Factura_Anulacion, int? _IdMovi_inven_tipo_Dev_Vta_Anulacion, int? _Tipo_NC_x_DevVta,
                                    int? _IdDepartamento_x_DevVta, int? _IdTipoCbteCble_Factura, int? _IdTipoCbteCble_Factura_Reverso, int? _IdTipoCbteCble_Factura_Costo_VTA, int? _IdTipoCbteCble_Factura_Costo_VTA_Reverso, int? _IdTipoCbteCble_NC,
                                    int? _IdTipoCbteCble_NC_Reverso, int? _IdTipoCbteCble_ND, int? _IdTipoCbteCble_ND_Reverso, string _SeImprimiGuiaRemiAuto, int? _NumeroDeItemFact, string _TipoCobroDafaultFactu,
                                    int? _IdCaja_Default_Factura, string _IdCtaCble_x_anticipo_cliente, int? _pa_IdTipoNota_NC_x_Anulacion, string _IdEstadoAprobacion, string _pa_ruta_descarga_xml_fac_elct, byte[] _File_Reporte_FacturaDiseño, byte[] _File_Reporte_Nota_CRED_DEB,
                                    string _IdCtaCble_IVA, string _IdCtaCble_SubTotal_Vtas_x_Default, string _IdCtaCble_CXC_Vtas_x_Default, Boolean? _pa_X_Defecto_la_factura_es_cbte_elect,
                                    Boolean? _pa_X_Defecto_la_guia_es_cbte_elect, Boolean? _pa_X_Defecto_la_ND_es_cbte_elect, Boolean ? _pa_X_Defecto_la_NC_es_cbte_elect)
        {

            IdEmpresa = _IdEmpresa;
            IdMovi_inven_tipo_Factura = _IdMovi_inven_tipo_Factura;
            pa_porc_max_total_item_x_despa_Guia = _pa_porc_max_total_item_x_despa_Guia;
            IdMovi_inven_tipo_Dev_Vta = _IdMovi_inven_tipo_Dev_Vta;
            IdMovi_inven_tipo_Factura_Anulacion = _IdMovi_inven_tipo_Factura_Anulacion;
            IdMovi_inven_tipo_Dev_Vta_Anulacion = _IdMovi_inven_tipo_Dev_Vta_Anulacion;
            Tipo_NC_x_DevVta = _Tipo_NC_x_DevVta;
            IdDepartamento_x_DevVta = _IdDepartamento_x_DevVta;
            IdTipoCbteCble_Factura = _IdTipoCbteCble_Factura;
            IdTipoCbteCble_Factura_Reverso = _IdTipoCbteCble_Factura_Reverso;
            IdTipoCbteCble_Factura_Costo_VTA = _IdTipoCbteCble_Factura_Costo_VTA;
            IdTipoCbteCble_Factura_Costo_VTA_Reverso = _IdTipoCbteCble_Factura_Costo_VTA_Reverso;
            IdTipoCbteCble_NC = _IdTipoCbteCble_NC;
            IdTipoCbteCble_NC_Reverso = _IdTipoCbteCble_NC_Reverso;
            IdTipoCbteCble_ND = _IdTipoCbteCble_ND;
            IdTipoCbteCble_ND_Reverso = _IdTipoCbteCble_ND_Reverso;
            SeImprimiGuiaRemiAuto = _SeImprimiGuiaRemiAuto;
            NumeroDeItemFact = _NumeroDeItemFact;
            TipoCobroDafaultFactu = _TipoCobroDafaultFactu;
            IdCaja_Default_Factura = _IdCaja_Default_Factura;
            IdCtaCble_x_anticipo_cliente = _IdCtaCble_x_anticipo_cliente;
            pa_IdTipoNota_NC_x_Anulacion = _pa_IdTipoNota_NC_x_Anulacion;
            IdEstadoAprobacion = _IdEstadoAprobacion;
            pa_ruta_descarga_xml_fac_elct = _pa_ruta_descarga_xml_fac_elct;
            File_Reporte_FacturaDiseño = _File_Reporte_FacturaDiseño;
            File_Reporte_Nota_CRED_DEB = _File_Reporte_Nota_CRED_DEB;
            IdCtaCble_IVA = _IdCtaCble_IVA;
            IdCtaCble_SubTotal_Vtas_x_Default = _IdCtaCble_SubTotal_Vtas_x_Default;
            IdCtaCble_CXC_Vtas_x_Default = _IdCtaCble_CXC_Vtas_x_Default;
            pa_X_Defecto_la_factura_es_cbte_elect = _pa_X_Defecto_la_factura_es_cbte_elect;
            pa_X_Defecto_la_guia_es_cbte_elect = _pa_X_Defecto_la_guia_es_cbte_elect;
            pa_X_Defecto_la_ND_es_cbte_elect = _pa_X_Defecto_la_ND_es_cbte_elect;
            pa_X_Defecto_la_NC_es_cbte_elect = _pa_X_Defecto_la_NC_es_cbte_elect;

        }
    }
}

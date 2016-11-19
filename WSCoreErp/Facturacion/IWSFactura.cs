using System;
namespace WSCoreErp.Facturacion
{
    interface IWSFactura
    {
        bool AnularDBCbteVtaTipo(Core.ErpSys.Info.Facturacion.fac_cbteVta_tipo_Info Info);
        Core.ErpSys.Info.Facturacion.fac_cbteVta_Info Get_Info_CbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdCbteVta);
        System.Collections.Generic.List<Core.ErpSys.Info.Facturacion.fac_cbteVta_Info> Get_List_CbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta);
        System.Collections.Generic.List<Core.ErpSys.Info.Facturacion.fac_cbteVta_tipo_Info> Get_List_CbteVtaTipo();
        Core.ErpSys.Info.Facturacion.fac_cbteVta_Talonario_Info Get_NumCbteVta_Talonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdCbteVtaTipo);
        bool GetNumCbteVta(ref string Mensaje);
        bool GrabarDBCbteVta(Core.ErpSys.Info.Facturacion.fac_cbteVta_Info Info);
        bool GrabarDBCbteVtaTipo(Core.ErpSys.Info.Facturacion.fac_cbteVta_tipo_Info Info);
        bool GrabarDBTalonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string idCbteVtaTipo, string IniciaRango, int Rango);
        bool ModificarDBCbteVtaTipo(Core.ErpSys.Info.Facturacion.fac_cbteVta_tipo_Info Info);
    }
}

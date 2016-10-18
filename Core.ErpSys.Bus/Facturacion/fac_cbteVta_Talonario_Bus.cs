using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.Facturacion;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Bus.General;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_cbteVta_Talonario_Bus
    {
        fac_cbteVta_Talonario_Data oDAta = new fac_cbteVta_Talonario_Data();
        public fac_cbteVta_Talonario_Info Get_NumCbteVta_Talonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdCbteVtaTipo)
        {
            try
            {
                return oDAta.Get_NumCbteVta_Talonario(IdEmpresa, IdSucursal, IdPuntoVta, IdCbteVtaTipo);
            }
            catch (Exception)
            {                
                return new  fac_cbteVta_Talonario_Info();
            }
        
        }

        public Boolean GrabarDBTalonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string idCbteVtaTipo, string IniciaRango, int Rango)
        {
            try
            {
                bool Respuesta = false;
                string MensajeError = "";

                Respuesta = validarcamposGrabarDB(IdEmpresa, IdSucursal, IdPuntoVta, idCbteVtaTipo, IniciaRango, Rango, ref MensajeError);

                if (Respuesta)
                {
                    tb_puntoVta_Bus BusPtoVenta = new tb_puntoVta_Bus();
                    tb_puntoVta_Info PtoVenta = BusPtoVenta.Get_Info_PuntoVta(IdEmpresa, IdPuntoVta);
                    tb_sucursal_Bus BusSucursal = new tb_sucursal_Bus();
                    tb_sucursal_Info Sucursal = BusSucursal.Get_Info_Sucursal(IdEmpresa, IdSucursal);

                    if (String.IsNullOrEmpty(PtoVenta.cod_puntoVta))
                    {
                        Respuesta = false;
                        MensajeError = "El Punto de Venta no tiene registrado un código";
                        return Respuesta;
                    }

                    if (String.IsNullOrEmpty(Sucursal.cod_establecimiento ))
                    {
                        Respuesta = false;
                        MensajeError = "La Sucursal no tiene registrado un código de Estblecimiento";
                        return Respuesta;
                    }   

                    return oDAta.GrabarDBTalonario(IdEmpresa, IdSucursal, IdPuntoVta, PtoVenta.cod_puntoVta, Sucursal.cod_establecimiento, idCbteVtaTipo, IniciaRango, Rango);
                }
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }

        }

        private bool validarcamposGrabarDB(int IdEmpresa, int IdSucursal, int IdPuntoVta, string idCbteVtaTipo, string IniciaRango, int Rango, ref string MensajeError)
        {
            try
            {
                bool Respuesta = false;
                #region Validaciones

                if (IdEmpresa == 0)
                {
                    Respuesta = false;
                    MensajeError = "PK no validado Empresa";
                    return Respuesta;
                }
                if (IdSucursal == 0)
                {
                    Respuesta = false;
                    MensajeError = "PK no validados Sucursal,";
                    return Respuesta;
                }
                if (IdPuntoVta  == 0)
                {
                    Respuesta = false;
                    MensajeError = "PK no validados Punto Venta,";
                    return Respuesta;
                }
                if (Rango  <= 0)
                {
                    Respuesta = false;
                    MensajeError = "El rango debe ser mayor a 0,";
                    return Respuesta;
                }
                if (String.IsNullOrEmpty(IniciaRango))
                {
                    Respuesta = false;
                    MensajeError = "El rango inicial no es valido";
                    return Respuesta;
                }               

                #endregion

                return Respuesta;
            }
            catch (Exception)
            {
                
                return false;
            }
        }
    }
}

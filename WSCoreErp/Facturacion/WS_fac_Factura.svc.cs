using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Bus.Facturacion;

namespace WSCoreErp.Facturacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WSFactura" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WSFactura.svc or WSFactura.svc.cs at the Solution Explorer and start debugging.
    public class WSFactura : IWS_fac_Factura
    {
        /// <summary>
        /// fac_cbteVta_Talonario
        /// </summary>
        fac_cbteVta_Talonario_Bus oBusTalon = new fac_cbteVta_Talonario_Bus();
        public fac_cbteVta_Talonario_Info Get_NumCbteVta_Talonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdCbteVtaTipo)
        {
           
                return oBusTalon.Get_NumCbteVta_Talonario(IdEmpresa, IdSucursal, IdPuntoVta, IdCbteVtaTipo);
           
        }
        
        public Boolean GrabarDBTalonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string idCbteVtaTipo, string IniciaRango, int Rango)
        {
            
                return oBusTalon.GrabarDBTalonario(IdEmpresa, IdSucursal, IdPuntoVta, idCbteVtaTipo, IniciaRango, Rango);
           
        }

        /// <summary>
        /// fac_cbteVta
        /// </summary>
        fac_cbteVta_Bus OBus = new fac_cbteVta_Bus();

        public List<fac_cbteVta_Info> Get_List_CbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            try
            {
                return OBus.Get_List_CbteVta(IdEmpresa, IdSucursal, IdPuntoVta);
            }
            catch (Exception)
            {

                return new List<fac_cbteVta_Info>(); ;
            }
        }

        public fac_cbteVta_Info Get_Info_CbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdCbteVta)
        {
            try
            {
                fac_cbteVta_Info Info = new fac_cbteVta_Info();
                Info = OBus.Get_Info_CbteVta(IdEmpresa, IdSucursal, IdPuntoVta, IdCbteVta);
                if (Info.IdEmpresa > 0)
                {
                    fac_cbteVta_det_Bus oBusDet = new fac_cbteVta_det_Bus();
                    Info.List_detalle = oBusDet.Get_List_CbteVta(IdEmpresa, IdCbteVta);
                }
                return Info;
            }
            catch (Exception)
            {

                return new fac_cbteVta_Info();
            }
        }

        public Boolean GrabarDBCbteVta(fac_cbteVta_Info Info)
        {

            try
            {
                bool Respuesta = false;
                string MensajeError = "";

                Respuesta = Validar_Corregir_Objeto(Info, ref MensajeError);

                if (Respuesta)
                {

                    Respuesta = OBus.GrabarDB(Info);
                    if (Respuesta == true)
                    {
                        fac_cbteVta_det_Bus Bus_deta = new fac_cbteVta_det_Bus();

                        Respuesta = Bus_deta.GrabarDB(Info.List_detalle);


                    }
                    else
                    {
                        OBus.EliminarDB(Info.IdEmpresa, Info.IdCbteVtaTipo, Info.IdCbteVta);
                    }
                }


                return Respuesta;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean GetNumCbteVta(ref string Mensaje)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// fac_cbteVta_tipo
        /// </summary>
        fac_cbteVta_tipo_Bus oBusCbteVtaTipo = new fac_cbteVta_tipo_Bus();
        public List<fac_cbteVta_tipo_Info> Get_List_CbteVtaTipo()
        {

            try
            {
                return oBusCbteVtaTipo.Get_List_CbteVtaTipo();
            }
            catch (Exception)
            {

                return new List<fac_cbteVta_tipo_Info>();
            }
        }

        public Boolean GrabarDBCbteVtaTipo(fac_cbteVta_tipo_Info Info)
        {

            try
            {
                return oBusCbteVtaTipo.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean ModificarDBCbteVtaTipo(fac_cbteVta_tipo_Info Info)
        {


            try
            {
                return oBusCbteVtaTipo.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDBCbteVtaTipo(fac_cbteVta_tipo_Info Info)
        {


            try
            {
                return oBusCbteVtaTipo.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }




    }
}

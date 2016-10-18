using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;
using Core.ErpSys.Bus.General;


namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_cliente_Bus
    {
        fac_cliente_Data oData = new fac_cliente_Data();

        public List<fac_cliente_Info> Get_List_Cliente(int IdEmpresa)
        {

            try
            {
                return oData.Get_List_Cliente(IdEmpresa);
            }
            catch (Exception)
            {

                return new List<fac_cliente_Info>();
            }

        }

        public fac_cliente_Info Get_Info_Cliente(int IdEmpresa, decimal  IdCliente)
        {
            try
            {
                fac_cliente_Info Info = new fac_cliente_Info();
                Info = oData.Get_Info_Cliente(IdEmpresa, IdCliente);
                if (Info != null)
                {
                    if (Info.IdEmpresa != 0 && Info.IdCliente != 0)
                    {
                        fac_cliente_contactos_Bus oBusCont = new fac_cliente_contactos_Bus();
                        fac_cliente_pto_emision_cliente_Bus oBusPtoEm = new fac_cliente_pto_emision_cliente_Bus();
                        Info.List_Contactos = oBusCont.Get_List_Contactos(Info.IdEmpresa, Info.IdCliente);
                        Info.List_PtoEmision = oBusPtoEm.Get_List_Cliente_pto_emision_cliente(Info.IdEmpresa, Info.IdCliente);
                    }
                }
                return Info;
            }
            catch (Exception)
            {

                return new fac_cliente_Info();
            }
        }

        public Boolean GrabarDB(fac_cliente_Info Info, ref string MensajeError)
        {
            try
            {
                tb_persona_Bus BusP = new tb_persona_Bus();

                Boolean Respuesta = false;

                /// Validamos cada campo del Info Cliente
                /// 

                Respuesta = Validar_Corregir_Objeto(Info, ref MensajeError);

                if (Info.IdPersona == 0)
                {

                    Respuesta = BusP.GrabarDB(Info.Persona);
                    if (Respuesta == false)
                        return false;

                }

                if (Respuesta)
                {
                    Respuesta = BusP.ModificarDB(Info.Persona);

                    if (Respuesta)
                    {
                        Respuesta = oData.GrabarDB(Info);

                        /// Grabamos despues los contactos y los puntos de emisión.
                        /// 

                        if (Respuesta)
                        {
                            fac_cliente_contactos_Bus oBusContactos = new fac_cliente_contactos_Bus();
                            fac_cliente_pto_emision_cliente_Bus oBusPtoEmision = new fac_cliente_pto_emision_cliente_Bus();

                            foreach (fac_cliente_contactos_Info Contacto in Info.List_Contactos)
                            {
                                oBusContactos.GrabarDB(Contacto);
                            }

                            foreach (fac_cliente_pto_emision_cliente_Info PtoEmision in Info.List_PtoEmision)
                            {
                                oBusPtoEmision.GrabarDB(PtoEmision);
                            }
                        }
                    }
                }
                return Respuesta;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool Validar_Corregir_Objeto(fac_cliente_Info Info ,ref string MensajeError)
        {
            try
            {
                  bool Respuesta = true;
               #region Validaciones

               if ( Info.IdEmpresa == 0 )
               {
                   Respuesta = false;
                   MensajeError = "PK no validado Empresa";
                   return Respuesta;
               }
                if ( Info.IdSucursal ==0 )
               {
                   Respuesta = false;
                   MensajeError = "PK no validados Sucursal,";
                   return Respuesta;
               }               
              
               if (Info.Idtipo_cliente  == 0)
               {
                   Respuesta = false;
                   MensajeError = "Tipo de Cliente no valido";
                   return Respuesta;
               }
               if (string.IsNullOrEmpty(Info.IdTipoCredito))
               {
                   Respuesta = false;
                   MensajeError = "Tipo de Crédito no valido";
                   return Respuesta;
               }
               if (Info.IdPersona  == 0)
               {
                   Respuesta = false;
                   MensajeError = "PK no valido persona.";
                   return Respuesta;
               }
               if (string.IsNullOrEmpty(Info.cod_cliente))
               {
                   Respuesta = false;
                   MensajeError = "Código de Cliente no valido";
                   return Respuesta;
               }
               if (string.IsNullOrEmpty(Info.cat_IdActividadComercial))
               {
                   Respuesta = false;
                   MensajeError = "Actividad Comercial no valida.";
                   return Respuesta;
               }
               if (string.IsNullOrEmpty(Info.cl_Cat_crediticia))
               {
                   Respuesta = false;
                   MensajeError = "Cta Crediticia no valido";
                   return Respuesta;
               }
                if (string.IsNullOrEmpty(Info.IdCiudad))
               {
                   Respuesta = false;
                   MensajeError = "Ciudad no valida";
                   return Respuesta;
               }
                if (string.IsNullOrEmpty(Info.IdParroquia))
               {
                   Respuesta = false;
                   MensajeError = "Parroquia no valida";
                   return Respuesta;
               }
                if (string.IsNullOrEmpty(Info.IdUsuario))
                {
                    Respuesta = false;
                    MensajeError = "Usuario no valido";
                    return Respuesta;
                }
                if (string.IsNullOrEmpty(Info.nom_pc))
                {
                    Respuesta = false;
                    MensajeError = "PC no valida.";
                    return Respuesta;
                } if (string.IsNullOrEmpty(Info.ip))
                {
                    Respuesta = false;
                    MensajeError = "IP no valida.";
                    return Respuesta;
                } 
                
                
               #endregion

               #region Correcciones

                    Info.Observacion = (Info.Observacion == null) ? "" : Info.Observacion;
               
               #endregion


               return Respuesta;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDB(fac_cliente_Info Info, ref string MensajeError)
        {
            try
            {


                tb_persona_Bus BusP = new tb_persona_Bus();

                Boolean Respuesta = false;

                /// Validamos cada campo del Info Cliente
                /// 

                Respuesta = Validar_Corregir_Objeto(Info, ref MensajeError);

               
                if (Respuesta)
                {
                    Respuesta = BusP.ModificarDB(Info.Persona);

                    if (Respuesta)
                    {
                        Respuesta = oData.ModificarDB(Info);

                        /// Grabamos despues los contactos y los puntos de emisión.
                        /// 

                      
                    }
                }
                return Respuesta;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDB(fac_cliente_Info Info)
        {
            try
            {
                return oData.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fac_cliente_contactos_Bus
    {
        fac_cliente_contactos_Data oData = new fac_cliente_contactos_Data();

        public List<fac_cliente_contactos_Info> Get_List_Contactos(int IdEmpresa, decimal  IdCliente)
        {
            try
            {
                return oData.Get_List_Contactos(IdEmpresa, IdCliente);
            }
            catch (Exception)
            {

                return new List<fac_cliente_contactos_Info>();
            }
        }
        public fac_cliente_contactos_Info Get_Info_Contactos(int IdEmpresa, decimal  IdCliente, int IdEmpresa_cont, decimal  IdContacto)
        {
            try
            {
                return oData.Get_Info_Contactos(IdEmpresa, IdCliente, IdEmpresa_cont, IdContacto);
            }
            catch (Exception)
            {

                return new fac_cliente_contactos_Info(); 
            }
        }

        public Boolean GrabarDB(fac_cliente_contactos_Info Info)
        {
            try
            {
                
                return oData.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Boolean ModificarDB(fac_cliente_contactos_Info Info)
        {
            try
            {
                return oData.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }


        }
        public Boolean ValidarObjeto(fac_cliente_contactos_Info Info, ref string MensajeError)
        {
            try
            {
                Boolean Respuesta = false;
                #region Validaciones
                if (Info.IdEmpresa_cli == 0)
                {
                    Respuesta = false;
                    MensajeError = "PK no validado Empresa Cliente";
                    return Respuesta;
                }
                if (Info.IdEmpresa_cont == 0)
                {
                    Respuesta = false;
                    MensajeError = "PK no validado Empresa Contacto,";
                    return Respuesta;
                }
                if (Info.IdCliente == 0)
                {
                    Respuesta = false;
                    MensajeError = "PK Cliente no valido";
                    return Respuesta;
                }
                #endregion

                #region Correcciones
                    Info.observacion = (Info.observacion == null) ? "" : Info.observacion;
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

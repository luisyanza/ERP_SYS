using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.ErpSys.Bus.Facturacion;
using Core.ErpSys.Info.Facturacion;

namespace WSCoreErp.Facturacion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WS_fac_Cliente" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WS_fac_Cliente.svc or WS_fac_Cliente.svc.cs at the Solution Explorer and start debugging.
    public class WS_fac_Cliente : IWS_fac_Cliente
    {


        fac_cliente_Bus oBusCliente = new fac_cliente_Bus();

        public List<fac_cliente_Info> Get_List_Cliente(int IdEmpresa)
        {

            try
            {
                return oBusCliente.Get_List_Cliente(IdEmpresa);
            }
            catch (Exception)
            {

                return new List<fac_cliente_Info>();
            }

        }

        public fac_cliente_Info Get_Info_Cliente(int IdEmpresa, int IdCliente)
        {
            try
            {
                return oBusCliente.Get_Info_Cliente(IdEmpresa, IdCliente);
            }
            catch (Exception)
            {

                return new fac_cliente_Info();
            }
        }

        public Boolean GrabarDB_Cliente(fac_cliente_Info Info, ref string MensajeError)
        {
            try
            {
                return oBusCliente.GrabarDB(Info, ref MensajeError);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDB_Cliente(fac_cliente_Info Info,ref string MensajeError)
        {
            try
            {
                return oBusCliente.ModificarDB(Info, ref MensajeError );
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDB_Cliente(fac_cliente_Info Info)
        {
            try
            {
                return oBusCliente.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        fac_cliente_tipo_Bus oBusClienteTipo = new fac_cliente_tipo_Bus();
        public List<fac_cliente_tipo_Info> Get_List_ClienteTipo(fac_cliente_tipo_Info Info)
        {
            try
            {
                return oBusClienteTipo.Get_List_ClienteTipo(Info);
            }
            catch (Exception)
            {

                return new List<fac_cliente_tipo_Info>();
            }

        }

        public fac_cliente_tipo_Info Get_Info_ClienteTipo(int idEmpresa, int Idtipo_cliente)
        {
            try
            {
                return oBusClienteTipo.Get_Info_ClienteTipo(idEmpresa, Idtipo_cliente);
            }
            catch (Exception)
            {

                return new fac_cliente_tipo_Info();
            }
        }

        public Boolean GrabarDBClienteTipo(fac_cliente_tipo_Info Info)
        {
            try
            {
                return oBusClienteTipo.GrabarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean ModificarDBClienteTipo(fac_cliente_tipo_Info Info)
        {
            try
            {
                return oBusClienteTipo.ModificarDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean AnularDBClienteTipo(fac_cliente_tipo_Info Info)
        {
            try
            {
                return oBusClienteTipo.AnularDB(Info);
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}

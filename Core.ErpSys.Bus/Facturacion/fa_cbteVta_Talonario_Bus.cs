using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.Facturacion;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Bus.Facturacion
{
    public class fa_cbteVta_Talonario_Bus
    {
        fa_cbteVta_Talonario_Data oDAta = new fa_cbteVta_Talonario_Data();
        public fa_cbteVta_Talonario_Info Get_NumCbteVta_Talonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdCbteVtaTipo)
        {
            try
            {
                return oDAta.Get_NumCbteVta_Talonario(IdEmpresa, IdSucursal, IdPuntoVta, IdCbteVtaTipo);
            }
            catch (Exception)
            {                
                return new  fa_cbteVta_Talonario_Info();
            }
        
        }

        public Boolean GrabarDBTalonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string idCbteVtaTipo, string IniciaRango, int Rango)
        {
            try
            {
                 
                return oDAta.GrabarDBTalonario(IdEmpresa, IdSucursal, IdPuntoVta, idCbteVtaTipo, IniciaRango, Rango);
            }
            catch (Exception)
            {
                return false; 
                
            }
        
        }
    }
}

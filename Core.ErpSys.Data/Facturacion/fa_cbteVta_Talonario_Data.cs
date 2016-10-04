using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
namespace Core.ErpSys.Data.Facturacion
{
    public class fa_cbteVta_Talonario_Data
    {

        public List<fa_cbteVta_Talonario_Info> Get_List_fa_cbteVta_Talonario(fa_cbteVta_tipo TipoVta)
        {
            List<fa_cbteVta_Talonario_Info> ListInfo = new List<fa_cbteVta_Talonario_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fa_cbteVta_Talonario
                              where q.IdEmpresa == TipoVta.IdEmpresa && q.IdCbteVtaTipo == TipoVta.IdCbteVtaTipo 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fa_cbteVta_Talonario_Info(item.IdEmpresa, item.IdSucursal, item.IdPuntoVta, item.IdCbteVtaTipo, item.num_CbteVta, item.num_autorizacion, item.usado));
                }

            }
            catch (Exception)
            {
                return new List<fa_cbteVta_Talonario_Info>();
            }

            return ListInfo;
        }

        public fa_cbteVta_Talonario_Info Get_NumCbteVta_Talonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdCbteVtaTipo)
        {
            fa_cbteVta_Talonario_Info Info = new fa_cbteVta_Talonario_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                fa_cbteVta_Talonario item = OBase.fa_cbteVta_Talonario.OrderBy(x => x.num_CbteVta).
                                                        First(c => c.IdEmpresa == IdEmpresa && c.IdSucursal == IdSucursal && c.IdPuntoVta == IdPuntoVta
                                                                && c.IdCbteVtaTipo == IdCbteVtaTipo && c.usado == false);

                if (item != null)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdPuntoVta = item.IdPuntoVta;
                    Info.IdCbteVtaTipo = item.IdCbteVtaTipo;
                    Info.num_CbteVta = item.num_CbteVta;
                    Info.num_autorizacion = item.num_autorizacion;
                    Info.usado = item.usado;

                }
              
            }
            catch (Exception)
            {
                return new fa_cbteVta_Talonario_Info();
            }

            return Info;
        }

        public Boolean ValidaNumCbteVtaUsado(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdCbteVtaTipo, string num_CbteVta)
        {
            try
            {
                Entities_Facturacion oBase = new Entities_Facturacion();

                IQueryable<fa_cbteVta_Talonario>  selectq = from q in oBase.fa_cbteVta_Talonario
                                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                                                      && q.IdCbteVtaTipo == IdCbteVtaTipo && q.num_CbteVta == num_CbteVta
                                              select q;
                if (selectq != null)
                {
                    foreach (var item in selectq)
                    {
                        if (item.usado == false)
                            return true;
                        else
                            return false;
                    }

                    return false;
                }
                else return false;
            }
            catch (Exception)
            {

                return false;
            }
                   
        }
        public Boolean ValidarExistaNumCbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta, string idCbteVtaTipo, string IniciaRango )
        {
            try
            {
                Entities_Facturacion oBase = new Entities_Facturacion();

                var selectq = from q in oBase.fa_cbteVta_Talonario
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                                    && q.IdCbteVtaTipo == idCbteVtaTipo && q.num_CbteVta == IniciaRango 
                              select q;

                foreach (var item in selectq)
                {
                    return true;
                }
                return false ;
            }
            catch (Exception)
            {

                return false;
            }
        
        }
        public  Boolean GrabarDBTalonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string idCbteVtaTipo, string IniciaRango, int Rango)
        {
            try
            {
                if (ValidarExistaNumCbteVta(IdEmpresa, IdSucursal, IdPuntoVta, idCbteVtaTipo, IniciaRango))
                {
                    
                    using (Entities_Facturacion context = new Entities_Facturacion())
                    {
                        string EstPtoVta = IniciaRango.Substring(0, 8);
                        IniciaRango = IniciaRango.Substring(9, IniciaRango.Length); 
                        int inicio = Convert.ToInt32(IniciaRango);
                        int lenght = IniciaRango.Length;
                        int fin = inicio + Rango;

                        for (int i = inicio; i <= fin; i++)
                        {
                            var addressG = new fa_cbteVta_Talonario();

                            string NumCbteVta = EstPtoVta+ i.ToString().PadLeft(lenght,'0');

                            addressG.IdEmpresa = IdEmpresa;
                            addressG.IdSucursal = IdSucursal;
                            addressG.IdPuntoVta = IdPuntoVta;
                            addressG.IdCbteVtaTipo = idCbteVtaTipo;
                            addressG.num_CbteVta = NumCbteVta;
                            addressG.num_autorizacion = null;
                            addressG.usado = false;

                            context.fa_cbteVta_Talonario.Add(addressG);
                            context.SaveChanges();
                        }

                        return true;

                    }
                }
                else return false;
            }
            catch (Exception)
            {
                return false ;
            }
        
        }


    }
}

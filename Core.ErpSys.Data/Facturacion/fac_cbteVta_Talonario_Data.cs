using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_cbteVta_Talonario_Data
    {

        public List<fac_cbteVta_Talonario_Info> Get_List_fac_cbteVta_Talonario(fac_cbteVta_tipo TipoVta)
        {
            List<fac_cbteVta_Talonario_Info> ListInfo = new List<fac_cbteVta_Talonario_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cbteVta_Talonario
                              where q.IdEmpresa == TipoVta.IdEmpresa && q.IdCbteVtaTipo == TipoVta.IdCbteVtaTipo 
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_cbteVta_Talonario_Info(item.IdEmpresa, item.IdSucursal, item.IdPuntoVta, item.IdCbteVtaTipo, item.num_CbteVta, item.num_autorizacion));//, item.usado));
                }

            }
            catch (Exception)
            {
                return new List<fac_cbteVta_Talonario_Info>();
            }

            return ListInfo;
        }

        public fac_cbteVta_Talonario_Info Get_NumCbteVta_Talonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdCbteVtaTipo)
        {
            fac_cbteVta_Talonario_Info Info = new fac_cbteVta_Talonario_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                fac_cbteVta_Talonario item = OBase.fac_cbteVta_Talonario.OrderBy(x => x.num_CbteVta).
                                                        First(c => c.IdEmpresa == IdEmpresa && c.IdSucursal == IdSucursal && c.IdPuntoVta == IdPuntoVta
                                                                && c.IdCbteVtaTipo == IdCbteVtaTipo ); //&& c.usado == false);

                if (item != null)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdPuntoVta = item.IdPuntoVta;
                    Info.IdCbteVtaTipo = item.IdCbteVtaTipo;
                    Info.num_CbteVta = item.num_CbteVta;
                    Info.num_autorizacion = item.num_autorizacion;
                   // Info.usado = item.usado;

                }
              
            }
            catch (Exception)
            {
                return new fac_cbteVta_Talonario_Info();
            }

            return Info;
        }

        public Boolean ValidaNumCbteVtaUsado(int IdEmpresa, int IdSucursal, int IdPuntoVta, string IdCbteVtaTipo, string num_CbteVta)
        {
            try
            {
                Entities_Facturacion oBase = new Entities_Facturacion();

                IQueryable<fac_cbteVta_Talonario>  selectq = from q in oBase.fac_cbteVta_Talonario
                                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                                                      && q.IdCbteVtaTipo == IdCbteVtaTipo && q.num_CbteVta == num_CbteVta 
                                              select q;
                if (selectq != null)
                {
                    foreach (var item in selectq)
                    {
                        //if (item.usado == false)
                        //    return true;
                        //else
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

                var selectq = from q in oBase.fac_cbteVta_Talonario
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
        public  Boolean GrabarDBTalonario(int IdEmpresa, int IdSucursal, int IdPuntoVta, string Establecimiento, string NumSerie, string idCbteVtaTipo, string IniciaRango, int Rango)
        {
            try
            {
                if (ValidarExistaNumCbteVta(IdEmpresa, IdSucursal, IdPuntoVta, idCbteVtaTipo, IniciaRango))
                {
                    
                    using (Entities_Facturacion context = new Entities_Facturacion())
                    {
                        
                       // string EstPtoVta = IniciaRango.Substring(0, 8);
                        IniciaRango = IniciaRango.Substring(9, IniciaRango.Length); 
                        int inicio = Convert.ToInt32(IniciaRango);
                        int lenght = IniciaRango.Length;
                        int fin = inicio + Rango;

                        for (int i = inicio; i <= fin; i++)
                        {
                            var addressG = new fac_cbteVta_Talonario();

                            string NumCbteVta = Establecimiento + "-" + NumSerie + "-" + i.ToString().PadLeft(lenght, '0');

                            addressG.IdEmpresa = IdEmpresa;
                            addressG.IdSucursal = IdSucursal;
                            addressG.IdPuntoVta = IdPuntoVta;
                            addressG.IdCbteVtaTipo = idCbteVtaTipo;
                            addressG.num_CbteVta = NumCbteVta;
                            addressG.num_autorizacion = null;
                            //  addressG.usado = false;

                            context.fac_cbteVta_Talonario.Add(addressG);
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

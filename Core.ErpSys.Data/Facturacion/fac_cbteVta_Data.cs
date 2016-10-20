using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;
using Core.ErpSys.Data.Facturacion;



namespace Core.ErpSys.Data.Facturacion
{
   public class fac_cbteVta_Data
    {

        public List<fac_cbteVta_Info> Get_List_CbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta)
        {
            List<fac_cbteVta_Info> ListInfo = new List<fac_cbteVta_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cbteVta
                              where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_cbteVta_Info(item.IdEmpresa,item.IdCbteVtaTipo,item.IdCbteVta,item.CodCbteVta,item.num_CbteVta,
                                                        item.IdSucursal,item.IdPuntoVta,item.IdTipoNota,item.IdCaja,item.IdCliente,
                                                        item.estado,item.vt_Observacion,item.Fecha_Autorizacion,item.num_autorizacion,item.vt_plazo,
                                                        item.vt_fecha_venc,item.vt_fecha));

                }

            }
            catch (Exception)
            {
                return new List<fac_cbteVta_Info>();
            }

            return ListInfo;
        }

        public fac_cbteVta_Info Get_Info_CbteVta(int IdEmpresa, int IdSucursal, int IdPuntoVta, decimal IdCbteVta)
        {
            fac_cbteVta_Info Info = new fac_cbteVta_Info();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_cbteVta
                              where q.IdCbteVta == IdCbteVta && q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdPuntoVta == IdPuntoVta
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdCbteVtaTipo = item.IdCbteVtaTipo;
                    Info.IdCbteVta = item.IdCbteVta;
                    Info.CodCbteVta = item.CodCbteVta;
                    Info.num_CbteVta = item.num_CbteVta;
                    Info.IdSucursal = item.IdSucursal;
                    Info.IdPuntoVta = item.IdPuntoVta;
                    Info.IdTipoNota = item.IdTipoNota;
                    Info.IdCaja = item.IdCaja;
                    Info.IdCliente = item.IdCliente;
                    Info.estado = item.estado;
                    Info.vt_Observacion = item.vt_Observacion;
                    Info.Fecha_Autorizacion = item.Fecha_Autorizacion;
                    Info.num_autorizacion = item.num_autorizacion;
                    Info.vt_plazo = item.vt_plazo;
                    Info.vt_fecha_venc = item.vt_fecha_venc;
                    Info.vt_fecha = item.vt_fecha;

                }
            }
            catch (Exception)
            {
                return new fac_cbteVta_Info();
            }

            return Info;

        }


       public Boolean GrabarDB(fac_cbteVta_Info Info)
       {
           try
           {
               using (Entities_Facturacion context = new Entities_Facturacion())
               {


                   var addressG = new fac_cbteVta();
                   
                   addressG.IdEmpresa = Info.IdEmpresa;
                   addressG.IdCbteVtaTipo = Info.IdCbteVtaTipo;
                   addressG.IdCbteVta = Info.IdCbteVta= Get_IdCbteVta(Info.IdEmpresa, Info.IdCbteVtaTipo);
                   addressG.CodCbteVta = Info.CodCbteVta;
                   addressG.num_CbteVta = Info.num_CbteVta;
                   addressG.IdSucursal = Info.IdSucursal;
                   addressG.IdPuntoVta = Info.IdPuntoVta;
                   addressG.IdTipoNota = Info.IdTipoNota;
                   addressG.IdCaja = Info.IdCaja;
                   addressG.IdCliente = Info.IdCliente;
                   addressG.estado = Info.estado;
                   addressG.vt_Observacion = Info.vt_Observacion;
                   addressG.Fecha_Autorizacion = Info.Fecha_Autorizacion;
                   addressG.num_autorizacion = Info.num_autorizacion;
                   addressG.vt_plazo = Info.vt_plazo;
                   addressG.vt_fecha_venc = Info.vt_fecha_venc;
                   addressG.vt_fecha = Info.vt_fecha;
                   context.fac_cbteVta.Add(addressG);
                   context.SaveChanges();

               }
           }
           catch (Exception)
           {
               return false;
           }

           return true;

       }

       public Boolean EliminarDB(int IdEmpresa, string IdTipoCbteVta, decimal IdCbte)
       {
           try
           {
               bool respuesta = false;
               using (Entities_Facturacion context = new Entities_Facturacion())
               {
                   var contact = context.fac_cbteVta.First(cbte => cbte.IdCbteVta == IdCbte && cbte.IdCbteVtaTipo == IdTipoCbteVta && cbte.IdEmpresa == IdEmpresa);

                   if (contact != null)
                   {
                       context.fac_cbteVta.Remove(contact);
                       
                   }
                   respuesta = true;
               }
               return respuesta;
           }
           catch (Exception)
           {
               return false;
           }
       }

       public decimal Get_IdCbteVta(int IdEmpresa, string IdTipoCbteVta)
       {
           decimal IdCbteVta;
           try
           {

               Entities_Facturacion base_ = new Entities_Facturacion();

               var CbteVta = from Cl in base_.fac_cbteVta
                              where Cl.IdEmpresa == IdEmpresa
                              select Cl;

               if (CbteVta.ToList().Count == 0)

                   return 1;

               else
               {
                   var select = (from T in base_.fac_cbteVta
                                  where T.IdEmpresa == IdEmpresa
                                  select T.IdCbteVta).Max();
                   IdCbteVta = select + 1;
                   return IdCbteVta;
               }
           }
           catch (Exception ex)
           {
               
               return 0;
           }
       }

      



    }
}

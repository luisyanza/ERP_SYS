using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_TerminoPago_Distribucion_Data
    {


        public List<fac_TerminoPago_Distribucion_Info> Get_List_TerminoPago_Distribucion(string  IdTerminoPago)
        {
            List<fac_TerminoPago_Distribucion_Info> ListInfo = new List<fac_TerminoPago_Distribucion_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_TerminoPago_Distribucion
                              where q.IdTerminoPago == IdTerminoPago  
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_TerminoPago_Distribucion_Info(item.IdTerminoPago, item.Secuencia, item.Num_Dias_Vcto, item.Por_distribucion));
                }

            }
            catch (Exception)
            {
                return new List<fac_TerminoPago_Distribucion_Info>();
            }

            return ListInfo;
        }

        public Boolean GrabarDB(fac_TerminoPago_Distribucion_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_TerminoPago_Distribucion();
                    addressG.IdTerminoPago = Info.IdTerminoPago;
                    addressG.Secuencia = Info.Secuencia;
                    addressG.Num_Dias_Vcto = Info.Num_Dias_Vcto;
                    addressG.Por_distribucion = Info.Por_distribucion;
                    context.fac_TerminoPago_Distribucion.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_TerminoPago_Distribucion_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_TerminoPago_Distribucion.FirstOrDefault(cot => cot.IdTerminoPago == Info.IdTerminoPago && cot.Secuencia == Info.Secuencia );

                    if (contact != null)
                    {
                        contact.Secuencia = Info.Secuencia;
                        contact.Num_Dias_Vcto = Info.Num_Dias_Vcto;
                        contact.Por_distribucion = Info.Por_distribucion;


                        context.SaveChanges();
                    }
                    else
                        return false;
                }
            }
            catch (Exception)
            {

                return false;
            }

            return true;

        }
    }
}

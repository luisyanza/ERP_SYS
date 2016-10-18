using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_TerminoPago_Data
    {

        public List<fac_TerminoPago_Info> Get_List_TerminoPago(fac_TerminoPago_Info Info)
        {
            List<fac_TerminoPago_Info> ListInfo = new List<fac_TerminoPago_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_TerminoPago

                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_TerminoPago_Info(item.IdTerminoPago,	item.nom_TerminoPago,	item.Num_Coutas,	item.Dias_Vct));
                }

            }
            catch (Exception)
            {
                return new List<fac_TerminoPago_Info>();
            }

            return ListInfo;
        }

        public Boolean GrabarDB(fac_TerminoPago_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_TerminoPago();
                    addressG.IdTerminoPago = Info.IdTerminoPago;
                    addressG.nom_TerminoPago = Info.nom_TerminoPago;
                    addressG.Num_Coutas = Info.Num_Coutas;
                    addressG.Dias_Vct = Info.Dias_Vct;
                    context.fac_TerminoPago.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_TerminoPago_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_TerminoPago.FirstOrDefault(cot => cot.IdTerminoPago == Info.IdTerminoPago);

                    if (contact != null)
                    {
                        contact.nom_TerminoPago = Info.nom_TerminoPago;
                        contact.Num_Coutas = Info.Num_Coutas;
                        contact.Dias_Vct = Info.Dias_Vct;

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

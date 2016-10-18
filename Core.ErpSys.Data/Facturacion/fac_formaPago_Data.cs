using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fac_formaPago_Data
    {
        public List<fac_formaPago_Info> Get_List_FormaPago(fac_formaPago_Info Info)
        {
            List<fac_formaPago_Info> ListInfo = new List<fac_formaPago_Info>();

            try
            {

                Entities_Facturacion OBase = new Entities_Facturacion();

                var selectq = from q in OBase.fac_formaPago
                              
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new fac_formaPago_Info(item.IdFormaPago,item.nom_FormaPago ));
                }

            }
            catch (Exception)
            {
                return new List<fac_formaPago_Info>();
            }

            return ListInfo;
        }

        public Boolean GrabarDB(fac_formaPago_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {


                    var addressG = new fac_formaPago();
                    addressG.IdFormaPago = Info.IdFormaPago;
                    addressG.nom_FormaPago = Info.nom_FormaPago;
                    context.fac_formaPago.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }

        public Boolean ModificarDB(fac_formaPago_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var contact = context.fac_formaPago.FirstOrDefault(cot => cot.IdFormaPago == Info.IdFormaPago);

                    if (contact != null)
                    {
                        contact.nom_FormaPago = Info.nom_FormaPago;
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

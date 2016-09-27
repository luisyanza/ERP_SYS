using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Facturacion;

namespace Core.ErpSys.Data.Facturacion
{
    public class fa_cbteVta_tipo_Data
    {
        public List<fa_cbteVta_tipo_Info> Get_List_CbteVtaTipo()
        {
            List<fa_cbteVta_tipo_Info> ListInfo = new List<fa_cbteVta_tipo_Info>();
            try
            {
                Entities_Facturacion oBase = new Entities_Facturacion();

                IQueryable<fa_cbteVta_tipo> selectq = from q in oBase.fa_cbteVta_tipo
                                                       select q;

                foreach (fa_cbteVta_tipo item in selectq)
                {
                    ListInfo.Add(new fa_cbteVta_tipo_Info(item.IdEmpresa,	item.IdCbteVtaTipo,	item.nom_CbteVtaTipo,	item.estado));

                }

            }
            catch (Exception)
            {

                return new List<fa_cbteVta_tipo_Info>();
            }
            return ListInfo;

        }
        public Boolean GrabarDB(fa_cbteVta_tipo_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {
                    var addressG = new fa_cbteVta_tipo();
                    addressG.IdEmpresa = Info.IdEmpresa;
                    addressG.IdCbteVtaTipo = Info.IdCbteVtaTipo;
                    addressG.nom_CbteVtaTipo = Info.nom_CbteVtaTipo;
                    addressG.estado = true;
                    context.fa_cbteVta_tipo.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public Boolean ModificarDB(fa_cbteVta_tipo_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {

                    fa_cbteVta_tipo contact = context.fa_cbteVta_tipo.First(cot => cot.IdCbteVtaTipo == Info.IdCbteVtaTipo);

                    if (contact != null)
                    {

                        contact.nom_CbteVtaTipo = Info.nom_CbteVtaTipo;

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
        public Boolean AnularDB(fa_cbteVta_tipo_Info Info)
        {
            try
            {
                using (Entities_Facturacion context = new Entities_Facturacion())
                {

                    fa_cbteVta_tipo contact = context.fa_cbteVta_tipo.First(cot => cot.IdCbteVtaTipo == Info.IdCbteVtaTipo);

                    if (contact != null)
                    {

                        contact.estado = false;

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

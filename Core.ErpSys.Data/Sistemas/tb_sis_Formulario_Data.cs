using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.Sistemas;

namespace Core.ErpSys.Data.Sistemas
{
    public class tb_sis_Formulario_Data
    {
        public List<tb_sis_Formulario_Info> Get_List_Formulario()
        {
            List<tb_sis_Formulario_Info> ListInfo = new List<tb_sis_Formulario_Info>();

            try
            {

                Entities_Sistemas OBase = new Entities_Sistemas();

                var selectq = from q in OBase.tb_sis_Formulario
                              select q;

                foreach (var item in selectq)
                {
                    ListInfo.Add(new tb_sis_Formulario_Info(item.IdForm, item.nom_form, item.estado, item.titulo));
                }


            }
            catch (Exception)
            {
                return new List<tb_sis_Formulario_Info>();
            }

            return ListInfo;
        }

        public tb_sis_Formulario_Info Get_Info_Formulario(string IdFormulario)
        {
            tb_sis_Formulario_Info Info = new tb_sis_Formulario_Info();

            try
            {
                
                Entities_Sistemas OBase = new Entities_Sistemas();

                var selectq = from q in OBase.tb_sis_Formulario
                              where q.IdForm == IdFormulario
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdForm = item.IdForm;
                    Info.nom_form = item.nom_form;
                    Info.estado = item.estado;
                    Info.titulo = item.titulo;

                }
            }
            catch (Exception)
            {
                return new tb_sis_Formulario_Info();
            }

            return Info;

        }

        public Boolean GrabarDB(tb_sis_Formulario_Info Info)
        {
            try
            {
                using (Entities_Sistemas context = new Entities_Sistemas())
                {
                    
                    var addressG = new tb_sis_Formulario();
                    addressG.IdForm = Info.IdForm;
                    addressG.nom_form = Info.nom_form;
                    addressG.estado = true;
                    addressG.titulo = Info.titulo;
                    context.tb_sis_Formulario.Add(addressG);
                    context.SaveChanges();

                }
            }
            catch (Exception)
            {
                return false;
            }
            
            return true;

        }

        public Boolean ModificarDB(tb_sis_Formulario_Info Info)
        {
            try
            {
                using (Entities_Sistemas context = new Entities_Sistemas())
                {
                    var contact = context.tb_sis_Formulario.FirstOrDefault(cot => cot.IdForm == Info.IdForm);

                    if (contact != null)
                    {
                        contact.nom_form = Info.nom_form;
                        contact.titulo = Info.titulo;
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }

            return true;

        }

        public Boolean AnularDB(tb_sis_Formulario_Info Info)
        {
            try
            {
                using (Entities_Sistemas context = new Entities_Sistemas())
                {
                    var contact = context.tb_sis_Formulario.FirstOrDefault(cot => cot.IdForm == Info.IdForm);
                    if (contact != null)
                    {
                        contact.estado = false;
                        context.SaveChanges();
                    }
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

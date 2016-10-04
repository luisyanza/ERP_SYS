using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.General;

namespace Core.ErpSys.Data.General
{
    public class tb_persona_Data
    {

        public List<tb_persona_Info> Get_List_Personas() {

            List<tb_persona_Info> ListInfo = new List<tb_persona_Info>();
            try
            {
                Entities_General OBAse = new Entities_General();
                IQueryable<tb_persona>  select = from q in OBAse.tb_persona
                             select q;

                foreach (tb_persona  item in select )
                {
                   
                    
                    ListInfo.Add(new tb_persona_Info(item.IdPersona, item.cod_persona , item.nombre , item.apellido 
                        ,item.razon_social,  item.IdTipoDocumento ,item.Num_documento, item.IdTipoPersona ,item.estado));
                    
                }

            }
            catch (Exception)
            {
                
                return new List<tb_persona_Info>();
            }
            return ListInfo;

        }
        public tb_persona_Info Get_Info_Persona(string NumDocumento)
        {

            tb_persona_Info InfoNew = new tb_persona_Info();
            try
            {
                Entities_General OBase = new Entities_General();

                var selectq = from q in OBase.tb_persona
                              where q.Num_documento == NumDocumento 
                              select q;

                foreach (var item in selectq)
                {
                    InfoNew.IdPersona = item.IdPersona;
                    InfoNew.cod_persona = item.cod_persona;
                    InfoNew.nombre = item.nombre;
                    InfoNew.apellido = item.apellido;
                    InfoNew.razon_social = item.razon_social;
                    InfoNew.IdTipoDocumento = item.IdTipoDocumento;
                    InfoNew.Num_documento = item.Num_documento;
                    InfoNew.IdTipoPersona = item.IdTipoPersona;
                    InfoNew.estado = item.estado;

                }
            }
            catch (Exception)
            {

                return new tb_persona_Info();
            }
            return InfoNew;
        }

        public tb_persona_Info Get_Info_Persona(tb_persona_Info Info)
        {

            tb_persona_Info InfoNew = new tb_persona_Info();
            try
            {
                   Entities_General  OBase = new Entities_General();

                    var selectq = from q in OBase.tb_persona 
                                  where q.IdPersona   == Info.IdPersona  
                                  select q;

                    foreach (var item in selectq)
                    {
                        InfoNew.IdPersona = item.IdPersona;
                        InfoNew.cod_persona = item.cod_persona;
                        InfoNew.nombre = item.nombre;
                        InfoNew.apellido = item.apellido;
                        InfoNew.razon_social = item.razon_social;
                        InfoNew.IdTipoDocumento = item.IdTipoDocumento;
                        InfoNew.Num_documento = item.Num_documento;
                        InfoNew.IdTipoPersona = item.IdTipoPersona;
                        InfoNew.estado = item.estado;

                    }
            }
            catch (Exception)
            {

                return new tb_persona_Info();
            }
            return InfoNew;
        }
        public Boolean GrabarDB(tb_persona_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    var address = new tb_persona();
                    address.IdPersona = Info.IdPersona;
                    address.cod_persona = Info.cod_persona;
                    address.nombre = Info.nombre;
                    address.apellido = Info.apellido;
                    address.razon_social = Info.razon_social;
                    address.IdTipoDocumento = Info.IdTipoDocumento;
                    address.Num_documento = Info.Num_documento;
                    address.IdTipoPersona = Info.IdTipoPersona;
                    address.estado = true;
                    context.tb_persona.Add(address);
                    context.SaveChanges();
                }

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public Boolean ModificarDB(tb_persona_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    
                      
                    var contact = context.tb_persona.First(cot => cot.IdPersona == Info.IdPersona);

                    if (contact != null)
                    {

                        contact.IdPersona = Info.IdPersona;
                        contact.cod_persona = Info.cod_persona;
                        contact.nombre = Info.nombre;
                        contact.apellido = Info.apellido;
                        contact.razon_social = Info.razon_social;
                        contact.IdTipoDocumento = Info.IdTipoDocumento;
                        contact.Num_documento = Info.Num_documento;
                        contact.IdTipoPersona = Info.IdTipoPersona;
                        contact.estado = true;
                        context.tb_persona.Add(contact);
                        context.SaveChanges();
                    }
                    else return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public Boolean AnularDB(tb_persona_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {


                    var contact = context.tb_persona.First(cot => cot.IdPersona == Info.IdPersona);

                    if (contact != null)
                    {

                        contact.estado = false ;
                        context.tb_persona.Add(contact);
                        context.SaveChanges();
                    }
                    else return false;
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

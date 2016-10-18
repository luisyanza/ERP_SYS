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

                foreach (tb_persona item in select)
                {


                    ListInfo.Add(new tb_persona_Info(item.IdPersona, item.cod_persona, item.pe_nombreCompleto, item.pe_nombre, item.pe_apellido, item.pe_razon_social, item.IdTipoDocumento,
                                                        item.Num_documento, item.IdTipoPersona, item.estado, item.pe_Naturaleza_cat, item.pe_sexo, item.IdEstadoCivil_cat,
                                                        item.pe_fechaNacimiento, item.pe_correo, item.pe_correo1, item.pe_correo2, item.pe_telef_Casa, item.pe_telef_Trab,
                                                        item.pe_telef_Contacto, item.pe_direccion, item.pe_fax, item.pe_casilla, item.IdTipoCta_acreditacion_cat, item.num_cta_acreditacion, item.IdBanco_acreditacion));
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

            tb_persona_Info Info = new tb_persona_Info();
            try
            {
                Entities_General OBase = new Entities_General();

                var selectq = from q in OBase.tb_persona
                              where q.Num_documento == NumDocumento 
                              select q;

                foreach (var item in selectq)
                {
                    Info.IdPersona = item.IdPersona;
                    Info.cod_persona = item.cod_persona;
                    Info.pe_nombreCompleto = item.pe_nombreCompleto;
                    Info.pe_nombre = item.pe_nombre;
                    Info.pe_apellido = item.pe_apellido;
                    Info.pe_razon_social = item.pe_razon_social;
                    Info.IdTipoDocumento = item.IdTipoDocumento;
                    Info.Num_documento = item.Num_documento;
                    Info.IdTipoPersona = item.IdTipoPersona;
                    Info.estado = item.estado;
                    Info.pe_Naturaleza_cat = item.pe_Naturaleza_cat;
                    Info.pe_sexo = item.pe_sexo;
                    Info.IdEstadoCivil_cat = item.IdEstadoCivil_cat;
                    Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    Info.pe_correo = item.pe_correo;
                    Info.pe_correo1 = item.pe_correo1;
                    Info.pe_correo2 = item.pe_correo2;
                    Info.pe_telef_Casa = item.pe_telef_Casa;
                    Info.pe_telef_Trab = item.pe_telef_Trab;
                    Info.pe_telef_Contacto = item.pe_telef_Contacto;
                    Info.pe_direccion = item.pe_direccion;
                    Info.pe_fax = item.pe_fax;
                    Info.pe_casilla = item.pe_casilla;
                    Info.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                    Info.num_cta_acreditacion = item.num_cta_acreditacion;
                    Info.IdBanco_acreditacion = item.IdBanco_acreditacion;


                }
            }
            catch (Exception)
            {

                return new tb_persona_Info();
            }
            return Info;
        }

        public tb_persona_Info Get_Info_Persona(tb_persona_Info Info)
        {

            tb_persona_Info Infonew = new tb_persona_Info();
            try
            {
                   Entities_General  OBase = new Entities_General();

                    var selectq = from q in OBase.tb_persona 
                                  where q.IdPersona   == Info.IdPersona  
                                  select q;

                    foreach (var item in selectq)
                    {
                        Infonew.IdPersona = item.IdPersona;
                        Infonew.cod_persona = item.cod_persona;
                        Infonew.pe_nombreCompleto = item.pe_nombreCompleto;
                        Infonew.pe_nombre = item.pe_nombre;
                        Infonew.pe_apellido = item.pe_apellido;
                        Infonew.pe_razon_social = item.pe_razon_social;
                        Infonew.IdTipoDocumento = item.IdTipoDocumento;
                        Infonew.Num_documento = item.Num_documento;
                        Infonew.IdTipoPersona = item.IdTipoPersona;
                        Infonew.estado = item.estado;
                        Infonew.pe_Naturaleza_cat = item.pe_Naturaleza_cat;
                        Infonew.pe_sexo = item.pe_sexo;
                        Infonew.IdEstadoCivil_cat = item.IdEstadoCivil_cat;
                        Infonew.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        Infonew.pe_correo = item.pe_correo;
                        Infonew.pe_correo1 = item.pe_correo1;
                        Infonew.pe_correo2 = item.pe_correo2;
                        Infonew.pe_telef_Casa = item.pe_telef_Casa;
                        Infonew.pe_telef_Trab = item.pe_telef_Trab;
                        Infonew.pe_telef_Contacto = item.pe_telef_Contacto;
                        Infonew.pe_direccion = item.pe_direccion;
                        Infonew.pe_fax = item.pe_fax;
                        Infonew.pe_casilla = item.pe_casilla;
                        Infonew.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                        Infonew.num_cta_acreditacion = item.num_cta_acreditacion;
                        Infonew.IdBanco_acreditacion = item.IdBanco_acreditacion;


                    }
            }
            catch (Exception)
            {

                return new tb_persona_Info();
            }
            return Infonew;
        }
        public Boolean GrabarDB(tb_persona_Info Info)
        {
            try
            {
                using (Entities_General context = new Entities_General())
                {
                    var addressG = new tb_persona();
                    addressG.IdPersona = Info.IdPersona;
                    addressG.cod_persona = Info.cod_persona;
                    addressG.pe_nombreCompleto = Info.pe_nombreCompleto;
                    addressG.pe_nombre = Info.pe_nombre;
                    addressG.pe_apellido = Info.pe_apellido;
                    addressG.pe_razon_social = Info.pe_razon_social;
                    addressG.IdTipoDocumento = Info.IdTipoDocumento;
                    addressG.Num_documento = Info.Num_documento;
                    addressG.IdTipoPersona = Info.IdTipoPersona;
                    addressG.pe_Naturaleza_cat = Info.pe_Naturaleza_cat;
                    addressG.pe_sexo = Info.pe_sexo;
                    addressG.IdEstadoCivil_cat = Info.IdEstadoCivil_cat;
                    addressG.pe_fechaNacimiento = Info.pe_fechaNacimiento;
                    addressG.pe_correo = Info.pe_correo;
                    addressG.pe_correo1 = Info.pe_correo1;
                    addressG.pe_correo2 = Info.pe_correo2;
                    addressG.pe_telef_Casa = Info.pe_telef_Casa;
                    addressG.pe_telef_Trab = Info.pe_telef_Trab;
                    addressG.pe_telef_Contacto = Info.pe_telef_Contacto;
                    addressG.pe_direccion = Info.pe_direccion;
                    addressG.pe_fax = Info.pe_fax;
                    addressG.pe_casilla = Info.pe_casilla;
                    addressG.IdTipoCta_acreditacion_cat = Info.IdTipoCta_acreditacion_cat;
                    addressG.num_cta_acreditacion = Info.num_cta_acreditacion;
                    addressG.IdBanco_acreditacion = Info.IdBanco_acreditacion;
                    addressG.estado = true;
                    context.tb_persona.Add(addressG);
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

                        contact.cod_persona = Info.cod_persona;
                        contact.pe_nombreCompleto = Info.pe_nombreCompleto;
                        contact.pe_nombre = Info.pe_nombre;
                        contact.pe_apellido = Info.pe_apellido;
                        contact.pe_razon_social = Info.pe_razon_social;
                        contact.IdTipoDocumento = Info.IdTipoDocumento;
                        contact.Num_documento = Info.Num_documento;
                        contact.IdTipoPersona = Info.IdTipoPersona;
                        contact.estado = Info.estado;
                        contact.pe_Naturaleza_cat = Info.pe_Naturaleza_cat;
                        contact.pe_sexo = Info.pe_sexo;
                        contact.IdEstadoCivil_cat = Info.IdEstadoCivil_cat;
                        contact.pe_fechaNacimiento = Info.pe_fechaNacimiento;
                        contact.pe_correo = Info.pe_correo;
                        contact.pe_correo1 = Info.pe_correo1;
                        contact.pe_correo2 = Info.pe_correo2;
                        contact.pe_telef_Casa = Info.pe_telef_Casa;
                        contact.pe_telef_Trab = Info.pe_telef_Trab;
                        contact.pe_telef_Contacto = Info.pe_telef_Contacto;
                        contact.pe_direccion = Info.pe_direccion;
                        contact.pe_fax = Info.pe_fax;
                        contact.pe_casilla = Info.pe_casilla;
                        contact.IdTipoCta_acreditacion_cat = Info.IdTipoCta_acreditacion_cat;
                        contact.num_cta_acreditacion = Info.num_cta_acreditacion;
                        contact.IdBanco_acreditacion = Info.IdBanco_acreditacion;

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

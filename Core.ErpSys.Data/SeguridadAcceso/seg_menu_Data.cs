using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Info.SeguridadAcceso;

namespace Core.ErpSys.Data.SeguridadAcceso
{
    public class seg_menu_Data
    {


        public List<seg_menu_Info> Get_List_Menu()
            {
                List<seg_menu_Info> ListInfo = new List<seg_menu_Info>();

                try
                {

                    Entities_Seguridad_Accesos  OBase = new Entities_Seguridad_Accesos();

                    var selectq = from q in OBase.seg_menu
                                  select q;

                    foreach (var item in selectq)
                    {
                        ListInfo.Add(new seg_menu_Info(item.IdMenu, item.cod_menu, item.nom_menu, item.IdMenuPadre ,item.estado, item.posicion , item.nivel , item.path_web, item.nom_webform , item.observacion , item.IdFormulario , item.IdReporte,item.esFormulario,item.esReporte ));
                    }


                }
                catch (Exception)
                {
                    return new List<seg_menu_Info>();
                }

                return ListInfo;
            }


        public List<seg_menu_Info> Get_List_Menu(string IdUsuario)
        {
            List<seg_menu_Info> ListInfo = new List<seg_menu_Info>();

            try
            {

                Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

               
                var selectq = from menu in OBase.seg_menu
                              join rel in OBase.seg_menu_x_seg_usuario
                              on menu.IdMenu equals rel.IdMenu into MenuUsuario
                              from menu2 in MenuUsuario
                              where menu2.IdUsuario == IdUsuario
                              select menu2;


                foreach (var item in selectq)
                {
                    ListInfo.Add(new seg_menu_Info(item.IdMenu, item.seg_menu.cod_menu, item.seg_menu.nom_menu, item.seg_menu.IdMenuPadre, item.seg_menu.estado,item.seg_menu.posicion,item.seg_menu.nivel, item.seg_menu.path_web, item.seg_menu.nom_webform, item.observacion, item.seg_menu.IdFormulario, item.seg_menu.IdReporte, item.seg_menu.esFormulario, item.seg_menu.esReporte));
                }


            }
            catch (Exception)
            {
                return new List<seg_menu_Info>();
            }

            return ListInfo;
        }

        public seg_menu_Info Get_Info_Menu(string IdMenu)
            {
                seg_menu_Info Info = new seg_menu_Info();

                try
                {

                    Entities_Seguridad_Accesos OBase = new Entities_Seguridad_Accesos();

                    var selectq = from q in OBase.seg_menu
                                  where q.IdMenu == IdMenu
                                  select q;

                    foreach (var item in selectq)
                    {
                        Info.IdMenu = item.IdMenu;
                        Info.cod_menu = item.cod_menu;
                        Info.nom_menu = item.nom_menu;
                        Info.IdMenuPadre = item.IdMenuPadre;
                        Info.estado = item.estado;
                        Info.path_web = item.path_web;
                        Info.nom_webform = item.nom_webform;
                        Info.observacion = item.observacion;
                        Info.IdFormulario = item.IdFormulario;
                        Info.IdReporte = item.IdReporte;
                        Info.esFormulario = item.esFormulario;
                        Info.esReporte = item.esReporte;


                    }
                }
                catch (Exception)
                {
                    return new seg_menu_Info();
                }

                return Info;

            }

        public Boolean GrabarDB(seg_menu_Info Info)
            {
                try
                {
                    using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                    {
                        

                        var addressG = new seg_menu();
                        addressG.IdMenu = Info.IdMenu;
                        addressG.cod_menu = Info.cod_menu;
                        addressG.nom_menu = Info.nom_menu;
                        addressG.IdMenuPadre = Info.IdMenuPadre;
                        addressG.estado = true ;
                        addressG.nivel = Info.nivel;
                        addressG.posicion = Info.posicion;
                        addressG.path_web = Info.path_web;
                        addressG.nom_webform = Info.nom_webform;
                        addressG.observacion = Info.observacion;
                        addressG.IdFormulario = Info.IdFormulario;
                        addressG.IdReporte = Info.IdReporte;
                        addressG.esFormulario = Info.esFormulario;
                        addressG.esReporte = Info.esReporte;

                        context.seg_menu.Add(addressG);
                        context.SaveChanges();

                    }
                }
                catch (Exception)
                {
                    return false;
                }

                return true;

            }

        public Boolean ModificarDB(seg_menu_Info Info)
            {
                try
                {
                    using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                    {
                        var contact = context.seg_menu.FirstOrDefault(cot => cot.IdMenu  == Info.IdMenu);

                        if (contact != null)
                        {

                            contact.cod_menu = Info.cod_menu;
                            contact.nom_menu = Info.nom_menu;
                            contact.IdMenuPadre = Info.IdMenuPadre;
                            contact.path_web = Info.path_web;
                            contact.nom_webform = Info.nom_webform;
                            contact.observacion = Info.observacion;
                            contact.IdFormulario = Info.IdFormulario;
                            contact.IdReporte = Info.IdReporte;
                            contact.esFormulario = Info.esFormulario;
                            contact.esReporte = Info.esReporte;
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

        public Boolean AnularDB(seg_menu_Info Info)
            {
                try
                {
                    using (Entities_Seguridad_Accesos context = new Entities_Seguridad_Accesos())
                    {
                        var contact = context.seg_menu.FirstOrDefault(cot => cot.IdMenu == Info.IdMenu);
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

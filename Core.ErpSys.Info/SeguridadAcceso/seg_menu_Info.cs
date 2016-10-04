using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.SeguridadAcceso
{
    public class seg_menu_Info
    {
      

        public string IdMenu { get; set; }
        public string cod_menu { get; set; }
        public string nom_menu { get; set; }
        public string IdMenuPadre { get; set; }
        public bool estado { get; set; }
        public int? posicion { get; set; }
        public int? nivel { get; set; }
        public string path_web { get; set; }
        public string nom_webform { get; set; }
        public string observacion { get; set; }
        public string IdFormulario { get; set; }
        public string IdReporte { get; set; }
        public bool? esFormulario { get; set; }
        public bool? esReporte { get; set; }

        public seg_menu_Info()
        {

        }

        public seg_menu_Info(string _IdMenu, string _cod_menu , string _nom_menu, string _IdMenuPadre ,  bool _estado, int? _posicion, int? _nivel, string _path_web , string _nom_webform, string _observacion, string _IdFormulario, string _IdReporte, bool? _esFormulario, bool? _esReporte )
        {
            IdMenu = _IdMenu;
            cod_menu = _cod_menu;
            nom_menu = _nom_menu;
            IdMenuPadre = _IdMenuPadre;
            estado = _estado;
            posicion = _posicion;
            nivel = _nivel;
            path_web = _path_web;
            nom_webform = _nom_webform;
            observacion = _observacion;
            IdFormulario = _IdFormulario;
            IdReporte = _IdReporte;
            esFormulario = _esFormulario;
            esReporte = _esReporte;


        }





    }
}

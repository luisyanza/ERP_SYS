//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.ErpSys.Data.SeguridadAcceso
{
    using System;
    using System.Collections.Generic;
    
    public partial class seg_perfil
    {
        public seg_perfil()
        {
            this.seg_perfil_x_seg_menu = new HashSet<seg_perfil_x_seg_menu>();
        }
    
        public int IdPerfil { get; set; }
        public string nom_perfil { get; set; }
        public bool estado { get; set; }
    
        public virtual ICollection<seg_perfil_x_seg_menu> seg_perfil_x_seg_menu { get; set; }
    }
}

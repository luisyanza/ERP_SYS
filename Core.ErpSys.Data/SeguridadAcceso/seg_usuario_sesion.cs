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
    
    public partial class seg_usuario_sesion
    {
        public decimal IdRegistro { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime fecha_hora { get; set; }
        public string tipo { get; set; }
        public string ip { get; set; }
        public string equipo { get; set; }
    
        public virtual seg_usuario seg_usuario { get; set; }
    }
}

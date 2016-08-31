using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ErpSys.Info.Sistemas
{
    public class tb_sis_Formulario_Info
    {
        public string IdForm { get; set; }
        public string nom_form { get; set; }
        public bool estado { get; set; }
        public string titulo { get; set; }


        public tb_sis_Formulario_Info()
        {

        }
        public tb_sis_Formulario_Info(string _IdForm, string _nom_form, bool _estado, string _titulo)
        {
            IdForm = _IdForm;
            nom_form = _nom_form;
            estado = _estado;
            titulo = _titulo;
        }
    }

}

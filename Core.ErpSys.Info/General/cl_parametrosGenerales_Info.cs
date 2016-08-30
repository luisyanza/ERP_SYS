using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;

namespace FirmElect.Info
{

    public sealed class cl_parametrosGenerales_Info
    {

        static readonly cl_parametrosGenerales_Info instance = new cl_parametrosGenerales_Info();


        public decimal Version = 201607151431;

        public string Nom_Sistema { get; set; }
        //public tb_Parametro_Info Parametro_Info { get; set; }
        //public  List<tb_Empresa_Info> G_listEmpresas{ get; set; }
    
       
        static cl_parametrosGenerales_Info() { }

        cl_parametrosGenerales_Info()
        {
        }

        public static cl_parametrosGenerales_Info Instance
        {
            get { return instance; }
        }

    }

}

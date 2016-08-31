﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.ErpSys.Data.SeguridadAcceso ;
using Core.ErpSys.Info.SeguridadAcceso;

namespace Core.ErpSys.Bus.SeguridadAcceso
{
    public class tb_seg_usuario_Bus
    {
        tb_seg_usuario_Data Odata = new tb_seg_usuario_Data();

        public List<tb_seg_usuario_Info> Get_List_Usuario()
        {
            return Odata.Get_List_Usuario();
        }

        public tb_seg_usuario_Info Get_Info_Usuario(string IdUsuario)
        {

            return Odata.Get_Info_Usuario(IdUsuario);

        }

        public Boolean GrabarDB(tb_seg_usuario_Info Info)
        {
            return Odata.GrabarDB(Info);

        }

        public Boolean ModificarDB(tb_seg_usuario_Info Info)
        {
            return Odata.ModificarDB(Info);

        }

        public Boolean AnularDB(tb_seg_usuario_Info Info)
        {
            return Odata.AnularDB(Info);

        }
    }
}

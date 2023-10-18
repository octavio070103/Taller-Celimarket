﻿using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class usuario
    {
        public int id_usuario {  get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime fecha_registro { get; set; }
        public int estado_usuario { get; set; }
        public persona obj_persona { get; set; }
        public rol obj_rol { get; set; }
        public domicilio obj_domicilio { get; set; }

    }
}

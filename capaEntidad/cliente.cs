﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class cliente
    {

        public int id_cliente {  get; set; }
        public bool estado_cliente { get; set; }

        public persona obj_persona { get; set; }

        public DateTime fecha_creacion_cliente { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public static class EstilosCSS
    {
        public static string ObtenerEstilosCSS()
        {
            string estilosCSS = @"
            body {
                background: linear-gradient(to bottom, rgb(22, 72, 99), rgb(66, 125, 157));
            }
           ";

            return estilosCSS;
        }
    }
    /* h1 {
                color:gainsboro;
                align-items: center;
                justify-content: center;
                text-align: center;
                margin-top:20px;
            }*/
}

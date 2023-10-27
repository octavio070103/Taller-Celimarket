using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_DataBase
    {
        private CD_DataBase obj_CD_DataBase = new CD_DataBase();

        public bool RealizarBackUp(string nameBaseDatos, string backupPath)
        {
            return obj_CD_DataBase.RealizarBackup(nameBaseDatos, backupPath);
        }

        public bool RealizarRestauracion(string nameBaseDatos, string restauracionPath)
        {
            return obj_CD_DataBase.RealizarRestauracion(nameBaseDatos, restauracionPath);
        }

    }
}

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
        private CD_DataBase backupManager = new CD_DataBase();

        public bool RealizarBackUp(string backupPath)
        {
            return backupManager.RealizarBackup("bd_virtualBiblio", backupPath);
        }

        public bool RealizarRestauracion(string backupPath)
        {
            return backupManager.RealizarRestauracion("bd_virtualBiblio", backupPath);
        }

    }
}

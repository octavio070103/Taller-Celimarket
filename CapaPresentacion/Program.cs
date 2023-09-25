using CapaPresentacion.Formularios.Admin;
using CapaPresentacion.Formularios.Gerente;
using Proyecto_Taller.Presentacion.Formularios.Login;
using Proyecto_Taller.Presentacion.Formularios.Vendedor;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuAdministrador());
        }
    }
}
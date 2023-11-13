using capaEntidad;
using CapaLogica;
using Proyecto_Taller.Presentacion.Formularios.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Gerente.caja
{
    public partial class FrmAdministrarCaja : Form
    {
        private MenuGerente instancia_gerente;
        private capaEntidad.usuario usuarioActual;
        public FrmAdministrarCaja(MenuGerente p_menuGerente, usuario p_usuarioActual)
        {
            InitializeComponent();
            instancia_gerente = p_menuGerente;
            usuarioActual = p_usuarioActual;
        }
        private void FrmAdministrarCaja_Load(object sender, EventArgs e)
        {
            DataGridDisenio.Formato(dataGridCajasCerradas, 1); //llamo a la clase datagrid disenio que le da el formato 1 a ese data grid 
            // Crear una instancia de la capa de lógica para hacer uso de los metodos que tiene esa clase CL_categoria que esta en la capa logica
            CL_Caja obj_CL_Caja = new CL_Caja();

            List<caja_cierre> listaCajasCerradas = obj_CL_Caja.listarCajasCerradas();// Obtener la lista de categorias desde la capa de lógica

            // llamo al metodo Mostrar la lista de categorias en el DataGridView y le pasa la lista obtenida de la capa logica
            mostrarCajasCerradasEnDataGridView(listaCajasCerradas);
        }
        private void mostrarCajasCerradasEnDataGridView(List<capaEntidad.caja_cierre> p_listaCajaCerrada)
        {
            dataGridCajasCerradas.Rows.Clear(); // Limpiar filas existentes

            foreach (capaEntidad.caja_cierre item in p_listaCajaCerrada)
            {

                //Agregar una fila al DataGridView con los datos del usuario
                dataGridCajasCerradas.Rows.Add(
                    new object[]
                    { //items de la cierreCaja
                      item.id_cierre_caja, item.fecha_cierre_caja,item.monto_final,item.diferencia_cierre_Caja,
                       item.estado_cierre== 1 ? "Caja Cerrada Correctamente" : "Caja Con diferencia", // Determinar el estado del apertura 1=cerro corectamente con el saldo positivo ,0= cerro con un saldo de diferncia negativo falta plata
                      //item del usuario que realizo el cierre
                      item.obj_usuario.obj_persona.dni,item.obj_usuario.obj_persona.nombre + " "+item.obj_usuario.obj_persona.apellido,
                      //item de la apertura_caja
                      item.obj_caja_apertura.id_apertura_caja,item.obj_caja_apertura.fecha_apertura,item.obj_caja_apertura.monto_inicial_apertura,
                      //item del usuario que realizo el cierre
                      item.obj_caja_apertura.obj_usuario.obj_persona.dni, item.obj_caja_apertura.obj_usuario.obj_persona.nombre+" "+item.obj_caja_apertura.obj_usuario.obj_persona.apellido,
                      item.obj_caja_apertura.estado_apertura == 1 ? "Caja Apertura Cerrada" : "Caja Apertura Abierta" // Determinar el estado del apertura 
                      }
                 );

            }
            dataGridCajasCerradas.ClearSelection();//quita la seleccion de fila por defecto que tiene el data grid

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            instancia_gerente.OpenChildForm(new FrmApertYCierreCaja(instancia_gerente, usuarioActual));
        }


    }
}

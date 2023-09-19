using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidad;
using CapaLogica;

namespace CapaPresentacion.Formularios.Admin
{
    public partial class RegistrarUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        public RegistrarUsuario(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            List<rol> listaRol = new CL_rol().listarRol();

            //va a leer todos los items dentro de la lista
            foreach (rol item in listaRol)
            {
                comboRolUsu.Items.Add(item.descripcion_rol);
            }
        }

        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            // Obtener la descripción del rol seleccionado en el ComboBox
            string rolSeleccionadoDescripcion = comboRolUsu.SelectedItem as string;

            if (rolSeleccionadoDescripcion != null)
            {
                    // Buscar el id_rol correspondiente a la descripción seleccionada
                    int idRolSeleccionado = ObtenerIdRolPorDescripcion(rolSeleccionadoDescripcion);

                    if (idRolSeleccionado != -1)
                    {
                        capaEntidad.usuario obj_usuario = new capaEntidad.usuario() //creo mi objeto obj_usuario que es de tipo usuario y con las llaves indiico que le pasare los valores a sus respetctivos atributos
                    {
                            nombre = txtNombreUsu.Text,
                            apellido = txtApelliUsu.Text,
                            dni = txtDniUsu.Text,
                            email = txtEmailUsu.Text,
                            password = txtPasswordUsu.Text,
                            telefono = txtTelefUsu.Text,
                            obj_rol = new rol()
                            {
                                id_rol = idRolSeleccionado

                            },
                            obj_domicilio = new domicilio()
                            {
                                id_domicilio = 1//aca debo de cambiar por el domicilio creado 
                            },
                            estado_usuario = 1

                    };

                     int id_usuario_generado = new CL_usuario().registrarUsuario(obj_usuario, out mensaje);
                        if (mensaje != "")
                        {
                        MessageBox.Show(mensaje);
                         }

                    }
                    else
                    {
                            MessageBox.Show("No se pudo encontrar el ID del rol seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
             }
            else
            {
                MessageBox.Show("Debes seleccionar un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Método para buscar el id_rol por la descripción del rol
        private int ObtenerIdRolPorDescripcion(string descripcion)
        {
            List<rol> listaRol = new CL_rol().listarRol();

            foreach (rol item in listaRol)
            {
                if (item.descripcion_rol == descripcion)
                {
                    return item.id_rol;
                }
            }

            // Si no se encuentra la descripción, devuelve -1 para indicar un error.
            return -1;
        }



    }
}

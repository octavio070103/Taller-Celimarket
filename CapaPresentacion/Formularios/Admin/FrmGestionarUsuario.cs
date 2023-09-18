using CapaDatos;
using capaEntidad;
using CapaLogica;
using FontAwesome.Sharp;
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

namespace CapaPresentacion.Formularios.Admin
{

    public partial class FrmGestionarUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        private Form currentChildForm;

        public FrmGestionarUsuario(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
        }


        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            instanciaMenuAdministrador.OpenChildForm(new Admin.RegistrarUsuario(this.instanciaMenuAdministrador));
        }

        private void iconBtnModif_Click(object sender, EventArgs e)
        {
            instanciaMenuAdministrador.OpenChildForm(new Admin.FrmEditarUsuario(this.instanciaMenuAdministrador));
        }

        private void iconBtnElim_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnPermiso_Click(object sender, EventArgs e)
        {
            instanciaMenuAdministrador.OpenChildForm(new Admin.usuario.FrmPermisoUsuario(this.instanciaMenuAdministrador));
        }

        private void FrmGestionarUsuario_Load(object sender, EventArgs e)
        {
            // Crear una instancia de la capa de lógica
            CL_usuario obj_CL_Usuario = new CL_usuario();
            //por ewsto uso capaentidad.usuario ya que es necesario especificar de manera explícita a cuál usuario te estás refiriendo,lo HAGOcalificando el nombre de la clase usuario con el espacio de nombres al que pertenece. 
            List<capaEntidad.usuario> listaUsuarios = obj_CL_Usuario.listarUsuarios(); // Obtener la lista de usuarios desde la capa de lógica

            // llama al metodo Mostrar la lista de usuarios en el DataGridView y le pasa la lista obtenida de la capa logica
            mostrarUsuariosEnDataGridView(listaUsuarios);

        }

        private void mostrarUsuariosEnDataGridView(List<capaEntidad.usuario> p_listaUsuarios)
        {
            dataGridUsuarios.Rows.Clear(); // Limpiar filas existentes

            // Asigna la lista de usuarios al DataGridView (como fuente de datos)
            // dataGridUsuarios.DataSource = listaUsuarios;

            foreach (capaEntidad.usuario item in p_listaUsuarios)
            {
                // Agregar una fila al DataGridView con los datos del usuario
                dataGridUsuarios.Rows.Add(
                    new object[]
                    { //items del usuario
                      item.id_usuario, item.dni,item.nombre,item.apellido,item.email,item.password,item.telefono,
                       //item rol
                       item.obj_rol.id_rol,item.obj_rol.descripcion_rol,
                       item.obj_domicilio.id_domicilio,item.obj_domicilio.calle,item.obj_domicilio.numero,item.obj_domicilio.provincia,
                       item.estado_usuario==true ? 1 : 0,item.estado_usuario==true ? "Activo" : "NO activo"
                    }
                 );

            }
            // Ocultar los botones
            iconbtnGuardar.Visible = false;
            iconBtnCancelar.Visible = false;
        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void iconBtnModif_Click_1(object sender, EventArgs e)
        {
            iconbtnGuardar.Visible = true;
            iconBtnCancelar.Visible = true;
            iconBtnModif.Visible = false;
        }

        private void dataGridUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            //aca estoy diciendo que si la fila que se selcciono el inidice es mayor o igual a 0 es decir que en verdad es una fila qu eme guarde el indice de ese id_usuario que seleciono en el txtIDGuardado para pdoer traer de laBd ese usuario
            if (indice >= 0)
            {

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridUsuarios.Rows[e.RowIndex];

                // Obtener los datos necesarios de la fila (suponiendo que la columna 0 contiene el ID)
                int id_usuario = Convert.ToInt32(selectedRow.Cells[0].Value);
                CL_usuario obj_CL_Usuario = new CL_usuario();

                capaEntidad.usuario objUsuario = obj_CL_Usuario.buscarUsuario(id_usuario);

                if (objUsuario != null)
                {
                    txtDniDato.Text = objUsuario.dni.ToString();
                    txtNombreDato.Text = objUsuario.nombre;
                    txtApeDato.Text = objUsuario.apellido;
                    txtEmailDato.Text = objUsuario.email;
                    txtTelefDato.Text = objUsuario.telefono;

                    //declaro mi lista que va a contener objetos de tipo rol
                    List<rol> listaRol = new CL_rol().listarRol();
                    //va a leer todos los items dentro de la lista y Rellena el ComboBox con los roles
                    foreach (rol item in listaRol)
                    {
                        comboRolDato.Items.Add(item.descripcion_rol);
                    }

                    //buscamos el índice del rol del usuario en la lista de roles utilizando FindIndex(traigo el 1er elemenot que cumple la condicion) y una expresión lambda(Las expresiones lambda permiten definir funciones pequeñas y simples en línea, sin la necesidad de declarar un método completo.) que compara el id_rol
                    int indiceRol = listaRol.FindIndex(r => r.id_rol == objUsuario.obj_rol.id_rol);//a parte r => ... significa que estás definiendo un parámetro r que representa cada elemento de la lista (rol) y, a continuación, especificas una condición. En este caso, la condición es que el id_rol del elemento r sea igual al id_rol del rol asociado al usuario (objUsuario.obj_rol.id_rol).

                    // Si se encontró el índice, selecciona el rol en el ComboBox
                    if (indiceRol >= 0)
                    {
                        comboRolDato.SelectedIndex = indiceRol;
                    }

                    //ahora hacemos lo mismo pero para el estado del usuario
                    comboEstadoDato.Items.Add("Activo");
                    comboEstadoDato.Items.Add("No activo");
                    if(objUsuario.estado_usuario== 1)
                    {
                        comboEstadoDato.SelectedIndex = 1;
                    }
                    else
                    {
                        comboEstadoDato.SelectedIndex = 0;
                    }
                }

            }
        }
    }
}

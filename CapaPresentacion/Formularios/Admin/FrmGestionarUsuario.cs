using CapaDatos;
using capaEntidad;
using CapaLogica;
using CapaPresentacion.Formularios.Admin.usuario;
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
                // Determinar el estado del usuario
                string estado = item.estado_usuario == 1 ? "Activo" : "No activo";

                // Agregar una fila al DataGridView con los datos del usuario
                dataGridUsuarios.Rows.Add(
                    new object[]
                    { //items del usuario
                      item.id_usuario, item.dni,item.nombre,item.apellido,item.email,item.password,item.telefono,
                       //item rol
                       item.obj_rol.id_rol,item.obj_rol.descripcion_rol,
                       item.obj_domicilio.id_domicilio,item.obj_domicilio.calle,item.obj_domicilio.numero,item.obj_domicilio.provincia,
                      // item.estado_usuario==true ? 1 : 0,item.estado_usuario==true ? "Activo" : "NO activo"
                       item.estado_usuario,estado
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

            DialogResult consulta = MessageBox.Show("¿Desea Editar los datos Del Empleado?", "Editar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (consulta == DialogResult.OK)
            {
                iconbtnGuardar.Visible = true;
                iconBtnCancelar.Visible = true;
                iconBtnModif.Visible = false;
            }
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
                    txtIdGuardado.Text = objUsuario.id_usuario.ToString();
                    txtDniDato.Text = objUsuario.dni.ToString();
                    txtNombreDato.Text = objUsuario.nombre;
                    txtApeDato.Text = objUsuario.apellido;
                    txtEmailDato.Text = objUsuario.email;
                    txtTelefDato.Text = objUsuario.telefono;
                    txtDomiciliodato.Text = objUsuario.obj_domicilio.calle + " " + objUsuario.obj_domicilio.numero.ToString();

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

                    //ahora hacemos lo mismo pero para el estado del usuario añadimos las opciones al comboBox  y luego decimos que dependiendo del estado_usuario que se seleccione esa opcion para el usuario
                    comboEstadoDato.Items.Add("Activo");
                    comboEstadoDato.Items.Add("No activo");
                    if (objUsuario.estado_usuario == 1)
                    {
                        comboEstadoDato.SelectedIndex = 0;
                    }
                    else
                    {
                        comboEstadoDato.SelectedIndex = 1;
                    }
                }
                else
                {

                }

            }
        }

        /*este metodo llama al formualario de editar domicilio del uusario */
        private void txtDomiciliodato_MouseClick(object sender, MouseEventArgs e)
        {
            FrmRegistrarDomicilio frmRegistrarDomicilio = new FrmRegistrarDomicilio();

            frmRegistrarDomicilio.Show();
        }

        private void txtDniFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombreFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtApeFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {/*
            if (validarCampos())
            {
                // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
                DialogResult ask;//se declara una variable llamada ask del tipo DialogResult, que se usará para almacenar el resultado del cuadro de diálogo.
                borrarMensajeError();

                ask = MessageBox.Show("Seguro que desea Editar el usuario ? ", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //como  Todos los msgbox devuelven un resultado lógico. podemos hacer el sig if
                if (ask == DialogResult.Yes)
                {
                    //aca va la funcion de guardar el uusario editado
                    MessageBox.Show("El cliente: " + txtNombreDato.Text + " " + txtApeDato.Text + " el usuario se edito correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("El usuario: " + txtNombreDato.Text + " " + txtApeDato.Text + " No se edito correctamente ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }*/
        }
        /*
        private bool validarCampos()
        {
            bool validacion = true;
            string dni = txtDniDato.Text;
            string nombre = txtNombreDato.Text;
            string apellido = txtApeDato.Text;
            string email = txtEmailDato.Text;
            string telefono = txtTelefDato.Text;
            string domicilio = txtDomiciliodato.Text;

            int numero = 0;

            string nombreCompleto = nombre + " " + apellido;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(domicilio))
            {
                // MessageBox.Show("Debe de completar todos los campos");
                MessageBox.Show("Por favor, Rellene todos los campos para poder editar el Usuario", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(lblDni, "Ingrese su DNI");
                errorProvider1.SetError(lblNombre, "Ingrese su nombre");//El primer argumento es el control al que deseas asociar el mensaje de error..El segundo argumento es el mensaje de error que deseas mostrar.  
                errorProvider1.SetError(lblApellido, "Ingrese su Apellido");
                errorProvider1.SetError(lblTelefono, "Ingrese su Telefono");
                return validacion = false;
            }

            //validar que el campos Dni solo se ingresen numeros
            if (!int.TryParse(dni, out numero))
            {
                errorProvider1.SetError(lblDni, "Ingrese su DNI");
                MessageBox.Show("El Dni debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            // Validar que los campos Apellido y Nombre contengan solo letras
            if (!EsAlfabetico(apellido))
            {
                errorProvider1.SetError(lblApellido, "Ingrese su apellido");
                MessageBox.Show(" El apellido debe de contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            if (!EsAlfabetico(nombre))
            {
                errorProvider1.SetError(lblNombre, "Ingrese su nombre");
                MessageBox.Show(" El nombre debe de contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //validar que el campos Dni solo se ingresen numeros
            if (!int.TryParse(telefono, out numero))
            {
                errorProvider1.SetError(lblTelefono, "Ingrese su Telefono");
                MessageBox.Show("El Telefono debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            lblModificar.Text = nombreCompleto;
            return validacion;
        }

        //limpia los mensajes de error que se muestran junto a los campos en caso de que hayan errores de validación.
        private void borrarMensajeError()
        {
            errorProvider1.SetError(lblNombre, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblDni, "");    // Limpiar mensaje de error
            errorProvider1.SetError(lblApellido, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblTelefono, ""); // Limpiar mensaje de error

        }*/

        }
}

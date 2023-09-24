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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

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

            //sucribo un manejador de eventos(textBoxFiltro) a mi evento (TextCganged) para textbox de filtrado
            txtDniFiltro.TextChanged += txtDniFiltro_TextChanged;//El += se utiliza para agregar un manejador de eventos adicional a los que ya puedan estar suscritos al evento, en lugar de reemplazarlos.
            txtNombreFiltro.TextChanged += txtNombreFiltro_TextChanged;
            txtApeFiltro.TextChanged += txtApeFiltro_TextChanged;
            comboFiltroEstado.TextChanged += comboFiltroEstado_TextChanged;
            comboFiltroRol.TextChanged += comboFiltroRol_TextChanged;
          
        }


        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            instanciaMenuAdministrador.OpenChildForm(new Admin.RegistrarUsuario(this.instanciaMenuAdministrador));
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

            txtIdGuardado.Visible = false;//oculto el id del usuario que luego uso para guardarlo y poder editar el usuario o buscarlo 
            ReadOnlyTxtDatoUsuario(true);//configuro que el panel de datos del usuario sea en lectura uniucamente es decir le digo que se active esa propiedad

            //cargo el comoboBox del filtrado dle estadi al cargar el formulario
            comboFiltroEstado.Items.Add("Activo");
            comboFiltroEstado.Items.Add("No activo");

            //cargo el comoboBox de lso roles dewl filtrado
            listarRolesCombo(comboFiltroRol);
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
            dataGridUsuarios.ClearSelection();//quita la seleccion de fila por defecto que tiene el data grid
            // Ocultar los botones
            iconbtnGuardar.Visible = false;
            iconBtnCancelar.Visible = false;
        }

        //aca cargo mi panel de datos del uusario con los datos del datagrid que se selecciono
        private void dataGridUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            //aca estoy diciendo que si la fila que se selcciono el inidice es mayor o igual a 0 es decir que en verdad es una fila qu eme guarde el indice de ese id_usuario que seleciono en el txtIDGuardado para pdoer traer de laBd ese usuario
            if (indice >= 0)
            {
                limpiartxtDato();
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
                    txtPasswordDato.Text = objUsuario.password;
                    txtDomiciliodato.Text = objUsuario.obj_domicilio.calle + " " + objUsuario.obj_domicilio.numero.ToString();


                    List<rol> listaRol = listarRolesCombo(comboRolDato);//este metodo lista los roles en el comboBox que le paso como parametro y lo guardo en una var de tipo lista rol y asi puedo buscar el indiice del rol leugo 

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
        private void iconBtnModif_Click_1(object sender, EventArgs e)
        {
            //aca digo que si el usuario selecciono una columna en el data grid y ademas el txtid que se encarga de guardar el id del uusario selecionado es disitinto de 0 que entre al if
            //esto lo hago ay que asi me aseguro de que el usuario selecciono una columna en el data grid y que ademas es un usuario valido pq su id se guardo
            if (dataGridUsuarios.SelectedRows.Count > 0 && Convert.ToInt32(txtIdGuardado.Text) != 0)
            {
                DialogResult consulta = MessageBox.Show("¿Desea Editar los datos Del usuario?", "Editar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (consulta == DialogResult.OK)
                {

                    iconbtnGuardar.Visible = true;
                    iconBtnCancelar.Visible = true;
                    iconBtnModif.Visible = false;
                    ReadOnlyTxtDatoUsuario(false);//configuro el panel del usuario en modo edicion deshabilit ando la funcion ReadOnly
                }
                /*hago para que los text pasen de modo lectura a poder escrbirse sobre ellos */
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para poder editarlo ", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void iconBtnElim_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            CapaLogica.CL_usuario obj_cl_usuario = new CL_usuario();

            //aca digo que si el usuario selecciono una columna en el data grid y ademas el txtid que se encarga de guardar el id del uusario selecionado es disitinto de 0 que entre al if
            //esto lo hago ay que asi me aseguro de que el usuario selecciono una columna en el data grid y que ademas es un usuario valido pq su id se guardo
            if (dataGridUsuarios.SelectedRows.Count > 0 && Convert.ToInt32(txtIdGuardado.Text) != 0)
            {
                DialogResult consulta = MessageBox.Show("¿Desea Dar de bajo el usuario?", "Eliminar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (consulta == DialogResult.OK)
                {
                    capaEntidad.usuario obj_usuario = new capaEntidad.usuario
                    {
                        id_usuario = Convert.ToInt32(txtIdGuardado.Text)

                    };


                    obj_cl_usuario.eliminarUsuarioLogico(obj_usuario, out mensaje);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para poder darlo baja ", "Eliminar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public List<rol> listarRolesCombo(ComboBox p_combo)
        {
            //declaro mi lista que va a contener objetos de tipo rol
            List<rol> listaRol = new CL_rol().listarRol();
            //va a leer todos los items dentro de la lista y Rellena el ComboBox con los roles
            foreach (rol item in listaRol)
            {
                p_combo.Items.Add(item.descripcion_rol);
            }
            return listaRol;

        }
        private void ReadOnlyTxtDatoUsuario(bool valor)
        {
            txtDniDato.ReadOnly = valor;
            txtNombreDato.ReadOnly = valor;
            txtApeDato.ReadOnly = valor;
            txtApeDato.ReadOnly = valor;
            txtPasswordDato.ReadOnly = valor;
            txtTelefDato.ReadOnly = valor;
            txtEmailDato.ReadOnly = valor;
            //faltaria hacer para los comboBox para que esten en modo lecyra tambien
            txtDomiciliodato.ReadOnly = valor;
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
        {
            string mensaje = string.Empty;
            // Crear una instancia de la capa de lógica
            CL_usuario obj_CL_Usuario = new CL_usuario();

            if (validarCampos())
            {
                // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
                DialogResult ask;//se declara una variable llamada ask del tipo DialogResult, que se usará para almacenar el resultado del cuadro de diálogo.
                borrarMensajeError();

                ask = MessageBox.Show("Seguro que desea Editar el usuario ? ", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Obtener la descripción del rol seleccionado en el ComboBox
                string rolSeleccionadoDescripcion = comboRolDato.SelectedItem as string; //falta poner las valdiaciones del rol seleccionado queesta en festionar usuario

                //como  Todos los msgbox devuelven un resultado lógico. podemos hacer el sig if
                if (ask == DialogResult.Yes)
                {
                    // Buscar el id_rol correspondiente a la descripción seleccionada
                    int idRolSeleccionado = ObtenerIdRolPorDescripcion(rolSeleccionadoDescripcion);

                    capaEntidad.usuario obj_Usuario = new capaEntidad.usuario()
                    {
                        id_usuario = Convert.ToInt32(txtIdGuardado.Text),
                        dni = txtDniDato.Text,
                        nombre = txtNombreDato.Text,
                        apellido = txtApeDato.Text,
                        email = txtEmailDato.Text,
                        telefono = txtTelefDato.Text,
                        password = txtPasswordDato.Text,
                        obj_rol = new rol()
                        {
                            id_rol = idRolSeleccionado
                        },
                        obj_domicilio = new domicilio()
                        {
                            id_domicilio = 1//aca debo de cambiar por el domicilio creado 
                        },
                        estado_usuario = estadoUsuarioSeleccionado(comboEstadoDato.SelectedItem as string) //convierto de manera segura selecteditem en un tipo string con as string y sino es posible devuelve null en vez de lanar una excepcion como lo hace .Tostring
                    };

                    bool resultadoEditarUsuario = new CL_usuario().editarUsuario(obj_Usuario, out mensaje);

                    if (resultadoEditarUsuario)
                    {
                        limpiartxtDato();

                        MessageBox.Show("El usuario: " + txtNombreDato.Text + " " + txtApeDato.Text + " el usuario se edito correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        iconbtnGuardar.Visible = false;
                        iconBtnCancelar.Visible = false;
                        iconBtnModif.Visible = true;

                        //listo los usuarios aca porque en teoria se actualizo la lista de los usuario es decir que se modifco esa lista entonces la actualizo
                        //por ewsto uso capaentidad.usuario ya que es necesario especificar de manera explícita a cuál usuario te estás refiriendo,lo HAGOcalificando el nombre de la clase usuario con el espacio de nombres al que pertenece. 
                        List<capaEntidad.usuario> listaUsuarios = obj_CL_Usuario.listarUsuarios(); // Obtener la lista de usuarios desde la capa de lógica
                        // llama al metodo Mostrar la lista de usuarios en el DataGridView y le pasa la lista obtenida de la capa logica con esto logro hacer un REFRESH EN EL DATAGRID con los datos nuevos
                        mostrarUsuariosEnDataGridView(listaUsuarios);
                    }
                    else
                    {
                        limpiartxtDato();
                        MessageBox.Show("El usuario: " + txtNombreDato.Text + " " + txtApeDato.Text + " No se edito correctamente ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        iconbtnGuardar.Visible = false;
                        iconBtnCancelar.Visible = false;
                        iconBtnModif.Visible = true;
                        //no actualizo el datgrid ya que no se edito ningun elemento
                    }
                    //aca muestro en caso de que haya habido algun error en el metodo resultadoEditarUsuario el error del mensaje o en caso de exito tmabien muestro el mensaje proveniente de mi proceso alamcenado
                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje);
                    }
                }

            }
        }

        private int estadoUsuarioSeleccionado(string p_seleccionEstado)
        {
            if (p_seleccionEstado == "Activo")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

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
                errorProvider1.SetError(lblDniDato, "Ingrese su DNI correctamente");
                errorProvider1.SetError(lblNombreDato, "Ingrese su nombre correctamente");//El primer argumento es el control al que deseas asociar el mensaje de error..El segundo argumento es el mensaje de error que deseas mostrar.  
                errorProvider1.SetError(lblApellidoDato, "Ingrese su Apellido correctamente");
                errorProvider1.SetError(lblEmailDato, "Ingrese su Email correctamente");
                errorProvider1.SetError(lblTelefDato, "Ingrese su Telefono correctamente");
                errorProvider1.SetError(lblDomicilioDato, "Ingrese su Domicilio correctamente");
                return validacion = false;
            }

            //validar que el campos Dni solo se ingresen numeros
            if (!int.TryParse(dni, out numero))
            {
                errorProvider1.SetError(lblDniDato, "Ingrese su DNI correctamente");
                MessageBox.Show("El Dni debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            // Validar que los campos Apellido y Nombre contengan solo letras
            if (!EsAlfabetico(nombre))
            {
                errorProvider1.SetError(lblNombreDato, "Ingrese su nombre");
                MessageBox.Show(" El nombre debe de contener solamente letras y un solo espacio de separacion entre nombres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            if (!EsAlfabetico(apellido))
            {
                errorProvider1.SetError(lblApellidoDato, "Ingrese su apellido");
                MessageBox.Show(" El apellido debe de contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            if (!validarEmail(email))
            {
                errorProvider1.SetError(lblEmailDato, "Ingrese su email valido formato: correo@example.com");
                MessageBox.Show(" El email debe de seguir el formato correo@example.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            return validacion;
        }

        // Función para verificar si una cadena contiene solo letras
        private bool EsAlfabetico(string texto)
        {
            bool espacioEncontrado = false;
            foreach (char c in texto)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (espacioEncontrado)
                    {
                        // Se encontró un espacio en blanco después de otro espacio en blanco
                        return false;
                    }
                    espacioEncontrado = true;
                }
                else if (!char.IsLetter(c))
                {
                    // El carácter no es una letra
                    return false;
                }
                else
                {
                    // Reiniciar el indicador de espacio si se encuentra una letra
                    espacioEncontrado = false;
                }
            }
            return true;
        }

        // toma una cadena que representa un email y utiliza una expresión regular para verificar si se ajusta a un formato de email válido. 
        // Si el email cumple con este formato, la función ValidarEmail devuelve true; de lo contrario, devuelve false.
        public bool validarEmail(string email)
        {
            // Patrón de expresión regular para validar un email
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Utiliza la clase Regex para hacer la validación
            return Regex.IsMatch(email, patron);
        }

        //limpia los mensajes de error que se muestran junto a los campos en caso de que hayan errores de validación.
        private void borrarMensajeError()
        {
            errorProvider1.SetError(lblDniDato, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblNombreDato, "");    // Limpiar mensaje de error
            errorProvider1.SetError(lblApellidoDato, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblEmailDato, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblTelefDato, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblDomicilioDato, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblPassword, ""); // Limpiar mensaje de error
        }

        private void limpiartxtDato()
        {
            txtIdGuardado.Text = "";
            txtDniDato.Text = "";
            txtNombreDato.Text = "";
            txtApeDato.Text = "";
            txtEmailDato.Text = "";
            txtTelefDato.Text = "";
            txtDomiciliodato.Text = "";
            txtPasswordDato.Text = "";
        }

        //en este evento se actualizara el friltro del dataGrid de usuarios cada vez que se cambie el texto del mi textBox
        private void txtDniFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtDniFiltro.Text;
            string atributo = "dni";
            // Filtra los datos en el DataGridView
            FiltrarDataGridView(filtro,atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }

        private void txtNombreFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNombreFiltro.Text;
            string atributo = "nombre";
            // Filtra los datos en el DataGridView
            FiltrarDataGridView(filtro,atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }

        private void txtApeFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtApeFiltro.Text;
            string atributo = "apellido";
            // Filtra los datos en el DataGridView
            FiltrarDataGridView(filtro,atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }

        private void comboFiltroEstado_TextChanged(object sender, EventArgs e)
        {
            

            if (comboEstadoDato.SelectedIndex == 1)
            {
                string filtro = "0";
                string atributo = "estado";
                // Filtra los datos en el DataGridView
                FiltrarDataGridView(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
            }
            else
            {
                string filtro = "1";
                string atributo = "estado";
                // Filtra los datos en el DataGridView
                FiltrarDataGridView(filtro,atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
            }
        }
        private void comboFiltroRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void FiltrarDataGridView(string filtro, string atributo)
        {
            // Crear una instancia de la capa de lógica
            CL_usuario obj_CL_Usuario = new CL_usuario();
            //por ewsto uso capaentidad.usuario ya que es necesario especificar de manera explícita a cuál usuario te estás refiriendo,lo HAGOcalificando el nombre de la clase usuario con el espacio de nombres al que pertenece. 
            List<capaEntidad.usuario> listaUsuarioFiltrado = obj_CL_Usuario.listarUsuarioFiltrados(filtro,atributo); // Obtener la lista de usuarios desde la capa de lógica

            // Actualiza el DataGridView
            mostrarUsuariosEnDataGridView(listaUsuarioFiltrado);

        }

       
    }
}

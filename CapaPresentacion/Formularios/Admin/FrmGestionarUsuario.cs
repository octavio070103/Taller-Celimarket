using CapaDatos;
using capaEntidad;
using CapaLogica;
using CapaPresentacion.Formularios.Admin.usuario;
using ClosedXML.Excel;
using FontAwesome.Sharp;
using Proyecto_Taller.Presentacion.Formularios.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        private static capaEntidad.usuario usuarioActual;
        public FrmGestionarUsuario(MenuAdministrador p_MenuAdministrador, capaEntidad.usuario p_usuarioActual)
        {

            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;

            //sucribo un manejador de eventos(textBoxFiltro) a mi evento (TextCganged) para textbox de filtrado
            txtDniFiltro.TextChanged += txtDniFiltro_TextChanged;//El += se utiliza para agregar un manejador de eventos adicional a los que ya puedan estar suscritos al evento, en lugar de reemplazarlos.
            txtNombreFiltro.TextChanged += txtNombreFiltro_TextChanged;
            txtApeFiltro.TextChanged += txtApeFiltro_TextChanged;
            comboFiltroEstado.TextChanged += comboFiltroEstado_TextChanged_1;
            comboFiltroRol.TextChanged += comboFiltroRol_TextChanged;

            panelDatosUsuario.Visible = false;//escondo el panel de editar datos del usuario al inicio sino selecciono ningun usuario para editar,estara oculto
            txtIdGuardado.Visible = false;//oculto el id del usuario que luego uso para guardarlo y poder editar el usuario o buscarlo 
            usuarioActual = p_usuarioActual;
        }


        private void iconBtnAgregar_Click(object sender, EventArgs e)
        {
            instanciaMenuAdministrador.OpenChildForm(new Admin.RegistrarUsuario(this.instanciaMenuAdministrador));
        }

        private void iconBtnPermiso_Click(object sender, EventArgs e)
        {
            instanciaMenuAdministrador.OpenChildForm(new Admin.usuario.FrmPermisoUsuario(this.instanciaMenuAdministrador, usuarioActual));
        }

        private void FrmGestionarUsuario_Load(object sender, EventArgs e)
        {
            DataGridDisenio.Formato(dataGridUsuarios, 1); //llamo a la clase datagrid disenio que le da el formato 1 a ese data grid 

            // Crear una instancia de la capa de lógica
            CL_usuario obj_CL_Usuario = new CL_usuario();
            //ESCRIBO capaentidad.usuario ya que es necesario especificar de manera explícita que archivo usuario te estás refiriendo,lo HAGO calificando el nombre de la clase usuario con el espacio de nombres al que pertenece. 
            List<capaEntidad.usuario> listaUsuarios = obj_CL_Usuario.listarUsuarios(); // Obtener la lista de usuarios desde la capa de lógica

            // llama al metodo Mostrar la lista de usuarios en el DataGridView y le pasa la lista obtenida de la capa logica
            mostrarUsuariosEnDataGridView(listaUsuarios);

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

                // Agregar una fila al DataGridView con los datos del usuario
                dataGridUsuarios.Rows.Add(
                    new object[]
                    { //items del usuario
                      item.id_usuario, item.obj_persona.dni,item.obj_persona.nombre,item.obj_persona.apellido,item.email,item.password,item.obj_persona.telefono,
                       //item rol
                       item.obj_rol.id_rol,item.obj_rol.nombre_rol,
                       item.obj_domicilio.id_domicilio,item.obj_domicilio.calle,item.obj_domicilio.numero,item.obj_domicilio.provincia,
                      // item.estado_usuario==true ? 1 : 0,item.estado_usuario==true ? "Activo" : "NO activo"
                       item.estado_usuario,
                       item.estado_usuario == 1 ? "Activo" : "No activo" // Determinar el estado del usuario si es 1=activo
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
                DetallesUsuario(true);

                limpiartxtDato();//limpio los campos del panel de datos usuario

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridUsuarios.Rows[indice];

                // Obtener los datos necesarios de la fila  obteniuendo de esa fila selecciona su id_usuario(cells [0] y el valor de este(suponiendo que la columna 0 contiene la columna ID)
                int id_usuario = Convert.ToInt32(selectedRow.Cells[0].Value);//toma el valor alamcenadoi en la 1ra celda de la fila seleccionada y lo asigna a esa var

                CL_usuario obj_CL_Usuario = new CL_usuario();

                capaEntidad.usuario objUsuario = obj_CL_Usuario.buscarUsuario(id_usuario);

                if (objUsuario != null)
                {
                    //ver como puedo meter esto dentro de un emtood llamado verdetalles o algo asi entonces cuando el usuario edita puedo volver  allamr a ese mtodo y que los datos quee dito se actualicen si tenenr que volver a seleccioan rel usuario en el data para que pase

                    txtIdGuardado.Text = objUsuario.id_usuario.ToString();
                    txtDniDato.Text = objUsuario.obj_persona.dni.ToString();
                    txtNombreDato.Text = objUsuario.obj_persona.nombre;
                    txtApeDato.Text = objUsuario.obj_persona.apellido;
                    dateTimePickerNacimientoDato.Value = objUsuario.obj_persona.fecha_nacimiento;
                    txtEmailDato.Text = objUsuario.email;
                    txtTelefDato.Text = objUsuario.obj_persona.telefono;
                    txtPasswordDato.Text = objUsuario.password;
                    txtDomiciliodato.Text = objUsuario.obj_domicilio.calle + " " + objUsuario.obj_domicilio.numero.ToString();

                    //cargo el combo box de losroles del panel de editar datos del usuario ,lo guardo en una lista de roles a esos roles para poder buscar el indice del rol que tiene ese usuario asi se selecciona ese rol como predeterminado
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

                        //me permitira determinar que boton mostrarse si el de dar de alta o el de dar de baja depnediendo del estado del usuario que se seleccion
                        iconBtnElim.Visible = true;
                        iconBtnAlta.Visible = false;
                    }
                    else
                    {
                        comboEstadoDato.SelectedIndex = 1;
                        //me permitira determinar que boton mostrarse si el de dar de alta o el de dar de baja depnediendo del estado del usuario que se seleccion
                        iconBtnElim.Visible = false;
                        iconBtnAlta.Visible = true;
                    }

                }
                else
                {

                }

            }

        }

        //si el usuario selecciona una fila para ver su detalles se redimensionan los paneles y se hace visible el editar,redimensiona los botones los cambia de posicion
        private void DetallesUsuario(bool valor)
        {
            //si el valor del parametro valor es true significa que se debe de mostrar el panel de datos de usuario
            if (valor == true)
            {
                panelDatosUsuario.Visible = true;
                // Establecer el tamaño del data grid es decir lo redimienciono cuando se muestran los detalles del uusario 
                dataGridUsuarios.Location = new System.Drawing.Point(12, 176);
                dataGridUsuarios.Size = new System.Drawing.Size(690, 349); // ancho y alto en píxeles

                iconBtnAgregar.Location = new System.Drawing.Point(80, 99);
                iconBtnAlta.Location = new System.Drawing.Point(211, 99);
                iconBtnElim.Location = new System.Drawing.Point(211, 99);
                iconBtnPermiso.Location = new System.Drawing.Point(341, 99);
            }
            else //se oculta el panel de detalles de usuario si el valor es false ya que sifnigca que se quiere ocultar el mismo 
            {
                panelDatosUsuario.Visible = false;
                // Establecer el tamaño del data grid es decir lo redimienciono cuando se muestran los detalles del uusario 
                dataGridUsuarios.Location = new System.Drawing.Point(12, 176);
                dataGridUsuarios.Size = new System.Drawing.Size(800, 349); // ancho y alto en píxeles
            }


        }


        /************************************* DAR DE BAJA *************************************/
        private void iconBtnElim_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            CapaLogica.CL_usuario obj_cl_usuario = new CL_usuario();

            //aca digo que si el usuario selecciono una columna en el data grid y ademas el txtid que se encarga de guardar el id del uusario selecionado es disitinto de 0 que entre al if
            //esto lo hago ay que asi me aseguro de que el usuario selecciono una columna en el data grid y que ademas es un usuario valido pq su id se guardo
            if (dataGridUsuarios.SelectedRows.Count > 0 && Convert.ToInt32(txtIdGuardado.Text) != 0)
            {
                DialogResult consulta = MessageBox.Show("¿Desea Dar de bajo el usuario?", "Eliminar Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (consulta == DialogResult.Yes)
                {
                    capaEntidad.usuario obj_usuario = new capaEntidad.usuario
                    {
                        id_usuario = Convert.ToInt32(txtIdGuardado.Text)

                    };


                    obj_cl_usuario.eliminarUsuarioLogico(obj_usuario, out mensaje);

                    //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
                    FrmGestionarUsuario_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para poder darlo de baja ", "Eliminar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //aca muestro en caso de que haya habido algun error en el metodo DarDeBaja o en caso de exito tmabien muestro el mensaje proveniente de mi procedimiento alamcenado
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
            }
        }
        public List<rol> listarRolesCombo(ComboBox p_combo)
        {
            //declaro mi lista que va a contener objetos de tipo rol
            List<rol> listaRol = new CL_rol().listarRol();
            //va a leer todos los items dentro de la lista y Rellena el ComboBox con los roles
            foreach (rol item in listaRol)
            {
                p_combo.Items.Add(item.nombre_rol);
            }
            return listaRol;

        }

        /************************************** DAR DE ALTA UN USUARIO **********************************************/
        private void iconBtnAlta_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;
            CapaLogica.CL_usuario obj_cl_usuario = new CL_usuario();

            //aca digo que si el usuario selecciono una columna en el data grid y ademas el txtid que se encarga de guardar el id del uusario selecionado es disitinto de 0 que entre al if
            //esto lo hago ay que asi me aseguro de que el usuario selecciono una columna en el data grid y que ademas es un usuario valido pq su id se guardo
            if (dataGridUsuarios.SelectedRows.Count > 0 && Convert.ToInt32(txtIdGuardado.Text) != 0)
            {
                DialogResult consulta = MessageBox.Show("¿Desea Dar de Alta el usuario?", "Dar de Alta Datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (consulta == DialogResult.Yes)
                {
                    capaEntidad.usuario obj_usuario = new capaEntidad.usuario
                    {
                        id_usuario = Convert.ToInt32(txtIdGuardado.Text)

                    };


                    obj_cl_usuario.darDeAltaUsuario(obj_usuario, out mensaje);
                }
                //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
                FrmGestionarUsuario_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para poder darlo de Alta ", "Eliminar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //aca muestro en caso de que haya habido algun error en el metodo darDeAlta o en caso de exito tmabien muestro el mensaje proveniente de mi procedimiento alamcenado
            if (mensaje != "")
            {
                MessageBox.Show(mensaje);
            }
        }
        private void ReadOnlyTxtDatoUsuario(bool valor)
        {
            //el parametro valor contiene el valor True o False dependiendo si quiero que este en modo lectura(true) o en modo edicion los campos (false)
            txtDniDato.ReadOnly = valor;
            txtNombreDato.ReadOnly = valor;
            txtApeDato.ReadOnly = valor;
            txtApeDato.ReadOnly = valor;
            // txtPasswordDato.ReadOnly = valor;
            txtTelefDato.ReadOnly = valor;
            txtEmailDato.ReadOnly = valor;
            txtDomiciliodato.ReadOnly = valor;

            //usamos la propeidad enable para que parezca esatr en modo lectura y evitar cambios por parte del usuario,como esta propiedad usa el valor contrario al readOnly para ponerse en modo lectura le agrgamos el ! operador de negacion esto cambiara el valor y asi podremos hacer uso de esa propeidad
            dateTimePickerNacimientoDato.Enabled = !valor;
            comboEstadoDato.Enabled = !valor;
            comboRolDato.Enabled = !valor;
        }

        // Método para buscar el id_rol por la descripción del rol
        private int ObtenerIdRolPorDescripcion(string descripcion)
        {
            List<rol> listaRol = new CL_rol().listarRol();

            foreach (rol item in listaRol)
            {
                if (item.nombre_rol == descripcion)
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
            CapaLogica.CL_usuario obj_cl_usuario = new CL_usuario();
            capaEntidad.usuario obj_usuario_editando = obj_cl_usuario.buscarUsuario(Convert.ToInt32(txtIdGuardado.Text));//aca atravez del metodo buscar usuario obtengo el usuario que se esta editando para asi obtener su id_domicilio y poder obtener su domicilio actual

            //aca usamos el metodo buscar domicilio para traer ese objeto domcilio que se quiere editar
            CapaLogica.CL_domicilio obj_CL_domicilio = new CL_domicilio();
            capaEntidad.domicilio obj_domicilio_editando = obj_CL_domicilio.buscarDomicilioID(obj_usuario_editando.obj_domicilio.id_domicilio); //le paso como parametro el id_domcilio del usuario que se esta editando


            FrmRegistrarDomicilio frmRegistrarDomicilio = new FrmRegistrarDomicilio(obj_domicilio_editando);//le paso como parametro ese objeto domicilio que obtuve atravez del id_domiclio

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

        /************************************* MODIFICAR*******/
        private void iconBtnModif_Click_1(object sender, EventArgs e)
        {
            //aca digo que si el usuario selecciono una columna en el data grid y ademas el txtid que se encarga de guardar el id del uusario selecionado es disitinto de 0 que entre al if
            //esto lo hago ay que asi me aseguro de que el usuario selecciono una columna en el data grid y que ademas es un usuario valido pq su id se guardo
            if (dataGridUsuarios.SelectedRows.Count > 0 && Convert.ToInt32(txtIdGuardado.Text) > 0)
            {
                DialogResult consulta = MessageBox.Show("¿Desea Editar los datos Del usuario?", "Editar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (consulta == DialogResult.OK)
                {

                    iconbtnGuardar.Visible = true;
                    iconBtnCancelar.Visible = true;
                    iconBtnModif.Visible = false;
                    ReadOnlyTxtDatoUsuario(false);//configuro el panel del usuario en modo edicion deshabilit ando la funcion ReadOnly
                }
                //hago para que los text pasen de modo lectura a poder escrbirse sobre ellos 
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para poder editarlo ", "Editar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //cancelar el editar usuario,cancela la modificacion
        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult ask;//se declara una variable llamada ask del tipo DialogResult, que se usará para almacenar el resultado del cuadro de diálogo.
            ask = MessageBox.Show("Seguro que desea cancelar la edicion del usuario ? ", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //como  Todos los msgbox devuelven un resultado lógico. podemos hacer el sig if
            if (ask == DialogResult.Yes)
            {
                //elimino los valores de todos los campos del editar usuario
                txtIdGuardado.Text = "";
                txtEmailDato.Text = "";
                txtPasswordDato.Text = "";
                comboEstadoDato.SelectedIndex = -1;
                txtDniDato.Text = "";
                txtNombreDato.Text = "";
                txtApeDato.Text = "";
                txtTelefDato.Text = "";
                txtDomiciliodato.Text = "";
                panelDatosUsuario.Visible = false;//escondo el panel de editar datos del usuario al cancelar 
            }
            DetallesUsuario(false);//aca oculto el panel luego de que se caneclo la edicion del usuario
        }

        //guardar modificacion
        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            // Crear una instancia de la capa de lógica
            CL_usuario obj_CL_Usuario = new CL_usuario();

            capaEntidad.usuario objUsuario = obj_CL_Usuario.buscarUsuario(Convert.ToInt32(txtIdGuardado.Text));//aca obtengo el usuario que se esta por gurdar la mdoficacion es decir el usuario que se esta ediatando,esto lo hago mientras tanto porque el domicilio es dificil modficar

            if (validarCampos())
            {
                // Crear la variable "ask" del tipo DialogoREsult ya que MsgBoxREsult es parte del lenguaje Basic y no de C#
                DialogResult ask;//se declara una variable llamada ask del tipo DialogResult, que se usará para almacenar el resultado del cuadro de diálogo.
                borrarMensajeError();//borro los mensjaes de error en caso que lo haya

                ask = MessageBox.Show("Seguro que desea Editar el usuario ? ", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Obtener la descripción del rol seleccionado en el ComboBox
                string rolSeleccionadoDescripcion = comboRolDato.SelectedItem as string; //falta poner las valdiaciones del rol seleccionado queesta en festionar usuario

                //como  Todos los msgbox devuelven un resultado lógico. podemos hacer el sig if
                if (ask == DialogResult.Yes) //si la respuesta es si yes entra al id
                {
                    // Buscar el id_rol correspondiente a la descripción seleccionada
                    int idRolSeleccionado = ObtenerIdRolPorDescripcion(rolSeleccionadoDescripcion);

                    capaEntidad.usuario obj_Usuario = new capaEntidad.usuario()
                    {
                        id_usuario = Convert.ToInt32(txtIdGuardado.Text),
                        email = txtEmailDato.Text,
                        password = txtPasswordDato.Text,
                        estado_usuario = estadoUsuarioSeleccionado(comboEstadoDato.SelectedItem as string), //convierto de manera segura selecteditem en un tipo string con as string y sino es posible devuelve null en vez de lanar una excepcion como lo hace .Tostring
                        obj_persona = new persona()
                        {
                            dni = txtDniDato.Text,
                            nombre = txtNombreDato.Text,
                            apellido = txtApeDato.Text,
                            fecha_nacimiento = dateTimePickerNacimientoDato.Value, // Año, mes, día 
                            telefono = txtTelefDato.Text
                        },
                        obj_rol = new rol()
                        {
                            id_rol = idRolSeleccionado

                        },
                        obj_domicilio = new domicilio()
                        {

                            id_domicilio = objUsuario.obj_domicilio.id_domicilio//por ahora el domicilio nose debe de cambiar queda el actual solamente
                        }


                    };

                    bool resultadoEditarUsuario = new CL_usuario().editarUsuario(obj_Usuario, out mensaje);

                    if (resultadoEditarUsuario)
                    {

                        MessageBox.Show("El usuario: " + txtNombreDato.Text + " " + txtApeDato.Text + " se edito correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        iconbtnGuardar.Visible = false;
                        iconBtnCancelar.Visible = false;
                        iconBtnModif.Visible = true;

                        //listo los usuarios aca porque en teoria se actualizo la lista de los usuario es decir que se modifco esa lista entonces la actualizo
                        //por ewsto uso capaentidad.usuario ya que es necesario especificar de manera explícita a cuál usuario te estás refiriendo,lo HAGOcalificando el nombre de la clase usuario con el espacio de nombres al que pertenece. 
                        
                        //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
                        FrmGestionarUsuario_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso

                        limpiartxtDato();//limpio los campos del panel de datos 
                    }
                    else
                    {

                        MessageBox.Show("El usuario: " + txtNombreDato.Text + " " + txtApeDato.Text + " No se edito correctamente ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        iconbtnGuardar.Visible = false;
                        iconBtnCancelar.Visible = false;
                        iconBtnModif.Visible = true;
                        //no actualizo el datgrid ya que no se edito ningun elemento
                        limpiartxtDato();//limpio los campos del panel de datos 
                    }
                    //aca muestro en caso de que haya habido algun error en el metodo resultadoEditarUsuario el error del mensaje o en caso de exito tmabien muestro el mensaje proveniente de mi proceso alamcenado
                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje);
                    }

                }
                DetallesUsuario(false);//aca oculto el panel luego de que se edito el usuario 

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
                validacion = false;
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

        // Función para verificar si una cadena contiene solo letras y un sol oespacio por palabra
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
                                                           // errorProvider1.SetError(lblPassword, ""); // Limpiar mensaje de error
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
            // Limpiar el ComboBox Roles Eliminando todos los elementos ya que una vez que el usuario selecciona otros datos o slae del panel de datos del usuario debo de limpiarlo para que nose cargue siempre el combobox
            comboRolDato.Items.Clear();
            comboRolDato.Text = "Seleccione un Rol"; // aca le paso el texto predeterminado que quiero que tenga el combo

            comboEstadoDato.Items.Clear();
            comboEstadoDato.Text = "Seleccione un Estado"; // aca le paso el texto predeterminado que quiero que tenga el combo
        }

        //en este evento se actualizara el friltro del dataGrid de usuarios cada vez que se cambie el texto del mi textBox
        private void txtDniFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtDniFiltro.Text;
            string atributo = "dni";
            // Filtra los datos en el DataGridView
            FiltrarDataGridView(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }

        private void txtNombreFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNombreFiltro.Text;
            string atributo = "nombre";
            // Filtra los datos en el DataGridView
            FiltrarDataGridView(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }

        private void txtApeFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtApeFiltro.Text;
            string atributo = "apellido";
            // Filtra los datos en el DataGridView
            FiltrarDataGridView(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }
        private void comboFiltroEstado_TextChanged_1(object sender, EventArgs e)
        {
            string filtro = "";
            string atributo = "estado_usuario";

            switch (comboFiltroEstado.SelectedIndex)
            {
                //caso de que el usuario eleja mostrar los usuarios activos
                case 0:
                    filtro = "1"; FiltrarDataGridView(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro  
                    break;
                //case para mostrar los usuarios inactivos
                case 1:
                    filtro = "0"; FiltrarDataGridView(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro  
                    break;

                default: break;
            }
        }

        private void comboFiltroRol_TextChanged(object sender, EventArgs e)
        {
            // Añade la condición de filtrado según el atributo
            string filtro = "";
            string atributo = "rol_usuario";
            switch (comboFiltroRol.SelectedIndex)
            {
                case 0: //case del admin
                    filtro = "1";
                    FiltrarDataGridView(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro  
                    break;

                case 1: //case del gerente
                    filtro = "2";
                    FiltrarDataGridView(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
                    break;

                case 2: //case del vendedor
                    filtro = "3";
                    FiltrarDataGridView(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
                    break;

                default: break;

            }
        }

        private void FiltrarDataGridView(string filtro, string atributo)
        {
            // Crear una instancia de la capa de lógica
            CL_usuario obj_CL_Usuario = new CL_usuario();
            //por ewsto uso capaentidad.usuario ya que es necesario especificar de manera explícita a cuál usuario te estás refiriendo,lo HAGOcalificando el nombre de la clase usuario con el espacio de nombres al que pertenece. 
            List<capaEntidad.usuario> listaUsuarioFiltrado = obj_CL_Usuario.listarUsuarioFiltrados(filtro, atributo); // Obtener la lista de usuarios desde la capa de lógica

            // Actualiza el DataGridView
            mostrarUsuariosEnDataGridView(listaUsuarioFiltrado);

        }

        //funcionalidad par alimpair el filtro
        private void iconbtnClean_Click(object sender, EventArgs e)
        {
            /*
            //limpio todos los campos de los filtros
            txtDniFiltro.Text = "Filtrar Dni";
            txtNombreFiltro.Text = "Filtrar nombre";
            txtApeFiltro.Text = "Filtrar Apellido";
            comboFiltroEstado.Text = "Filtrar Estado";
            comboFiltroRol.Text = "Filtrar Rol";*/ //no necesito hacer esto ya que al llmar al metodo load me ahorra tener que limpiar los campos ya que vuelven a sus valores predeterminados

            //vuelvo a listar el datagrid con la lista sin filtrar 
            //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
            FrmGestionarUsuario_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
        }

        /*********exporto los datos en formato excel *******************/
        private void iconBtnExcel_Click(object sender, EventArgs e)
        {
            //aca digo que me permita imprimir el excel solo si posee alguna fila el datagrid 
            if (dataGridUsuarios.Rows.Count > 0)
            {
                DataTable datatableExcel = new DataTable(); //aca creo un obj datatable "datatableExcel" para poder guardar el encabezado de cada columna

                foreach (DataGridViewColumn columna in dataGridUsuarios.Columns) //aca digo que recorra las columns de mi datagrid usuario
                {
                    //este if me permite no guardar la cabecera de columnas que no quiero por ej id_rol y id_usuario
                    if (columna.HeaderText != "Id_usuario" && columna.HeaderText != "id_domicilio" && columna.HeaderText != "id_rol" && columna.HeaderText != "Password")
                    {
                        datatableExcel.Columns.Add(columna.HeaderText, typeof(string)); //aca agrego el headertext de mi columna que se esta recorriendo en ese momento al datatableExcel  es decir inserto todas las cabceras en mi datagridexcel

                    }
                }

                //recorro y inserto todas mis filas de mi datagrid usuario en mi datatableexcel que es de tipo datatable
                foreach (DataGridViewRow filas in dataGridUsuarios.Rows) //aca digo que recorra las columns de mi datagrid usuario
                {
                    //aca digo que se guarden en el excel solo las filas que estan visibles en ese momento ej.si aplico un filtro de que filas mostrar que solo guarden esas filas visibles unicamente en el excel
                    if (filas.Visible)
                    {
                        //aca creo un nuevo objeto array y accedo a una fila y en esa fila que accedi que se guarden lso valores de cada cells o celda de cada columna , y asi haria con cada fila de mi datagridpwemiso
                        datatableExcel.Rows.Add(new object[]
                        {//aca guardo los valores de las columnas de esa fila que accedi puedo guardar todas las columnsa o puedo poner solo las columnas que quiero el valor pero debe de coincidir con la cabecera que guarde
                            filas.Cells[1].Value.ToString(),
                            filas.Cells[2].Value.ToString(),
                            filas.Cells[3].Value.ToString(),
                            filas.Cells[4].Value.ToString(),
                            filas.Cells[5].Value.ToString(),
                            filas.Cells[8].Value.ToString(),
                            filas.Cells[10].Value.ToString(),
                            filas.Cells[11].Value.ToString(),
                            filas.Cells[12].Value.ToString(),
                            filas.Cells[13].Value.ToString(),
                            filas.Cells[14].Value.ToString(),
                        });
                    }
                }

                //aca le pregunto al usuario en que parte quiere guardar al archivo excel a este obj lo llamare saveFile
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteUsuario{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss")); //aca le asigno el nobre predetemrinado que tendra mi archivo y con format obtengo un mayor control sobre el texto luego al nombre le concateno la fecha y hora
                saveFile.Filter = "Excel Files | *.xlsx"; //aca estoy agregando un filtro a la ventana de donde quiero que se guarden para que al momento de mostrarse solo se muestren ese tipo de archivos con esa extension

                //aca digo si en el evento showdialog de la ventana de savefile se dio al evento ok que entre al if
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //aca comienzo a manipular el nugget de excel que instale para poder crear y exportar el mismo 
                        XLWorkbook wb = new XLWorkbook(); //aca creo el archivo excel
                        var hoja = wb.Worksheets.Add(datatableExcel, "Informe Usuario"); //aca creo una variable que sera la hoja de mi excel
                        hoja.ColumnsUsed().AdjustToContents(); //aca le decimo que se ajuste el contenido al ancho de las columnnas que tienen contenidos unicamente
                        wb.SaveAs(saveFile.FileName); //aca con el saveas (guardar como) guardo mi excel en la ruta que le paso como parametro que determine anteriormente en savefile.filename
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo Generar el Reporte, ocurrio un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

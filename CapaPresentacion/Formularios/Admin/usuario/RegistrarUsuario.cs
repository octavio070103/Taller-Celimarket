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

using capaEntidad;
using CapaLogica;
using CapaPresentacion.Formularios.Admin.usuario;

namespace CapaPresentacion.Formularios.Admin
{
    public partial class RegistrarUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        private int id_Domicilio_Generado; // Variable para almacenar el id_domicilio_registrado

        public RegistrarUsuario(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
            
             dateTimePickerNacimiento.MaxDate=DateTime.Now.AddYears(-18);//la fecha maxima para elegir de ancimiento es la fecha actual menos 18 anios,es decir que el minima de edad para poder registrador como usuario es de 18 anios
            dateTimePickerNacimiento.MinDate=DateTime.Now.AddYears(-100);//la edad maxima para tener y registrarse es de 100 anios comparada a la fecha actual
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
                comboRolUsu.Items.Add(item.nombre_rol);
            }

           
            //dateTimePickerNacimiento.Value = DateTime.UtcNow;//configuro para que el valor inicial del datetime sea el de la fecha de hoy
        }

        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            int id_usuario_generado;

            // Obtener la descripción del rol seleccionado en el ComboBox
            string rolSeleccionadoDescripcion = comboRolUsu.SelectedItem as string;

            if (rolSeleccionadoDescripcion != null)
            {
                // Buscar el id_rol correspondiente a la descripción seleccionada
                int idRolSeleccionado = ObtenerIdRolPorDescripcion(rolSeleccionadoDescripcion);

                if (idRolSeleccionado != -1)
                {
                    if (validarCampos())
                    {
                        borrarMensajeError();//borro los erroProvider de lso label

                        capaEntidad.usuario obj_usuario = new capaEntidad.usuario() //creo mi objeto obj_usuario que es de tipo usuario y con las llaves indiico que le pasare los valores a sus respetctivos atributos
                        {

                            email = txtEmailUsu.Text,
                            password = txtPasswordUsu.Text,
                            estado_usuario = 1,
                            obj_persona = new persona()
                            {
                                dni = txtDniUsu.Text,
                                nombre = txtNombreUsu.Text,
                                apellido = txtApelliUsu.Text,
                                fecha_nacimiento = dateTimePickerNacimiento.Value, // Año, mes, día 
                                telefono = txtTelefUsu.Text
                            },
                            obj_rol = new rol()
                            {
                                id_rol = idRolSeleccionado

                            },

                            obj_domicilio = new domicilio()
                            {
                                id_domicilio = id_Domicilio_Generado,
                            }


                        };

                        id_usuario_generado = new CL_usuario().registrarUsuario(obj_usuario, out mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show(mensaje);
                        }
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
                if (item.nombre_rol == descripcion)
                {
                    return item.id_rol;
                }
            }

            // Si no se encuentra la descripción, devuelve -1 para indicar un error.
            return -1;
        }

        private bool validarCampos()
        {
            bool validacion = true;
            string dni = txtDniUsu.Text;
            string nombre = txtNombreUsu.Text;
            string apellido = txtApelliUsu.Text;
            string email = txtEmailUsu.Text;
            string telefono = txtTelefUsu.Text;
            string password = txtPasswordUsu.Text;
            string domicilio = txtDomRegistrado.Text;
            DateTime validacionFechaMax = dateTimePickerNacimiento.MaxDate;
            DateTime validacionFechaMin = dateTimePickerNacimiento.MinDate;

            int numero = 0;

            string nombreCompleto = nombre + " " + apellido;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(telefono)
                || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(domicilio))
            {
                // MessageBox.Show("Debe de completar todos los campos");
                MessageBox.Show("Por favor, Rellene todos los campos para poder editar el Usuario", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validacion = false;
            }

            // Validar que los campos Apellido y Nombre contengan solo letras
            if (!EsAlfabetico(nombre))
            {
                errorProvider1.SetError(lblNombre, "Ingrese su nombre");
                MessageBox.Show(" El nombre debe de contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            if (!EsAlfabetico(apellido))
            {
                errorProvider1.SetError(lblApellido, "Ingrese su apellido");
                MessageBox.Show(" El apellido debe de contener solamente letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //validar que el campos Dni solo se ingresen numeros
            if (!int.TryParse(dni, out numero))
            {
                errorProvider1.SetError(lblDni, "Ingrese su DNI correctamente");
                MessageBox.Show("El Dni debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //validar que el campos telefono solo se ingresen numeros
            if (!int.TryParse(telefono, out numero))
            {
                errorProvider1.SetError(lblTelefono, "Ingrese su telefono correctamente");
                MessageBox.Show("El telefono debe de contener solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            if (!validarEmail(email))
            {
                errorProvider1.SetError(lblEmail, "Ingrese su email valido formato: correo@example.com");
                MessageBox.Show(" El email debe de seguir el formato correo@example.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //aca pregunto que si le fechaMax es decir que el usuario minimamente tenga 18 anios para ser usuario que si tiene selccionada una fecha que no cumpla que me salta el error y no me dejed registrar
            if (dateTimePickerNacimiento.Value > validacionFechaMax)//si la fecha que sel;cciono es mayor a la que MAx que deterine que salte la validacion
            {
                errorProvider1.SetError(lblFechaNacimiento, "Ingrese  una fecha validad");
                MessageBox.Show(" Debe de tener como minimo 18 años para poder registrarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }
            //aca pregunto que si le fechaMin es decir que el usuario com omaximo tenga 100 anios para ser usuario que si tiene mas de 100 selccionada una fecha que no cumpla que me salta el error y no me dejed registrar
            if (validacionFechaMin > dateTimePickerNacimiento.Value)//si la fecha que sel;cciono es menor a la que Min que deterine que salte la validacion
            {  
                errorProvider1.SetError(lblFechaNacimiento, "Ingrese  una fecha validad");
                MessageBox.Show(" El usuario puede tener 100 años como maximo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //valido que el id_generado del domicilio sea = 0 ya que esto significa que se genero un domicilio ,ya que sino se genero correctamente ese id=0
            /*
            if ( (Convert.ToInt32(txtIdDomRegistrado.Text)) == 0)
            {
                errorProvider1.SetError(lblEmail, "Vuelva a ingresar su domicilio ,ocurrio un error");
                MessageBox.Show(" Debe de rellenar todos los campos del domicilio y de manera precisa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }*/
            return validacion;
        }

        // Función para verificar si una cadena contiene solo letras
        private bool EsAlfabetico(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        // toma una cadena que representa un email y utiliza una expresión regular para verificar si se ajusta a un formato de email válido. El patrón de expresión regular ^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$ verifica que el email tenga el formato correcto, como "nombre@dominio.com".
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
            errorProvider1.SetError(lblDni, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblNombre, "");    // Limpiar mensaje de error
            errorProvider1.SetError(lblApellido, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblEmail, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblTelefono, ""); // Limpiar mensaje de error
            errorProvider1.SetError(lblPassword, ""); // Limpiar mensaje de error
        }

        private void iconBtnLimpiarDatos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtNombreUsu.Text=string.Empty;
            txtApelliUsu.Text = string.Empty;
            txtDniUsu.Text = string.Empty;
            txtDomRegistrado.Text = string.Empty;
            iconBtnDomicilio.Visible = true;
            txtTelefUsu.Text = string.Empty;
            txtEmailUsu.Text = string.Empty;
            txtPasswordUsu.Text = string.Empty;

            dateTimePickerNacimiento.Value = DateTime.MaxValue;
           
        }

        private void iconBtnDomicilio_Click(object sender, EventArgs e)
        {


            FrmRegistrarDomicilio frmRegistrarDomicilio = new FrmRegistrarDomicilio(null); //le paso como paremtro null ya que este contructor recibe un obj_domicilio le paso null cuando es la primera vez que registro un domiclio sino le paso el domiclio a editar

            // Abre el formulario secundario de manera modal,hago esto para esperar que el form se cierre para pdoer acceder a el y traer el id_generado sino si uso show el cod que sigue se sigue ejecutando si esperar a que se cierre el formualrio 
            if (frmRegistrarDomicilio.ShowDialog() == DialogResult.OK) //ShowDialog() abrirá el formulario secundario de manera modal, lo que significa que el código en el formulario principal esperará hasta que se cierre el formulario secundario antes de continuar.
            {
                // Obtén el id_domicilio_registrado del formulario secundario después de que se haya cerrado
                id_Domicilio_Generado = frmRegistrarDomicilio.id_domicilio_registrado;

                //hago viisible y coulto txt box que contienen el domcilio y el otro el btn de agrgsr lo oculto
                txtDomRegistrado.Visible = true;
                iconBtnDomicilio.Visible = false;
            }

            //metodo para traer los dtos del domicilio que recien se inserto en la base de datos 
            CL_domicilio obj_CL_domicilio = new CL_domicilio();
            domicilio obj_domicilio = new domicilio(); //creo un obj de tipo domicilio apra guardar el resutado del buscar domiclio y poder acceder a sus atributos

            obj_domicilio = obj_CL_domicilio.buscarDomicilioID(id_Domicilio_Generado);
            if (obj_domicilio != null)
            {
                txtDomRegistrado.Text = obj_domicilio.calle + " " + obj_domicilio.numero;
            }
            else
            {
                MessageBox.Show(" No se encontro el domicilio insertado,vuelva a insertar ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //hago viisible el btn y oculto el tx  que contienen el domcilio 
                txtDomRegistrado.Visible = false;
                iconBtnDomicilio.Visible = true;
            }

        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            //reseteo o elimino los valores de los campos al momento de canecelar para que quede todo vacio como cuando se inicia el fomr
            txtNombreUsu.Text = string.Empty;
            txtApelliUsu.Text = string.Empty;
            txtDniUsu.Text = string.Empty;
            txtTelefUsu.Text = string.Empty;
            txtEmailUsu.Text = string.Empty;
            txtPasswordUsu.Text = string.Empty;
            txtDomRegistrado.Text = string.Empty;
            iconBtnDomicilio.Visible = true;

            dateTimePickerNacimiento.Value = DateTime.Now;
        }
    }
}

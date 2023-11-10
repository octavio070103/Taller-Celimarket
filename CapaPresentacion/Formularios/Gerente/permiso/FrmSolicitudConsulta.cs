using capaEntidad;
using CapaLogica;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using SixLabors.Fonts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Controls; si tengo errore con algo activo este

namespace CapaPresentacion.Formularios.Gerente.permiso
{
    public partial class FrmSolicitudConsulta : Form
    {
        private static capaEntidad.usuario usuarioActual;
        public FrmSolicitudConsulta(capaEntidad.usuario obj_usuario_actual)
        {
            InitializeComponent();
            usuarioActual = obj_usuario_actual;
            cargarDatosUsuario();
        }
        private void picMinPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmSolicitudConsulta_Load(object sender, EventArgs e)
        {
            //carga el combobox de motivo_consulta que conteien los motivos que peude seleccionar el usuario  Uso de la función con una lista de motivo_consulta y el combo de motivo_consulta
            CL_Consulta obj_CL_Consulta = new CL_Consulta();
            List<motivo_consulta> listaMotivo_consulta = obj_CL_Consulta.listaMotivosConsulta(); //con esta funcion obtenemos una lista de  marcas que estan cargadas en la BD
            CargarComboBox(listaMotivo_consulta, comboMotivo_consulta, motivo_consulta => motivo_consulta.nombre_motivo_consulta);

        }

        /***metodo para cargar los textBox del usuario y la interfez que va a ver al iniciar el formulario dependiendo de sus datos de usuario(si ya tiene otras consultas o sino tiene) **/
        public void cargarDatosUsuario()
        {
            //creo una isntancia de mi capa logica consulta
            CL_Consulta obj_CL_Consulta = new CL_Consulta();

            //aca busco las consulta de este usuario atravez de su id_usuario para que si existe que me cargue en el datagrid las anteriores consultas y sino tiene consultas que no me muestre este panel de cosnultas anteriores
            List<consulta> listaConsulPorIdUsuario = obj_CL_Consulta.buscarConsultasPorIdUsuario(usuarioActual.id_usuario);
            if (listaConsulPorIdUsuario.Count > 0)//aca pregunto si la cantidad de elementos que tiene estra losta es mayor a 0 entonces significa que teine consultas y si este usuario tiene vinculado consultas anteriores que me muestre el panel de las consultas anteriores
            {
                cargarDatosConsultasAnteriores(listaConsulPorIdUsuario);

            }
            else
            { //sino lo tiene lo que hace es cargerme los datos del usuario y me permite completar la consulta sin mostrarme el panel de consultas anteriores
                cargarDatosPrimeraConsulta();
            }
        }
        private void cargarDatosConsultasAnteriores(List<consulta> p_listaConsulPorIdUsuario)
        {
            //hago visibole el panel que oculte que me va a mostrar las consultas anteriores de ese usuario
            panelConsulAnteriores.Visible = true;
            plTituloConsulAntes.Visible = true;

            txtNombre.Text = usuarioActual.obj_persona.nombre;
            txtApellido.Text = usuarioActual.obj_persona.apellido;
            txtEmail.Text = usuarioActual.email;
            txtDni.Text = usuarioActual.obj_persona.dni;
            txtRol.Text = usuarioActual.obj_rol.nombre_rol;
            txtTel.Text = usuarioActual.obj_persona.telefono;

            //hago para que sean solo de lectura esos campos ya que no debo de permitir que pueda editar estos campos del usuario 
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtDni.ReadOnly = true;
            txtRol.ReadOnly = true;
            txtTel.ReadOnly = true;

            //me falta aca cargar el datagrid con los form anteriores
            CL_Consulta obj_CL_Consulta = new CL_Consulta();

            cargarDataGridConsultasAnteriores(obj_CL_Consulta.buscarConsultasPorIdUsuario(usuarioActual.id_usuario)); //aca le paso la lisat de consultas anteriores de ese usuario que lo obtengo atraves del metodo buscarcosnultasidusuario que me devulve las consul anteriores
        }

        private void cargarDataGridConsultasAnteriores(List<consulta> p_listaConsultasDelUsu)
        {
            dataGridConsultas.Rows.Clear(); // Limpiar filas existentes
            foreach (capaEntidad.consulta item in p_listaConsultasDelUsu)
            {

                // Agregar una fila al DataGridView con los datos del usuario
                dataGridConsultas.Rows.Add(
                    new object[]
                    {  //items de motivo_consulta
                       item.id_consulta,item.obj_motivo_consulta.nombre_motivo_consulta,
                      //items de consulta del usuario,
                      item.id_consulta,item.comentario_consulta,item.fecha_consulta,item.estado_consulta, //aca tambien casteo mi atributo fecha que es de tipo datetime a date
                     item.obj_usuario.id_usuario
                     }
                 );

            }
            dataGridConsultas.ClearSelection();//quita la seleccion de fila por defecto que tiene el data grid

        }

        private void cargarDatosPrimeraConsulta()
        {
            txtNombre.Text = usuarioActual.obj_persona.nombre;
            txtApellido.Text = usuarioActual.obj_persona.apellido;
            txtEmail.Text = usuarioActual.email;
            txtDni.Text = usuarioActual.obj_persona.dni;
            txtRol.Text = usuarioActual.obj_rol.nombre_rol;
            txtTel.Text = usuarioActual.obj_persona.telefono;

            //hago para que sean solo de lectura esos campos ya que no debo de permitir que pueda editar estos campos del usuario 
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtRol.ReadOnly = true;
            txtDni.ReadOnly = true;
            txtTel.ReadOnly = true;
        }

        //metodo para cargar combobox generico ,este metodo toma un obj de tipo T( tipo generico) y carga el combo box (para distintos objetos y distintos campo que quiero que se cargue dentro del cambo
        //T=tipodeObj representa el tipo de dato con el que trabajara,List<T> es una lista genérica que contiene elementos de tipo T,p_comboBox=es el combo al que quiero cargar,es un delegado funcional que toma un objeto de tipo T y devuelve una cadena.(ej si quiero obtener el nombre de cada rol le pasaria esto rol => rol.Nombre)
        //Esto permite personalizar cómo se extrae el texto de los elementos de la lista de tipo T para mostrarlos en el ComboBox.
        private void CargarComboBox<T>(List<T> lista, ComboBox p_comboBox, Func<T, string> obtenerTexto)
        {
            p_comboBox.Items.Clear(); // Limpia los elementos existentes en el ComboBox.

            foreach (T item in lista)
            {
                string texto = obtenerTexto(item);
                p_comboBox.Items.Add(texto);
            }
        }

        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            int id_consulta_generado = 0;

            if (validarCampos())
            {
                capaEntidad.consulta obj_consulta = new capaEntidad.consulta()
                {
                    comentario_consulta = txtComentarioConsulta.Text,
                    obj_usuario = usuarioActual,//le paso el usuarioa actual que contiene todos los datos necesario del usuario
                    //aca le paso el id_motivo_consulta atravses del metodo que lo consigue para poder registrar mi cosnulta
                    obj_motivo_consulta = new motivo_consulta()
                    {
                        id_motivo_consulta = obtenerIDMotivoConsultaSeleccionada() // tengo que validar esto en el metodo validar campo ya que si es = 0 significa que el usuario no seleccionada
                    }
                };
                id_consulta_generado = new CL_Consulta().registrarConsulta(obj_consulta, out mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }
                FrmSolicitudConsulta_Load(this, EventArgs.Empty);
            }
        }
        private bool validarCampos()
        {
            bool validacion = true;

            string nombreUsu = txtNombre.Text;
            string apeUsu = txtApellido.Text;
            string correo = txtEmail.Text;
            string dniUsu = txtDni.Text;
            string rolUsu = txtRol.Text;
            string telefUsu = txtTel.Text;
            string consulta = txtComentarioConsulta.Text;
            string? motivoConsulta = comboMotivo_consulta.SelectedItem.ToString();

            int numero = 0;

            if (string.IsNullOrEmpty(nombreUsu) || string.IsNullOrEmpty(apeUsu) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(dniUsu) || string.IsNullOrEmpty(rolUsu)
               || string.IsNullOrEmpty(telefUsu) || string.IsNullOrEmpty(consulta) || string.IsNullOrEmpty(motivoConsulta))
            {
                MessageBox.Show("Por favor, Rellene todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validacion = false;
            }

            // Validar que los campos nombreUsu  contengan solo letras
            if (!EsAlfabetico(nombreUsu))
            {
                errorProvider1.SetError(lblNombre, "El nombre del usuario nose cargo correctamente");
                MessageBox.Show("Cierre la Ventana y vuelva a abrirla por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            // Validar que los campos descripcion y Nombre contengan solo letras
            if (!EsAlfabetico(apeUsu))
            {
                errorProvider1.SetError(lblApelli, "El apellido del usuario nose cargo correctamente");
                MessageBox.Show("Cierre la Ventana y vuelva a abrirla por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            if (!validarEmail(correo))
            {
                errorProvider1.SetError(lblCorreo, "El email del usuario nose cargo correctamente");
                MessageBox.Show("Cierre la Ventana y vuelva a abrirla por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            //validar que el campos Dni solo se ingresen numeros
            if (!int.TryParse(dniUsu, out numero))
            {
                errorProvider1.SetError(lblDni, "El dni del usuario nose cargo correctamente");
                MessageBox.Show("Cierre la Ventana y vuelva a abrirla por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            // Validar que los campos descripcion y Nombre contengan solo letras
            if (!EsAlfabetico(rolUsu))
            {
                errorProvider1.SetError(lblRol, "El rol del usuario nose cargo correctamente");
                MessageBox.Show(" Cierre la Ventana y vuelva a abrirla por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            // Validar que los campos descripcion y Nombre contengan solo letras
            if (!EsAlfabetico(motivoConsulta))
            {
                errorProvider1.SetError(comboMotivo_consulta, "Seleccione una Consulta Valida");
                MessageBox.Show(" Veulva a seleccionar La consulta por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }


            return validacion;
        }

        public int obtenerIDMotivoConsultaSeleccionada()
        {
            int id_motivo_consulta_obtenido = 0;

            //aca pregunto que si selecciono un item en el combobox motivo_consulta que entre al if
            if (comboMotivo_consulta.SelectedItem != null)
            {
                CL_Consulta obj_CL_Consulta = new CL_Consulta(); //creo un obj CL_Consulta donde voy a tener mi metodo para obtener el obj_motivo_consulta atraves del nombre 
                string? nombre_motivo_consulta = comboMotivo_consulta.SelectedItem.ToString();//aca convierto a string el nombre del motivo_consulta que selecciono en el combo box para psarle como parametro a mi metodo

                // Verificar que tipoSeleccionado no sea nulo o vacío antes de usarlo
                if (!string.IsNullOrWhiteSpace(nombre_motivo_consulta))
                {
                    //llamo al metodo obtenerIDCategoriaSeleccionada el cual busca en la base de datos apartir del nombre de la categoria y si cocindice trae su id_categoria 
                    id_motivo_consulta_obtenido = obj_CL_Consulta.obtenerIDMotivoConsultaSeleccionada(nombre_motivo_consulta);
                }
            }
            return id_motivo_consulta_obtenido;//si encontro va a retorna el id encontrado y sino retorna 0

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

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas cancelar el registro de la consulta ?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {//si cancela se borra todo el contenido del form sin editar lo que el usuario haya modficado o cambiado ya que no el dio a confirmar             
                txtComentarioConsulta.Text = string.Empty;

            }
        }
    }
}

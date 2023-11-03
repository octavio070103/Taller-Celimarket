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

namespace CapaPresentacion.Formularios.Gerente.permiso
{
    public partial class FrmSolicitudPermiso : Form
    {

        private static capaEntidad.usuario usuarioActual;
        public FrmSolicitudPermiso(capaEntidad.usuario obj_usuario_actual)
        {
            InitializeComponent();
            usuarioActual = obj_usuario_actual;
            cargarDatosUsuario();
            //this.StartPosition = FormStartPosition.Manual;
            // this.Location = new Point(650, 200); // Define la posición en pantalla

        }

        private void picMinPantalla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FrmSolicitudPermiso_Load(object sender, EventArgs e)
        {
            //carga el combobox de motivo_permiso que conteien los motivos que peude seleccionar el usuario  Uso de la función con una lista de motivo_permiso y el combo de motivo_permiso
            CL_Permiso obj_CL_Permiso = new CL_Permiso();
            List<motivo_permiso> listaMotivo_permiso = obj_CL_Permiso.listarMotivoPermiso(); //con esta funcion obtenemos una lista de  marcas que estan cargadas en la BD
            CargarComboBox(listaMotivo_permiso, comboMotivo_permiso, motivo_permiso => motivo_permiso.nombre_motivo_permiso);

            //aca establezco la fecha predeterminadas de los datetime desde y la fecha limite (min y max que puede tener)
            dateTimePickerDesde.Value = DateTime.Now;//aca digo que la fecha predetemrinada al abrir el programa que sea la de hoy 
            dateTimePickerDesde.MinDate = DateTime.Now;  // La fecha mínima para el datetime "desde" va a ser  va a ser la de hoy en la que se ejecuta el programa
            dateTimePickerDesde.MaxDate = DateTime.Now.AddMonths(6); // La fecha maxima para el datetime "desde" va a ser  va a ser la de  6 meses desde la fecha actual en la que se ejecuta el programa(obtenida a través de DateTime.Now).

            //datetime hasta
            dateTimeHasta.Value = DateTime.Now.AddDays(1);//la fecha predeterminada para este datetime va a ser 1 dia desde la fecha Actual en la que se ejcuta el programa
            dateTimeHasta.MinDate = DateTime.Now;  // La fecha mínima para el datetime  va a ser  va a ser la de hoy en la que se ejecuta el programa
            dateTimeHasta.MaxDate = DateTime.Now.AddMonths(6);// La fecha maxima para el datetime "desde" va a ser  va a ser la de  6 meses desde la fecha actual en la que se ejecuta el programa(obtenida a través de DateTime.Now).

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /***metodo para cargar los textBox del usuario que inicio sesion con sus datos de la base **/
        public void cargarDatosUsuario()
        {
            //creo una isntancia de m icapa logica permiso
            CL_Permiso obj_CL_Permiso = new CL_Permiso();

            //aca busco el permiso de este usuario atravez de su id_usuario para que si existe que me cargue el permiso directamente y sino que pueda ingresar
            capaEntidad.permiso obj_permiso = obj_CL_Permiso.buscarPermisoPorIdUsuario(usuarioActual.id_usuario);
            if (obj_permiso != null)//si este usuario tiene vinculado un permiso a su id l oque hace es cargarme los datos de ese permiso
            {
                cargarDatosDelPermiso(obj_permiso);

            }
            else
            { //sino lo tiene lo que hace es cargerme los datos del usuario y me permite completar el permiso para pedirlo
                cargarDatosNuevoPermiso();
            }
        }
        //si un usuario tiene vinculado un permiso ,me permite solo ver ese permiso sus datos y no poder editar el permiso ni pedir uno nuevo hasta qu este finalice o sea rechazado
        private void cargarDatosDelPermiso(capaEntidad.permiso p_obj_permiso)
        {
            //hago visibole el panel que oculte
            panelEstadoPermiso.Visible = true;
            paneltituEstado.Visible = true;

            txtNombre.Text = p_obj_permiso.obj_usuario.obj_persona.nombre;
            txtApellido.Text = p_obj_permiso.obj_usuario.obj_persona.apellido;
            txtEmail.Text = p_obj_permiso.obj_usuario.email;
            txtDni.Text = p_obj_permiso.obj_usuario.obj_persona.dni;
            txtRol.Text = p_obj_permiso.obj_usuario.obj_rol.nombre_rol;
            txtTelefono.Text = p_obj_permiso.obj_usuario.obj_persona.telefono;
            dateTimePickerDesde.Value = p_obj_permiso.fecha_inicio;
            dateTimeHasta.Value = p_obj_permiso.fecha_finalizacion;
            lblEstadoPermiso.Text = p_obj_permiso.estado_aprobacion;
            txtJustificacion.Text = p_obj_permiso.comentario_justificacion;
            comboMotivo_permiso.Text = p_obj_permiso.obj_motivo_permiso.nombre_motivo_permiso;

            //hago para que sean solo de lectura esos campos  ya que no debo de permitir que pueda editar estos campos del usuario 
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtDni.ReadOnly = true;
            txtRol.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtJustificacion.ReadOnly = true;

            dateTimeHasta.Enabled = false;
            dateTimePickerDesde.Enabled = false;
            lblEstadoPermiso.Enabled = false;
            comboMotivo_permiso.Enabled = false;

            //oculto los botoners de guardar y cancelar ya que aqui solo puedo ver es de solo lectura cuando ya exitse el permiso de este usuario
            iconBtnCancelar.Visible = false;
            iconbtnGuardar.Visible = false;
        }

        //si el usuario no tiene un pemriso vinculado me rellena los campos del usuario y me permite llenar lso campos del eprmiso
        private void cargarDatosNuevoPermiso()
        {
            txtNombre.Text = usuarioActual.obj_persona.nombre;
            txtApellido.Text = usuarioActual.obj_persona.apellido;
            txtEmail.Text = usuarioActual.email;
            txtDni.Text = usuarioActual.obj_persona.dni;
            txtRol.Text = usuarioActual.obj_rol.nombre_rol;
            txtTelefono.Text = usuarioActual.obj_persona.telefono;
            //hago para que sean solo de lectura esos campos ya que no debo de permitir que pueda editar estos campos del usuario 
            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtRol.ReadOnly = true;
            txtDni.ReadOnly = true;
            txtTelefono.ReadOnly = true;
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

        /*** Aca registro la solictud de permiso del usuario ***/
        private void iconbtnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            int id_permiso_generado = 0;

            if (validarCampos())
            {
                capaEntidad.permiso obj_permiso = new capaEntidad.permiso()
                {
                    fecha_inicio = dateTimePickerDesde.Value,
                    fecha_finalizacion = dateTimeHasta.Value,
                    comentario_justificacion = txtJustificacion.Text,
                    estado_aprobacion = "pendiente",
                    estado_permiso = 1,
                    obj_usuario = usuarioActual,//le paso el usuarioa actual
                    obj_motivo_permiso = new motivo_permiso
                    {
                        id_motivo_permiso = obtenerIDMotivoPermiso()//tengo que validar esto en el metodo validar campo ya que si es =0 significa que el usuario no seleccionada
                    }
                };

                id_permiso_generado = new CL_Permiso().registrarPermiso(obj_permiso, out mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }

            }

        }

        private bool validarCampos()
        {
            bool validacion = true;

            return validacion;
        }

        public int obtenerIDMotivoPermiso()
        {
            int id_motivo_permiso_obtenido = 0;

            //aca pregunto que si selecciono un item en el combobox motivoPermiso que entre al if
            if (comboMotivo_permiso.SelectedItem != null)
            {
                CL_Permiso obj_CL_Permiso = new CL_Permiso(); //creo un obj CL_Permiso donde voy a tener mi metodo para obtener elobj_motivo_permiso atraves del nombre 
                string? nombre_motivo_permiso = comboMotivo_permiso.SelectedItem.ToString();//aca convierto a string el nombre del moitivo_permiso que selecciono en el combo box para psarle como parametro a mi metodo

                // Verificar que tipoSeleccionado no sea nulo o vacío antes de usarlo
                if (!string.IsNullOrWhiteSpace(nombre_motivo_permiso))
                {
                    //llamo al metodo obtenerIDCategoriaSeleccionada el cual busca en la base de datos apartir del nombre de la categoria y si cocindice trae su id_categoria 
                    id_motivo_permiso_obtenido = obj_CL_Permiso.obtenerIDMotivoPermisoSeleccionada(nombre_motivo_permiso);
                }
            }
            return id_motivo_permiso_obtenido;//si encontro va a retorna el id encontrado y sino retorna 0
        }


    }
}

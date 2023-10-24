using capaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;//clase que me permite mandar el mail al usuario del estado de su solicitud
using System.Net.Mail;
using CapaDatos;

namespace CapaPresentacion.Formularios.Admin.usuario
{
    public partial class FrmPermisoUsuario : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        private static capaEntidad.usuario usuarioActual;
        public FrmPermisoUsuario(MenuAdministrador p_menuAdministrador,capaEntidad.usuario p_usuarioActual )
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_menuAdministrador;
            usuarioActual = p_usuarioActual;
        }

        private void FrmPermisoUsuario_Load(object sender, EventArgs e)
        {

            // Crear una instancia de la capa de lógica
            CL_Permiso obj_CL_Permiso = new CL_Permiso();

            List<capaEntidad.permiso> listaPermisos = obj_CL_Permiso.listarPermisos();

            // llama al metodo Mostrar la lista de usuarios en el DataGridView y le pasa la lista obtenida de la capa logica
            mostrarPermisosEnDataGridView(listaPermisos);

        }

        private void mostrarPermisosEnDataGridView(List<capaEntidad.permiso> p_listaPermisos)
        {
            dataGridPermisos.Rows.Clear(); // Limpiar filas existentes

            foreach (capaEntidad.permiso item in p_listaPermisos)
            {

                // Agregar una fila al DataGridView con los datos del usuario
                dataGridPermisos.Rows.Add(
                    new object[]
                    { //items de permisos,
                      item.id_permiso,item.fecha_inicio.Date,item.fecha_finalizacion.Date,item.estado_aprobacion, //aca tambien casteo mi atributo fecha que es de tipo datetime a date
                      // item de la tabla rol
                      item.obj_usuario.obj_rol.nombre_rol,
                      // item de la tabla persona
                       item.obj_usuario.obj_persona.id_persona,item.obj_usuario.obj_persona.dni,item.obj_usuario.obj_persona.nombre,item.obj_usuario.obj_persona.apellido,
                       // item de la tabla domicilio
                       item.obj_usuario.obj_domicilio.id_domicilio,

                       item.estado_permiso== 1 ? "Activo" : "No activo"//este item es de la tabla permiso y me permiute mostrar si el permiso se encuentra activo o no 
                     }
                 );

            }
            dataGridPermisos.ClearSelection();//quita la seleccion de fila por defecto que tiene el data grid

        }

        /***Evento de Seleccion de un permiso en el data grid ***/
        private void dataGridPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex; //con esta sentencia  obtengo la fila seleccionada su indice
                                     //aca estoy diciendo que si la fila que se selcciono el inidice es mayor o igual a 0 es decir que en verdad es una fila qu eme guarde el indice de ese id_usuario que seleciono en el txtIDGuardado para pdoer traer de laBd ese usuario
            if (indice >= 0)
            {
                
                limpiarCamposDato(); //limpio los campos del panel de datos permiso

                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dataGridPermisos.Rows[indice];

                // Obtener los datos necesarios de la fila  obteniuendo de esa fila selecciona su id_permiso(cells [0] y el valor de este(suponiendo que la columna 0 contiene la columna ID)
                int id_permiso = Convert.ToInt32(selectedRow.Cells[0].Value);//toma el valor alamcenadoi en la 1ra celda de la fila seleccionada y lo asigna a esa var

                CL_Permiso obj_CL_Permiso = new CL_Permiso();//creo mi isntancia de la capa logica permiso

                capaEntidad.permiso obj_permiso = obj_CL_Permiso.buscarPermiso(id_permiso);// creo mi obj de tipo permiso en donde va a coentener el obj resultadod e acceder a la capa logica precsimanete al metodo bsucarPermisso  donde le paso el id_permiso

                //si el obj_permiso que contiene la categoria que se selecciono o que se busco es != null significa que se encontro entronces entra al id para mostrar sus data en el panel de datos yta que el metodo buscarpermisos devuelve null sino encvontro algun permiso con ese id
                if (obj_permiso != null)
                {
                    txtIdPermiso.Text = obj_permiso.id_permiso.ToString();

                    //carga el combobox de tipo_permiso Uso de la función con una lista de motivo_permiso y el combo de motivo_permiso
                    List<motivo_permiso> listaTipoPermiso = obj_CL_Permiso.listarMotivoPermiso(); //con esta funcion obtenemos una lista de  motivos_permiso que estan cargadas en la BD
                    CargarComboBox(listaTipoPermiso, cboTipoPermiso, motivo_permiso => motivo_permiso.nombre_motivo_permiso);

                    //buscamos el índice del motivo_permiso para que se muestre como predeterminado el valor que esta en la BD en el combo  utilizando FindIndex(traigo el 1er elemenot que cumple la condicion) y una expresión lambda(Las expresiones lambda permiten definir funciones pequeñas y simples en línea, sin la necesidad de declarar un método completo.) que compara el id_rol
                    int indiceMotivoPermiso = listaTipoPermiso.FindIndex(m => m.id_motivo_permiso == obj_permiso.obj_motivo_permiso.id_motivo_permiso);//a parte m => ... significa que estás definiendo un parámetro m que representa cada elemento de la lista (motivo_permiso) y, a continuación, especificas una condición. En este caso, la condición es que el id_motivoPermiso del elemento m sea igual al id_motivoPermiso del motivo_permiso asociado al permiso (objpermiso.obj_motivopermiuso.id_motivoPermiso).

                    // Si se encontró el índice, selecciona el motivo permiso en el ComboBox como valor inicial
                    if (indiceMotivoPermiso >= 0)
                    {
                        cboTipoPermiso.SelectedIndex = indiceMotivoPermiso;
                    }

                    txtIdEmpleado.Text = obj_permiso.obj_usuario.id_usuario.ToString();
                    txtDniEmple.Text = obj_permiso.obj_usuario.obj_persona.dni.ToString();
                    txtNombreEmple.Text = obj_permiso.obj_usuario.obj_persona.nombre.ToString();
                    txtApeEmple.Text = obj_permiso.obj_usuario.obj_persona.apellido.ToString();
                    txtEmailDato.Text = obj_permiso.obj_usuario.email.ToString();
                    txtTelefDato.Text = obj_permiso.obj_usuario.email.ToString();
                    txtRolDato.Text = obj_permiso.obj_usuario.obj_rol.nombre_rol.ToString();
                    txtDomiDato.Text = obj_permiso.obj_usuario.obj_domicilio.numero.ToString() + " " + obj_permiso.obj_usuario.obj_domicilio.calle.ToString();
                    txtDiasSolciitados.Text = (obj_permiso.fecha_finalizacion - obj_permiso.fecha_inicio).Days.ToString();//aca calculo el total de dias solciitados como fechaIni es menor siempre lo calculo asi poneindo 1ro fechafin
                    txtJustificacion.Text = obj_permiso.comentario_justificacion.ToString();

                }
            }
        }



        public void limpiarCamposDato()
        {

        }

        //metodo para cargar combobox generico ,este metodo toma un obj de tipo T( tipo generico) y carga el combo box (para distintos objetos y distintos campo que quiero que se cargue dentro del cambo
        //T=tipodeObj representa el tipo de dato con el que trabajara,List<T> es una lista genérica que contiene elementos de tipo T,p_comboBox=es el combo al que quiero cargar,es un delegado funcional que toma un objeto de tipo T y devuelve una cadena.(ej si quiero obtener el nombre de cada rol le pasaria esto rol => rol.Nombre)
        //Esto permite personalizar cómo se extrae el texto de los elementos de la lista de tipo T para mostrarlos en el ComboBox.
        private void CargarComboBox<T>(List<T> lista, System.Windows.Forms.ComboBox p_comboBox, Func<T, string> obtenerTexto) //aca  System.Windows.Forms.ComboBox especifico claramente cual comboBox estoy utilizando en este caso el que es para windows forms hago esto para evitar ambiguedad
        {
            p_comboBox.Items.Clear(); // Limpia los elementos existentes en el ComboBox.

            foreach (T item in lista)
            {
                string texto = obtenerTexto(item);
                p_comboBox.Items.Add(texto);
            }

        }

        public void ReadOnlyCamposDatoPermiso(bool valor)
        {
            //el parametro valor contiene el valor True o False dependiendo si quiero que este en modo lectura(true) o en modo edicion los campos (false)
            txtIdEmpleado.ReadOnly = valor;
            txtDniEmple.ReadOnly = valor;
            txtNombreEmple.ReadOnly = valor;
            txtApeEmple.ReadOnly = valor;
            txtEmailDato.ReadOnly = valor;
            txtTelefDato.ReadOnly = valor;
            txtRolDato.ReadOnly = valor;
            txtDomiDato.ReadOnly = valor;
            txtDiasSolciitados.ReadOnly = valor;
            txtJustificacion.ReadOnly = valor;

            //usamos la propeidad enable para que parezca esatr en modo lectura(para el comoboBox) y evitar cambios por parte del usuario que intereactua o que se pueda editar dependiendo del valor,como esta propiedad usa el valor contrario al readOnly para ponerse en modo lectura le agrgamos el ! operador de negacion esto cambiara el valor y asi podremos hacer uso de esa propeidad
            cboTipoPermiso.Enabled = !valor;
        }

        /************************APROBAR PERMISO*********************************************/
        private void iconBtnAprobarPermiso_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            CL_Permiso obj_CL_Permiso = new CL_Permiso();

            //aca digo que si la categoria selecciono una columna en el data grid y ademas el id_cateogria que se encarga de guardar cuando se seleciono la categoria en el data grid es mayor a 0 que entre al if
            //esto lo hago para asegurame de que la categoria que se selecciono  en el data grid  es validad y que ademas es un usuario valido pq su id es mayor a 0
            if (dataGridPermisos.SelectedRows.Count > 0 && Convert.ToInt32(txtIdPermiso.Text) > 0)
            {

                DialogResult consulta = MessageBox.Show("¿Desea APROBAR el Permiso del Empleado" + txtNombreEmple.Text+ "?", "Revisar Permiso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (consulta == DialogResult.Yes)
                {
                    //creo un obj_permiso que va a contener el id_permiso de la permiso a apronar
                    capaEntidad.permiso obj_permiso_aprobado = new capaEntidad.permiso
                    {
                        id_permiso = Convert.ToInt32(txtIdPermiso.Text), //aca le paso el id_permiso que necesito para poder hace uso del metodo par aaprobar el permiso
                        estado_aprobacion="aprobado"
                    };


                    obj_CL_Permiso.cambiarEstadoPermiso(obj_permiso_aprobado, out mensaje);

                    //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
                    FrmPermisoUsuario_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
                                                                  //tenemos dos formas de hacer esto de vovler a carga el datagrid actualizado una es volveindo aa cargar el formualrio y la otra es llamando al metodo mostrarDatagrid y pasarle la lista nueva
                    capaEntidad.permiso obj_permiso = obj_CL_Permiso.buscarPermiso(Convert.ToInt32(txtIdPermiso.Text));//aca llamo al metodo buscar permiso para que me traiga el obj_permiso de la BD completo y pueda usar para enviar notifcaion del estado de su permiso
                    EnviarNotificacionPorCorreo(obj_permiso, "Solicitud de Permiso Rechazada", mensaje);
                }
                //aca muestro en caso de que haya habido algun error en el metodo DarDeBaja o en caso de exito tmabien muestro el mensaje proveniente de mi procedimiento alamcenado
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Permiso para poder Aprobarlo o rechazarlo ", "Revisar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        /************************RECHAZAR PERMISO*********************************************/
        private void iconBtnRechaPermiso_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            CL_Permiso obj_CL_Permiso = new CL_Permiso();

            //aca digo que si la categoria selecciono una columna en el data grid y ademas el id_cateogria que se encarga de guardar cuando se seleciono la categoria en el data grid es mayor a 0 que entre al if
            //esto lo hago para asegurame de que la categoria que se selecciono  en el data grid  es validad y que ademas es un usuario valido pq su id es mayor a 0
            if (dataGridPermisos.SelectedRows.Count > 0 && Convert.ToInt32(txtIdPermiso.Text) > 0)
            {

                DialogResult consulta = MessageBox.Show("¿Desea RECHAZAR el Permiso del Empleado" + txtNombreEmple.Text + "?", "Revisar Permiso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (consulta == DialogResult.Yes)
                {
                    //creo un obj_permiso que va a contener el id_permiso de la permiso a rechzador
                    capaEntidad.permiso obj_permiso_rechazado = new capaEntidad.permiso
                    {
                        id_permiso = Convert.ToInt32(txtIdPermiso.Text), //aca le paso el id_permiso que necesito para poder hace uso del metodo par aaprobar el permiso
                        estado_aprobacion = "rechazado"
                    };


                    obj_CL_Permiso.cambiarEstadoPermiso(obj_permiso_rechazado, out mensaje);

                    //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
                    FrmPermisoUsuario_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso
                                                                  //tenemos dos formas de hacer esto de vovler a carga el datagrid actualizado una es volveindo aa cargar el formualrio y la otra es llamando al metodo mostrarDatagrid y pasarle la lista nueva

                   capaEntidad.permiso obj_permiso = obj_CL_Permiso.buscarPermiso(Convert.ToInt32(txtIdPermiso.Text));//aca llamo al metodo buscar permiso para que me traiga el obj_permiso de la BD completo y pueda usar para enviar notifcaion del estado de su permiso
                    EnviarNotificacionPorCorreo(obj_permiso, "Solicitud de Permiso Rechazada", mensaje);
                }

                //aca muestro en caso de que haya habido algun error en el metodo DarDeBaja o en caso de exito tmabien muestro el mensaje proveniente de mi procedimiento alamcenado
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Permiso para poder Aprobarlo o rechazarlo ", "Revisar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        public void EnviarNotificacionPorCorreo(permiso obj_permiso, string asunto, string mensaje)
        {
            try
            {
                var correo = new MailMessage();
                correo.From = new MailAddress("tudirecciondecorreo@gmail.com");
              //  correo.To.Add();
                correo.Subject = asunto;
                correo.Body = mensaje;

                var smtp = new SmtpClient("smtp.gmail.com"); // Cambia esto al servidor SMTP que uses (por ejemplo, el servidor de tu empresa)
                smtp.Port = 587; // Puerto SMTP (puede variar según el proveedor)
                smtp.Credentials = new NetworkCredential("tudirecciondecorreo@gmail.com", "tucontraseña");
                smtp.EnableSsl = true; // Habilitar SSL para conexiones seguras

                smtp.Send(correo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar correo electrónico: " + ex.Message);
                // Aquí puedes manejar errores o registrarlos en un archivo de registro.
            }

        }

    }
}

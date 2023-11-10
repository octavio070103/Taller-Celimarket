using capaEntidad;
using CapaLogica;
using CapaPresentacion.Formularios.Admin.consulta_reclamo;
using CapaPresentacion.Formularios.Gerente.caja;
using DocumentFormat.OpenXml.Drawing;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace CapaPresentacion.Formularios.Admin
{
    public partial class FrmGestionarConsulta : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        public FrmGestionarConsulta(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
            // Desvincular el controlador de eventos
          //  dataGridConsultas.ColumnHeaderMouseClick -= dataGridConsultas_CellClick;

        }
        private void FrmGestionarConsulta_Load(object sender, EventArgs e)
        {
            DataGridDisenio.Formato(dataGridConsultas, 1); //llamo a la clase datagrid disenio que le da el formato 1 a ese data grid 

            // Crear una instancia de la capa de lógica para hacer uso de los metodos que tiene esa clase CL_Consulta que esta en la capa logica
            CL_Consulta obj_CL_Consulta = new CL_Consulta();

            List<capaEntidad.consulta> listaConsultas = obj_CL_Consulta.listarConsulta();// Obtener la lista de Consultas desde la capa de lógica

            // llamo al metodo Mostrar la lista de Consultas en el DataGridView y le pasa la lista obtenida de la capa logica
            mostrarConsultasEnDataGridView(listaConsultas);

            //cargo el comoboBox del filtrado dle estado de ka consulta al cargar el formulario
            comboFiltroEstado.Items.Add("Leido");
            comboFiltroEstado.Items.Add("no leido");

            //cargo el combobox de rol filtro,para esto Uso de la función de listar rol y el combo de rol
            CL_rol obj_CL_rol = new CL_rol();//creo mi isntancia de la capa logica rol
            List<rol> listaTipoRoles = obj_CL_rol.listarRol(); //con esta funcion obtenemos una lista de  roles que estan cargadas en la BD
            CargarComboBox(listaTipoRoles, comboFiltroRol, rol => rol.nombre_rol);

            //carga el combobox de motivo_consulta filtro,para esto Uso de la función de istar motivo y el combo de motivo
            List<motivo_consulta> listaMotivoConsulta = obj_CL_Consulta.listaMotivosConsulta(); //con esta funcion obtenemos una lista de  motivo que estan cargadas en la BD
            CargarComboBox(listaMotivoConsulta, comboMotivo, motivo_consulta => motivo_consulta.nombre_motivo_consulta);

        }

        //metodo para cargar combobox generico ,este metodo toma un obj de tipo T(tipo generico) y carga el combo box(para distintos objetos y distintos campo que quiero que se cargue dentro del cambo
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

        private void mostrarConsultasEnDataGridView(List<capaEntidad.consulta> p_listaConsultas)
        {
            dataGridConsultas.Rows.Clear(); // Limpiar filas existentes

            foreach (capaEntidad.consulta item in p_listaConsultas)
            {

                // Agregar una fila al DataGridView con los datos del usuario
                dataGridConsultas.Rows.Add(
                    new object[]
                    { //items de motivo_consulta
                       item.id_consulta,item.obj_motivo_consulta.nombre_motivo_consulta,
                      //items de esa cosnulta que se esta recorriendo en el foreach en ese momento
                      item.id_consulta,item.comentario_consulta,item.fecha_consulta,item.estado_consulta, //aca tambien casteo mi atributo fecha que es de tipo datetime a date
                       //item de ese usuario de esa consulta que se esta recorriendo
                       item.obj_usuario.id_usuario,
                       //item de ese rol de ese usuario de esa consulta que se esta recorriendo
                       item.obj_usuario.obj_rol.id_rol,item.obj_usuario.obj_rol.nombre_rol,
                       //item de esa persona de ese usuario de esa consulta que se esta recorriendo
                       item.obj_usuario.obj_persona.id_persona,item.obj_usuario.obj_persona.dni,item.obj_usuario.obj_persona.nombre,item.obj_usuario.obj_persona.apellido
                    }
                 );

            }
            dataGridConsultas.ClearSelection();//quita la seleccion de fila por defecto que tiene el data grid

        }





        //este evento se activa cuando da click en el datagrid
        private void dataGridConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0) {

                string mensaje = string.Empty;
                string mensajeCorreo = "La consulta fue recibida y leida";
                CL_Consulta obj_CL_Consulta = new CL_Consulta();
                //obtenemos el id_consulta de la consulta que se selecciono para marcarla como leida es decir cambiar el estado de la consulta a leida

                DataGridViewRow filaSeleccionada = dataGridConsultas.Rows[e.RowIndex]; //primero obtenemos la filaSeleccionada

                int id_consultaSeleccionada = Convert.ToInt32((filaSeleccionada.Cells["Col_id_consulta"].Value.ToString()));//obtenemos el valor de la columna id_consulta lo convertimos a entero
                capaEntidad.consulta obj_consulta = obj_CL_Consulta.buscarConsultaPorIdConsulta(id_consultaSeleccionada); //aca le pasamos el id_consulta que obtuivmos para poder obtener el ese registro de consulta (obj_consulta) y asi cambiar  su estado a leido

                //aca pregunto si la consuluma e.columIndex es decir si el indiice de la col que se selecciono es == a la columna responder_consulta entonces que entre al if y me permita responder esa cosnulta
                if (dataGridConsultas.Columns[e.ColumnIndex].Name == "Responder_Consulta")
                {
                    FrmResponderConsulta ventanaEmergRespConsul = new FrmResponderConsulta(obj_consulta);
                    ventanaEmergRespConsul.ShowDialog();
                }

                //aca pregunto si la consuluma e.columIndex es decir si el indiice de la col que se selecciono es == a la columna MarcarLeido entonces que entre al if y me permita marcar como leido esa consulta
                if (dataGridConsultas.Columns[e.ColumnIndex].Name == "MarcarLeido")
                {
                    bool cambiarEstadoConsulta = obj_CL_Consulta.cambiarEstadoConsulta(obj_consulta, out mensaje);
                    if (cambiarEstadoConsulta)
                    {
                        MessageBox.Show(mensaje);
                        EnviarNotificacionPorCorreo(obj_consulta, "Consulta Leida por el Administrador", mensajeCorreo);
                    }
                    FrmGestionarConsulta_Load(this, EventArgs.Empty);
                }
            }
         
        }

        /****************** FILTROS DE MI DATAGRID **********************/
        private void dateTimeFiltro_ValueChanged(object sender, EventArgs e)
        {
            string filtro = dateTimeFiltro.Value.ToString("yyyy-MM-dd");
            string atributo = "fecha filtro";
            // Filtra los datos en el DataGridView
            FiltrarDataGridViewConsulta(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }


        private void txtDniFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtDniFiltro.Text;
            string atributo = "dni del empleado";
            // Filtra los datos en el DataGridView
            FiltrarDataGridViewConsulta(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }

        private void comboMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = comboMotivo.SelectedItem.ToString(); //obtenemos el elemento seleccionado de este combobox
            string atributo = "Motivo de la consulta";
            // Filtra los datos en el DataGridView
            FiltrarDataGridViewConsulta(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }

        private void comboFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = comboFiltroEstado.SelectedItem.ToString(); //obtenemos el elemento seleccionado de este combobox
            string atributo = "estado de la consulta";
            // Filtra los datos en el DataGridView
            FiltrarDataGridViewConsulta(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }

        private void comboFiltroRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = comboFiltroRol.SelectedItem.ToString(); //obtenemos el elemento seleccionado de este combobox
            string atributo = "rol del empleado";
            // Filtra los datos en el DataGridView
            FiltrarDataGridViewConsulta(filtro, atributo);//lamo a mi metodo que filtra los uusarios del datagrid y le paso el filtro
        }

        private void FiltrarDataGridViewConsulta(string filtro, string atributo)
        {
            // Crear una instancia de la capa de lógica
            CL_Consulta obj_CL_Consulta = new CL_Consulta();
            //por ewsto uso capaentidad.consulkta ya que es necesario especificar de manera explícita a cuál usuario te estás refiriendo,lo HAGOcalificando el nombre de la clase usuario con el espacio de nombres al que pertenece. 
            List<capaEntidad.consulta> listaConsultaFiltrado = obj_CL_Consulta.listarConsultaFiltrado(filtro, atributo); // Obtener la lista de usuarios desde la capa de lógica

            // Actualiza el DataGridView
            mostrarConsultasEnDataGridView(listaConsultaFiltrado);

        }
        /******************************* Responder Consulta **************************/
        public void EnviarNotificacionPorCorreo(consulta obj_consulta, string asunto, string mensaje)
        {
            try
            {
                //CONFIGURAR VALORES
                string Host = "smtp.gmail.com";
                int Puerto = 587;
                string Usuario = "celimarketexpress@gmail.com";
                string Clave = "pqadyqsdvadgeqjc";//clave generada para aplicación en GMAIL

                //PROPORCIONAMOS AUTENTICACION DE GMAIL
                SmtpClient smtp = new SmtpClient(Host, Puerto);
                MailMessage msg = new MailMessage();


                //CREAMOS EL CONTENIDO DEL CORREO
                string[] Destinatario = obj_consulta.obj_usuario.email.Split(',');
                //  string[] DestinatarioCopia = txtCopia.Text.Split(',');
                // string[] DestinatarioCopiaOculta = txtCopiaOculta.Text.Split(',');


                msg.From = new MailAddress(Usuario, "SERVIDOR CORREO CELIMARKET");
                foreach (string correo in Destinatario) if (correo != "") msg.To.Add(new MailAddress(correo));
                // foreach (string correo in DestinatarioCopia) if (correo != "") msg.CC.Add(new MailAddress(correo)); este me sirve por si quiero una copia del correo enviarlo
                //   foreach (string correo in DestinatarioCopiaOculta) if (correo != "") msg.Bcc.Add(new MailAddress(correo)); esto es por si quiero una coipa oculta
                //  foreach (string adjunto in ArchivoAdjuntos) if (adjunto != "") msg.Attachments.Add(new Attachment(adjunto)); esto es por si quiero permitir que s eadjunten archivos
                msg.Subject = asunto;
                msg.IsBodyHtml = false;
                msg.Body = mensaje;


                //ENVIAMOS EL CORREO
                smtp.Credentials = new NetworkCredential(Usuario, Clave);
                smtp.EnableSsl = true;
                smtp.Send(msg);
                MessageBox.Show("Notificacion de Consulta Enviada al correo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo electrónico: " + ex.Message);
            }

        }

        //Limpia el contenido de los campos del filtrado
        private void iconbtnClean_Click(object sender, EventArgs e)
        {

            //vuelvo a listar el datagrid con la lista sin filtrar 
            //le pasamos los valores comunes que se paan cuando se carga pro primaera vez el formualrio 
            FrmGestionarConsulta_Load(this, EventArgs.Empty);//vuelvo a cargar el formualrio desde el principio permitiendome volver a cargar el dataGrid con los datos actulizados es decir co nel usuario dado de alta en este caso

        }

        private void iconBtnExcel_Click(object sender, EventArgs e)
        {
            //aca digo que me permita imprimir el excel solo si posee alguna fila el datagrid
            if (dataGridConsultas.Rows.Count > 0)
            {
                DataTable datatableExcel = new DataTable(); //aca creo un obj datatable para poder guardar el encabezado de cada columna

                foreach (DataGridViewColumn columna in dataGridConsultas.Columns) //aca digo que recorra las columns de mi dataGrid Consultas
                {
                    if (columna.HeaderText != "Marca Como Leido" && columna.HeaderText != "Responder") { 
                    datatableExcel.Columns.Add(columna.HeaderText, typeof(string)); //aca agrego el headertext de mi columna que se esta recorriendo en ese momento al datatableExcel  es decir inserto todas las cabceras en mi datagridexcel
                    }
                }

                //recorro y inserto todas mis filas de mi datagrid consulta en mi datatableexcel
                foreach (DataGridViewRow filas in dataGridConsultas.Rows) //aca digo que recorra las columns de mi datagrid consulta
                {
                    //aca digo que se guarden en el excel solo las filas que estan visibles en ese momento ej.si aplico un filtro de que filas mostrar que solo guarden esas filas visibles unicamente en el excel
                    if (filas.Visible)
                    {
                        //aca creo un nuevo objeto array y accedo a una fila y en esa fila que accedi que se guarden lso valores de cada cells o celda de cada columna , y asi haria con cada fila de mi datagridproduc
                        datatableExcel.Rows.Add(new object[]
                        {//aca guardo los valores de las columnas de esa fila que accedi puedo guardar todas las columnsa o puedo poner solo las columnas que quiero el valor pero debe de coincidir con la cabecera que guarde
                            filas.Cells[0].Value.ToString(),
                            filas.Cells[1].Value.ToString(),
                            filas.Cells[2].Value.ToString(),
                            filas.Cells[3].Value.ToString(),
                            filas.Cells[4].Value.ToString(),
                            filas.Cells[5].Value.ToString(),
                            filas.Cells[6].Value.ToString(),
                            filas.Cells[7].Value.ToString(),
                            filas.Cells[8].Value.ToString(),
                            filas.Cells[9].Value.ToString(),
                            filas.Cells[10].Value.ToString(),
                            filas.Cells[11].Value.ToString(),
                            filas.Cells[12].Value.ToString(),
                            
                           
                        });
                    }
                }

                //aca le pregunto al usuario en que parte quiere guardar al archivo excel a este obj lo llamare saveFile
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteConsulta{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss")); //aca le asigno el nobre predetemrinado que tendra mi archivo y con format obtengo un mayor control sobre el texto luego al nombre le concateno la fecha y hora
                saveFile.Filter = "Excel Files | *.xlsx"; //aca estoy agregando un filtro a la ventana de donde quiero que se guarden para que al momento de mostrarse solo se muestren ese tipo de archivos con esa extension

                //aca digo si en el evento showdialog de la ventana de savefile se dio al evento ok que entre al if
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //aca comienzo a manipular el nugget de excel que instale para poder crear y exportar el mismo 
                        XLWorkbook wb = new XLWorkbook(); //aca creo el archivo excel
                        var hoja = wb.Worksheets.Add(datatableExcel, "Informe Consultas"); //aca creo una variable que sera la hoja de mi excel
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

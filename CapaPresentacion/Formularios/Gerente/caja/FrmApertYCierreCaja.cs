using CapaDatos;
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

namespace CapaPresentacion.Formularios.Gerente.caja
{
    public partial class FrmApertYCierreCaja : Form
    {
        private MenuGerente instancia_menuGerente;
        private usuario usuarioActual;
        // private int cantVentas;
        public FrmApertYCierreCaja(MenuGerente p_menuGerente, usuario p_usuarioActual)
        {
            InitializeComponent();
            instancia_menuGerente = p_menuGerente;
            usuarioActual = p_usuarioActual;

            dataGridMovEnCaja.Visible = false;//oculto el datagrid de mov primeramente ya que en teoria todavia nose abrio ninguna caja
            lblTituloDatelleMov.Visible = false;
        }

        private void FrmApertYCierreCaja_Load(object sender, EventArgs e)
        {
            CargarDatosAperturaCaja();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar qué pestaña está seleccionada
            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Text == "Apertura Caja")
            {
                // Cargar datos específicos para la pestaña de apertura de caja
                CargarDatosAperturaCaja();
            }
            else if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Text == "Cerrar Caja")
            {
                // Cargar datos específicos para la pestaña de cierre de caja
                CargarDatosCerrarCaja();
            }
        }
        private void CargarDatosAperturaCaja()
        {
            // aca cargo los datos en la pestaña de apertura de caja
            txtUsuAper.Text = usuarioActual.obj_persona.nombre + " " + usuarioActual.obj_persona.apellido;
            txtRolUsuAper.Text = usuarioActual.obj_rol.nombre_rol;
            txtFechaApertura.Text = DateTime.Now.ToString();
            txtTipoMovimientoAper.Text = "Apertura de caja";

            caja_apertura obj_cajaAperturaActual = new CL_Caja().obtenerCajaAperturaPorFecha(DateTime.Now);//obtengo la caja apertura para la fecha en la que se cierra la caja
            //si entra al if significa que la caja ya fue abierta anteriormente es decir ya se abrio la caja por lo que debo de poder visualizar los mov de la caja y no debo de poder reditar lso datos de los txt solo verlos
            if ((obj_cajaAperturaActual != null) && (obj_cajaAperturaActual.estado_apertura == 1))
            {
                mostrarDatosDeAperturaCaja(obj_cajaAperturaActual.id_apertura_caja);
            }

        }
        private void mostrarDatosDeAperturaCaja(int p_id_apertura_caja_actual)
        {
            txtMontoApertura.ReadOnly = true; //aca hago para que el campo monto apertura si ya se abrio la caja anteriomente sol oaparezca en modo lectura y no en modo edicion
            iconBtnAbrirCaja.Visible = false;  //tambien oculto el boton de abrir caja
            dataGridMovEnCaja.Visible = true;
            DataGridDisenio.Formato(dataGridMovEnCaja, 2); //llamo a la clase datagrid disenio que le da el formato 1 a ese data grid 

            List<ventaCaja> listaVentasPorAperturaCaja = new CL_Caja().listarVentasPorAperturaCaja(p_id_apertura_caja_actual);//obtengo la listaVenta de la caja actual
            mostrarVentasAperturaCaja(listaVentasPorAperturaCaja);
        }

        public void mostrarVentasAperturaCaja(List<capaEntidad.ventaCaja> p_listaCategoria)
        {
            dataGridMovEnCaja.Rows.Clear(); // Limpiar filas existentes
            foreach (capaEntidad.ventaCaja item in p_listaCategoria)
            {
                // Agregar una fila al DataGridView con los datos del usuario
                dataGridMovEnCaja.Rows.Add(
                    new object[]
                    { //items de la categoria
                      item.id_venta,item.fecha_venta,
                      item.obj_cliente.id_cliente,item.obj_cliente.obj_persona.dni,item.obj_cliente.obj_persona.nombre+" "+item.obj_cliente.obj_persona.apellido,
                      item.obj_usuario.id_usuario,item.obj_usuario.obj_persona.dni,item.obj_usuario.obj_persona.nombre+" "+item.obj_usuario.obj_persona.apellido,
                      item.obj_caja_apertura.id_apertura_caja,
                      item.obj_producto.Idproducto,item.obj_producto.nombre_producto,
                      item.cantidad_venta,item.subtotal
                    }
                 );
            }
            dataGridMovEnCaja.ClearSelection();//quita la seleccion de fila por defecto que tiene el data grid

        }

        /************realizar la apertura de la caja*********/
        private void iconBtnAbrirCaja_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            int id_caja_apertura_generado = 0;

            if (validarCamposAperturaCaja())
            {
                capaEntidad.caja_apertura obj_caja_apertura = new capaEntidad.caja_apertura()
                {
                    fecha_apertura = DateTime.Now,
                    monto_inicial_apertura = Convert.ToDecimal(txtMontoApertura.Text),
                    obj_usuario = usuarioActual,//le paso el usuarioa actual que contiene todos los datos necesario del usuario
                    //aca le paso el id_motivo_consulta atravses del metodo que lo consigue para poder registrar mi cosnulta
                    estado_apertura = 1
                };
                id_caja_apertura_generado = new CL_Caja().RegistrarAperturaDeCaja(obj_caja_apertura, out mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }

                if (id_caja_apertura_generado > 0)
                {
                    mostrarDatosDeAperturaCaja(id_caja_apertura_generado);
                }

            }
            DialogResult = advertenciaAbrirCaja();
        }


        private bool validarCamposAperturaCaja()
        {
            bool validacion = true;
            string usuarioTurno = txtUsuAper.Text;
            string rolUsu = txtRolUsuAper.Text;
            string montoApertura = txtMontoApertura.Text;

            decimal numero = 0;

            if (string.IsNullOrEmpty(usuarioTurno) || string.IsNullOrEmpty(rolUsu) || string.IsNullOrEmpty(montoApertura))
            {
                MessageBox.Show("Por favor, Rellene todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validacion = false;
            }

            //validar que el campos monto solo se ingresen decimales
            if (!decimal.TryParse(montoApertura, out numero))
            {
                MessageBox.Show("El monto Apertura debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            return validacion;
        }

        private DialogResult advertenciaAbrirCaja()
        {
            AdvertenciaAbrirCaja ventEmergenAdverAbrirCaja = new AdvertenciaAbrirCaja();
            DialogResult resultado = ventEmergenAdverAbrirCaja.ShowDialog();
            return resultado;
        }


        //btn para regresar sino se quiere realizAr la apertura de la caja
        private void BtnRegresarApertura_Click(object sender, EventArgs e)
        {
            this.Close();
            this.instancia_menuGerente.OpenChildForm(new FrmAdministrarCaja(this.instancia_menuGerente, usuarioActual));
        }



        /************realizar el cierre de la caja*********/

        /*cargo los datos en la estania o tabcontrol de cerraCaja*/
        private void CargarDatosCerrarCaja()
        {
            // aca cargo los datos en la pestaña de cierre de caja
            txtFechaCierre.Text = DateTime.Now.ToString();
            txtUsuCierre.Text = usuarioActual.obj_persona.nombre + " " + usuarioActual.obj_persona.apellido;

            caja_cierre obj_caja_cierreActual = new CL_Caja().obtenerCajaCierrePorFecha(DateTime.Now);//obtengo la caja apertura para la fecha en la que se cierra la caja

            //con este if determino si ya se cerro la caja solo se pueda ver los datos de esa caja actual si asi se desea
            if (obj_caja_cierreActual != null)
            {
                //aca obtengo la listas de ventas por la aperturaCaja segund el id_apertura_caja que obtengo de mi obj_caja_cierreActual que tiene un obj_caja_apertura y este tiene el id_apertura_Caja que quiero para pdoer obtener las vcentas de la misma y co count obtengo la cant devuelva de valores
                int cantVentas = new CL_Caja().listarVentasPorAperturaCaja(obj_caja_cierreActual.obj_caja_apertura.id_apertura_caja).Count; //le asigno la cantidad de ventas de este cierre de caja que tuvo
                mostrarDatosCajaCerrada(obj_caja_cierreActual, cantVentas);//muiestra el panle que contiene los datos de esa caja 
            }
        }

        private DialogResult advertenciaCierreCaja()
        {
            AdvertenciaCierreCaja ventEmergenAdverCierreCaja = new AdvertenciaCierreCaja();
            DialogResult resultado = ventEmergenAdverCierreCaja.ShowDialog();
            return resultado;
        }

        private void iconBtnCerrarCaja_Click(object sender, EventArgs e)
        {
            DialogResult = advertenciaCierreCaja();
            string mensaje = string.Empty;
            int id_caja_cierre_generado = 0;

            caja_apertura obj_cajaAperturaActual = new CL_Caja().obtenerCajaAperturaPorFecha(DateTime.Now);//obtengo la caja apertura para la fecha en la que se cierra la caja
            List<ventaCaja> listaVentasPorAperturaCaja = new CL_Caja().listarVentasPorAperturaCaja(obj_cajaAperturaActual.id_apertura_caja);
            int cantVentas = listaVentasPorAperturaCaja.Count; //le asigno la cantidad de ventas de este cierre de caja que tuvo
            //obtengo el monto final 
            decimal montoFinal = 0;
            //Calcular subtotal de todas las ventas y ahi obtengo el monto final
            foreach (ventaCaja venta in listaVentasPorAperturaCaja)
            {
                montoFinal += venta.subtotal; // aca voy acumulando el subtotral de cada venta asi puedo obtener el montoFinal esperado para poder cerrar la caja y cuadrarla
            }
            if (validarCamposCierreCaja())
            {
                //esto seria mi totalCaja
                decimal montoDeCaja = Convert.ToDecimal(txtMontoCaja.Text) + obj_cajaAperturaActual.monto_inicial_apertura; //aca obtengo el monto de m icaja sumando el monto que tengo enla caja que lo ingresa el usuario mas el monto con el que inicie

                capaEntidad.caja_cierre obj_caja_cierre = new capaEntidad.caja_cierre()
                {
                    obj_caja_apertura = obj_cajaAperturaActual,
                    fecha_cierre_caja = DateTime.Now,
                    obj_usuario = usuarioActual,//le paso el usuarioa actual que contiene todos los datos necesario del usuario
                    monto_final = montoFinal,
                    diferencia_cierre_Caja = (montoDeCaja + obj_cajaAperturaActual.monto_inicial_apertura) - montoFinal, //la diferencia se calcula entre la resta del montoFinal obtenido de la ventas realizadas y la suma del 9monto de la caja en ese moento y el monto con el que se inicio esa caja)
                    //el estado_cierre lo defino en el proc almacenado dependendiendo del valor de la diferencia
                };
                id_caja_cierre_generado = new CL_Caja().RegistrarCierreDeCaja(obj_caja_cierre, out mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                }
                //si el id_caja_cierre_generado singifica que se realizo el cierre de caja de manera correcta y id_caja_cierre_generado contiene el id de la caja que se cerro,entonces si se cerro de manera correcta muestro la caja cerrada
                if (id_caja_cierre_generado > 0)
                {
                    mostrarDatosCajaCerrada(obj_caja_cierre, cantVentas); //carga y muestra los datos de la caja que se cerro 

                }

            }
        }
        /**********ME MUESTRA DATOS DE LA CAJA UNA VEZ QUE SE CERRO********/
        private void mostrarDatosCajaCerrada(caja_cierre p_obj_caja_cierre, int p_cantVentas)
        {
            iconBtnImprimir.Visible = true;
            panelDatosCajaCerra.Visible = true; //muestro el panel que contiene los datos de la caja que se cerro
            txtMontoCaja.ReadOnly = true; //hago que el monto caja nose pueda editar el valor
            //cargo los label con el datos pertinente
            lblMontoInicial.Text = p_obj_caja_cierre.obj_caja_apertura.monto_inicial_apertura.ToString();
            lblUsuAper.Text = p_obj_caja_cierre.obj_caja_apertura.obj_usuario.obj_persona.nombre + " " + p_obj_caja_cierre.obj_caja_apertura.obj_usuario.obj_persona.apellido;
            lblFechaApertura.Text = p_obj_caja_cierre.obj_caja_apertura.fecha_apertura.ToString();
            lblNumVentas.Text = p_cantVentas.ToString();
            lblMontoCierre.Text = p_obj_caja_cierre.monto_final.ToString();
            lblDiferencia.Text = p_obj_caja_cierre.diferencia_cierre_Caja.ToString();
        }

        private bool validarCamposCierreCaja()
        {
            bool validacion = true;
            string usuarioTurno = txtUsuAper.Text;
            string montoDeLaCaja = txtMontoCaja.Text;

            decimal numero = 0;

            if (string.IsNullOrEmpty(usuarioTurno) || string.IsNullOrEmpty(montoDeLaCaja))
            {
                MessageBox.Show("Por favor, Rellene todos los campos", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validacion = false;
            }

            //validar que el campos monto solo se ingresen decimales
            if (!decimal.TryParse(montoDeLaCaja, out numero))
            {
                MessageBox.Show("El monto Apertura debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validacion = false;
            }

            return validacion;
        }


        private void iconBtnRegresarCierre_Click(object sender, EventArgs e)
        {
            this.Close();
            this.instancia_menuGerente.OpenChildForm(new FrmAdministrarCaja(this.instancia_menuGerente, usuarioActual));
        }

        private void iconBtnImprimir_Click(object sender, EventArgs e)
        {

            caja_cierre obj_caja_cierreActual = new CL_Caja().obtenerCajaCierrePorFecha(DateTime.Now);//obtengo la caja apertura para la fecha en la que se cierra la caja

            FrmTicketCierre frmTicketCierre = new FrmTicketCierre(obj_caja_cierreActual);
            frmTicketCierre.Show();
        }
    }
}

using capaEntidad;
using CapaLogica;
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
    public partial class FrmTicketCierre : Form
    {
        private caja_cierre cajaCierreActual;

        public FrmTicketCierre(caja_cierre p_obj_cajaAperturaActual)
        {
            InitializeComponent();
            cajaCierreActual = p_obj_cajaAperturaActual;
            cargarDatosTicket();
        }

        private void cargarDatosTicket()
        {
            capaEntidad.negocio obj_negocio = new CL_Negocio().obtenerDatosNegocio(); //aca obtengo los datos del negocio y l oguardo en un obj de tiponegocio

            //datos de cabecera de la caja
            lblnroCajacierre.Text = cajaCierreActual.id_cierre_caja.ToString();
            lblFechaApertura.Text = cajaCierreActual.obj_caja_apertura.fecha_apertura.ToString();
            lblFechaCierreCaja.Text = cajaCierreActual.fecha_cierre_caja.ToString();

            // Datos del negocio
            lblNomNegocio.Text = obj_negocio.nombre_negocio;
            lblCUIT.Text = obj_negocio.CUIT;
            lblEmailNegocio.Text = obj_negocio.email_negocio;

            //datos del gerente de cierre
            lblTi.Text = cajaCierreActual.obj_usuario.obj_persona.nombre + " " + cajaCierreActual.obj_usuario.obj_persona.apellido;

            //datos Total Venta debo de clasificar las venta segun el tipo que fue
            List<MetPagoDeVentas> listaDeVentasPorTipMetPago = new CL_Caja().obtenerTipoMetPagoDeVentasCajaAper(cajaCierreActual.obj_caja_apertura.id_apertura_caja);
            foreach (MetPagoDeVentas item in listaDeVentasPorTipMetPago)
            {
                switch (item.id_tipo_metPago)
                {
                    case 1:
                        lblCantEfecMetPago.Text = item.cant_vent_tipo_tipo_metPago.ToString(); lblTotEfecMetPago.Text = item.total_vent_tipo_tipo_metPago.ToString();
                        break;
                    case 2:
                        lblCantCredMetPago.Text = item.cant_vent_tipo_tipo_metPago.ToString(); lblTotCredMetPago.Text = item.total_vent_tipo_tipo_metPago.ToString();
                        break;
                    case 3:
                        lblCantDebitMetPago.Text = item.cant_vent_tipo_tipo_metPago.ToString(); lblTotDebitMetPago.Text = item.total_vent_tipo_tipo_metPago.ToString();
                        break;
                    default:; break;
                }
            }

            //datos del movimiento encaja
            lblMontoApertu.Text = cajaCierreActual.obj_caja_apertura.monto_inicial_apertura.ToString();
            lblMontoFinal.Text = cajaCierreActual.monto_final.ToString();
            lblRetirosDeCaja.Text = "0";
            //datos del totalCaja
            lblMontoFinalCaja.Text = cajaCierreActual.monto_final.ToString();
            lblDifCierreCaja.Text = cajaCierreActual.diferencia_cierre_Caja.ToString();
            lblTotalVentas.Text = new CL_Caja().listarVentasPorAperturaCaja(cajaCierreActual.obj_caja_apertura.id_apertura_caja).Count().ToString();
        }

        private void iconBtnRegresarCierre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

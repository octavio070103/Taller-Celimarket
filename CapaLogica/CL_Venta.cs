using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using capaEntidad;

namespace CapaLogica
{
    public class CL_Venta
    {
        public DataTable obtenerMetodosPago()
        {
            CD_venta auxVenta = new CD_venta();
            DataTable auxListaMetodos = auxVenta.obtenerMetodosPago();

            return auxListaMetodos;
        }

        public void registrarVenta(venta objVenta, out int idVentaRegistrada, out int resultadoEjec)
        {
            idVentaRegistrada = 0;
            resultadoEjec = 0;

            CD_venta auxVenta = new CD_venta();
            auxVenta.registrarVenta(objVenta, out idVentaRegistrada, out resultadoEjec);
        }

        public void registrarDetalleVenta( List<detalle_venta> listaDetalleVenta, out string mensajeResultado)
        {
            mensajeResultado = "";

            CD_detalle_venta auxDetalleVenta = new CD_detalle_venta();
            auxDetalleVenta.registrarDetalleVenta(listaDetalleVenta, out mensajeResultado);
        }

        public DataTable listarVentasVendedor(int pIdUsuario)
        {
            CD_venta auxVenta = new CD_venta();

            DataTable auxListaVentas = auxVenta.listarVentasVendedor(pIdUsuario);

            return auxListaVentas;
        }


        public DataTable listarDetalleVenta(int pIdVenta)
        {
            CD_detalle_venta auxDetalle = new CD_detalle_venta();
            DataTable listaDetalle = auxDetalle.listarDetalleVenta(pIdVenta);

            return listaDetalle;
        }


        public factura obtenerDatosFactura(int pIdVenta)
        {
            CD_venta auxVenta = new CD_venta();
            factura auxFactura = auxVenta.buscarFactura(pIdVenta);

            return auxFactura;
        }


        public string[] obtenerDatosNegocioPorPeriodo( DateTime fechaInicio, DateTime fechaFin)
        {
            CD_venta auxVenta = new CD_venta();
            string[] auxDatos = auxVenta.datosDelNegocioPorPeriodo(fechaInicio, fechaFin);

            return auxDatos;
        }


        public List<productoMasVendido> productosMasVendidosPorPeriodo(DateTime pFechaInicio, DateTime pFechaFin)
        {
            CD_venta auxVenta = new CD_venta();
            List<productoMasVendido> auxLista = auxVenta.productosMasVendidosPorPeriodo(pFechaInicio, pFechaFin);

            return auxLista;
        }


        public List<categoriaMasVendida> categoriasMasVendidasPorPeriodo(DateTime pFechaInicio, DateTime pFechaFin)
        {
            CD_venta auxVenta = new CD_venta();
            List<categoriaMasVendida> auxLista = auxVenta.categoriasMasVendidasPorPeriodo(pFechaInicio, pFechaFin);

            return auxLista;
        }


        public DataTable listarVentasVendedorPorPeriodo(int pIdUsuario, DateTime pFechaInicio, DateTime pFechaFin)
        {
            CD_venta auxVenta = new CD_venta();
            DataTable auxLista = auxVenta.listarVentasVendedorPorPeriodo(pIdUsuario, pFechaInicio, pFechaFin);

            return auxLista;
        }

    }
}

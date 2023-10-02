using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CapaPresentacion.Formularios.Gerente.gestion_ventas
{
    public partial class ModuloEstadisticas : Form
    {
        public ModuloEstadisticas()
        {
            InitializeComponent();
        }

        private void ModuloEstadisticas_Load(object sender, EventArgs e)
        {
            graficoProductosMasVendidos();
            graficoCategoriasMasVendidas();
            datosDelNegocio();
        }

        private void graficoProductosMasVendidos()
        {
            ArrayList productos = new ArrayList();
            ArrayList cantidadVen = new ArrayList();


            SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena);

            SqlCommand cmd = new SqlCommand("SP_ProductosMasVendidos", Obj_conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            Obj_conexion.Open();

            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                productos.Add(dataReader.GetString(0));
                cantidadVen.Add(dataReader.GetInt32(1));
            }

            chartProductosVen.Series[0].Points.DataBindXY(productos, cantidadVen);

            dataReader.Close();
            Obj_conexion.Close();
        }


        private void graficoCategoriasMasVendidas()
        {
            ArrayList categorias = new ArrayList();
            ArrayList cantidadVen = new ArrayList();


            SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena);

            SqlCommand cmd = new SqlCommand("SP_CategoriasMasVendidas", Obj_conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            Obj_conexion.Open();

            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                categorias.Add(dataReader.GetString(0));
                cantidadVen.Add(dataReader.GetInt32(1));
            }

            chartCategoriasVen.Series[0].Points.DataBindXY(categorias, cantidadVen);

            dataReader.Close();
            Obj_conexion.Close();
        }


        private void datosDelNegocio()
        {

            SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena);

            SqlCommand cmd = new SqlCommand("SP_DatosDelNegocio", Obj_conexion);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter nroVentas = new SqlParameter("@nroVentas", SqlDbType.Int);
            SqlParameter totalRecaudado = new SqlParameter("@totalRecaudado", SqlDbType.Float);
            SqlParameter nroClientes = new SqlParameter("@nroClientes", SqlDbType.Float);
            SqlParameter nroEmpleado = new SqlParameter("@nroEmpleado", SqlDbType.Int);
            SqlParameter nroProveedores = new SqlParameter("@nroProveedores", SqlDbType.Int);
            SqlParameter nroProductos = new SqlParameter("@nroProductos", SqlDbType.Int);


            nroVentas.Direction = ParameterDirection.Output;
            totalRecaudado.Direction = ParameterDirection.Output;
            nroClientes.Direction = ParameterDirection.Output;
            nroEmpleado.Direction = ParameterDirection.Output;
            nroProveedores.Direction = ParameterDirection.Output;
            nroProductos.Direction = ParameterDirection.Output;


            cmd.Parameters.Add(nroVentas);
            cmd.Parameters.Add(totalRecaudado);
            cmd.Parameters.Add(nroClientes);
            cmd.Parameters.Add(nroEmpleado);
            cmd.Parameters.Add(nroProveedores);
            cmd.Parameters.Add(nroProductos);

            Obj_conexion.Open();

            cmd.ExecuteNonQuery();

            lblCantVentas.Text = cmd.Parameters["@nroVentas"].Value.ToString();
            lblTotalRecau.Text = cmd.Parameters["@totalRecaudado"].Value.ToString();
            lblNroClientes.Text = cmd.Parameters["@nroClientes"].Value.ToString();
            lblNroEmpleados.Text = cmd.Parameters["@nroEmpleado"].Value.ToString();
            lblNroProve.Text = cmd.Parameters["@nroProveedores"].Value.ToString();
            lblNroProdu.Text = cmd.Parameters["@nroProductos"].Value.ToString();

            Obj_conexion.Close();

        }

    }
}

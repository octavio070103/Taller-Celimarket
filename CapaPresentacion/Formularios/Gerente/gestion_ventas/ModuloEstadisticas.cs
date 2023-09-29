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
using Proyecto_Taller.Presentacion.Formularios.Vendedor;

namespace CapaPresentacion.Formularios.Gerente.gestion_ventas
{
    public partial class ModuloEstadisticas : Form
    {
        private MenuGerente instanciaMenuGerente;
        public ModuloEstadisticas(MenuGerente p_gerente)
        {
            InitializeComponent();
            MenuGerente gerente = p_gerente;
        }

        private void ModuloEstadisticas_Load(object sender, EventArgs e)
        {
            graficoProductosMasVendidos();
            graficoCategoriasMasVendidas();
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

    }
}

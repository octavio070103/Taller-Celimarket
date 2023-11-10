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

namespace CapaPresentacion.Formularios.Admin
{
    public partial class FrmRespaldo : Form
    {
        private MenuAdministrador instanciaMenuAdministrador;
        private CL_DataBase obj_dataBase = new CL_DataBase(); //creo una instancia de mi capa logica para usar sus metodos en mi formuilario
        public FrmRespaldo(MenuAdministrador p_MenuAdministrador)
        {
            InitializeComponent();
            this.instanciaMenuAdministrador = p_MenuAdministrador;
            txtSelectFolderPath.Visible = false; //escondo eltxt que tiene la ruta
        }

        private void iconBtnFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Selecciona la carpeta en el disco C:";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer; //aca le digo en que carpeta quierop que se habra

                // Establecer la ruta predeterminada en C:\
                folderBrowserDialog.SelectedPath = "C:\\";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK) //aca pregunto si el usuario selecciono una carpeta y confirmo es decir dio ok al la ventana de dialogo que entre al if
                {
                    txtSelectFolderPath.Text = folderBrowserDialog.SelectedPath;//contendra la ruta o el path de la carpeta que el usuairo seleccione para guardar el backup
                    iconBtnFolder.Visible = false;//escondo el btn de seleccioncarpeta
                    txtSelectFolderPath.Visible = true; //muestro eltxt que tiene la ruta
                }
            }
        }

        private void iconBtnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de respaldo (*.bak)|*.bak";
                    openFileDialog.Title = "Seleccione el archivo para Importar";
                    openFileDialog.InitialDirectory = txtSelectFolderPath.Text; // selecciona la ruta inicial que elijio el usuario para ahcer el backup

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string rutaArchivoRespaldo = openFileDialog.FileName;
                        bool resultadoRestauracion = obj_dataBase.RealizarRestauracion("BD_CeliMarket", rutaArchivoRespaldo);

                        if (resultadoRestauracion)
                        {
                            MessageBox.Show("Restauración de la base de datos exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Error al restaurar la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // LimpiarCampos();
        }

        private void iconBtnRespaldar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtSelectFolderPath.Text)) //aca pregunto que si la ruta que selecciono el usuario es distinto de null que entre al if es decir si conteien la ruta que entre al if
                {
                    bool resultadoBackup = obj_dataBase.RealizarBackUp("BD_CeliMarket", txtSelectFolderPath.Text);

                    if (resultadoBackup)
                    {
                        MessageBox.Show("El Backup de la base " + txtNombreBD.Text + " se realizo con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error al realizar  el Backup,Debe de Seleccionar una carpeta que este dentro del disco C ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        iconBtnFolder.Visible = true;
                        txtSelectFolderPath.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una carpeta antes de realizar el Backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar realizar el backup " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // LimpiarCampos();//limpio los campos al salir del metodo respaldar
        }

        private void FrmRespaldo_Load(object sender, EventArgs e)
        {

            string nameBaseDatos = "BD_CeliMarket";
            infoDataBase obj_infoDataBase = obj_dataBase.obtenerInfoDataBase(nameBaseDatos);
            txtNombreBD.Text = nameBaseDatos;
            txtSeleccionServidor.Text = obj_infoDataBase.serverName.ToString();
            txtSeleccionBase.Text = nameBaseDatos;
            txtTamaBD.Text = obj_infoDataBase.size_DB.ToString() + "MB";
            txtCanTablaBD.Text = obj_infoDataBase.totalTablas.ToString();
            dateTimePicker1.Value = obj_infoDataBase.fecha_DB_Backup;
            txtTablasPrinci.Text = obj_infoDataBase.NombresTablas.ToString();
        }
    }
}

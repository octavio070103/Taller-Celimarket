using DocumentFormat.OpenXml.Vml.Office;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public class DataGridDisenio
    {
        //Método para dar formato al DataGridView, recibimos dos paramateros uno tipo DataGrid y otro int para la selección del color.
        public static void Formato(DataGridView pData, int color)
        {
            //   pData.RowHeadersVisible = false;
            //  pData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
          
            switch (color)
            {
                case 1:
                    //hago que elc ontenido de las filas o rows este centrados 
                    pData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    //Ancho de columnas
                    pData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //Alto de las filas
                    pData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    //No se agrege columnas automaticamente
                    pData.AutoGenerateColumns = false;

                    pData.BackgroundColor = Color.FromArgb(67, 68, 89); //color de fondo del datgrid
                    //cambiar color de las grillas
                    pData.GridColor = Color.FromArgb(1,1,1);// Color.FromArgb(1,1,1);//color de las grillas                                                     
                    pData.BorderStyle = BorderStyle.None; //Quitamos el borde
                    pData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; //le doy un borde horizontal a las celdas 

                    //Propiedade de defaultCellStyle
                    //ColumnHeaderDefaultCellStyle,cambiamos el formato de la cabecera aca
                    pData.EnableHeadersVisualStyles = false; //descativamos el fromato predetemrinado de la cabecera del datagrid,  //desactivamos el estilo por defecto de la cabecera
                    pData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; //le asingo un obrode al header de simple
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 33, 75);
                    pData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;  //Color de letra de las columnas
                    pData.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10f, FontStyle.Bold);
                    pData.ColumnHeadersDefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
                    pData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; //activo para que el tamnio de la cabecera sea automatico 
                
                    //Fila,propiedades de la filaDefaultCellstyle
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(67, 68, 89);
                    pData.RowsDefaultCellStyle.Font = new Font("Century Gothic", 9f, FontStyle.Regular); //Font para las filas
                    pData.RowsDefaultCellStyle.ForeColor= Color.White;//color de las letras de las filas
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(47, 33, 75);//color de fondo al seleccionar una fila  o celda
                    pData.RowsDefaultCellStyle.SelectionForeColor = Color.White;//color de las letras al seleccionar la celda
                    pData.RowsDefaultCellStyle.Padding = new Padding(0, 3, 0, 3);

                    //Fila alternativa  o fila secundaria o fila de en medio
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(132, 133, 164);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(112, 86, 164);
                    pData.AlternatingRowsDefaultCellStyle.Padding = new Padding(0, 3, 0, 3);
                    break;
                case 2:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(166, 166, 166);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 149, 183);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(217, 217, 217);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 183, 216);
                    break;
                case 3:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 80, 77);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(230, 184, 183);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(149, 161, 194);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 220, 219);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(157, 185, 217);
                    break;
                case 4:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(155, 187, 89);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(216, 228, 188);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(140, 190, 197);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 241, 222);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(152, 198, 219);
                    break;
                case 5:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 100, 162);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(204, 192, 218);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(132, 166, 216);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(228, 223, 236);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(148, 186, 228);
                    break;
                case 6:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 172, 198);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(183, 222, 232);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(118, 186, 226);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 243);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 196, 233);
                    break;
                case 7:
                    //Columna
                    pData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 150, 70);
                    //Fila
                    pData.RowsDefaultCellStyle.BackColor = Color.FromArgb(252, 213, 180);
                    pData.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(163, 180, 192);
                    //Fila alternativa
                    pData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 233, 217);
                    pData.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(164, 193, 216);
                    break;
            }
        }
    }
}


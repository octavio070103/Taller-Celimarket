using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_DataBase
    {
        public void obtenerInfoDataBase(string nameBaseDatos)
        {
            try
            {
                //le paso cadena de la clase conexion 
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    try
                    {
                        //creo un nuevo sqlcommand que me pide 2 cosass el procedimiento almacenado y la conexion que abrimos es decir el objConexion 
                        SqlCommand cmd = new SqlCommand("SP_OBTENERINFO_DB", Obj_conexion);

                       
                        //parametros de salida que tiene este procedimiento almacenado es decir el resultado de esa operacio(mis variables aux de mis operaciones
                        cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;//declaro mi variable de salidad de mi procedimiento almacenado resultado me trae el id_resultado
                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                        // Establece el tipo de comando a CommandType.StoredProcedure, lo que significa que la consulta es una instrucción SQL Procedural.
                        cmd.CommandType = CommandType.StoredProcedure;
                        Obj_conexion.Open();//Abre la conexión a la base de datos utilizando el objeto Obj_conexion. Esto prepara la conexión para ejecutar la consulta SQL.

                        //ejcutamos nuestro comando
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                        Console.WriteLine("Error de conexión: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                Console.WriteLine("Error de conexión: " + ex.Message);
            }
        }

        public bool RealizarBackup(string nameBaseDatos, string backupPath)
        {
            bool respuesta = false; //retorno el valor de la operacion de backup

            try
            {
                string backupFileName = backupPath + "\\Backup" + nameBaseDatos + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak";

                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    Obj_conexion.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Obj_conexion;
                        cmd.CommandText = $"BACKUP DATABASE [{nameBaseDatos}] TO DISK = '{backupFileName}'";
                        cmd.ExecuteNonQuery();
                    }
                }

                respuesta= true;
            }
            catch (Exception ex)
            {
                // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return respuesta;
        }

        public bool RealizarRestauracion(string nameBaseDatos, string restauracionPath)
        {
            bool respuesta = false; //retorno el valor de la operacion de restauracion

            try
            {
                using (SqlConnection Obj_conexion = new SqlConnection(CD_conexion.cadena))
                {
                    Obj_conexion.Open();

                    // Asegúrate de que no haya conexiones activas a la base de datos que deseas restaurar
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Obj_conexion;
                        cmd.CommandText = $@"
                        ALTER DATABASE [{nameBaseDatos}]
                        SET SINGLE_USER
                        WITH ROLLBACK IMMEDIATE;";

                        cmd.ExecuteNonQuery();
                    }

                    // Realizar la restauración
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Obj_conexion;
                        cmd.CommandText = $"USE master; RESTORE DATABASE [{nameBaseDatos}] FROM DISK = '{restauracionPath}' WITH REPLACE;";
                        cmd.ExecuteNonQuery();
                    }

                    // Volver a la base de datos original
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = Obj_conexion;
                        cmd.CommandText = $"USE [{nameBaseDatos}];";
                        cmd.ExecuteNonQuery();
                    }
                }

                respuesta= true;
            }
            catch (Exception ex)
            {
                // Maneja la excepción aquí, puedes imprimir un mensaje de error o registrar la excepción en un archivo de registro.
                Console.WriteLine("Error de conexión: " + ex.Message);
            }

            return respuesta;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Capa_de_Datos
{
    public class CapaDatos
    {
        static string Cadena_Conexion = "Data Source=.;Initial Catalog=MusicStore;Integrated Security=True";
        static SqlConnection Conexion = new SqlConnection(Cadena_Conexion);
        public DataTable Ejecutar_Consulta(StringBuilder Query, SqlCommand Comando) {
            // Es mejor usar un DataTable cuando trabajemos con consultas a una sola tabla.
            DataTable Tabla = new DataTable();
            try
            {
                Conexion.Open();
                if (Comando == null)
                {
                    Comando = new SqlCommand();
                }
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Query.ToString();

                SqlDataReader Lector = Comando.ExecuteReader();
                // DataReader para tabajar DataTable!

                Tabla.Load(Lector);
                Conexion.Close();

                return Tabla;
            }
            catch (Exception ex)
            {
                Conexion.Close();
                throw new Exception("Error en Capa de Datos: " + ex);
                // En el mundo real mostrar el mensaje de error no es lo optimo, pues puede ser informacion sensible.
            }
        }
    }
}

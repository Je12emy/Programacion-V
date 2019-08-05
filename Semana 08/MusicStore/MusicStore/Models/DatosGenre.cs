using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace MusicStore.Models
{
    public class DatosGenre
    {
        CapaDatos _CadaDatos = new CapaDatos();
        // Creamos una instancia de CapaDatos
        readonly string mensajeError = "Error en datos genero";

        public DataTable ConsultarGenero(int idGenero = 0) {
            // Aca declaramos el Parametro de idGenero como 0, pues asi sera Opcional.
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand Comando = new SqlCommand();
            DataTable Tabla = new DataTable();

            try
            {
                // Hacemos un query para seleccionar todos los datos en Genre
                sqlQuery.Append("SELECT * FROM Genre ");
                // Al hacer el siguiente podemos especificar el filtro en caso de que nos den un valor
                if (idGenero != 0)
                {
                    sqlQuery.Append(" Where GenreId = @IdGenero");
                    Comando.Parameters.Add("@IdGenero", SqlDbType.Int).Value = idGenero;
                    Tabla = _CadaDatos.Ejecutar_Consulta(sqlQuery, Comando);
                }
                else {
                    Tabla = _CadaDatos.Ejecutar_Consulta(sqlQuery);
                }
                return Tabla;
            }
            catch (Exception)
            {
                throw new Exception(mensajeError);
            }
        }


        public void InsertarGenero(string Nombre,string Descripcion) {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand Comando = new SqlCommand();
            int Resultado = 0;

            try
            {
                sqlQuery.Append("INSERT INTO Genre VALUES(@Nombre, @Descripcion)");
                Comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = Nombre.Trim() ;
                Comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = Descripcion.Trim() ;

                Resultado = _CadaDatos.EjecutarSentencia(sqlQuery, Comando);
            }
            catch (Exception ex)
            {

                throw new Exception(mensajeError + ex.Message);
            }
        }
        public void ModificarGenero(string IdGenero, string Nombre, string Descripcion) {
            StringBuilder sqlQuery = new StringBuilder();
            SqlCommand Comando = new SqlCommand();
            int Resultado = 0;

            try
            {
                sqlQuery.Append("UPDATE Genre SET Name = @Nombre, Description = @Description WHERE GenreId = @IdGenero");
                Comando.Parameters.Add("@IdGenero", SqlDbType.Int).Value = IdGenero;
                Comando.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = Nombre;
                Comando.Parameters.Add("@Description", SqlDbType.NVarChar).Value = Descripcion;

                Resultado = _CadaDatos.EjecutarSentencia(sqlQuery, Comando);
            }
            catch (Exception ex)
            {

                throw new Exception(mensajeError + ex.Message);
            }
        }
    }
}
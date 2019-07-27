using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace MusicStore.Models
{
    public class Genre
    {
        // Definimos los parametros que trabajara el modelo de Datos, estos mismos parametros son capturados en el View y
        // alimentaran a los metodos de consulta.
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DataTable Tabla { get; set; }

        // Es buena practica iniciar los datos en vacio en caso de que a causa de un error no se de una excepcion
        public Genre() {
            Id = 0;
            Nombre = "";
            Descripcion = "";
            Tabla = new DataTable();
        }


    }
}
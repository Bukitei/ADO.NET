using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualCADO.NET
{
    class Conexion
    {
        public Conexion() { }

        public SqlConnection Con()
        {
            // Nombre servidor + nombre base de dataos + Autentificación Windows SI/NO
            string connectionString = "data source=localhost; " +
            "initial catalog=bdResidenciasEscolares; integrated security=true";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open(); // Abrimos conexión

            return connection;
        }
    }
}

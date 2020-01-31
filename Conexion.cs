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
        SqlConnection conn;
        public SqlConnection Con
        {
            get { return conn; }
            set { conn = value; }
        }
        public Conexion()
        { // establecer la conexion
            string strConn = "data source=localhost; " +
            "initial catalog=bdResidenciasEscolares; integrated security=true";
            Con = new SqlConnection(strConn);
        }
    }
}

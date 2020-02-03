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



namespace visualCADO.NET
{
    public partial class Form1 : Form
    {
        Conexion cc = new Conexion();

        int table;

        DataSet ds;

        SqlDataAdapter da;


        public Form1()
        {
            InitializeComponent();
        }

        private void goToEstancias_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = cc.Con)
            {
                using (SqlCommand cmd = new SqlCommand("select * from estancias", conn))
                {
                    conn.Open(); //Abrimos la conexión

                    ds = new DataSet();

                    da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "Estancias");

                    dataGrid.DataSource = ds.Tables["Estancias"]; //Cargamos los datos en la tabla

                    table = 0; //Indicamos con que tabla estamos tratando
                }
            }

        }

        private void goToEstudiantes_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = cc.Con)
            {
                using (SqlCommand cmd = new SqlCommand("select * from estudiantes", conn))
                {
                    conn.Open();

                    ds = new DataSet();

                    da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "Estudiantes");

                    dataGrid.DataSource = ds.Tables["Estudiantes"]; //Cargamos los datos en la tabla

                    table = 1;
                }
            }
        }

        private void goToResidencias_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = cc.Con)
            {
                using (SqlCommand cmd = new SqlCommand("select * from residencias", conn))
                {
                    conn.Open();

                    ds = new DataSet();

                    da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "Residencias");

                    dataGrid.DataSource = ds.Tables["Residencias"]; //Cargamos los datos en la tabla

                    table = 2;
                }
            }
        }

        private void goToUniversidades_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = cc.Con)
            {
                using (SqlCommand cmd = new SqlCommand("select * from universidades", conn))
                {
                    conn.Open();

                    ds = new DataSet();

                    da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "Universidades");

                    dataGrid.DataSource = ds.Tables["Universidades"]; //Cargamos los datos en la tabla

                    table = 3;
                }
            }
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da); // Construye la sentencia correspondiente
            if (table == 0)
            {
                da.Update(ds.Tables["Estancias"]); // Funciona para borrar, insertar o modificar gracias al SqlCommandBuilder
            }
            else if (table == 1)
            {
                da.Update(ds.Tables["Estudiantes"]);
            }
            else if (table == 2)
            {
                da.Update(ds.Tables["Residencias"]);
            }
            else
            {
                da.Update(ds.Tables["Universidades"]);
            }


        }
    }
    
}

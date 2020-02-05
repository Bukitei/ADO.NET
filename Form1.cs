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
            dataGrid.DefaultCellStyle.NullValue = "Sin dato";
        }

        private void goToEstancias_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = cc.Con())
            {
                using (SqlCommand cmd = new SqlCommand("select * from estancias", conn))
                {

                    ds = new DataSet();

                    da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "Estancias");

                    dataGrid.DataSource = ds.Tables["Estancias"]; //Cargamos los datos en la tabla

                    dataGrid.Columns[0].HeaderText = "Código de estudiante";
                    dataGrid.Columns[1].HeaderText = "Código de residencia";
                    dataGrid.Columns[2].HeaderText = "Fecha de inicio";
                    dataGrid.Columns[3].HeaderText = "Fecha fin";
                    dataGrid.Columns[4].HeaderText = "Precio pagado";

                    table = 0; //Indicamos con que tabla estamos tratando
                }
            }

        }

        private void goToEstudiantes_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = cc.Con())
            {
                using (SqlCommand cmd = new SqlCommand("select * from estudiantes", conn))
                {

                    ds = new DataSet();

                    da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "Estudiantes");

                    dataGrid.DataSource = ds.Tables["Estudiantes"]; //Cargamos los datos en la tabla

                    dataGrid.Columns[0].HeaderText = "Código de estudiante";
                    dataGrid.Columns[1].HeaderText = "Nombre de estudiante";
                    dataGrid.Columns[2].HeaderText = "DNI";
                    dataGrid.Columns[3].HeaderText = "Teléfono de estudiante";

                    table = 1;
                }
            }
        }

        private void goToResidencias_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = cc.Con())
            {
                using (SqlCommand cmd = new SqlCommand("select * from residencias", conn))
                {

                    ds = new DataSet();

                    da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "Residencias");

                    dataGrid.DataSource = ds.Tables["Residencias"];

                    dataGrid.Columns[0].HeaderText = "Id de residencia";
                    dataGrid.Columns[1].HeaderText = "Nombre de residencia";
                    dataGrid.Columns[2].HeaderText = "Código de universidad";
                    dataGrid.Columns[3].HeaderText = "Precio mensual";
                    dataGrid.Columns[4].HeaderText = "Comedor";

                    table = 2;
                }
            }
        }

        private void goToUniversidades_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = cc.Con())
            {
                using (SqlCommand cmd = new SqlCommand("select * from universidades", conn))
                {

                    ds = new DataSet();

                    da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "Universidades");

                    dataGrid.DataSource = ds.Tables["Universidades"]; //Cargamos los datos en la tabla

                    dataGrid.Columns[0].HeaderText = "Código de universidad";
                    dataGrid.Columns[1].HeaderText = "Nombre de universidad";

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
            using (SqlConnection conn = cc.Con())
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da); // Construye la sentencia correspondiente
                da.SelectCommand.Connection = conn;
                

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
    
}

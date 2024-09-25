using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Gym
{
    public partial class Buscar_Miembro : Form
    {
        public Buscar_Miembro()
        {
            InitializeComponent();
        }

        // Función para cargar datos de los miembros
        private void CargarMiembros(string filtro = "")
        {
            // CONEXIÓN A LA BASE DE DATOS
            MySqlConnection con = new MySqlConnection("server=localhost;database=GymBD;uid=root;pwd=lalita2012;");

            // Comando SQL para seleccionar todos los miembros o con filtro si existe
            string query = "SELECT * FROM miembros";

            if (!string.IsNullOrEmpty(filtro))
            {
                query += " WHERE miembroID = @filtro OR dni = @filtro";
            }

            MySqlCommand cmd = new MySqlCommand(query, con);

            if (!string.IsNullOrEmpty(filtro))
            {
                cmd.Parameters.AddWithValue("@filtro", filtro);
            }

            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DataSet DS = new DataSet();

            try
            {
                con.Open(); // Abre la conexión
                DA.Fill(DS); // Llena el DataSet con los resultados de la consulta

                if (DS.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = DS.Tables[0]; // Muestra los resultados en el DataGridView

                    // Ajusta las columnas y filas al contenido
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.AutoResizeRows();
                }
                else
                {
                    MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close(); // Cierra la conexión
            }
        }

        // Evento Load del formulario para cargar automáticamente los miembros
        private void Buscar_Miembro_Load(object sender, EventArgs e)
        {
            CargarMiembros();  // Carga todos los miembros al abrir el formulario
        }

  

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
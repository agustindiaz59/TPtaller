using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Gym
{
    public partial class Buscar_Miembro : Form
    {
        public Buscar_Miembro()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            // Configuración inicial de los controles
            InicializarControles();
        }

        private void InicializarControles()
        {
            // Configuración del DataGridView
            dataGridView1.Dock = DockStyle.Fill; // Hace que el DataGridView ocupe todo el ancho y alto del contenedor
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta las columnas para ocupar el ancho disponible

            // Configuración del panel2
            panel2.Dock = DockStyle.Fill; // Hace que el panel2 ocupe todo el ancho y alto del contenedor
        }

        private void CargarMiembros(string filtro = "", int pageNumber = 1, int pageSize = 20)
        {
            string connectionString = "server=localhost;database=GymBD;uid=root;pwd=lalita2012;";

            // Modificar la consulta para incluir paginación
            string query = "SELECT * FROM miembros";

            if (!string.IsNullOrEmpty(filtro))
            {
                query += " WHERE miembroID = @filtro OR dni = @filtro";
            }

            // Agregar paginación
            query += $" LIMIT @pageSize OFFSET @offset";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, con))
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    cmd.Parameters.AddWithValue("@filtro", filtro);
                }

                cmd.Parameters.AddWithValue("@pageSize", pageSize);
                cmd.Parameters.AddWithValue("@offset", (pageNumber - 1) * pageSize);

                using (MySqlDataAdapter DA = new MySqlDataAdapter(cmd))
                {
                    DataSet DS = new DataSet();
                    try
                    {
                        con.Open();
                        DA.Fill(DS);

                        if (DS.Tables[0].Rows.Count > 0)
                        {
                            dataGridView1.DataSource = DS.Tables[0];
                            AjustarDataGridView();
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
                }
            }
        }

        private void AjustarDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajustar columnas para llenar el ancho
            dataGridView1.AutoResizeRows(); // Ajustar filas según contenido
        }

        private void Buscar_Miembro_Load(object sender, EventArgs e)
        {
            CargarMiembros();  // Carga todos los miembros al abrir el formulario
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }
    }
}
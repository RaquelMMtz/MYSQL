using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class ExhibicionNacional : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public ExhibicionNacional()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVExNa.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM ExhibicionNacional ORDER BY idExhibicionNacional");
        }
        private void ExhibicionNacional_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

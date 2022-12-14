using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class CambioDirectivo : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public CambioDirectivo()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVCD.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM CambioDirectivo ORDER BY idCambioDirectivo");
        }
        private void CambioDirectivo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Directivo = txtIDD.Text;
            string Cambio = txtIDC.Text;
            string numInt = txtNumIn.Text;
            consulta = "INSERT INTO CambioDirectivo (idCambio, idDirectivo, numIntegrantes) values ('" + Cambio + "','" + Directivo + "','" + numInt + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDD.Clear();
            txtIDC.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idCambioDirectivo = (int)dGVCD.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE CambioDirectivo SET ESTATUS = 0 WHERE idCambioDirectivo =" + idCambioDirectivo.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Directivo = txtIDD.Text;
            string Cambio = txtIDC.Text;
            string numInt = txtNumIn.Text;
            int idCambioDirectivo = (int)dGVCD.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE AnimacionAnimador SET idCambio ='" + Cambio + "',idDirectivo='" + Directivo + "',numIntegrantes='" + numInt + "'WHERE idCambioDirectivo = " + idCambioDirectivo.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDD.Clear();
            txtIDC.Clear();
            txtNumIn.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}

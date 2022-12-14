using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class AnimacionAnimador : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public AnimacionAnimador()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVAA.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM AmimacionAnimador ORDER BY idAmimacionAnimador");
        }
        private void AnimacionAnimador_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Animacion = txtIDANI.Text;
            string Animador = txtIDAN.Text;
            string numInt = txtNumIn.Text;
            consulta = "INSERT INTO AnimacionAnimador (idAnimacion, idAnimador, numIntegrantes) values ('" + Animacion + "','" + Animador + "','" + numInt + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            txtIDANI.Clear();
            txtIDAN.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAnimacionAnimador = (int)dGVAA.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE AnimacionAnimador SET ESTATUS = 0 WHERE idAnimacionAnimador =" + idAnimacionAnimador.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Animacion = txtIDANI.Text;
            string Animador = txtIDAN.Text;
            string numInt = txtNumIn.Text;
            int idAnimacionAnimador = (int)dGVAA.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE AnimacionAnimador SET idAnimacion ='" + Animacion + "',idAnimador='" + Animador + "',numIntegrantes='" + numInt + "'WHERE idAnimacionAnimador = " + idAnimacionAnimador.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDANI.Clear();
            txtIDAN.Clear();
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

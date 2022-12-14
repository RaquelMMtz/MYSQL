using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class Junta_Directiva : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Junta_Directiva()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVJD.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM JuntaDirectiva ORDER BY idJuntaDirectiva");
        }
        private void Junta_Directiva_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string motivo = txtMotivo.Text;
            string numIn = txtNumIn.Text;
            consulta = "INSERT INTO JuntaDirectiva (motivo, numIntegrantes) values ('" + motivo + "','" + numIn + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtMotivo.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idJuntaDirectiva = (int)dGVJD.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE JuntaDirectiva SET ESTATUS = 0 WHERE idJuntaDirectiva =" + idJuntaDirectiva.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string motivo = txtMotivo.Text;
            string numIn = txtNumIn.Text;
            int idJuntaDirectiva = (int)dGVJD.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE JuntaDirectiva SET motivo ='" + motivo + "',numIntegrantes='" + numIn + "'WHERE idJuntaDirectiva = " + idJuntaDirectiva.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtMotivo.Clear();
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

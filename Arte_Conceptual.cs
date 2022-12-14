using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class Arte_Conceptual : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Arte_Conceptual()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVArteConceptual.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Actor ORDER BY idActor");
        }
        private void Arte_Conceptual_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtFechaEntrega.Text;
            string concepto = txtConcepto.Text;
            consulta = "INSERT INTO ArteConceptual (concepto,fechaEntrega) values ('" + concepto + "','" + fechaEntrega + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFechaEntrega.Clear();
            txtConcepto.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idArteConceptual = (int)dGVArteConceptual.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ArteConceptual SET ESTATUS = 0 WHERE idArteConceptual =" + idArteConceptual.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtFechaEntrega.Text;
            string concepto = txtConcepto.Text;
            int idArteConceptual = (int)dGVArteConceptual.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE ArteConceptual SET concepto ='" + concepto + "',fechaEntrega='" + fechaEntrega + "','" + "'WHERE idArteConceptual = " + idArteConceptual.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtConcepto.Clear();
            txtFechaEntrega.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class Esqueletizacion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Esqueletizacion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVEsq.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Esqueletizacion ORDER BY idEsqueletizacion");
        }
        private void Esqueletizacion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idTecnico = txtIDTecnico.Text;
            consulta = "INSERT INTO Esqueletizacion (fecha, idTecnico) values ('" + fecha + "','" + idTecnico + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtIDTecnico.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEsqueletizacion = (int)dGVEsq.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Esqueletizacion SET ESTATUS = 0 WHERE idEsqueletizacion =" + idEsqueletizacion.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idTecnico = txtIDTecnico.Text;
            int idEsqueletizacion = (int)dGVEsq.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Equeletizacion SET fechaEntrega ='" + fecha + "',idTecnico='" + idTecnico + "'WHERE idEsqueletizacion = " + idEsqueletizacion.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtIDTecnico.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class DiaPressentacion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public DiaPressentacion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVDP.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM DiaPresentacion ORDER BY idDiaPresentacion");
        }
        private void DiaPressentacion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string fecha = txtFecha.Text;
            string idJuntaDirectiva = txtIDJD.Text;
            consulta = "INSERT INTO DiaPresentacion (descripcion, fecha, id) values ('" + descripcion + "','" + fecha + "','" + idJuntaDirectiva + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
            txtFecha.Clear();
            txtIDJD.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idDiaPresentacion = (int)dGVDP.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE DiaPresentacion SET ESTATUS = 0 WHERE idDiaPresentacion =" + idDiaPresentacion.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string fecha = txtFecha.Text;
            string idJuntaDirectiva = txtIDJD.Text;
            int idDiaPresentacion = (int)dGVDP.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE DiaPresentacion SET descripcion ='" + descripcion + "',fecha='" + fecha + "',idJuntaDirectiva='" + idJuntaDirectiva + "'WHERE idDiaPresentacion = " + idDiaPresentacion.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
            txtFecha.Clear();
            txtIDJD.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}

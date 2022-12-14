using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class CorreccionColor : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public CorreccionColor()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVCC.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM CorreccionColor ORDER BY idCorreccionColor");
        }
        private void CorreccionColor_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string fecha = txtFecha.Text;
            string idTecnico = txtIDTecnico.Text;
            consulta = "INSERT INTO ColeccionColor (descripcion, fecha, idTecnico) values ('" + descripcion + "','" + fecha + "','" + idTecnico + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
            txtFecha.Clear();
            txtIDTecnico.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idColeccionColor = (int)dGVCC.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ColeccionColor SET ESTATUS = 0 WHERE idColeccionColor =" + idColeccionColor.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string fecha = txtFecha.Text;
            string idTecnico = txtIDTecnico.Text;
            int idColeccionColor = (int)dGVCC.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE ColeccionColor SET descripcion ='" + descripcion + "',fechaEntrega='" + fecha + "',idTecnico='" + idTecnico + "'WHERE idColeccionColor = " + idColeccionColor.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
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

using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class ColorScript : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public ColorScript()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVCS.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM ColorScript ORDER BY idColorScript");
        }
        private void ColorScript_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string fechaEntrega = txtFecha.Text;
            string idArtista = txtIDArtista.Text;
            consulta = "INSERT INTO ColorScript (descripcion,fechaEntrega, idArtista) values ('" + descripcion + "','" + fechaEntrega + "','" + idArtista + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
            txtFecha.Clear();
            txtIDArtista.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idColorScript = (int)dGVCS.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ColorScript SET ESTATUS = 0 WHERE idColorScript =" + idColorScript.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string fechaEntrega = txtFecha.Text;
            string idArtista = txtIDArtista.Text; ;
            int idColorScript = (int)dGVCS.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE ColorScrpt SET descripcion ='" + descripcion + "',fechaEntrega='" + fechaEntrega + "',idArtista='" + idArtista + "'WHERE idColorScript = " + idColorScript.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
            txtFecha.Clear();
            txtIDArtista.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}

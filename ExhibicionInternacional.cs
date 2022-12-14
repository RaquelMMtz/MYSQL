using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class ExhibicionInternacional : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public ExhibicionInternacional()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVExIn.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM ExhibicionInternacional ORDER BY idExhibicionInternacional");
        }
        private void ExhibicionInternacional_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string calle = txtC.Text;
            string numero = txtNum.Text;
            string colonia = txtCol.Text;
            string ciudad = txtCiu.Text;
            string pais = txtP.Text;
            string idGerente = txtIDG.Text;
            consulta = "INSERT INTO ExhibicionInternacional (fecha, calle, numero, colonia, ciudad, pais, idGerente) values ('" + fecha + "','" + calle + "','" + numero + "','" + colonia + "','" + ciudad + "','" + pais + "','" + idGerente + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtC.Clear();
            txtNum.Clear();
            txtCol.Clear();
            txtCiu.Clear();
            txtP.Clear();
            txtIDG.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idExhibicionInternacional = (int)dGVExIn.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ExhibicionInternacional SET ESTATUS = 0 WHERE idExhibicionInternacional =" + idExhibicionInternacional.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string calle = txtC.Text;
            string numero = txtNum.Text;
            string colonia = txtCol.Text;
            string ciudad = txtCiu.Text;
            string pais = txtP.Text;
            string idGerente = txtIDG.Text;
            int idExhibicionInternacional = (int)dGVExIn.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE ExhibicionInternacional SET fecha ='" + fecha + "',calle='" + calle + "',numero='" + numero + "',colonia='" + colonia + "',ciudad='" + ciudad + "',pais='" + pais + "',idGerente='" + idGerente + "'WHERE idExhibicionInternacional = " + idExhibicionInternacional.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtC.Clear();
            txtNum.Clear();
            txtCol.Clear();
            txtCiu.Clear();
            txtP.Clear();
            txtIDG.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}

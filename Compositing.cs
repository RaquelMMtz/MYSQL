using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class Compositing : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Compositing()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVCom.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Compositing ORDER BY idCompositing");
        }
        private void Compositing_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idTecnico = txtIDTecnico.Text;
            consulta = "INSERT INTO Compositing (fechaEntrega, idTecnico) values ('" + fecha + "','" + idTecnico + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtIDTecnico.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idCompositing = (int)dGVCom.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Compositing SET ESTATUS = 0 WHERE idCompositing =" + idCompositing.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idTecnico = txtIDTecnico.Text;
            int idCompositing = (int)dGVCom.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Compositing SET fechaEntrega ='" + fecha + "',idTecnico='" + idTecnico + "'WHERE idCompositing = " + idCompositing.ToString();
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

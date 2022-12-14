using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class MattePainting : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public MattePainting()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVMP.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM MattePainting ORDER BY idMattePPainting");
        }
        private void MattePainting_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idFondista = txtIDFondista.Text;
            consulta = "INSERT INTO MattePainting (fechaEntrega, idFondista) values ('" + fecha + "','" + idFondista + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtIDFondista.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idMattePainting = (int)dGVMP.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE MattePainting SET ESTATUS = 0 WHERE idMattePainting =" + idMattePainting.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idFondista = txtIDFondista.Text;
            int idMattePainting = (int)dGVMP.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE MattePainting SET fechaEntrega ='" + fecha + "',idFondista='" + idFondista + "'WHERE idMattePainting = " + idMattePainting.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtIDFondista.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}

using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class ArtistaStoryBoard : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public ArtistaStoryBoard()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVAS.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM ArtistaStoryBoard ORDER BY idArtistaStoryBoard");
        }
        private void ArtistaStoryBoard_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Artista = txtIDA.Text;
            string StoryBoard = txtIDS.Text;
            string numInt = txtNumIn.Text;
            consulta = "INSERT INTO AnimacionAnimador (idAnimacion, idAnimador, numIntegrantes) values ('" + Artista + "','" + StoryBoard + "','" + numInt + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDA.Clear();
            txtIDS.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idArtistaStoryBoard = (int)dGVAS.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ArtistaStoryBoard SET ESTATUS = 0 WHERE idArtistaStoryBoard =" + idArtistaStoryBoard.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }
    

        private void btnModificar_Click(object sender, EventArgs e)
        {
        string Artista = txtIDA.Text;
        string StoryBoard = txtIDS.Text;
        string numInt = txtNumIn.Text;
        int idArtistaStoryBoard = (int)dGVAS.SelectedRows[0].Cells[0].Value;
        consulta = "  UPDATE ArtistaStoryBoard SET idArtista ='" + Artista + "',idStoryBoard='" + StoryBoard + "',numIntegrantes='" + numInt + "'WHERE idArtistaStoryBoard = " + idArtistaStoryBoard.ToString();
        conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        txtIDA.Clear();
        txtIDS.Clear();
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

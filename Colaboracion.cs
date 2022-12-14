﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class Colaboracion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Colaboracion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVColaboracion.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM Colaboracion ORDER BY idColaboracion");
        }
        private void Colaboracion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Estudio = txtEstudio.Text;
            string NumInt = txtNumIn.Text;
            string idJuntaDirectiva = txtIDJD.Text;
            consulta = "INSERT INTO Colaboracion (estudio, numIntegrantes, idJuntaDirectiva) values ('" + Estudio + "','" + NumInt + "','" + idJuntaDirectiva + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtEstudio.Clear();
            txtIDJD.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idColaboracion = (int)dGVColaboracion.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Colaboracion SET ESTATUS = 0 WHERE idColaboracion =" + idColaboracion.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Estudio = txtEstudio.Text;
            string NumInt = txtNumIn.Text;
            string idJuntaDirectiva = txtIDJD.Text;
            int idColaboracion = (int)dGVColaboracion.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Colaboracion SET estudio ='" + Estudio + "',numIntegrantes='" + NumInt + "',idJuntaDirectiva='" + idJuntaDirectiva + "'WHERE idColaboracion = " + idColaboracion.ToString();
            conexion.Open();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtEstudio.Clear();
            txtIDJD.Clear();
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

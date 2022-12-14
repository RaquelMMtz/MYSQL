﻿using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalMYSQL
{
    public partial class GrabacionVoz : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public GrabacionVoz()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=Biblioteca;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVGV.DataSource = ConexionMYSQL.ejecutaConsultaSelect("SELECT *FROM GrabacionVoz ORDER BY idGrabacionVoz");
        }
        private void GrabacionVoz_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idTecnico = txtIDTecnico.Text;
            consulta = "INSERT INTO GrabacionVoz (fechaEntrega, idTecnico) values ('" + fecha + "','" + idTecnico + "')";
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtIDTecnico.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idGrabacionVoz = (int)dGVGV.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE GrabacionVoz SET ESTATUS = 0 WHERE idGrabacionVoz =" + idGrabacionVoz.ToString();
            ConexionMYSQL.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idTecnico = txtIDTecnico.Text;
            int idGrabacionVoz = (int)dGVGV.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE GrabacionVoz SET fechaEntrega ='" + fecha + "',idTecnico='" + idTecnico + "'WHERE idGrabacionVoz = " + idGrabacionVoz.ToString();
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

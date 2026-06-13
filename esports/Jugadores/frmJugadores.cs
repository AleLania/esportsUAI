using Business;
using Entities;
using esports.Equipos;
using esports.Jugadores;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace esports
{
    public partial class frmJugadores : Form
    {
        public frmJugadores()
        {
            InitializeComponent();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {

            frmCargarJugador ventana = new frmCargarJugador();
            ventana.ShowDialog();

            cargarJugadores();
        }

        private void cargarJugadores()
        {
            JugadorBusiness jugador = new JugadorBusiness();

            dgvJugadores.DataSource = jugador.obtenerJugadores();

            //oculto columnas de id que quedan feo
            dgvJugadores.Columns["IdJugador"].Visible = false;
            dgvJugadores.Columns["IdEquipo"].Visible = false;
        }
        private void frmJugadores_Load(object sender, EventArgs e)
        {
            cargarJugadores();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            frmModificarJugador ventana = new frmModificarJugador();
            ventana.ShowDialog();
            cargarJugadores();
        }
    }
}

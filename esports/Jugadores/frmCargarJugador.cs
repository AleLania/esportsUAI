using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace esports.Jugadores
{
    public partial class frmCargarJugador : Form
    {
        public frmCargarJugador()
        {
            InitializeComponent();
        }

        private void frmCargarJugador_Load(object sender, EventArgs e)
        {

        }

        private void cmbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            JugadoresEntity jugador = new JugadoresEntity();

            jugador.NombreApellido = txtNombreApellido.Text;
            jugador.Nick = txtNick.Text;

            JugadorBusiness jugadorBusiness = new JugadorBusiness();

            jugadorBusiness.cargarJugador(jugador);
        }
    }
}

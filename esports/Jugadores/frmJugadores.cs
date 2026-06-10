using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Business;
using Entities;


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

            string nombre = Interaction.InputBox("Ingrese el nombre del jugador");
            string tag = Interaction.InputBox("Ingrese el tag del jugador");
        }

        private void cargarJugadores()
        {
            JugadorBusiness jugador = new JugadorBusiness();

            dgvJugadores.DataSource = jugador.ObtenerJugadores();
        }
        private void frmJugadores_Load(object sender, EventArgs e)
        {
            cargarJugadores();
        }
    }
}

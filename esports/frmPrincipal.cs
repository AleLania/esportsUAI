using Data;
using esports.Competencias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using esports.Partidos;

namespace esports
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnJugadores_Click(object sender, EventArgs e)
        {
            try
            {
                frmJugadores ventana = new frmJugadores();
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de jugadores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                frmEquipos ventana = new frmEquipos();
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de equipos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            try
            {
                frmPartidos ventana = new frmPartidos();
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de partidos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompetencias_Click(object sender, EventArgs e)
        {
            try
            {
                frmResultados ventana = new frmResultados();
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la ventana de competencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBracket_Click(object sender, EventArgs e)
        {
            //aca ventana al bracket de la copa
            ShowDialog();
        }
    }
}

using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            frmJugadores ventana = new frmJugadores();
            ventana.ShowDialog();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            frmEquipos ventana = new frmEquipos();
            ShowDialog();
        }

        private void btnPartidos_Click(object sender, EventArgs e)
        {
            //aca ventana a partidos
            ShowDialog();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            //aca ventana a tabla de la liga
            ShowDialog();
        }

        private void btnBracket_Click(object sender, EventArgs e)
        {
            //aca ventana al bracket de la copa
            ShowDialog();
        }
    }
}

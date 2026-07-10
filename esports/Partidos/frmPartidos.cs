using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using esports;

namespace esports.Partidos
{
    public partial class frmPartidos : Form
    {
        public frmPartidos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarPartidoCopa_Click(object sender, EventArgs e)
        {
            frmPartidoCopa ventana = new frmPartidoCopa();
            ventana.ShowDialog();
        }

        private void btnCargarPartidoTorneo_Click(object sender, EventArgs e)
        {
            frmPartidoTorneo ventana = new frmPartidoTorneo();
            ventana.ShowDialog();
        }
    }
}

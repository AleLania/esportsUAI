using esports.Equipos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace esports
{
    public partial class frmEquipos : Form
    {
        public void updateDgv()
        {
            dgvEquipos.DataSource = null;
            //dgvEquipos.DataSource = EquiposBusiness.GetEquipos();
        }
        public frmEquipos()
        {
            InitializeComponent();
            updateDgv();
        }

        private void btnAddEquipo_Click(object sender, EventArgs e)
        {
            frmAddEquipos ventana = new frmAddEquipos();
            ventana.ShowDialog();
        }

        private void btnUpdateEquipo_Click(object sender, EventArgs e)
        {
            frmUpdateEquipos ventana = new frmUpdateEquipos();
            ventana.ShowDialog();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

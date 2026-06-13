using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;
using esports.Equipos;

namespace esports
{
    public partial class frmEquipos : Form
    {
        public void cargarEquipos()
        {
            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = EquipoBusiness.getEquipos();
        }

        public frmEquipos()
        {
            InitializeComponent();
        }

        private void btnUpdateEquipo_Click(object sender, EventArgs e)
        {
            frmUpdateEquipos ventana = new frmUpdateEquipos();
            ventana.ShowDialog();
            cargarEquipos();
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            cargarEquipos();
        }

        private void btnAddEquipo_Click(object sender, EventArgs e)
        {
            frmAddEquipos ventana = new frmAddEquipos();
            ventana.ShowDialog();
            cargarEquipos();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
            try
            {
                dgvEquipos.DataSource = null;
                dgvEquipos.DataSource = EquipoBusiness.getEquiposTorneo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public frmEquipos()
        {
            InitializeComponent();
        }

        private void btnUpdateEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateEquipos ventana = new frmUpdateEquipos(this);
                ventana.ShowDialog();
                cargarEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            cargarEquipos();
        }

        private void btnAddEquipo_Click(object sender, EventArgs e)
        {
            frmAddEquipos ventana = new frmAddEquipos(this);
            ventana.ShowDialog();
            cargarEquipos();
        }

        private void btnVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            frmDeleteEquipos ventana = new frmDeleteEquipos(this);
            ventana.ShowDialog();
            cargarEquipos();
        }
    }
}

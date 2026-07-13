using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace esports.Equipos
{
    public partial class frmDeleteEquipos : Form
    {
        frmEquipos frmEquipos;
        public frmDeleteEquipos(frmEquipos frmEquipos)
        {
            InitializeComponent();
            this.frmEquipos = frmEquipos;
        }

        private void ffrmDeleteEquipos_Load(object sender, EventArgs e)
        {
            cmbEquipo.DataSource = null;
            cmbEquipo.DataSource = Business.EquipoBusiness.getEquipos();
            cmbEquipo.DisplayMember = "nombre";
            cmbEquipo.ValueMember = "id";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idAEliminar = (int)cmbEquipo.SelectedValue;
                EquipoBusiness.deleteEquipoById(idAEliminar);
                frmEquipos.cargarEquipos();
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al eliminar el equipo: " + ex.Message);
            }
           
        }
    }
}

using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;

namespace esports.Equipos
{
    public partial class frmUpdateEquipos : Form
    {
        frmEquipos frmEquiposs = new frmEquipos();


        public frmUpdateEquipos(frmEquipos frmEquipos)
        {
            InitializeComponent();
            this.frmEquiposs = frmEquipos;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEquipos.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un equipo para actualizar.");
                    return;
                }
                int id = (int)cmbEquipos.SelectedValue;
                string nombre = txtNombreEquipo.Text;
                EquipoBusiness.updateEquipo(nombre, id);
            }
            catch (Exception ex)
            {
                return;
            }

            this.Close();
        }

        private void frmUpdateEquipos_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEquipos.Items.Clear();
                cmbEquipos.DataSource = EquipoBusiness.getEquipos();
                cmbEquipos.DisplayMember = "nombre";
                cmbEquipos.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los equipos: " + ex.Message);
            }
        }
    }
}

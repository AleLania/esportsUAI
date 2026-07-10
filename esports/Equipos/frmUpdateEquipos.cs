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
    public partial class frmUpdateEquipos : frmAddEquipos
    {
        frmEquipos frmEquiposs = new frmEquipos();
        public frmUpdateEquipos()
        {
            InitializeComponent();
            cmbEsport.Visible = false;
            label2.Visible = false;
        }

        protected override void btnSave_Click(object sender, EventArgs e)
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
            cmbEquipos.Items.Clear();
            cmbEquipos.DataSource = EquipoBusiness.getEquipos();
            cmbEquipos.DisplayMember = "nombre";
            cmbEquipos.ValueMember = "id";
        }
    }
}

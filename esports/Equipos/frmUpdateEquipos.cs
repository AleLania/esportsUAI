using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace esports.Equipos
{
    public partial class frmUpdateEquipos : frmAddEquipos
    {
        frmEquipos frmEquipos;
        public frmUpdateEquipos()
        {
            InitializeComponent();
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {/*
            int id = (int)cmbEquipos.SelectedValue;
            string nombre = txtNombreEquipo.Text;
            int esport = (int)cmbDisciplina.SelectedValue;*/
                

            //EquiposBusiness.updateEquipo(id, nombre, esport);

            //frmEquipos.updateDgv();

            this.Close();
        }
    }
}

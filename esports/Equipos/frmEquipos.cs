using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Business;

namespace esports
{
    public partial class frmEquipos : Form
    {
        
        EquipoBusiness equiposBusiness = new EquipoBusiness();
        public frmEquipos()
        {
            InitializeComponent();
        }

        private void btnUpdateEquipo_Click(object sender, EventArgs e)
        {

        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            dgvEquipos.DataSource = null;
            dgvEquipos.DataSource = equiposBusiness.getEquipos();
        }

        private void btnAddEquipo_Click(object sender, EventArgs e)
        {

        }
    }
}

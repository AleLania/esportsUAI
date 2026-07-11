using Business;
using esports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            cmbEquipo.Items.Clear();
            cmbEquipo.DataSource = EquipoBusiness.getEquipos();
            cmbEquipo.DisplayMember = "nombre";
            cmbEquipo.ValueMember = "id";

            cmbCompetencia.Items.Clear();
            cmbCompetencia.DataSource = CompetenciasBusiness.getCompetencias();
            cmbCompetencia.DisplayMember = "descripcion";
            cmbCompetencia.ValueMember = "id";

            dgvPartidos.DataSource = PartidoBusiness.getPartidos();

        }

        private void btnCargarPartidoCopa_Click(object sender, EventArgs e)
        {
            frmPartidoCopa ventana = new frmPartidoCopa();
            ventana.ShowDialog();

            CargarGrilla();
        }

        private void btnFiltrarPartidos_Click(object sender, EventArgs e)
        {
            try
            {
                int idEquipo = (int)cmbEquipo.SelectedValue;
                int idCompetencia = (int)cmbCompetencia.SelectedValue;

                dgvPartidos.DataSource = null;
                dgvPartidos.DataSource = PartidoBusiness.getPartidosByEquipoYCompetencia(idEquipo, idCompetencia);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar partidos: " + ex.Message);
            }
        }

        private void btnCargarPartidoTorneo_Click_1(object sender, EventArgs e)
        {
            frmPartidoTorneo ventana = new frmPartidoTorneo();
            ventana.ShowDialog();

            CargarGrilla();
        }
        private void btnBorrarFiltros_Click(object sender, EventArgs e)
        {
            dgvPartidos.DataSource = null;
            dgvPartidos.DataSource = PartidoBusiness.getPartidos();
        }

        private void CargarGrilla()
        {
            PartidoBusiness business = new PartidoBusiness();

            dgvPartidos.DataSource = null;
            dgvPartidos.DataSource = business.ObtenerPartidos();
        }
    }
}

using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace esports.Partidos
{
    public partial class frmPartidoCopa : Form
    {
        public frmPartidoCopa()
        {
            InitializeComponent();
        }

        private void frmPartidoCopa_Load(object sender, EventArgs e)
        {
            try
            {
                cmbDisciplina.DataSource = DisciplinaBusiness.getDisciplinas();
                cmbDisciplina.DisplayMember = "descripcion";
                cmbDisciplina.ValueMember = "id";
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el Form");
            }
        }

        private void cmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDisciplina.SelectedItem == null)
                    return;

                DisciplinasEntity disciplina =
                    (DisciplinasEntity)cmbDisciplina.SelectedItem;

                List<EquiposEntity> equipos =
                    EquipoBusiness.getEquiposByDisciplina(disciplina.id);

                cmbEquipo1.DataSource = equipos;
                cmbEquipo2.DataSource = new List<EquiposEntity>(equipos);

                cmbEquipoGanador.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cambiar la disciplina");
            }

        }

        private void cmbEquipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGanadores();
        }

        private void cmbEquipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGanadores();
        }
        private void CargarGanadores()
        {
            if (cmbEquipo1.SelectedItem == null || cmbEquipo2.SelectedItem == null)
                return;

            List<EquiposEntity> posiblesGanadores =
                new List<EquiposEntity>();

            posiblesGanadores.Add((EquiposEntity)cmbEquipo1.SelectedItem);
            posiblesGanadores.Add((EquiposEntity)cmbEquipo2.SelectedItem);

            cmbEquipoGanador.DataSource = posiblesGanadores;
        }

        private void btnCargarPartidoCopa_Click(object sender, EventArgs e)
        {
            try
            {
                PartidosEntity partido = new PartidosEntity(
                    (EquiposEntity)cmbEquipo1.SelectedItem,
                    (EquiposEntity)cmbEquipo2.SelectedItem,
                    (EquiposEntity)cmbEquipoGanador.SelectedItem,
                    new CompetenciasEntity(2, "Copa"),
                    (DisciplinasEntity)cmbDisciplina.SelectedItem);

                PartidoBusiness business = new PartidoBusiness();

                business.CargarPartido(partido);

                MessageBox.Show("Partido cargado correctamente.");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

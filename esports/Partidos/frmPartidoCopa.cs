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
        frmPartidos frmPartidos;

        public frmPartidoCopa(frmPartidos frmPartidos)
        {
            InitializeComponent();
            this.frmPartidos = frmPartidos;
        }

        private void frmPartidoCopa_Load(object sender, EventArgs e)
        {
            try
            {
                cmbDisciplina.DataSource = DisciplinaBusiness.getDisciplinas();
                cmbDisciplina.DisplayMember = "descripcion";
                cmbDisciplina.ValueMember = "id";

                DisciplinasEntity disciplina = (DisciplinasEntity)cmbDisciplina.SelectedItem;

                List<BracketsEntity> brackets = BracketBusiness.getBracketsConEquipos(disciplina.id);

                cmbBracket.DataSource = brackets;
                cmbBracket.DisplayMember = "instancia";
                cmbBracket.ValueMember = "id";
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

                DisciplinasEntity disciplina = (DisciplinasEntity)cmbDisciplina.SelectedItem;
                List<BracketsEntity> brackets = BracketBusiness.getBracketsConEquipos(disciplina.id);

                cmbBracket.DataSource = null;
                cmbBracket.DataSource = brackets;
                cmbBracket.DisplayMember = "instancia";
                cmbBracket.ValueMember = "id";

                cmbEquipoGanador.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cambiar la disciplina: " + ex.Message);
            }
        }


        private void btnCargarPartidoCopa_Click(object sender, EventArgs e)
        {
            try
            {
                BracketsEntity bracket = (BracketsEntity)cmbBracket.SelectedItem;
                EquiposEntity ganador = (EquiposEntity)cmbEquipoGanador.SelectedItem;
                DisciplinasEntity disciplina = (DisciplinasEntity)cmbDisciplina.SelectedItem;

                PartidosEntity partido = new PartidosEntity(
                    bracket.equipo1,
                    bracket.equipo2,
                    ganador,
                    new CompetenciasEntity(2, "Copa"),
                    disciplina
                );

                PartidoBusiness business = new PartidoBusiness();
                business.CargarPartido(partido);

                MessageBox.Show("Partido cargado correctamente.");
                frmPartidos.actualizarDgv();
                Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar partido de copa " + ex.Message);
            }
        }

        private void cmbBracket_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                if (cmbBracket.SelectedItem == null) return;

                BracketsEntity bracket = (BracketsEntity)cmbBracket.SelectedItem;

                List<EquiposEntity> posiblesGanadores = new List<EquiposEntity>();
                if (bracket.equipo1 != null) posiblesGanadores.Add(bracket.equipo1);
                if (bracket.equipo2 != null) posiblesGanadores.Add(bracket.equipo2);

                cmbEquipoGanador.DataSource = posiblesGanadores;
                cmbEquipoGanador.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar equipos: " + ex.Message);
            }
        }
    }
}

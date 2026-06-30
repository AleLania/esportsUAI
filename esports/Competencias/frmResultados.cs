using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace esports.Competencias
{
    public partial class frmResultados : Form
    {
        public void getDiscplinas()
        {
            cmbEsport.Items.Clear();
            cmbEsport.DataSource = DisciplinaBusiness.getDisciplinas();
            cmbEsport.DisplayMember = "descripcion";
            cmbEsport.ValueMember = "id";
        }

        public void getCómpetencias()
        {
            cmbCompetencia.Items.Clear();
            cmbCompetencia.DataSource = CompetenciasBusiness.getCompetencias();
            cmbCompetencia.DisplayMember = "descripcion";
            cmbCompetencia.ValueMember = "id";
        }


        public frmResultados()
        {
            InitializeComponent();

        }
        private void frmResultados_Load(object sender, EventArgs e)
        {
            getDiscplinas();
            getCómpetencias();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int idDisciplina = (int)cmbEsport.SelectedValue;
            int idCompetencia = (int)cmbCompetencia.SelectedValue;

            dgvResultados.DataSource = null;
            dgvResultados.DataSource = ResultadosBusiness.getResultados(idDisciplina, idCompetencia);
        }
    }
}

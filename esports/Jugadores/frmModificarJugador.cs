using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace esports.Jugadores
{
    public partial class frmModificarJugador : Form
    {
        public frmModificarJugador()
        {
            InitializeComponent();
        }

        private void frmModificarJugador_Load(object sender, EventArgs e)
        {
            JugadorBusiness jugadorBusiness = new JugadorBusiness();

            cmbJugador.DataSource = jugadorBusiness.getJugadores();

            cmbJugador.DisplayMember = "NombreApellido";
            cmbJugador.ValueMember = "IdJugador";

            EquipoBusiness equipoBusiness = new EquipoBusiness();

            cmbEquipos.DataSource = EquipoBusiness.getEquipos();
            cmbEquipos.DisplayMember = "nombre";
            cmbEquipos.ValueMember = "id";
        }

        private void cmbJugador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJugador.SelectedValue == null)
                return;

            if (cmbJugador.SelectedValue is not int)
                return;

            int idJugador = (int)cmbJugador.SelectedValue;

            JugadorBusiness jugadorBusiness = new JugadorBusiness();

            JugadoresEntity? jugador =
                jugadorBusiness.obtenerJugadorPorId(idJugador);

            if (jugador != null)
            {
                txtNuevoNombre.Text = jugador.NombreApellido;
                txtNick.Text = jugador.Nick;
                cmbEquipos.SelectedValue = jugador.equipo.id;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                JugadoresEntity jugador = new JugadoresEntity(
                    Convert.ToInt32(cmbJugador.SelectedValue),
                    txtNuevoNombre.Text,
                    txtNick.Text,
                    Convert.ToInt32(cmbEquipos.SelectedValue)
                    );

                JugadorBusiness jugadorBusiness = new JugadorBusiness();

                jugadorBusiness.actualizarJugador(jugador);

                MessageBox.Show("Jugador modificado correctamente");

                txtNuevoNombre.Clear();
                txtNick.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

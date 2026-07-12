using Business;
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
    public partial class frmAddEquipos : Form
    {
        frmEquipos frmEquipos;

        public frmAddEquipos(frmEquipos frmEquipos)
        {
            InitializeComponent();
            this.frmEquipos = frmEquipos;

        }

        private void InitializeComponent()
        {
            btnSave = new Button();
            txtNombreEquipo = new TextBox();
            cmbEsport = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lblAltaEquipo = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(78, 186);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 32);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(100, 74);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(174, 23);
            txtNombreEquipo.TabIndex = 1;
            // 
            // cmbEsport
            // 
            cmbEsport.FormattingEnabled = true;
            cmbEsport.Location = new Point(164, 125);
            cmbEsport.Name = "cmbEsport";
            cmbEsport.Size = new Size(110, 23);
            cmbEsport.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 77);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 128);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Esport";
            // 
            // lblAltaEquipo
            // 
            lblAltaEquipo.AutoSize = true;
            lblAltaEquipo.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltaEquipo.Location = new Point(88, 12);
            lblAltaEquipo.Name = "lblAltaEquipo";
            lblAltaEquipo.Size = new Size(104, 18);
            lblAltaEquipo.TabIndex = 22;
            lblAltaEquipo.Text = "Alta de Equipo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAltaEquipo);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 245);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // frmAddEquipos
            // 
            ClientSize = new Size(306, 262);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbEsport);
            Controls.Add(txtNombreEquipo);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "frmAddEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAddEquipos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        protected Button btnSave;
        protected TextBox txtNombreEquipo;
        protected ComboBox cmbEsport;
        protected Label label1;
        protected Label label2;

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreEquipo.Text;
                int idDisciplina = (int)cmbEsport.SelectedValue;

                EquipoBusiness.insertEquipo(nombre, idDisciplina);
                frmEquipos.cargarEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void frmAddEquipos_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEsport.Items.Clear();
                cmbEsport.DataSource = DisciplinaBusiness.getDisciplinas();
                cmbEsport.DisplayMember = "descripcion";
                cmbEsport.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las disciplinas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Label lblAltaEquipo;
        private GroupBox groupBox1;
    }
}

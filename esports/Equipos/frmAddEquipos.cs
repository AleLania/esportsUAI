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
        public frmAddEquipos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btnSave = new Button();
            txtNombreEquipo = new TextBox();
            cmbEsport = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(99, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(218, 73);
            btnSave.TabIndex = 0;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(114, 138);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(174, 27);
            txtNombreEquipo.TabIndex = 1;
            // 
            // cmbEsport
            // 
            cmbEsport.FormattingEnabled = true;
            cmbEsport.Location = new Point(114, 238);
            cmbEsport.Name = "cmbEsport";
            cmbEsport.Size = new Size(182, 28);
            cmbEsport.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 91);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 196);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "Esport";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 5;
            label3.Text = "Alta de Equipo";
            // 
            // frmAddEquipos
            // 
            ClientSize = new Size(487, 508);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbEsport);
            Controls.Add(txtNombreEquipo);
            Controls.Add(btnSave);
            Name = "frmAddEquipos";
            ResumeLayout(false);
            PerformLayout();

        }

        protected Button btnSave;
        protected TextBox txtNombreEquipo;
        protected ComboBox cmbEsport;
        protected Label label1;
        protected Label label2;
        protected Label label3;

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               string nombre = txtNombreEquipo.Text;
                int idDisciplina = (int)cmbEsport.SelectedValue;

                EquipoBusiness.insertEquipo(nombre,idDisciplina);
            }
            catch (Exception ex) 
            { 
            MessageBox.Show("Error al guardar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           frmEquipos.cargarEquipos();

            this.Close();
        }
    }
}

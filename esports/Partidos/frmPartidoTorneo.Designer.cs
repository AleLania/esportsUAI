namespace esports.Partidos
{
    partial class frmPartidoTorneo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbEquipoGanador = new ComboBox();
            cmbEquipo2 = new ComboBox();
            cmbEquipo1 = new ComboBox();
            lblGanador = new Label();
            lblEquipo2 = new Label();
            lblEquipo1 = new Label();
            btnCargarPartidoTorneo = new Button();
            lblPartidoTorneo = new Label();
            cmbDisciplina = new ComboBox();
            lblDisciplina = new Label();
            SuspendLayout();
            // 
            // cmbEquipoGanador
            // 
            cmbEquipoGanador.FormattingEnabled = true;
            cmbEquipoGanador.Location = new Point(161, 183);
            cmbEquipoGanador.Name = "cmbEquipoGanador";
            cmbEquipoGanador.Size = new Size(121, 23);
            cmbEquipoGanador.TabIndex = 19;
            // 
            // cmbEquipo2
            // 
            cmbEquipo2.FormattingEnabled = true;
            cmbEquipo2.Location = new Point(161, 137);
            cmbEquipo2.Name = "cmbEquipo2";
            cmbEquipo2.Size = new Size(121, 23);
            cmbEquipo2.TabIndex = 18;
            // 
            // cmbEquipo1
            // 
            cmbEquipo1.FormattingEnabled = true;
            cmbEquipo1.Location = new Point(161, 90);
            cmbEquipo1.Name = "cmbEquipo1";
            cmbEquipo1.Size = new Size(121, 23);
            cmbEquipo1.TabIndex = 17;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Location = new Point(33, 186);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(52, 15);
            lblGanador.TabIndex = 15;
            lblGanador.Text = "Ganador";
            // 
            // lblEquipo2
            // 
            lblEquipo2.AutoSize = true;
            lblEquipo2.Location = new Point(32, 140);
            lblEquipo2.Name = "lblEquipo2";
            lblEquipo2.Size = new Size(53, 15);
            lblEquipo2.TabIndex = 14;
            lblEquipo2.Text = "Equipo 2";
            // 
            // lblEquipo1
            // 
            lblEquipo1.AutoSize = true;
            lblEquipo1.Location = new Point(32, 93);
            lblEquipo1.Name = "lblEquipo1";
            lblEquipo1.Size = new Size(53, 15);
            lblEquipo1.TabIndex = 13;
            lblEquipo1.Text = "Equipo 1";
            // 
            // btnCargarPartidoTorneo
            // 
            btnCargarPartidoTorneo.Location = new Point(32, 239);
            btnCargarPartidoTorneo.Name = "btnCargarPartidoTorneo";
            btnCargarPartidoTorneo.Size = new Size(139, 23);
            btnCargarPartidoTorneo.TabIndex = 12;
            btnCargarPartidoTorneo.Text = "Cargar Partido Torneo";
            btnCargarPartidoTorneo.UseVisualStyleBackColor = true;
            // 
            // lblPartidoTorneo
            // 
            lblPartidoTorneo.AutoSize = true;
            lblPartidoTorneo.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartidoTorneo.Location = new Point(22, 20);
            lblPartidoTorneo.Name = "lblPartidoTorneo";
            lblPartidoTorneo.Size = new Size(173, 18);
            lblPartidoTorneo.TabIndex = 11;
            lblPartidoTorneo.Text = "Cargar Partido de Torneo";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(162, 53);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(121, 23);
            cmbDisciplina.TabIndex = 21;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(33, 56);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(58, 15);
            lblDisciplina.TabIndex = 20;
            lblDisciplina.Text = "Disciplina";
            // 
            // frmPartidoTorneo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 320);
            Controls.Add(cmbDisciplina);
            Controls.Add(lblDisciplina);
            Controls.Add(cmbEquipoGanador);
            Controls.Add(cmbEquipo2);
            Controls.Add(cmbEquipo1);
            Controls.Add(lblGanador);
            Controls.Add(lblEquipo2);
            Controls.Add(lblEquipo1);
            Controls.Add(btnCargarPartidoTorneo);
            Controls.Add(lblPartidoTorneo);
            Name = "frmPartidoTorneo";
            Text = "frmPartidoTorneo";
            Load += frmPartidoTorneo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEquipoGanador;
        private ComboBox cmbEquipo2;
        private ComboBox cmbEquipo1;
        private Label lblGanador;
        private Label lblEquipo2;
        private Label lblEquipo1;
        private Button btnCargarPartidoTorneo;
        private Label lblPartidoTorneo;
        private ComboBox cmbDisciplina;
        private Label lblDisciplina;
    }
}
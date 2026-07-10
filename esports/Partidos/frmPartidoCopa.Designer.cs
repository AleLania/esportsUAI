namespace esports.Partidos
{
    partial class frmPartidoCopa
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
            SuspendLayout();
            // 
            // cmbEquipoGanador
            // 
            cmbEquipoGanador.FormattingEnabled = true;
            cmbEquipoGanador.Location = new Point(163, 196);
            cmbEquipoGanador.Name = "cmbEquipoGanador";
            cmbEquipoGanador.Size = new Size(121, 23);
            cmbEquipoGanador.TabIndex = 27;
            // 
            // cmbEquipo2
            // 
            cmbEquipo2.FormattingEnabled = true;
            cmbEquipo2.Location = new Point(163, 150);
            cmbEquipo2.Name = "cmbEquipo2";
            cmbEquipo2.Size = new Size(121, 23);
            cmbEquipo2.TabIndex = 26;
            // 
            // cmbEquipo1
            // 
            cmbEquipo1.FormattingEnabled = true;
            cmbEquipo1.Location = new Point(163, 103);
            cmbEquipo1.Name = "cmbEquipo1";
            cmbEquipo1.Size = new Size(121, 23);
            cmbEquipo1.TabIndex = 25;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Location = new Point(35, 199);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(52, 15);
            lblGanador.TabIndex = 24;
            lblGanador.Text = "Ganador";
            // 
            // lblEquipo2
            // 
            lblEquipo2.AutoSize = true;
            lblEquipo2.Location = new Point(34, 153);
            lblEquipo2.Name = "lblEquipo2";
            lblEquipo2.Size = new Size(53, 15);
            lblEquipo2.TabIndex = 23;
            lblEquipo2.Text = "Equipo 2";
            // 
            // lblEquipo1
            // 
            lblEquipo1.AutoSize = true;
            lblEquipo1.Location = new Point(34, 106);
            lblEquipo1.Name = "lblEquipo1";
            lblEquipo1.Size = new Size(53, 15);
            lblEquipo1.TabIndex = 22;
            lblEquipo1.Text = "Equipo 1";
            // 
            // btnCargarPartidoTorneo
            // 
            btnCargarPartidoTorneo.Location = new Point(34, 252);
            btnCargarPartidoTorneo.Name = "btnCargarPartidoTorneo";
            btnCargarPartidoTorneo.Size = new Size(139, 23);
            btnCargarPartidoTorneo.TabIndex = 21;
            btnCargarPartidoTorneo.Text = "Cargar Partido Copa";
            btnCargarPartidoTorneo.UseVisualStyleBackColor = true;
            // 
            // lblPartidoTorneo
            // 
            lblPartidoTorneo.AutoSize = true;
            lblPartidoTorneo.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartidoTorneo.Location = new Point(24, 38);
            lblPartidoTorneo.Name = "lblPartidoTorneo";
            lblPartidoTorneo.Size = new Size(162, 18);
            lblPartidoTorneo.TabIndex = 20;
            lblPartidoTorneo.Text = "Cargar Partido de Copa";
            // 
            // frmPartidoCopa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 322);
            Controls.Add(cmbEquipoGanador);
            Controls.Add(cmbEquipo2);
            Controls.Add(cmbEquipo1);
            Controls.Add(lblGanador);
            Controls.Add(lblEquipo2);
            Controls.Add(lblEquipo1);
            Controls.Add(btnCargarPartidoTorneo);
            Controls.Add(lblPartidoTorneo);
            Name = "frmPartidoCopa";
            Text = "frmPartidoCopa";
            Load += frmPartidoCopa_Load;
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
    }
}
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
            cmbBracket = new ComboBox();
            lblGanador = new Label();
            lblEquipo1 = new Label();
            btnCargarPartidoCopa = new Button();
            lblPartidoTorneo = new Label();
            cmbDisciplina = new ComboBox();
            lblDisciplina = new Label();
            SuspendLayout();
            // 
            // cmbEquipoGanador
            // 
            cmbEquipoGanador.FormattingEnabled = true;
            cmbEquipoGanador.Location = new Point(233, 327);
            cmbEquipoGanador.Margin = new Padding(4, 5, 4, 5);
            cmbEquipoGanador.Name = "cmbEquipoGanador";
            cmbEquipoGanador.Size = new Size(171, 33);
            cmbEquipoGanador.TabIndex = 27;
            // 
            // cmbBracket
            // 
            cmbBracket.FormattingEnabled = true;
            cmbBracket.Location = new Point(233, 172);
            cmbBracket.Margin = new Padding(4, 5, 4, 5);
            cmbBracket.Name = "cmbBracket";
            cmbBracket.Size = new Size(171, 33);
            cmbBracket.TabIndex = 25;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Location = new Point(50, 332);
            lblGanador.Margin = new Padding(4, 0, 4, 0);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(80, 25);
            lblGanador.TabIndex = 24;
            lblGanador.Text = "Ganador";
            // 
            // lblEquipo1
            // 
            lblEquipo1.AutoSize = true;
            lblEquipo1.Location = new Point(49, 177);
            lblEquipo1.Margin = new Padding(4, 0, 4, 0);
            lblEquipo1.Name = "lblEquipo1";
            lblEquipo1.Size = new Size(69, 25);
            lblEquipo1.TabIndex = 22;
            lblEquipo1.Text = "Bracket";
            // 
            // btnCargarPartidoCopa
            // 
            btnCargarPartidoCopa.Location = new Point(49, 420);
            btnCargarPartidoCopa.Margin = new Padding(4, 5, 4, 5);
            btnCargarPartidoCopa.Name = "btnCargarPartidoCopa";
            btnCargarPartidoCopa.Size = new Size(199, 38);
            btnCargarPartidoCopa.TabIndex = 21;
            btnCargarPartidoCopa.Text = "Cargar Partido Copa";
            btnCargarPartidoCopa.UseVisualStyleBackColor = true;
            btnCargarPartidoCopa.Click += btnCargarPartidoCopa_Click;
            // 
            // lblPartidoTorneo
            // 
            lblPartidoTorneo.AutoSize = true;
            lblPartidoTorneo.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartidoTorneo.Location = new Point(34, 55);
            lblPartidoTorneo.Margin = new Padding(4, 0, 4, 0);
            lblPartidoTorneo.Name = "lblPartidoTorneo";
            lblPartidoTorneo.Size = new Size(250, 28);
            lblPartidoTorneo.TabIndex = 20;
            lblPartidoTorneo.Text = "Cargar Partido de Copa";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(234, 105);
            cmbDisciplina.Margin = new Padding(4, 5, 4, 5);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(171, 33);
            cmbDisciplina.TabIndex = 29;
            cmbDisciplina.SelectedIndexChanged += cmbDisciplina_SelectedIndexChanged;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(50, 110);
            lblDisciplina.Margin = new Padding(4, 0, 4, 0);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(87, 25);
            lblDisciplina.TabIndex = 28;
            lblDisciplina.Text = "Disciplina";
            // 
            // frmPartidoCopa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 537);
            Controls.Add(cmbDisciplina);
            Controls.Add(lblDisciplina);
            Controls.Add(cmbEquipoGanador);
            Controls.Add(cmbBracket);
            Controls.Add(lblGanador);
            Controls.Add(lblEquipo1);
            Controls.Add(btnCargarPartidoCopa);
            Controls.Add(lblPartidoTorneo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPartidoCopa";
            Text = "frmPartidoCopa";
            Load += frmPartidoCopa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEquipoGanador;
        private ComboBox cmbBracket;
        private Label lblGanador;
        private Label lblEquipo1;
        private Button btnCargarPartidoCopa;
        private Label lblPartidoTorneo;
        private ComboBox cmbDisciplina;
        private Label lblDisciplina;
    }
}
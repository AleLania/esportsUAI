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
            lblPartidoCopa = new Label();
            cmbDisciplina = new ComboBox();
            lblDisciplina = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbEquipoGanador
            // 
            cmbEquipoGanador.FormattingEnabled = true;
            cmbEquipoGanador.Location = new Point(90, 142);
            cmbEquipoGanador.Name = "cmbEquipoGanador";
            cmbEquipoGanador.Size = new Size(121, 23);
            cmbEquipoGanador.TabIndex = 27;
            // 
            // cmbBracket
            // 
            cmbBracket.FormattingEnabled = true;
            cmbBracket.Location = new Point(90, 91);
            cmbBracket.Name = "cmbBracket";
            cmbBracket.Size = new Size(121, 23);
            cmbBracket.TabIndex = 25;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Location = new Point(14, 158);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(52, 15);
            lblGanador.TabIndex = 24;
            lblGanador.Text = "Ganador";
            // 
            // lblEquipo1
            // 
            lblEquipo1.AutoSize = true;
            lblEquipo1.Location = new Point(14, 106);
            lblEquipo1.Name = "lblEquipo1";
            lblEquipo1.Size = new Size(46, 15);
            lblEquipo1.TabIndex = 22;
            lblEquipo1.Text = "Bracket";
            // 
            // btnCargarPartidoCopa
            // 
            btnCargarPartidoCopa.Location = new Point(48, 185);
            btnCargarPartidoCopa.Name = "btnCargarPartidoCopa";
            btnCargarPartidoCopa.Size = new Size(132, 32);
            btnCargarPartidoCopa.TabIndex = 21;
            btnCargarPartidoCopa.Text = "Cargar Partido Copa";
            btnCargarPartidoCopa.UseVisualStyleBackColor = true;
            btnCargarPartidoCopa.Click += btnCargarPartidoCopa_Click;
            // 
            // lblPartidoCopa
            // 
            lblPartidoCopa.AutoSize = true;
            lblPartidoCopa.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartidoCopa.Location = new Point(39, 27);
            lblPartidoCopa.Name = "lblPartidoCopa";
            lblPartidoCopa.Size = new Size(162, 18);
            lblPartidoCopa.TabIndex = 20;
            lblPartidoCopa.Text = "Cargar Partido de Copa";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(102, 64);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(121, 23);
            cmbDisciplina.TabIndex = 29;
            cmbDisciplina.SelectedIndexChanged += cmbDisciplina_SelectedIndexChanged;
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(14, 66);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(58, 15);
            lblDisciplina.TabIndex = 28;
            lblDisciplina.Text = "Disciplina";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbBracket);
            groupBox1.Controls.Add(cmbEquipoGanador);
            groupBox1.Controls.Add(btnCargarPartidoCopa);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 237);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            // 
            // frmPartidoCopa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 271);
            Controls.Add(cmbDisciplina);
            Controls.Add(lblDisciplina);
            Controls.Add(lblGanador);
            Controls.Add(lblEquipo1);
            Controls.Add(lblPartidoCopa);
            Controls.Add(groupBox1);
            Name = "frmPartidoCopa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargar Partido de Copa";
            Load += frmPartidoCopa_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEquipoGanador;
        private ComboBox cmbBracket;
        private Label lblGanador;
        private Label lblEquipo1;
        private Button btnCargarPartidoCopa;
        private Label lblPartidoCopa;
        private ComboBox cmbDisciplina;
        private Label lblDisciplina;
        private GroupBox groupBox1;
    }
}
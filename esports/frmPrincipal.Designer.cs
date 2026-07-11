namespace esports
{
    partial class frmPrincipal
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
            label1 = new Label();
            btnJugadores = new Button();
            btnEquipos = new Button();
            btnPartidos = new Button();
            btnCompetencias = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(225, 30);
            label1.TabIndex = 0;
            label1.Text = "Gestión de eSports";
            // 
            // btnJugadores
            // 
            btnJugadores.Font = new Font("Bahnschrift", 11F);
            btnJugadores.Location = new Point(26, 94);
            btnJugadores.Margin = new Padding(3, 4, 3, 4);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(130, 50);
            btnJugadores.TabIndex = 1;
            btnJugadores.Text = "Jugadores";
            btnJugadores.UseVisualStyleBackColor = true;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.Font = new Font("Bahnschrift", 11F);
            btnEquipos.Location = new Point(26, 152);
            btnEquipos.Margin = new Padding(3, 4, 3, 4);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(130, 50);
            btnEquipos.TabIndex = 2;
            btnEquipos.Text = "Equipos";
            btnEquipos.UseVisualStyleBackColor = true;
            btnEquipos.Click += btnEquipos_Click;
            // 
            // btnPartidos
            // 
            btnPartidos.Font = new Font("Bahnschrift", 11F);
            btnPartidos.Location = new Point(26, 210);
            btnPartidos.Margin = new Padding(3, 4, 3, 4);
            btnPartidos.Name = "btnPartidos";
            btnPartidos.Size = new Size(130, 50);
            btnPartidos.TabIndex = 3;
            btnPartidos.Text = "Partidos";
            btnPartidos.UseVisualStyleBackColor = true;
            btnPartidos.Click += btnPartidos_Click;
            // 
            // btnCompetencias
            // 
            btnCompetencias.Font = new Font("Bahnschrift", 11F);
            btnCompetencias.Location = new Point(26, 266);
            btnCompetencias.Margin = new Padding(3, 4, 3, 4);
            btnCompetencias.Name = "btnCompetencias";
            btnCompetencias.Size = new Size(130, 70);
            btnCompetencias.TabIndex = 4;
            btnCompetencias.Text = "Competencias";
            btnCompetencias.UseVisualStyleBackColor = true;
            btnCompetencias.Click += btnCompetencias_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCompetencias);
            Controls.Add(btnPartidos);
            Controls.Add(btnEquipos);
            Controls.Add(btnJugadores);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnJugadores;
        private Button btnEquipos;
        private Button btnPartidos;
        private Button btnCompetencias;
    }
}
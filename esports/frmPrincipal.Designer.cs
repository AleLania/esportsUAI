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
            btnTabla = new Button();
            btnBracket = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(181, 24);
            label1.TabIndex = 0;
            label1.Text = "Gestión de eSports";
            // 
            // btnJugadores
            // 
            btnJugadores.Font = new Font("Bahnschrift", 11F);
            btnJugadores.Location = new Point(23, 71);
            btnJugadores.Name = "btnJugadores";
            btnJugadores.Size = new Size(114, 37);
            btnJugadores.TabIndex = 1;
            btnJugadores.Text = "Jugadores";
            btnJugadores.UseVisualStyleBackColor = true;
            btnJugadores.Click += btnJugadores_Click;
            // 
            // btnEquipos
            // 
            btnEquipos.Font = new Font("Bahnschrift", 11F);
            btnEquipos.Location = new Point(23, 114);
            btnEquipos.Name = "btnEquipos";
            btnEquipos.Size = new Size(114, 37);
            btnEquipos.TabIndex = 2;
            btnEquipos.Text = "Equipos";
            btnEquipos.UseVisualStyleBackColor = true;
            btnEquipos.Click += btnEquipos_Click;
            // 
            // btnPartidos
            // 
            btnPartidos.Font = new Font("Bahnschrift", 11F);
            btnPartidos.Location = new Point(23, 157);
            btnPartidos.Name = "btnPartidos";
            btnPartidos.Size = new Size(114, 37);
            btnPartidos.TabIndex = 3;
            btnPartidos.Text = "Partidos";
            btnPartidos.UseVisualStyleBackColor = true;
            btnPartidos.Click += btnPartidos_Click;
            // 
            // btnTabla
            // 
            btnTabla.Font = new Font("Bahnschrift", 11F);
            btnTabla.Location = new Point(23, 200);
            btnTabla.Name = "btnTabla";
            btnTabla.Size = new Size(114, 52);
            btnTabla.TabIndex = 4;
            btnTabla.Text = "Tabla posiciones";
            btnTabla.UseVisualStyleBackColor = true;
            btnTabla.Click += btnTabla_Click;
            // 
            // btnBracket
            // 
            btnBracket.Font = new Font("Bahnschrift", 11F);
            btnBracket.Location = new Point(23, 258);
            btnBracket.Name = "btnBracket";
            btnBracket.Size = new Size(114, 52);
            btnBracket.TabIndex = 5;
            btnBracket.Text = "Bracket Copa";
            btnBracket.UseVisualStyleBackColor = true;
            btnBracket.Click += btnBracket_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBracket);
            Controls.Add(btnTabla);
            Controls.Add(btnPartidos);
            Controls.Add(btnEquipos);
            Controls.Add(btnJugadores);
            Controls.Add(label1);
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
        private Button btnTabla;
        private Button btnBracket;
    }
}
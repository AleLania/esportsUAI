namespace esports
{
    partial class frmJugadores
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
            lblJugadores = new Label();
            btnAgregarJugador = new Button();
            btnModificarJugador = new Button();
            dgvJugadores = new DataGridView();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // lblJugadores
            // 
            lblJugadores.AutoSize = true;
            lblJugadores.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJugadores.Location = new Point(22, 29);
            lblJugadores.Name = "lblJugadores";
            lblJugadores.Size = new Size(114, 18);
            lblJugadores.TabIndex = 0;
            lblJugadores.Text = "ABM Jugadores";
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.Location = new Point(40, 279);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(75, 23);
            btnAgregarJugador.TabIndex = 1;
            btnAgregarJugador.Text = "Agregar";
            btnAgregarJugador.UseVisualStyleBackColor = true;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // btnModificarJugador
            // 
            btnModificarJugador.Location = new Point(147, 279);
            btnModificarJugador.Name = "btnModificarJugador";
            btnModificarJugador.Size = new Size(75, 23);
            btnModificarJugador.TabIndex = 2;
            btnModificarJugador.Text = "Modificar";
            btnModificarJugador.UseVisualStyleBackColor = true;
            btnModificarJugador.Click += btnModificarJugador_Click;
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(300, 7);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.Size = new Size(392, 323);
            dgvJugadores.TabIndex = 3;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(40, 350);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 337);
            Controls.Add(btnVolver);
            Controls.Add(dgvJugadores);
            Controls.Add(btnModificarJugador);
            Controls.Add(btnAgregarJugador);
            Controls.Add(lblJugadores);
            Name = "frmJugadores";
            Text = "frmJugadores";
            Load += frmJugadores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJugadores;
        private Button btnAgregarJugador;
        private Button btnModificarJugador;
        private DataGridView dgvJugadores;
        private Button btnVolver;
    }
}
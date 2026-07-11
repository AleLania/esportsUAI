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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // lblJugadores
            // 
            lblJugadores.AutoSize = true;
            lblJugadores.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJugadores.Location = new Point(25, 39);
            lblJugadores.Name = "lblJugadores";
            lblJugadores.Size = new Size(143, 23);
            lblJugadores.TabIndex = 0;
            lblJugadores.Text = "ABM Jugadores";
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.Location = new Point(43, 320);
            btnAgregarJugador.Margin = new Padding(3, 4, 3, 4);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(86, 31);
            btnAgregarJugador.TabIndex = 1;
            btnAgregarJugador.Text = "Agregar";
            btnAgregarJugador.UseVisualStyleBackColor = true;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // btnModificarJugador
            // 
            btnModificarJugador.Location = new Point(165, 320);
            btnModificarJugador.Margin = new Padding(3, 4, 3, 4);
            btnModificarJugador.Name = "btnModificarJugador";
            btnModificarJugador.Size = new Size(86, 31);
            btnModificarJugador.TabIndex = 2;
            btnModificarJugador.Text = "Modificar";
            btnModificarJugador.UseVisualStyleBackColor = true;
            btnModificarJugador.Click += btnModificarJugador_Click;
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(343, 9);
            dgvJugadores.Margin = new Padding(3, 4, 3, 4);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.RowHeadersWidth = 51;
            dgvJugadores.Size = new Size(448, 431);
            dgvJugadores.TabIndex = 3;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(46, 467);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // button1
            // 
            button1.Location = new Point(43, 405);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 5;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmJugadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(button1);
            Controls.Add(btnVolver);
            Controls.Add(dgvJugadores);
            Controls.Add(btnModificarJugador);
            Controls.Add(btnAgregarJugador);
            Controls.Add(lblJugadores);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button1;
    }
}
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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            SuspendLayout();
            // 
            // lblJugadores
            // 
            lblJugadores.AutoSize = true;
            lblJugadores.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJugadores.Location = new Point(19, 19);
            lblJugadores.Name = "lblJugadores";
            lblJugadores.Size = new Size(114, 18);
            lblJugadores.TabIndex = 0;
            lblJugadores.Text = "ABM Jugadores";
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.Location = new Point(16, 61);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(116, 32);
            btnAgregarJugador.TabIndex = 1;
            btnAgregarJugador.Text = "Agregar Jugador";
            btnAgregarJugador.UseVisualStyleBackColor = true;
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // btnModificarJugador
            // 
            btnModificarJugador.Location = new Point(16, 111);
            btnModificarJugador.Name = "btnModificarJugador";
            btnModificarJugador.Size = new Size(116, 32);
            btnModificarJugador.TabIndex = 2;
            btnModificarJugador.Text = "Modificar Jugador";
            btnModificarJugador.UseVisualStyleBackColor = true;
            btnModificarJugador.Click += btnModificarJugador_Click;
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(150, 7);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.RowHeadersWidth = 51;
            dgvJugadores.Size = new Size(406, 330);
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
            // button1
            // 
            button1.Location = new Point(14, 290);
            button1.Name = "button1";
            button1.Size = new Size(116, 32);
            button1.TabIndex = 5;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(11, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 167);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // frmJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 337);
            Controls.Add(button1);
            Controls.Add(btnVolver);
            Controls.Add(dgvJugadores);
            Controls.Add(btnModificarJugador);
            Controls.Add(btnAgregarJugador);
            Controls.Add(lblJugadores);
            Controls.Add(groupBox1);
            Name = "frmJugadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Jugadores";
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
        private GroupBox groupBox1;
    }
}
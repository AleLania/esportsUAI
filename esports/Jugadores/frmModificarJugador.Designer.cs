namespace esports.Jugadores
{
    partial class frmModificarJugador
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
            cmbJugador = new ComboBox();
            cmbEquipos = new ComboBox();
            lblNombreJugador = new Label();
            label1 = new Label();
            txtNuevoNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNick = new TextBox();
            btnGuardar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // cmbJugador
            // 
            cmbJugador.FormattingEnabled = true;
            cmbJugador.Location = new Point(30, 79);
            cmbJugador.Name = "cmbJugador";
            cmbJugador.Size = new Size(133, 23);
            cmbJugador.TabIndex = 0;
            cmbJugador.SelectedIndexChanged += cmbJugador_SelectedIndexChanged;
            // 
            // cmbEquipos
            // 
            cmbEquipos.FormattingEnabled = true;
            cmbEquipos.Location = new Point(30, 195);
            cmbEquipos.Name = "cmbEquipos";
            cmbEquipos.Size = new Size(133, 23);
            cmbEquipos.TabIndex = 1;
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Location = new Point(30, 49);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(119, 15);
            lblNombreJugador.TabIndex = 2;
            lblNombreJugador.Text = "Seleccione el jugador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 165);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione el equipo";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(233, 79);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(100, 23);
            txtNuevoNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 49);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 5;
            label2.Text = "Nuevo Nombre y Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 131);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Nuevo Nick";
            // 
            // txtNick
            // 
            txtNick.Location = new Point(233, 165);
            txtNick.Name = "txtNick";
            txtNick.Size = new Size(100, 23);
            txtNick.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(56, 265);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(56, 336);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmModificarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(txtNick);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNuevoNombre);
            Controls.Add(label1);
            Controls.Add(lblNombreJugador);
            Controls.Add(cmbEquipos);
            Controls.Add(cmbJugador);
            Name = "frmModificarJugador";
            Text = "frmModificarJugador";
            Load += frmModificarJugador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbJugador;
        private ComboBox cmbEquipos;
        private Label lblNombreJugador;
        private Label label1;
        private TextBox txtNuevoNombre;
        private Label label2;
        private Label label3;
        private TextBox txtNick;
        private Button btnGuardar;
        private Button btnVolver;
    }
}
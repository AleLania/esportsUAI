namespace esports.Jugadores
{
    partial class frmCargarJugador
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
            lblNombre = new Label();
            lblNick = new Label();
            lblEquipo = new Label();
            txtNombreApellido = new TextBox();
            txtNick = new TextBox();
            cmbEquipos = new ComboBox();
            btnGuardar = new Button();
            btnVolver = new Button();
            lblAltaJugador = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(22, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre y Apellido";
            // 
            // lblNick
            // 
            lblNick.AutoSize = true;
            lblNick.Location = new Point(22, 107);
            lblNick.Name = "lblNick";
            lblNick.Size = new Size(31, 15);
            lblNick.TabIndex = 2;
            lblNick.Text = "Nick";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(22, 150);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(44, 15);
            lblEquipo.TabIndex = 3;
            lblEquipo.Text = "Equipo";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(154, 62);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(122, 23);
            txtNombreApellido.TabIndex = 4;
            // 
            // txtNick
            // 
            txtNick.Location = new Point(154, 103);
            txtNick.Name = "txtNick";
            txtNick.Size = new Size(122, 23);
            txtNick.TabIndex = 5;
            // 
            // cmbEquipos
            // 
            cmbEquipos.FormattingEnabled = true;
            cmbEquipos.Location = new Point(154, 147);
            cmbEquipos.Name = "cmbEquipos";
            cmbEquipos.Size = new Size(122, 23);
            cmbEquipos.TabIndex = 6;
            cmbEquipos.SelectedIndexChanged += cmbEquipos_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(67, 195);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 32);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(35, 274);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(92, 28);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblAltaJugador
            // 
            lblAltaJugador.AutoSize = true;
            lblAltaJugador.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltaJugador.Location = new Point(70, 15);
            lblAltaJugador.Name = "lblAltaJugador";
            lblAltaJugador.Size = new Size(113, 18);
            lblAltaJugador.TabIndex = 21;
            lblAltaJugador.Text = "Alta de Jugador";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAltaJugador);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 247);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // frmCargarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 271);
            Controls.Add(btnVolver);
            Controls.Add(cmbEquipos);
            Controls.Add(txtNick);
            Controls.Add(txtNombreApellido);
            Controls.Add(lblEquipo);
            Controls.Add(lblNick);
            Controls.Add(lblNombre);
            Controls.Add(groupBox1);
            Name = "frmCargarJugador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCargarJugador";
            Load += frmCargarJugador_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private Label lblNick;
        private Label lblEquipo;
        private TextBox txtNombreApellido;
        private TextBox txtNick;
        private ComboBox cmbEquipos;
        private Button btnGuardar;
        private Button btnVolver;
        private Label lblAltaJugador;
        private GroupBox groupBox1;
    }
}
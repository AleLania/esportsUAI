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
            label1 = new Label();
            lblNombre = new Label();
            lblNick = new Label();
            lblEquipo = new Label();
            txtNombreApellido = new TextBox();
            txtNick = new TextBox();
            cmbEquipos = new ComboBox();
            btnGuardar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 37);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Alta de Jugador";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(33, 81);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre y Apellido";
            // 
            // lblNick
            // 
            lblNick.AutoSize = true;
            lblNick.Location = new Point(33, 119);
            lblNick.Name = "lblNick";
            lblNick.Size = new Size(31, 15);
            lblNick.TabIndex = 2;
            lblNick.Text = "Nick";
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(33, 166);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(44, 15);
            lblEquipo.TabIndex = 3;
            lblEquipo.Text = "Equipo";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(165, 78);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(100, 23);
            txtNombreApellido.TabIndex = 4;
            // 
            // txtNick
            // 
            txtNick.Location = new Point(165, 119);
            txtNick.Name = "txtNick";
            txtNick.Size = new Size(100, 23);
            txtNick.TabIndex = 5;
            // 
            // cmbEquipos
            // 
            cmbEquipos.FormattingEnabled = true;
            cmbEquipos.Location = new Point(161, 158);
            cmbEquipos.Name = "cmbEquipos";
            cmbEquipos.Size = new Size(98, 23);
            cmbEquipos.TabIndex = 6;
            cmbEquipos.SelectedIndexChanged += cmbEquipos_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(56, 227);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 28);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(56, 335);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(92, 28);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmCargarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEquipos);
            Controls.Add(txtNick);
            Controls.Add(txtNombreApellido);
            Controls.Add(lblEquipo);
            Controls.Add(lblNick);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "frmCargarJugador";
            Text = "frmCargarJugador";
            Load += frmCargarJugador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombre;
        private Label lblNick;
        private Label lblEquipo;
        private TextBox txtNombreApellido;
        private TextBox txtNick;
        private ComboBox cmbEquipos;
        private Button btnGuardar;
        private Button btnVolver;
    }
}
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
            lblModificarJugador = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbJugador
            // 
            cmbJugador.FormattingEnabled = true;
            cmbJugador.Location = new Point(195, 58);
            cmbJugador.Name = "cmbJugador";
            cmbJugador.Size = new Size(133, 23);
            cmbJugador.TabIndex = 0;
            cmbJugador.SelectedIndexChanged += cmbJugador_SelectedIndexChanged;
            // 
            // cmbEquipos
            // 
            cmbEquipos.FormattingEnabled = true;
            cmbEquipos.Location = new Point(195, 199);
            cmbEquipos.Name = "cmbEquipos";
            cmbEquipos.Size = new Size(133, 23);
            cmbEquipos.TabIndex = 1;
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Location = new Point(20, 61);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new Size(119, 15);
            lblNombreJugador.TabIndex = 2;
            lblNombreJugador.Text = "Seleccione el jugador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 202);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 3;
            label1.Text = "Nuevo Equipo";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(183, 102);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(145, 23);
            txtNuevoNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 105);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 5;
            label2.Text = "Nuevo Nombre y Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 150);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "Nuevo Nick";
            // 
            // txtNick
            // 
            txtNick.Location = new Point(228, 150);
            txtNick.Name = "txtNick";
            txtNick.Size = new Size(100, 23);
            txtNick.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(91, 240);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 32);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(103, 304);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(132, 32);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblModificarJugador
            // 
            lblModificarJugador.AutoSize = true;
            lblModificarJugador.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModificarJugador.Location = new Point(107, 23);
            lblModificarJugador.Name = "lblModificarJugador";
            lblModificarJugador.Size = new Size(128, 18);
            lblModificarJugador.TabIndex = 21;
            lblModificarJugador.Text = "Modificar Jugador";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(332, 286);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // frmModificarJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 348);
            Controls.Add(lblModificarJugador);
            Controls.Add(btnVolver);
            Controls.Add(txtNick);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNuevoNombre);
            Controls.Add(label1);
            Controls.Add(lblNombreJugador);
            Controls.Add(cmbEquipos);
            Controls.Add(cmbJugador);
            Controls.Add(groupBox1);
            Name = "frmModificarJugador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmModificarJugador";
            Load += frmModificarJugador_Load;
            groupBox1.ResumeLayout(false);
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
        private Label lblModificarJugador;
        private GroupBox groupBox1;
    }
}
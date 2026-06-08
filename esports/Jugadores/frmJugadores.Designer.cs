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
            btnAgregarJugador.Location = new Point(25, 93);
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
            btnModificarJugador.Location = new Point(25, 144);
            btnModificarJugador.Margin = new Padding(3, 4, 3, 4);
            btnModificarJugador.Name = "btnModificarJugador";
            btnModificarJugador.Size = new Size(86, 31);
            btnModificarJugador.TabIndex = 2;
            btnModificarJugador.Text = "Modificar";
            btnModificarJugador.UseVisualStyleBackColor = true;
            // 
            // frmJugadores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnModificarJugador);
            Controls.Add(btnAgregarJugador);
            Controls.Add(lblJugadores);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmJugadores";
            Text = "frmJugadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJugadores;
        private Button btnAgregarJugador;
        private Button btnModificarJugador;
    }
}
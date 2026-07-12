namespace esports.Partidos
{
    partial class frmPartidos
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
            lblPartidos = new Label();
            btnCargarPartidoCopa = new Button();
            btnCargarPartidoTorneo = new Button();
            dgvPartidos = new DataGridView();
            label1 = new Label();
            cmbEquipo = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbCompetencia = new ComboBox();
            btnFiltrarPartidos = new Button();
            btnBorrarFiltros = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPartidos
            // 
            lblPartidos.AutoSize = true;
            lblPartidos.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartidos.Location = new Point(42, 19);
            lblPartidos.Name = "lblPartidos";
            lblPartidos.Size = new Size(100, 18);
            lblPartidos.TabIndex = 1;
            lblPartidos.Text = "ABM Partidos";
            // 
            // btnCargarPartidoCopa
            // 
            btnCargarPartidoCopa.Location = new Point(21, 58);
            btnCargarPartidoCopa.Name = "btnCargarPartidoCopa";
            btnCargarPartidoCopa.Size = new Size(139, 37);
            btnCargarPartidoCopa.TabIndex = 2;
            btnCargarPartidoCopa.Text = "Cargar Partido de Copa";
            btnCargarPartidoCopa.UseVisualStyleBackColor = true;
            btnCargarPartidoCopa.Click += btnCargarPartidoCopa_Click;
            // 
            // btnCargarPartidoTorneo
            // 
            btnCargarPartidoTorneo.Location = new Point(12, 115);
            btnCargarPartidoTorneo.Name = "btnCargarPartidoTorneo";
            btnCargarPartidoTorneo.Size = new Size(157, 37);
            btnCargarPartidoTorneo.TabIndex = 3;
            btnCargarPartidoTorneo.Text = "Cargar Partido de Torneo";
            btnCargarPartidoTorneo.UseVisualStyleBackColor = true;
            btnCargarPartidoTorneo.Click += btnCargarPartidoTorneo_Click_1;
            // 
            // dgvPartidos
            // 
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Location = new Point(206, 9);
            dgvPartidos.Margin = new Padding(3, 2, 3, 2);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.RowHeadersWidth = 51;
            dgvPartidos.Size = new Size(565, 501);
            dgvPartidos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 27);
            label1.Name = "label1";
            label1.Size = new Size(170, 18);
            label1.TabIndex = 5;
            label1.Text = "Visualizador de Partidos";
            // 
            // cmbEquipo
            // 
            cmbEquipo.FormattingEnabled = true;
            cmbEquipo.Location = new Point(21, 75);
            cmbEquipo.Margin = new Padding(3, 2, 3, 2);
            cmbEquipo.Name = "cmbEquipo";
            cmbEquipo.Size = new Size(133, 23);
            cmbEquipo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 48);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 7;
            label2.Text = "Equipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 127);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 8;
            label3.Text = "Competencia";
            // 
            // cmbCompetencia
            // 
            cmbCompetencia.FormattingEnabled = true;
            cmbCompetencia.Location = new Point(21, 153);
            cmbCompetencia.Margin = new Padding(3, 2, 3, 2);
            cmbCompetencia.Name = "cmbCompetencia";
            cmbCompetencia.Size = new Size(133, 23);
            cmbCompetencia.TabIndex = 9;
            // 
            // btnFiltrarPartidos
            // 
            btnFiltrarPartidos.Location = new Point(21, 210);
            btnFiltrarPartidos.Margin = new Padding(3, 4, 3, 4);
            btnFiltrarPartidos.Name = "btnFiltrarPartidos";
            btnFiltrarPartidos.Size = new Size(139, 37);
            btnFiltrarPartidos.TabIndex = 10;
            btnFiltrarPartidos.Text = "Filtrar partidos";
            btnFiltrarPartidos.UseVisualStyleBackColor = true;
            btnFiltrarPartidos.Click += btnFiltrarPartidos_Click;
            // 
            // btnBorrarFiltros
            // 
            btnBorrarFiltros.Location = new Point(21, 265);
            btnBorrarFiltros.Margin = new Padding(3, 4, 3, 4);
            btnBorrarFiltros.Name = "btnBorrarFiltros";
            btnBorrarFiltros.Size = new Size(139, 37);
            btnBorrarFiltros.TabIndex = 11;
            btnBorrarFiltros.Text = "Borrar filtros";
            btnBorrarFiltros.UseVisualStyleBackColor = true;
            btnBorrarFiltros.Click += btnBorrarFiltros_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrarFiltros);
            groupBox1.Controls.Add(btnFiltrarPartidos);
            groupBox1.Controls.Add(cmbCompetencia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbEquipo);
            groupBox1.Location = new Point(7, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 321);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPartidos);
            groupBox2.Controls.Add(btnCargarPartidoCopa);
            groupBox2.Controls.Add(btnCargarPartidoTorneo);
            groupBox2.Location = new Point(7, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(182, 165);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // frmPartidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 520);
            Controls.Add(label1);
            Controls.Add(dgvPartidos);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmPartidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizador y Gestor de Partidos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPartidos;
        private Button btnCargarPartidoCopa;
        private Button btnCargarPartidoTorneo;
        public DataGridView dgvPartidos;
        private Label label1;
        private ComboBox cmbEquipo;
        private Label label2;
        private Label label3;
        private ComboBox cmbCompetencia;
        private Button btnFiltrarPartidos;
        private Button btnBorrarFiltros;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
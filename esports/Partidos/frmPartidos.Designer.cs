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
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            SuspendLayout();
            // 
            // lblPartidos
            // 
            lblPartidos.AutoSize = true;
            lblPartidos.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartidos.Location = new Point(122, 370);
            lblPartidos.Name = "lblPartidos";
            lblPartidos.Size = new Size(125, 23);
            lblPartidos.TabIndex = 1;
            lblPartidos.Text = "ABM Partidos";
            // 
            // btnCargarPartidoCopa
            // 
            btnCargarPartidoCopa.Location = new Point(12, 408);
            btnCargarPartidoCopa.Margin = new Padding(3, 4, 3, 4);
            btnCargarPartidoCopa.Name = "btnCargarPartidoCopa";
            btnCargarPartidoCopa.Size = new Size(159, 49);
            btnCargarPartidoCopa.TabIndex = 2;
            btnCargarPartidoCopa.Text = "Cargar Partido de Copa";
            btnCargarPartidoCopa.UseVisualStyleBackColor = true;
            btnCargarPartidoCopa.Click += btnCargarPartidoCopa_Click;
            // 
            // btnCargarPartidoTorneo
            // 
            btnCargarPartidoTorneo.Location = new Point(199, 408);
            btnCargarPartidoTorneo.Margin = new Padding(3, 4, 3, 4);
            btnCargarPartidoTorneo.Name = "btnCargarPartidoTorneo";
            btnCargarPartidoTorneo.Size = new Size(159, 49);
            btnCargarPartidoTorneo.TabIndex = 3;
            btnCargarPartidoTorneo.Text = "Cargar Partido de Torneo";
            btnCargarPartidoTorneo.UseVisualStyleBackColor = true;
            // 
            // dgvPartidos
            // 
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Location = new Point(385, 12);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.RowHeadersWidth = 51;
            dgvPartidos.Size = new Size(517, 564);
            dgvPartidos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 12);
            label1.Name = "label1";
            label1.Size = new Size(216, 23);
            label1.TabIndex = 5;
            label1.Text = "Visualizador de Partidos";
            // 
            // cmbEquipo
            // 
            cmbEquipo.FormattingEnabled = true;
            cmbEquipo.Location = new Point(72, 90);
            cmbEquipo.Name = "cmbEquipo";
            cmbEquipo.Size = new Size(151, 28);
            cmbEquipo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 60);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 7;
            label2.Text = "Equipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 148);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 8;
            label3.Text = "Competencia";
            // 
            // cmbCompetencia
            // 
            cmbCompetencia.FormattingEnabled = true;
            cmbCompetencia.Location = new Point(72, 181);
            cmbCompetencia.Name = "cmbCompetencia";
            cmbCompetencia.Size = new Size(151, 28);
            cmbCompetencia.TabIndex = 9;
            // 
            // btnFiltrarPartidos
            // 
            btnFiltrarPartidos.Location = new Point(72, 242);
            btnFiltrarPartidos.Margin = new Padding(3, 4, 3, 4);
            btnFiltrarPartidos.Name = "btnFiltrarPartidos";
            btnFiltrarPartidos.Size = new Size(159, 49);
            btnFiltrarPartidos.TabIndex = 10;
            btnFiltrarPartidos.Text = "Filtrar partidos";
            btnFiltrarPartidos.UseVisualStyleBackColor = true;
            btnFiltrarPartidos.Click += btnFiltrarPartidos_Click;
            // 
            // frmPartidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnFiltrarPartidos);
            Controls.Add(cmbCompetencia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbEquipo);
            Controls.Add(label1);
            Controls.Add(dgvPartidos);
            Controls.Add(btnCargarPartidoTorneo);
            Controls.Add(btnCargarPartidoCopa);
            Controls.Add(lblPartidos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPartidos";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPartidos;
        private Button btnCargarPartidoCopa;
        private Button btnCargarPartidoTorneo;
        private DataGridView dgvPartidos;
        private Label label1;
        private ComboBox cmbEquipo;
        private Label label2;
        private Label label3;
        private ComboBox cmbCompetencia;
        private Button btnFiltrarPartidos;
    }
}
namespace esports.Competencias
{
    partial class frmResultados
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
            Label label1;
            Label label2;
            cmbEsport = new ComboBox();
            cmbCompetencia = new ComboBox();
            dgvResultados = new DataGridView();
            btnVer = new Button();
            btnVolver = new Button();
            lblPartidoTorneo = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 47);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Elegir Esport";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 114);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 3;
            label2.Text = "Elegir Competencia";
            // 
            // cmbEsport
            // 
            cmbEsport.FormattingEnabled = true;
            cmbEsport.Location = new Point(11, 72);
            cmbEsport.Margin = new Padding(2);
            cmbEsport.Name = "cmbEsport";
            cmbEsport.Size = new Size(128, 23);
            cmbEsport.TabIndex = 0;
            // 
            // cmbCompetencia
            // 
            cmbCompetencia.FormattingEnabled = true;
            cmbCompetencia.Location = new Point(11, 137);
            cmbCompetencia.Margin = new Padding(2);
            cmbCompetencia.Name = "cmbCompetencia";
            cmbCompetencia.Size = new Size(128, 23);
            cmbCompetencia.TabIndex = 1;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(156, 11);
            dgvResultados.Margin = new Padding(2);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 62;
            dgvResultados.Size = new Size(530, 399);
            dgvResultados.TabIndex = 4;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(14, 191);
            btnVer.Margin = new Padding(2);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(132, 32);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(14, 373);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(132, 32);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblPartidoTorneo
            // 
            lblPartidoTorneo.AutoSize = true;
            lblPartidoTorneo.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartidoTorneo.Location = new Point(30, 17);
            lblPartidoTorneo.Name = "lblPartidoTorneo";
            lblPartidoTorneo.Size = new Size(90, 18);
            lblPartidoTorneo.TabIndex = 21;
            lblPartidoTorneo.Text = "Visualizador";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 236);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // frmResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 412);
            Controls.Add(lblPartidoTorneo);
            Controls.Add(btnVolver);
            Controls.Add(btnVer);
            Controls.Add(dgvResultados);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCompetencia);
            Controls.Add(cmbEsport);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmResultados";
            Text = "Competencias";
            Load += frmResultados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEsport;
        private ComboBox cmbCompetencia;
        private DataGridView dgvResultados;
        private Button btnVer;
        private Button btnVolver;
        private Label lblPartidoTorneo;
        private GroupBox groupBox1;
    }
}
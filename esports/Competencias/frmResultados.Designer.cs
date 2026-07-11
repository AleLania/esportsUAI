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
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 2;
            label1.Text = "Elegir Esport";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 150);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 3;
            label2.Text = "Elegir Competencia";
            // 
            // cmbEsport
            // 
            cmbEsport.FormattingEnabled = true;
            cmbEsport.Location = new Point(10, 94);
            cmbEsport.Margin = new Padding(2, 2, 2, 2);
            cmbEsport.Name = "cmbEsport";
            cmbEsport.Size = new Size(146, 28);
            cmbEsport.TabIndex = 0;
            // 
            // cmbCompetencia
            // 
            cmbCompetencia.FormattingEnabled = true;
            cmbCompetencia.Location = new Point(10, 180);
            cmbCompetencia.Margin = new Padding(2, 2, 2, 2);
            cmbCompetencia.Name = "cmbCompetencia";
            cmbCompetencia.Size = new Size(146, 28);
            cmbCompetencia.TabIndex = 1;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(294, 60);
            dgvResultados.Margin = new Padding(2, 2, 2, 2);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 62;
            dgvResultados.Size = new Size(490, 471);
            dgvResultados.TabIndex = 4;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(16, 284);
            btnVer.Margin = new Padding(2, 2, 2, 2);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(82, 34);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(16, 497);
            btnVolver.Margin = new Padding(2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 34);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmResultados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 549);
            Controls.Add(btnVolver);
            Controls.Add(btnVer);
            Controls.Add(dgvResultados);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCompetencia);
            Controls.Add(cmbEsport);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmResultados";
            Text = "Form1";
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
    }
}
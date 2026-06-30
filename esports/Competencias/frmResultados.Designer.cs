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
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 2;
            label1.Text = "Elegir Esport";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 187);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 3;
            label2.Text = "Elegir Competencia";
            // 
            // cmbEsport
            // 
            cmbEsport.FormattingEnabled = true;
            cmbEsport.Location = new Point(12, 117);
            cmbEsport.Name = "cmbEsport";
            cmbEsport.Size = new Size(182, 33);
            cmbEsport.TabIndex = 0;
            // 
            // cmbCompetencia
            // 
            cmbCompetencia.FormattingEnabled = true;
            cmbCompetencia.Location = new Point(12, 225);
            cmbCompetencia.Name = "cmbCompetencia";
            cmbCompetencia.Size = new Size(182, 33);
            cmbCompetencia.TabIndex = 1;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(367, 75);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.RowHeadersWidth = 62;
            dgvResultados.Size = new Size(613, 589);
            dgvResultados.TabIndex = 4;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(20, 355);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(103, 43);
            btnVer.TabIndex = 5;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // frmResultados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 686);
            Controls.Add(btnVer);
            Controls.Add(dgvResultados);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCompetencia);
            Controls.Add(cmbEsport);
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
    }
}
namespace esports.Equipos
{
    partial class frmUpdateEquipos
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
            cmbEquipos = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(98, 435);
            btnSave.Click += btnSave_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(113, 239);
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.Location = new Point(113, 339);
            // 
            // label1
            // 
            label1.Location = new Point(113, 192);
            // 
            // label2
            // 
            label2.Location = new Point(113, 297);
            // 
            // label3
            // 
            label3.Size = new Size(148, 25);
            label3.Text = "Modificar Equipo";
            // 
            // cmbEquipos
            // 
            cmbEquipos.FormattingEnabled = true;
            cmbEquipos.Location = new Point(113, 135);
            cmbEquipos.Name = "cmbEquipos";
            cmbEquipos.Size = new Size(182, 33);
            cmbEquipos.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 98);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 7;
            label4.Text = "Seleccione equipo";
            // 
            // frmUpdateEquipos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 544);
            Controls.Add(label4);
            Controls.Add(cmbEquipos);
            Name = "frmUpdateEquipos";
            Text = "Form1";
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(txtNombreEquipo, 0);
            Controls.SetChildIndex(cmbDisciplina, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(cmbEquipos, 0);
            Controls.SetChildIndex(label4, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEquipos;
        private Label label4;
    }
}
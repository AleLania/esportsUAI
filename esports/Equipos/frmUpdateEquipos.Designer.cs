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
            btnSave.Location = new Point(77, 275);
            btnSave.Margin = new Padding(2);
            btnSave.Size = new Size(174, 58);
            btnSave.Click += btnSave_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(90, 191);
            txtNombreEquipo.Margin = new Padding(2);
            txtNombreEquipo.Size = new Size(140, 27);
            // 
            // cmbEsport
            // 
            cmbEsport.Location = new Point(244, 305);
            cmbEsport.Margin = new Padding(2);
            cmbEsport.Size = new Size(146, 28);
            // 
            // label1
            // 
            label1.Location = new Point(90, 154);
            label1.Margin = new Padding(2, 0, 2, 0);
            // 
            // label2
            // 
            label2.Location = new Point(244, 272);
            label2.Margin = new Padding(2, 0, 2, 0);
            // 
            // label3
            // 
            label3.Location = new Point(10, 17);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Size = new Size(124, 20);
            label3.Text = "Modificar Equipo";
            // 
            // cmbEquipos
            // 
            cmbEquipos.FormattingEnabled = true;
            cmbEquipos.Location = new Point(90, 108);
            cmbEquipos.Margin = new Padding(2);
            cmbEquipos.Name = "cmbEquipos";
            cmbEquipos.Size = new Size(146, 28);
            cmbEquipos.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 78);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 7;
            label4.Text = "Seleccione equipo";
            // 
            // frmUpdateEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 355);
            Controls.Add(label4);
            Controls.Add(cmbEquipos);
            Margin = new Padding(2);
            Name = "frmUpdateEquipos";
            Text = "Form1";
            Load += frmUpdateEquipos_Load;
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(txtNombreEquipo, 0);
            Controls.SetChildIndex(cmbEsport, 0);
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
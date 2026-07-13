namespace esports.Equipos
{
    partial class frmDeleteEquipos
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
            cmbEquipo = new ComboBox();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            lblAltaEquipo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 93);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 27;
            label1.Text = "Nombre";
            // 
            // cmbEquipo
            // 
            cmbEquipo.FormattingEnabled = true;
            cmbEquipo.Location = new Point(108, 69);
            cmbEquipo.Name = "cmbEquipo";
            cmbEquipo.Size = new Size(110, 33);
            cmbEquipo.TabIndex = 26;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(78, 202);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 32);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAltaEquipo);
            groupBox1.Controls.Add(cmbEquipo);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 245);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            // 
            // lblAltaEquipo
            // 
            lblAltaEquipo.AutoSize = true;
            lblAltaEquipo.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAltaEquipo.Location = new Point(88, 12);
            lblAltaEquipo.Name = "lblAltaEquipo";
            lblAltaEquipo.Size = new Size(161, 28);
            lblAltaEquipo.TabIndex = 22;
            lblAltaEquipo.Text = "Alta de Equipo";
            // 
            // ffrmDeleteEquipos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 284);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(groupBox1);
            Name = "ffrmDeleteEquipos";
            Text = "ffrmDeleteEquipos";
            Load += ffrmDeleteEquipos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected Label label1;
        protected ComboBox cmbEquipo;
        protected Button btnDelete;
        private GroupBox groupBox1;
        private Label lblAltaEquipo;
    }
}
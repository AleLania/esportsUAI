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
            btnSave = new Button();
            txtNombreEquipo = new TextBox();
            lblModificarEquipo = new Label();
            lblNuevoNombre = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbEquipos
            // 
            cmbEquipos.FormattingEnabled = true;
            cmbEquipos.Location = new Point(141, 72);
            cmbEquipos.Margin = new Padding(2);
            cmbEquipos.Name = "cmbEquipos";
            cmbEquipos.Size = new Size(128, 23);
            cmbEquipos.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 75);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 7;
            label4.Text = "Seleccione equipo";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(78, 176);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 32);
            btnSave.TabIndex = 8;
            btnSave.Text = "Modificar Equipo";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(169, 116);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(100, 23);
            txtNombreEquipo.TabIndex = 9;
            // 
            // lblModificarEquipo
            // 
            lblModificarEquipo.AutoSize = true;
            lblModificarEquipo.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModificarEquipo.Location = new Point(91, 19);
            lblModificarEquipo.Name = "lblModificarEquipo";
            lblModificarEquipo.Size = new Size(119, 18);
            lblModificarEquipo.TabIndex = 22;
            lblModificarEquipo.Text = "Modificar Equipo";
            // 
            // lblNuevoNombre
            // 
            lblNuevoNombre.AutoSize = true;
            lblNuevoNombre.Location = new Point(24, 119);
            lblNuevoNombre.Margin = new Padding(2, 0, 2, 0);
            lblNuevoNombre.Name = "lblNuevoNombre";
            lblNuevoNombre.Size = new Size(89, 15);
            lblNuevoNombre.TabIndex = 23;
            lblNuevoNombre.Text = "Nuevo Nombre";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblModificarEquipo);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 224);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // frmUpdateEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 243);
            Controls.Add(lblNuevoNombre);
            Controls.Add(txtNombreEquipo);
            Controls.Add(label4);
            Controls.Add(cmbEquipos);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmUpdateEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmUpdateEquipos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEquipos;
        private Label label4;
        private Button btnSave;
        private TextBox txtNombreEquipo;
        private Label lblModificarEquipo;
        private Label lblNuevoNombre;
        private GroupBox groupBox1;
    }
}
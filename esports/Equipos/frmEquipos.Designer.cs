namespace esports
{
    partial class frmEquipos
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
            btnAddEquipo = new Button();
            btnUpdateEquipo = new Button();
            dgvEquipos = new DataGridView();
            btnVolverMenu = new Button();
            lblGestionEquipos = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // btnAddEquipo
            // 
            btnAddEquipo.Location = new Point(16, 61);
            btnAddEquipo.Margin = new Padding(3, 2, 3, 2);
            btnAddEquipo.Name = "btnAddEquipo";
            btnAddEquipo.Size = new Size(116, 32);
            btnAddEquipo.TabIndex = 0;
            btnAddEquipo.Text = "Agregar Equipo";
            btnAddEquipo.UseVisualStyleBackColor = true;
            btnAddEquipo.Click += btnAddEquipo_Click;
            // 
            // btnUpdateEquipo
            // 
            btnUpdateEquipo.Location = new Point(16, 111);
            btnUpdateEquipo.Margin = new Padding(3, 2, 3, 2);
            btnUpdateEquipo.Name = "btnUpdateEquipo";
            btnUpdateEquipo.Size = new Size(116, 31);
            btnUpdateEquipo.TabIndex = 1;
            btnUpdateEquipo.Text = "Modificar Equipo";
            btnUpdateEquipo.UseVisualStyleBackColor = true;
            btnUpdateEquipo.Click += btnUpdateEquipo_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(150, 7);
            dgvEquipos.Margin = new Padding(2);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 62;
            dgvEquipos.Size = new Size(406, 330);
            dgvEquipos.TabIndex = 2;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(14, 290);
            btnVolverMenu.Margin = new Padding(3, 2, 3, 2);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(116, 32);
            btnVolverMenu.TabIndex = 3;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // lblGestionEquipos
            // 
            lblGestionEquipos.AutoSize = true;
            lblGestionEquipos.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGestionEquipos.Location = new Point(27, 19);
            lblGestionEquipos.Name = "lblGestionEquipos";
            lblGestionEquipos.Size = new Size(97, 18);
            lblGestionEquipos.TabIndex = 4;
            lblGestionEquipos.Text = "ABM Equipos";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(11, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 167);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // frmEquipos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 337);
            Controls.Add(lblGestionEquipos);
            Controls.Add(btnVolverMenu);
            Controls.Add(dgvEquipos);
            Controls.Add(btnUpdateEquipo);
            Controls.Add(btnAddEquipo);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Equipos";
            Load += frmEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddEquipo;
        private Button btnUpdateEquipo;
        private DataGridView dgvEquipos;
        private Button btnVolverMenu;
        private Label lblGestionEquipos;
        private GroupBox groupBox1;
    }
}
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
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddEquipo
            // 
            btnAddEquipo.Location = new Point(23, 102);
            btnAddEquipo.Margin = new Padding(4, 3, 4, 3);
            btnAddEquipo.Name = "btnAddEquipo";
            btnAddEquipo.Size = new Size(166, 53);
            btnAddEquipo.TabIndex = 0;
            btnAddEquipo.Text = "Agregar Equipo";
            btnAddEquipo.UseVisualStyleBackColor = true;
            btnAddEquipo.Click += btnAddEquipo_Click;
            // 
            // btnUpdateEquipo
            // 
            btnUpdateEquipo.Location = new Point(23, 185);
            btnUpdateEquipo.Margin = new Padding(4, 3, 4, 3);
            btnUpdateEquipo.Name = "btnUpdateEquipo";
            btnUpdateEquipo.Size = new Size(166, 52);
            btnUpdateEquipo.TabIndex = 1;
            btnUpdateEquipo.Text = "Modificar Equipo";
            btnUpdateEquipo.UseVisualStyleBackColor = true;
            btnUpdateEquipo.Click += btnUpdateEquipo_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(214, 12);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 62;
            dgvEquipos.Size = new Size(580, 550);
            dgvEquipos.TabIndex = 2;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(20, 483);
            btnVolverMenu.Margin = new Padding(4, 3, 4, 3);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(166, 53);
            btnVolverMenu.TabIndex = 3;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // lblGestionEquipos
            // 
            lblGestionEquipos.AutoSize = true;
            lblGestionEquipos.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGestionEquipos.Location = new Point(39, 32);
            lblGestionEquipos.Margin = new Padding(4, 0, 4, 0);
            lblGestionEquipos.Name = "lblGestionEquipos";
            lblGestionEquipos.Size = new Size(149, 28);
            lblGestionEquipos.TabIndex = 4;
            lblGestionEquipos.Text = "ABM Equipos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Location = new Point(16, -2);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(190, 335);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(8, 275);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 52);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Eliminar Equipo";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmEquipos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 562);
            Controls.Add(lblGestionEquipos);
            Controls.Add(btnVolverMenu);
            Controls.Add(dgvEquipos);
            Controls.Add(btnUpdateEquipo);
            Controls.Add(btnAddEquipo);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmEquipos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Equipos";
            Load += frmEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            groupBox1.ResumeLayout(false);
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
        private Button btnDelete;
    }
}
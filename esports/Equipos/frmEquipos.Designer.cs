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
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).BeginInit();
            SuspendLayout();
            // 
            // btnAddEquipo
            // 
            btnAddEquipo.Location = new Point(26, 65);
            btnAddEquipo.Name = "btnAddEquipo";
            btnAddEquipo.Size = new Size(133, 42);
            btnAddEquipo.TabIndex = 0;
            btnAddEquipo.Text = "Agregar Equipo";
            btnAddEquipo.UseVisualStyleBackColor = true;
            btnAddEquipo.Click += btnAddEquipo_Click;
            // 
            // btnUpdateEquipo
            // 
            btnUpdateEquipo.Location = new Point(26, 128);
            btnUpdateEquipo.Name = "btnUpdateEquipo";
            btnUpdateEquipo.Size = new Size(133, 41);
            btnUpdateEquipo.TabIndex = 1;
            btnUpdateEquipo.Text = "Modificar Equipo";
            btnUpdateEquipo.UseVisualStyleBackColor = true;
            btnUpdateEquipo.Click += btnUpdateEquipo_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(342, 10);
            dgvEquipos.Margin = new Padding(2, 2, 2, 2);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 62;
            dgvEquipos.Size = new Size(448, 430);
            dgvEquipos.TabIndex = 2;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(18, 386);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(133, 42);
            btnVolverMenu.TabIndex = 3;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // frmEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolverMenu);
            Controls.Add(dgvEquipos);
            Controls.Add(btnUpdateEquipo);
            Controls.Add(btnAddEquipo);
            Name = "frmEquipos";
            Text = "frmEquipos";
            Load += frmEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEquipos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddEquipo;
        private Button btnUpdateEquipo;
        private DataGridView dgvEquipos;
        private Button btnVolverMenu;
    }
}
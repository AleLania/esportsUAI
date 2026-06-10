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
            btnAddEquipo.Location = new Point(32, 81);
            btnAddEquipo.Margin = new Padding(4);
            btnAddEquipo.Name = "btnAddEquipo";
            btnAddEquipo.Size = new Size(166, 52);
            btnAddEquipo.TabIndex = 0;
            btnAddEquipo.Text = "Agregar Equipo";
            btnAddEquipo.UseVisualStyleBackColor = true;
            btnAddEquipo.Click += btnAddEquipo_Click;
            // 
            // btnUpdateEquipo
            // 
            btnUpdateEquipo.Location = new Point(32, 160);
            btnUpdateEquipo.Margin = new Padding(4);
            btnUpdateEquipo.Name = "btnUpdateEquipo";
            btnUpdateEquipo.Size = new Size(166, 51);
            btnUpdateEquipo.TabIndex = 1;
            btnUpdateEquipo.Text = "Modificar Equipo";
            btnUpdateEquipo.UseVisualStyleBackColor = true;
            btnUpdateEquipo.Click += btnUpdateEquipo_Click;
            // 
            // dgvEquipos
            // 
            dgvEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipos.Location = new Point(428, 12);
            dgvEquipos.Name = "dgvEquipos";
            dgvEquipos.RowHeadersWidth = 62;
            dgvEquipos.Size = new Size(560, 538);
            dgvEquipos.TabIndex = 2;
            // 
            // btnVolverMenu
            // 
            btnVolverMenu.Location = new Point(23, 482);
            btnVolverMenu.Margin = new Padding(4);
            btnVolverMenu.Name = "btnVolverMenu";
            btnVolverMenu.Size = new Size(166, 52);
            btnVolverMenu.TabIndex = 3;
            btnVolverMenu.Text = "Volver";
            btnVolverMenu.UseVisualStyleBackColor = true;
            btnVolverMenu.Click += btnVolverMenu_Click;
            // 
            // frmEquipos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnVolverMenu);
            Controls.Add(dgvEquipos);
            Controls.Add(btnUpdateEquipo);
            Controls.Add(btnAddEquipo);
            Margin = new Padding(4);
            Name = "frmEquipos";
            Text = "frmEquipos";
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
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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // btnUpdateEquipo
            // 
            btnUpdateEquipo.Location = new Point(26, 128);
            btnUpdateEquipo.Name = "btnUpdateEquipo";
            btnUpdateEquipo.Size = new Size(133, 41);
            btnUpdateEquipo.TabIndex = 1;
            btnUpdateEquipo.Text = "Modificar Equipo";
            btnUpdateEquipo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(373, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(415, 415);
            dataGridView1.TabIndex = 2;
            // 
            // frmEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdateEquipo);
            Controls.Add(btnAddEquipo);
            Name = "frmEquipos";
            Text = "frmEquipos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddEquipo;
        private Button btnUpdateEquipo;
        private DataGridView dataGridView1;
    }
}
namespace esports.Partidos
{
    partial class frmPartidos
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
            lblPartidos = new Label();
            btnCargarPartidoCopa = new Button();
            btnCargarPartidoTorneo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPartidos
            // 
            lblPartidos.AutoSize = true;
            lblPartidos.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPartidos.Location = new Point(30, 30);
            lblPartidos.Name = "lblPartidos";
            lblPartidos.Size = new Size(100, 18);
            lblPartidos.TabIndex = 1;
            lblPartidos.Text = "ABM Partidos";
            // 
            // btnCargarPartidoCopa
            // 
            btnCargarPartidoCopa.Location = new Point(30, 363);
            btnCargarPartidoCopa.Name = "btnCargarPartidoCopa";
            btnCargarPartidoCopa.Size = new Size(139, 23);
            btnCargarPartidoCopa.TabIndex = 2;
            btnCargarPartidoCopa.Text = "Cargar Partido de Copa";
            btnCargarPartidoCopa.UseVisualStyleBackColor = true;
            btnCargarPartidoCopa.Click += this.btnCargarPartidoCopa_Click;
            // 
            // btnCargarPartidoTorneo
            // 
            btnCargarPartidoTorneo.Location = new Point(249, 363);
            btnCargarPartidoTorneo.Name = "btnCargarPartidoTorneo";
            btnCargarPartidoTorneo.Size = new Size(171, 23);
            btnCargarPartidoTorneo.TabIndex = 3;
            btnCargarPartidoTorneo.Text = "Cargar Partido de Torneo";
            btnCargarPartidoTorneo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 163);
            label1.Name = "label1";
            label1.Size = new Size(163, 18);
            label1.TabIndex = 4;
            label1.Text = "Posible dgv de partidos";
            // 
            // frmPartidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCargarPartidoTorneo);
            Controls.Add(btnCargarPartidoCopa);
            Controls.Add(lblPartidos);
            Name = "frmPartidos";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPartidos;
        private Button btnCargarPartidoCopa;
        private Button btnCargarPartidoTorneo;
        private Label label1;
    }
}
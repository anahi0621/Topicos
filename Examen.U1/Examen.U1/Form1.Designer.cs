namespace Examen.U1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.grdp = new Plantilla.GradientPanel();
            this.btnNosotros = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMedical = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.grdp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdp
            // 
            this.grdp.BackColor = System.Drawing.Color.Transparent;
            this.grdp.ColorButtom = System.Drawing.Color.LightCyan;
            this.grdp.ColorTop = System.Drawing.Color.MidnightBlue;
            this.grdp.Controls.Add(this.btnNosotros);
            this.grdp.Controls.Add(this.pictureBox1);
            this.grdp.Controls.Add(this.btnMedical);
            this.grdp.Controls.Add(this.btnCitas);
            this.grdp.Controls.Add(this.btnAcerca);
            this.grdp.Controls.Add(this.btnSalir);
            this.grdp.Controls.Add(this.btnPacientes);
            this.grdp.Location = new System.Drawing.Point(-1, -1);
            this.grdp.Name = "grdp";
            this.grdp.Size = new System.Drawing.Size(800, 550);
            this.grdp.TabIndex = 7;
            // 
            // btnNosotros
            // 
            this.btnNosotros.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNosotros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNosotros.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNosotros.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnNosotros.Location = new System.Drawing.Point(288, 180);
            this.btnNosotros.Margin = new System.Windows.Forms.Padding(2);
            this.btnNosotros.Name = "btnNosotros";
            this.btnNosotros.Size = new System.Drawing.Size(150, 162);
            this.btnNosotros.TabIndex = 4;
            this.btnNosotros.Text = "Nosotros";
            this.btnNosotros.UseVisualStyleBackColor = false;
            this.btnNosotros.Click += new System.EventHandler(this.btnNosotros_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::Examen.U1.Properties.Resources._2_banner_height_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(528, 371);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnMedical
            // 
            this.btnMedical.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMedical.Enabled = false;
            this.btnMedical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedical.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedical.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnMedical.Location = new System.Drawing.Point(133, 13);
            this.btnMedical.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedical.Name = "btnMedical";
            this.btnMedical.Size = new System.Drawing.Size(150, 162);
            this.btnMedical.TabIndex = 0;
            this.btnMedical.Text = "Medical";
            this.btnMedical.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnCitas.Location = new System.Drawing.Point(133, 347);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(150, 162);
            this.btnCitas.TabIndex = 5;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAcerca.Enabled = false;
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnAcerca.Location = new System.Drawing.Point(288, 13);
            this.btnAcerca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(150, 162);
            this.btnAcerca.TabIndex = 1;
            this.btnAcerca.Text = "Acerca de";
            this.btnAcerca.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(442, 13);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 162);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnPacientes.Location = new System.Drawing.Point(133, 180);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(150, 162);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.grdp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.grdp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedical;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnNosotros;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Plantilla.GradientPanel grdp;
    }
}


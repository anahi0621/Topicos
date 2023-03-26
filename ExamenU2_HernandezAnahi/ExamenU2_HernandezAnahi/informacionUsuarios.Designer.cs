
namespace ExamenU2_HernandezAnahi
{
    partial class frmInformacion
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
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dtvInformacion = new System.Windows.Forms.DataGridView();
            this.clMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvInformacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.btnRegresar);
            this.pnl2.Controls.Add(this.dtvInformacion);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(0, 0);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(800, 450);
            this.pnl2.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRegresar.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRegresar.Location = new System.Drawing.Point(331, 387);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(129, 54);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtvInformacion
            // 
            this.dtvInformacion.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dtvInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvInformacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMatricula,
            this.clNombre,
            this.clEmail});
            this.dtvInformacion.Location = new System.Drawing.Point(24, 20);
            this.dtvInformacion.Name = "dtvInformacion";
            this.dtvInformacion.RowHeadersWidth = 51;
            this.dtvInformacion.RowTemplate.Height = 24;
            this.dtvInformacion.Size = new System.Drawing.Size(743, 361);
            this.dtvInformacion.TabIndex = 1;
            // 
            // clMatricula
            // 
            this.clMatricula.HeaderText = "Matricula";
            this.clMatricula.MinimumWidth = 6;
            this.clMatricula.Name = "clMatricula";
            this.clMatricula.Width = 125;
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Nombre completo";
            this.clNombre.MinimumWidth = 6;
            this.clNombre.Name = "clNombre";
            this.clNombre.Width = 125;
            // 
            // clEmail
            // 
            this.clEmail.HeaderText = "Email";
            this.clEmail.MinimumWidth = 6;
            this.clEmail.Name = "clEmail";
            this.clEmail.Width = 125;
            // 
            // frmInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl2);
            this.Name = "frmInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Informacion de usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvInformacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.DataGridView dtvInformacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.Button btnRegresar;
    }
}
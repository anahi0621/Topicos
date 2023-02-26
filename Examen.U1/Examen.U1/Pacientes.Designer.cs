namespace Examen.U1
{
    partial class frmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            this.dtgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.cmbDiagnostico = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVerOcultar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvRegistros
            // 
            this.dtgvRegistros.AllowUserToAddRows = false;
            this.dtgvRegistros.AllowUserToDeleteRows = false;
            this.dtgvRegistros.AllowUserToResizeColumns = false;
            this.dtgvRegistros.AllowUserToResizeRows = false;
            this.dtgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvRegistros.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dtgvRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Edad,
            this.Diagnostico});
            this.dtgvRegistros.EnableHeadersVisualStyles = false;
            this.dtgvRegistros.GridColor = System.Drawing.Color.MidnightBlue;
            this.dtgvRegistros.Location = new System.Drawing.Point(14, 34);
            this.dtgvRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvRegistros.Name = "dtgvRegistros";
            this.dtgvRegistros.ReadOnly = true;
            this.dtgvRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvRegistros.RowHeadersVisible = false;
            this.dtgvRegistros.RowHeadersWidth = 51;
            this.dtgvRegistros.RowTemplate.Height = 24;
            this.dtgvRegistros.Size = new System.Drawing.Size(410, 198);
            this.dtgvRegistros.TabIndex = 10;
            this.dtgvRegistros.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.Location = new System.Drawing.Point(11, 357);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(176, 357);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 30);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = global::Examen.U1.Properties.Resources._2_banner_height_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(709, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Himalaya", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 48);
            this.label7.TabIndex = 39;
            this.label7.Tag = "";
            this.label7.Text = "Pacientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtboxNombre);
            this.groupBox1.Controls.Add(this.cmbDiagnostico);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtboxCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtboxEdad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 238);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 29);
            this.label6.TabIndex = 29;
            this.label6.Text = "Diagnostico:";
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtboxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtboxNombre.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNombre.ForeColor = System.Drawing.Color.SlateGray;
            this.txtboxNombre.Location = new System.Drawing.Point(135, 77);
            this.txtboxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxNombre.MaxLength = 35;
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(200, 36);
            this.txtboxNombre.TabIndex = 1;
            this.txtboxNombre.Text = "INGRESE NOMBRE";
            this.txtboxNombre.Enter += new System.EventHandler(this.txtboxNombre_Enter);
            this.txtboxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxNombre_KeyPress);
            this.txtboxNombre.Leave += new System.EventHandler(this.txtboxNombre_Leave);
            // 
            // cmbDiagnostico
            // 
            this.cmbDiagnostico.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDiagnostico.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiagnostico.ForeColor = System.Drawing.Color.SlateGray;
            this.cmbDiagnostico.FormattingEnabled = true;
            this.cmbDiagnostico.Items.AddRange(new object[] {
            "SELECCIONE UNA OPCIÓN",
            "MODERADO",
            "NO MODERADO"});
            this.cmbDiagnostico.Location = new System.Drawing.Point(135, 161);
            this.cmbDiagnostico.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDiagnostico.Name = "cmbDiagnostico";
            this.cmbDiagnostico.Size = new System.Drawing.Size(298, 37);
            this.cmbDiagnostico.TabIndex = 3;
            this.cmbDiagnostico.Enter += new System.EventHandler(this.cmbDiagnostico_Enter);
            this.cmbDiagnostico.Leave += new System.EventHandler(this.cmbDiagnostico_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigó:";
            // 
            // txtboxCodigo
            // 
            this.txtboxCodigo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtboxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxCodigo.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCodigo.ForeColor = System.Drawing.Color.SlateGray;
            this.txtboxCodigo.Location = new System.Drawing.Point(135, 33);
            this.txtboxCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxCodigo.MaxLength = 6;
            this.txtboxCodigo.Name = "txtboxCodigo";
            this.txtboxCodigo.Size = new System.Drawing.Size(200, 36);
            this.txtboxCodigo.TabIndex = 0;
            this.txtboxCodigo.Text = "INGRESE CODIGÓ";
            this.txtboxCodigo.Enter += new System.EventHandler(this.txtboxCodigo_Enter);
            this.txtboxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCodigo_KeyPress);
            this.txtboxCodigo.Leave += new System.EventHandler(this.txtboxCodigo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre:";
            // 
            // txtboxEdad
            // 
            this.txtboxEdad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtboxEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxEdad.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEdad.ForeColor = System.Drawing.Color.SlateGray;
            this.txtboxEdad.Location = new System.Drawing.Point(135, 121);
            this.txtboxEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxEdad.MaxLength = 2;
            this.txtboxEdad.Name = "txtboxEdad";
            this.txtboxEdad.Size = new System.Drawing.Size(200, 36);
            this.txtboxEdad.TabIndex = 2;
            this.txtboxEdad.Text = "INGRESE EDAD";
            this.txtboxEdad.Enter += new System.EventHandler(this.txtboxEdad_Enter);
            this.txtboxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxEdad_KeyPress);
            this.txtboxEdad.Leave += new System.EventHandler(this.txtboxEdad_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Edad:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnActualizar.Location = new System.Drawing.Point(176, 310);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 30);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregar.Location = new System.Drawing.Point(11, 310);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 30);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVerOcultar
            // 
            this.btnVerOcultar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVerOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerOcultar.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerOcultar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnVerOcultar.Location = new System.Drawing.Point(495, 110);
            this.btnVerOcultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerOcultar.Name = "btnVerOcultar";
            this.btnVerOcultar.Size = new System.Drawing.Size(120, 30);
            this.btnVerOcultar.TabIndex = 9;
            this.btnVerOcultar.Text = "Ocultar";
            this.btnVerOcultar.UseVisualStyleBackColor = false;
            this.btnVerOcultar.Click += new System.EventHandler(this.btnVerOcultar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MidnightBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Location = new System.Drawing.Point(495, 63);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 30);
            this.button4.TabIndex = 8;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(322, 243);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(109, 29);
            this.lblPromedio.TabIndex = 42;
            this.lblPromedio.Tag = "";
            this.lblPromedio.Text = "Promedio: 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(457, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 245);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPromedio);
            this.groupBox3.Controls.Add(this.dtgvRegistros);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Himalaya", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(469, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 284);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tabla de registros";
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 102;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // Diagnostico
            // 
            this.Diagnostico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.ReadOnly = true;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(909, 573);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnVerOcultar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPacientes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvRegistros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.ComboBox cmbDiagnostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVerOcultar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
    }
}
﻿namespace Examen.U1
{
    partial class frmCitas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitas));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grdp = new Plantilla.GradientPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtboxUnidades = new System.Windows.Forms.TextBox();
            this.lblCostos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grdp.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdp
            // 
            this.grdp.ColorButtom = System.Drawing.Color.LightCyan;
            this.grdp.ColorTop = System.Drawing.Color.MidnightBlue;
            this.grdp.Controls.Add(this.textBox3);
            this.grdp.Controls.Add(this.btnBuscar);
            this.grdp.Controls.Add(this.panel3);
            this.grdp.Controls.Add(this.panel2);
            this.grdp.Controls.Add(this.panel1);
            this.grdp.Controls.Add(this.label7);
            this.grdp.Controls.Add(this.pictureBox1);
            this.grdp.Controls.Add(this.lblConfirmacion);
            this.grdp.Controls.Add(this.label5);
            this.grdp.Controls.Add(this.btnCancelar);
            this.grdp.Controls.Add(this.btnGenerar);
            this.grdp.Controls.Add(this.btnSalir);
            this.grdp.Location = new System.Drawing.Point(-1, -1);
            this.grdp.Name = "grdp";
            this.grdp.Size = new System.Drawing.Size(1000, 720);
            this.grdp.TabIndex = 39;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.textBox3.Location = new System.Drawing.Point(419, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(384, 36);
            this.textBox3.TabIndex = 43;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.Location = new System.Drawing.Point(683, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 30);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.panel3.Controls.Add(this.txtboxUnidades);
            this.panel3.Controls.Add(this.lblCostos);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.cmbDescripcion);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(619, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 218);
            this.panel3.TabIndex = 41;
            // 
            // txtboxUnidades
            // 
            this.txtboxUnidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.txtboxUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxUnidades.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUnidades.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtboxUnidades.Location = new System.Drawing.Point(146, 133);
            this.txtboxUnidades.MaxLength = 2;
            this.txtboxUnidades.Name = "txtboxUnidades";
            this.txtboxUnidades.Size = new System.Drawing.Size(57, 36);
            this.txtboxUnidades.TabIndex = 45;
            this.txtboxUnidades.TextChanged += new System.EventHandler(this.txtboxUnidades_TextChanged);
            this.txtboxUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxUnidades_KeyPress);
            // 
            // lblCostos
            // 
            this.lblCostos.AutoSize = true;
            this.lblCostos.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostos.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblCostos.Location = new System.Drawing.Point(146, 87);
            this.lblCostos.Name = "lblCostos";
            this.lblCostos.Size = new System.Drawing.Size(23, 29);
            this.lblCostos.TabIndex = 11;
            this.lblCostos.Text = "$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblTotal.Location = new System.Drawing.Point(237, 179);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 29);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = " _____";
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.cmbDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDescripcion.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDescripcion.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Items.AddRange(new object[] {
            "Cirugia",
            "Ultrasonido",
            "Radiografia",
            "Examen de orina"});
            this.cmbDescripcion.Location = new System.Drawing.Point(146, 36);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(160, 37);
            this.cmbDescripcion.TabIndex = 8;
            this.cmbDescripcion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label16.Location = new System.Drawing.Point(172, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 29);
            this.label16.TabIndex = 7;
            this.label16.Text = "Total:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label14.Location = new System.Drawing.Point(42, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 29);
            this.label14.TabIndex = 5;
            this.label14.Text = "Unidades: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Location = new System.Drawing.Point(129, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Servicios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Location = new System.Drawing.Point(27, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Descripción:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label12.Location = new System.Drawing.Point(63, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 29);
            this.label12.TabIndex = 3;
            this.label12.Text = "Costos: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dtgv);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(13, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 275);
            this.panel2.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(425, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "0";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AllowUserToOrderColumns = true;
            this.dtgv.AllowUserToResizeColumns = false;
            this.dtgv.AllowUserToResizeRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgv.ColumnHeadersHeight = 29;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgv.EnableHeadersVisualStyles = false;
            this.dtgv.GridColor = System.Drawing.Color.MidnightBlue;
            this.dtgv.Location = new System.Drawing.Point(17, 16);
            this.dtgv.Margin = new System.Windows.Forms.Padding(2);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(458, 214);
            this.dtgv.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hora";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label18.Location = new System.Drawing.Point(367, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 29);
            this.label18.TabIndex = 9;
            this.label18.Text = "Total: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.dtpHora);
            this.panel1.Controls.Add(this.txtboxNombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtboxCodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 199);
            this.panel1.TabIndex = 39;
            // 
            // dtpHora
            // 
            this.dtpHora.CalendarMonthBackground = System.Drawing.Color.LightSteelBlue;
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(98, 141);
            this.dtpHora.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(200, 36);
            this.dtpHora.TabIndex = 34;
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.txtboxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxNombre.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNombre.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtboxNombre.Location = new System.Drawing.Point(98, 54);
            this.txtboxNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxNombre.MaxLength = 35;
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(200, 36);
            this.txtboxNombre.TabIndex = 17;
            this.txtboxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(37, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hora:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.LightSteelBlue;
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(98, 100);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 36);
            this.dtpFecha.TabIndex = 31;
            this.dtpFecha.Enter += new System.EventHandler(this.dtpFecha_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código:";
            // 
            // txtboxCodigo
            // 
            this.txtboxCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.txtboxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxCodigo.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCodigo.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.txtboxCodigo.Location = new System.Drawing.Point(98, 9);
            this.txtboxCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxCodigo.MaxLength = 6;
            this.txtboxCodigo.Name = "txtboxCodigo";
            this.txtboxCodigo.Size = new System.Drawing.Size(200, 36);
            this.txtboxCodigo.TabIndex = 15;
            this.txtboxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Himalaya", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(13, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 48);
            this.label7.TabIndex = 38;
            this.label7.Tag = "";
            this.label7.Text = "Citas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::Examen.U1.Properties.Resources._2_banner_height_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(812, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmacion.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacion.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblConfirmacion.Location = new System.Drawing.Point(150, 382);
            this.lblConfirmacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(98, 29);
            this.lblConfirmacion.TabIndex = 37;
            this.lblConfirmacion.Text = "0 0 0 0 0 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(138, 346);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "Confirmación";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.Location = new System.Drawing.Point(206, 302);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 30);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnGenerar.Location = new System.Drawing.Point(75, 302);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(120, 30);
            this.btnGenerar.TabIndex = 34;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(46)))), ((int)(((byte)(92)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.Location = new System.Drawing.Point(742, 671);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 30);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(963, 635);
            this.Controls.Add(this.grdp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCitas_FormClosing);
            this.grdp.ResumeLayout(false);
            this.grdp.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.Label label7;
        private Plantilla.GradientPanel grdp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCostos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtboxUnidades;
    }
}
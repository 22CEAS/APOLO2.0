﻿namespace Apolo
{
    partial class frmProcesoCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoCambio));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaCambio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtGuiaRemision = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoLaptop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNroTicket = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroCambio = new System.Windows.Forms.TextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtRucDni = new System.Windows.Forms.TextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.chbEquipoDanado = new System.Windows.Forms.CheckBox();
            this.chbEquipoDevuelto = new System.Windows.Forms.CheckBox();
            this.chbPagaraCliente = new System.Windows.Forms.CheckBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlC = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLaptopsSeleccionados = new DevExpress.XtraGrid.GridControl();
            this.vistaEquipos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MarcaLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreModeloLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TamanoPantalla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GeneracionProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreModeloVideo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapacidadVideo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaCambio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptopsSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(207, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fecha Cambio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Guía de Remisión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(207, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Cliente";
            // 
            // dtpFechaCambio
            // 
            // 
            // 
            // 
            this.dtpFechaCambio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaCambio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFechaCambio.ButtonDropDown.Visible = true;
            this.dtpFechaCambio.IsPopupCalendarOpen = false;
            this.dtpFechaCambio.Location = new System.Drawing.Point(210, 174);
            // 
            // 
            // 
            this.dtpFechaCambio.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaCambio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dtpFechaCambio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaCambio.MonthCalendar.DisplayMonth = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.dtpFechaCambio.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpFechaCambio.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaCambio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaCambio.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpFechaCambio.Name = "dtpFechaCambio";
            this.dtpFechaCambio.Size = new System.Drawing.Size(141, 20);
            this.dtpFechaCambio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaCambio.TabIndex = 5;
            // 
            // txtGuiaRemision
            // 
            this.txtGuiaRemision.Location = new System.Drawing.Point(13, 174);
            this.txtGuiaRemision.Name = "txtGuiaRemision";
            this.txtGuiaRemision.Size = new System.Drawing.Size(148, 20);
            this.txtGuiaRemision.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(11, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 79;
            this.label8.Text = "Código Laptop a Buscar";
            // 
            // txtCodigoLaptop
            // 
            this.txtCodigoLaptop.Location = new System.Drawing.Point(13, 116);
            this.txtCodigoLaptop.Name = "txtCodigoLaptop";
            this.txtCodigoLaptop.Size = new System.Drawing.Size(148, 20);
            this.txtCodigoLaptop.TabIndex = 1;
            this.txtCodigoLaptop.TextChanged += new System.EventHandler(this.txtCodigoLaptop_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(367, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 81;
            this.label9.Text = "N° Ticket Técnico";
            // 
            // txtNroTicket
            // 
            this.txtNroTicket.Location = new System.Drawing.Point(369, 174);
            this.txtNroTicket.Name = "txtNroTicket";
            this.txtNroTicket.Size = new System.Drawing.Size(117, 20);
            this.txtNroTicket.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(162, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 56);
            this.btnBuscar.TabIndex = 153;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 152;
            this.label2.Text = "Cambio N°:";
            // 
            // txtNroCambio
            // 
            this.txtNroCambio.Location = new System.Drawing.Point(12, 59);
            this.txtNroCambio.Name = "txtNroCambio";
            this.txtNroCambio.ReadOnly = true;
            this.txtNroCambio.Size = new System.Drawing.Size(149, 20);
            this.txtNroCambio.TabIndex = 151;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(531, 95);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(68, 18);
            this.labelX1.TabIndex = 155;
            this.labelX1.Text = "RUC / DNI:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(210, 116);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(269, 20);
            this.txtCliente.TabIndex = 2;
            // 
            // txtRucDni
            // 
            this.txtRucDni.Location = new System.Drawing.Point(531, 116);
            this.txtRucDni.Name = "txtRucDni";
            this.txtRucDni.ReadOnly = true;
            this.txtRucDni.Size = new System.Drawing.Size(124, 20);
            this.txtRucDni.TabIndex = 3;
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular.AutoSize = true;
            this.btnAnular.BackColor = System.Drawing.Color.Transparent;
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnular.Location = new System.Drawing.Point(445, 506);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(60, 66);
            this.btnAnular.TabIndex = 174;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(597, 506);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 66);
            this.btnImprimir.TabIndex = 173;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(511, 507);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 172;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.AutoSize = true;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(286, 506);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 65);
            this.btnEditar.TabIndex = 171;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(218, 508);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 63);
            this.btnNuevo.TabIndex = 170;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrabar.AutoSize = true;
            this.btnGrabar.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.FlatAppearance.BorderSize = 0;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrabar.Location = new System.Drawing.Point(359, 508);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(94, 64);
            this.btnGrabar.TabIndex = 169;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(17, 80);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(623, 87);
            this.txtObservacion.TabIndex = 175;
            // 
            // chbEquipoDanado
            // 
            this.chbEquipoDanado.AutoSize = true;
            this.chbEquipoDanado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbEquipoDanado.Location = new System.Drawing.Point(158, 30);
            this.chbEquipoDanado.Name = "chbEquipoDanado";
            this.chbEquipoDanado.Size = new System.Drawing.Size(128, 20);
            this.chbEquipoDanado.TabIndex = 176;
            this.chbEquipoDanado.Text = "Equipo Dañado";
            this.chbEquipoDanado.UseVisualStyleBackColor = true;
            // 
            // chbEquipoDevuelto
            // 
            this.chbEquipoDevuelto.AutoSize = true;
            this.chbEquipoDevuelto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbEquipoDevuelto.Location = new System.Drawing.Point(17, 30);
            this.chbEquipoDevuelto.Name = "chbEquipoDevuelto";
            this.chbEquipoDevuelto.Size = new System.Drawing.Size(132, 20);
            this.chbEquipoDevuelto.TabIndex = 177;
            this.chbEquipoDevuelto.Text = "Equipo Devuelto";
            this.chbEquipoDevuelto.UseVisualStyleBackColor = true;
            this.chbEquipoDevuelto.CheckedChanged += new System.EventHandler(this.chbEquipoDevuelto_CheckedChanged);
            // 
            // chbPagaraCliente
            // 
            this.chbPagaraCliente.AutoSize = true;
            this.chbPagaraCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbPagaraCliente.Location = new System.Drawing.Point(292, 30);
            this.chbPagaraCliente.Name = "chbPagaraCliente";
            this.chbPagaraCliente.Size = new System.Drawing.Size(125, 20);
            this.chbPagaraCliente.TabIndex = 178;
            this.chbPagaraCliente.Text = "Pagará Cliente";
            this.chbPagaraCliente.UseVisualStyleBackColor = true;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(21, 56);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(84, 18);
            this.labelX2.TabIndex = 179;
            this.labelX2.Text = "Observación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSede);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.chbEquipoDanado);
            this.groupBox1.Controls.Add(this.chbPagaraCliente);
            this.groupBox1.Controls.Add(this.chbEquipoDevuelto);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 180);
            this.groupBox1.TabIndex = 180;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observaciones del Cambio";
            // 
            // cmbSede
            // 
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(474, 26);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(166, 24);
            this.cmbSede.TabIndex = 182;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(424, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 181;
            this.label5.Text = "Sede";
            // 
            // pnlC
            // 
            this.pnlC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlC.Controls.Add(this.btnCerrar);
            this.pnlC.Controls.Add(this.label6);
            this.pnlC.Location = new System.Drawing.Point(0, 0);
            this.pnlC.Name = "pnlC";
            this.pnlC.Size = new System.Drawing.Size(785, 33);
            this.pnlC.TabIndex = 181;
            this.pnlC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlC_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(660, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 197;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(282, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 183;
            this.label6.Text = "CAMBIO";
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlC_MouseMove);
            // 
            // dgvLaptopsSeleccionados
            // 
            this.dgvLaptopsSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaptopsSeleccionados.Location = new System.Drawing.Point(13, 213);
            this.dgvLaptopsSeleccionados.MainView = this.vistaEquipos;
            this.dgvLaptopsSeleccionados.Name = "dgvLaptopsSeleccionados";
            this.dgvLaptopsSeleccionados.Size = new System.Drawing.Size(659, 82);
            this.dgvLaptopsSeleccionados.TabIndex = 196;
            this.dgvLaptopsSeleccionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaEquipos});
            // 
            // vistaEquipos
            // 
            this.vistaEquipos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaEquipos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaEquipos.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaEquipos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaEquipos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaEquipos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaEquipos.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaEquipos.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaEquipos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaEquipos.Appearance.Row.Options.UseFont = true;
            this.vistaEquipos.Appearance.Row.Options.UseForeColor = true;
            this.vistaEquipos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.MarcaLC,
            this.NombreModeloLC,
            this.TamanoPantalla,
            this.TipoProcesador,
            this.GeneracionProcesador,
            this.NombreModeloVideo,
            this.CapacidadVideo,
            this.IdLC});
            this.vistaEquipos.GridControl = this.dgvLaptopsSeleccionados;
            this.vistaEquipos.Name = "vistaEquipos";
            this.vistaEquipos.OptionsBehavior.Editable = false;
            this.vistaEquipos.OptionsCustomization.AllowColumnMoving = false;
            this.vistaEquipos.OptionsDetail.EnableMasterViewMode = false;
            this.vistaEquipos.OptionsMenu.EnableColumnMenu = false;
            this.vistaEquipos.OptionsView.ColumnAutoWidth = false;
            this.vistaEquipos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaEquipos.OptionsView.ShowGroupPanel = false;
            this.vistaEquipos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vistaEquipos_KeyUp);
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.MinWidth = 40;
            this.Codigo.Name = "Codigo";
            this.Codigo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 0;
            this.Codigo.Width = 140;
            // 
            // MarcaLC
            // 
            this.MarcaLC.Caption = "Marca";
            this.MarcaLC.FieldName = "MarcaLC";
            this.MarcaLC.MinWidth = 40;
            this.MarcaLC.Name = "MarcaLC";
            this.MarcaLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MarcaLC.Visible = true;
            this.MarcaLC.VisibleIndex = 1;
            this.MarcaLC.Width = 100;
            // 
            // NombreModeloLC
            // 
            this.NombreModeloLC.Caption = "Modelo";
            this.NombreModeloLC.FieldName = "NombreModeloLC";
            this.NombreModeloLC.MinWidth = 40;
            this.NombreModeloLC.Name = "NombreModeloLC";
            this.NombreModeloLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NombreModeloLC.Visible = true;
            this.NombreModeloLC.VisibleIndex = 2;
            this.NombreModeloLC.Width = 100;
            // 
            // TamanoPantalla
            // 
            this.TamanoPantalla.Caption = "Pantalla";
            this.TamanoPantalla.FieldName = "TamanoPantalla";
            this.TamanoPantalla.MinWidth = 40;
            this.TamanoPantalla.Name = "TamanoPantalla";
            this.TamanoPantalla.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TamanoPantalla.Width = 100;
            // 
            // TipoProcesador
            // 
            this.TipoProcesador.Caption = "Procesador";
            this.TipoProcesador.FieldName = "TipoProcesador";
            this.TipoProcesador.MinWidth = 40;
            this.TipoProcesador.Name = "TipoProcesador";
            this.TipoProcesador.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TipoProcesador.Visible = true;
            this.TipoProcesador.VisibleIndex = 3;
            this.TipoProcesador.Width = 100;
            // 
            // GeneracionProcesador
            // 
            this.GeneracionProcesador.Caption = "Generación";
            this.GeneracionProcesador.FieldName = "GeneracionProcesador";
            this.GeneracionProcesador.MinWidth = 40;
            this.GeneracionProcesador.Name = "GeneracionProcesador";
            this.GeneracionProcesador.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.GeneracionProcesador.Visible = true;
            this.GeneracionProcesador.VisibleIndex = 4;
            this.GeneracionProcesador.Width = 100;
            // 
            // NombreModeloVideo
            // 
            this.NombreModeloVideo.Caption = "Video";
            this.NombreModeloVideo.FieldName = "NombreModeloVideo";
            this.NombreModeloVideo.Name = "NombreModeloVideo";
            this.NombreModeloVideo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // CapacidadVideo
            // 
            this.CapacidadVideo.Caption = "Capacidad Video";
            this.CapacidadVideo.FieldName = "CapacidadVideo";
            this.CapacidadVideo.MinWidth = 40;
            this.CapacidadVideo.Name = "CapacidadVideo";
            this.CapacidadVideo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CapacidadVideo.Visible = true;
            this.CapacidadVideo.VisibleIndex = 5;
            this.CapacidadVideo.Width = 100;
            // 
            // IdLC
            // 
            this.IdLC.Caption = "gridColumn1";
            this.IdLC.FieldName = "IdLC";
            this.IdLC.Name = "IdLC";
            this.IdLC.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.AutoSize = true;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProducto.Location = new System.Drawing.Point(549, 139);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 71);
            this.btnAgregarProducto.TabIndex = 197;
            this.btnAgregarProducto.Text = "Agregar\r\nEquipos";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // frmProcesoCambio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(697, 580);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvLaptopsSeleccionados);
            this.Controls.Add(this.pnlC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtRucDni);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNroCambio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNroTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigoLaptop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaCambio);
            this.Controls.Add(this.txtGuiaRemision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoCambio";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio";
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaCambio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlC.ResumeLayout(false);
            this.pnlC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptopsSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaCambio;
        private System.Windows.Forms.TextBox txtGuiaRemision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoLaptop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNroTicket;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroCambio;
        internal DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtRucDni;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.CheckBox chbEquipoDanado;
        private System.Windows.Forms.CheckBox chbEquipoDevuelto;
        private System.Windows.Forms.CheckBox chbPagaraCliente;
        internal DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlC;
        private System.Windows.Forms.Label label6;
        public DevExpress.XtraGrid.GridControl dgvLaptopsSeleccionados;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaEquipos;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn MarcaLC;
        private DevExpress.XtraGrid.Columns.GridColumn NombreModeloLC;
        private DevExpress.XtraGrid.Columns.GridColumn TamanoPantalla;
        private DevExpress.XtraGrid.Columns.GridColumn TipoProcesador;
        private DevExpress.XtraGrid.Columns.GridColumn GeneracionProcesador;
        private DevExpress.XtraGrid.Columns.GridColumn NombreModeloVideo;
        private DevExpress.XtraGrid.Columns.GridColumn CapacidadVideo;
        private DevExpress.XtraGrid.Columns.GridColumn IdLC;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}
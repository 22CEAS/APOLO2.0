﻿namespace Apolo
{
    partial class frmProcesoNotaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoNotaCredito));
            this.cmbFactura = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDeseleccionarFilas = new System.Windows.Forms.Button();
            this.btnSeleccionarFilas = new System.Windows.Forms.Button();
            this.dgvFacturas = new DevExpress.XtraGrid.GridControl();
            this.vistaFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Seleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuiaSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecIniPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecFinPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VentaSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VentaDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecIniPagoAntiguo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecFinPagoAntiguo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalSolesAntiguo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalDolaresAntiguo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.costoSolesAntiguo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.costoDolaresAntiguo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtObservación = new DevExpress.XtraEditors.MemoEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNC = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoCambio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservación.Properties)).BeginInit();
            this.pnlNC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaEmision)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFactura
            // 
            this.cmbFactura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFactura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFactura.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFactura.FormattingEnabled = true;
            this.cmbFactura.Location = new System.Drawing.Point(230, 56);
            this.cmbFactura.Name = "cmbFactura";
            this.cmbFactura.Size = new System.Drawing.Size(177, 29);
            this.cmbFactura.TabIndex = 1;
            this.cmbFactura.SelectedIndexChanged += new System.EventHandler(this.cmbFactura_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(234, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 20);
            this.label15.TabIndex = 58;
            this.label15.Text = "Número Factura";
            // 
            // btnDeseleccionarFilas
            // 
            this.btnDeseleccionarFilas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeseleccionarFilas.AutoSize = true;
            this.btnDeseleccionarFilas.BackColor = System.Drawing.Color.Transparent;
            this.btnDeseleccionarFilas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeseleccionarFilas.FlatAppearance.BorderSize = 0;
            this.btnDeseleccionarFilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionarFilas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeseleccionarFilas.Image = ((System.Drawing.Image)(resources.GetObject("btnDeseleccionarFilas.Image")));
            this.btnDeseleccionarFilas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeseleccionarFilas.Location = new System.Drawing.Point(113, 174);
            this.btnDeseleccionarFilas.Name = "btnDeseleccionarFilas";
            this.btnDeseleccionarFilas.Size = new System.Drawing.Size(179, 50);
            this.btnDeseleccionarFilas.TabIndex = 140;
            this.btnDeseleccionarFilas.Text = "Deseleccionar Filas";
            this.btnDeseleccionarFilas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeseleccionarFilas.UseVisualStyleBackColor = false;
            this.btnDeseleccionarFilas.Click += new System.EventHandler(this.btnDeseleccionarFilas_Click);
            // 
            // btnSeleccionarFilas
            // 
            this.btnSeleccionarFilas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarFilas.AutoSize = true;
            this.btnSeleccionarFilas.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarFilas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarFilas.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarFilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarFilas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarFilas.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarFilas.Image")));
            this.btnSeleccionarFilas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeleccionarFilas.Location = new System.Drawing.Point(-15, 174);
            this.btnSeleccionarFilas.Name = "btnSeleccionarFilas";
            this.btnSeleccionarFilas.Size = new System.Drawing.Size(157, 50);
            this.btnSeleccionarFilas.TabIndex = 139;
            this.btnSeleccionarFilas.Text = "Seleccionar Filas";
            this.btnSeleccionarFilas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionarFilas.UseVisualStyleBackColor = false;
            this.btnSeleccionarFilas.Click += new System.EventHandler(this.btnSeleccionarFilas_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Location = new System.Drawing.Point(12, 229);
            this.dgvFacturas.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvFacturas.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvFacturas.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvFacturas.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvFacturas.MainView = this.vistaFacturas;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dgvFacturas.Size = new System.Drawing.Size(1028, 239);
            this.dgvFacturas.TabIndex = 138;
            this.dgvFacturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaFacturas});
            // 
            // vistaFacturas
            // 
            this.vistaFacturas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaFacturas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaFacturas.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaFacturas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaFacturas.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaFacturas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaFacturas.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaFacturas.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaFacturas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaFacturas.Appearance.Row.Options.UseFont = true;
            this.vistaFacturas.Appearance.Row.Options.UseForeColor = true;
            this.vistaFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Seleccionar,
            this.Codigo,
            this.GuiaSalida,
            this.ruc,
            this.fecIniPago,
            this.fecFinPago,
            this.VentaSoles,
            this.VentaDolares,
            this.CostoSoles,
            this.CostoDolares,
            this.idFactura,
            this.idSalida,
            this.idLC,
            this.fecIniPagoAntiguo,
            this.fecFinPagoAntiguo,
            this.totalSolesAntiguo,
            this.totalDolaresAntiguo,
            this.costoSolesAntiguo,
            this.costoDolaresAntiguo,
            this.numFactura});
            this.vistaFacturas.GridControl = this.dgvFacturas;
            this.vistaFacturas.Name = "vistaFacturas";
            this.vistaFacturas.OptionsCustomization.AllowColumnMoving = false;
            this.vistaFacturas.OptionsCustomization.AllowGroup = false;
            this.vistaFacturas.OptionsMenu.EnableColumnMenu = false;
            this.vistaFacturas.OptionsSelection.MultiSelect = true;
            this.vistaFacturas.OptionsView.ColumnAutoWidth = false;
            this.vistaFacturas.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaFacturas.OptionsView.ShowAutoFilterRow = true;
            this.vistaFacturas.OptionsView.ShowGroupPanel = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.Caption = "Seleccionar";
            this.Seleccionar.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Seleccionar.FieldName = "Seleccionar";
            this.Seleccionar.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Seleccionar.MinWidth = 50;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Seleccionar.Visible = true;
            this.Seleccionar.VisibleIndex = 0;
            this.Seleccionar.Width = 100;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "codigoLC";
            this.Codigo.MinWidth = 40;
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            this.Codigo.Width = 160;
            // 
            // GuiaSalida
            // 
            this.GuiaSalida.Caption = "N° Guía";
            this.GuiaSalida.FieldName = "guiaSalida";
            this.GuiaSalida.MinWidth = 40;
            this.GuiaSalida.Name = "GuiaSalida";
            this.GuiaSalida.OptionsColumn.AllowEdit = false;
            this.GuiaSalida.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.GuiaSalida.Visible = true;
            this.GuiaSalida.VisibleIndex = 2;
            this.GuiaSalida.Width = 100;
            // 
            // ruc
            // 
            this.ruc.Caption = "RUC";
            this.ruc.FieldName = "ruc";
            this.ruc.Name = "ruc";
            this.ruc.OptionsColumn.AllowEdit = false;
            this.ruc.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ruc.Visible = true;
            this.ruc.VisibleIndex = 3;
            // 
            // fecIniPago
            // 
            this.fecIniPago.Caption = "Fecha Inicio Pago";
            this.fecIniPago.FieldName = "fecIniPago";
            this.fecIniPago.Name = "fecIniPago";
            this.fecIniPago.OptionsColumn.AllowEdit = false;
            this.fecIniPago.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fecIniPago.Visible = true;
            this.fecIniPago.VisibleIndex = 4;
            // 
            // fecFinPago
            // 
            this.fecFinPago.Caption = "Fecha Fin Pago";
            this.fecFinPago.FieldName = "fecFinPago";
            this.fecFinPago.Name = "fecFinPago";
            this.fecFinPago.OptionsColumn.AllowEdit = false;
            this.fecFinPago.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fecFinPago.Visible = true;
            this.fecFinPago.VisibleIndex = 5;
            // 
            // VentaSoles
            // 
            this.VentaSoles.Caption = "Venta Soles";
            this.VentaSoles.FieldName = "totalSoles";
            this.VentaSoles.MinWidth = 40;
            this.VentaSoles.Name = "VentaSoles";
            this.VentaSoles.OptionsColumn.AllowEdit = false;
            this.VentaSoles.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.VentaSoles.Visible = true;
            this.VentaSoles.VisibleIndex = 6;
            this.VentaSoles.Width = 100;
            // 
            // VentaDolares
            // 
            this.VentaDolares.Caption = "Venta Dolares";
            this.VentaDolares.FieldName = "totalDolares";
            this.VentaDolares.MinWidth = 40;
            this.VentaDolares.Name = "VentaDolares";
            this.VentaDolares.OptionsColumn.AllowEdit = false;
            this.VentaDolares.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.VentaDolares.Visible = true;
            this.VentaDolares.VisibleIndex = 7;
            this.VentaDolares.Width = 100;
            // 
            // CostoSoles
            // 
            this.CostoSoles.Caption = "Costo Soles";
            this.CostoSoles.FieldName = "costoSoles";
            this.CostoSoles.MinWidth = 40;
            this.CostoSoles.Name = "CostoSoles";
            this.CostoSoles.OptionsColumn.AllowEdit = false;
            this.CostoSoles.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.CostoSoles.Visible = true;
            this.CostoSoles.VisibleIndex = 8;
            this.CostoSoles.Width = 100;
            // 
            // CostoDolares
            // 
            this.CostoDolares.Caption = "Costo Dolares";
            this.CostoDolares.FieldName = "costoDolares";
            this.CostoDolares.MinWidth = 40;
            this.CostoDolares.Name = "CostoDolares";
            this.CostoDolares.OptionsColumn.AllowEdit = false;
            this.CostoDolares.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.CostoDolares.Visible = true;
            this.CostoDolares.VisibleIndex = 9;
            this.CostoDolares.Width = 100;
            // 
            // idFactura
            // 
            this.idFactura.Caption = "idFactura";
            this.idFactura.FieldName = "idFactura";
            this.idFactura.MinWidth = 40;
            this.idFactura.Name = "idFactura";
            this.idFactura.OptionsColumn.AllowEdit = false;
            this.idFactura.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.idFactura.Width = 100;
            // 
            // idSalida
            // 
            this.idSalida.Caption = "idSalida";
            this.idSalida.FieldName = "idSalida";
            this.idSalida.Name = "idSalida";
            this.idSalida.OptionsColumn.AllowEdit = false;
            this.idSalida.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // idLC
            // 
            this.idLC.Caption = "idLC";
            this.idLC.FieldName = "idLC";
            this.idLC.Name = "idLC";
            this.idLC.OptionsColumn.AllowEdit = false;
            this.idLC.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // fecIniPagoAntiguo
            // 
            this.fecIniPagoAntiguo.Caption = "fecIniPagoAntiguo";
            this.fecIniPagoAntiguo.FieldName = "fecIniPagoAntiguo";
            this.fecIniPagoAntiguo.Name = "fecIniPagoAntiguo";
            this.fecIniPagoAntiguo.OptionsColumn.AllowEdit = false;
            this.fecIniPagoAntiguo.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            // 
            // fecFinPagoAntiguo
            // 
            this.fecFinPagoAntiguo.Caption = "fecFinPagoAntiguo";
            this.fecFinPagoAntiguo.FieldName = "fecFinPagoAntiguo";
            this.fecFinPagoAntiguo.Name = "fecFinPagoAntiguo";
            this.fecFinPagoAntiguo.OptionsColumn.AllowEdit = false;
            this.fecFinPagoAntiguo.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            // 
            // totalSolesAntiguo
            // 
            this.totalSolesAntiguo.Caption = "totalSolesAntiguo";
            this.totalSolesAntiguo.FieldName = "totalSolesAntiguo";
            this.totalSolesAntiguo.Name = "totalSolesAntiguo";
            this.totalSolesAntiguo.OptionsColumn.AllowEdit = false;
            this.totalSolesAntiguo.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // totalDolaresAntiguo
            // 
            this.totalDolaresAntiguo.Caption = "totalDolaresAntiguo";
            this.totalDolaresAntiguo.FieldName = "totalDolaresAntiguo";
            this.totalDolaresAntiguo.Name = "totalDolaresAntiguo";
            this.totalDolaresAntiguo.OptionsColumn.AllowEdit = false;
            this.totalDolaresAntiguo.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // costoSolesAntiguo
            // 
            this.costoSolesAntiguo.Caption = "costoSolesAntiguo";
            this.costoSolesAntiguo.FieldName = "costoSolesAntiguo";
            this.costoSolesAntiguo.Name = "costoSolesAntiguo";
            this.costoSolesAntiguo.OptionsColumn.AllowEdit = false;
            this.costoSolesAntiguo.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // costoDolaresAntiguo
            // 
            this.costoDolaresAntiguo.Caption = "costoDolaresAntiguo";
            this.costoDolaresAntiguo.FieldName = "costoDolaresAntiguo";
            this.costoDolaresAntiguo.Name = "costoDolaresAntiguo";
            this.costoDolaresAntiguo.OptionsColumn.AllowEdit = false;
            this.costoDolaresAntiguo.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // numFactura
            // 
            this.numFactura.Caption = "numFactura";
            this.numFactura.FieldName = "numFactura";
            this.numFactura.Name = "numFactura";
            this.numFactura.OptionsColumn.AllowEdit = false;
            this.numFactura.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(443, 56);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(170, 27);
            this.txtReferencia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 166;
            this.label1.Text = "Doc. Nota Crédito";
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
            this.btnCancelar.Location = new System.Drawing.Point(941, 474);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 65);
            this.btnCancelar.TabIndex = 214;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(777, 476);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 63);
            this.btnNuevo.TabIndex = 213;
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
            this.btnGrabar.Location = new System.Drawing.Point(859, 476);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(94, 64);
            this.btnGrabar.TabIndex = 212;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtObservación
            // 
            this.txtObservación.Location = new System.Drawing.Point(14, 111);
            this.txtObservación.Name = "txtObservación";
            this.txtObservación.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservación.Properties.Appearance.Options.UseFont = true;
            this.txtObservación.Size = new System.Drawing.Size(1025, 59);
            this.txtObservación.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 216;
            this.label2.Text = "Observación";
            // 
            // pnlNC
            // 
            this.pnlNC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlNC.Controls.Add(this.btnCerrar);
            this.pnlNC.Controls.Add(this.label3);
            this.pnlNC.Location = new System.Drawing.Point(0, 0);
            this.pnlNC.Name = "pnlNC";
            this.pnlNC.Size = new System.Drawing.Size(1080, 29);
            this.pnlNC.TabIndex = 217;
            this.pnlNC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlNC_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1031, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 237;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(458, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 28);
            this.label3.TabIndex = 219;
            this.label3.Text = "NOTA DE CRÉDITO";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlNC_MouseMove);
            // 
            // cmbAccion
            // 
            this.cmbAccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Location = new System.Drawing.Point(15, 56);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(177, 29);
            this.cmbAccion.TabIndex = 0;
            this.cmbAccion.SelectedIndexChanged += new System.EventHandler(this.cmbAccion_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 220;
            this.label5.Text = "Acción";
            // 
            // dtpFechaEmision
            // 
            // 
            // 
            // 
            this.dtpFechaEmision.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaEmision.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFechaEmision.ButtonDropDown.Visible = true;
            this.dtpFechaEmision.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtpFechaEmision.IsPopupCalendarOpen = false;
            this.dtpFechaEmision.Location = new System.Drawing.Point(644, 56);
            // 
            // 
            // 
            this.dtpFechaEmision.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaEmision.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dtpFechaEmision.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaEmision.MonthCalendar.DisplayMonth = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.dtpFechaEmision.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpFechaEmision.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaEmision.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaEmision.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(141, 27);
            this.dtpFechaEmision.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaEmision.TabIndex = 221;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 222;
            this.label4.Text = "Fecha Emisión";
            // 
            // txtMontoCambio
            // 
            this.txtMontoCambio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMontoCambio.Location = new System.Drawing.Point(815, 56);
            this.txtMontoCambio.Name = "txtMontoCambio";
            this.txtMontoCambio.Size = new System.Drawing.Size(119, 27);
            this.txtMontoCambio.TabIndex = 223;
            this.txtMontoCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoCambio_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(811, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 224;
            this.label6.Text = "Tipo Cambio";
            // 
            // frmProcesoNotaCredito
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1061, 544);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontoCambio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAccion);
            this.Controls.Add(this.pnlNC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservación);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.btnDeseleccionarFilas);
            this.Controls.Add(this.btnSeleccionarFilas);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.cmbFactura);
            this.Controls.Add(this.label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoNotaCredito";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acción";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservación.Properties)).EndInit();
            this.pnlNC.ResumeLayout(false);
            this.pnlNC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaEmision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFactura;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDeseleccionarFilas;
        private System.Windows.Forms.Button btnSeleccionarFilas;
        private DevExpress.XtraGrid.GridControl dgvFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn Seleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn GuiaSalida;
        private DevExpress.XtraGrid.Columns.GridColumn VentaSoles;
        private DevExpress.XtraGrid.Columns.GridColumn VentaDolares;
        private DevExpress.XtraGrid.Columns.GridColumn CostoSoles;
        private DevExpress.XtraGrid.Columns.GridColumn CostoDolares;
        private DevExpress.XtraGrid.Columns.GridColumn idFactura;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private DevExpress.XtraGrid.Columns.GridColumn ruc;
        private DevExpress.XtraGrid.Columns.GridColumn fecIniPago;
        private DevExpress.XtraGrid.Columns.GridColumn fecFinPago;
        private DevExpress.XtraGrid.Columns.GridColumn idSalida;
        private DevExpress.XtraGrid.Columns.GridColumn idLC;
        private DevExpress.XtraGrid.Columns.GridColumn fecIniPagoAntiguo;
        private DevExpress.XtraGrid.Columns.GridColumn fecFinPagoAntiguo;
        private DevExpress.XtraGrid.Columns.GridColumn totalSolesAntiguo;
        private DevExpress.XtraGrid.Columns.GridColumn totalDolaresAntiguo;
        private DevExpress.XtraGrid.Columns.GridColumn costoSolesAntiguo;
        private DevExpress.XtraGrid.Columns.GridColumn costoDolaresAntiguo;
        private DevExpress.XtraGrid.Columns.GridColumn numFactura;
        private DevExpress.XtraEditors.MemoEdit txtObservación;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlNC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnCerrar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaEmision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoCambio;
        private System.Windows.Forms.Label label6;
    }
}
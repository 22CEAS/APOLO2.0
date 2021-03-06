﻿namespace Apolo
{
    partial class frmReporteCV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCV));
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvLaptops = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoAntiguo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Guia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pantalla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Procesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Generacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Video = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Capacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscoDuro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscoDuro2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VersionWindows = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VersionOffice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FecPrimerTraslado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecIniContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecFinContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecInicioFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fecFinFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarifa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Moneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UBSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CorteAlquiler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giftCarga = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlCV = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.verResumen = new System.Windows.Forms.Button();
            this.cargarData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).BeginInit();
            this.pnlCV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.AutoSize = true;
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(12, 585);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 137;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvLaptops
            // 
            this.dgvLaptops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaptops.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White;
            this.dgvLaptops.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgvLaptops.Location = new System.Drawing.Point(12, 82);
            this.dgvLaptops.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvLaptops.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvLaptops.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvLaptops.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvLaptops.MainView = this.vista;
            this.dgvLaptops.Name = "dgvLaptops";
            this.dgvLaptops.Size = new System.Drawing.Size(1128, 458);
            this.dgvLaptops.TabIndex = 136;
            this.dgvLaptops.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista});
            this.dgvLaptops.MouseLeave += new System.EventHandler(this.dgvLaptops_MouseLeave);
            this.dgvLaptops.MouseHover += new System.EventHandler(this.dgvLaptops_MouseHover);
            // 
            // vista
            // 
            this.vista.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vista.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vista.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vista.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.vista.Appearance.HeaderPanel.Options.UseFont = true;
            this.vista.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vista.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vista.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vista.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vista.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vista.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vista.Appearance.Row.Options.UseFont = true;
            this.vista.Appearance.Row.Options.UseForeColor = true;
            this.vista.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdSalida,
            this.KAM,
            this.ruc,
            this.Cliente,
            this.Contacto,
            this.Direccion,
            this.Codigo,
            this.CodigoAntiguo,
            this.Guia,
            this.Marca,
            this.Modelo,
            this.Pantalla,
            this.Procesador,
            this.Generacion,
            this.Video,
            this.Capacidad,
            this.RAM,
            this.DiscoDuro1,
            this.DiscoDuro2,
            this.VersionWindows,
            this.VersionOffice,
            this.FecPrimerTraslado,
            this.fecIniContrato,
            this.fecFinContrato,
            this.factura,
            this.fecInicioFactura,
            this.fecFinFactura,
            this.Tarifa,
            this.Costo,
            this.Moneda,
            this.TipoCambio,
            this.UBSoles,
            this.CorteAlquiler});
            this.vista.GridControl = this.dgvLaptops;
            this.vista.Name = "vista";
            this.vista.OptionsBehavior.Editable = false;
            this.vista.OptionsSelection.MultiSelect = true;
            this.vista.OptionsView.ColumnAutoWidth = false;
            this.vista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            this.vista.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vista_KeyUp);
            // 
            // IdSalida
            // 
            this.IdSalida.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdSalida.AppearanceHeader.Options.UseBackColor = true;
            this.IdSalida.Caption = "Id Salida";
            this.IdSalida.FieldName = "IdSalida";
            this.IdSalida.MinWidth = 40;
            this.IdSalida.Name = "IdSalida";
            this.IdSalida.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IdSalida.Visible = true;
            this.IdSalida.VisibleIndex = 0;
            this.IdSalida.Width = 70;
            // 
            // KAM
            // 
            this.KAM.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KAM.AppearanceHeader.Options.UseBackColor = true;
            this.KAM.Caption = "KAM";
            this.KAM.FieldName = "KAM";
            this.KAM.Name = "KAM";
            this.KAM.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.KAM.Visible = true;
            this.KAM.VisibleIndex = 1;
            this.KAM.Width = 150;
            // 
            // ruc
            // 
            this.ruc.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ruc.AppearanceHeader.Options.UseBackColor = true;
            this.ruc.Caption = "Ruc";
            this.ruc.FieldName = "ruc";
            this.ruc.Name = "ruc";
            this.ruc.Visible = true;
            this.ruc.VisibleIndex = 2;
            // 
            // Cliente
            // 
            this.Cliente.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cliente.AppearanceHeader.Options.UseBackColor = true;
            this.Cliente.Caption = "Razon Social";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.MinWidth = 40;
            this.Cliente.Name = "Cliente";
            this.Cliente.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 3;
            this.Cliente.Width = 250;
            // 
            // Contacto
            // 
            this.Contacto.Caption = "Contacto";
            this.Contacto.FieldName = "Contacto";
            this.Contacto.MinWidth = 40;
            this.Contacto.Name = "Contacto";
            this.Contacto.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Contacto.Width = 100;
            // 
            // Direccion
            // 
            this.Direccion.Caption = "Direccion";
            this.Direccion.FieldName = "DireccionCliente";
            this.Direccion.MinWidth = 40;
            this.Direccion.Name = "Direccion";
            this.Direccion.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Direccion.Width = 100;
            // 
            // Codigo
            // 
            this.Codigo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Codigo.AppearanceHeader.Options.UseBackColor = true;
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.MinWidth = 40;
            this.Codigo.Name = "Codigo";
            this.Codigo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 4;
            this.Codigo.Width = 150;
            // 
            // CodigoAntiguo
            // 
            this.CodigoAntiguo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CodigoAntiguo.AppearanceHeader.Options.UseBackColor = true;
            this.CodigoAntiguo.Caption = "Código Antiguo";
            this.CodigoAntiguo.FieldName = "CodigoAntiguo";
            this.CodigoAntiguo.MinWidth = 40;
            this.CodigoAntiguo.Name = "CodigoAntiguo";
            this.CodigoAntiguo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CodigoAntiguo.Visible = true;
            this.CodigoAntiguo.VisibleIndex = 5;
            this.CodigoAntiguo.Width = 120;
            // 
            // Guia
            // 
            this.Guia.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Guia.AppearanceHeader.Options.UseBackColor = true;
            this.Guia.Caption = "Guia";
            this.Guia.FieldName = "guia";
            this.Guia.MinWidth = 40;
            this.Guia.Name = "Guia";
            this.Guia.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Guia.Visible = true;
            this.Guia.VisibleIndex = 6;
            this.Guia.Width = 100;
            // 
            // Marca
            // 
            this.Marca.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Marca.AppearanceHeader.Options.UseBackColor = true;
            this.Marca.Caption = "Marca";
            this.Marca.FieldName = "MarcaLC";
            this.Marca.MinWidth = 40;
            this.Marca.Name = "Marca";
            this.Marca.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Marca.Visible = true;
            this.Marca.VisibleIndex = 7;
            this.Marca.Width = 100;
            // 
            // Modelo
            // 
            this.Modelo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Modelo.AppearanceHeader.Options.UseBackColor = true;
            this.Modelo.Caption = "Modelo";
            this.Modelo.FieldName = "NombreModeloLC";
            this.Modelo.MinWidth = 40;
            this.Modelo.Name = "Modelo";
            this.Modelo.Visible = true;
            this.Modelo.VisibleIndex = 8;
            this.Modelo.Width = 100;
            // 
            // Pantalla
            // 
            this.Pantalla.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Pantalla.AppearanceHeader.Options.UseBackColor = true;
            this.Pantalla.Caption = "Pantalla";
            this.Pantalla.FieldName = "TamanoPantalla";
            this.Pantalla.MinWidth = 40;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Pantalla.Visible = true;
            this.Pantalla.VisibleIndex = 9;
            this.Pantalla.Width = 100;
            // 
            // Procesador
            // 
            this.Procesador.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Procesador.AppearanceHeader.Options.UseBackColor = true;
            this.Procesador.Caption = "Procesador";
            this.Procesador.FieldName = "TipoProcesador";
            this.Procesador.MinWidth = 40;
            this.Procesador.Name = "Procesador";
            this.Procesador.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Procesador.Visible = true;
            this.Procesador.VisibleIndex = 10;
            this.Procesador.Width = 100;
            // 
            // Generacion
            // 
            this.Generacion.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Generacion.AppearanceHeader.Options.UseBackColor = true;
            this.Generacion.Caption = "Generación";
            this.Generacion.FieldName = "GeneracionProcesador";
            this.Generacion.MinWidth = 40;
            this.Generacion.Name = "Generacion";
            this.Generacion.Visible = true;
            this.Generacion.VisibleIndex = 11;
            this.Generacion.Width = 100;
            // 
            // Video
            // 
            this.Video.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Video.AppearanceHeader.Options.UseBackColor = true;
            this.Video.Caption = "Video";
            this.Video.FieldName = "NombreModeloVideo";
            this.Video.MinWidth = 40;
            this.Video.Name = "Video";
            this.Video.Width = 100;
            // 
            // Capacidad
            // 
            this.Capacidad.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Capacidad.AppearanceHeader.Options.UseBackColor = true;
            this.Capacidad.Caption = "Capacidad Video";
            this.Capacidad.FieldName = "CapacidadVideo";
            this.Capacidad.MinWidth = 40;
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Visible = true;
            this.Capacidad.VisibleIndex = 12;
            this.Capacidad.Width = 100;
            // 
            // RAM
            // 
            this.RAM.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RAM.AppearanceHeader.Options.UseBackColor = true;
            this.RAM.Caption = "RAM";
            this.RAM.FieldName = "RAM";
            this.RAM.MinWidth = 40;
            this.RAM.Name = "RAM";
            this.RAM.Visible = true;
            this.RAM.VisibleIndex = 13;
            this.RAM.Width = 100;
            // 
            // DiscoDuro1
            // 
            this.DiscoDuro1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DiscoDuro1.AppearanceHeader.Options.UseBackColor = true;
            this.DiscoDuro1.Caption = "Disco Duro (HDD)";
            this.DiscoDuro1.FieldName = "DiscoDuro1";
            this.DiscoDuro1.MinWidth = 40;
            this.DiscoDuro1.Name = "DiscoDuro1";
            this.DiscoDuro1.Visible = true;
            this.DiscoDuro1.VisibleIndex = 14;
            this.DiscoDuro1.Width = 100;
            // 
            // DiscoDuro2
            // 
            this.DiscoDuro2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DiscoDuro2.AppearanceHeader.Options.UseBackColor = true;
            this.DiscoDuro2.Caption = "Disco Duro (SSD)";
            this.DiscoDuro2.FieldName = "DiscoDuro2";
            this.DiscoDuro2.MinWidth = 40;
            this.DiscoDuro2.Name = "DiscoDuro2";
            this.DiscoDuro2.Visible = true;
            this.DiscoDuro2.VisibleIndex = 15;
            this.DiscoDuro2.Width = 100;
            // 
            // VersionWindows
            // 
            this.VersionWindows.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.VersionWindows.AppearanceHeader.Options.UseBackColor = true;
            this.VersionWindows.Caption = "Versión Windows";
            this.VersionWindows.FieldName = "VersionWindows";
            this.VersionWindows.MinWidth = 40;
            this.VersionWindows.Name = "VersionWindows";
            this.VersionWindows.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.VersionWindows.Visible = true;
            this.VersionWindows.VisibleIndex = 16;
            this.VersionWindows.Width = 100;
            // 
            // VersionOffice
            // 
            this.VersionOffice.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.VersionOffice.AppearanceHeader.Options.UseBackColor = true;
            this.VersionOffice.Caption = "Versión Office";
            this.VersionOffice.FieldName = "VersionOffice";
            this.VersionOffice.MinWidth = 40;
            this.VersionOffice.Name = "VersionOffice";
            this.VersionOffice.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.VersionOffice.Visible = true;
            this.VersionOffice.VisibleIndex = 17;
            this.VersionOffice.Width = 100;
            // 
            // FecPrimerTraslado
            // 
            this.FecPrimerTraslado.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FecPrimerTraslado.AppearanceHeader.Options.UseBackColor = true;
            this.FecPrimerTraslado.Caption = "Fecha Primer Traslado";
            this.FecPrimerTraslado.FieldName = "FecPrimerTraslado";
            this.FecPrimerTraslado.MinWidth = 40;
            this.FecPrimerTraslado.Name = "FecPrimerTraslado";
            this.FecPrimerTraslado.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.FecPrimerTraslado.Visible = true;
            this.FecPrimerTraslado.VisibleIndex = 18;
            this.FecPrimerTraslado.Width = 100;
            // 
            // fecIniContrato
            // 
            this.fecIniContrato.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fecIniContrato.AppearanceHeader.Options.UseBackColor = true;
            this.fecIniContrato.Caption = "Inicio Plazo Alquiler";
            this.fecIniContrato.FieldName = "fecIniContrato";
            this.fecIniContrato.MinWidth = 40;
            this.fecIniContrato.Name = "fecIniContrato";
            this.fecIniContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fecIniContrato.Visible = true;
            this.fecIniContrato.VisibleIndex = 19;
            this.fecIniContrato.Width = 100;
            // 
            // fecFinContrato
            // 
            this.fecFinContrato.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fecFinContrato.AppearanceHeader.Options.UseBackColor = true;
            this.fecFinContrato.Caption = "Fin Plazo Alquiler";
            this.fecFinContrato.FieldName = "fecFinContrato";
            this.fecFinContrato.MinWidth = 40;
            this.fecFinContrato.Name = "fecFinContrato";
            this.fecFinContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fecFinContrato.Visible = true;
            this.fecFinContrato.VisibleIndex = 20;
            this.fecFinContrato.Width = 100;
            // 
            // factura
            // 
            this.factura.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.factura.AppearanceHeader.Options.UseBackColor = true;
            this.factura.Caption = "Factura";
            this.factura.FieldName = "factura";
            this.factura.MinWidth = 40;
            this.factura.Name = "factura";
            this.factura.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.factura.Visible = true;
            this.factura.VisibleIndex = 21;
            this.factura.Width = 100;
            // 
            // fecInicioFactura
            // 
            this.fecInicioFactura.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fecInicioFactura.AppearanceHeader.Options.UseBackColor = true;
            this.fecInicioFactura.Caption = "Fecha Inicio Factura";
            this.fecInicioFactura.FieldName = "fecInicioFactura";
            this.fecInicioFactura.MinWidth = 40;
            this.fecInicioFactura.Name = "fecInicioFactura";
            this.fecInicioFactura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fecInicioFactura.Visible = true;
            this.fecInicioFactura.VisibleIndex = 22;
            this.fecInicioFactura.Width = 100;
            // 
            // fecFinFactura
            // 
            this.fecFinFactura.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fecFinFactura.AppearanceHeader.Options.UseBackColor = true;
            this.fecFinFactura.Caption = "Fecha Fin Factura";
            this.fecFinFactura.FieldName = "fecFinFactura";
            this.fecFinFactura.MinWidth = 40;
            this.fecFinFactura.Name = "fecFinFactura";
            this.fecFinFactura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.fecFinFactura.Visible = true;
            this.fecFinFactura.VisibleIndex = 23;
            this.fecFinFactura.Width = 100;
            // 
            // Tarifa
            // 
            this.Tarifa.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Tarifa.AppearanceHeader.Options.UseBackColor = true;
            this.Tarifa.Caption = "Tarifa";
            this.Tarifa.FieldName = "Tarifa";
            this.Tarifa.MinWidth = 40;
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Tarifa.Visible = true;
            this.Tarifa.VisibleIndex = 24;
            this.Tarifa.Width = 100;
            // 
            // Costo
            // 
            this.Costo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Costo.AppearanceHeader.Options.UseBackColor = true;
            this.Costo.Caption = "Costo";
            this.Costo.FieldName = "Costo";
            this.Costo.MinWidth = 40;
            this.Costo.Name = "Costo";
            this.Costo.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Costo.Visible = true;
            this.Costo.VisibleIndex = 25;
            this.Costo.Width = 100;
            // 
            // Moneda
            // 
            this.Moneda.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Moneda.AppearanceHeader.Options.UseBackColor = true;
            this.Moneda.Caption = "Moneda";
            this.Moneda.FieldName = "Moneda";
            this.Moneda.MinWidth = 40;
            this.Moneda.Name = "Moneda";
            this.Moneda.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Moneda.Visible = true;
            this.Moneda.VisibleIndex = 26;
            this.Moneda.Width = 100;
            // 
            // TipoCambio
            // 
            this.TipoCambio.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TipoCambio.AppearanceHeader.Options.UseBackColor = true;
            this.TipoCambio.Caption = "Tipo de Cambio";
            this.TipoCambio.FieldName = "TipoCambio";
            this.TipoCambio.MinWidth = 40;
            this.TipoCambio.Name = "TipoCambio";
            this.TipoCambio.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TipoCambio.Visible = true;
            this.TipoCambio.VisibleIndex = 27;
            this.TipoCambio.Width = 100;
            // 
            // UBSoles
            // 
            this.UBSoles.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UBSoles.AppearanceHeader.Options.UseBackColor = true;
            this.UBSoles.Caption = "Utilidad Bruta Soles";
            this.UBSoles.FieldName = "UBSoles";
            this.UBSoles.MinWidth = 40;
            this.UBSoles.Name = "UBSoles";
            this.UBSoles.Visible = true;
            this.UBSoles.VisibleIndex = 28;
            this.UBSoles.Width = 100;
            // 
            // CorteAlquiler
            // 
            this.CorteAlquiler.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CorteAlquiler.AppearanceHeader.Options.UseBackColor = true;
            this.CorteAlquiler.Caption = "Corte Alquiler";
            this.CorteAlquiler.FieldName = "CorteAlquiler";
            this.CorteAlquiler.MinWidth = 40;
            this.CorteAlquiler.Name = "CorteAlquiler";
            this.CorteAlquiler.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CorteAlquiler.Visible = true;
            this.CorteAlquiler.VisibleIndex = 29;
            this.CorteAlquiler.Width = 80;
            // 
            // giftCarga
            // 
            this.giftCarga.BackColor = System.Drawing.Color.White;
            this.giftCarga.Location = new System.Drawing.Point(477, 320);
            this.giftCarga.Name = "giftCarga";
            this.giftCarga.Size = new System.Drawing.Size(190, 138);
            this.giftCarga.TabIndex = 140;
            this.giftCarga.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(886, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 144;
            this.label1.Text = "CANTIDAD REGISTROS:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(1080, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(65, 43);
            this.btnCerrar.TabIndex = 145;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlCV
            // 
            this.pnlCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlCV.Controls.Add(this.label2);
            this.pnlCV.Controls.Add(this.btnCerrar);
            this.pnlCV.Location = new System.Drawing.Point(2, 0);
            this.pnlCV.Name = "pnlCV";
            this.pnlCV.Size = new System.Drawing.Size(1148, 53);
            this.pnlCV.TabIndex = 146;
            this.pnlCV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCV_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(387, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 31);
            this.label2.TabIndex = 146;
            this.label2.Text = "CUADRO DE VENCIMIENTO";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCV_MouseMove);
            // 
            // verResumen
            // 
            this.verResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.verResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.verResumen.Location = new System.Drawing.Point(628, 329);
            this.verResumen.Name = "verResumen";
            this.verResumen.Size = new System.Drawing.Size(115, 19);
            this.verResumen.TabIndex = 143;
            this.verResumen.Text = "VER RESUMEN";
            this.verResumen.UseVisualStyleBackColor = false;
            // 
            // cargarData
            // 
            this.cargarData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cargarData.Location = new System.Drawing.Point(528, 329);
            this.cargarData.Name = "cargarData";
            this.cargarData.Size = new System.Drawing.Size(113, 19);
            this.cargarData.TabIndex = 138;
            this.cargarData.Text = "CARGANDO DATA";
            this.cargarData.UseVisualStyleBackColor = true;
            this.cargarData.Click += new System.EventHandler(this.cargarData_Click);
            // 
            // frmReporteCV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1152, 657);
            this.Controls.Add(this.pnlCV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giftCarga);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvLaptops);
            this.Controls.Add(this.cargarData);
            this.Controls.Add(this.verResumen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "frmReporteCV";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadro Vencimiento";
            this.Load += new System.EventHandler(this.frmReporteCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).EndInit();
            this.pnlCV.ResumeLayout(false);
            this.pnlCV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportar;
        private DevExpress.XtraGrid.GridControl dgvLaptops;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Contacto;
        private DevExpress.XtraGrid.Columns.GridColumn Direccion;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Marca;
        private DevExpress.XtraGrid.Columns.GridColumn Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn Pantalla;
        private DevExpress.XtraGrid.Columns.GridColumn Procesador;
        private DevExpress.XtraGrid.Columns.GridColumn Generacion;
        private DevExpress.XtraGrid.Columns.GridColumn Video;
        private DevExpress.XtraGrid.Columns.GridColumn Capacidad;
        private DevExpress.XtraGrid.Columns.GridColumn fecIniContrato;
        private DevExpress.XtraGrid.Columns.GridColumn fecFinContrato;
        private DevExpress.XtraGrid.Columns.GridColumn factura;
        private DevExpress.XtraGrid.Columns.GridColumn fecInicioFactura;
        private DevExpress.XtraGrid.Columns.GridColumn fecFinFactura;
        private DevExpress.XtraGrid.Columns.GridColumn Tarifa;
        private DevExpress.XtraGrid.Columns.GridColumn Costo;
        private DevExpress.XtraGrid.Columns.GridColumn Moneda;
        private DevExpress.XtraGrid.Columns.GridColumn Guia;
        private DevExpress.XtraGrid.Columns.GridColumn IdSalida;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoAntiguo;
        private DevExpress.XtraGrid.Columns.GridColumn VersionOffice;
        private DevExpress.XtraGrid.Columns.GridColumn TipoCambio;
        public System.Windows.Forms.PictureBox giftCarga;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn ruc;
        private DevExpress.XtraGrid.Columns.GridColumn KAM;
        private DevExpress.XtraGrid.Columns.GridColumn UBSoles;
        private DevExpress.XtraGrid.Columns.GridColumn RAM;
        private DevExpress.XtraGrid.Columns.GridColumn FecPrimerTraslado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verResumen;
        public System.Windows.Forms.Button cargarData;
        private DevExpress.XtraGrid.Columns.GridColumn DiscoDuro2;
        private DevExpress.XtraGrid.Columns.GridColumn DiscoDuro1;
        private DevExpress.XtraGrid.Columns.GridColumn VersionWindows;
        private DevExpress.XtraGrid.Columns.GridColumn CorteAlquiler;
    }
}
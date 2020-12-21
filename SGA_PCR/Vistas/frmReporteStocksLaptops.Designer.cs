﻿namespace Apolo
{
    partial class frmReporteStocksLaptops
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteStocksLaptops));
            this.dgvLaptops = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Procesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Video = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapacidadVideo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Disco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapacidadDisco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Disco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapacidadDisco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MemoriaRam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RucCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ubicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SerieFabrica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.giftCarga = new System.Windows.Forms.PictureBox();
            this.cargarData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCantidadFiltrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalLaptops = new System.Windows.Forms.TextBox();
            this.txtDesfasadas = new System.Windows.Forms.TextBox();
            this.txtPersonales = new System.Windows.Forms.TextBox();
            this.txtReservadas = new System.Windows.Forms.TextBox();
            this.txtAlquilados = new System.Windows.Forms.TextBox();
            this.txtDisponibles = new System.Windows.Forms.TextBox();
            this.verResumen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.GeneracionProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLaptops
            // 
            this.dgvLaptops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaptops.Location = new System.Drawing.Point(11, 139);
            this.dgvLaptops.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvLaptops.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvLaptops.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvLaptops.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvLaptops.MainView = this.vista;
            this.dgvLaptops.Name = "dgvLaptops";
            this.dgvLaptops.Size = new System.Drawing.Size(1075, 354);
            this.dgvLaptops.TabIndex = 132;
            this.dgvLaptops.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista});
            this.dgvLaptops.MouseLeave += new System.EventHandler(this.dgvLaptops_MouseLeave);
            this.dgvLaptops.MouseHover += new System.EventHandler(this.dgvLaptops_MouseHover);
            // 
            // vista
            // 
            this.vista.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vista.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
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
            this.CodigoLC,
            this.Marca,
            this.Modelo,
            this.Procesador,
            this.GeneracionProcesador,
            this.Video,
            this.CapacidadVideo,
            this.Disco1,
            this.CapacidadDisco1,
            this.Disco2,
            this.CapacidadDisco2,
            this.MemoriaRam,
            this.Estado,
            this.Cliente,
            this.RucCliente,
            this.Ubicacion,
            this.SerieFabrica,
            this.IdSalida});
            this.vista.GridControl = this.dgvLaptops;
            this.vista.Name = "vista";
            this.vista.OptionsBehavior.Editable = false;
            this.vista.OptionsView.ColumnAutoWidth = false;
            this.vista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            this.vista.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.vista_CellValueChanged);
            // 
            // CodigoLC
            // 
            this.CodigoLC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CodigoLC.AppearanceHeader.Options.UseBackColor = true;
            this.CodigoLC.Caption = "Código";
            this.CodigoLC.FieldName = "Codigo";
            this.CodigoLC.MinWidth = 40;
            this.CodigoLC.Name = "CodigoLC";
            this.CodigoLC.Visible = true;
            this.CodigoLC.VisibleIndex = 0;
            this.CodigoLC.Width = 130;
            // 
            // Marca
            // 
            this.Marca.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Marca.AppearanceHeader.Options.UseBackColor = true;
            this.Marca.Caption = "Marca";
            this.Marca.FieldName = "MarcaLC";
            this.Marca.MinWidth = 40;
            this.Marca.Name = "Marca";
            this.Marca.Visible = true;
            this.Marca.VisibleIndex = 1;
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
            this.Modelo.VisibleIndex = 2;
            this.Modelo.Width = 200;
            // 
            // Procesador
            // 
            this.Procesador.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Procesador.AppearanceHeader.Options.UseBackColor = true;
            this.Procesador.Caption = "Procesador";
            this.Procesador.FieldName = "TipoProcesador";
            this.Procesador.MinWidth = 40;
            this.Procesador.Name = "Procesador";
            this.Procesador.Visible = true;
            this.Procesador.VisibleIndex = 3;
            this.Procesador.Width = 100;
            // 
            // Video
            // 
            this.Video.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Video.AppearanceHeader.Options.UseBackColor = true;
            this.Video.Caption = "Video";
            this.Video.FieldName = "NombreModeloVideo";
            this.Video.MinWidth = 40;
            this.Video.Name = "Video";
            this.Video.Width = 170;
            // 
            // CapacidadVideo
            // 
            this.CapacidadVideo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CapacidadVideo.AppearanceHeader.Options.UseBackColor = true;
            this.CapacidadVideo.Caption = "Capacidad Video";
            this.CapacidadVideo.FieldName = "CapacidadVideo";
            this.CapacidadVideo.MinWidth = 40;
            this.CapacidadVideo.Name = "CapacidadVideo";
            this.CapacidadVideo.Visible = true;
            this.CapacidadVideo.VisibleIndex = 5;
            this.CapacidadVideo.Width = 130;
            // 
            // Disco1
            // 
            this.Disco1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Disco1.AppearanceHeader.Options.UseBackColor = true;
            this.Disco1.Caption = "Disco1";
            this.Disco1.FieldName = "Disco1";
            this.Disco1.MinWidth = 40;
            this.Disco1.Name = "Disco1";
            this.Disco1.Visible = true;
            this.Disco1.VisibleIndex = 6;
            this.Disco1.Width = 70;
            // 
            // CapacidadDisco1
            // 
            this.CapacidadDisco1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CapacidadDisco1.AppearanceHeader.Options.UseBackColor = true;
            this.CapacidadDisco1.Caption = "Capacidad Disco1";
            this.CapacidadDisco1.FieldName = "CapacidadDisco1";
            this.CapacidadDisco1.MinWidth = 40;
            this.CapacidadDisco1.Name = "CapacidadDisco1";
            this.CapacidadDisco1.Visible = true;
            this.CapacidadDisco1.VisibleIndex = 7;
            this.CapacidadDisco1.Width = 130;
            // 
            // Disco2
            // 
            this.Disco2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Disco2.AppearanceHeader.Options.UseBackColor = true;
            this.Disco2.Caption = "Disco2";
            this.Disco2.FieldName = "Disco2";
            this.Disco2.MinWidth = 40;
            this.Disco2.Name = "Disco2";
            this.Disco2.Visible = true;
            this.Disco2.VisibleIndex = 8;
            this.Disco2.Width = 70;
            // 
            // CapacidadDisco2
            // 
            this.CapacidadDisco2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CapacidadDisco2.AppearanceHeader.Options.UseBackColor = true;
            this.CapacidadDisco2.Caption = "Capacidad Disco2";
            this.CapacidadDisco2.FieldName = "CapacidadDisco2";
            this.CapacidadDisco2.MinWidth = 40;
            this.CapacidadDisco2.Name = "CapacidadDisco2";
            this.CapacidadDisco2.Visible = true;
            this.CapacidadDisco2.VisibleIndex = 9;
            this.CapacidadDisco2.Width = 130;
            // 
            // MemoriaRam
            // 
            this.MemoriaRam.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MemoriaRam.AppearanceHeader.Options.UseBackColor = true;
            this.MemoriaRam.Caption = "Memoria Ram";
            this.MemoriaRam.FieldName = "CapacidadMemoria";
            this.MemoriaRam.MinWidth = 40;
            this.MemoriaRam.Name = "MemoriaRam";
            this.MemoriaRam.Visible = true;
            this.MemoriaRam.VisibleIndex = 10;
            this.MemoriaRam.Width = 100;
            // 
            // Estado
            // 
            this.Estado.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Estado.AppearanceHeader.Options.UseBackColor = true;
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "EstadoNombre";
            this.Estado.MinWidth = 40;
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 11;
            this.Estado.Width = 130;
            // 
            // Cliente
            // 
            this.Cliente.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cliente.AppearanceHeader.Options.UseBackColor = true;
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.MinWidth = 40;
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 12;
            this.Cliente.Width = 150;
            // 
            // RucCliente
            // 
            this.RucCliente.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RucCliente.AppearanceHeader.Options.UseBackColor = true;
            this.RucCliente.Caption = "RUC";
            this.RucCliente.FieldName = "RucCliente";
            this.RucCliente.MinWidth = 40;
            this.RucCliente.Name = "RucCliente";
            this.RucCliente.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.RucCliente.Visible = true;
            this.RucCliente.VisibleIndex = 13;
            this.RucCliente.Width = 140;
            // 
            // Ubicacion
            // 
            this.Ubicacion.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Ubicacion.AppearanceHeader.Options.UseBackColor = true;
            this.Ubicacion.Caption = "Ubicación";
            this.Ubicacion.FieldName = "Ubicacion";
            this.Ubicacion.MinWidth = 40;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.Visible = true;
            this.Ubicacion.VisibleIndex = 14;
            this.Ubicacion.Width = 150;
            // 
            // SerieFabrica
            // 
            this.SerieFabrica.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SerieFabrica.AppearanceHeader.Options.UseBackColor = true;
            this.SerieFabrica.Caption = "Serie Fabrica";
            this.SerieFabrica.FieldName = "SerieFabrica";
            this.SerieFabrica.MinWidth = 40;
            this.SerieFabrica.Name = "SerieFabrica";
            this.SerieFabrica.Visible = true;
            this.SerieFabrica.VisibleIndex = 15;
            this.SerieFabrica.Width = 150;
            // 
            // IdSalida
            // 
            this.IdSalida.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdSalida.AppearanceHeader.Options.UseBackColor = true;
            this.IdSalida.Caption = "Id Salida";
            this.IdSalida.FieldName = "IdSalida";
            this.IdSalida.MinWidth = 40;
            this.IdSalida.Name = "IdSalida";
            this.IdSalida.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.IdSalida.Visible = true;
            this.IdSalida.VisibleIndex = 16;
            this.IdSalida.Width = 80;
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
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(1109, 193);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(82, 63);
            this.btnExportar.TabIndex = 139;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // giftCarga
            // 
            this.giftCarga.BackColor = System.Drawing.Color.White;
            this.giftCarga.Location = new System.Drawing.Point(419, 266);
            this.giftCarga.Name = "giftCarga";
            this.giftCarga.Size = new System.Drawing.Size(239, 185);
            this.giftCarga.TabIndex = 146;
            this.giftCarga.TabStop = false;
            // 
            // cargarData
            // 
            this.cargarData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cargarData.Location = new System.Drawing.Point(498, 331);
            this.cargarData.Name = "cargarData";
            this.cargarData.Size = new System.Drawing.Size(113, 19);
            this.cargarData.TabIndex = 145;
            this.cargarData.Text = "CARGANDO DATA";
            this.cargarData.UseVisualStyleBackColor = true;
            this.cargarData.Click += new System.EventHandler(this.cargarData_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1119, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 63);
            this.button1.TabIndex = 149;
            this.button1.Text = "REPORTE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnExportar2_Click);
            // 
            // txtCantidadFiltrada
            // 
            this.txtCantidadFiltrada.BackColor = System.Drawing.Color.White;
            this.txtCantidadFiltrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadFiltrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadFiltrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCantidadFiltrada.Location = new System.Drawing.Point(1000, 496);
            this.txtCantidadFiltrada.Name = "txtCantidadFiltrada";
            this.txtCantidadFiltrada.ReadOnly = true;
            this.txtCantidadFiltrada.Size = new System.Drawing.Size(86, 19);
            this.txtCantidadFiltrada.TabIndex = 171;
            this.txtCantidadFiltrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(794, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 170;
            this.label2.Text = "CANTIDAD FILTRADA:";
            // 
            // txtTotalLaptops
            // 
            this.txtTotalLaptops.BackColor = System.Drawing.Color.White;
            this.txtTotalLaptops.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalLaptops.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLaptops.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTotalLaptops.Location = new System.Drawing.Point(32, 29);
            this.txtTotalLaptops.Name = "txtTotalLaptops";
            this.txtTotalLaptops.ReadOnly = true;
            this.txtTotalLaptops.Size = new System.Drawing.Size(127, 37);
            this.txtTotalLaptops.TabIndex = 183;
            this.txtTotalLaptops.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDesfasadas
            // 
            this.txtDesfasadas.BackColor = System.Drawing.Color.White;
            this.txtDesfasadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesfasadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesfasadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDesfasadas.Location = new System.Drawing.Point(9, 28);
            this.txtDesfasadas.Name = "txtDesfasadas";
            this.txtDesfasadas.ReadOnly = true;
            this.txtDesfasadas.Size = new System.Drawing.Size(160, 37);
            this.txtDesfasadas.TabIndex = 182;
            this.txtDesfasadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPersonales
            // 
            this.txtPersonales.BackColor = System.Drawing.Color.White;
            this.txtPersonales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPersonales.Location = new System.Drawing.Point(13, 29);
            this.txtPersonales.Name = "txtPersonales";
            this.txtPersonales.ReadOnly = true;
            this.txtPersonales.Size = new System.Drawing.Size(160, 37);
            this.txtPersonales.TabIndex = 181;
            this.txtPersonales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReservadas
            // 
            this.txtReservadas.BackColor = System.Drawing.Color.White;
            this.txtReservadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReservadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtReservadas.Location = new System.Drawing.Point(12, 29);
            this.txtReservadas.Name = "txtReservadas";
            this.txtReservadas.ReadOnly = true;
            this.txtReservadas.Size = new System.Drawing.Size(160, 37);
            this.txtReservadas.TabIndex = 180;
            this.txtReservadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlquilados
            // 
            this.txtAlquilados.BackColor = System.Drawing.Color.White;
            this.txtAlquilados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlquilados.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlquilados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtAlquilados.Location = new System.Drawing.Point(12, 29);
            this.txtAlquilados.Name = "txtAlquilados";
            this.txtAlquilados.ReadOnly = true;
            this.txtAlquilados.Size = new System.Drawing.Size(160, 37);
            this.txtAlquilados.TabIndex = 179;
            this.txtAlquilados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDisponibles
            // 
            this.txtDisponibles.BackColor = System.Drawing.Color.White;
            this.txtDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDisponibles.Location = new System.Drawing.Point(3, 31);
            this.txtDisponibles.Name = "txtDisponibles";
            this.txtDisponibles.ReadOnly = true;
            this.txtDisponibles.Size = new System.Drawing.Size(180, 37);
            this.txtDisponibles.TabIndex = 178;
            this.txtDisponibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // verResumen
            // 
            this.verResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.verResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.verResumen.Location = new System.Drawing.Point(1151, 340);
            this.verResumen.Name = "verResumen";
            this.verResumen.Size = new System.Drawing.Size(10, 10);
            this.verResumen.TabIndex = 185;
            this.verResumen.Text = "VER RESUMEN";
            this.verResumen.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDisponibles);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(209, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 80);
            this.panel1.TabIndex = 186;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 187;
            this.label3.Text = "LAPTOPS DISPONIBLES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(505, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 188;
            this.label4.Text = "RESUMEN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAlquilados);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(607, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 80);
            this.panel2.TabIndex = 188;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 16);
            this.label5.TabIndex = 187;
            this.label5.Text = "LAPTOPS ALQUILADAS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtReservadas);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 80);
            this.panel3.TabIndex = 189;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(0, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 187;
            this.label6.Text = "LAPTOPS RESERVADAS";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtPersonales);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(803, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 80);
            this.panel4.TabIndex = 190;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 16);
            this.label7.TabIndex = 187;
            this.label7.Text = "LAPTOPS PERSONAL";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtDesfasadas);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(406, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(191, 80);
            this.panel5.TabIndex = 191;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 16);
            this.label8.TabIndex = 187;
            this.label8.Text = "LAPTOPS DESFASADAS";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.txtTotalLaptops);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(1000, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(191, 80);
            this.panel6.TabIndex = 192;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(-2, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 16);
            this.label9.TabIndex = 187;
            this.label9.Text = "TOTAL LAPTOPS OFICINA";
            // 
            // GeneracionProcesador
            // 
            this.GeneracionProcesador.Caption = "Generacion Procesador";
            this.GeneracionProcesador.DisplayFormat.FormatString = "{0} GEN";
            this.GeneracionProcesador.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.GeneracionProcesador.FieldName = "GeneracionProcesador";
            this.GeneracionProcesador.Name = "GeneracionProcesador";
            this.GeneracionProcesador.Visible = true;
            this.GeneracionProcesador.VisibleIndex = 4;
            this.GeneracionProcesador.Width = 120;
            // 
            // frmReporteStocksLaptops
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.verResumen);
            this.Controls.Add(this.txtCantidadFiltrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.giftCarga);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvLaptops);
            this.Controls.Add(this.cargarData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "frmReporteStocksLaptops";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Laptops";
            this.Load += new System.EventHandler(this.frmReporteStocksLaptops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoLC;
        private DevExpress.XtraGrid.Columns.GridColumn Marca;
        private DevExpress.XtraGrid.Columns.GridColumn Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn Procesador;
        private DevExpress.XtraGrid.Columns.GridColumn Video;
        private DevExpress.XtraGrid.Columns.GridColumn CapacidadVideo;
        private DevExpress.XtraGrid.Columns.GridColumn Disco1;
        private DevExpress.XtraGrid.Columns.GridColumn CapacidadDisco1;
        private DevExpress.XtraGrid.Columns.GridColumn Disco2;
        private DevExpress.XtraGrid.Columns.GridColumn CapacidadDisco2;
        private DevExpress.XtraGrid.Columns.GridColumn MemoriaRam;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn Ubicacion;
        private DevExpress.XtraGrid.Columns.GridColumn SerieFabrica;
        private System.Windows.Forms.Button btnExportar;
        private DevExpress.XtraGrid.Columns.GridColumn IdSalida;
        public System.Windows.Forms.PictureBox giftCarga;
        public System.Windows.Forms.Button cargarData;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn RucCliente;
        private System.Windows.Forms.TextBox txtCantidadFiltrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalLaptops;
        private System.Windows.Forms.TextBox txtDesfasadas;
        private System.Windows.Forms.TextBox txtPersonales;
        private System.Windows.Forms.TextBox txtReservadas;
        private System.Windows.Forms.TextBox txtAlquilados;
        public System.Windows.Forms.TextBox txtDisponibles;
        private System.Windows.Forms.Button verResumen;
        public DevExpress.XtraGrid.GridControl dgvLaptops;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.Columns.GridColumn GeneracionProcesador;
    }
}
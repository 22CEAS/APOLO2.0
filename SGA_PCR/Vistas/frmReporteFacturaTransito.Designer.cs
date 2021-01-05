namespace Apolo
{
    partial class frmReporteFacturaTransito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteFacturaTransito));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.cargarData = new System.Windows.Forms.Button();
            this.verResumen = new System.Windows.Forms.Button();
            this.giftCarga = new System.Windows.Forms.PictureBox();
            this.dgvEquiposCodigos = new DevExpress.XtraGrid.GridControl();
            this.vistaCodigo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaIniPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaFinPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RucDni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuiaSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CantidadEquipos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ObservacionXLevantar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlFTr = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCodigo)).BeginInit();
            this.pnlFTr.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(990, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 233;
            this.label1.Text = "CANTIDAD REGISTROS:";
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
            this.btnExportar.Location = new System.Drawing.Point(25, 560);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 231;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // cargarData
            // 
            this.cargarData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cargarData.Location = new System.Drawing.Point(288, 294);
            this.cargarData.Name = "cargarData";
            this.cargarData.Size = new System.Drawing.Size(113, 19);
            this.cargarData.TabIndex = 234;
            this.cargarData.Text = "CARGANDO DATA";
            this.cargarData.UseVisualStyleBackColor = true;
            this.cargarData.Click += new System.EventHandler(this.cargarData_Click);
            // 
            // verResumen
            // 
            this.verResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.verResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.verResumen.Location = new System.Drawing.Point(286, 350);
            this.verResumen.Name = "verResumen";
            this.verResumen.Size = new System.Drawing.Size(115, 19);
            this.verResumen.TabIndex = 235;
            this.verResumen.Text = "VER RESUMEN";
            this.verResumen.UseVisualStyleBackColor = false;
            // 
            // giftCarga
            // 
            this.giftCarga.BackColor = System.Drawing.Color.Silver;
            this.giftCarga.Location = new System.Drawing.Point(821, 557);
            this.giftCarga.Name = "giftCarga";
            this.giftCarga.Size = new System.Drawing.Size(41, 66);
            this.giftCarga.TabIndex = 241;
            this.giftCarga.TabStop = false;
            // 
            // dgvEquiposCodigos
            // 
            this.dgvEquiposCodigos.Location = new System.Drawing.Point(25, 198);
            this.dgvEquiposCodigos.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvEquiposCodigos.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvEquiposCodigos.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvEquiposCodigos.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvEquiposCodigos.MainView = this.vistaCodigo;
            this.dgvEquiposCodigos.Name = "dgvEquiposCodigos";
            this.dgvEquiposCodigos.Size = new System.Drawing.Size(1228, 353);
            this.dgvEquiposCodigos.TabIndex = 240;
            this.dgvEquiposCodigos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaCodigo});
            this.dgvEquiposCodigos.MouseLeave += new System.EventHandler(this.dgvEquiposCodigos_MouseLeave);
            this.dgvEquiposCodigos.MouseHover += new System.EventHandler(this.dgvEquiposCodigos_MouseHover);
            // 
            // vistaCodigo
            // 
            this.vistaCodigo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaCodigo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaCodigo.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaCodigo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaCodigo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaCodigo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaCodigo.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaCodigo.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaCodigo.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaCodigo.Appearance.Row.Options.UseFont = true;
            this.vistaCodigo.Appearance.Row.Options.UseForeColor = true;
            this.vistaCodigo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoEquipo,
            this.NumeroFactura,
            this.FechaPago,
            this.FechaIniPago,
            this.FechaFinPago,
            this.RucDni,
            this.RazonSocial,
            this.NumeroOC,
            this.GuiaSalida,
            this.TotalSoles,
            this.TotalDolares,
            this.CostoSoles,
            this.CostoDolares,
            this.CantidadEquipos,
            this.ObservacionXLevantar});
            this.vistaCodigo.GridControl = this.dgvEquiposCodigos;
            this.vistaCodigo.Name = "vistaCodigo";
            this.vistaCodigo.OptionsBehavior.Editable = false;
            this.vistaCodigo.OptionsCustomization.AllowColumnMoving = false;
            this.vistaCodigo.OptionsMenu.EnableColumnMenu = false;
            this.vistaCodigo.OptionsView.ColumnAutoWidth = false;
            this.vistaCodigo.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaCodigo.OptionsView.ShowAutoFilterRow = true;
            this.vistaCodigo.OptionsView.ShowGroupPanel = false;
            // 
            // CodigoEquipo
            // 
            this.CodigoEquipo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CodigoEquipo.AppearanceHeader.Options.UseBackColor = true;
            this.CodigoEquipo.Caption = "Código Equipo";
            this.CodigoEquipo.FieldName = "CodigoLC";
            this.CodigoEquipo.MinWidth = 40;
            this.CodigoEquipo.Name = "CodigoEquipo";
            this.CodigoEquipo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CodigoEquipo.Visible = true;
            this.CodigoEquipo.VisibleIndex = 0;
            this.CodigoEquipo.Width = 140;
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NumeroFactura.AppearanceHeader.Options.UseBackColor = true;
            this.NumeroFactura.Caption = "Número Factura";
            this.NumeroFactura.FieldName = "NumeroFactura";
            this.NumeroFactura.MinWidth = 40;
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.OptionsColumn.AllowEdit = false;
            this.NumeroFactura.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NumeroFactura.Visible = true;
            this.NumeroFactura.VisibleIndex = 1;
            this.NumeroFactura.Width = 100;
            // 
            // FechaPago
            // 
            this.FechaPago.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaPago.AppearanceHeader.Options.UseBackColor = true;
            this.FechaPago.Caption = "Fecha Pago";
            this.FechaPago.FieldName = "FechaPago";
            this.FechaPago.MinWidth = 40;
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.OptionsColumn.AllowEdit = false;
            this.FechaPago.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.FechaPago.Visible = true;
            this.FechaPago.VisibleIndex = 2;
            this.FechaPago.Width = 100;
            // 
            // FechaIniPago
            // 
            this.FechaIniPago.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaIniPago.AppearanceHeader.Options.UseBackColor = true;
            this.FechaIniPago.Caption = "Fecha Inicio Pago";
            this.FechaIniPago.FieldName = "FechaIniPago";
            this.FechaIniPago.MinWidth = 40;
            this.FechaIniPago.Name = "FechaIniPago";
            this.FechaIniPago.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.FechaIniPago.Visible = true;
            this.FechaIniPago.VisibleIndex = 3;
            this.FechaIniPago.Width = 100;
            // 
            // FechaFinPago
            // 
            this.FechaFinPago.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaFinPago.AppearanceHeader.Options.UseBackColor = true;
            this.FechaFinPago.Caption = "Fecha Fin Pago";
            this.FechaFinPago.FieldName = "FechaFinPago";
            this.FechaFinPago.MinWidth = 40;
            this.FechaFinPago.Name = "FechaFinPago";
            this.FechaFinPago.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.FechaFinPago.Visible = true;
            this.FechaFinPago.VisibleIndex = 4;
            this.FechaFinPago.Width = 100;
            // 
            // RucDni
            // 
            this.RucDni.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RucDni.AppearanceHeader.Options.UseBackColor = true;
            this.RucDni.Caption = "Ruc Dni";
            this.RucDni.FieldName = "RucDni";
            this.RucDni.MinWidth = 40;
            this.RucDni.Name = "RucDni";
            this.RucDni.OptionsColumn.AllowEdit = false;
            this.RucDni.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.RucDni.Visible = true;
            this.RucDni.VisibleIndex = 5;
            this.RucDni.Width = 100;
            // 
            // RazonSocial
            // 
            this.RazonSocial.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RazonSocial.AppearanceHeader.Options.UseBackColor = true;
            this.RazonSocial.Caption = "Razón Social";
            this.RazonSocial.FieldName = "RazonSocial";
            this.RazonSocial.MinWidth = 40;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.OptionsColumn.AllowEdit = false;
            this.RazonSocial.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.RazonSocial.Visible = true;
            this.RazonSocial.VisibleIndex = 6;
            this.RazonSocial.Width = 200;
            // 
            // NumeroOC
            // 
            this.NumeroOC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NumeroOC.AppearanceHeader.Options.UseBackColor = true;
            this.NumeroOC.Caption = "Numero OC";
            this.NumeroOC.FieldName = "NumeroOC";
            this.NumeroOC.MinWidth = 40;
            this.NumeroOC.Name = "NumeroOC";
            this.NumeroOC.OptionsColumn.AllowEdit = false;
            this.NumeroOC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NumeroOC.Visible = true;
            this.NumeroOC.VisibleIndex = 7;
            this.NumeroOC.Width = 100;
            // 
            // GuiaSalida
            // 
            this.GuiaSalida.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GuiaSalida.AppearanceHeader.Options.UseBackColor = true;
            this.GuiaSalida.Caption = "Guía Salida";
            this.GuiaSalida.FieldName = "NumeroDocRef";
            this.GuiaSalida.MinWidth = 40;
            this.GuiaSalida.Name = "GuiaSalida";
            this.GuiaSalida.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.GuiaSalida.Visible = true;
            this.GuiaSalida.VisibleIndex = 8;
            this.GuiaSalida.Width = 100;
            // 
            // TotalSoles
            // 
            this.TotalSoles.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TotalSoles.AppearanceHeader.Options.UseBackColor = true;
            this.TotalSoles.Caption = "Total Soles";
            this.TotalSoles.FieldName = "TotalSoles";
            this.TotalSoles.MinWidth = 40;
            this.TotalSoles.Name = "TotalSoles";
            this.TotalSoles.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TotalSoles.Visible = true;
            this.TotalSoles.VisibleIndex = 9;
            this.TotalSoles.Width = 100;
            // 
            // TotalDolares
            // 
            this.TotalDolares.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TotalDolares.AppearanceHeader.Options.UseBackColor = true;
            this.TotalDolares.Caption = "Total Dolares";
            this.TotalDolares.FieldName = "TotalDolares";
            this.TotalDolares.MinWidth = 40;
            this.TotalDolares.Name = "TotalDolares";
            this.TotalDolares.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TotalDolares.Visible = true;
            this.TotalDolares.VisibleIndex = 10;
            this.TotalDolares.Width = 100;
            // 
            // CostoSoles
            // 
            this.CostoSoles.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CostoSoles.AppearanceHeader.Options.UseBackColor = true;
            this.CostoSoles.Caption = "Costo Soles";
            this.CostoSoles.FieldName = "CostoSoles";
            this.CostoSoles.MinWidth = 40;
            this.CostoSoles.Name = "CostoSoles";
            this.CostoSoles.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.CostoSoles.Visible = true;
            this.CostoSoles.VisibleIndex = 11;
            this.CostoSoles.Width = 100;
            // 
            // CostoDolares
            // 
            this.CostoDolares.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CostoDolares.AppearanceHeader.Options.UseBackColor = true;
            this.CostoDolares.Caption = "Costo Dolares";
            this.CostoDolares.FieldName = "CostoDolares";
            this.CostoDolares.MinWidth = 40;
            this.CostoDolares.Name = "CostoDolares";
            this.CostoDolares.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.CostoDolares.Visible = true;
            this.CostoDolares.VisibleIndex = 12;
            this.CostoDolares.Width = 100;
            // 
            // CantidadEquipos
            // 
            this.CantidadEquipos.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CantidadEquipos.AppearanceHeader.Options.UseBackColor = true;
            this.CantidadEquipos.Caption = "Cantidad Equipos";
            this.CantidadEquipos.FieldName = "CantidadEquipos";
            this.CantidadEquipos.MinWidth = 40;
            this.CantidadEquipos.Name = "CantidadEquipos";
            this.CantidadEquipos.OptionsColumn.AllowEdit = false;
            this.CantidadEquipos.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.CantidadEquipos.Visible = true;
            this.CantidadEquipos.VisibleIndex = 13;
            this.CantidadEquipos.Width = 100;
            // 
            // ObservacionXLevantar
            // 
            this.ObservacionXLevantar.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ObservacionXLevantar.AppearanceHeader.Options.UseBackColor = true;
            this.ObservacionXLevantar.Caption = "Observación";
            this.ObservacionXLevantar.FieldName = "ObservacionXLevantar";
            this.ObservacionXLevantar.MinWidth = 40;
            this.ObservacionXLevantar.Name = "ObservacionXLevantar";
            this.ObservacionXLevantar.OptionsColumn.AllowEdit = false;
            this.ObservacionXLevantar.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ObservacionXLevantar.Visible = true;
            this.ObservacionXLevantar.VisibleIndex = 14;
            this.ObservacionXLevantar.Width = 300;
            // 
            // pnlFTr
            // 
            this.pnlFTr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlFTr.Controls.Add(this.label2);
            this.pnlFTr.Controls.Add(this.btnNuevo);
            this.pnlFTr.Location = new System.Drawing.Point(2, 2);
            this.pnlFTr.Name = "pnlFTr";
            this.pnlFTr.Size = new System.Drawing.Size(1312, 110);
            this.pnlFTr.TabIndex = 242;
            this.pnlFTr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFTr_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(527, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 31);
            this.label2.TabIndex = 178;
            this.label2.Text = "FACTURAS EN TRANSITO";
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
            this.btnNuevo.Location = new System.Drawing.Point(1226, 22);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 63);
            this.btnNuevo.TabIndex = 177;
            this.btnNuevo.Text = "CERRAR";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmReporteFacturaTransito
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1315, 635);
            this.Controls.Add(this.pnlFTr);
            this.Controls.Add(this.giftCarga);
            this.Controls.Add(this.dgvEquiposCodigos);
            this.Controls.Add(this.cargarData);
            this.Controls.Add(this.verResumen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteFacturaTransito";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas en Transito";
            this.Load += new System.EventHandler(this.frmReporteFacturaTransito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCodigo)).EndInit();
            this.pnlFTr.ResumeLayout(false);
            this.pnlFTr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.Button cargarData;
        private System.Windows.Forms.Button verResumen;
        public System.Windows.Forms.PictureBox giftCarga;
        private DevExpress.XtraGrid.GridControl dgvEquiposCodigos;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaPago;
        private DevExpress.XtraGrid.Columns.GridColumn FechaIniPago;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFinPago;
        private DevExpress.XtraGrid.Columns.GridColumn RucDni;
        private DevExpress.XtraGrid.Columns.GridColumn RazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroOC;
        private DevExpress.XtraGrid.Columns.GridColumn GuiaSalida;
        private DevExpress.XtraGrid.Columns.GridColumn TotalSoles;
        private DevExpress.XtraGrid.Columns.GridColumn TotalDolares;
        private DevExpress.XtraGrid.Columns.GridColumn CostoSoles;
        private DevExpress.XtraGrid.Columns.GridColumn CostoDolares;
        private DevExpress.XtraGrid.Columns.GridColumn CantidadEquipos;
        private DevExpress.XtraGrid.Columns.GridColumn ObservacionXLevantar;
        private System.Windows.Forms.Panel pnlFTr;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label2;
    }
}
namespace Apolo
{
    partial class frmProcesoFacturaTransito
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
            this.cmbFactura = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.Error = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBuscarV = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.giftCarga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposCodigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFactura
            // 
            this.cmbFactura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFactura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFactura.FormattingEnabled = true;
            this.cmbFactura.Location = new System.Drawing.Point(25, 40);
            this.cmbFactura.Name = "cmbFactura";
            this.cmbFactura.Size = new System.Drawing.Size(177, 21);
            this.cmbFactura.TabIndex = 217;
            this.cmbFactura.SelectedIndexChanged += new System.EventHandler(this.cmbFactura_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 16);
            this.label15.TabIndex = 218;
            this.label15.Text = "Número Factura";
            // 
            // dgvEquiposCodigos
            // 
            this.dgvEquiposCodigos.Location = new System.Drawing.Point(25, 111);
            this.dgvEquiposCodigos.MainView = this.vistaCodigo;
            this.dgvEquiposCodigos.Name = "dgvEquiposCodigos";
            this.dgvEquiposCodigos.Size = new System.Drawing.Size(1228, 392);
            this.dgvEquiposCodigos.TabIndex = 229;
            this.dgvEquiposCodigos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaCodigo});
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
            this.ObservacionXLevantar,
            this.Error});
            this.vistaCodigo.GridControl = this.dgvEquiposCodigos;
            this.vistaCodigo.Name = "vistaCodigo";
            this.vistaCodigo.OptionsCustomization.AllowColumnMoving = false;
            this.vistaCodigo.OptionsMenu.EnableColumnMenu = false;
            this.vistaCodigo.OptionsView.ColumnAutoWidth = false;
            this.vistaCodigo.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaCodigo.OptionsView.ShowAutoFilterRow = true;
            this.vistaCodigo.OptionsView.ShowGroupPanel = false;
            // 
            // CodigoEquipo
            // 
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
            this.ObservacionXLevantar.Caption = "Observación por levantar";
            this.ObservacionXLevantar.FieldName = "ObservacionXLevantar";
            this.ObservacionXLevantar.MinWidth = 40;
            this.ObservacionXLevantar.Name = "ObservacionXLevantar";
            this.ObservacionXLevantar.OptionsColumn.AllowEdit = false;
            this.ObservacionXLevantar.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ObservacionXLevantar.Visible = true;
            this.ObservacionXLevantar.VisibleIndex = 14;
            this.ObservacionXLevantar.Width = 300;
            // 
            // Error
            // 
            this.Error.Caption = "Error";
            this.Error.FieldName = "Error";
            this.Error.MinWidth = 40;
            this.Error.Name = "Error";
            this.Error.OptionsColumn.AllowEdit = false;
            this.Error.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Error.Visible = true;
            this.Error.VisibleIndex = 15;
            this.Error.Width = 100;
            // 
            // btnBuscarV
            // 
            this.btnBuscarV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarV.Location = new System.Drawing.Point(981, 29);
            this.btnBuscarV.Name = "btnBuscarV";
            this.btnBuscarV.Size = new System.Drawing.Size(75, 41);
            this.btnBuscarV.TabIndex = 233;
            this.btnBuscarV.Text = "Buscar V";
            this.btnBuscarV.UseVisualStyleBackColor = true;
            this.btnBuscarV.Click += new System.EventHandler(this.btnBuscarV_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.Location = new System.Drawing.Point(1079, 29);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 41);
            this.btnValidar.TabIndex = 232;
            this.btnValidar.Text = "Validar Factura";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.Location = new System.Drawing.Point(1178, 29);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 41);
            this.btnGrabar.TabIndex = 231;
            this.btnGrabar.Text = "Grabar Factura";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // giftCarga
            // 
            this.giftCarga.Location = new System.Drawing.Point(577, 19);
            this.giftCarga.Name = "giftCarga";
            this.giftCarga.Size = new System.Drawing.Size(74, 67);
            this.giftCarga.TabIndex = 234;
            this.giftCarga.TabStop = false;
            // 
            // frmProcesoFacturaTransito
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 556);
            this.Controls.Add(this.giftCarga);
            this.Controls.Add(this.btnBuscarV);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvEquiposCodigos);
            this.Controls.Add(this.cmbFactura);
            this.Controls.Add(this.label15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoFacturaTransito";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura Transito";
            this.Load += new System.EventHandler(this.frmProcesoFacturaTransito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposCodigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFactura;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraGrid.GridControl dgvEquiposCodigos;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn FechaPago;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn FechaIniPago;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFinPago;
        private DevExpress.XtraGrid.Columns.GridColumn RucDni;
        private DevExpress.XtraGrid.Columns.GridColumn RazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn GuiaSalida;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroFactura;
        private DevExpress.XtraGrid.Columns.GridColumn TotalSoles;
        private DevExpress.XtraGrid.Columns.GridColumn TotalDolares;
        private DevExpress.XtraGrid.Columns.GridColumn CostoSoles;
        private DevExpress.XtraGrid.Columns.GridColumn CostoDolares;
        private DevExpress.XtraGrid.Columns.GridColumn ObservacionXLevantar;
        private System.Windows.Forms.Button btnBuscarV;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnGrabar;
        public System.Windows.Forms.PictureBox giftCarga;
        private DevExpress.XtraGrid.Columns.GridColumn CantidadEquipos;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroOC;
        private DevExpress.XtraGrid.Columns.GridColumn Error;
    }
}
﻿namespace Apolo
{
    partial class frmProcesoSubirFacturas
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
            this.btnSubirFactura = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.dgvLaptops = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FechaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaIniPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaFinPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RucDni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroDocRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumeroFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VentaSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UtilidadSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UtilidadDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CantidadEquipos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ObservacionXLevantar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.giftCarga = new System.Windows.Forms.PictureBox();
            this.btnBuscarV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubirFactura
            // 
            this.btnSubirFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirFactura.Location = new System.Drawing.Point(883, 12);
            this.btnSubirFactura.Name = "btnSubirFactura";
            this.btnSubirFactura.Size = new System.Drawing.Size(75, 41);
            this.btnSubirFactura.TabIndex = 0;
            this.btnSubirFactura.Text = "Subir Factura";
            this.btnSubirFactura.UseVisualStyleBackColor = true;
            this.btnSubirFactura.Click += new System.EventHandler(this.btnSubirFactura_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabar.Location = new System.Drawing.Point(1182, 12);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 41);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar Factura";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.Location = new System.Drawing.Point(1083, 12);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 41);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar Factura";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // dgvLaptops
            // 
            this.dgvLaptops.Location = new System.Drawing.Point(12, 69);
            this.dgvLaptops.MainView = this.vista;
            this.dgvLaptops.Name = "dgvLaptops";
            this.dgvLaptops.Size = new System.Drawing.Size(1291, 452);
            this.dgvLaptops.TabIndex = 137;
            this.dgvLaptops.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista});
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
            this.FechaPago,
            this.TipoPago,
            this.CodigoLC,
            this.Descripcion,
            this.FechaIniPago,
            this.FechaFinPago,
            this.RucDni,
            this.RazonSocial,
            this.NumeroOC,
            this.NumeroDocRef,
            this.NumeroFactura,
            this.TotalSoles,
            this.TotalDolares,
            this.TipoCambio,
            this.VentaSoles,
            this.Proveedor,
            this.CostoSoles,
            this.CostoDolares,
            this.UtilidadSoles,
            this.UtilidadDolares,
            this.CantidadEquipos,
            this.ObservacionXLevantar});
            this.vista.GridControl = this.dgvLaptops;
            this.vista.Name = "vista";
            this.vista.OptionsBehavior.Editable = false;
            this.vista.OptionsCustomization.AllowColumnMoving = false;
            this.vista.OptionsMenu.EnableColumnMenu = false;
            this.vista.OptionsView.ColumnAutoWidth = false;
            this.vista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            this.vista.OptionsView.ShowGroupPanel = false;
            // 
            // FechaPago
            // 
            this.FechaPago.Caption = "Fecha Pago";
            this.FechaPago.FieldName = "FechaPago";
            this.FechaPago.MinWidth = 40;
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.FechaPago.Visible = true;
            this.FechaPago.VisibleIndex = 0;
            this.FechaPago.Width = 100;
            // 
            // TipoPago
            // 
            this.TipoPago.Caption = "Tipo Pago";
            this.TipoPago.FieldName = "TipoPago";
            this.TipoPago.MinWidth = 40;
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TipoPago.Visible = true;
            this.TipoPago.VisibleIndex = 1;
            this.TipoPago.Width = 100;
            // 
            // CodigoLC
            // 
            this.CodigoLC.Caption = "Código Equipo";
            this.CodigoLC.FieldName = "CodigoLC";
            this.CodigoLC.MinWidth = 40;
            this.CodigoLC.Name = "CodigoLC";
            this.CodigoLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CodigoLC.Visible = true;
            this.CodigoLC.VisibleIndex = 2;
            this.CodigoLC.Width = 100;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripción";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.MinWidth = 40;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 3;
            this.Descripcion.Width = 100;
            // 
            // FechaIniPago
            // 
            this.FechaIniPago.Caption = "Fecha Inicio Pago";
            this.FechaIniPago.FieldName = "FechaIniPago";
            this.FechaIniPago.MinWidth = 40;
            this.FechaIniPago.Name = "FechaIniPago";
            this.FechaIniPago.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.FechaIniPago.Visible = true;
            this.FechaIniPago.VisibleIndex = 4;
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
            this.FechaFinPago.VisibleIndex = 5;
            this.FechaFinPago.Width = 100;
            // 
            // RucDni
            // 
            this.RucDni.Caption = "Ruc Dni";
            this.RucDni.FieldName = "RucDni";
            this.RucDni.MinWidth = 40;
            this.RucDni.Name = "RucDni";
            this.RucDni.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.RucDni.Visible = true;
            this.RucDni.VisibleIndex = 6;
            this.RucDni.Width = 100;
            // 
            // RazonSocial
            // 
            this.RazonSocial.Caption = "Razon Social";
            this.RazonSocial.FieldName = "RazonSocial";
            this.RazonSocial.MinWidth = 40;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.RazonSocial.Visible = true;
            this.RazonSocial.VisibleIndex = 7;
            this.RazonSocial.Width = 100;
            // 
            // NumeroOC
            // 
            this.NumeroOC.Caption = "Número OC";
            this.NumeroOC.FieldName = "NumeroOC";
            this.NumeroOC.MinWidth = 40;
            this.NumeroOC.Name = "NumeroOC";
            this.NumeroOC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NumeroOC.Visible = true;
            this.NumeroOC.VisibleIndex = 8;
            this.NumeroOC.Width = 100;
            // 
            // NumeroDocRef
            // 
            this.NumeroDocRef.Caption = "Guía Salida";
            this.NumeroDocRef.FieldName = "NumeroDocRef";
            this.NumeroDocRef.MinWidth = 40;
            this.NumeroDocRef.Name = "NumeroDocRef";
            this.NumeroDocRef.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NumeroDocRef.Visible = true;
            this.NumeroDocRef.VisibleIndex = 9;
            this.NumeroDocRef.Width = 100;
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.Caption = "Número Factura";
            this.NumeroFactura.FieldName = "NumeroFactura";
            this.NumeroFactura.MinWidth = 40;
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NumeroFactura.Visible = true;
            this.NumeroFactura.VisibleIndex = 10;
            this.NumeroFactura.Width = 100;
            // 
            // TotalSoles
            // 
            this.TotalSoles.Caption = "Total Soles";
            this.TotalSoles.FieldName = "TotalSoles";
            this.TotalSoles.MinWidth = 40;
            this.TotalSoles.Name = "TotalSoles";
            this.TotalSoles.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TotalSoles.Visible = true;
            this.TotalSoles.VisibleIndex = 11;
            this.TotalSoles.Width = 100;
            // 
            // TotalDolares
            // 
            this.TotalDolares.Caption = "Total Dolares";
            this.TotalDolares.FieldName = "TotalDolares";
            this.TotalDolares.MinWidth = 40;
            this.TotalDolares.Name = "TotalDolares";
            this.TotalDolares.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TotalDolares.Visible = true;
            this.TotalDolares.VisibleIndex = 12;
            this.TotalDolares.Width = 100;
            // 
            // TipoCambio
            // 
            this.TipoCambio.Caption = "Tipo Cambio";
            this.TipoCambio.FieldName = "TipoCambio";
            this.TipoCambio.MinWidth = 40;
            this.TipoCambio.Name = "TipoCambio";
            this.TipoCambio.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TipoCambio.Visible = true;
            this.TipoCambio.VisibleIndex = 13;
            this.TipoCambio.Width = 100;
            // 
            // VentaSoles
            // 
            this.VentaSoles.Caption = "Venta Soles";
            this.VentaSoles.FieldName = "VentaSoles";
            this.VentaSoles.MinWidth = 40;
            this.VentaSoles.Name = "VentaSoles";
            this.VentaSoles.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.VentaSoles.Visible = true;
            this.VentaSoles.VisibleIndex = 14;
            this.VentaSoles.Width = 100;
            // 
            // Proveedor
            // 
            this.Proveedor.Caption = "Proveedor";
            this.Proveedor.FieldName = "Proveedor";
            this.Proveedor.MinWidth = 40;
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Proveedor.Visible = true;
            this.Proveedor.VisibleIndex = 15;
            this.Proveedor.Width = 100;
            // 
            // CostoSoles
            // 
            this.CostoSoles.Caption = "Costo Soles";
            this.CostoSoles.FieldName = "CostoSoles";
            this.CostoSoles.MinWidth = 40;
            this.CostoSoles.Name = "CostoSoles";
            this.CostoSoles.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CostoSoles.Visible = true;
            this.CostoSoles.VisibleIndex = 16;
            this.CostoSoles.Width = 100;
            // 
            // CostoDolares
            // 
            this.CostoDolares.Caption = "Costo Dolares";
            this.CostoDolares.FieldName = "CostoDolares";
            this.CostoDolares.MinWidth = 40;
            this.CostoDolares.Name = "CostoDolares";
            this.CostoDolares.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CostoDolares.Visible = true;
            this.CostoDolares.VisibleIndex = 17;
            this.CostoDolares.Width = 100;
            // 
            // UtilidadSoles
            // 
            this.UtilidadSoles.Caption = "Utilidad Soles";
            this.UtilidadSoles.FieldName = "UtilidadSoles";
            this.UtilidadSoles.MinWidth = 40;
            this.UtilidadSoles.Name = "UtilidadSoles";
            this.UtilidadSoles.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.UtilidadSoles.Visible = true;
            this.UtilidadSoles.VisibleIndex = 18;
            this.UtilidadSoles.Width = 100;
            // 
            // UtilidadDolares
            // 
            this.UtilidadDolares.Caption = "Utilidad Dolares";
            this.UtilidadDolares.FieldName = "UtilidadDolares";
            this.UtilidadDolares.MinWidth = 40;
            this.UtilidadDolares.Name = "UtilidadDolares";
            this.UtilidadDolares.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.UtilidadDolares.Visible = true;
            this.UtilidadDolares.VisibleIndex = 19;
            this.UtilidadDolares.Width = 100;
            // 
            // CantidadEquipos
            // 
            this.CantidadEquipos.Caption = "Cantidad Equipos";
            this.CantidadEquipos.FieldName = "CantidadEquipos";
            this.CantidadEquipos.MinWidth = 40;
            this.CantidadEquipos.Name = "CantidadEquipos";
            this.CantidadEquipos.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.CantidadEquipos.Visible = true;
            this.CantidadEquipos.VisibleIndex = 20;
            this.CantidadEquipos.Width = 100;
            // 
            // ObservacionXLevantar
            // 
            this.ObservacionXLevantar.Caption = "Observación por levantar";
            this.ObservacionXLevantar.FieldName = "ObservacionXLevantar";
            this.ObservacionXLevantar.MinWidth = 40;
            this.ObservacionXLevantar.Name = "ObservacionXLevantar";
            this.ObservacionXLevantar.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ObservacionXLevantar.Visible = true;
            this.ObservacionXLevantar.VisibleIndex = 21;
            this.ObservacionXLevantar.Width = 300;
            // 
            // giftCarga
            // 
            this.giftCarga.Location = new System.Drawing.Point(456, 171);
            this.giftCarga.Name = "giftCarga";
            this.giftCarga.Size = new System.Drawing.Size(413, 310);
            this.giftCarga.TabIndex = 141;
            this.giftCarga.TabStop = false;
            // 
            // btnBuscarV
            // 
            this.btnBuscarV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarV.Location = new System.Drawing.Point(985, 12);
            this.btnBuscarV.Name = "btnBuscarV";
            this.btnBuscarV.Size = new System.Drawing.Size(75, 41);
            this.btnBuscarV.TabIndex = 142;
            this.btnBuscarV.Text = "Buscar V";
            this.btnBuscarV.UseVisualStyleBackColor = true;
            this.btnBuscarV.Click += new System.EventHandler(this.btnBuscarV_Click);
            // 
            // frmProcesoSubirFacturas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1315, 533);
            this.Controls.Add(this.btnBuscarV);
            this.Controls.Add(this.giftCarga);
            this.Controls.Add(this.dgvLaptops);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSubirFactura);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoSubirFacturas";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas Sisgeco";
            this.Load += new System.EventHandler(this.frmProcesoSubirFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubirFactura;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnValidar;
        private DevExpress.XtraGrid.GridControl dgvLaptops;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraGrid.Columns.GridColumn FechaPago;
        private DevExpress.XtraGrid.Columns.GridColumn TipoPago;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoLC;
        private DevExpress.XtraGrid.Columns.GridColumn FechaIniPago;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFinPago;
        private DevExpress.XtraGrid.Columns.GridColumn RucDni;
        private DevExpress.XtraGrid.Columns.GridColumn RazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroOC;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroDocRef;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroFactura;
        private DevExpress.XtraGrid.Columns.GridColumn TotalSoles;
        private DevExpress.XtraGrid.Columns.GridColumn TotalDolares;
        private DevExpress.XtraGrid.Columns.GridColumn TipoCambio;
        private DevExpress.XtraGrid.Columns.GridColumn VentaSoles;
        private DevExpress.XtraGrid.Columns.GridColumn CostoSoles;
        private DevExpress.XtraGrid.Columns.GridColumn CostoDolares;
        private DevExpress.XtraGrid.Columns.GridColumn UtilidadSoles;
        private DevExpress.XtraGrid.Columns.GridColumn UtilidadDolares;
        private DevExpress.XtraGrid.Columns.GridColumn ObservacionXLevantar;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Proveedor;
        public System.Windows.Forms.PictureBox giftCarga;
        private System.Windows.Forms.Button btnBuscarV;
        private DevExpress.XtraGrid.Columns.GridColumn CantidadEquipos;
    }
}
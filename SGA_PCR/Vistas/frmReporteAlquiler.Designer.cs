namespace Apolo
{
    partial class frmReporteAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteAlquiler));
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FueDevuelto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaDevolucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuiaDevolucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvAlquiler = new DevExpress.XtraGrid.GridControl();
            this.vistaAlquiler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RucDni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FecSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FecIniContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FecFinContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuiaSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CorteAlquiler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaCambio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlAlquileres = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblAlquileres = new System.Windows.Forms.Label();
            this.idSalidaDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UltimaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FecInicioFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FecFinFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaEmisionFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAlquiler)).BeginInit();
            this.pnlAlquileres.SuspendLayout();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Estado.AppearanceHeader.Options.UseBackColor = true;
            this.Estado.Caption = "Id Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 150;
            // 
            // FueDevuelto
            // 
            this.FueDevuelto.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FueDevuelto.AppearanceHeader.Options.UseBackColor = true;
            this.FueDevuelto.Caption = "Fue Devuelto";
            this.FueDevuelto.FieldName = "FueDevuelto";
            this.FueDevuelto.Name = "FueDevuelto";
            this.FueDevuelto.Visible = true;
            this.FueDevuelto.VisibleIndex = 8;
            this.FueDevuelto.Width = 150;
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaDevolucion.AppearanceHeader.Options.UseBackColor = true;
            this.FechaDevolucion.Caption = "Fecha Devolucion";
            this.FechaDevolucion.FieldName = "FechaDevolucion";
            this.FechaDevolucion.Name = "FechaDevolucion";
            this.FechaDevolucion.Visible = true;
            this.FechaDevolucion.VisibleIndex = 10;
            this.FechaDevolucion.Width = 150;
            // 
            // GuiaDevolucion
            // 
            this.GuiaDevolucion.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GuiaDevolucion.AppearanceHeader.Options.UseBackColor = true;
            this.GuiaDevolucion.Caption = "Guia Devolucion";
            this.GuiaDevolucion.FieldName = "GuiaDevolucion";
            this.GuiaDevolucion.Name = "GuiaDevolucion";
            this.GuiaDevolucion.Visible = true;
            this.GuiaDevolucion.VisibleIndex = 11;
            this.GuiaDevolucion.Width = 150;
            // 
            // dgvAlquiler
            // 
            this.dgvAlquiler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlquiler.Location = new System.Drawing.Point(12, 119);
            this.dgvAlquiler.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvAlquiler.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvAlquiler.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvAlquiler.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvAlquiler.MainView = this.vistaAlquiler;
            this.dgvAlquiler.Name = "dgvAlquiler";
            this.dgvAlquiler.Size = new System.Drawing.Size(915, 378);
            this.dgvAlquiler.TabIndex = 137;
            this.dgvAlquiler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaAlquiler});
            // 
            // vistaAlquiler
            // 
            this.vistaAlquiler.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaAlquiler.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaAlquiler.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaAlquiler.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaAlquiler.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaAlquiler.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaAlquiler.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaAlquiler.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaAlquiler.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaAlquiler.Appearance.Row.Options.UseFont = true;
            this.vistaAlquiler.Appearance.Row.Options.UseForeColor = true;
            this.vistaAlquiler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdSalida,
            this.IdCliente,
            this.IdSucursal,
            this.RucDni,
            this.Cliente,
            this.IdLC,
            this.Codigo,
            this.FecSalida,
            this.FecIniContrato,
            this.FecFinContrato,
            this.GuiaSalida,
            this.Estado,
            this.NombreEstado,
            this.FueDevuelto,
            this.FechaDevolucion,
            this.GuiaDevolucion,
            this.CorteAlquiler,
            this.FechaCambio,
            this.idSalidaDet,
            this.UltimaFactura,
            this.FecInicioFactura,
            this.FecFinFactura,
            this.FechaEmisionFactura});
            this.vistaAlquiler.GridControl = this.dgvAlquiler;
            this.vistaAlquiler.Name = "vistaAlquiler";
            this.vistaAlquiler.OptionsBehavior.Editable = false;
            this.vistaAlquiler.OptionsView.ColumnAutoWidth = false;
            this.vistaAlquiler.OptionsView.ShowAutoFilterRow = true;
            this.vistaAlquiler.OptionsView.ShowIndicator = false;
            // 
            // IdSalida
            // 
            this.IdSalida.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdSalida.AppearanceHeader.Options.UseBackColor = true;
            this.IdSalida.Caption = "Id Salida";
            this.IdSalida.FieldName = "IdSalida";
            this.IdSalida.Name = "IdSalida";
            this.IdSalida.Width = 150;
            // 
            // IdCliente
            // 
            this.IdCliente.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdCliente.AppearanceHeader.Options.UseBackColor = true;
            this.IdCliente.Caption = "IdCliente";
            this.IdCliente.FieldName = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Width = 150;
            // 
            // IdSucursal
            // 
            this.IdSucursal.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdSucursal.AppearanceHeader.Options.UseBackColor = true;
            this.IdSucursal.Caption = "IdSucursal";
            this.IdSucursal.FieldName = "IdSucursal";
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.Width = 150;
            // 
            // RucDni
            // 
            this.RucDni.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RucDni.AppearanceHeader.Options.UseBackColor = true;
            this.RucDni.Caption = "Ruc Cliente";
            this.RucDni.FieldName = "RucDni";
            this.RucDni.Name = "RucDni";
            this.RucDni.Visible = true;
            this.RucDni.VisibleIndex = 0;
            this.RucDni.Width = 150;
            // 
            // Cliente
            // 
            this.Cliente.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cliente.AppearanceHeader.Options.UseBackColor = true;
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 1;
            this.Cliente.Width = 150;
            // 
            // IdLC
            // 
            this.IdLC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdLC.AppearanceHeader.Options.UseBackColor = true;
            this.IdLC.Caption = "IdLC";
            this.IdLC.FieldName = "IdLC";
            this.IdLC.Name = "IdLC";
            this.IdLC.Width = 150;
            // 
            // Codigo
            // 
            this.Codigo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Codigo.AppearanceHeader.Options.UseBackColor = true;
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 2;
            this.Codigo.Width = 150;
            // 
            // FecSalida
            // 
            this.FecSalida.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FecSalida.AppearanceHeader.Options.UseBackColor = true;
            this.FecSalida.Caption = "Fecha Traslado";
            this.FecSalida.FieldName = "FecSalida";
            this.FecSalida.Name = "FecSalida";
            this.FecSalida.Visible = true;
            this.FecSalida.VisibleIndex = 3;
            this.FecSalida.Width = 150;
            // 
            // FecIniContrato
            // 
            this.FecIniContrato.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FecIniContrato.AppearanceHeader.Options.UseBackColor = true;
            this.FecIniContrato.Caption = "Inicio Plazo Alquiler";
            this.FecIniContrato.FieldName = "FecIniContrato";
            this.FecIniContrato.Name = "FecIniContrato";
            this.FecIniContrato.Visible = true;
            this.FecIniContrato.VisibleIndex = 4;
            this.FecIniContrato.Width = 150;
            // 
            // FecFinContrato
            // 
            this.FecFinContrato.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FecFinContrato.AppearanceHeader.Options.UseBackColor = true;
            this.FecFinContrato.Caption = "Fin Plazo Alquiler";
            this.FecFinContrato.FieldName = "FecFinContrato";
            this.FecFinContrato.Name = "FecFinContrato";
            this.FecFinContrato.Visible = true;
            this.FecFinContrato.VisibleIndex = 5;
            this.FecFinContrato.Width = 150;
            // 
            // GuiaSalida
            // 
            this.GuiaSalida.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GuiaSalida.AppearanceHeader.Options.UseBackColor = true;
            this.GuiaSalida.Caption = "Guia Salida";
            this.GuiaSalida.FieldName = "GuiaSalida";
            this.GuiaSalida.Name = "GuiaSalida";
            this.GuiaSalida.Visible = true;
            this.GuiaSalida.VisibleIndex = 6;
            this.GuiaSalida.Width = 150;
            // 
            // NombreEstado
            // 
            this.NombreEstado.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NombreEstado.AppearanceHeader.Options.UseBackColor = true;
            this.NombreEstado.Caption = "Estado";
            this.NombreEstado.FieldName = "NombreEstado";
            this.NombreEstado.Name = "NombreEstado";
            this.NombreEstado.Visible = true;
            this.NombreEstado.VisibleIndex = 7;
            this.NombreEstado.Width = 150;
            // 
            // CorteAlquiler
            // 
            this.CorteAlquiler.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CorteAlquiler.AppearanceHeader.Options.UseBackColor = true;
            this.CorteAlquiler.Caption = "Corte Alquiler";
            this.CorteAlquiler.FieldName = "CorteAlquiler";
            this.CorteAlquiler.Name = "CorteAlquiler";
            this.CorteAlquiler.Visible = true;
            this.CorteAlquiler.VisibleIndex = 12;
            this.CorteAlquiler.Width = 150;
            // 
            // FechaCambio
            // 
            this.FechaCambio.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaCambio.AppearanceHeader.Options.UseBackColor = true;
            this.FechaCambio.Caption = "Fecha Cambio";
            this.FechaCambio.FieldName = "FechaCambio";
            this.FechaCambio.Name = "FechaCambio";
            this.FechaCambio.Visible = true;
            this.FechaCambio.VisibleIndex = 9;
            this.FechaCambio.Width = 150;
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
            this.btnExportar.Location = new System.Drawing.Point(12, 525);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 138;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // pnlAlquileres
            // 
            this.pnlAlquileres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlAlquileres.Controls.Add(this.btnCerrar);
            this.pnlAlquileres.Controls.Add(this.lblAlquileres);
            this.pnlAlquileres.Location = new System.Drawing.Point(2, 2);
            this.pnlAlquileres.Name = "pnlAlquileres";
            this.pnlAlquileres.Size = new System.Drawing.Size(939, 49);
            this.pnlAlquileres.TabIndex = 139;
            this.pnlAlquileres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlAlquileres_MouseMove);
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
            this.btnCerrar.Location = new System.Drawing.Point(885, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(51, 38);
            this.btnCerrar.TabIndex = 153;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblAlquileres
            // 
            this.lblAlquileres.AutoSize = true;
            this.lblAlquileres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlquileres.ForeColor = System.Drawing.Color.White;
            this.lblAlquileres.Location = new System.Drawing.Point(383, 7);
            this.lblAlquileres.Name = "lblAlquileres";
            this.lblAlquileres.Size = new System.Drawing.Size(195, 31);
            this.lblAlquileres.TabIndex = 152;
            this.lblAlquileres.Text = "ALQUILERES";
            this.lblAlquileres.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlAlquileres_MouseMove);
            // 
            // idSalidaDet
            // 
            this.idSalidaDet.Caption = "idSalidaDet";
            this.idSalidaDet.FieldName = "idSalidaDet";
            this.idSalidaDet.Name = "idSalidaDet";
            this.idSalidaDet.Visible = true;
            this.idSalidaDet.VisibleIndex = 13;
            this.idSalidaDet.Width = 100;
            // 
            // UltimaFactura
            // 
            this.UltimaFactura.Caption = "UltimaFactura";
            this.UltimaFactura.FieldName = "UltimaFactura";
            this.UltimaFactura.Name = "UltimaFactura";
            this.UltimaFactura.Visible = true;
            this.UltimaFactura.VisibleIndex = 14;
            this.UltimaFactura.Width = 150;
            // 
            // FecInicioFactura
            // 
            this.FecInicioFactura.Caption = "FecInicioFactura";
            this.FecInicioFactura.FieldName = "FecInicioFactura";
            this.FecInicioFactura.Name = "FecInicioFactura";
            this.FecInicioFactura.Visible = true;
            this.FecInicioFactura.VisibleIndex = 15;
            this.FecInicioFactura.Width = 150;
            // 
            // FecFinFactura
            // 
            this.FecFinFactura.Caption = "FecFinFactura";
            this.FecFinFactura.FieldName = "FecFinFactura";
            this.FecFinFactura.Name = "FecFinFactura";
            this.FecFinFactura.Visible = true;
            this.FecFinFactura.VisibleIndex = 16;
            this.FecFinFactura.Width = 150;
            // 
            // FechaEmisionFactura
            // 
            this.FechaEmisionFactura.Caption = "FechaEmisionFactura";
            this.FechaEmisionFactura.FieldName = "FechaEmisionFactura";
            this.FechaEmisionFactura.Name = "FechaEmisionFactura";
            this.FechaEmisionFactura.Visible = true;
            this.FechaEmisionFactura.VisibleIndex = 17;
            this.FechaEmisionFactura.Width = 150;
            // 
            // frmReporteAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(939, 623);
            this.Controls.Add(this.pnlAlquileres);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvAlquiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Alquiler";
            this.Load += new System.EventHandler(this.frmReporteAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlquiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaAlquiler)).EndInit();
            this.pnlAlquileres.ResumeLayout(false);
            this.pnlAlquileres.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvAlquiler;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaAlquiler;
        private System.Windows.Forms.Button btnExportar;
        private DevExpress.XtraGrid.Columns.GridColumn IdSalida;
        private DevExpress.XtraGrid.Columns.GridColumn IdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn IdSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn RucDni;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn IdLC;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn FecSalida;
        private DevExpress.XtraGrid.Columns.GridColumn FecIniContrato;
        private DevExpress.XtraGrid.Columns.GridColumn FecFinContrato;
        private DevExpress.XtraGrid.Columns.GridColumn GuiaSalida;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn NombreEstado;
        private DevExpress.XtraGrid.Columns.GridColumn FueDevuelto;
        private DevExpress.XtraGrid.Columns.GridColumn CorteAlquiler;
        private System.Windows.Forms.Panel pnlAlquileres;
        private System.Windows.Forms.Label lblAlquileres;
        private System.Windows.Forms.Button btnCerrar;
        private DevExpress.XtraGrid.Columns.GridColumn FechaDevolucion;
        private DevExpress.XtraGrid.Columns.GridColumn GuiaDevolucion;
        private DevExpress.XtraGrid.Columns.GridColumn FechaCambio;
        private DevExpress.XtraGrid.Columns.GridColumn idSalidaDet;
        private DevExpress.XtraGrid.Columns.GridColumn UltimaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FecInicioFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FecFinFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaEmisionFactura;
    }
}
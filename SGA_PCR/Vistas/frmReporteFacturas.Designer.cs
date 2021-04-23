namespace Apolo
{
    partial class frmReporteFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteFacturas));
            this.dgvFacturas = new DevExpress.XtraGrid.GridControl();
            this.vistaFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NumeroFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaInicioFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaFinFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaEmisionFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RucCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuiaSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoDolares = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UBSoles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EstadoFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlFacturas = new System.Windows.Forms.Panel();
            this.lblFacturas = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFacturas)).BeginInit();
            this.pnlFacturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturas.Location = new System.Drawing.Point(12, 97);
            this.dgvFacturas.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvFacturas.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvFacturas.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvFacturas.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvFacturas.MainView = this.vistaFacturas;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(1212, 366);
            this.dgvFacturas.TabIndex = 136;
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
            this.NumeroFactura,
            this.FechaInicioFactura,
            this.FechaFinFactura,
            this.FechaEmisionFactura,
            this.Cliente,
            this.RucCliente,
            this.CodigoEquipo,
            this.GuiaSalida,
            this.TotalSoles,
            this.TotalDolares,
            this.CostoSoles,
            this.CostoDolares,
            this.UBSoles,
            this.EstadoFactura});
            this.vistaFacturas.GridControl = this.dgvFacturas;
            this.vistaFacturas.Name = "vistaFacturas";
            this.vistaFacturas.OptionsBehavior.Editable = false;
            this.vistaFacturas.OptionsView.ColumnAutoWidth = false;
            this.vistaFacturas.OptionsView.ShowAutoFilterRow = true;
            this.vistaFacturas.OptionsView.ShowIndicator = false;
            this.vistaFacturas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vistaFacturas_KeyUp);
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NumeroFactura.AppearanceHeader.Options.UseBackColor = true;
            this.NumeroFactura.Caption = "Numero Factura";
            this.NumeroFactura.FieldName = "NumeroFactura";
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.Visible = true;
            this.NumeroFactura.VisibleIndex = 0;
            this.NumeroFactura.Width = 150;
            // 
            // FechaInicioFactura
            // 
            this.FechaInicioFactura.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaInicioFactura.AppearanceHeader.Options.UseBackColor = true;
            this.FechaInicioFactura.Caption = "Fecha Inicio Factura";
            this.FechaInicioFactura.FieldName = "FechaInicioFactura";
            this.FechaInicioFactura.Name = "FechaInicioFactura";
            this.FechaInicioFactura.Visible = true;
            this.FechaInicioFactura.VisibleIndex = 1;
            this.FechaInicioFactura.Width = 150;
            // 
            // FechaFinFactura
            // 
            this.FechaFinFactura.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaFinFactura.AppearanceHeader.Options.UseBackColor = true;
            this.FechaFinFactura.Caption = "Fecha Fin Factura";
            this.FechaFinFactura.FieldName = "FechaFinFactura";
            this.FechaFinFactura.Name = "FechaFinFactura";
            this.FechaFinFactura.Visible = true;
            this.FechaFinFactura.VisibleIndex = 2;
            this.FechaFinFactura.Width = 150;
            // 
            // FechaEmisionFactura
            // 
            this.FechaEmisionFactura.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaEmisionFactura.AppearanceHeader.Options.UseBackColor = true;
            this.FechaEmisionFactura.Caption = "Fecha Emision Factura";
            this.FechaEmisionFactura.FieldName = "FechaEmisionFactura";
            this.FechaEmisionFactura.Name = "FechaEmisionFactura";
            this.FechaEmisionFactura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaEmisionFactura.Visible = true;
            this.FechaEmisionFactura.VisibleIndex = 3;
            this.FechaEmisionFactura.Width = 150;
            // 
            // Cliente
            // 
            this.Cliente.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cliente.AppearanceHeader.Options.UseBackColor = true;
            this.Cliente.Caption = "Cliente";
            this.Cliente.FieldName = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Visible = true;
            this.Cliente.VisibleIndex = 4;
            this.Cliente.Width = 150;
            // 
            // RucCliente
            // 
            this.RucCliente.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RucCliente.AppearanceHeader.Options.UseBackColor = true;
            this.RucCliente.Caption = "Ruc Cliente";
            this.RucCliente.FieldName = "RucCliente";
            this.RucCliente.Name = "RucCliente";
            this.RucCliente.Visible = true;
            this.RucCliente.VisibleIndex = 5;
            this.RucCliente.Width = 150;
            // 
            // CodigoEquipo
            // 
            this.CodigoEquipo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CodigoEquipo.AppearanceHeader.Options.UseBackColor = true;
            this.CodigoEquipo.Caption = "Codigo Equipo";
            this.CodigoEquipo.FieldName = "CodigoEquipo";
            this.CodigoEquipo.Name = "CodigoEquipo";
            this.CodigoEquipo.Visible = true;
            this.CodigoEquipo.VisibleIndex = 6;
            this.CodigoEquipo.Width = 150;
            // 
            // GuiaSalida
            // 
            this.GuiaSalida.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GuiaSalida.AppearanceHeader.Options.UseBackColor = true;
            this.GuiaSalida.Caption = "Guia Salida";
            this.GuiaSalida.FieldName = "GuiaSalida";
            this.GuiaSalida.Name = "GuiaSalida";
            this.GuiaSalida.Visible = true;
            this.GuiaSalida.VisibleIndex = 7;
            this.GuiaSalida.Width = 100;
            // 
            // TotalSoles
            // 
            this.TotalSoles.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TotalSoles.AppearanceHeader.Options.UseBackColor = true;
            this.TotalSoles.Caption = "Venta Soles";
            this.TotalSoles.FieldName = "TotalSoles";
            this.TotalSoles.Name = "TotalSoles";
            this.TotalSoles.Visible = true;
            this.TotalSoles.VisibleIndex = 8;
            this.TotalSoles.Width = 100;
            // 
            // TotalDolares
            // 
            this.TotalDolares.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TotalDolares.AppearanceHeader.Options.UseBackColor = true;
            this.TotalDolares.Caption = "Venta Dolares";
            this.TotalDolares.FieldName = "TotalDolares";
            this.TotalDolares.Name = "TotalDolares";
            this.TotalDolares.Visible = true;
            this.TotalDolares.VisibleIndex = 9;
            this.TotalDolares.Width = 100;
            // 
            // CostoSoles
            // 
            this.CostoSoles.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CostoSoles.AppearanceHeader.Options.UseBackColor = true;
            this.CostoSoles.Caption = "Costo Soles";
            this.CostoSoles.FieldName = "CostoSoles";
            this.CostoSoles.Name = "CostoSoles";
            this.CostoSoles.Visible = true;
            this.CostoSoles.VisibleIndex = 10;
            this.CostoSoles.Width = 100;
            // 
            // CostoDolares
            // 
            this.CostoDolares.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CostoDolares.AppearanceHeader.Options.UseBackColor = true;
            this.CostoDolares.Caption = "Costo Dolares";
            this.CostoDolares.FieldName = "CostoDolares";
            this.CostoDolares.Name = "CostoDolares";
            this.CostoDolares.Visible = true;
            this.CostoDolares.VisibleIndex = 11;
            this.CostoDolares.Width = 100;
            // 
            // UBSoles
            // 
            this.UBSoles.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UBSoles.AppearanceHeader.Options.UseBackColor = true;
            this.UBSoles.Caption = "Utilidad Bruta Soles";
            this.UBSoles.FieldName = "UBSoles";
            this.UBSoles.Name = "UBSoles";
            this.UBSoles.Visible = true;
            this.UBSoles.VisibleIndex = 12;
            this.UBSoles.Width = 150;
            // 
            // EstadoFactura
            // 
            this.EstadoFactura.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EstadoFactura.AppearanceHeader.Options.UseBackColor = true;
            this.EstadoFactura.Caption = "Estado Factura";
            this.EstadoFactura.FieldName = "EstadoFactura";
            this.EstadoFactura.Name = "EstadoFactura";
            this.EstadoFactura.Visible = true;
            this.EstadoFactura.VisibleIndex = 13;
            this.EstadoFactura.Width = 150;
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
            this.btnExportar.Location = new System.Drawing.Point(12, 495);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 137;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // pnlFacturas
            // 
            this.pnlFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlFacturas.Controls.Add(this.lblFacturas);
            this.pnlFacturas.Controls.Add(this.btnCerrar);
            this.pnlFacturas.Location = new System.Drawing.Point(2, 2);
            this.pnlFacturas.Name = "pnlFacturas";
            this.pnlFacturas.Size = new System.Drawing.Size(1231, 51);
            this.pnlFacturas.TabIndex = 138;
            this.pnlFacturas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFacturas_MouseMove);
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.ForeColor = System.Drawing.Color.White;
            this.lblFacturas.Location = new System.Drawing.Point(537, 13);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(170, 31);
            this.lblFacturas.TabIndex = 140;
            this.lblFacturas.Text = "FACTURAS";
            this.lblFacturas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFacturas_MouseMove);
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
            this.btnCerrar.Location = new System.Drawing.Point(1178, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 42);
            this.btnCerrar.TabIndex = 139;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1236, 590);
            this.Controls.Add(this.pnlFacturas);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteFacturas";
            this.Load += new System.EventHandler(this.frmReporteFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFacturas)).EndInit();
            this.pnlFacturas.ResumeLayout(false);
            this.pnlFacturas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaFacturas;
        private System.Windows.Forms.Button btnExportar;
        private DevExpress.XtraGrid.Columns.GridColumn NumeroFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaInicioFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFinFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaEmisionFactura;
        private DevExpress.XtraGrid.Columns.GridColumn Cliente;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoEquipo;
        private System.Windows.Forms.Panel pnlFacturas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn RucCliente;
        private DevExpress.XtraGrid.Columns.GridColumn EstadoFactura;
        private DevExpress.XtraGrid.Columns.GridColumn GuiaSalida;
        private DevExpress.XtraGrid.Columns.GridColumn TotalSoles;
        private DevExpress.XtraGrid.Columns.GridColumn TotalDolares;
        private DevExpress.XtraGrid.Columns.GridColumn CostoSoles;
        private DevExpress.XtraGrid.Columns.GridColumn CostoDolares;
        private DevExpress.XtraGrid.Columns.GridColumn UBSoles;
    }
}
namespace Apolo
{
    partial class frmReporteCorteAlquiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCorteAlquiler));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlCA = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLaptops = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FechaProceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MotivoCorte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaUltimaFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaCorteAlquiler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCorteAlquiler = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Anular = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAnular = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.giftCarga = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlCA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(882, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 232;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlCA
            // 
            this.pnlCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlCA.Controls.Add(this.btnCerrar);
            this.pnlCA.Controls.Add(this.label2);
            this.pnlCA.Location = new System.Drawing.Point(0, 0);
            this.pnlCA.Name = "pnlCA";
            this.pnlCA.Size = new System.Drawing.Size(914, 34);
            this.pnlCA.TabIndex = 194;
            this.pnlCA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCV_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(340, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 195;
            this.label2.Text = "CORTE ALQUILER";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCV_MouseMove);
            // 
            // dgvLaptops
            // 
            this.dgvLaptops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaptops.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White;
            this.dgvLaptops.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.dgvLaptops.Location = new System.Drawing.Point(12, 61);
            this.dgvLaptops.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvLaptops.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvLaptops.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvLaptops.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvLaptops.MainView = this.vista;
            this.dgvLaptops.Name = "dgvLaptops";
            this.dgvLaptops.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnAnular});
            this.dgvLaptops.Size = new System.Drawing.Size(889, 272);
            this.dgvLaptops.TabIndex = 195;
            this.dgvLaptops.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vista});
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
            this.FechaProceso,
            this.RUC,
            this.Codigo,
            this.MotivoCorte,
            this.FechaUltimaFactura,
            this.FechaCorteAlquiler,
            this.IdEstado,
            this.NombreEstado,
            this.IdCorteAlquiler,
            this.Anular});
            this.vista.GridControl = this.dgvLaptops;
            this.vista.Name = "vista";
            this.vista.OptionsSelection.MultiSelect = true;
            this.vista.OptionsView.ColumnAutoWidth = false;
            this.vista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // FechaProceso
            // 
            this.FechaProceso.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaProceso.AppearanceHeader.Options.UseBackColor = true;
            this.FechaProceso.Caption = "Fecha Proceso";
            this.FechaProceso.FieldName = "FechaProceso";
            this.FechaProceso.MinWidth = 40;
            this.FechaProceso.Name = "FechaProceso";
            this.FechaProceso.OptionsColumn.AllowEdit = false;
            this.FechaProceso.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaProceso.Visible = true;
            this.FechaProceso.VisibleIndex = 0;
            this.FechaProceso.Width = 100;
            // 
            // RUC
            // 
            this.RUC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RUC.AppearanceHeader.Options.UseBackColor = true;
            this.RUC.Caption = "RUC";
            this.RUC.FieldName = "RUC";
            this.RUC.MinWidth = 40;
            this.RUC.Name = "RUC";
            this.RUC.OptionsColumn.AllowEdit = false;
            this.RUC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.RUC.Visible = true;
            this.RUC.VisibleIndex = 1;
            this.RUC.Width = 100;
            // 
            // Codigo
            // 
            this.Codigo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Codigo.AppearanceHeader.Options.UseBackColor = true;
            this.Codigo.Caption = "Código";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.MinWidth = 40;
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 2;
            this.Codigo.Width = 140;
            // 
            // MotivoCorte
            // 
            this.MotivoCorte.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MotivoCorte.AppearanceHeader.Options.UseBackColor = true;
            this.MotivoCorte.Caption = "Motivo Corte";
            this.MotivoCorte.FieldName = "MotivoCorte";
            this.MotivoCorte.MinWidth = 40;
            this.MotivoCorte.Name = "MotivoCorte";
            this.MotivoCorte.OptionsColumn.AllowEdit = false;
            this.MotivoCorte.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MotivoCorte.Visible = true;
            this.MotivoCorte.VisibleIndex = 3;
            this.MotivoCorte.Width = 140;
            // 
            // FechaUltimaFactura
            // 
            this.FechaUltimaFactura.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaUltimaFactura.AppearanceHeader.Options.UseBackColor = true;
            this.FechaUltimaFactura.Caption = "Fecha Última Factura";
            this.FechaUltimaFactura.FieldName = "FechaUltimaFactura";
            this.FechaUltimaFactura.MinWidth = 40;
            this.FechaUltimaFactura.Name = "FechaUltimaFactura";
            this.FechaUltimaFactura.OptionsColumn.AllowEdit = false;
            this.FechaUltimaFactura.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaUltimaFactura.Visible = true;
            this.FechaUltimaFactura.VisibleIndex = 4;
            this.FechaUltimaFactura.Width = 100;
            // 
            // FechaCorteAlquiler
            // 
            this.FechaCorteAlquiler.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FechaCorteAlquiler.AppearanceHeader.Options.UseBackColor = true;
            this.FechaCorteAlquiler.Caption = "Fecha Corte Alquiler";
            this.FechaCorteAlquiler.FieldName = "FechaCorteAlquiler";
            this.FechaCorteAlquiler.MinWidth = 40;
            this.FechaCorteAlquiler.Name = "FechaCorteAlquiler";
            this.FechaCorteAlquiler.OptionsColumn.AllowEdit = false;
            this.FechaCorteAlquiler.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaCorteAlquiler.Visible = true;
            this.FechaCorteAlquiler.VisibleIndex = 5;
            this.FechaCorteAlquiler.Width = 100;
            // 
            // IdEstado
            // 
            this.IdEstado.Caption = "IdEstado";
            this.IdEstado.FieldName = "IdEstado";
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // NombreEstado
            // 
            this.NombreEstado.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NombreEstado.AppearanceHeader.Options.UseBackColor = true;
            this.NombreEstado.Caption = "Estado";
            this.NombreEstado.FieldName = "NombreEstado";
            this.NombreEstado.MinWidth = 40;
            this.NombreEstado.Name = "NombreEstado";
            this.NombreEstado.OptionsColumn.AllowEdit = false;
            this.NombreEstado.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NombreEstado.Visible = true;
            this.NombreEstado.VisibleIndex = 6;
            this.NombreEstado.Width = 100;
            // 
            // IdCorteAlquiler
            // 
            this.IdCorteAlquiler.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdCorteAlquiler.AppearanceHeader.Options.UseBackColor = true;
            this.IdCorteAlquiler.Caption = "IdCorteAlquiler";
            this.IdCorteAlquiler.FieldName = "IdCorteAlquiler";
            this.IdCorteAlquiler.MinWidth = 40;
            this.IdCorteAlquiler.Name = "IdCorteAlquiler";
            this.IdCorteAlquiler.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IdCorteAlquiler.Width = 100;
            // 
            // Anular
            // 
            this.Anular.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Anular.AppearanceHeader.Options.UseBackColor = true;
            this.Anular.Caption = "Anular";
            this.Anular.ColumnEdit = this.btnAnular;
            this.Anular.Name = "Anular";
            this.Anular.Visible = true;
            this.Anular.VisibleIndex = 7;
            // 
            // btnAnular
            // 
            this.btnAnular.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Appearance.Image")));
            this.btnAnular.Appearance.Options.UseImage = true;
            this.btnAnular.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnAnular.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAnular.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAnular_ButtonPressed);
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
            this.btnExportar.Location = new System.Drawing.Point(12, 363);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 63);
            this.btnExportar.TabIndex = 196;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(555, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 197;
            this.label1.Text = "CANTIDAD REGISTROS:";
            // 
            // giftCarga
            // 
            this.giftCarga.BackColor = System.Drawing.Color.White;
            this.giftCarga.Location = new System.Drawing.Point(301, 339);
            this.giftCarga.Name = "giftCarga";
            this.giftCarga.Size = new System.Drawing.Size(190, 138);
            this.giftCarga.TabIndex = 233;
            this.giftCarga.TabStop = false;
            // 
            // frmReporteCorteAlquiler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.giftCarga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.dgvLaptops);
            this.Controls.Add(this.pnlCA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReporteCorteAlquiler";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteCorteAlquiler";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlCA.ResumeLayout(false);
            this.pnlCA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAnular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giftCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlCA;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl dgvLaptops;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private System.Windows.Forms.Button btnExportar;
        private DevExpress.XtraGrid.Columns.GridColumn FechaProceso;
        private DevExpress.XtraGrid.Columns.GridColumn RUC;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn MotivoCorte;
        private DevExpress.XtraGrid.Columns.GridColumn FechaUltimaFactura;
        private DevExpress.XtraGrid.Columns.GridColumn FechaCorteAlquiler;
        private DevExpress.XtraGrid.Columns.GridColumn IdCorteAlquiler;
        private DevExpress.XtraGrid.Columns.GridColumn Anular;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAnular;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox giftCarga;
        private DevExpress.XtraGrid.Columns.GridColumn IdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn NombreEstado;
    }
}
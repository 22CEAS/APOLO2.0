namespace Apolo
{
    partial class frmProcesoCambioRazonSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoCambioRazonSocial));
            this.pnlD = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClienteNuevo = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtNroDocumentoNuevo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvLaptopsSeleccionados = new DevExpress.XtraGrid.GridControl();
            this.vistaLaptops = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TipoEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MarcaLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModeloLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSucursalNuevo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptopsSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaLaptops)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlD
            // 
            this.pnlD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlD.Controls.Add(this.btnCerrar);
            this.pnlD.Controls.Add(this.label5);
            this.pnlD.Location = new System.Drawing.Point(0, 0);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(604, 33);
            this.pnlD.TabIndex = 185;
            this.pnlD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlD_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(565, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 186;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(204, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 23);
            this.label5.TabIndex = 164;
            this.label5.Text = "CAMBIO RAZÓN SOCIAL";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlD_MouseMove);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(489, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 59);
            this.btnCancelar.TabIndex = 179;
            this.btnCancelar.Text = " Cancelar";
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
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(497, 200);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(67, 57);
            this.btnNuevo.TabIndex = 177;
            this.btnNuevo.Text = "  Nuevo";
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
            this.btnGrabar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrabar.Location = new System.Drawing.Point(492, 341);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(80, 58);
            this.btnGrabar.TabIndex = 176;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(13, 61);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(377, 21);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
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
            this.labelX1.Location = new System.Drawing.Point(427, 43);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(113, 18);
            this.labelX1.TabIndex = 172;
            this.labelX1.Text = "RUC / DNI Actual:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(426, 61);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.ReadOnly = true;
            this.txtNroDocumento.Size = new System.Drawing.Size(146, 20);
            this.txtNroDocumento.TabIndex = 171;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 167;
            this.label1.Text = "Cliente Actual";
            // 
            // cmbClienteNuevo
            // 
            this.cmbClienteNuevo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbClienteNuevo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClienteNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbClienteNuevo.FormattingEnabled = true;
            this.cmbClienteNuevo.Location = new System.Drawing.Point(13, 107);
            this.cmbClienteNuevo.Name = "cmbClienteNuevo";
            this.cmbClienteNuevo.Size = new System.Drawing.Size(377, 21);
            this.cmbClienteNuevo.TabIndex = 1;
            this.cmbClienteNuevo.SelectedIndexChanged += new System.EventHandler(this.cmbClienteNuevo_SelectedIndexChanged);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(428, 90);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(113, 18);
            this.labelX2.TabIndex = 189;
            this.labelX2.Text = "RUC / DNI Nuevo:";
            // 
            // txtNroDocumentoNuevo
            // 
            this.txtNroDocumentoNuevo.Location = new System.Drawing.Point(426, 108);
            this.txtNroDocumentoNuevo.Name = "txtNroDocumentoNuevo";
            this.txtNroDocumentoNuevo.ReadOnly = true;
            this.txtNroDocumentoNuevo.Size = new System.Drawing.Size(146, 20);
            this.txtNroDocumentoNuevo.TabIndex = 188;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 187;
            this.label6.Text = "Cliente Nuevo";
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
            this.btnAgregarProducto.Location = new System.Drawing.Point(497, 263);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 71);
            this.btnAgregarProducto.TabIndex = 190;
            this.btnAgregarProducto.Text = "Agregar\r\nEquipos";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgvLaptopsSeleccionados
            // 
            this.dgvLaptopsSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaptopsSeleccionados.Location = new System.Drawing.Point(13, 206);
            this.dgvLaptopsSeleccionados.MainView = this.vistaLaptops;
            this.dgvLaptopsSeleccionados.Name = "dgvLaptopsSeleccionados";
            this.dgvLaptopsSeleccionados.Size = new System.Drawing.Size(459, 243);
            this.dgvLaptopsSeleccionados.TabIndex = 191;
            this.dgvLaptopsSeleccionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaLaptops});
            // 
            // vistaLaptops
            // 
            this.vistaLaptops.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaLaptops.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaLaptops.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaLaptops.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaLaptops.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaLaptops.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaLaptops.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaLaptops.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaLaptops.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaLaptops.Appearance.Row.Options.UseFont = true;
            this.vistaLaptops.Appearance.Row.Options.UseForeColor = true;
            this.vistaLaptops.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vistaLaptops.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TipoEquipo,
            this.CodigoLC,
            this.MarcaLC,
            this.ModeloLC,
            this.IdLC});
            this.vistaLaptops.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.vistaLaptops.GridControl = this.dgvLaptopsSeleccionados;
            this.vistaLaptops.Name = "vistaLaptops";
            this.vistaLaptops.OptionsBehavior.Editable = false;
            this.vistaLaptops.OptionsCustomization.AllowColumnMoving = false;
            this.vistaLaptops.OptionsCustomization.AllowGroup = false;
            this.vistaLaptops.OptionsDetail.EnableMasterViewMode = false;
            this.vistaLaptops.OptionsMenu.EnableColumnMenu = false;
            this.vistaLaptops.OptionsView.ColumnAutoWidth = false;
            this.vistaLaptops.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaLaptops.OptionsView.ShowAutoFilterRow = true;
            this.vistaLaptops.OptionsView.ShowGroupPanel = false;
            this.vistaLaptops.OptionsView.ShowIndicator = false;
            // 
            // TipoEquipo
            // 
            this.TipoEquipo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TipoEquipo.AppearanceHeader.Options.UseBackColor = true;
            this.TipoEquipo.Caption = "Tipo Equipo";
            this.TipoEquipo.FieldName = "LaptopTipoEquipoLC";
            this.TipoEquipo.MinWidth = 40;
            this.TipoEquipo.Name = "TipoEquipo";
            this.TipoEquipo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TipoEquipo.Width = 100;
            // 
            // CodigoLC
            // 
            this.CodigoLC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CodigoLC.AppearanceHeader.Options.UseBackColor = true;
            this.CodigoLC.Caption = "Código";
            this.CodigoLC.FieldName = "Codigo";
            this.CodigoLC.MinWidth = 40;
            this.CodigoLC.Name = "CodigoLC";
            this.CodigoLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CodigoLC.Visible = true;
            this.CodigoLC.VisibleIndex = 0;
            this.CodigoLC.Width = 140;
            // 
            // MarcaLC
            // 
            this.MarcaLC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MarcaLC.AppearanceHeader.Options.UseBackColor = true;
            this.MarcaLC.Caption = "Marca";
            this.MarcaLC.FieldName = "Marca";
            this.MarcaLC.MinWidth = 40;
            this.MarcaLC.Name = "MarcaLC";
            this.MarcaLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MarcaLC.Visible = true;
            this.MarcaLC.VisibleIndex = 1;
            this.MarcaLC.Width = 140;
            // 
            // ModeloLC
            // 
            this.ModeloLC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ModeloLC.AppearanceHeader.Options.UseBackColor = true;
            this.ModeloLC.Caption = "Modelo";
            this.ModeloLC.FieldName = "Modelo";
            this.ModeloLC.MinWidth = 40;
            this.ModeloLC.Name = "ModeloLC";
            this.ModeloLC.Visible = true;
            this.ModeloLC.VisibleIndex = 2;
            this.ModeloLC.Width = 160;
            // 
            // IdLC
            // 
            this.IdLC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdLC.AppearanceHeader.Options.UseBackColor = true;
            this.IdLC.Caption = "IdLC";
            this.IdLC.FieldName = "IdEquipo";
            this.IdLC.MinWidth = 40;
            this.IdLC.Name = "IdLC";
            this.IdLC.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IdLC.Width = 80;
            // 
            // cmbSucursalNuevo
            // 
            this.cmbSucursalNuevo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSucursalNuevo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSucursalNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSucursalNuevo.FormattingEnabled = true;
            this.cmbSucursalNuevo.Location = new System.Drawing.Point(13, 155);
            this.cmbSucursalNuevo.Name = "cmbSucursalNuevo";
            this.cmbSucursalNuevo.Size = new System.Drawing.Size(377, 21);
            this.cmbSucursalNuevo.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 16);
            this.label15.TabIndex = 193;
            this.label15.Text = "Sucursal Nuevo:";
            // 
            // frmProcesoCambioRazonSocial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(602, 477);
            this.Controls.Add(this.cmbSucursalNuevo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvLaptopsSeleccionados);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.cmbClienteNuevo);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtNroDocumentoNuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlD);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoCambioRazonSocial";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio Razon Social";
            this.pnlD.ResumeLayout(false);
            this.pnlD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptopsSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaLaptops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cmbCliente;
        internal DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClienteNuevo;
        internal DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.TextBox txtNroDocumentoNuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarProducto;
        public DevExpress.XtraGrid.GridControl dgvLaptopsSeleccionados;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaLaptops;
        private DevExpress.XtraGrid.Columns.GridColumn TipoEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn MarcaLC;
        private DevExpress.XtraGrid.Columns.GridColumn ModeloLC;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoLC;
        private DevExpress.XtraGrid.Columns.GridColumn IdLC;
        private System.Windows.Forms.ComboBox cmbSucursalNuevo;
        private System.Windows.Forms.Label label15;
    }
}
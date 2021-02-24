namespace Apolo
{
    partial class frmProcesoCorteAlquiler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoCorteAlquiler));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.pnlCA = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEquiposSeleccionados = new DevExpress.XtraGrid.GridControl();
            this.vistaEquipos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CodigoEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MarcaLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModeloLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaIniContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaFinContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MotivoCorte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PersonaContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DireccionRecojo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaRecojo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pnlCA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.AutoSize = true;
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(587, 410);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(80, 66);
            this.btnBorrar.TabIndex = 192;
            this.btnBorrar.Text = "Borrar Fila";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(589, 339);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 65);
            this.btnCancelar.TabIndex = 191;
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
            this.btnNuevo.Location = new System.Drawing.Point(590, 191);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(65, 63);
            this.btnNuevo.TabIndex = 190;
            this.btnNuevo.Text = " Nuevo";
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
            this.btnGrabar.Location = new System.Drawing.Point(594, 260);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(64, 64);
            this.btnGrabar.TabIndex = 189;
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
            this.cmbCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(16, 64);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(373, 25);
            this.cmbCliente.TabIndex = 181;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(434, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(68, 18);
            this.labelX1.TabIndex = 188;
            this.labelX1.Text = "RUC / DNI:";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDocumento.Location = new System.Drawing.Point(434, 64);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.ReadOnly = true;
            this.txtNroDocumento.Size = new System.Drawing.Size(146, 23);
            this.txtNroDocumento.TabIndex = 187;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 185;
            this.label3.Text = "Documento Referencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 184;
            this.label1.Text = "Cliente";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(16, 117);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(170, 23);
            this.txtReferencia.TabIndex = 182;
            // 
            // pnlCA
            // 
            this.pnlCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlCA.Controls.Add(this.btnCerrar);
            this.pnlCA.Controls.Add(this.label2);
            this.pnlCA.Location = new System.Drawing.Point(0, 0);
            this.pnlCA.Name = "pnlCA";
            this.pnlCA.Size = new System.Drawing.Size(679, 34);
            this.pnlCA.TabIndex = 193;
            this.pnlCA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCA_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(647, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 232;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(271, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 195;
            this.label2.Text = "CORTE ALQUILER";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCA_MouseMove);
            // 
            // dgvEquiposSeleccionados
            // 
            this.dgvEquiposSeleccionados.Location = new System.Drawing.Point(38, 191);
            this.dgvEquiposSeleccionados.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvEquiposSeleccionados.MainView = this.vistaEquipos;
            this.dgvEquiposSeleccionados.Name = "dgvEquiposSeleccionados";
            this.dgvEquiposSeleccionados.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.dgvEquiposSeleccionados.Size = new System.Drawing.Size(512, 294);
            this.dgvEquiposSeleccionados.TabIndex = 231;
            this.dgvEquiposSeleccionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaEquipos});
            // 
            // vistaEquipos
            // 
            this.vistaEquipos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaEquipos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaEquipos.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaEquipos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaEquipos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaEquipos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaEquipos.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaEquipos.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaEquipos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaEquipos.Appearance.Row.Options.UseFont = true;
            this.vistaEquipos.Appearance.Row.Options.UseForeColor = true;
            this.vistaEquipos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CodigoEquipo,
            this.NumFactura,
            this.FechaIniContrato,
            this.FechaFinContrato,
            this.MotivoCorte,
            this.PersonaContacto,
            this.DireccionRecojo,
            this.Telefono,
            this.FechaRecojo,
            this.MarcaLC,
            this.ModeloLC,
            this.IdLC});
            this.vistaEquipos.GridControl = this.dgvEquiposSeleccionados;
            this.vistaEquipos.Name = "vistaEquipos";
            this.vistaEquipos.OptionsCustomization.AllowColumnMoving = false;
            this.vistaEquipos.OptionsMenu.EnableColumnMenu = false;
            this.vistaEquipos.OptionsView.ColumnAutoWidth = false;
            this.vistaEquipos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaEquipos.OptionsView.ShowAutoFilterRow = true;
            this.vistaEquipos.OptionsView.ShowGroupPanel = false;
            // 
            // CodigoEquipo
            // 
            this.CodigoEquipo.Caption = "Código Equipo";
            this.CodigoEquipo.FieldName = "CodigoLC";
            this.CodigoEquipo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.CodigoEquipo.MinWidth = 40;
            this.CodigoEquipo.Name = "CodigoEquipo";
            this.CodigoEquipo.OptionsColumn.AllowEdit = false;
            this.CodigoEquipo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.CodigoEquipo.Visible = true;
            this.CodigoEquipo.VisibleIndex = 0;
            this.CodigoEquipo.Width = 140;
            // 
            // MarcaLC
            // 
            this.MarcaLC.Caption = "Marca";
            this.MarcaLC.FieldName = "MarcaLC";
            this.MarcaLC.MinWidth = 40;
            this.MarcaLC.Name = "MarcaLC";
            this.MarcaLC.OptionsColumn.AllowEdit = false;
            this.MarcaLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MarcaLC.Width = 100;
            // 
            // ModeloLC
            // 
            this.ModeloLC.Caption = "Modelo";
            this.ModeloLC.FieldName = "ModeloLC";
            this.ModeloLC.MinWidth = 40;
            this.ModeloLC.Name = "ModeloLC";
            this.ModeloLC.OptionsColumn.AllowEdit = false;
            this.ModeloLC.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ModeloLC.Width = 100;
            // 
            // NumFactura
            // 
            this.NumFactura.Caption = "Número Factura";
            this.NumFactura.FieldName = "NumFactura";
            this.NumFactura.MinWidth = 40;
            this.NumFactura.Name = "NumFactura";
            this.NumFactura.OptionsColumn.AllowEdit = false;
            this.NumFactura.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NumFactura.Visible = true;
            this.NumFactura.VisibleIndex = 1;
            this.NumFactura.Width = 130;
            // 
            // FechaIniContrato
            // 
            this.FechaIniContrato.Caption = "Fecha Inicio Alquiler";
            this.FechaIniContrato.FieldName = "FechaIniContrato";
            this.FechaIniContrato.MinWidth = 40;
            this.FechaIniContrato.Name = "FechaIniContrato";
            this.FechaIniContrato.OptionsColumn.AllowEdit = false;
            this.FechaIniContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaIniContrato.Visible = true;
            this.FechaIniContrato.VisibleIndex = 2;
            this.FechaIniContrato.Width = 130;
            // 
            // FechaFinContrato
            // 
            this.FechaFinContrato.Caption = "Fecha Fin Alquiler";
            this.FechaFinContrato.FieldName = "FechaFinContrato";
            this.FechaFinContrato.MinWidth = 40;
            this.FechaFinContrato.Name = "FechaFinContrato";
            this.FechaFinContrato.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaFinContrato.Visible = true;
            this.FechaFinContrato.VisibleIndex = 3;
            this.FechaFinContrato.Width = 130;
            // 
            // IdLC
            // 
            this.IdLC.Caption = "IdLC";
            this.IdLC.FieldName = "IdLC";
            this.IdLC.Name = "IdLC";
            this.IdLC.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // MotivoCorte
            // 
            this.MotivoCorte.Caption = "Motivo Corte";
            this.MotivoCorte.FieldName = "DescripcionMotivoCorte";
            this.MotivoCorte.MinWidth = 40;
            this.MotivoCorte.Name = "MotivoCorte";
            this.MotivoCorte.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MotivoCorte.Visible = true;
            this.MotivoCorte.VisibleIndex = 4;
            this.MotivoCorte.Width = 140;
            // 
            // PersonaContacto
            // 
            this.PersonaContacto.Caption = "Persona Contacto";
            this.PersonaContacto.FieldName = "PersonaContacto";
            this.PersonaContacto.MinWidth = 40;
            this.PersonaContacto.Name = "PersonaContacto";
            this.PersonaContacto.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.PersonaContacto.Visible = true;
            this.PersonaContacto.VisibleIndex = 5;
            this.PersonaContacto.Width = 140;
            // 
            // DireccionRecojo
            // 
            this.DireccionRecojo.Caption = "Dirección Recojo";
            this.DireccionRecojo.FieldName = "Direccion";
            this.DireccionRecojo.MinWidth = 40;
            this.DireccionRecojo.Name = "DireccionRecojo";
            this.DireccionRecojo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.DireccionRecojo.Visible = true;
            this.DireccionRecojo.VisibleIndex = 6;
            this.DireccionRecojo.Width = 140;
            // 
            // Telefono
            // 
            this.Telefono.Caption = "Teléfono";
            this.Telefono.FieldName = "Telefono";
            this.Telefono.MinWidth = 40;
            this.Telefono.Name = "Telefono";
            this.Telefono.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Telefono.Visible = true;
            this.Telefono.VisibleIndex = 7;
            this.Telefono.Width = 100;
            // 
            // FechaRecojo
            // 
            this.FechaRecojo.Caption = "Fecha Recojo";
            this.FechaRecojo.FieldName = "FechaRecojo";
            this.FechaRecojo.MinWidth = 40;
            this.FechaRecojo.Name = "FechaRecojo";
            this.FechaRecojo.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.FechaRecojo.Visible = true;
            this.FechaRecojo.VisibleIndex = 8;
            this.FechaRecojo.Width = 100;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
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
            this.btnAgregarProducto.Location = new System.Drawing.Point(505, 98);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 71);
            this.btnAgregarProducto.TabIndex = 232;
            this.btnAgregarProducto.Text = "Agregar\r\nEquipos";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // frmProcesoCorteAlquiler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(677, 519);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvEquiposSeleccionados);
            this.Controls.Add(this.pnlCA);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReferencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoCorteAlquiler";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corte Alquiler";
            this.pnlCA.ResumeLayout(false);
            this.pnlCA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquiposSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cmbCliente;
        internal DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Panel pnlCA;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl dgvEquiposSeleccionados;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaEquipos;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn MarcaLC;
        private DevExpress.XtraGrid.Columns.GridColumn ModeloLC;
        private DevExpress.XtraGrid.Columns.GridColumn FechaIniContrato;
        private DevExpress.XtraGrid.Columns.GridColumn FechaFinContrato;
        private DevExpress.XtraGrid.Columns.GridColumn NumFactura;
        private DevExpress.XtraGrid.Columns.GridColumn IdLC;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private DevExpress.XtraGrid.Columns.GridColumn MotivoCorte;
        private DevExpress.XtraGrid.Columns.GridColumn PersonaContacto;
        private DevExpress.XtraGrid.Columns.GridColumn DireccionRecojo;
        private DevExpress.XtraGrid.Columns.GridColumn Telefono;
        private DevExpress.XtraGrid.Columns.GridColumn FechaRecojo;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
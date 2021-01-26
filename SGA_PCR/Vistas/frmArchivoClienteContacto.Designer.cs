
namespace Apolo
{
    partial class frmArchivoClienteContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchivoClienteContacto));
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtNombreContacto = new System.Windows.Forms.TextBox();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCS = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.dgvContactos = new DevExpress.XtraGrid.GridControl();
            this.vistaContactos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Anexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbTipoContacto = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.pnlCS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(23, 58);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(347, 24);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(391, 135);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(44, 18);
            this.labelX7.TabIndex = 149;
            this.labelX7.Text = "Anexo";
            // 
            // txtAnexo
            // 
            this.txtAnexo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtAnexo.Location = new System.Drawing.Point(389, 155);
            this.txtAnexo.MaxLength = 250;
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(127, 23);
            this.txtAnexo.TabIndex = 6;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(27, 86);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(117, 18);
            this.labelX6.TabIndex = 147;
            this.labelX6.Text = "Nombre Contacto";
            // 
            // txtNombreContacto
            // 
            this.txtNombreContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtNombreContacto.Location = new System.Drawing.Point(24, 105);
            this.txtNombreContacto.MaxLength = 1000;
            this.txtNombreContacto.Name = "txtNombreContacto";
            this.txtNombreContacto.Size = new System.Drawing.Size(185, 23);
            this.txtNombreContacto.TabIndex = 1;
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chbActivo.Checked = true;
            this.chbActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbActivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.chbActivo.Location = new System.Drawing.Point(546, 137);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(53, 34);
            this.chbActivo.TabIndex = 7;
            this.chbActivo.Text = "Activo\r\n";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(233, 85);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(42, 18);
            this.labelX5.TabIndex = 144;
            this.labelX5.Text = "Cargo";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(25, 37);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(47, 18);
            this.labelX4.TabIndex = 143;
            this.labelX4.Text = "Cliente";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(27, 136);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(40, 18);
            this.labelX3.TabIndex = 142;
            this.labelX3.Text = "Email:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(232, 136);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(59, 18);
            this.labelX2.TabIndex = 141;
            this.labelX2.Text = "Teléfono:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.AutoSize = true;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(606, 474);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 63);
            this.btnImprimir.TabIndex = 139;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(601, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 138;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.AutoSize = true;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(601, 255);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 65);
            this.btnEditar.TabIndex = 137;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(601, 188);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 63);
            this.btnNuevo.TabIndex = 136;
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
            this.btnGrabar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrabar.Location = new System.Drawing.Point(601, 334);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 63);
            this.btnGrabar.TabIndex = 135;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTelefono.Location = new System.Drawing.Point(230, 155);
            this.txtTelefono.MaxLength = 250;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(140, 23);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(24, 155);
            this.txtEmail.MaxLength = 250;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCargo.Location = new System.Drawing.Point(230, 105);
            this.txtCargo.MaxLength = 250;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(140, 23);
            this.txtCargo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 23);
            this.label1.TabIndex = 134;
            this.label1.Text = "MAESTRO CLIENTE/CONTACTO";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCS_MouseMove);
            // 
            // pnlCS
            // 
            this.pnlCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlCS.Controls.Add(this.btnCerrar);
            this.pnlCS.Controls.Add(this.label1);
            this.pnlCS.Location = new System.Drawing.Point(0, 0);
            this.pnlCS.Name = "pnlCS";
            this.pnlCS.Size = new System.Drawing.Size(689, 31);
            this.pnlCS.TabIndex = 151;
            this.pnlCS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCS_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(635, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 232;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvContactos
            // 
            this.dgvContactos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvContactos.Location = new System.Drawing.Point(23, 201);
            this.dgvContactos.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvContactos.MainView = this.vistaContactos;
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(576, 336);
            this.dgvContactos.TabIndex = 231;
            this.dgvContactos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaContactos});
            this.dgvContactos.Click += new System.EventHandler(this.dgvContactos_Click);
            // 
            // vistaContactos
            // 
            this.vistaContactos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaContactos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaContactos.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaContactos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaContactos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaContactos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaContactos.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaContactos.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaContactos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaContactos.Appearance.Row.Options.UseFont = true;
            this.vistaContactos.Appearance.Row.Options.UseForeColor = true;
            this.vistaContactos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nombre,
            this.Email,
            this.Telefono,
            this.Anexo,
            this.Cargo,
            this.Estado,
            this.IdContacto});
            this.vistaContactos.GridControl = this.dgvContactos;
            this.vistaContactos.Name = "vistaContactos";
            this.vistaContactos.OptionsBehavior.Editable = false;
            this.vistaContactos.OptionsCustomization.AllowColumnMoving = false;
            this.vistaContactos.OptionsMenu.EnableColumnMenu = false;
            this.vistaContactos.OptionsView.ColumnAutoWidth = false;
            this.vistaContactos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaContactos.OptionsView.ShowAutoFilterRow = true;
            this.vistaContactos.OptionsView.ShowGroupPanel = false;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "NombreContacto";
            this.Nombre.MinWidth = 40;
            this.Nombre.Name = "Nombre";
            this.Nombre.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 0;
            this.Nombre.Width = 140;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "Email";
            this.Email.MinWidth = 40;
            this.Email.Name = "Email";
            this.Email.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 1;
            this.Email.Width = 120;
            // 
            // Telefono
            // 
            this.Telefono.Caption = "Telefono";
            this.Telefono.FieldName = "Telefono";
            this.Telefono.MinWidth = 40;
            this.Telefono.Name = "Telefono";
            this.Telefono.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Telefono.Visible = true;
            this.Telefono.VisibleIndex = 2;
            this.Telefono.Width = 100;
            // 
            // Anexo
            // 
            this.Anexo.Caption = "Anexo";
            this.Anexo.FieldName = "Anexo";
            this.Anexo.MinWidth = 40;
            this.Anexo.Name = "Anexo";
            this.Anexo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Anexo.Visible = true;
            this.Anexo.VisibleIndex = 3;
            this.Anexo.Width = 100;
            // 
            // Cargo
            // 
            this.Cargo.Caption = "Cargo";
            this.Cargo.FieldName = "Cargo";
            this.Cargo.MinWidth = 40;
            this.Cargo.Name = "Cargo";
            this.Cargo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Cargo.Visible = true;
            this.Cargo.VisibleIndex = 4;
            this.Cargo.Width = 100;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "Estado";
            this.Estado.MinWidth = 40;
            this.Estado.Name = "Estado";
            this.Estado.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 5;
            this.Estado.Width = 100;
            // 
            // IdContacto
            // 
            this.IdContacto.Caption = "IdContacto";
            this.IdContacto.FieldName = "IdContacto";
            this.IdContacto.Name = "IdContacto";
            this.IdContacto.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IdContacto.Visible = true;
            this.IdContacto.VisibleIndex = 6;
            // 
            // cmbTipoContacto
            // 
            this.cmbTipoContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipoContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbTipoContacto.FormattingEnabled = true;
            this.cmbTipoContacto.Location = new System.Drawing.Point(389, 105);
            this.cmbTipoContacto.Name = "cmbTipoContacto";
            this.cmbTipoContacto.Size = new System.Drawing.Size(127, 24);
            this.cmbTipoContacto.TabIndex = 3;
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
            this.labelX1.Location = new System.Drawing.Point(392, 86);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 18);
            this.labelX1.TabIndex = 232;
            this.labelX1.Text = "Tipo Contacto";
            // 
            // frmArchivoClienteContacto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(682, 551);
            this.Controls.Add(this.cmbTipoContacto);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.pnlCS);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtAnexo);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtNombreContacto);
            this.Controls.Add(this.chbActivo);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArchivoClienteContacto";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Contacto";
            this.pnlCS.ResumeLayout(false);
            this.pnlCS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCliente;
        internal DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.TextBox txtAnexo;
        internal DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.TextBox txtNombreContacto;
        private System.Windows.Forms.CheckBox chbActivo;
        internal DevComponents.DotNetBar.LabelX labelX5;
        internal DevComponents.DotNetBar.LabelX labelX4;
        internal DevComponents.DotNetBar.LabelX labelX3;
        internal DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCS;
        private DevExpress.XtraGrid.GridControl dgvContactos;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaContactos;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Telefono;
        private DevExpress.XtraGrid.Columns.GridColumn Anexo;
        private DevExpress.XtraGrid.Columns.GridColumn Cargo;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn IdContacto;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ComboBox cmbTipoContacto;
        internal DevComponents.DotNetBar.LabelX labelX1;
    }
}
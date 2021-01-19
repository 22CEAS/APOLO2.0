namespace Apolo
{
    partial class frmConfiguracionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionUsuarios));
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.labelPerfil = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.pnlConfguracionUsuario = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.dgvUsu = new DevExpress.XtraGrid.GridControl();
            this.vistaUsu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dni = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.User = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdPerfil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombrePerfil1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreEstado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreArea1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlConfguracionUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(123, 70);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(148, 20);
            this.txtDni.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(581, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(123, 102);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(148, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(581, 101);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(148, 20);
            this.txtClaveUsuario.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(459, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(459, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "CONTRASEÑA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "EMAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(459, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "AREA";
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(581, 131);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(148, 21);
            this.cmbArea.TabIndex = 11;
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
            this.btnCancelar.Location = new System.Drawing.Point(749, 463);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 104;
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
            this.btnEditar.Location = new System.Drawing.Point(749, 315);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 65);
            this.btnEditar.TabIndex = 103;
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
            this.btnNuevo.Location = new System.Drawing.Point(749, 248);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 63);
            this.btnNuevo.TabIndex = 102;
            this.btnNuevo.Text = "Nuevo";
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
            this.btnGrabar.Location = new System.Drawing.Point(749, 394);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 63);
            this.btnGrabar.TabIndex = 101;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // labelPerfil
            // 
            this.labelPerfil.AutoSize = true;
            this.labelPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelPerfil.Location = new System.Drawing.Point(12, 161);
            this.labelPerfil.Name = "labelPerfil";
            this.labelPerfil.Size = new System.Drawing.Size(60, 16);
            this.labelPerfil.TabIndex = 107;
            this.labelPerfil.Text = "PERFIL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(459, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 108;
            this.label8.Text = "ESTADO";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(581, 158);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(148, 21);
            this.cmbEstado.TabIndex = 110;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(123, 159);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(148, 21);
            this.cmbPerfil.TabIndex = 111;
            // 
            // pnlConfguracionUsuario
            // 
            this.pnlConfguracionUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlConfguracionUsuario.Controls.Add(this.btnCerrar);
            this.pnlConfguracionUsuario.Controls.Add(this.lblUsuarios);
            this.pnlConfguracionUsuario.Location = new System.Drawing.Point(3, 3);
            this.pnlConfguracionUsuario.Name = "pnlConfguracionUsuario";
            this.pnlConfguracionUsuario.Size = new System.Drawing.Size(820, 41);
            this.pnlConfguracionUsuario.TabIndex = 112;
            this.pnlConfguracionUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlConfguracionUsuario_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.AutoSize = true;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(772, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 39);
            this.btnCerrar.TabIndex = 147;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblUsuarios.Location = new System.Drawing.Point(200, 5);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(420, 31);
            this.lblUsuarios.TabIndex = 146;
            this.lblUsuarios.Text = "CONFIGURACION USUARIOS";
            this.lblUsuarios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlConfguracionUsuario_MouseMove);
            // 
            // dgvUsu
            // 
            this.dgvUsu.Location = new System.Drawing.Point(15, 186);
            this.dgvUsu.MainView = this.vistaUsu;
            this.dgvUsu.Name = "dgvUsu";
            this.dgvUsu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dgvUsu.Size = new System.Drawing.Size(728, 387);
            this.dgvUsu.TabIndex = 141;
            this.dgvUsu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaUsu});
            this.dgvUsu.Click += new System.EventHandler(this.dgvUsu_Click);
            // 
            // vistaUsu
            // 
            this.vistaUsu.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaUsu.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaUsu.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaUsu.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaUsu.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaUsu.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaUsu.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaUsu.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaUsu.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaUsu.Appearance.Row.Options.UseFont = true;
            this.vistaUsu.Appearance.Row.Options.UseForeColor = true;
            this.vistaUsu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdUsuario,
            this.Dni,
            this.Nombre,
            this.User,
            this.IdPerfil,
            this.NombrePerfil1,
            this.Email,
            this.Estado,
            this.NombreEstado1,
            this.IdArea,
            this.NombreArea1});
            this.vistaUsu.GridControl = this.dgvUsu;
            this.vistaUsu.Name = "vistaUsu";
            this.vistaUsu.OptionsBehavior.Editable = false;
            this.vistaUsu.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.vistaUsu.OptionsSelection.MultiSelect = true;
            this.vistaUsu.OptionsView.ColumnAutoWidth = false;
            this.vistaUsu.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaUsu.OptionsView.ShowAutoFilterRow = true;
            // 
            // IdUsuario
            // 
            this.IdUsuario.Caption = "IDUSUARIO";
            this.IdUsuario.FieldName = "IdUsuario";
            this.IdUsuario.MinWidth = 100;
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Width = 100;
            // 
            // Dni
            // 
            this.Dni.Caption = "DNI";
            this.Dni.FieldName = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.Visible = true;
            this.Dni.VisibleIndex = 0;
            this.Dni.Width = 100;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "NOMBRE";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            this.Nombre.Width = 100;
            // 
            // User
            // 
            this.User.Caption = "USUARIO";
            this.User.FieldName = "User";
            this.User.Name = "User";
            this.User.Visible = true;
            this.User.VisibleIndex = 2;
            this.User.Width = 100;
            // 
            // IdPerfil
            // 
            this.IdPerfil.Caption = "ID PERFIL";
            this.IdPerfil.FieldName = "IdPerfil";
            this.IdPerfil.Name = "IdPerfil";
            // 
            // NombrePerfil1
            // 
            this.NombrePerfil1.Caption = "PERFIL";
            this.NombrePerfil1.FieldName = "NombrePerfil1";
            this.NombrePerfil1.Name = "NombrePerfil1";
            this.NombrePerfil1.Visible = true;
            this.NombrePerfil1.VisibleIndex = 3;
            this.NombrePerfil1.Width = 100;
            // 
            // Email
            // 
            this.Email.Caption = "EMAIL";
            this.Email.FieldName = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            this.Email.Width = 100;
            // 
            // Estado
            // 
            this.Estado.Caption = "ID ESTADO";
            this.Estado.FieldName = "Estado";
            this.Estado.Name = "Estado";
            // 
            // NombreEstado1
            // 
            this.NombreEstado1.Caption = "ESTADO";
            this.NombreEstado1.FieldName = "NombreEstado1";
            this.NombreEstado1.Name = "NombreEstado1";
            this.NombreEstado1.Visible = true;
            this.NombreEstado1.VisibleIndex = 5;
            this.NombreEstado1.Width = 100;
            // 
            // IdArea
            // 
            this.IdArea.Caption = "ID AREA";
            this.IdArea.FieldName = "IdArea";
            this.IdArea.Name = "IdArea";
            // 
            // NombreArea1
            // 
            this.NombreArea1.Caption = "AREA";
            this.NombreArea1.FieldName = "NombreArea1";
            this.NombreArea1.Name = "NombreArea1";
            this.NombreArea1.Visible = true;
            this.NombreArea1.VisibleIndex = 6;
            this.NombreArea1.Width = 100;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // frmConfiguracionUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(836, 585);
            this.Controls.Add(this.dgvUsu);
            this.Controls.Add(this.pnlConfguracionUsuario);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelPerfil);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cmbArea);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtClaveUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracionUsuarios";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.frmConfiguracionUsuarios_Load);
            this.pnlConfguracionUsuario.ResumeLayout(false);
            this.pnlConfguracionUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label labelPerfil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Panel pnlConfguracionUsuario;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Button btnCerrar;
        private DevExpress.XtraGrid.GridControl dgvUsu;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaUsu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn Dni;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn User;
        private DevExpress.XtraGrid.Columns.GridColumn IdPerfil;
        private DevExpress.XtraGrid.Columns.GridColumn NombrePerfil1;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private DevExpress.XtraGrid.Columns.GridColumn NombreEstado1;
        private DevExpress.XtraGrid.Columns.GridColumn IdArea;
        private DevExpress.XtraGrid.Columns.GridColumn NombreArea1;
    }
}
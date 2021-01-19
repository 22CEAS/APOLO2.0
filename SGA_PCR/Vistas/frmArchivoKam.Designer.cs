namespace Apolo
{
    partial class frmArchivoKam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArchivoKam));
            this.cmbKAM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeseleccionarFilas = new System.Windows.Forms.Button();
            this.btnSeleccionarFilas = new System.Windows.Forms.Button();
            this.dgvClienteKam = new DevExpress.XtraGrid.GridControl();
            this.vista = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Seleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.CLIENTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KAM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.pnlK = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCambiarForma = new System.Windows.Forms.Button();
            this.btnCargarData = new System.Windows.Forms.Button();
            this.btnRelacionKAMmas = new System.Windows.Forms.Button();
            this.dgvKAMmas = new DevExpress.XtraGrid.GridControl();
            this.vistaKAMmas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DniKam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreKam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteKam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.pnlK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKAMmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaKAMmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKAM
            // 
            this.cmbKAM.FormattingEnabled = true;
            this.cmbKAM.Location = new System.Drawing.Point(54, 70);
            this.cmbKAM.Name = "cmbKAM";
            this.cmbKAM.Size = new System.Drawing.Size(150, 21);
            this.cmbKAM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "KAM";
            // 
            // btnDeseleccionarFilas
            // 
            this.btnDeseleccionarFilas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeseleccionarFilas.AutoSize = true;
            this.btnDeseleccionarFilas.BackColor = System.Drawing.Color.Transparent;
            this.btnDeseleccionarFilas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeseleccionarFilas.FlatAppearance.BorderSize = 0;
            this.btnDeseleccionarFilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeseleccionarFilas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeseleccionarFilas.Image = ((System.Drawing.Image)(resources.GetObject("btnDeseleccionarFilas.Image")));
            this.btnDeseleccionarFilas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeseleccionarFilas.Location = new System.Drawing.Point(353, 54);
            this.btnDeseleccionarFilas.Name = "btnDeseleccionarFilas";
            this.btnDeseleccionarFilas.Size = new System.Drawing.Size(144, 50);
            this.btnDeseleccionarFilas.TabIndex = 139;
            this.btnDeseleccionarFilas.Text = "Deseleccionar Filas";
            this.btnDeseleccionarFilas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeseleccionarFilas.UseVisualStyleBackColor = false;
            this.btnDeseleccionarFilas.Click += new System.EventHandler(this.btnDeseleccionarFilas_Click);
            // 
            // btnSeleccionarFilas
            // 
            this.btnSeleccionarFilas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarFilas.AutoSize = true;
            this.btnSeleccionarFilas.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionarFilas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarFilas.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarFilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarFilas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarFilas.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarFilas.Image")));
            this.btnSeleccionarFilas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeleccionarFilas.Location = new System.Drawing.Point(219, 54);
            this.btnSeleccionarFilas.Name = "btnSeleccionarFilas";
            this.btnSeleccionarFilas.Size = new System.Drawing.Size(128, 50);
            this.btnSeleccionarFilas.TabIndex = 138;
            this.btnSeleccionarFilas.Text = "Seleccionar Filas";
            this.btnSeleccionarFilas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionarFilas.UseVisualStyleBackColor = false;
            this.btnSeleccionarFilas.Click += new System.EventHandler(this.btnSeleccionarFilas_Click);
            // 
            // dgvClienteKam
            // 
            this.dgvClienteKam.Location = new System.Drawing.Point(5, 112);
            this.dgvClienteKam.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvClienteKam.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvClienteKam.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvClienteKam.MainView = this.vista;
            this.dgvClienteKam.Name = "dgvClienteKam";
            this.dgvClienteKam.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dgvClienteKam.Size = new System.Drawing.Size(492, 321);
            this.dgvClienteKam.TabIndex = 140;
            this.dgvClienteKam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Seleccionar,
            this.CLIENTE,
            this.KAM});
            this.vista.GridControl = this.dgvClienteKam;
            this.vista.Name = "vista";
            this.vista.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.vista.OptionsSelection.MultiSelect = true;
            this.vista.OptionsView.ColumnAutoWidth = false;
            this.vista.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vista.OptionsView.ShowAutoFilterRow = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.Caption = "Seleccionar";
            this.Seleccionar.ColumnEdit = this.repositoryItemCheckEdit1;
            this.Seleccionar.FieldName = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Seleccionar.Visible = true;
            this.Seleccionar.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // CLIENTE
            // 
            this.CLIENTE.Caption = "CLIENTE";
            this.CLIENTE.FieldName = "Nombre_razonSocial";
            this.CLIENTE.MinWidth = 100;
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.Visible = true;
            this.CLIENTE.VisibleIndex = 1;
            this.CLIENTE.Width = 200;
            // 
            // KAM
            // 
            this.KAM.Caption = "KAM";
            this.KAM.FieldName = "KAM1";
            this.KAM.MinWidth = 100;
            this.KAM.Name = "KAM";
            this.KAM.OptionsColumn.AllowEdit = false;
            this.KAM.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.KAM.Visible = true;
            this.KAM.VisibleIndex = 2;
            this.KAM.Width = 200;
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
            this.btnGrabar.Location = new System.Drawing.Point(161, 435);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(119, 60);
            this.btnGrabar.TabIndex = 141;
            this.btnGrabar.Text = "Relacionar KAM";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // pnlK
            // 
            this.pnlK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlK.Controls.Add(this.label2);
            this.pnlK.Controls.Add(this.button1);
            this.pnlK.Location = new System.Drawing.Point(0, 0);
            this.pnlK.Name = "pnlK";
            this.pnlK.Size = new System.Drawing.Size(991, 52);
            this.pnlK.TabIndex = 142;
            this.pnlK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlK_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(399, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 31);
            this.label2.TabIndex = 144;
            this.label2.Text = "MAESTRO KAM";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlK_MouseMove);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(930, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 42);
            this.button1.TabIndex = 143;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCambiarForma
            // 
            this.btnCambiarForma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCambiarForma.Location = new System.Drawing.Point(498, 276);
            this.btnCambiarForma.Name = "btnCambiarForma";
            this.btnCambiarForma.Size = new System.Drawing.Size(61, 38);
            this.btnCambiarForma.TabIndex = 143;
            this.btnCambiarForma.Text = "MASIVO";
            this.btnCambiarForma.UseVisualStyleBackColor = true;
            this.btnCambiarForma.Click += new System.EventHandler(this.btnCambiarForma_Click);
            // 
            // btnCargarData
            // 
            this.btnCargarData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarData.AutoSize = true;
            this.btnCargarData.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarData.FlatAppearance.BorderSize = 0;
            this.btnCargarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarData.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarData.Image")));
            this.btnCargarData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarData.Location = new System.Drawing.Point(607, 435);
            this.btnCargarData.Name = "btnCargarData";
            this.btnCargarData.Size = new System.Drawing.Size(119, 60);
            this.btnCargarData.TabIndex = 144;
            this.btnCargarData.Text = "Cargar Data";
            this.btnCargarData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarData.UseVisualStyleBackColor = false;
            this.btnCargarData.Visible = false;
            this.btnCargarData.Click += new System.EventHandler(this.btnCargarData_Click);
            // 
            // btnRelacionKAMmas
            // 
            this.btnRelacionKAMmas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelacionKAMmas.AutoSize = true;
            this.btnRelacionKAMmas.BackColor = System.Drawing.Color.Transparent;
            this.btnRelacionKAMmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelacionKAMmas.FlatAppearance.BorderSize = 0;
            this.btnRelacionKAMmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelacionKAMmas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelacionKAMmas.Image = ((System.Drawing.Image)(resources.GetObject("btnRelacionKAMmas.Image")));
            this.btnRelacionKAMmas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRelacionKAMmas.Location = new System.Drawing.Point(756, 435);
            this.btnRelacionKAMmas.Name = "btnRelacionKAMmas";
            this.btnRelacionKAMmas.Size = new System.Drawing.Size(119, 60);
            this.btnRelacionKAMmas.TabIndex = 145;
            this.btnRelacionKAMmas.Text = "Relacionar KAM";
            this.btnRelacionKAMmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelacionKAMmas.UseVisualStyleBackColor = false;
            this.btnRelacionKAMmas.Visible = false;
            this.btnRelacionKAMmas.Click += new System.EventHandler(this.btnRelacionKAMmas_Click);
            // 
            // dgvKAMmas
            // 
            this.dgvKAMmas.Location = new System.Drawing.Point(578, 58);
            this.dgvKAMmas.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvKAMmas.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvKAMmas.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvKAMmas.MainView = this.vistaKAMmas;
            this.dgvKAMmas.Name = "dgvKAMmas";
            this.dgvKAMmas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.dgvKAMmas.Size = new System.Drawing.Size(410, 375);
            this.dgvKAMmas.TabIndex = 146;
            this.dgvKAMmas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaKAMmas});
            this.dgvKAMmas.Visible = false;
            // 
            // vistaKAMmas
            // 
            this.vistaKAMmas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.vistaKAMmas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaKAMmas.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaKAMmas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaKAMmas.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaKAMmas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaKAMmas.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaKAMmas.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.vistaKAMmas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaKAMmas.Appearance.Row.Options.UseFont = true;
            this.vistaKAMmas.Appearance.Row.Options.UseForeColor = true;
            this.vistaKAMmas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ruc,
            this.gridColumn3,
            this.DniKam,
            this.NombreKam});
            this.vistaKAMmas.GridControl = this.dgvKAMmas;
            this.vistaKAMmas.Name = "vistaKAMmas";
            this.vistaKAMmas.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.vistaKAMmas.OptionsSelection.MultiSelect = true;
            this.vistaKAMmas.OptionsView.ColumnAutoWidth = false;
            this.vistaKAMmas.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaKAMmas.OptionsView.ShowAutoFilterRow = true;
            this.vistaKAMmas.OptionsView.ShowGroupPanel = false;
            this.vistaKAMmas.OptionsView.ShowIndicator = false;
            // 
            // ruc
            // 
            this.ruc.Caption = "RUC";
            this.ruc.FieldName = "rucCliente";
            this.ruc.MinWidth = 100;
            this.ruc.Name = "ruc";
            this.ruc.Visible = true;
            this.ruc.VisibleIndex = 0;
            this.ruc.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "CLIENTE";
            this.gridColumn3.FieldName = "razonSocialCliente";
            this.gridColumn3.MinWidth = 100;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 100;
            // 
            // DniKam
            // 
            this.DniKam.Caption = "DNI KAM";
            this.DniKam.FieldName = "dniKam";
            this.DniKam.Name = "DniKam";
            this.DniKam.Visible = true;
            this.DniKam.VisibleIndex = 2;
            this.DniKam.Width = 100;
            // 
            // NombreKam
            // 
            this.NombreKam.Caption = "NOMBRE KAM";
            this.NombreKam.FieldName = "nombreKam";
            this.NombreKam.Name = "NombreKam";
            this.NombreKam.Visible = true;
            this.NombreKam.VisibleIndex = 3;
            this.NombreKam.Width = 100;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // frmArchivoKam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(992, 497);
            this.Controls.Add(this.dgvKAMmas);
            this.Controls.Add(this.btnRelacionKAMmas);
            this.Controls.Add(this.btnCargarData);
            this.Controls.Add(this.btnCambiarForma);
            this.Controls.Add(this.pnlK);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvClienteKam);
            this.Controls.Add(this.btnDeseleccionarFilas);
            this.Controls.Add(this.btnSeleccionarFilas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKAM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArchivoKam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAM";
            this.Load += new System.EventHandler(this.frmArchivoKam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienteKam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.pnlK.ResumeLayout(false);
            this.pnlK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKAMmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaKAMmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeseleccionarFilas;
        private System.Windows.Forms.Button btnSeleccionarFilas;
        private DevExpress.XtraGrid.GridControl dgvClienteKam;
        private DevExpress.XtraGrid.Views.Grid.GridView vista;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn KAM;
        private System.Windows.Forms.Button btnGrabar;
        private DevExpress.XtraGrid.Columns.GridColumn CLIENTE;
        private DevExpress.XtraGrid.Columns.GridColumn Seleccionar;
        private System.Windows.Forms.Panel pnlK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambiarForma;
        private System.Windows.Forms.Button btnCargarData;
        private System.Windows.Forms.Button btnRelacionKAMmas;
        private DevExpress.XtraGrid.GridControl dgvKAMmas;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaKAMmas;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn ruc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn DniKam;
        private DevExpress.XtraGrid.Columns.GridColumn NombreKam;
    }
}
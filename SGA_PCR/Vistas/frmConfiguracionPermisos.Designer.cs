namespace Apolo
{
    partial class frmConfiguracionPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionPermisos));
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbModulosPrincipales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarPermisos = new System.Windows.Forms.Button();
            this.btnQuitarPermisos = new System.Windows.Forms.Button();
            this.submoduloDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlPermisos = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.dgvSubModulo = new DevExpress.XtraGrid.GridControl();
            this.vistaSubModulo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idSubmodulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descripcionSubmodulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idModuloP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvPermisos = new DevExpress.XtraGrid.GridControl();
            this.vistaPermisos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.submoduloDABindingSource)).BeginInit();
            this.pnlPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSubModulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUsuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarios.ForeColor = System.Drawing.Color.Black;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(171, 80);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(219, 24);
            this.cmbUsuarios.TabIndex = 0;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // cmbModulosPrincipales
            // 
            this.cmbModulosPrincipales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbModulosPrincipales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulosPrincipales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModulosPrincipales.ForeColor = System.Drawing.Color.Black;
            this.cmbModulosPrincipales.FormattingEnabled = true;
            this.cmbModulosPrincipales.Location = new System.Drawing.Point(631, 84);
            this.cmbModulosPrincipales.Name = "cmbModulosPrincipales";
            this.cmbModulosPrincipales.Size = new System.Drawing.Size(229, 24);
            this.cmbModulosPrincipales.TabIndex = 1;
            this.cmbModulosPrincipales.SelectedIndexChanged += new System.EventHandler(this.cmbModulosPrincipales_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(540, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "MODULO";
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarPermiso.Location = new System.Drawing.Point(438, 224);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(53, 41);
            this.btnAgregarPermiso.TabIndex = 10;
            this.btnAgregarPermiso.Text = ">";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // btnQuitarPermiso
            // 
            this.btnQuitarPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPermiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuitarPermiso.Location = new System.Drawing.Point(438, 296);
            this.btnQuitarPermiso.Name = "btnQuitarPermiso";
            this.btnQuitarPermiso.Size = new System.Drawing.Size(53, 41);
            this.btnQuitarPermiso.TabIndex = 11;
            this.btnQuitarPermiso.Text = "<";
            this.btnQuitarPermiso.UseVisualStyleBackColor = true;
            this.btnQuitarPermiso.Click += new System.EventHandler(this.btnQuitarPermiso_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(157, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "SUB MODULOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(578, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "PERMISOS DEL USUARIO";
            // 
            // btnAgregarPermisos
            // 
            this.btnAgregarPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarPermisos.Location = new System.Drawing.Point(438, 403);
            this.btnAgregarPermisos.Name = "btnAgregarPermisos";
            this.btnAgregarPermisos.Size = new System.Drawing.Size(53, 41);
            this.btnAgregarPermisos.TabIndex = 152;
            this.btnAgregarPermisos.Text = ">>";
            this.btnAgregarPermisos.UseVisualStyleBackColor = true;
            this.btnAgregarPermisos.Click += new System.EventHandler(this.btnAgregarPermisos_Click);
            // 
            // btnQuitarPermisos
            // 
            this.btnQuitarPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuitarPermisos.Location = new System.Drawing.Point(438, 472);
            this.btnQuitarPermisos.Name = "btnQuitarPermisos";
            this.btnQuitarPermisos.Size = new System.Drawing.Size(53, 41);
            this.btnQuitarPermisos.TabIndex = 153;
            this.btnQuitarPermisos.Text = "<<";
            this.btnQuitarPermisos.UseVisualStyleBackColor = true;
            this.btnQuitarPermisos.Click += new System.EventHandler(this.btnQuitarPermisos_Click);
            // 
            // submoduloDABindingSource
            // 
            this.submoduloDABindingSource.DataSource = typeof(AccesoDatos.SubmoduloDA);
            // 
            // pnlPermisos
            // 
            this.pnlPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlPermisos.Controls.Add(this.btnCerrar);
            this.pnlPermisos.Controls.Add(this.lblPermisos);
            this.pnlPermisos.Location = new System.Drawing.Point(2, 1);
            this.pnlPermisos.Name = "pnlPermisos";
            this.pnlPermisos.Size = new System.Drawing.Size(948, 43);
            this.pnlPermisos.TabIndex = 154;
            this.pnlPermisos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPermisos_MouseMove);
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
            this.btnCerrar.Location = new System.Drawing.Point(900, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 39);
            this.btnCerrar.TabIndex = 146;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisos.ForeColor = System.Drawing.Color.White;
            this.lblPermisos.Location = new System.Drawing.Point(252, 6);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(420, 31);
            this.lblPermisos.TabIndex = 145;
            this.lblPermisos.Text = "CONFIGURACION PERMISOS";
            this.lblPermisos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPermisos_MouseMove);
            // 
            // dgvSubModulo
            // 
            this.dgvSubModulo.Location = new System.Drawing.Point(73, 173);
            this.dgvSubModulo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvSubModulo.MainView = this.vistaSubModulo;
            this.dgvSubModulo.Name = "dgvSubModulo";
            this.dgvSubModulo.Size = new System.Drawing.Size(317, 375);
            this.dgvSubModulo.TabIndex = 233;
            this.dgvSubModulo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaSubModulo});
            // 
            // vistaSubModulo
            // 
            this.vistaSubModulo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaSubModulo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaSubModulo.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaSubModulo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaSubModulo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaSubModulo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaSubModulo.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaSubModulo.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaSubModulo.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaSubModulo.Appearance.Row.Options.UseFont = true;
            this.vistaSubModulo.Appearance.Row.Options.UseForeColor = true;
            this.vistaSubModulo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idSubmodulo,
            this.descripcionSubmodulo,
            this.idModuloP});
            this.vistaSubModulo.GridControl = this.dgvSubModulo;
            this.vistaSubModulo.Name = "vistaSubModulo";
            this.vistaSubModulo.OptionsBehavior.Editable = false;
            this.vistaSubModulo.OptionsCustomization.AllowColumnMoving = false;
            this.vistaSubModulo.OptionsMenu.EnableColumnMenu = false;
            this.vistaSubModulo.OptionsView.ColumnAutoWidth = false;
            this.vistaSubModulo.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaSubModulo.OptionsView.ShowAutoFilterRow = true;
            this.vistaSubModulo.OptionsView.ShowGroupPanel = false;
            // 
            // idSubmodulo
            // 
            this.idSubmodulo.Caption = "IdSubmodulo";
            this.idSubmodulo.FieldName = "idSubmodulo";
            this.idSubmodulo.Name = "idSubmodulo";
            this.idSubmodulo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // descripcionSubmodulo
            // 
            this.descripcionSubmodulo.Caption = "Sub Módulo";
            this.descripcionSubmodulo.FieldName = "descripcionSubmodulo";
            this.descripcionSubmodulo.MinWidth = 40;
            this.descripcionSubmodulo.Name = "descripcionSubmodulo";
            this.descripcionSubmodulo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.descripcionSubmodulo.Visible = true;
            this.descripcionSubmodulo.VisibleIndex = 0;
            this.descripcionSubmodulo.Width = 285;
            // 
            // idModuloP
            // 
            this.idModuloP.Caption = "IdModulo";
            this.idModuloP.FieldName = "idModuloP";
            this.idModuloP.Name = "idModuloP";
            this.idModuloP.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.Location = new System.Drawing.Point(543, 173);
            this.dgvPermisos.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvPermisos.MainView = this.vistaPermisos;
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(317, 375);
            this.dgvPermisos.TabIndex = 234;
            this.dgvPermisos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaPermisos});
            // 
            // vistaPermisos
            // 
            this.vistaPermisos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaPermisos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaPermisos.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaPermisos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaPermisos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaPermisos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaPermisos.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaPermisos.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaPermisos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaPermisos.Appearance.Row.Options.UseFont = true;
            this.vistaPermisos.Appearance.Row.Options.UseForeColor = true;
            this.vistaPermisos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.vistaPermisos.GridControl = this.dgvPermisos;
            this.vistaPermisos.Name = "vistaPermisos";
            this.vistaPermisos.OptionsBehavior.Editable = false;
            this.vistaPermisos.OptionsCustomization.AllowColumnMoving = false;
            this.vistaPermisos.OptionsMenu.EnableColumnMenu = false;
            this.vistaPermisos.OptionsView.ColumnAutoWidth = false;
            this.vistaPermisos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaPermisos.OptionsView.ShowAutoFilterRow = true;
            this.vistaPermisos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IdSubmodulo";
            this.gridColumn1.FieldName = "idSubmodulo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Sub Módulo";
            this.gridColumn2.FieldName = "descripcionSubmodulo";
            this.gridColumn2.MinWidth = 40;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 285;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "IdModulo";
            this.gridColumn3.FieldName = "idModuloP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // frmConfiguracionPermisos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(946, 588);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.dgvSubModulo);
            this.Controls.Add(this.pnlPermisos);
            this.Controls.Add(this.btnQuitarPermisos);
            this.Controls.Add(this.btnAgregarPermisos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQuitarPermiso);
            this.Controls.Add(this.btnAgregarPermiso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbModulosPrincipales);
            this.Controls.Add(this.cmbUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1598, 858);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(946, 546);
            this.Name = "frmConfiguracionPermisos";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERMISOS";
            ((System.ComponentModel.ISupportInitialize)(this.submoduloDABindingSource)).EndInit();
            this.pnlPermisos.ResumeLayout(false);
            this.pnlPermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSubModulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbModulosPrincipales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private System.Windows.Forms.Button btnQuitarPermiso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource submoduloDABindingSource;
        private System.Windows.Forms.Button btnAgregarPermisos;
        private System.Windows.Forms.Button btnQuitarPermisos;
        private System.Windows.Forms.Panel pnlPermisos;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Button btnCerrar;
        private DevExpress.XtraGrid.GridControl dgvSubModulo;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaSubModulo;
        private DevExpress.XtraGrid.Columns.GridColumn idSubmodulo;
        private DevExpress.XtraGrid.Columns.GridColumn descripcionSubmodulo;
        private DevExpress.XtraGrid.Columns.GridColumn idModuloP;
        private DevExpress.XtraGrid.GridControl dgvPermisos;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaPermisos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
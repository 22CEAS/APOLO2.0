namespace Apolo
{
    partial class frmProcesoCambioAgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoCambioAgregarProducto));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dgvEquipos = new DevExpress.XtraGrid.GridControl();
            this.vistaEquipos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Seleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Código = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModeloEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pantalla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Procesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeseleccionarFilas = new System.Windows.Forms.Button();
            this.btnSeleccionarFilas = new System.Windows.Forms.Button();
            this.generacionProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nombreModeloVideo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.capacidadVideo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idVideo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEquipos)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(745, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 123;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnGrabar.Location = new System.Drawing.Point(822, 305);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 63);
            this.btnGrabar.TabIndex = 122;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquipos.Location = new System.Drawing.Point(23, 79);
            //this.dgvEquipos.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            //this.dgvEquipos.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            //this.dgvEquipos.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvEquipos.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvEquipos.MainView = this.vistaEquipos;
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.Size = new System.Drawing.Size(863, 218);
            this.dgvEquipos.TabIndex = 209;
            this.dgvEquipos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.Seleccionar,
            this.Código,
            this.Marca,
            this.ModeloEquipo,
            this.Pantalla,
            this.Procesador,
            this.generacionProcesador,
            this.nombreModeloVideo,
            this.capacidadVideo,
            this.idLC,
            this.idVideo,
            this.idProcesador});
            this.vistaEquipos.GridControl = this.dgvEquipos;
            this.vistaEquipos.Name = "vistaEquipos";
            this.vistaEquipos.OptionsCustomization.AllowColumnMoving = false;
            this.vistaEquipos.OptionsCustomization.AllowGroup = false;
            this.vistaEquipos.OptionsDetail.EnableMasterViewMode = false;
            this.vistaEquipos.OptionsMenu.EnableColumnMenu = false;
            this.vistaEquipos.OptionsView.ColumnAutoWidth = false;
            this.vistaEquipos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaEquipos.OptionsView.ShowAutoFilterRow = true;
            this.vistaEquipos.OptionsView.ShowGroupPanel = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.Caption = "Seleccionar";
            this.Seleccionar.FieldName = "Seleccionar";
            this.Seleccionar.MinWidth = 40;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.Seleccionar.Visible = true;
            this.Seleccionar.VisibleIndex = 0;
            this.Seleccionar.Width = 80;
            // 
            // Código
            // 
            this.Código.Caption = "Código";
            this.Código.FieldName = "codigo";
            this.Código.MinWidth = 40;
            this.Código.Name = "Código";
            this.Código.OptionsColumn.AllowEdit = false;
            this.Código.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Código.Visible = true;
            this.Código.VisibleIndex = 1;
            this.Código.Width = 140;
            // 
            // Marca
            // 
            this.Marca.Caption = "Marca";
            this.Marca.FieldName = "marcaLC";
            this.Marca.MinWidth = 40;
            this.Marca.Name = "Marca";
            this.Marca.OptionsColumn.AllowEdit = false;
            this.Marca.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Marca.Visible = true;
            this.Marca.VisibleIndex = 2;
            this.Marca.Width = 100;
            // 
            // ModeloEquipo
            // 
            this.ModeloEquipo.Caption = "Modelo";
            this.ModeloEquipo.FieldName = "nombreModeloLC";
            this.ModeloEquipo.MinWidth = 40;
            this.ModeloEquipo.Name = "ModeloEquipo";
            this.ModeloEquipo.OptionsColumn.AllowEdit = false;
            this.ModeloEquipo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ModeloEquipo.Visible = true;
            this.ModeloEquipo.VisibleIndex = 3;
            this.ModeloEquipo.Width = 100;
            // 
            // Pantalla
            // 
            this.Pantalla.Caption = "Pantalla";
            this.Pantalla.FieldName = "tamanoPantalla";
            this.Pantalla.MinWidth = 40;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.OptionsColumn.AllowEdit = false;
            this.Pantalla.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Pantalla.Visible = true;
            this.Pantalla.VisibleIndex = 4;
            this.Pantalla.Width = 100;
            // 
            // Procesador
            // 
            this.Procesador.Caption = "Procesador";
            this.Procesador.FieldName = "tipoProcesador";
            this.Procesador.MinWidth = 40;
            this.Procesador.Name = "Procesador";
            this.Procesador.OptionsColumn.AllowEdit = false;
            this.Procesador.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Procesador.Visible = true;
            this.Procesador.VisibleIndex = 5;
            this.Procesador.Width = 100;
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
            this.btnDeseleccionarFilas.Location = new System.Drawing.Point(157, 12);
            this.btnDeseleccionarFilas.Name = "btnDeseleccionarFilas";
            this.btnDeseleccionarFilas.Size = new System.Drawing.Size(144, 50);
            this.btnDeseleccionarFilas.TabIndex = 208;
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
            this.btnSeleccionarFilas.Location = new System.Drawing.Point(23, 12);
            this.btnSeleccionarFilas.Name = "btnSeleccionarFilas";
            this.btnSeleccionarFilas.Size = new System.Drawing.Size(128, 50);
            this.btnSeleccionarFilas.TabIndex = 207;
            this.btnSeleccionarFilas.Text = "Seleccionar Filas";
            this.btnSeleccionarFilas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionarFilas.UseVisualStyleBackColor = false;
            this.btnSeleccionarFilas.Click += new System.EventHandler(this.btnSeleccionarFilas_Click);
            // 
            // generacionProcesador
            // 
            this.generacionProcesador.Caption = "Generación";
            this.generacionProcesador.FieldName = "generacionProcesador";
            this.generacionProcesador.MinWidth = 40;
            this.generacionProcesador.Name = "generacionProcesador";
            this.generacionProcesador.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.generacionProcesador.Visible = true;
            this.generacionProcesador.VisibleIndex = 6;
            this.generacionProcesador.Width = 100;
            // 
            // nombreModeloVideo
            // 
            this.nombreModeloVideo.Caption = "Video";
            this.nombreModeloVideo.FieldName = "nombreModeloVideo";
            this.nombreModeloVideo.Name = "nombreModeloVideo";
            this.nombreModeloVideo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // capacidadVideo
            // 
            this.capacidadVideo.Caption = "Capacidad Video";
            this.capacidadVideo.FieldName = "capacidadVideo";
            this.capacidadVideo.MinWidth = 40;
            this.capacidadVideo.Name = "capacidadVideo";
            this.capacidadVideo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.capacidadVideo.Visible = true;
            this.capacidadVideo.VisibleIndex = 7;
            this.capacidadVideo.Width = 100;
            // 
            // idLC
            // 
            this.idLC.Caption = "gridColumn1";
            this.idLC.FieldName = "idLC";
            this.idLC.Name = "idLC";
            this.idLC.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // idVideo
            // 
            this.idVideo.Caption = "gridColumn1";
            this.idVideo.FieldName = "idVideo";
            this.idVideo.Name = "idVideo";
            this.idVideo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // idProcesador
            // 
            this.idProcesador.Caption = "gridColumn1";
            this.idProcesador.FieldName = "idProcesador";
            this.idProcesador.Name = "idProcesador";
            this.idProcesador.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // frmProcesoCambioAgregarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 368);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.btnDeseleccionarFilas);
            this.Controls.Add(this.btnSeleccionarFilas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoCambioAgregarProducto";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        public DevExpress.XtraGrid.GridControl dgvEquipos;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaEquipos;
        private DevExpress.XtraGrid.Columns.GridColumn Seleccionar;
        private DevExpress.XtraGrid.Columns.GridColumn Código;
        private DevExpress.XtraGrid.Columns.GridColumn Marca;
        private DevExpress.XtraGrid.Columns.GridColumn ModeloEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn Pantalla;
        private DevExpress.XtraGrid.Columns.GridColumn Procesador;
        private System.Windows.Forms.Button btnDeseleccionarFilas;
        private System.Windows.Forms.Button btnSeleccionarFilas;
        private DevExpress.XtraGrid.Columns.GridColumn generacionProcesador;
        private DevExpress.XtraGrid.Columns.GridColumn nombreModeloVideo;
        private DevExpress.XtraGrid.Columns.GridColumn capacidadVideo;
        private DevExpress.XtraGrid.Columns.GridColumn idLC;
        private DevExpress.XtraGrid.Columns.GridColumn idVideo;
        private DevExpress.XtraGrid.Columns.GridColumn idProcesador;
    }
}
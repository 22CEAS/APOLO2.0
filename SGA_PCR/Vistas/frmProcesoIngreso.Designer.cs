namespace Apolo
{
    partial class frmProcesoIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoIngreso));
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.LabelX4 = new DevComponents.DotNetBar.LabelX();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroIngreso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoIngreso = new System.Windows.Forms.ComboBox();
            this.btnAgregarLicencia = new System.Windows.Forms.Button();
            this.btnAgregarDisco = new System.Windows.Forms.Button();
            this.btnAgregarMemoria = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMonedaTipo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMontoCambio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel5 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvLaptopsSeleccionados = new DevExpress.XtraGrid.GridControl();
            this.vistaLaptops = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TipoEquipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Marca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Procesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabLaptops = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel8 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnVisualizarProyectores = new System.Windows.Forms.Button();
            this.btnAgregarProyectores = new System.Windows.Forms.Button();
            this.dgvProyectores = new DevExpress.XtraGrid.GridControl();
            this.vistaProyectores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProyectorTipoEquipoProyector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProyectorMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProyectorNombreModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProyectoCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProyectoPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdIngresoDetalleProyector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProyectorCaracteristica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProyectorTamano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabProyectores = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel7 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnVisualizarMonitores = new System.Windows.Forms.Button();
            this.btnAgregarMonitores = new System.Windows.Forms.Button();
            this.dgvMonitores = new DevExpress.XtraGrid.GridControl();
            this.vistaMonitores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MonitorMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonitorNombreModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonitorTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonitorCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonitorPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdIngresoDetalleMonitor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MonitorTamanoPantalla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabMonitores = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnVisualizarImpresora = new System.Windows.Forms.Button();
            this.btnAgregarImpresora = new System.Windows.Forms.Button();
            this.dgvImpresoras = new DevExpress.XtraGrid.GridControl();
            this.vistaImpresoras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ImpresoraMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImpresoraNombreModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImpresoraTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImpresoraCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImpresoraPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdIngresoDetalleImpresora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabImpresoras = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvDiscos = new DevExpress.XtraGrid.GridControl();
            this.vistaDiscos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapacidadDisco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CantidadDisco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TamanoDisco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrecioDisco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdDisco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabDiscosDuro = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvMemoria = new DevExpress.XtraGrid.GridControl();
            this.vistaMemoria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ModeloMemoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CapacidadMemoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CantidadMemoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoMemoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrecioMemoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdMemoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabMemorias = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel6 = new DevComponents.DotNetBar.TabControlPanel();
            this.btnVisualizarTablets = new System.Windows.Forms.Button();
            this.btnAgregarTablets = new System.Windows.Forms.Button();
            this.dgvTablets = new DevExpress.XtraGrid.GridControl();
            this.vistaTablets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TabletMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabletNombreModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabletProcesador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabletCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabletPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabletTamanoPantalla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdIngresoDetalleTablet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabletSistema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabletRam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabletRom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabTablets = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvLicencias = new DevExpress.XtraGrid.GridControl();
            this.vistaLicencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MarcaLicencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Version = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Clave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CantidadLicencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCategoría = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdLicencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabSoftwares = new DevComponents.DotNetBar.TabItem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptopsSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaLaptops)).BeginInit();
            this.tabControlPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProyectores)).BeginInit();
            this.tabControlPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMonitores)).BeginInit();
            this.tabControlPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpresoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaImpresoras)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDiscos)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMemoria)).BeginInit();
            this.tabControlPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaTablets)).BeginInit();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaLicencias)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(359, 68);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(283, 24);
            this.cmbProveedor.TabIndex = 2;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            // 
            // txtRUC
            // 
            this.txtRUC.Enabled = false;
            this.txtRUC.Location = new System.Drawing.Point(703, 69);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(136, 23);
            this.txtRUC.TabIndex = 3;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(72, 111);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(193, 23);
            this.txtFactura.TabIndex = 5;
            // 
            // dtpFechaIngreso
            // 
            // 
            // 
            // 
            this.dtpFechaIngreso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaIngreso.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFechaIngreso.ButtonDropDown.Visible = true;
            this.dtpFechaIngreso.IsPopupCalendarOpen = false;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(1004, 65);
            // 
            // 
            // 
            this.dtpFechaIngreso.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaIngreso.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.dtpFechaIngreso.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaIngreso.MonthCalendar.DisplayMonth = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.dtpFechaIngreso.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpFechaIngreso.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpFechaIngreso.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaIngreso.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(124, 23);
            this.dtpFechaIngreso.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaIngreso.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(878, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de Ingreso";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.Location = new System.Drawing.Point(753, 49);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarProducto.TabIndex = 9;
            this.btnAgregarProducto.Text = "Agregar Laptops";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // LabelX4
            // 
            this.LabelX4.AutoSize = true;
            // 
            // 
            // 
            this.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.LabelX4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX4.ForeColor = System.Drawing.Color.Black;
            this.LabelX4.Location = new System.Drawing.Point(659, 70);
            this.LabelX4.Name = "LabelX4";
            this.LabelX4.Size = new System.Drawing.Size(28, 18);
            this.LabelX4.TabIndex = 15;
            this.LabelX4.Text = "RUC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(817, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "TOTAL: $25300";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Guía de Remision";
            // 
            // txtGuia
            // 
            this.txtGuia.Location = new System.Drawing.Point(414, 112);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(189, 23);
            this.txtGuia.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AutoSize = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(206, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 56);
            this.btnBuscar.TabIndex = 150;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 149;
            this.label5.Text = "Ingreso N°:";
            // 
            // txtNroIngreso
            // 
            this.txtNroIngreso.Location = new System.Drawing.Point(95, 24);
            this.txtNroIngreso.Name = "txtNroIngreso";
            this.txtNroIngreso.ReadOnly = true;
            this.txtNroIngreso.Size = new System.Drawing.Size(106, 23);
            this.txtNroIngreso.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 152;
            this.label7.Text = "Tipo";
            // 
            // cmbTipoIngreso
            // 
            this.cmbTipoIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTipoIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIngreso.FormattingEnabled = true;
            this.cmbTipoIngreso.Location = new System.Drawing.Point(72, 69);
            this.cmbTipoIngreso.Name = "cmbTipoIngreso";
            this.cmbTipoIngreso.Size = new System.Drawing.Size(193, 24);
            this.cmbTipoIngreso.TabIndex = 1;
            // 
            // btnAgregarLicencia
            // 
            this.btnAgregarLicencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarLicencia.Location = new System.Drawing.Point(773, 62);
            this.btnAgregarLicencia.Name = "btnAgregarLicencia";
            this.btnAgregarLicencia.Size = new System.Drawing.Size(81, 45);
            this.btnAgregarLicencia.TabIndex = 12;
            this.btnAgregarLicencia.Text = "Agregar\r\nSoftware";
            this.btnAgregarLicencia.UseVisualStyleBackColor = true;
            this.btnAgregarLicencia.Click += new System.EventHandler(this.btnAgregarLicencia_Click);
            // 
            // btnAgregarDisco
            // 
            this.btnAgregarDisco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDisco.Location = new System.Drawing.Point(776, 62);
            this.btnAgregarDisco.Name = "btnAgregarDisco";
            this.btnAgregarDisco.Size = new System.Drawing.Size(86, 40);
            this.btnAgregarDisco.TabIndex = 11;
            this.btnAgregarDisco.Text = "Agregar\r\nDiscos";
            this.btnAgregarDisco.UseVisualStyleBackColor = true;
            this.btnAgregarDisco.Click += new System.EventHandler(this.btnAgregarDisco_Click);
            // 
            // btnAgregarMemoria
            // 
            this.btnAgregarMemoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMemoria.Location = new System.Drawing.Point(766, 82);
            this.btnAgregarMemoria.Name = "btnAgregarMemoria";
            this.btnAgregarMemoria.Size = new System.Drawing.Size(85, 45);
            this.btnAgregarMemoria.TabIndex = 10;
            this.btnAgregarMemoria.Text = "Agregar\r\nMemorias";
            this.btnAgregarMemoria.UseVisualStyleBackColor = true;
            this.btnAgregarMemoria.Click += new System.EventHandler(this.btnAgregarMemoria_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnular.AutoSize = true;
            this.btnAnular.BackColor = System.Drawing.Color.Transparent;
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnular.Location = new System.Drawing.Point(19, 387);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(59, 66);
            this.btnAnular.TabIndex = 180;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
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
            this.btnImprimir.Location = new System.Drawing.Point(9, 531);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 66);
            this.btnImprimir.TabIndex = 179;
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
            this.btnCancelar.Location = new System.Drawing.Point(9, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 65);
            this.btnCancelar.TabIndex = 14;
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
            this.btnEditar.Location = new System.Drawing.Point(15, 239);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(78, 65);
            this.btnEditar.TabIndex = 177;
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
            this.btnNuevo.Location = new System.Drawing.Point(16, 163);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 63);
            this.btnNuevo.TabIndex = 176;
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
            this.btnGrabar.Location = new System.Drawing.Point(18, 315);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(66, 64);
            this.btnGrabar.TabIndex = 13;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizar.AutoSize = true;
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisualizar.Location = new System.Drawing.Point(744, 123);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(100, 63);
            this.btnVisualizar.TabIndex = 181;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(656, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 183;
            this.label9.Text = "Moneda";
            // 
            // cmbMonedaTipo
            // 
            this.cmbMonedaTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMonedaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonedaTipo.FormattingEnabled = true;
            this.cmbMonedaTipo.Location = new System.Drawing.Point(720, 116);
            this.cmbMonedaTipo.Name = "cmbMonedaTipo";
            this.cmbMonedaTipo.Size = new System.Drawing.Size(119, 24);
            this.cmbMonedaTipo.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(881, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 185;
            this.label10.Text = "Tipo Cambio";
            // 
            // txtMontoCambio
            // 
            this.txtMontoCambio.Location = new System.Drawing.Point(986, 116);
            this.txtMontoCambio.Name = "txtMontoCambio";
            this.txtMontoCambio.Size = new System.Drawing.Size(119, 23);
            this.txtMontoCambio.TabIndex = 8;
            this.txtMontoCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoCambio_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(734, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 186;
            this.label14.Text = "Precio Sin IGV";
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.SystemColors.Window;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel6);
            this.tabControl1.Controls.Add(this.tabControlPanel5);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel4);
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel8);
            this.tabControl1.Controls.Add(this.tabControlPanel7);
            this.tabControl1.ForeColor = System.Drawing.Color.Black;
            this.tabControl1.Location = new System.Drawing.Point(95, 175);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 381);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document;
            this.tabControl1.TabIndex = 187;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabLaptops);
            this.tabControl1.Tabs.Add(this.tabSoftwares);
            this.tabControl1.Tabs.Add(this.tabMemorias);
            this.tabControl1.Tabs.Add(this.tabDiscosDuro);
            this.tabControl1.Tabs.Add(this.tabImpresoras);
            this.tabControl1.Tabs.Add(this.tabTablets);
            this.tabControl1.Tabs.Add(this.tabMonitores);
            this.tabControl1.Tabs.Add(this.tabProyectores);
            // 
            // tabControlPanel5
            // 
            this.tabControlPanel5.Controls.Add(this.dgvLaptopsSeleccionados);
            this.tabControlPanel5.Controls.Add(this.btnVisualizar);
            this.tabControlPanel5.Controls.Add(this.btnAgregarProducto);
            this.tabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel5.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel5.Name = "tabControlPanel5";
            this.tabControlPanel5.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel5.Size = new System.Drawing.Size(877, 355);
            this.tabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel5.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel5.Style.GradientAngle = 90;
            this.tabControlPanel5.TabIndex = 5;
            this.tabControlPanel5.TabItem = this.tabLaptops;
            this.tabControlPanel5.Text = "VER RESUMEN";
            // 
            // dgvLaptopsSeleccionados
            // 
            this.dgvLaptopsSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLaptopsSeleccionados.Location = new System.Drawing.Point(75, 31);
            this.dgvLaptopsSeleccionados.MainView = this.vistaLaptops;
            this.dgvLaptopsSeleccionados.Name = "dgvLaptopsSeleccionados";
            this.dgvLaptopsSeleccionados.Size = new System.Drawing.Size(628, 304);
            this.dgvLaptopsSeleccionados.TabIndex = 188;
            this.dgvLaptopsSeleccionados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaLaptops});
            this.dgvLaptopsSeleccionados.DoubleClick += new System.EventHandler(this.dgvLaptopsSeleccionados_DoubleClick);
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
            this.vistaLaptops.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TipoEquipo,
            this.Marca,
            this.Modelo,
            this.Procesador,
            this.Cantidad,
            this.IdDetalle});
            this.vistaLaptops.GridControl = this.dgvLaptopsSeleccionados;
            this.vistaLaptops.Name = "vistaLaptops";
            this.vistaLaptops.OptionsBehavior.Editable = false;
            this.vistaLaptops.OptionsCustomization.AllowGroup = false;
            this.vistaLaptops.OptionsDetail.EnableMasterViewMode = false;
            this.vistaLaptops.OptionsView.ColumnAutoWidth = false;
            this.vistaLaptops.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaLaptops.OptionsView.ShowAutoFilterRow = true;
            this.vistaLaptops.OptionsView.ShowGroupPanel = false;
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
            this.TipoEquipo.Visible = true;
            this.TipoEquipo.VisibleIndex = 0;
            this.TipoEquipo.Width = 100;
            // 
            // Marca
            // 
            this.Marca.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Marca.AppearanceHeader.Options.UseBackColor = true;
            this.Marca.Caption = "Marca";
            this.Marca.FieldName = "LaptopMarcaLC";
            this.Marca.MinWidth = 40;
            this.Marca.Name = "Marca";
            this.Marca.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Marca.Visible = true;
            this.Marca.VisibleIndex = 1;
            this.Marca.Width = 140;
            // 
            // Modelo
            // 
            this.Modelo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Modelo.AppearanceHeader.Options.UseBackColor = true;
            this.Modelo.Caption = "Modelo";
            this.Modelo.FieldName = "LaptopNombreModeloLC";
            this.Modelo.MinWidth = 40;
            this.Modelo.Name = "Modelo";
            this.Modelo.Visible = true;
            this.Modelo.VisibleIndex = 2;
            this.Modelo.Width = 140;
            // 
            // Procesador
            // 
            this.Procesador.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Procesador.AppearanceHeader.Options.UseBackColor = true;
            this.Procesador.Caption = "Procesador";
            this.Procesador.FieldName = "LaptopTipoProcesador";
            this.Procesador.MinWidth = 40;
            this.Procesador.Name = "Procesador";
            this.Procesador.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Procesador.Visible = true;
            this.Procesador.VisibleIndex = 3;
            this.Procesador.Width = 100;
            // 
            // Cantidad
            // 
            this.Cantidad.Caption = "Cantidad";
            this.Cantidad.FieldName = "Cantidad";
            this.Cantidad.MinWidth = 40;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Cantidad.Visible = true;
            this.Cantidad.VisibleIndex = 4;
            this.Cantidad.Width = 100;
            // 
            // IdDetalle
            // 
            this.IdDetalle.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdDetalle.AppearanceHeader.Options.UseBackColor = true;
            this.IdDetalle.Caption = "IdDetalle";
            this.IdDetalle.FieldName = "IdIngresoDetalle";
            this.IdDetalle.MinWidth = 40;
            this.IdDetalle.Name = "IdDetalle";
            this.IdDetalle.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IdDetalle.Width = 80;
            // 
            // tabLaptops
            // 
            this.tabLaptops.AttachedControl = this.tabControlPanel5;
            this.tabLaptops.Name = "tabLaptops";
            this.tabLaptops.Text = "Laptops y CPU";
            // 
            // tabControlPanel8
            // 
            this.tabControlPanel8.Controls.Add(this.btnVisualizarProyectores);
            this.tabControlPanel8.Controls.Add(this.btnAgregarProyectores);
            this.tabControlPanel8.Controls.Add(this.dgvProyectores);
            this.tabControlPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel8.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel8.Name = "tabControlPanel8";
            this.tabControlPanel8.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel8.Size = new System.Drawing.Size(877, 355);
            this.tabControlPanel8.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel8.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel8.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel8.Style.GradientAngle = 90;
            this.tabControlPanel8.TabIndex = 8;
            this.tabControlPanel8.TabItem = this.tabProyectores;
            // 
            // btnVisualizarProyectores
            // 
            this.btnVisualizarProyectores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizarProyectores.AutoSize = true;
            this.btnVisualizarProyectores.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizarProyectores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarProyectores.FlatAppearance.BorderSize = 0;
            this.btnVisualizarProyectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarProyectores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarProyectores.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarProyectores.Image")));
            this.btnVisualizarProyectores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisualizarProyectores.Location = new System.Drawing.Point(725, 167);
            this.btnVisualizarProyectores.Name = "btnVisualizarProyectores";
            this.btnVisualizarProyectores.Size = new System.Drawing.Size(100, 63);
            this.btnVisualizarProyectores.TabIndex = 197;
            this.btnVisualizarProyectores.Text = "Visualizar";
            this.btnVisualizarProyectores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizarProyectores.UseVisualStyleBackColor = false;
            this.btnVisualizarProyectores.Click += new System.EventHandler(this.btnVisualizarProyectores_Click);
            // 
            // btnAgregarProyectores
            // 
            this.btnAgregarProyectores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProyectores.Location = new System.Drawing.Point(734, 93);
            this.btnAgregarProyectores.Name = "btnAgregarProyectores";
            this.btnAgregarProyectores.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarProyectores.TabIndex = 196;
            this.btnAgregarProyectores.Text = "Agregar Proyectores";
            this.btnAgregarProyectores.UseVisualStyleBackColor = true;
            this.btnAgregarProyectores.Click += new System.EventHandler(this.btnAgregarProyectores_Click);
            // 
            // dgvProyectores
            // 
            this.dgvProyectores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProyectores.Location = new System.Drawing.Point(112, 26);
            this.dgvProyectores.MainView = this.vistaProyectores;
            this.dgvProyectores.Name = "dgvProyectores";
            this.dgvProyectores.Size = new System.Drawing.Size(565, 304);
            this.dgvProyectores.TabIndex = 191;
            this.dgvProyectores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaProyectores});
            this.dgvProyectores.DoubleClick += new System.EventHandler(this.dgvProyectores_DoubleClick);
            // 
            // vistaProyectores
            // 
            this.vistaProyectores.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaProyectores.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaProyectores.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaProyectores.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaProyectores.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaProyectores.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaProyectores.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaProyectores.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaProyectores.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaProyectores.Appearance.Row.Options.UseFont = true;
            this.vistaProyectores.Appearance.Row.Options.UseForeColor = true;
            this.vistaProyectores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProyectorTipoEquipoProyector,
            this.ProyectorMarca,
            this.ProyectorNombreModelo,
            this.ProyectoCantidad,
            this.ProyectoPrecio,
            this.IdIngresoDetalleProyector,
            this.ProyectorCaracteristica,
            this.ProyectorTamano});
            this.vistaProyectores.GridControl = this.dgvProyectores;
            this.vistaProyectores.Name = "vistaProyectores";
            this.vistaProyectores.OptionsBehavior.Editable = false;
            this.vistaProyectores.OptionsCustomization.AllowGroup = false;
            this.vistaProyectores.OptionsDetail.EnableMasterViewMode = false;
            this.vistaProyectores.OptionsView.ColumnAutoWidth = false;
            this.vistaProyectores.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaProyectores.OptionsView.ShowAutoFilterRow = true;
            this.vistaProyectores.OptionsView.ShowGroupPanel = false;
            // 
            // ProyectorTipoEquipoProyector
            // 
            this.ProyectorTipoEquipoProyector.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProyectorTipoEquipoProyector.AppearanceHeader.Options.UseBackColor = true;
            this.ProyectorTipoEquipoProyector.Caption = "Tipo Equipo";
            this.ProyectorTipoEquipoProyector.FieldName = "ProyectorTipoEquipoProyector";
            this.ProyectorTipoEquipoProyector.MinWidth = 40;
            this.ProyectorTipoEquipoProyector.Name = "ProyectorTipoEquipoProyector";
            this.ProyectorTipoEquipoProyector.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ProyectorTipoEquipoProyector.Visible = true;
            this.ProyectorTipoEquipoProyector.VisibleIndex = 0;
            this.ProyectorTipoEquipoProyector.Width = 150;
            // 
            // ProyectorMarca
            // 
            this.ProyectorMarca.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProyectorMarca.AppearanceHeader.Options.UseBackColor = true;
            this.ProyectorMarca.Caption = "Marca";
            this.ProyectorMarca.FieldName = "ProyectorMarca";
            this.ProyectorMarca.MinWidth = 40;
            this.ProyectorMarca.Name = "ProyectorMarca";
            this.ProyectorMarca.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ProyectorMarca.Visible = true;
            this.ProyectorMarca.VisibleIndex = 1;
            this.ProyectorMarca.Width = 140;
            // 
            // ProyectorNombreModelo
            // 
            this.ProyectorNombreModelo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProyectorNombreModelo.AppearanceHeader.Options.UseBackColor = true;
            this.ProyectorNombreModelo.Caption = "Modelo";
            this.ProyectorNombreModelo.FieldName = "ProyectorNombreModelo";
            this.ProyectorNombreModelo.MinWidth = 40;
            this.ProyectorNombreModelo.Name = "ProyectorNombreModelo";
            this.ProyectorNombreModelo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ProyectorNombreModelo.Visible = true;
            this.ProyectorNombreModelo.VisibleIndex = 2;
            this.ProyectorNombreModelo.Width = 140;
            // 
            // ProyectoCantidad
            // 
            this.ProyectoCantidad.Caption = "Cantidad";
            this.ProyectoCantidad.FieldName = "Cantidad";
            this.ProyectoCantidad.MinWidth = 40;
            this.ProyectoCantidad.Name = "ProyectoCantidad";
            this.ProyectoCantidad.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.ProyectoCantidad.Visible = true;
            this.ProyectoCantidad.VisibleIndex = 3;
            this.ProyectoCantidad.Width = 100;
            // 
            // ProyectoPrecio
            // 
            this.ProyectoPrecio.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProyectoPrecio.AppearanceHeader.Options.UseBackColor = true;
            this.ProyectoPrecio.Caption = "ProyectoPrecio";
            this.ProyectoPrecio.FieldName = "Precio";
            this.ProyectoPrecio.MinWidth = 40;
            this.ProyectoPrecio.Name = "ProyectoPrecio";
            this.ProyectoPrecio.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.ProyectoPrecio.Width = 100;
            // 
            // IdIngresoDetalleProyector
            // 
            this.IdIngresoDetalleProyector.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdIngresoDetalleProyector.AppearanceHeader.Options.UseBackColor = true;
            this.IdIngresoDetalleProyector.Caption = "IdIngresoDetalleProyector";
            this.IdIngresoDetalleProyector.FieldName = "IdIngresoDetalleProyector";
            this.IdIngresoDetalleProyector.MinWidth = 40;
            this.IdIngresoDetalleProyector.Name = "IdIngresoDetalleProyector";
            this.IdIngresoDetalleProyector.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IdIngresoDetalleProyector.Width = 80;
            // 
            // ProyectorCaracteristica
            // 
            this.ProyectorCaracteristica.Caption = "ProyectorCaracteristica";
            this.ProyectorCaracteristica.FieldName = "ProyectorCaracteristica";
            this.ProyectorCaracteristica.Name = "ProyectorCaracteristica";
            this.ProyectorCaracteristica.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // ProyectorTamano
            // 
            this.ProyectorTamano.Caption = "ProyectorTamano";
            this.ProyectorTamano.FieldName = "ProyectorTamano";
            this.ProyectorTamano.Name = "ProyectorTamano";
            this.ProyectorTamano.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // tabProyectores
            // 
            this.tabProyectores.AttachedControl = this.tabControlPanel8;
            this.tabProyectores.Name = "tabProyectores";
            this.tabProyectores.Text = "Proyectores";
            // 
            // tabControlPanel7
            // 
            this.tabControlPanel7.Controls.Add(this.btnVisualizarMonitores);
            this.tabControlPanel7.Controls.Add(this.btnAgregarMonitores);
            this.tabControlPanel7.Controls.Add(this.dgvMonitores);
            this.tabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel7.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel7.Name = "tabControlPanel7";
            this.tabControlPanel7.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel7.Size = new System.Drawing.Size(877, 355);
            this.tabControlPanel7.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel7.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel7.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel7.Style.GradientAngle = 90;
            this.tabControlPanel7.TabIndex = 7;
            this.tabControlPanel7.TabItem = this.tabMonitores;
            // 
            // btnVisualizarMonitores
            // 
            this.btnVisualizarMonitores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizarMonitores.AutoSize = true;
            this.btnVisualizarMonitores.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizarMonitores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarMonitores.FlatAppearance.BorderSize = 0;
            this.btnVisualizarMonitores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarMonitores.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarMonitores.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarMonitores.Image")));
            this.btnVisualizarMonitores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisualizarMonitores.Location = new System.Drawing.Point(732, 167);
            this.btnVisualizarMonitores.Name = "btnVisualizarMonitores";
            this.btnVisualizarMonitores.Size = new System.Drawing.Size(100, 63);
            this.btnVisualizarMonitores.TabIndex = 195;
            this.btnVisualizarMonitores.Text = "Visualizar";
            this.btnVisualizarMonitores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizarMonitores.UseVisualStyleBackColor = false;
            this.btnVisualizarMonitores.Click += new System.EventHandler(this.btnVisualizarMonitores_Click);
            // 
            // btnAgregarMonitores
            // 
            this.btnAgregarMonitores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMonitores.Location = new System.Drawing.Point(741, 93);
            this.btnAgregarMonitores.Name = "btnAgregarMonitores";
            this.btnAgregarMonitores.Size = new System.Drawing.Size(91, 41);
            this.btnAgregarMonitores.TabIndex = 194;
            this.btnAgregarMonitores.Text = "Agregar Monitores";
            this.btnAgregarMonitores.UseVisualStyleBackColor = true;
            this.btnAgregarMonitores.Click += new System.EventHandler(this.btnAgregarMonitores_Click);
            // 
            // dgvMonitores
            // 
            this.dgvMonitores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonitores.Location = new System.Drawing.Point(67, 27);
            this.dgvMonitores.MainView = this.vistaMonitores;
            this.dgvMonitores.Name = "dgvMonitores";
            this.dgvMonitores.Size = new System.Drawing.Size(616, 304);
            this.dgvMonitores.TabIndex = 190;
            this.dgvMonitores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaMonitores});
            this.dgvMonitores.DoubleClick += new System.EventHandler(this.dgvMonitores_DoubleClick);
            // 
            // vistaMonitores
            // 
            this.vistaMonitores.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaMonitores.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaMonitores.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaMonitores.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaMonitores.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaMonitores.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaMonitores.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaMonitores.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaMonitores.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaMonitores.Appearance.Row.Options.UseFont = true;
            this.vistaMonitores.Appearance.Row.Options.UseForeColor = true;
            this.vistaMonitores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MonitorMarca,
            this.MonitorNombreModelo,
            this.MonitorTipo,
            this.MonitorCantidad,
            this.MonitorPrecio,
            this.IdIngresoDetalleMonitor,
            this.MonitorTamanoPantalla});
            this.vistaMonitores.GridControl = this.dgvMonitores;
            this.vistaMonitores.Name = "vistaMonitores";
            this.vistaMonitores.OptionsBehavior.Editable = false;
            this.vistaMonitores.OptionsCustomization.AllowGroup = false;
            this.vistaMonitores.OptionsDetail.EnableMasterViewMode = false;
            this.vistaMonitores.OptionsView.ColumnAutoWidth = false;
            this.vistaMonitores.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaMonitores.OptionsView.ShowAutoFilterRow = true;
            this.vistaMonitores.OptionsView.ShowGroupPanel = false;
            // 
            // MonitorMarca
            // 
            this.MonitorMarca.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MonitorMarca.AppearanceHeader.Options.UseBackColor = true;
            this.MonitorMarca.Caption = "Marca";
            this.MonitorMarca.FieldName = "MonitorMarca";
            this.MonitorMarca.MinWidth = 40;
            this.MonitorMarca.Name = "MonitorMarca";
            this.MonitorMarca.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MonitorMarca.Visible = true;
            this.MonitorMarca.VisibleIndex = 0;
            this.MonitorMarca.Width = 140;
            // 
            // MonitorNombreModelo
            // 
            this.MonitorNombreModelo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MonitorNombreModelo.AppearanceHeader.Options.UseBackColor = true;
            this.MonitorNombreModelo.Caption = "Modelo";
            this.MonitorNombreModelo.FieldName = "MonitorNombreModelo";
            this.MonitorNombreModelo.MinWidth = 40;
            this.MonitorNombreModelo.Name = "MonitorNombreModelo";
            this.MonitorNombreModelo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MonitorNombreModelo.Visible = true;
            this.MonitorNombreModelo.VisibleIndex = 1;
            this.MonitorNombreModelo.Width = 140;
            // 
            // MonitorTipo
            // 
            this.MonitorTipo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MonitorTipo.AppearanceHeader.Options.UseBackColor = true;
            this.MonitorTipo.Caption = "Tipo";
            this.MonitorTipo.FieldName = "MonitorTipo";
            this.MonitorTipo.MinWidth = 40;
            this.MonitorTipo.Name = "MonitorTipo";
            this.MonitorTipo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.MonitorTipo.Visible = true;
            this.MonitorTipo.VisibleIndex = 2;
            this.MonitorTipo.Width = 200;
            // 
            // MonitorCantidad
            // 
            this.MonitorCantidad.Caption = "Cantidad";
            this.MonitorCantidad.FieldName = "Cantidad";
            this.MonitorCantidad.MinWidth = 40;
            this.MonitorCantidad.Name = "MonitorCantidad";
            this.MonitorCantidad.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.MonitorCantidad.Visible = true;
            this.MonitorCantidad.VisibleIndex = 3;
            this.MonitorCantidad.Width = 100;
            // 
            // MonitorPrecio
            // 
            this.MonitorPrecio.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MonitorPrecio.AppearanceHeader.Options.UseBackColor = true;
            this.MonitorPrecio.Caption = "Precio";
            this.MonitorPrecio.FieldName = "Precio";
            this.MonitorPrecio.MinWidth = 40;
            this.MonitorPrecio.Name = "MonitorPrecio";
            this.MonitorPrecio.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.MonitorPrecio.Width = 100;
            // 
            // IdIngresoDetalleMonitor
            // 
            this.IdIngresoDetalleMonitor.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdIngresoDetalleMonitor.AppearanceHeader.Options.UseBackColor = true;
            this.IdIngresoDetalleMonitor.Caption = "IdIngresoDetalleMonitor";
            this.IdIngresoDetalleMonitor.FieldName = "IdIngresoDetalleMonitor";
            this.IdIngresoDetalleMonitor.MinWidth = 40;
            this.IdIngresoDetalleMonitor.Name = "IdIngresoDetalleMonitor";
            this.IdIngresoDetalleMonitor.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IdIngresoDetalleMonitor.Width = 80;
            // 
            // MonitorTamanoPantalla
            // 
            this.MonitorTamanoPantalla.Caption = "MonitorTamanoPantalla";
            this.MonitorTamanoPantalla.FieldName = "MonitorTamanoPantalla";
            this.MonitorTamanoPantalla.Name = "MonitorTamanoPantalla";
            this.MonitorTamanoPantalla.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // tabMonitores
            // 
            this.tabMonitores.AttachedControl = this.tabControlPanel7;
            this.tabMonitores.Name = "tabMonitores";
            this.tabMonitores.Text = "Monitores";
            // 
            // tabControlPanel4
            // 
            this.tabControlPanel4.Controls.Add(this.btnVisualizarImpresora);
            this.tabControlPanel4.Controls.Add(this.btnAgregarImpresora);
            this.tabControlPanel4.Controls.Add(this.dgvImpresoras);
            this.tabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel4.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel4.Name = "tabControlPanel4";
            this.tabControlPanel4.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel4.Size = new System.Drawing.Size(877, 355);
            this.tabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel4.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel4.Style.GradientAngle = 90;
            this.tabControlPanel4.TabIndex = 4;
            this.tabControlPanel4.TabItem = this.tabImpresoras;
            // 
            // btnVisualizarImpresora
            // 
            this.btnVisualizarImpresora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizarImpresora.AutoSize = true;
            this.btnVisualizarImpresora.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizarImpresora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarImpresora.FlatAppearance.BorderSize = 0;
            this.btnVisualizarImpresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarImpresora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarImpresora.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarImpresora.Image")));
            this.btnVisualizarImpresora.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisualizarImpresora.Location = new System.Drawing.Point(735, 136);
            this.btnVisualizarImpresora.Name = "btnVisualizarImpresora";
            this.btnVisualizarImpresora.Size = new System.Drawing.Size(100, 63);
            this.btnVisualizarImpresora.TabIndex = 191;
            this.btnVisualizarImpresora.Text = "Visualizar";
            this.btnVisualizarImpresora.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizarImpresora.UseVisualStyleBackColor = false;
            this.btnVisualizarImpresora.Click += new System.EventHandler(this.btnVisualizarImpresora_Click);
            // 
            // btnAgregarImpresora
            // 
            this.btnAgregarImpresora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImpresora.Location = new System.Drawing.Point(735, 62);
            this.btnAgregarImpresora.Name = "btnAgregarImpresora";
            this.btnAgregarImpresora.Size = new System.Drawing.Size(91, 41);
            this.btnAgregarImpresora.TabIndex = 190;
            this.btnAgregarImpresora.Text = "Agregar Impresoras";
            this.btnAgregarImpresora.UseVisualStyleBackColor = true;
            this.btnAgregarImpresora.Click += new System.EventHandler(this.btnAgregarImpresora_Click);
            // 
            // dgvImpresoras
            // 
            this.dgvImpresoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvImpresoras.Location = new System.Drawing.Point(67, 23);
            this.dgvImpresoras.MainView = this.vistaImpresoras;
            this.dgvImpresoras.Name = "dgvImpresoras";
            this.dgvImpresoras.Size = new System.Drawing.Size(616, 304);
            this.dgvImpresoras.TabIndex = 189;
            this.dgvImpresoras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaImpresoras});
            this.dgvImpresoras.DoubleClick += new System.EventHandler(this.dgvImpresoras_DoubleClick);
            // 
            // vistaImpresoras
            // 
            this.vistaImpresoras.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaImpresoras.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaImpresoras.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaImpresoras.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaImpresoras.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaImpresoras.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaImpresoras.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaImpresoras.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaImpresoras.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaImpresoras.Appearance.Row.Options.UseFont = true;
            this.vistaImpresoras.Appearance.Row.Options.UseForeColor = true;
            this.vistaImpresoras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ImpresoraMarca,
            this.ImpresoraNombreModelo,
            this.ImpresoraTipo,
            this.ImpresoraCantidad,
            this.ImpresoraPrecio,
            this.IdIngresoDetalleImpresora});
            this.vistaImpresoras.GridControl = this.dgvImpresoras;
            this.vistaImpresoras.Name = "vistaImpresoras";
            this.vistaImpresoras.OptionsBehavior.Editable = false;
            this.vistaImpresoras.OptionsCustomization.AllowGroup = false;
            this.vistaImpresoras.OptionsDetail.EnableMasterViewMode = false;
            this.vistaImpresoras.OptionsView.ColumnAutoWidth = false;
            this.vistaImpresoras.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaImpresoras.OptionsView.ShowAutoFilterRow = true;
            this.vistaImpresoras.OptionsView.ShowGroupPanel = false;
            // 
            // ImpresoraMarca
            // 
            this.ImpresoraMarca.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ImpresoraMarca.AppearanceHeader.Options.UseBackColor = true;
            this.ImpresoraMarca.Caption = "Marca";
            this.ImpresoraMarca.FieldName = "ImpresoraMarca";
            this.ImpresoraMarca.MinWidth = 40;
            this.ImpresoraMarca.Name = "ImpresoraMarca";
            this.ImpresoraMarca.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ImpresoraMarca.Visible = true;
            this.ImpresoraMarca.VisibleIndex = 0;
            this.ImpresoraMarca.Width = 140;
            // 
            // ImpresoraNombreModelo
            // 
            this.ImpresoraNombreModelo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ImpresoraNombreModelo.AppearanceHeader.Options.UseBackColor = true;
            this.ImpresoraNombreModelo.Caption = "Modelo";
            this.ImpresoraNombreModelo.FieldName = "ImpresoraNombreModelo";
            this.ImpresoraNombreModelo.MinWidth = 40;
            this.ImpresoraNombreModelo.Name = "ImpresoraNombreModelo";
            this.ImpresoraNombreModelo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ImpresoraNombreModelo.Visible = true;
            this.ImpresoraNombreModelo.VisibleIndex = 1;
            this.ImpresoraNombreModelo.Width = 140;
            // 
            // ImpresoraTipo
            // 
            this.ImpresoraTipo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ImpresoraTipo.AppearanceHeader.Options.UseBackColor = true;
            this.ImpresoraTipo.Caption = "Caracteristica";
            this.ImpresoraTipo.FieldName = "ImpresoraTipo";
            this.ImpresoraTipo.MinWidth = 40;
            this.ImpresoraTipo.Name = "ImpresoraTipo";
            this.ImpresoraTipo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ImpresoraTipo.Visible = true;
            this.ImpresoraTipo.VisibleIndex = 2;
            this.ImpresoraTipo.Width = 200;
            // 
            // ImpresoraCantidad
            // 
            this.ImpresoraCantidad.Caption = "Cantidad";
            this.ImpresoraCantidad.FieldName = "Cantidad";
            this.ImpresoraCantidad.MinWidth = 40;
            this.ImpresoraCantidad.Name = "ImpresoraCantidad";
            this.ImpresoraCantidad.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.ImpresoraCantidad.Visible = true;
            this.ImpresoraCantidad.VisibleIndex = 3;
            this.ImpresoraCantidad.Width = 100;
            // 
            // ImpresoraPrecio
            // 
            this.ImpresoraPrecio.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ImpresoraPrecio.AppearanceHeader.Options.UseBackColor = true;
            this.ImpresoraPrecio.Caption = "Precio";
            this.ImpresoraPrecio.FieldName = "Precio";
            this.ImpresoraPrecio.MinWidth = 40;
            this.ImpresoraPrecio.Name = "ImpresoraPrecio";
            this.ImpresoraPrecio.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.ImpresoraPrecio.Width = 100;
            // 
            // IdIngresoDetalleImpresora
            // 
            this.IdIngresoDetalleImpresora.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdIngresoDetalleImpresora.AppearanceHeader.Options.UseBackColor = true;
            this.IdIngresoDetalleImpresora.Caption = "IdIngresoDetalleImpresora";
            this.IdIngresoDetalleImpresora.FieldName = "IdIngresoDetalleImpresora";
            this.IdIngresoDetalleImpresora.MinWidth = 40;
            this.IdIngresoDetalleImpresora.Name = "IdIngresoDetalleImpresora";
            this.IdIngresoDetalleImpresora.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IdIngresoDetalleImpresora.Width = 80;
            // 
            // tabImpresoras
            // 
            this.tabImpresoras.AttachedControl = this.tabControlPanel4;
            this.tabImpresoras.Name = "tabImpresoras";
            this.tabImpresoras.Text = "Impresoras";
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.dgvDiscos);
            this.tabControlPanel3.Controls.Add(this.btnAgregarDisco);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(877, 355);
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabDiscosDuro;
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiscos.Location = new System.Drawing.Point(59, 21);
            this.dgvDiscos.MainView = this.vistaDiscos;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.Size = new System.Drawing.Size(685, 310);
            this.dgvDiscos.TabIndex = 191;
            this.dgvDiscos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaDiscos});
            this.dgvDiscos.DoubleClick += new System.EventHandler(this.dgvDiscos_DoubleClick);
            // 
            // vistaDiscos
            // 
            this.vistaDiscos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaDiscos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaDiscos.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaDiscos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaDiscos.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaDiscos.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaDiscos.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaDiscos.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaDiscos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaDiscos.Appearance.Row.Options.UseFont = true;
            this.vistaDiscos.Appearance.Row.Options.UseForeColor = true;
            this.vistaDiscos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tipo,
            this.CapacidadDisco,
            this.CantidadDisco,
            this.TamanoDisco,
            this.PrecioDisco,
            this.IdDisco});
            this.vistaDiscos.GridControl = this.dgvDiscos;
            this.vistaDiscos.Name = "vistaDiscos";
            this.vistaDiscos.OptionsCustomization.AllowGroup = false;
            this.vistaDiscos.OptionsDetail.EnableMasterViewMode = false;
            this.vistaDiscos.OptionsView.ColumnAutoWidth = false;
            this.vistaDiscos.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaDiscos.OptionsView.ShowAutoFilterRow = true;
            this.vistaDiscos.OptionsView.ShowGroupPanel = false;
            this.vistaDiscos.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.vistaDiscos_CellValueChanged);
            // 
            // Tipo
            // 
            this.Tipo.Caption = "TipoDisco";
            this.Tipo.FieldName = "TipoDisco";
            this.Tipo.MinWidth = 40;
            this.Tipo.Name = "Tipo";
            this.Tipo.OptionsColumn.AllowEdit = false;
            this.Tipo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Tipo.Visible = true;
            this.Tipo.VisibleIndex = 0;
            this.Tipo.Width = 130;
            // 
            // CapacidadDisco
            // 
            this.CapacidadDisco.Caption = "Capacidad";
            this.CapacidadDisco.FieldName = "Capacidad";
            this.CapacidadDisco.MinWidth = 40;
            this.CapacidadDisco.Name = "CapacidadDisco";
            this.CapacidadDisco.OptionsColumn.AllowEdit = false;
            this.CapacidadDisco.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.CapacidadDisco.Visible = true;
            this.CapacidadDisco.VisibleIndex = 1;
            this.CapacidadDisco.Width = 130;
            // 
            // CantidadDisco
            // 
            this.CantidadDisco.Caption = "Cantidad";
            this.CantidadDisco.FieldName = "Cantidad";
            this.CantidadDisco.MinWidth = 40;
            this.CantidadDisco.Name = "CantidadDisco";
            this.CantidadDisco.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.CantidadDisco.Visible = true;
            this.CantidadDisco.VisibleIndex = 2;
            this.CantidadDisco.Width = 130;
            // 
            // TamanoDisco
            // 
            this.TamanoDisco.Caption = "Tamano";
            this.TamanoDisco.FieldName = "Tamano";
            this.TamanoDisco.MinWidth = 40;
            this.TamanoDisco.Name = "TamanoDisco";
            this.TamanoDisco.OptionsColumn.AllowEdit = false;
            this.TamanoDisco.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TamanoDisco.Visible = true;
            this.TamanoDisco.VisibleIndex = 3;
            this.TamanoDisco.Width = 130;
            // 
            // PrecioDisco
            // 
            this.PrecioDisco.Caption = "Precio";
            this.PrecioDisco.FieldName = "Precio";
            this.PrecioDisco.MinWidth = 40;
            this.PrecioDisco.Name = "PrecioDisco";
            this.PrecioDisco.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.PrecioDisco.Visible = true;
            this.PrecioDisco.VisibleIndex = 4;
            this.PrecioDisco.Width = 130;
            // 
            // IdDisco
            // 
            this.IdDisco.Caption = "IdDisco";
            this.IdDisco.FieldName = "IdDisco";
            this.IdDisco.Name = "IdDisco";
            this.IdDisco.OptionsColumn.AllowEdit = false;
            this.IdDisco.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // tabDiscosDuro
            // 
            this.tabDiscosDuro.AttachedControl = this.tabControlPanel3;
            this.tabDiscosDuro.Name = "tabDiscosDuro";
            this.tabDiscosDuro.Text = "Disco Duro";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.dgvMemoria);
            this.tabControlPanel2.Controls.Add(this.btnAgregarMemoria);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(877, 355);
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabMemorias;
            // 
            // dgvMemoria
            // 
            this.dgvMemoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMemoria.Location = new System.Drawing.Point(52, 31);
            this.dgvMemoria.MainView = this.vistaMemoria;
            this.dgvMemoria.Name = "dgvMemoria";
            this.dgvMemoria.Size = new System.Drawing.Size(686, 290);
            this.dgvMemoria.TabIndex = 190;
            this.dgvMemoria.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaMemoria});
            this.dgvMemoria.DoubleClick += new System.EventHandler(this.dgvMemoria_DoubleClick);
            // 
            // vistaMemoria
            // 
            this.vistaMemoria.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaMemoria.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaMemoria.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaMemoria.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaMemoria.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaMemoria.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaMemoria.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaMemoria.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaMemoria.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaMemoria.Appearance.Row.Options.UseFont = true;
            this.vistaMemoria.Appearance.Row.Options.UseForeColor = true;
            this.vistaMemoria.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ModeloMemoria,
            this.CapacidadMemoria,
            this.CantidadMemoria,
            this.TipoMemoria,
            this.PrecioMemoria,
            this.IdMemoria});
            this.vistaMemoria.GridControl = this.dgvMemoria;
            this.vistaMemoria.Name = "vistaMemoria";
            this.vistaMemoria.OptionsCustomization.AllowGroup = false;
            this.vistaMemoria.OptionsDetail.EnableMasterViewMode = false;
            this.vistaMemoria.OptionsView.ColumnAutoWidth = false;
            this.vistaMemoria.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaMemoria.OptionsView.ShowAutoFilterRow = true;
            this.vistaMemoria.OptionsView.ShowGroupPanel = false;
            this.vistaMemoria.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.vistaMemoria_CellValueChanged);
            // 
            // ModeloMemoria
            // 
            this.ModeloMemoria.Caption = "Modelo";
            this.ModeloMemoria.FieldName = "TipoMemoria";
            this.ModeloMemoria.MinWidth = 40;
            this.ModeloMemoria.Name = "ModeloMemoria";
            this.ModeloMemoria.OptionsColumn.AllowEdit = false;
            this.ModeloMemoria.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ModeloMemoria.Visible = true;
            this.ModeloMemoria.VisibleIndex = 0;
            this.ModeloMemoria.Width = 130;
            // 
            // CapacidadMemoria
            // 
            this.CapacidadMemoria.Caption = "Capacidad";
            this.CapacidadMemoria.FieldName = "Capacidad";
            this.CapacidadMemoria.MinWidth = 40;
            this.CapacidadMemoria.Name = "CapacidadMemoria";
            this.CapacidadMemoria.OptionsColumn.AllowEdit = false;
            this.CapacidadMemoria.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.CapacidadMemoria.Visible = true;
            this.CapacidadMemoria.VisibleIndex = 1;
            this.CapacidadMemoria.Width = 130;
            // 
            // CantidadMemoria
            // 
            this.CantidadMemoria.Caption = "Cantidad";
            this.CantidadMemoria.FieldName = "Cantidad";
            this.CantidadMemoria.MinWidth = 40;
            this.CantidadMemoria.Name = "CantidadMemoria";
            this.CantidadMemoria.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.CantidadMemoria.Visible = true;
            this.CantidadMemoria.VisibleIndex = 2;
            this.CantidadMemoria.Width = 130;
            // 
            // TipoMemoria
            // 
            this.TipoMemoria.Caption = "Tipo";
            this.TipoMemoria.FieldName = "Tipo2";
            this.TipoMemoria.MinWidth = 40;
            this.TipoMemoria.Name = "TipoMemoria";
            this.TipoMemoria.OptionsColumn.AllowEdit = false;
            this.TipoMemoria.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TipoMemoria.Visible = true;
            this.TipoMemoria.VisibleIndex = 3;
            this.TipoMemoria.Width = 130;
            // 
            // PrecioMemoria
            // 
            this.PrecioMemoria.Caption = "Precio";
            this.PrecioMemoria.FieldName = "Precio";
            this.PrecioMemoria.MinWidth = 40;
            this.PrecioMemoria.Name = "PrecioMemoria";
            this.PrecioMemoria.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.PrecioMemoria.Visible = true;
            this.PrecioMemoria.VisibleIndex = 4;
            this.PrecioMemoria.Width = 130;
            // 
            // IdMemoria
            // 
            this.IdMemoria.Caption = "IdMemoria";
            this.IdMemoria.FieldName = "IdMemoria";
            this.IdMemoria.Name = "IdMemoria";
            this.IdMemoria.OptionsColumn.AllowEdit = false;
            this.IdMemoria.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // tabMemorias
            // 
            this.tabMemorias.AttachedControl = this.tabControlPanel2;
            this.tabMemorias.Name = "tabMemorias";
            this.tabMemorias.Text = "Memoria";
            // 
            // tabControlPanel6
            // 
            this.tabControlPanel6.Controls.Add(this.btnVisualizarTablets);
            this.tabControlPanel6.Controls.Add(this.btnAgregarTablets);
            this.tabControlPanel6.Controls.Add(this.dgvTablets);
            this.tabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel6.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel6.Name = "tabControlPanel6";
            this.tabControlPanel6.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel6.Size = new System.Drawing.Size(877, 355);
            this.tabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel6.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel6.Style.GradientAngle = 90;
            this.tabControlPanel6.TabIndex = 6;
            this.tabControlPanel6.TabItem = this.tabTablets;
            // 
            // btnVisualizarTablets
            // 
            this.btnVisualizarTablets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizarTablets.AutoSize = true;
            this.btnVisualizarTablets.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizarTablets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarTablets.FlatAppearance.BorderSize = 0;
            this.btnVisualizarTablets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarTablets.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarTablets.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarTablets.Image")));
            this.btnVisualizarTablets.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVisualizarTablets.Location = new System.Drawing.Point(723, 160);
            this.btnVisualizarTablets.Name = "btnVisualizarTablets";
            this.btnVisualizarTablets.Size = new System.Drawing.Size(100, 63);
            this.btnVisualizarTablets.TabIndex = 193;
            this.btnVisualizarTablets.Text = "Visualizar";
            this.btnVisualizarTablets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizarTablets.UseVisualStyleBackColor = false;
            this.btnVisualizarTablets.Click += new System.EventHandler(this.btnVisualizarTablets_Click);
            // 
            // btnAgregarTablets
            // 
            this.btnAgregarTablets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTablets.Location = new System.Drawing.Point(732, 86);
            this.btnAgregarTablets.Name = "btnAgregarTablets";
            this.btnAgregarTablets.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarTablets.TabIndex = 192;
            this.btnAgregarTablets.Text = "Agregar Tablets";
            this.btnAgregarTablets.UseVisualStyleBackColor = true;
            this.btnAgregarTablets.Click += new System.EventHandler(this.btnAgregarTablets_Click);
            // 
            // dgvTablets
            // 
            this.dgvTablets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablets.Location = new System.Drawing.Point(71, 26);
            this.dgvTablets.MainView = this.vistaTablets;
            this.dgvTablets.Name = "dgvTablets";
            this.dgvTablets.Size = new System.Drawing.Size(616, 304);
            this.dgvTablets.TabIndex = 190;
            this.dgvTablets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaTablets});
            this.dgvTablets.DoubleClick += new System.EventHandler(this.dgvTablets_DoubleClick);
            // 
            // vistaTablets
            // 
            this.vistaTablets.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaTablets.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaTablets.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaTablets.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaTablets.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaTablets.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaTablets.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaTablets.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaTablets.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaTablets.Appearance.Row.Options.UseFont = true;
            this.vistaTablets.Appearance.Row.Options.UseForeColor = true;
            this.vistaTablets.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TabletMarca,
            this.TabletNombreModelo,
            this.TabletProcesador,
            this.TabletCantidad,
            this.TabletPrecio,
            this.TabletTamanoPantalla,
            this.IdIngresoDetalleTablet,
            this.TabletSistema,
            this.TabletRam,
            this.TabletRom});
            this.vistaTablets.GridControl = this.dgvTablets;
            this.vistaTablets.Name = "vistaTablets";
            this.vistaTablets.OptionsBehavior.Editable = false;
            this.vistaTablets.OptionsCustomization.AllowGroup = false;
            this.vistaTablets.OptionsDetail.EnableMasterViewMode = false;
            this.vistaTablets.OptionsView.ColumnAutoWidth = false;
            this.vistaTablets.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaTablets.OptionsView.ShowAutoFilterRow = true;
            this.vistaTablets.OptionsView.ShowGroupPanel = false;
            // 
            // TabletMarca
            // 
            this.TabletMarca.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TabletMarca.AppearanceHeader.Options.UseBackColor = true;
            this.TabletMarca.Caption = "Marca";
            this.TabletMarca.FieldName = "TabletMarca";
            this.TabletMarca.MinWidth = 40;
            this.TabletMarca.Name = "TabletMarca";
            this.TabletMarca.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TabletMarca.Visible = true;
            this.TabletMarca.VisibleIndex = 0;
            this.TabletMarca.Width = 140;
            // 
            // TabletNombreModelo
            // 
            this.TabletNombreModelo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TabletNombreModelo.AppearanceHeader.Options.UseBackColor = true;
            this.TabletNombreModelo.Caption = "Modelo";
            this.TabletNombreModelo.FieldName = "TabletNombreModelo";
            this.TabletNombreModelo.MinWidth = 40;
            this.TabletNombreModelo.Name = "TabletNombreModelo";
            this.TabletNombreModelo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TabletNombreModelo.Visible = true;
            this.TabletNombreModelo.VisibleIndex = 1;
            this.TabletNombreModelo.Width = 140;
            // 
            // TabletProcesador
            // 
            this.TabletProcesador.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TabletProcesador.AppearanceHeader.Options.UseBackColor = true;
            this.TabletProcesador.Caption = "Procesador";
            this.TabletProcesador.FieldName = "TabletProcesador";
            this.TabletProcesador.MinWidth = 40;
            this.TabletProcesador.Name = "TabletProcesador";
            this.TabletProcesador.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.TabletProcesador.Visible = true;
            this.TabletProcesador.VisibleIndex = 2;
            this.TabletProcesador.Width = 200;
            // 
            // TabletCantidad
            // 
            this.TabletCantidad.Caption = "Cantidad";
            this.TabletCantidad.FieldName = "Cantidad";
            this.TabletCantidad.MinWidth = 40;
            this.TabletCantidad.Name = "TabletCantidad";
            this.TabletCantidad.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.TabletCantidad.Visible = true;
            this.TabletCantidad.VisibleIndex = 3;
            this.TabletCantidad.Width = 100;
            // 
            // TabletPrecio
            // 
            this.TabletPrecio.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TabletPrecio.AppearanceHeader.Options.UseBackColor = true;
            this.TabletPrecio.Caption = "Precio";
            this.TabletPrecio.FieldName = "Precio";
            this.TabletPrecio.MinWidth = 40;
            this.TabletPrecio.Name = "TabletPrecio";
            this.TabletPrecio.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.TabletPrecio.Width = 100;
            // 
            // TabletTamanoPantalla
            // 
            this.TabletTamanoPantalla.Caption = "TabletTamanoPantalla";
            this.TabletTamanoPantalla.FieldName = "TabletTamanoPantalla";
            this.TabletTamanoPantalla.Name = "TabletTamanoPantalla";
            this.TabletTamanoPantalla.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            // 
            // IdIngresoDetalleTablet
            // 
            this.IdIngresoDetalleTablet.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IdIngresoDetalleTablet.AppearanceHeader.Options.UseBackColor = true;
            this.IdIngresoDetalleTablet.Caption = "IdIngresoDetalleTablet";
            this.IdIngresoDetalleTablet.FieldName = "IdIngresoDetalleTablet";
            this.IdIngresoDetalleTablet.MinWidth = 40;
            this.IdIngresoDetalleTablet.Name = "IdIngresoDetalleTablet";
            this.IdIngresoDetalleTablet.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IdIngresoDetalleTablet.Width = 80;
            // 
            // TabletSistema
            // 
            this.TabletSistema.Caption = "TabletSistema";
            this.TabletSistema.FieldName = "TabletSistema";
            this.TabletSistema.Name = "TabletSistema";
            this.TabletSistema.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // TabletRam
            // 
            this.TabletRam.Caption = "TabletRam";
            this.TabletRam.FieldName = "TabletRam";
            this.TabletRam.Name = "TabletRam";
            this.TabletRam.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // TabletRom
            // 
            this.TabletRom.Caption = "TabletRom";
            this.TabletRom.FieldName = "TabletRom";
            this.TabletRom.Name = "TabletRom";
            this.TabletRom.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // tabTablets
            // 
            this.tabTablets.AttachedControl = this.tabControlPanel6;
            this.tabTablets.Name = "tabTablets";
            this.tabTablets.Text = "Tablets";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.dgvLicencias);
            this.tabControlPanel1.Controls.Add(this.btnAgregarLicencia);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(877, 355);
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(247)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabSoftwares;
            // 
            // dgvLicencias
            // 
            this.dgvLicencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLicencias.Location = new System.Drawing.Point(52, 31);
            this.dgvLicencias.MainView = this.vistaLicencias;
            this.dgvLicencias.Name = "dgvLicencias";
            this.dgvLicencias.Size = new System.Drawing.Size(696, 305);
            this.dgvLicencias.TabIndex = 189;
            this.dgvLicencias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaLicencias});
            this.dgvLicencias.DoubleClick += new System.EventHandler(this.dgvLicencias_DoubleClick);
            // 
            // vistaLicencias
            // 
            this.vistaLicencias.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaLicencias.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaLicencias.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaLicencias.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaLicencias.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaLicencias.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaLicencias.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaLicencias.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vistaLicencias.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaLicencias.Appearance.Row.Options.UseFont = true;
            this.vistaLicencias.Appearance.Row.Options.UseForeColor = true;
            this.vistaLicencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Categoria,
            this.MarcaLicencia,
            this.Version,
            this.Clave,
            this.CantidadLicencia,
            this.Precio,
            this.IdCategoría,
            this.IdModelo,
            this.IdLicencia});
            this.vistaLicencias.GridControl = this.dgvLicencias;
            this.vistaLicencias.Name = "vistaLicencias";
            this.vistaLicencias.OptionsCustomization.AllowGroup = false;
            this.vistaLicencias.OptionsDetail.EnableMasterViewMode = false;
            this.vistaLicencias.OptionsView.ColumnAutoWidth = false;
            this.vistaLicencias.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaLicencias.OptionsView.ShowAutoFilterRow = true;
            this.vistaLicencias.OptionsView.ShowGroupPanel = false;
            this.vistaLicencias.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.vistaLicencias_CellValueChanged);
            // 
            // Categoria
            // 
            this.Categoria.Caption = "Categoria";
            this.Categoria.FieldName = "Categoria";
            this.Categoria.MinWidth = 40;
            this.Categoria.Name = "Categoria";
            this.Categoria.OptionsColumn.AllowEdit = false;
            this.Categoria.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Categoria.Visible = true;
            this.Categoria.VisibleIndex = 0;
            this.Categoria.Width = 100;
            // 
            // MarcaLicencia
            // 
            this.MarcaLicencia.Caption = "Marca";
            this.MarcaLicencia.FieldName = "Marca";
            this.MarcaLicencia.Name = "MarcaLicencia";
            this.MarcaLicencia.OptionsColumn.AllowEdit = false;
            this.MarcaLicencia.UnboundType = DevExpress.Data.UnboundColumnType.String;
            // 
            // Version
            // 
            this.Version.Caption = "Version";
            this.Version.FieldName = "Version";
            this.Version.MinWidth = 40;
            this.Version.Name = "Version";
            this.Version.OptionsColumn.AllowEdit = false;
            this.Version.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Version.Visible = true;
            this.Version.VisibleIndex = 1;
            this.Version.Width = 150;
            // 
            // Clave
            // 
            this.Clave.Caption = "Clave";
            this.Clave.FieldName = "Clave";
            this.Clave.MinWidth = 40;
            this.Clave.Name = "Clave";
            this.Clave.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.Clave.Visible = true;
            this.Clave.VisibleIndex = 2;
            this.Clave.Width = 200;
            // 
            // CantidadLicencia
            // 
            this.CantidadLicencia.Caption = "Cantidad";
            this.CantidadLicencia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CantidadLicencia.FieldName = "Cantidad";
            this.CantidadLicencia.MinWidth = 40;
            this.CantidadLicencia.Name = "CantidadLicencia";
            this.CantidadLicencia.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.CantidadLicencia.Visible = true;
            this.CantidadLicencia.VisibleIndex = 3;
            this.CantidadLicencia.Width = 100;
            // 
            // Precio
            // 
            this.Precio.Caption = "Precio";
            this.Precio.FieldName = "Precio";
            this.Precio.MinWidth = 40;
            this.Precio.Name = "Precio";
            this.Precio.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Precio.Visible = true;
            this.Precio.VisibleIndex = 4;
            this.Precio.Width = 100;
            // 
            // IdCategoría
            // 
            this.IdCategoría.Caption = "IdCategoría";
            this.IdCategoría.FieldName = "IdCategoría";
            this.IdCategoría.Name = "IdCategoría";
            this.IdCategoría.OptionsColumn.AllowEdit = false;
            this.IdCategoría.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // IdModelo
            // 
            this.IdModelo.Caption = "IdModelo";
            this.IdModelo.FieldName = "IdModelo";
            this.IdModelo.Name = "IdModelo";
            this.IdModelo.OptionsColumn.AllowEdit = false;
            this.IdModelo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // IdLicencia
            // 
            this.IdLicencia.Caption = "IdLicencia";
            this.IdLicencia.FieldName = "IdLicencia";
            this.IdLicencia.Name = "IdLicencia";
            this.IdLicencia.OptionsColumn.AllowEdit = false;
            this.IdLicencia.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // tabSoftwares
            // 
            this.tabSoftwares.AttachedControl = this.tabControlPanel1;
            this.tabSoftwares.Name = "tabSoftwares";
            this.tabSoftwares.Text = "Software";
            // 
            // frmProcesoIngreso
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 607);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMontoCambio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbMonedaTipo);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTipoIngreso);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNroIngreso);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelX4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.cmbProveedor);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoIngreso";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ingreso";
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel5.ResumeLayout(false);
            this.tabControlPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptopsSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaLaptops)).EndInit();
            this.tabControlPanel8.ResumeLayout(false);
            this.tabControlPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaProyectores)).EndInit();
            this.tabControlPanel7.ResumeLayout(false);
            this.tabControlPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonitores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMonitores)).EndInit();
            this.tabControlPanel4.ResumeLayout(false);
            this.tabControlPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpresoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaImpresoras)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDiscos)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaMemoria)).EndInit();
            this.tabControlPanel6.ResumeLayout(false);
            this.tabControlPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaTablets)).EndInit();
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaLicencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtFactura;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaIngreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarProducto;
        internal DevComponents.DotNetBar.LabelX LabelX4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNroIngreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarLicencia;
        private System.Windows.Forms.Button btnAgregarDisco;
        private System.Windows.Forms.Button btnAgregarMemoria;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMonedaTipo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMontoCambio;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox cmbTipoIngreso;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel5;
        private DevComponents.DotNetBar.TabItem tabLaptops;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tabDiscosDuro;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabMemorias;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabSoftwares;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel7;
        private DevComponents.DotNetBar.TabItem tabMonitores;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel6;
        private DevComponents.DotNetBar.TabItem tabTablets;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel4;
        private DevComponents.DotNetBar.TabItem tabImpresoras;
        public DevExpress.XtraGrid.GridControl dgvLaptopsSeleccionados;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaLaptops;
        private DevExpress.XtraGrid.Columns.GridColumn TipoEquipo;
        private DevExpress.XtraGrid.Columns.GridColumn Marca;
        private DevExpress.XtraGrid.Columns.GridColumn Modelo;
        private DevExpress.XtraGrid.Columns.GridColumn Procesador;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn IdDetalle;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel8;
        private DevComponents.DotNetBar.TabItem tabProyectores;
        public DevExpress.XtraGrid.GridControl dgvLicencias;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaLicencias;
        private DevExpress.XtraGrid.Columns.GridColumn Categoria;
        private DevExpress.XtraGrid.Columns.GridColumn MarcaLicencia;
        private DevExpress.XtraGrid.Columns.GridColumn Version;
        private DevExpress.XtraGrid.Columns.GridColumn Clave;
        private DevExpress.XtraGrid.Columns.GridColumn CantidadLicencia;
        private DevExpress.XtraGrid.Columns.GridColumn Precio;
        private DevExpress.XtraGrid.Columns.GridColumn IdCategoría;
        private DevExpress.XtraGrid.Columns.GridColumn IdModelo;
        private DevExpress.XtraGrid.Columns.GridColumn IdLicencia;
        public DevExpress.XtraGrid.GridControl dgvMemoria;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaMemoria;
        private DevExpress.XtraGrid.Columns.GridColumn ModeloMemoria;
        private DevExpress.XtraGrid.Columns.GridColumn CapacidadMemoria;
        private DevExpress.XtraGrid.Columns.GridColumn CantidadMemoria;
        private DevExpress.XtraGrid.Columns.GridColumn TipoMemoria;
        private DevExpress.XtraGrid.Columns.GridColumn PrecioMemoria;
        private DevExpress.XtraGrid.Columns.GridColumn IdMemoria;
        public DevExpress.XtraGrid.GridControl dgvDiscos;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaDiscos;
        private DevExpress.XtraGrid.Columns.GridColumn Tipo;
        private DevExpress.XtraGrid.Columns.GridColumn CapacidadDisco;
        private DevExpress.XtraGrid.Columns.GridColumn CantidadDisco;
        private DevExpress.XtraGrid.Columns.GridColumn TamanoDisco;
        private DevExpress.XtraGrid.Columns.GridColumn PrecioDisco;
        private DevExpress.XtraGrid.Columns.GridColumn IdDisco;
        public DevExpress.XtraGrid.GridControl dgvImpresoras;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaImpresoras;
        private DevExpress.XtraGrid.Columns.GridColumn ImpresoraPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn ImpresoraMarca;
        private DevExpress.XtraGrid.Columns.GridColumn ImpresoraNombreModelo;
        private DevExpress.XtraGrid.Columns.GridColumn ImpresoraTipo;
        private DevExpress.XtraGrid.Columns.GridColumn ImpresoraCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn IdIngresoDetalleImpresora;
        private System.Windows.Forms.Button btnVisualizarImpresora;
        private System.Windows.Forms.Button btnAgregarImpresora;
        public DevExpress.XtraGrid.GridControl dgvTablets;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaTablets;
        private DevExpress.XtraGrid.Columns.GridColumn TabletMarca;
        private DevExpress.XtraGrid.Columns.GridColumn TabletNombreModelo;
        private DevExpress.XtraGrid.Columns.GridColumn TabletProcesador;
        private DevExpress.XtraGrid.Columns.GridColumn TabletCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn TabletPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn IdIngresoDetalleTablet;
        private System.Windows.Forms.Button btnVisualizarProyectores;
        private System.Windows.Forms.Button btnAgregarProyectores;
        public DevExpress.XtraGrid.GridControl dgvProyectores;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaProyectores;
        private DevExpress.XtraGrid.Columns.GridColumn ProyectorTipoEquipoProyector;
        private DevExpress.XtraGrid.Columns.GridColumn ProyectorMarca;
        private DevExpress.XtraGrid.Columns.GridColumn ProyectorNombreModelo;
        private DevExpress.XtraGrid.Columns.GridColumn ProyectoCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn ProyectoPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn IdIngresoDetalleProyector;
        private DevExpress.XtraGrid.Columns.GridColumn ProyectorCaracteristica;
        private DevExpress.XtraGrid.Columns.GridColumn ProyectorTamano;
        private System.Windows.Forms.Button btnVisualizarMonitores;
        private System.Windows.Forms.Button btnAgregarMonitores;
        public DevExpress.XtraGrid.GridControl dgvMonitores;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaMonitores;
        private DevExpress.XtraGrid.Columns.GridColumn MonitorMarca;
        private DevExpress.XtraGrid.Columns.GridColumn MonitorNombreModelo;
        private DevExpress.XtraGrid.Columns.GridColumn MonitorTipo;
        private DevExpress.XtraGrid.Columns.GridColumn MonitorCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn MonitorPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn IdIngresoDetalleMonitor;
        private DevExpress.XtraGrid.Columns.GridColumn MonitorTamanoPantalla;
        private System.Windows.Forms.Button btnVisualizarTablets;
        private System.Windows.Forms.Button btnAgregarTablets;
        private DevExpress.XtraGrid.Columns.GridColumn TabletTamanoPantalla;
        private DevExpress.XtraGrid.Columns.GridColumn TabletSistema;
        private DevExpress.XtraGrid.Columns.GridColumn TabletRam;
        private DevExpress.XtraGrid.Columns.GridColumn TabletRom;
    }
}
namespace Apolo
{
    partial class frmProcesoRelacionarGuia
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFacturas = new DevExpress.XtraGrid.GridControl();
            this.vistaFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Seleccionar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Facturas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Laptops = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guia";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(92, 385);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 29);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(32, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccionar una factura";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.Location = new System.Drawing.Point(31, 69);
            this.dgvFacturas.MainView = this.vistaFacturas;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.dgvFacturas.Size = new System.Drawing.Size(306, 294);
            this.dgvFacturas.TabIndex = 141;
            this.dgvFacturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaFacturas});
            // 
            // vistaFacturas
            // 
            this.vistaFacturas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.vistaFacturas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaFacturas.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaFacturas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaFacturas.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaFacturas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaFacturas.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaFacturas.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.vistaFacturas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaFacturas.Appearance.Row.Options.UseFont = true;
            this.vistaFacturas.Appearance.Row.Options.UseForeColor = true;
            this.vistaFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Seleccionar,
            this.Facturas});
            this.vistaFacturas.GridControl = this.dgvFacturas;
            this.vistaFacturas.Name = "vistaFacturas";
            this.vistaFacturas.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.vistaFacturas.OptionsSelection.MultiSelect = true;
            this.vistaFacturas.OptionsView.ColumnAutoWidth = false;
            this.vistaFacturas.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaFacturas.OptionsView.ShowAutoFilterRow = true;
            this.vistaFacturas.OptionsView.ShowGroupPanel = false;
            this.vistaFacturas.OptionsView.ShowIndicator = false;
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
            this.Seleccionar.Width = 100;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // Facturas
            // 
            this.Facturas.Caption = "Facturas";
            this.Facturas.FieldName = "numFactura";
            this.Facturas.MinWidth = 100;
            this.Facturas.Name = "Facturas";
            this.Facturas.Visible = true;
            this.Facturas.VisibleIndex = 1;
            this.Facturas.Width = 200;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(440, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 24);
            this.label3.TabIndex = 143;
            this.label3.Text = "Seleccione una laptop";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 34);
            this.button1.TabIndex = 144;
            this.button1.Text = "Relacionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(444, 69);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.gridControl1.Size = new System.Drawing.Size(306, 294);
            this.gridControl1.TabIndex = 145;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.Laptops});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Seleccionar";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gridColumn1.FieldName = "Seleccionar";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // Laptops
            // 
            this.Laptops.Caption = "Laptops";
            this.Laptops.FieldName = "Nombre_razonSocial";
            this.Laptops.MinWidth = 100;
            this.Laptops.Name = "Laptops";
            this.Laptops.Visible = true;
            this.Laptops.VisibleIndex = 1;
            this.Laptops.Width = 200;
            // 
            // frmProcesoRelacionarGuia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 545);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmProcesoRelacionarGuia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProcesoRelacionarGuia";
            this.Load += new System.EventHandler(this.frmProcesoRelacionarGuia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl dgvFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn Seleccionar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Facturas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn Laptops;
    }
}
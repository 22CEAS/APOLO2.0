namespace Apolo
{
    partial class frmProcesoTarifa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoTarifa));
            this.dgvTarifas = new DevExpress.XtraGrid.GridControl();
            this.vistaTarifas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnSubirGuias = new System.Windows.Forms.Button();
            this.btnCargarData = new System.Windows.Forms.Button();
            this.btnBuscarV = new System.Windows.Forms.Button();
            this.pnlTarifas = new System.Windows.Forms.Panel();
            this.lblTarifas = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.pnlTarifas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.Location = new System.Drawing.Point(2, 78);
            this.dgvTarifas.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvTarifas.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvTarifas.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvTarifas.MainView = this.vistaTarifas;
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.dgvTarifas.Size = new System.Drawing.Size(1158, 321);
            this.dgvTarifas.TabIndex = 149;
            this.dgvTarifas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vistaTarifas});
            // 
            // vistaTarifas
            // 
            this.vistaTarifas.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.vistaTarifas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.vistaTarifas.Appearance.HeaderPanel.Options.UseFont = true;
            this.vistaTarifas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.vistaTarifas.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.vistaTarifas.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.vistaTarifas.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.vistaTarifas.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.vistaTarifas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.vistaTarifas.Appearance.Row.Options.UseFont = true;
            this.vistaTarifas.Appearance.Row.Options.UseForeColor = true;
            this.vistaTarifas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Costo,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.vistaTarifas.GridControl = this.dgvTarifas;
            this.vistaTarifas.Name = "vistaTarifas";
            this.vistaTarifas.OptionsBehavior.Editable = false;
            this.vistaTarifas.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.vistaTarifas.OptionsSelection.MultiSelect = true;
            this.vistaTarifas.OptionsView.ColumnAutoWidth = false;
            this.vistaTarifas.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.vistaTarifas.OptionsView.ShowAutoFilterRow = true;
            this.vistaTarifas.OptionsView.ShowGroupPanel = false;
            this.vistaTarifas.OptionsView.ShowIndicator = false;
            this.vistaTarifas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vistaTarifas_KeyUp);
            // 
            // Costo
            // 
            this.Costo.Caption = "COSTO";
            this.Costo.FieldName = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.Visible = true;
            this.Costo.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "RUC CLIENTE";
            this.gridColumn1.FieldName = "RucCliente";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 150;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "CODIGO EQUIPO";
            this.gridColumn2.FieldName = "CodigoEquipo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 150;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "TARIFA";
            this.gridColumn3.FieldName = "Tarifa";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 150;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "OBSERVACION";
            this.gridColumn4.FieldName = "Observacion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            this.gridColumn4.Width = 150;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ID SALIDA DET";
            this.gridColumn5.FieldName = "IdSalidaDet";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 150;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ID SALIDA";
            this.gridColumn6.FieldName = "IdSalida";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 150;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "GUIA SALIDA";
            this.gridColumn7.FieldName = "GuiaSalida";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 150;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "MONEDA";
            this.gridColumn8.FieldName = "Moneda";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 100;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // btnSubirGuias
            // 
            this.btnSubirGuias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubirGuias.AutoSize = true;
            this.btnSubirGuias.BackColor = System.Drawing.Color.Transparent;
            this.btnSubirGuias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirGuias.FlatAppearance.BorderSize = 0;
            this.btnSubirGuias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirGuias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirGuias.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirGuias.Image")));
            this.btnSubirGuias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubirGuias.Location = new System.Drawing.Point(276, 419);
            this.btnSubirGuias.Name = "btnSubirGuias";
            this.btnSubirGuias.Size = new System.Drawing.Size(119, 74);
            this.btnSubirGuias.TabIndex = 148;
            this.btnSubirGuias.Text = "Subir \r\nTarifas";
            this.btnSubirGuias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubirGuias.UseVisualStyleBackColor = false;
            this.btnSubirGuias.Click += new System.EventHandler(this.btnSubirGuias_Click);
            // 
            // btnCargarData
            // 
            this.btnCargarData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargarData.AutoSize = true;
            this.btnCargarData.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarData.FlatAppearance.BorderSize = 0;
            this.btnCargarData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarData.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarData.Image = ((System.Drawing.Image)(resources.GetObject("btnCargarData.Image")));
            this.btnCargarData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarData.Location = new System.Drawing.Point(2, 419);
            this.btnCargarData.Name = "btnCargarData";
            this.btnCargarData.Size = new System.Drawing.Size(106, 74);
            this.btnCargarData.TabIndex = 147;
            this.btnCargarData.Text = "Cargar \r\nData";
            this.btnCargarData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarData.UseVisualStyleBackColor = false;
            this.btnCargarData.Click += new System.EventHandler(this.btnCargarData_Click);
            // 
            // btnBuscarV
            // 
            this.btnBuscarV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarV.AutoSize = true;
            this.btnBuscarV.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarV.FlatAppearance.BorderSize = 0;
            this.btnBuscarV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarV.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarV.Image")));
            this.btnBuscarV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarV.Location = new System.Drawing.Point(129, 419);
            this.btnBuscarV.Name = "btnBuscarV";
            this.btnBuscarV.Size = new System.Drawing.Size(110, 58);
            this.btnBuscarV.TabIndex = 242;
            this.btnBuscarV.Text = "BuscarV";
            this.btnBuscarV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarV.UseVisualStyleBackColor = false;
            this.btnBuscarV.Click += new System.EventHandler(this.btnBuscarV_Click);
            // 
            // pnlTarifas
            // 
            this.pnlTarifas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlTarifas.Controls.Add(this.lblTarifas);
            this.pnlTarifas.Controls.Add(this.btnCerrar);
            this.pnlTarifas.Location = new System.Drawing.Point(2, 1);
            this.pnlTarifas.Name = "pnlTarifas";
            this.pnlTarifas.Size = new System.Drawing.Size(1180, 41);
            this.pnlTarifas.TabIndex = 243;
            this.pnlTarifas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTarifas_MouseMove);
            // 
            // lblTarifas
            // 
            this.lblTarifas.AutoSize = true;
            this.lblTarifas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifas.ForeColor = System.Drawing.Color.White;
            this.lblTarifas.Location = new System.Drawing.Point(531, 3);
            this.lblTarifas.Name = "lblTarifas";
            this.lblTarifas.Size = new System.Drawing.Size(137, 31);
            this.lblTarifas.TabIndex = 144;
            this.lblTarifas.Text = "TARIFAS";
            this.lblTarifas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTarifas_MouseMove);
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
            this.btnCerrar.Location = new System.Drawing.Point(1135, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(42, 38);
            this.btnCerrar.TabIndex = 143;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmProcesoTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1182, 505);
            this.Controls.Add(this.pnlTarifas);
            this.Controls.Add(this.btnBuscarV);
            this.Controls.Add(this.dgvTarifas);
            this.Controls.Add(this.btnSubirGuias);
            this.Controls.Add(this.btnCargarData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProcesoTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARGA MASIVA TARIFAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.pnlTarifas.ResumeLayout(false);
            this.pnlTarifas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvTarifas;
        private DevExpress.XtraGrid.Views.Grid.GridView vistaTarifas;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private System.Windows.Forms.Button btnSubirGuias;
        private System.Windows.Forms.Button btnCargarData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Button btnBuscarV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Panel pnlTarifas;
        private System.Windows.Forms.Label lblTarifas;
        private System.Windows.Forms.Button btnCerrar;
        private DevExpress.XtraGrid.Columns.GridColumn Costo;
    }
}
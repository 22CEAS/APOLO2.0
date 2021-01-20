namespace Apolo
{
    partial class frmCargaMasivaTarifas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaMasivaTarifas));
            this.dgvTarifas = new DevExpress.XtraGrid.GridControl();
            this.vistaTarifas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnSubirGuias = new System.Windows.Forms.Button();
            this.btnCargarData = new System.Windows.Forms.Button();
            this.btnListarCV = new System.Windows.Forms.Button();
            this.btnBuscarV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.Location = new System.Drawing.Point(98, 23);
            this.dgvTarifas.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dgvTarifas.LookAndFeel.SkinName = "Office 2010 Silver";
            this.dgvTarifas.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dgvTarifas.MainView = this.vistaTarifas;
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.dgvTarifas.Size = new System.Drawing.Size(606, 321);
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
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
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
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 150;
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
            this.btnSubirGuias.Location = new System.Drawing.Point(466, 364);
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
            this.btnCargarData.Location = new System.Drawing.Point(192, 364);
            this.btnCargarData.Name = "btnCargarData";
            this.btnCargarData.Size = new System.Drawing.Size(106, 74);
            this.btnCargarData.TabIndex = 147;
            this.btnCargarData.Text = "Cargar \r\nData";
            this.btnCargarData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargarData.UseVisualStyleBackColor = false;
            this.btnCargarData.Click += new System.EventHandler(this.btnCargarData_Click);
            // 
            // btnListarCV
            // 
            this.btnListarCV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListarCV.AutoSize = true;
            this.btnListarCV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarCV.FlatAppearance.BorderSize = 0;
            this.btnListarCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarCV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCV.Image = ((System.Drawing.Image)(resources.GetObject("btnListarCV.Image")));
            this.btnListarCV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarCV.Location = new System.Drawing.Point(393, 355);
            this.btnListarCV.Name = "btnListarCV";
            this.btnListarCV.Size = new System.Drawing.Size(67, 83);
            this.btnListarCV.TabIndex = 243;
            this.btnListarCV.Text = "Listar\r\nCV\r\n";
            this.btnListarCV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarCV.UseVisualStyleBackColor = true;
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
            this.btnBuscarV.Location = new System.Drawing.Point(277, 364);
            this.btnBuscarV.Name = "btnBuscarV";
            this.btnBuscarV.Size = new System.Drawing.Size(110, 58);
            this.btnBuscarV.TabIndex = 242;
            this.btnBuscarV.Text = "BuscarV";
            this.btnBuscarV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarV.UseVisualStyleBackColor = false;
            // 
            // frmCargaMasivaTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarCV);
            this.Controls.Add(this.btnBuscarV);
            this.Controls.Add(this.dgvTarifas);
            this.Controls.Add(this.btnSubirGuias);
            this.Controls.Add(this.btnCargarData);
            this.Name = "frmCargaMasivaTarifas";
            this.Text = "CARGA MASIVA TARIFAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
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
        private System.Windows.Forms.Button btnListarCV;
        private System.Windows.Forms.Button btnBuscarV;
    }
}
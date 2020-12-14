namespace Apolo
{
    partial class frmProcesoIngresoImpresora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoIngresoImpresora));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSubirSeries = new System.Windows.Forms.Button();
            this.dgvSerieFabrica = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieFabrico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.btnAgregarImpresoraTipo = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarImpresoraMarca = new System.Windows.Forms.Button();
            this.btnAgregarImpresoraModelo = new System.Windows.Forms.Button();
            this.chbGarantia = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerieFabrica)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(598, 250);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 67);
            this.btnAceptar.TabIndex = 212;
            this.btnAceptar.Text = "Seleccionar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(500, 252);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 65);
            this.btnCancelar.TabIndex = 211;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSubirSeries
            // 
            this.btnSubirSeries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubirSeries.AutoSize = true;
            this.btnSubirSeries.BackColor = System.Drawing.Color.Transparent;
            this.btnSubirSeries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirSeries.FlatAppearance.BorderSize = 0;
            this.btnSubirSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirSeries.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirSeries.Image = ((System.Drawing.Image)(resources.GetObject("btnSubirSeries.Image")));
            this.btnSubirSeries.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubirSeries.Location = new System.Drawing.Point(655, 22);
            this.btnSubirSeries.Name = "btnSubirSeries";
            this.btnSubirSeries.Size = new System.Drawing.Size(40, 34);
            this.btnSubirSeries.TabIndex = 210;
            this.btnSubirSeries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubirSeries.UseVisualStyleBackColor = false;
            this.btnSubirSeries.Click += new System.EventHandler(this.btnSubirSeries_Click);
            // 
            // dgvSerieFabrica
            // 
            this.dgvSerieFabrica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerieFabrica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.SerieFabrico});
            this.dgvSerieFabrica.Location = new System.Drawing.Point(481, 78);
            this.dgvSerieFabrica.Name = "dgvSerieFabrica";
            this.dgvSerieFabrica.RowHeadersVisible = false;
            this.dgvSerieFabrica.Size = new System.Drawing.Size(228, 166);
            this.dgvSerieFabrica.TabIndex = 209;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Nro";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            this.Nro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nro.Width = 30;
            // 
            // SerieFabrico
            // 
            this.SerieFabrico.DataPropertyName = "serie";
            this.SerieFabrico.HeaderText = "Serie Fabrica";
            this.SerieFabrico.Name = "SerieFabrico";
            this.SerieFabrico.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 208;
            this.label3.Text = "Part Number";
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(110, 173);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(87, 20);
            this.txtPartNumber.TabIndex = 207;
            // 
            // btnAgregarImpresoraTipo
            // 
            this.btnAgregarImpresoraTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarImpresoraTipo.AutoSize = true;
            this.btnAgregarImpresoraTipo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarImpresoraTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImpresoraTipo.FlatAppearance.BorderSize = 0;
            this.btnAgregarImpresoraTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImpresoraTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImpresoraTipo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarImpresoraTipo.Image")));
            this.btnAgregarImpresoraTipo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarImpresoraTipo.Location = new System.Drawing.Point(322, 122);
            this.btnAgregarImpresoraTipo.Name = "btnAgregarImpresoraTipo";
            this.btnAgregarImpresoraTipo.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarImpresoraTipo.TabIndex = 206;
            this.btnAgregarImpresoraTipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarImpresoraTipo.UseVisualStyleBackColor = false;
            this.btnAgregarImpresoraTipo.Click += new System.EventHandler(this.btnAgregarImpresoraTipo_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(110, 126);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(208, 21);
            this.cmbTipo.TabIndex = 204;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 205;
            this.label5.Text = "Caracteristica";
            // 
            // btnAgregarImpresoraMarca
            // 
            this.btnAgregarImpresoraMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarImpresoraMarca.AutoSize = true;
            this.btnAgregarImpresoraMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarImpresoraMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImpresoraMarca.FlatAppearance.BorderSize = 0;
            this.btnAgregarImpresoraMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImpresoraMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImpresoraMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarImpresoraMarca.Image")));
            this.btnAgregarImpresoraMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarImpresoraMarca.Location = new System.Drawing.Point(322, 28);
            this.btnAgregarImpresoraMarca.Name = "btnAgregarImpresoraMarca";
            this.btnAgregarImpresoraMarca.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarImpresoraMarca.TabIndex = 203;
            this.btnAgregarImpresoraMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarImpresoraMarca.UseVisualStyleBackColor = false;
            this.btnAgregarImpresoraMarca.Click += new System.EventHandler(this.btnAgregarImpresoraMarca_Click);
            // 
            // btnAgregarImpresoraModelo
            // 
            this.btnAgregarImpresoraModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarImpresoraModelo.AutoSize = true;
            this.btnAgregarImpresoraModelo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarImpresoraModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImpresoraModelo.FlatAppearance.BorderSize = 0;
            this.btnAgregarImpresoraModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarImpresoraModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImpresoraModelo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarImpresoraModelo.Image")));
            this.btnAgregarImpresoraModelo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarImpresoraModelo.Location = new System.Drawing.Point(322, 73);
            this.btnAgregarImpresoraModelo.Name = "btnAgregarImpresoraModelo";
            this.btnAgregarImpresoraModelo.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarImpresoraModelo.TabIndex = 202;
            this.btnAgregarImpresoraModelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarImpresoraModelo.UseVisualStyleBackColor = false;
            this.btnAgregarImpresoraModelo.Click += new System.EventHandler(this.btnAgregarImpresoraModelo_Click);
            // 
            // chbGarantia
            // 
            this.chbGarantia.AutoSize = true;
            this.chbGarantia.BackColor = System.Drawing.Color.White;
            this.chbGarantia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGarantia.Location = new System.Drawing.Point(229, 173);
            this.chbGarantia.Name = "chbGarantia";
            this.chbGarantia.Size = new System.Drawing.Size(78, 20);
            this.chbGarantia.TabIndex = 201;
            this.chbGarantia.Text = "Garantía";
            this.chbGarantia.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 200;
            this.label8.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(110, 217);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(87, 20);
            this.txtPrecio.TabIndex = 194;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // cmbModelo
            // 
            this.cmbModelo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(110, 77);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(208, 21);
            this.cmbModelo.TabIndex = 192;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(478, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 199;
            this.label7.Text = "Cantidad";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(110, 30);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(208, 21);
            this.cmbMarca.TabIndex = 191;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(555, 29);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(91, 20);
            this.txtCantidad.TabIndex = 195;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 196;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 197;
            this.label2.Text = "Modelo";
            // 
            // frmProcesoIngresoImpresora
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 327);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSubirSeries);
            this.Controls.Add(this.dgvSerieFabrica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.btnAgregarImpresoraTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarImpresoraMarca);
            this.Controls.Add(this.btnAgregarImpresoraModelo);
            this.Controls.Add(this.chbGarantia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoIngresoImpresora";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresora";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerieFabrica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSubirSeries;
        private System.Windows.Forms.DataGridView dgvSerieFabrica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerieFabrico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.Button btnAgregarImpresoraTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarImpresoraMarca;
        private System.Windows.Forms.Button btnAgregarImpresoraModelo;
        private System.Windows.Forms.CheckBox chbGarantia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace Apolo
{
    partial class frmProcesoIngresoProyector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoIngresoProyector));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSubirSeries = new System.Windows.Forms.Button();
            this.dgvSerieFabrica = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerieFabrico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarProyectorMarca = new System.Windows.Forms.Button();
            this.btnAgregarProyectorModelo = new System.Windows.Forms.Button();
            this.chbGarantia = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarProyectorCaracteristica = new System.Windows.Forms.Button();
            this.cmbCaracteristica = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarProyectorLuminen = new System.Windows.Forms.Button();
            this.cmbLuminen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarProyectorResolucion = new System.Windows.Forms.Button();
            this.cmbResolucion = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.btnAceptar.Location = new System.Drawing.Point(594, 304);
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
            this.btnCancelar.Location = new System.Drawing.Point(496, 306);
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
            this.btnSubirSeries.Location = new System.Drawing.Point(674, 18);
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
            this.dgvSerieFabrica.Location = new System.Drawing.Point(477, 72);
            this.dgvSerieFabrica.Name = "dgvSerieFabrica";
            this.dgvSerieFabrica.RowHeadersVisible = false;
            this.dgvSerieFabrica.Size = new System.Drawing.Size(228, 212);
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
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(129, 29);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(208, 21);
            this.cmbTipo.TabIndex = 204;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 205;
            this.label5.Text = "Tipo";
            // 
            // btnAgregarProyectorMarca
            // 
            this.btnAgregarProyectorMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProyectorMarca.AutoSize = true;
            this.btnAgregarProyectorMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProyectorMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProyectorMarca.FlatAppearance.BorderSize = 0;
            this.btnAgregarProyectorMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProyectorMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProyectorMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProyectorMarca.Image")));
            this.btnAgregarProyectorMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProyectorMarca.Location = new System.Drawing.Point(342, 65);
            this.btnAgregarProyectorMarca.Name = "btnAgregarProyectorMarca";
            this.btnAgregarProyectorMarca.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarProyectorMarca.TabIndex = 203;
            this.btnAgregarProyectorMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProyectorMarca.UseVisualStyleBackColor = false;
            this.btnAgregarProyectorMarca.Click += new System.EventHandler(this.btnAgregarProyectorMarca_Click);
            // 
            // btnAgregarProyectorModelo
            // 
            this.btnAgregarProyectorModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProyectorModelo.AutoSize = true;
            this.btnAgregarProyectorModelo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProyectorModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProyectorModelo.FlatAppearance.BorderSize = 0;
            this.btnAgregarProyectorModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProyectorModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProyectorModelo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProyectorModelo.Image")));
            this.btnAgregarProyectorModelo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProyectorModelo.Location = new System.Drawing.Point(342, 110);
            this.btnAgregarProyectorModelo.Name = "btnAgregarProyectorModelo";
            this.btnAgregarProyectorModelo.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarProyectorModelo.TabIndex = 202;
            this.btnAgregarProyectorModelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProyectorModelo.UseVisualStyleBackColor = false;
            this.btnAgregarProyectorModelo.Click += new System.EventHandler(this.btnAgregarProyectorModelo_Click);
            // 
            // chbGarantia
            // 
            this.chbGarantia.AutoSize = true;
            this.chbGarantia.BackColor = System.Drawing.Color.White;
            this.chbGarantia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGarantia.Location = new System.Drawing.Point(257, 308);
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
            this.label8.Location = new System.Drawing.Point(26, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 200;
            this.label8.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(127, 356);
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
            this.cmbModelo.Location = new System.Drawing.Point(128, 119);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(208, 21);
            this.cmbModelo.TabIndex = 192;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(480, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 199;
            this.label7.Text = "Cantidad";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(128, 72);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(208, 21);
            this.cmbMarca.TabIndex = 191;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(557, 29);
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
            this.label1.Location = new System.Drawing.Point(28, 73);
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
            this.label2.Location = new System.Drawing.Point(28, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 197;
            this.label2.Text = "Modelo";
            // 
            // txtPantalla
            // 
            this.txtPantalla.Location = new System.Drawing.Point(127, 308);
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(87, 20);
            this.txtPantalla.TabIndex = 193;
            this.txtPantalla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPantalla_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 32);
            this.label4.TabIndex = 198;
            this.label4.Text = "Tamaño\r\nECRAM";
            // 
            // btnAgregarProyectorCaracteristica
            // 
            this.btnAgregarProyectorCaracteristica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProyectorCaracteristica.AutoSize = true;
            this.btnAgregarProyectorCaracteristica.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProyectorCaracteristica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProyectorCaracteristica.FlatAppearance.BorderSize = 0;
            this.btnAgregarProyectorCaracteristica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProyectorCaracteristica.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProyectorCaracteristica.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProyectorCaracteristica.Image")));
            this.btnAgregarProyectorCaracteristica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProyectorCaracteristica.Location = new System.Drawing.Point(342, 152);
            this.btnAgregarProyectorCaracteristica.Name = "btnAgregarProyectorCaracteristica";
            this.btnAgregarProyectorCaracteristica.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarProyectorCaracteristica.TabIndex = 215;
            this.btnAgregarProyectorCaracteristica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProyectorCaracteristica.UseVisualStyleBackColor = false;
            this.btnAgregarProyectorCaracteristica.Click += new System.EventHandler(this.btnAgregarProyectorCaracteristica_Click);
            // 
            // cmbCaracteristica
            // 
            this.cmbCaracteristica.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCaracteristica.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCaracteristica.FormattingEnabled = true;
            this.cmbCaracteristica.Location = new System.Drawing.Point(128, 161);
            this.cmbCaracteristica.Name = "cmbCaracteristica";
            this.cmbCaracteristica.Size = new System.Drawing.Size(208, 21);
            this.cmbCaracteristica.TabIndex = 213;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 214;
            this.label6.Text = "Caracteristica";
            // 
            // btnAgregarProyectorLuminen
            // 
            this.btnAgregarProyectorLuminen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProyectorLuminen.AutoSize = true;
            this.btnAgregarProyectorLuminen.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProyectorLuminen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProyectorLuminen.FlatAppearance.BorderSize = 0;
            this.btnAgregarProyectorLuminen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProyectorLuminen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProyectorLuminen.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProyectorLuminen.Image")));
            this.btnAgregarProyectorLuminen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProyectorLuminen.Location = new System.Drawing.Point(342, 237);
            this.btnAgregarProyectorLuminen.Name = "btnAgregarProyectorLuminen";
            this.btnAgregarProyectorLuminen.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarProyectorLuminen.TabIndex = 221;
            this.btnAgregarProyectorLuminen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProyectorLuminen.UseVisualStyleBackColor = false;
            this.btnAgregarProyectorLuminen.Click += new System.EventHandler(this.btnAgregarProyectorLuminen_Click);
            // 
            // cmbLuminen
            // 
            this.cmbLuminen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLuminen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLuminen.FormattingEnabled = true;
            this.cmbLuminen.Location = new System.Drawing.Point(128, 246);
            this.cmbLuminen.Name = "cmbLuminen";
            this.cmbLuminen.Size = new System.Drawing.Size(208, 21);
            this.cmbLuminen.TabIndex = 219;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 220;
            this.label3.Text = "Luminen";
            // 
            // btnAgregarProyectorResolucion
            // 
            this.btnAgregarProyectorResolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProyectorResolucion.AutoSize = true;
            this.btnAgregarProyectorResolucion.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProyectorResolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProyectorResolucion.FlatAppearance.BorderSize = 0;
            this.btnAgregarProyectorResolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProyectorResolucion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProyectorResolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProyectorResolucion.Image")));
            this.btnAgregarProyectorResolucion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProyectorResolucion.Location = new System.Drawing.Point(342, 195);
            this.btnAgregarProyectorResolucion.Name = "btnAgregarProyectorResolucion";
            this.btnAgregarProyectorResolucion.Size = new System.Drawing.Size(30, 30);
            this.btnAgregarProyectorResolucion.TabIndex = 218;
            this.btnAgregarProyectorResolucion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProyectorResolucion.UseVisualStyleBackColor = false;
            this.btnAgregarProyectorResolucion.Click += new System.EventHandler(this.btnAgregarProyectorResolucion_Click);
            // 
            // cmbResolucion
            // 
            this.cmbResolucion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbResolucion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbResolucion.FormattingEnabled = true;
            this.cmbResolucion.Location = new System.Drawing.Point(128, 204);
            this.cmbResolucion.Name = "cmbResolucion";
            this.cmbResolucion.Size = new System.Drawing.Size(208, 21);
            this.cmbResolucion.TabIndex = 216;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 217;
            this.label9.Text = "Resolución";
            // 
            // frmProcesoIngresoProyector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.btnAgregarProyectorLuminen);
            this.Controls.Add(this.cmbLuminen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregarProyectorResolucion);
            this.Controls.Add(this.cmbResolucion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAgregarProyectorCaracteristica);
            this.Controls.Add(this.cmbCaracteristica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSubirSeries);
            this.Controls.Add(this.dgvSerieFabrica);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarProyectorMarca);
            this.Controls.Add(this.btnAgregarProyectorModelo);
            this.Controls.Add(this.chbGarantia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesoIngresoProyector";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyectores y Ecram";
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
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarProyectorMarca;
        private System.Windows.Forms.Button btnAgregarProyectorModelo;
        private System.Windows.Forms.CheckBox chbGarantia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarProyectorCaracteristica;
        private System.Windows.Forms.ComboBox cmbCaracteristica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarProyectorLuminen;
        private System.Windows.Forms.ComboBox cmbLuminen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarProyectorResolucion;
        private System.Windows.Forms.ComboBox cmbResolucion;
        private System.Windows.Forms.Label label9;
    }
}
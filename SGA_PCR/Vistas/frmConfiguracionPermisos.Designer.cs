﻿namespace Apolo
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracionPermisos));
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbModulosPrincipales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSubmodulos = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.dgvPermisosUsuario = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.submoduloDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlPermisos = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblPermisos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.submoduloDABindingSource)).BeginInit();
            this.pnlPermisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUsuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(438, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(438, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // dgvSubmodulos
            // 
            this.dgvSubmodulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubmodulos.BackColor = System.Drawing.Color.Silver;
            this.dgvSubmodulos.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvSubmodulos.ForeColor = System.Drawing.Color.Black;
            this.dgvSubmodulos.Location = new System.Drawing.Point(73, 157);
            this.dgvSubmodulos.Name = "dgvSubmodulos";
            this.dgvSubmodulos.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvSubmodulos.PrimaryGrid.AllowRowResize = true;
            this.dgvSubmodulos.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.Name = "idSubmodulo";
            gridColumn1.Visible = false;
            gridColumn2.HeaderText = "Descripcion Sub Modulo";
            gridColumn2.Name = "descripcionSubmodulo";
            gridColumn2.Width = 300;
            gridColumn3.Name = "idModuloP";
            gridColumn3.Visible = false;
            this.dgvSubmodulos.PrimaryGrid.Columns.Add(gridColumn1);
            this.dgvSubmodulos.PrimaryGrid.Columns.Add(gridColumn2);
            this.dgvSubmodulos.PrimaryGrid.Columns.Add(gridColumn3);
            this.dgvSubmodulos.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvSubmodulos.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvSubmodulos.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvSubmodulos.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvSubmodulos.PrimaryGrid.EnableFiltering = true;
            this.dgvSubmodulos.PrimaryGrid.EnableRowFiltering = true;
            this.dgvSubmodulos.PrimaryGrid.Filter.Visible = true;
            this.dgvSubmodulos.PrimaryGrid.MultiSelect = false;
            this.dgvSubmodulos.PrimaryGrid.NoRowsText = "NO HAY PERMISOS DISPONIBLES";
            this.dgvSubmodulos.PrimaryGrid.NullString = "<<null>>";
            this.dgvSubmodulos.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvSubmodulos.PrimaryGrid.ShowRowHeaders = false;
            this.dgvSubmodulos.Size = new System.Drawing.Size(317, 419);
            this.dgvSubmodulos.TabIndex = 93;
            this.dgvSubmodulos.Text = "Tabla Memoria";
            this.dgvSubmodulos.Click += new System.EventHandler(this.dgvSubmodulos_Click);
            // 
            // dgvPermisosUsuario
            // 
            this.dgvPermisosUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPermisosUsuario.BackColor = System.Drawing.Color.Silver;
            this.dgvPermisosUsuario.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvPermisosUsuario.ForeColor = System.Drawing.Color.Black;
            this.dgvPermisosUsuario.Location = new System.Drawing.Point(544, 157);
            this.dgvPermisosUsuario.Name = "dgvPermisosUsuario";
            this.dgvPermisosUsuario.PrimaryGrid.AllowRowHeaderResize = true;
            this.dgvPermisosUsuario.PrimaryGrid.AllowRowResize = true;
            this.dgvPermisosUsuario.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn4.Name = "idUsuario";
            gridColumn4.Visible = false;
            gridColumn5.Name = "idSubmodulo";
            gridColumn5.Visible = false;
            gridColumn6.HeaderText = "Descripcion Sub Modulo";
            gridColumn6.Name = "descripcionSubmodulo";
            gridColumn6.Width = 300;
            this.dgvPermisosUsuario.PrimaryGrid.Columns.Add(gridColumn4);
            this.dgvPermisosUsuario.PrimaryGrid.Columns.Add(gridColumn5);
            this.dgvPermisosUsuario.PrimaryGrid.Columns.Add(gridColumn6);
            this.dgvPermisosUsuario.PrimaryGrid.DefaultRowHeight = 24;
            this.dgvPermisosUsuario.PrimaryGrid.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvPermisosUsuario.PrimaryGrid.DefaultVisualStyles.FilterColumnHeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.dgvPermisosUsuario.PrimaryGrid.EnableColumnFiltering = true;
            this.dgvPermisosUsuario.PrimaryGrid.EnableFiltering = true;
            this.dgvPermisosUsuario.PrimaryGrid.EnableRowFiltering = true;
            this.dgvPermisosUsuario.PrimaryGrid.Filter.Visible = true;
            this.dgvPermisosUsuario.PrimaryGrid.MultiSelect = false;
            this.dgvPermisosUsuario.PrimaryGrid.NoRowsText = "NO HAY PERMISOS DISPONIBLES";
            this.dgvPermisosUsuario.PrimaryGrid.NullString = "<<null>>";
            this.dgvPermisosUsuario.PrimaryGrid.RowHeaderWidth = 45;
            this.dgvPermisosUsuario.PrimaryGrid.ShowRowHeaders = false;
            this.dgvPermisosUsuario.Size = new System.Drawing.Size(316, 419);
            this.dgvPermisosUsuario.TabIndex = 95;
            this.dgvPermisosUsuario.Text = "Tabla Memoria";
            this.dgvPermisosUsuario.Click += new System.EventHandler(this.dgvPermisosUsuario_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(902, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(17, 16);
            this.button3.TabIndex = 151;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(438, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 41);
            this.button4.TabIndex = 152;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(438, 472);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 41);
            this.button5.TabIndex = 153;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.pnlPermisos.Location = new System.Drawing.Point(2, 2);
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
            // frmConfiguracionPermisos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(946, 588);
            this.Controls.Add(this.pnlPermisos);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvPermisosUsuario);
            this.Controls.Add(this.dgvSubmodulos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Load += new System.EventHandler(this.frmConfiguracionPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.submoduloDABindingSource)).EndInit();
            this.pnlPermisos.ResumeLayout(false);
            this.pnlPermisos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbModulosPrincipales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource submoduloDABindingSource;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvSubmodulos;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvPermisosUsuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnlPermisos;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Button btnCerrar;
    }
}
namespace pryFrancoSp4Lamilanga
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnMozo = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMozo = new System.Windows.Forms.TextBox();
            this.txtBebidaCon = new System.Windows.Forms.TextBox();
            this.txtBebidaSin = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPostre = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblBebidasin = new System.Windows.Forms.Label();
            this.lblbebidacon = new System.Windows.Forms.Label();
            this.lblPostre = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImporteMozo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(12, 236);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(89, 35);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnMozo
            // 
            this.btnMozo.Location = new System.Drawing.Point(12, 290);
            this.btnMozo.Name = "btnMozo";
            this.btnMozo.Size = new System.Drawing.Size(89, 47);
            this.btnMozo.TabIndex = 2;
            this.btnMozo.Text = "Mozo del dia";
            this.btnMozo.UseVisualStyleBackColor = true;
            this.btnMozo.Click += new System.EventHandler(this.btnMozo_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(12, 345);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(89, 55);
            this.btnTotal.TabIndex = 3;
            this.btnTotal.Text = "Totales";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(666, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 71);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtMozo
            // 
            this.txtMozo.Location = new System.Drawing.Point(116, 304);
            this.txtMozo.Name = "txtMozo";
            this.txtMozo.ReadOnly = true;
            this.txtMozo.Size = new System.Drawing.Size(84, 20);
            this.txtMozo.TabIndex = 5;
            // 
            // txtBebidaCon
            // 
            this.txtBebidaCon.Location = new System.Drawing.Point(335, 380);
            this.txtBebidaCon.Name = "txtBebidaCon";
            this.txtBebidaCon.ReadOnly = true;
            this.txtBebidaCon.Size = new System.Drawing.Size(95, 20);
            this.txtBebidaCon.TabIndex = 6;
            // 
            // txtBebidaSin
            // 
            this.txtBebidaSin.Location = new System.Drawing.Point(230, 380);
            this.txtBebidaSin.Name = "txtBebidaSin";
            this.txtBebidaSin.ReadOnly = true;
            this.txtBebidaSin.Size = new System.Drawing.Size(90, 20);
            this.txtBebidaSin.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(559, 380);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(89, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // txtPostre
            // 
            this.txtPostre.Location = new System.Drawing.Point(451, 380);
            this.txtPostre.Name = "txtPostre";
            this.txtPostre.ReadOnly = true;
            this.txtPostre.Size = new System.Drawing.Size(93, 20);
            this.txtPostre.TabIndex = 9;
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(116, 379);
            this.txtComida.Name = "txtComida";
            this.txtComida.ReadOnly = true;
            this.txtComida.Size = new System.Drawing.Size(96, 20);
            this.txtComida.TabIndex = 10;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(113, 361);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(47, 13);
            this.lblComida.TabIndex = 11;
            this.lblComida.Text = "Comidas";
            // 
            // lblBebidasin
            // 
            this.lblBebidasin.AutoSize = true;
            this.lblBebidasin.Location = new System.Drawing.Point(227, 361);
            this.lblBebidasin.Name = "lblBebidasin";
            this.lblBebidasin.Size = new System.Drawing.Size(93, 13);
            this.lblBebidasin.TabIndex = 12;
            this.lblBebidasin.Text = "Bebida sin alcohol";
            // 
            // lblbebidacon
            // 
            this.lblbebidacon.AutoSize = true;
            this.lblbebidacon.Location = new System.Drawing.Point(332, 361);
            this.lblbebidacon.Name = "lblbebidacon";
            this.lblbebidacon.Size = new System.Drawing.Size(98, 13);
            this.lblbebidacon.TabIndex = 13;
            this.lblbebidacon.Text = "Bebida con alcohol";
            // 
            // lblPostre
            // 
            this.lblPostre.AutoSize = true;
            this.lblPostre.Location = new System.Drawing.Point(448, 361);
            this.lblPostre.Name = "lblPostre";
            this.lblPostre.Size = new System.Drawing.Size(41, 13);
            this.lblPostre.TabIndex = 14;
            this.lblPostre.Text = "postres";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(556, 361);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total";
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToOrderColumns = true;
            this.dgvInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvInfo.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvInfo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvInfo.Location = new System.Drawing.Point(12, 12);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.Size = new System.Drawing.Size(532, 205);
            this.dgvInfo.TabIndex = 17;
            this.dgvInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvInfo_KeyPress);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mozo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Comidas";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.ToolTipText = "xc";
            // 
            // Column2
            // 
            this.Column2.HeaderText = " Bebidas sin alcohol";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bebidas con alcohol";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = " Postres";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtImporteMozo
            // 
            this.txtImporteMozo.Location = new System.Drawing.Point(230, 304);
            this.txtImporteMozo.Name = "txtImporteMozo";
            this.txtImporteMozo.ReadOnly = true;
            this.txtImporteMozo.Size = new System.Drawing.Size(84, 20);
            this.txtImporteMozo.TabIndex = 18;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtImporteMozo);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPostre);
            this.Controls.Add(this.lblbebidacon);
            this.Controls.Add(this.lblBebidasin);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.txtPostre);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtBebidaSin);
            this.Controls.Add(this.txtBebidaCon);
            this.Controls.Add(this.txtMozo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMozo);
            this.Controls.Add(this.btnValidar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "La Milanga";
            this.Load += new System.EventHandler(this.FrmMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnMozo;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtMozo;
        private System.Windows.Forms.TextBox txtBebidaCon;
        private System.Windows.Forms.TextBox txtBebidaSin;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPostre;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblBebidasin;
        private System.Windows.Forms.Label lblbebidacon;
        private System.Windows.Forms.Label lblPostre;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.TextBox txtImporteMozo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}


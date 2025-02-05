namespace JDcaja
{
    partial class FrmDetalleCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtmontototal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtnombreProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdocProveedor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.btnDescargar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.btnbusqueda = new FontAwesome.Sharp.IconButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnDescargar);
            this.groupBox3.Controls.Add(this.txtmontototal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnlimpiarbuscador);
            this.groupBox3.Controls.Add(this.btnbusqueda);
            this.groupBox3.Controls.Add(this.txtbusqueda);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dgvdata);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(915, 756);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle Compra";
            // 
            // txtmontototal
            // 
            this.txtmontototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontototal.Location = new System.Drawing.Point(162, 677);
            this.txtmontototal.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.Size = new System.Drawing.Size(138, 30);
            this.txtmontototal.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 677);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 25);
            this.label10.TabIndex = 90;
            this.label10.Text = "Monto Total:";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbusqueda.Location = new System.Drawing.Point(299, 46);
            this.txtbusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(249, 38);
            this.txtbusqueda.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(104, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 24);
            this.label11.TabIndex = 88;
            this.label11.Text = "Numero Documento:";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            this.dgvdata.Location = new System.Drawing.Point(18, 374);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(856, 290);
            this.dgvdata.TabIndex = 84;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.MinimumWidth = 6;
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtnumeroDocumento);
            this.groupBox2.Controls.Add(this.txtnombreProveedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdocProveedor);
            this.groupBox2.Location = new System.Drawing.Point(18, 227);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(856, 120);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de Proveedor:";
            // 
            // txtnumeroDocumento
            // 
            this.txtnumeroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumeroDocumento.Location = new System.Drawing.Point(726, 75);
            this.txtnumeroDocumento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtnumeroDocumento.Name = "txtnumeroDocumento";
            this.txtnumeroDocumento.Size = new System.Drawing.Size(116, 30);
            this.txtnumeroDocumento.TabIndex = 83;
            this.txtnumeroDocumento.Visible = false;
            // 
            // txtnombreProveedor
            // 
            this.txtnombreProveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtnombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreProveedor.Location = new System.Drawing.Point(332, 75);
            this.txtnombreProveedor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtnombreProveedor.Name = "txtnombreProveedor";
            this.txtnombreProveedor.Size = new System.Drawing.Size(308, 30);
            this.txtnombreProveedor.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "Razon Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "Numero Documento:";
            // 
            // txtdocProveedor
            // 
            this.txtdocProveedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdocProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocProveedor.Location = new System.Drawing.Point(10, 76);
            this.txtdocProveedor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtdocProveedor.Name = "txtdocProveedor";
            this.txtdocProveedor.Size = new System.Drawing.Size(309, 30);
            this.txtdocProveedor.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.txttipodocumento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Location = new System.Drawing.Point(18, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(856, 120);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de Compra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(561, 76);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(281, 30);
            this.txtusuario.TabIndex = 82;
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttipodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipodocumento.Location = new System.Drawing.Point(252, 76);
            this.txttipodocumento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.Size = new System.Drawing.Size(274, 30);
            this.txttipodocumento.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "Tipo de Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 79;
            this.label2.Text = "Fecha:";
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(10, 76);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(229, 30);
            this.txtfecha.TabIndex = 43;
            // 
            // btnDescargar
            // 
            this.btnDescargar.BackColor = System.Drawing.Color.White;
            this.btnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescargar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.Black;
            this.btnDescargar.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnDescargar.IconColor = System.Drawing.Color.Green;
            this.btnDescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescargar.IconSize = 25;
            this.btnDescargar.Location = new System.Drawing.Point(577, 679);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(283, 32);
            this.btnDescargar.TabIndex = 85;
            this.btnDescargar.Text = "Descargar PDF";
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescargar.UseVisualStyleBackColor = false;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 26;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(688, 48);
            this.btnlimpiarbuscador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(113, 39);
            this.btnlimpiarbuscador.TabIndex = 87;
            this.btnlimpiarbuscador.Text = "Limpiar";
            this.btnlimpiarbuscador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarbuscador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.BackColor = System.Drawing.Color.White;
            this.btnbusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbusqueda.ForeColor = System.Drawing.Color.Black;
            this.btnbusqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbusqueda.IconColor = System.Drawing.Color.Black;
            this.btnbusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbusqueda.IconSize = 26;
            this.btnbusqueda.Location = new System.Drawing.Point(563, 48);
            this.btnbusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(119, 39);
            this.btnbusqueda.TabIndex = 86;
            this.btnbusqueda.Text = "Buscar";
            this.btnbusqueda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbusqueda.UseVisualStyleBackColor = false;
            this.btnbusqueda.Click += new System.EventHandler(this.btnbusqueda_Click);
            // 
            // FrmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2767, 1096);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmDetalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleCompra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnumeroDocumento;
        private System.Windows.Forms.TextBox txtnombreProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdocProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfecha;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private FontAwesome.Sharp.IconButton btnbusqueda;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.TextBox txtmontototal;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnDescargar;
    }
}
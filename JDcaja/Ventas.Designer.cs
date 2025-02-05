namespace JDcaja
{
    partial class Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtpagarcon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttotalapagar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregarproducto = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnbuscarProducto = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombrecompleto = new System.Windows.Forms.TextBox();
            this.btnbuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdocCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtpagarcon);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txttotalapagar);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtcambio);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnRegistrar);
            this.groupBox3.Controls.Add(this.dgvdata);
            this.groupBox3.Controls.Add(this.btnAgregarproducto);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1431, 691);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registrar Venta";
            // 
            // txtpagarcon
            // 
            this.txtpagarcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagarcon.Location = new System.Drawing.Point(1258, 454);
            this.txtpagarcon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtpagarcon.Name = "txtpagarcon";
            this.txtpagarcon.Size = new System.Drawing.Size(138, 30);
            this.txtpagarcon.TabIndex = 93;
            this.txtpagarcon.TextChanged += new System.EventHandler(this.txtpagarcon_TextChanged);
            this.txtpagarcon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagarcon_KeyDown);
            this.txtpagarcon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagarcon_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1261, 426);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 25);
            this.label12.TabIndex = 92;
            this.label12.Text = "Pagar con:";
            // 
            // txttotalapagar
            // 
            this.txttotalapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalapagar.Location = new System.Drawing.Point(1258, 393);
            this.txttotalapagar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txttotalapagar.Name = "txttotalapagar";
            this.txttotalapagar.Size = new System.Drawing.Size(138, 30);
            this.txttotalapagar.TabIndex = 91;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1261, 365);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 25);
            this.label11.TabIndex = 90;
            this.label11.Text = "Total a Pagar:";
            // 
            // txtcambio
            // 
            this.txtcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcambio.Location = new System.Drawing.Point(1258, 515);
            this.txtcambio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(138, 30);
            this.txtcambio.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1261, 487);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 25);
            this.label10.TabIndex = 88;
            this.label10.Text = "Cambio:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.btnRegistrar.IconColor = System.Drawing.Color.Blue;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 30;
            this.btnRegistrar.Location = new System.Drawing.Point(1258, 568);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 75);
            this.btnRegistrar.TabIndex = 85;
            this.btnRegistrar.Text = "Crear Venta";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Precio,
            this.Cantida,
            this.SubTotal,
            this.btneliminar});
            this.dgvdata.Location = new System.Drawing.Point(18, 311);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(1221, 353);
            this.dgvdata.TabIndex = 84;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 125;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantida
            // 
            this.Cantida.HeaderText = "Cantidad";
            this.Cantida.MinimumWidth = 6;
            this.Cantida.Name = "Cantida";
            this.Cantida.ReadOnly = true;
            this.Cantida.Width = 125;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.MinimumWidth = 6;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.Width = 125;
            // 
            // btnAgregarproducto
            // 
            this.btnAgregarproducto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAgregarproducto.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregarproducto.IconColor = System.Drawing.Color.Green;
            this.btnAgregarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarproducto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarproducto.Location = new System.Drawing.Point(1266, 169);
            this.btnAgregarproducto.Name = "btnAgregarproducto";
            this.btnAgregarproducto.Size = new System.Drawing.Size(126, 121);
            this.btnAgregarproducto.TabIndex = 83;
            this.btnAgregarproducto.Text = "Agregar";
            this.btnAgregarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarproducto.UseVisualStyleBackColor = false;
            this.btnAgregarproducto.Click += new System.EventHandler(this.btnAgregarproducto_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtcantidad);
            this.groupBox4.Controls.Add(this.txtStock);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtPrecioVenta);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtIdProducto);
            this.groupBox4.Controls.Add(this.txtProducto);
            this.groupBox4.Controls.Add(this.btnbuscarProducto);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtCodProducto);
            this.groupBox4.Location = new System.Drawing.Point(18, 169);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Size = new System.Drawing.Size(1229, 121);
            this.groupBox4.TabIndex = 82;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion de Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1058, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 89;
            this.label9.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcantidad.Location = new System.Drawing.Point(1055, 79);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(166, 30);
            this.txtcantidad.TabIndex = 88;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(873, 79);
            this.txtStock.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(174, 30);
            this.txtStock.TabIndex = 87;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(876, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 86;
            this.label8.Text = "Stock:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(690, 79);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(174, 30);
            this.txtPrecioVenta.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 25);
            this.label7.TabIndex = 84;
            this.label7.Text = "Precio:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(190, 44);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(38, 30);
            this.txtIdProducto.TabIndex = 83;
            this.txtIdProducto.Visible = false;
            // 
            // txtProducto
            // 
            this.txtProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(361, 79);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(319, 30);
            this.txtProducto.TabIndex = 82;
            // 
            // btnbuscarProducto
            // 
            this.btnbuscarProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.btnbuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnbuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarProducto.IconColor = System.Drawing.Color.Black;
            this.btnbuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarProducto.IconSize = 26;
            this.btnbuscarProducto.Location = new System.Drawing.Point(264, 77);
            this.btnbuscarProducto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnbuscarProducto.Name = "btnbuscarProducto";
            this.btnbuscarProducto.Size = new System.Drawing.Size(84, 32);
            this.btnbuscarProducto.TabIndex = 81;
            this.btnbuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarProducto.UseVisualStyleBackColor = false;
            this.btnbuscarProducto.Click += new System.EventHandler(this.btnbuscarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "Cod. Producto:";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(10, 80);
            this.txtCodProducto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(244, 30);
            this.txtCodProducto.TabIndex = 43;
            this.txtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProducto_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtnombrecompleto);
            this.groupBox2.Controls.Add(this.btnbuscarProveedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtdocCliente);
            this.groupBox2.Location = new System.Drawing.Point(648, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(744, 120);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente:";
            // 
            // txtnombrecompleto
            // 
            this.txtnombrecompleto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtnombrecompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecompleto.Location = new System.Drawing.Point(426, 75);
            this.txtnombrecompleto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtnombrecompleto.Name = "txtnombrecompleto";
            this.txtnombrecompleto.Size = new System.Drawing.Size(308, 30);
            this.txtnombrecompleto.TabIndex = 82;
            // 
            // btnbuscarProveedor
            // 
            this.btnbuscarProveedor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnbuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnbuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscarProveedor.IconColor = System.Drawing.Color.Black;
            this.btnbuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarProveedor.IconSize = 26;
            this.btnbuscarProveedor.Location = new System.Drawing.Point(329, 72);
            this.btnbuscarProveedor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnbuscarProveedor.Name = "btnbuscarProveedor";
            this.btnbuscarProveedor.Size = new System.Drawing.Size(84, 32);
            this.btnbuscarProveedor.TabIndex = 81;
            this.btnbuscarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscarProveedor.UseVisualStyleBackColor = false;
            this.btnbuscarProveedor.Click += new System.EventHandler(this.btnbuscarProveedor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 80;
            this.label4.Text = "Nombre Completo:";
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
            // txtdocCliente
            // 
            this.txtdocCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtdocCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocCliente.Location = new System.Drawing.Point(10, 76);
            this.txtdocCliente.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtdocCliente.Name = "txtdocCliente";
            this.txtdocCliente.Size = new System.Drawing.Size(309, 30);
            this.txtdocCliente.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbotipodocumento);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Location = new System.Drawing.Point(18, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(609, 120);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 44);
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
            // cbotipodocumento
            // 
            this.cbotipodocumento.BackColor = System.Drawing.Color.Gainsboro;
            this.cbotipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(304, 73);
            this.cbotipodocumento.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(298, 33);
            this.cbotipodocumento.TabIndex = 44;
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfecha.Location = new System.Drawing.Point(10, 76);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(279, 30);
            this.txtfecha.TabIndex = 43;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1546, 795);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnAgregarproducto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private FontAwesome.Sharp.IconButton btnbuscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnombrecompleto;
        private FontAwesome.Sharp.IconButton btnbuscarProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdocCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtpagarcon;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttotalapagar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantida;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}
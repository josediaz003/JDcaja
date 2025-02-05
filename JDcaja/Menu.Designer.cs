namespace JDcaja
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            this.MenuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuNegocio = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubmenuRegistrarVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            this.SubMenuVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAcercade = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuarios,
            this.MenuMantenedor,
            this.MenuVentas,
            this.MenuCompras,
            this.MenuClientes,
            this.MenuProveedores,
            this.MenuReportes,
            this.MenuAcercade});
            this.menuStrip1.Location = new System.Drawing.Point(0, 110);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1445, 78);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuUsuarios
            // 
            this.MenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.MenuUsuarios.IconColor = System.Drawing.Color.Black;
            this.MenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuarios.IconSize = 50;
            this.MenuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuarios.Name = "MenuUsuarios";
            this.MenuUsuarios.Size = new System.Drawing.Size(79, 74);
            this.MenuUsuarios.Text = "Usuarios";
            this.MenuUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuarios.Click += new System.EventHandler(this.MenuUsuarios_Click);
            // 
            // MenuMantenedor
            // 
            this.MenuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuCategoria,
            this.SubMenuProducto,
            this.SubMenuNegocio});
            this.MenuMantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.MenuMantenedor.IconColor = System.Drawing.Color.Black;
            this.MenuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMantenedor.IconSize = 50;
            this.MenuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuMantenedor.Name = "MenuMantenedor";
            this.MenuMantenedor.Size = new System.Drawing.Size(104, 74);
            this.MenuMantenedor.Text = "Mantenedor";
            this.MenuMantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuCategoria
            // 
            this.SubMenuCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuCategoria.IconColor = System.Drawing.Color.Black;
            this.SubMenuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuCategoria.Name = "SubMenuCategoria";
            this.SubMenuCategoria.Size = new System.Drawing.Size(158, 26);
            this.SubMenuCategoria.Text = "Categoria";
            this.SubMenuCategoria.Click += new System.EventHandler(this.SubMenuCategoria_Click);
            // 
            // SubMenuProducto
            // 
            this.SubMenuProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuProducto.IconColor = System.Drawing.Color.Black;
            this.SubMenuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuProducto.Name = "SubMenuProducto";
            this.SubMenuProducto.Size = new System.Drawing.Size(158, 26);
            this.SubMenuProducto.Text = "Productos";
            this.SubMenuProducto.Click += new System.EventHandler(this.SubMenuProducto_Click);
            // 
            // SubMenuNegocio
            // 
            this.SubMenuNegocio.Name = "SubMenuNegocio";
            this.SubMenuNegocio.Size = new System.Drawing.Size(158, 26);
            this.SubMenuNegocio.Text = "Negocio";
            this.SubMenuNegocio.Click += new System.EventHandler(this.negocioToolStripMenuItem_Click);
            // 
            // MenuVentas
            // 
            this.MenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubmenuRegistrarVentas,
            this.SubMenuVerdetalleventa});
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.IconSize = 50;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(66, 74);
            this.MenuVentas.Text = "Ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubmenuRegistrarVentas
            // 
            this.SubmenuRegistrarVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubmenuRegistrarVentas.IconColor = System.Drawing.Color.Black;
            this.SubmenuRegistrarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubmenuRegistrarVentas.Name = "SubmenuRegistrarVentas";
            this.SubmenuRegistrarVentas.Size = new System.Drawing.Size(171, 26);
            this.SubmenuRegistrarVentas.Text = "Registrar";
            this.SubmenuRegistrarVentas.Click += new System.EventHandler(this.SubmenuRegistrarVentas_Click);
            // 
            // SubMenuVerdetalleventa
            // 
            this.SubMenuVerdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerdetalleventa.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerdetalleventa.Name = "SubMenuVerdetalleventa";
            this.SubMenuVerdetalleventa.Size = new System.Drawing.Size(171, 26);
            this.SubMenuVerdetalleventa.Text = "Ver Detalles";
            this.SubMenuVerdetalleventa.Click += new System.EventHandler(this.SubMenuVerdetalleventa_Click);
            // 
            // MenuCompras
            // 
            this.MenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenuRegistrarCompra,
            this.SubMenuVerDetalleCompra});
            this.MenuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.MenuCompras.IconColor = System.Drawing.Color.Black;
            this.MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCompras.IconSize = 50;
            this.MenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(82, 74);
            this.MenuCompras.Text = "Compras";
            this.MenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMenuRegistrarCompra
            // 
            this.SubMenuRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuRegistrarCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuRegistrarCompra.Name = "SubMenuRegistrarCompra";
            this.SubMenuRegistrarCompra.Size = new System.Drawing.Size(171, 26);
            this.SubMenuRegistrarCompra.Text = "Registrar";
            this.SubMenuRegistrarCompra.Click += new System.EventHandler(this.SubMenuRegistrarCompra_Click);
            // 
            // SubMenuVerDetalleCompra
            // 
            this.SubMenuVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMenuVerDetalleCompra.IconColor = System.Drawing.Color.Black;
            this.SubMenuVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMenuVerDetalleCompra.Name = "SubMenuVerDetalleCompra";
            this.SubMenuVerDetalleCompra.Size = new System.Drawing.Size(171, 26);
            this.SubMenuVerDetalleCompra.Text = "Ver Detalles";
            this.SubMenuVerDetalleCompra.Click += new System.EventHandler(this.SubMenuVerDetalleCompra_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuClientes.IconColor = System.Drawing.Color.Black;
            this.MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuClientes.IconSize = 50;
            this.MenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(75, 74);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuClientes.Click += new System.EventHandler(this.MenuClientes_Click);
            // 
            // MenuProveedores
            // 
            this.MenuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.MenuProveedores.IconColor = System.Drawing.Color.Black;
            this.MenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProveedores.IconSize = 50;
            this.MenuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProveedores.Name = "MenuProveedores";
            this.MenuProveedores.Size = new System.Drawing.Size(105, 74);
            this.MenuProveedores.Text = "Proveedores";
            this.MenuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuProveedores.Click += new System.EventHandler(this.MenuProveedores_Click);
            // 
            // MenuReportes
            // 
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 50;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(82, 74);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuReportes.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // MenuAcercade
            // 
            this.MenuAcercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MenuAcercade.IconColor = System.Drawing.Color.Black;
            this.MenuAcercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAcercade.IconSize = 50;
            this.MenuAcercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAcercade.Name = "MenuAcercade";
            this.MenuAcercade.Size = new System.Drawing.Size(89, 74);
            this.MenuAcercade.Text = "Acerca de";
            this.MenuAcercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(1445, 110);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "JD Sistema de Ventas";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 188);
            this.Contenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1445, 497);
            this.Contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUsuario.Location = new System.Drawing.Point(96, 79);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(79, 18);
            this.LblUsuario.TabIndex = 5;
            this.LblUsuario.Text = "LblUsuario";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 685);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuUsuarios;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem MenuMantenedor;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuProveedores;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuAcercade;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblUsuario;
        private FontAwesome.Sharp.IconMenuItem SubMenuCategoria;
        private FontAwesome.Sharp.IconMenuItem SubMenuProducto;
        private FontAwesome.Sharp.IconMenuItem SubmenuRegistrarVentas;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerdetalleventa;
        private FontAwesome.Sharp.IconMenuItem SubMenuRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem SubMenuVerDetalleCompra;
        private System.Windows.Forms.ToolStripMenuItem SubMenuNegocio;
    }
}
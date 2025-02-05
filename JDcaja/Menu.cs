using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace JDcaja
{
    public partial class Menu : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Menu(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);

            foreach (IconMenuItem iconmenu in menuStrip1.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);
                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }
            LblUsuario.Text = usuarioActual.NombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void MenuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuarios());
        }

        private void SubMenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new FrmCategorias());
        }

        private void SubMenuProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new FrmProductos());
        }

        private void SubmenuRegistrarVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new Ventas(usuarioActual));
        }

        private void SubMenuVerdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuVentas, new FrmDetalleVenta());
        }

        private void SubMenuRegistrarCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new FrmCompras(usuarioActual));
        }

        private void SubMenuVerDetalleCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new FrmDetalleCompra());
        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProveedores());
        }

        private void MenuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmReportes());
        }

        private void negocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuMantenedor, new FrmNegocio());
        }
    }
}
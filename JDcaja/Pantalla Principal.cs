using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDcaja
{
    public partial class Pantalla_Principal : Form
    {
        private int childFormNumber = 0;

        public Pantalla_Principal()
        {
            InitializeComponent();
        }
        public string Nombre;
        public string token;
        public int ID;

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login() ;
            login.Show();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        public void crearFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Nombre = this.Nombre;
            ventas.token = this.token;
            ventas.ID = this.ID;
            ventas.MdiParent = this;
            ventas.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Productos productos = new Productos();
            productos.MdiParent = this;
            productos.Nombre = this.Nombre;
            productos.token = this.token;
            productos.ID = this.ID;
            productos.Show();
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pantalla_Factura pantalla_Factura = new Pantalla_Factura();
            pantalla_Factura.MdiParent = this;
            pantalla_Factura.Nombre = this.Nombre;
            pantalla_Factura.token = this.token;
            pantalla_Factura.ID = this.ID;
            pantalla_Factura.Show();
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pantalla_Reportes pantalla_Reportes = new Pantalla_Reportes();
            pantalla_Reportes.MdiParent = this;
            pantalla_Reportes.Nombre = this.Nombre;
            pantalla_Reportes.token = this.token;
            pantalla_Reportes.ID = this.ID;
            pantalla_Reportes.Show();
        }

        private void facturaSobrePrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productosobreprecio productosobreprecio = new productosobreprecio();
            productosobreprecio.MdiParent = this;
            productosobreprecio.Nombre = this.Nombre;
            productosobreprecio.token = this.token;
            productosobreprecio.ID = this.ID;
            productosobreprecio.Show();
        }

        private void facturasCompletadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturasCompletadasPage facturasCompletadas = new FacturasCompletadasPage();
            facturasCompletadas.MdiParent = this;
            facturasCompletadas.Nombre = this.Nombre;
            facturasCompletadas.token = this.token;
            facturasCompletadas.ID = this.ID;
            facturasCompletadas.Show();
        }

        private void venderRecargasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recargas recargas = new Recargas();
            recargas.Nombre = this.Nombre;
            recargas.token = this.token;
            recargas.ID = this.ID;
            recargas.MdiParent = this;
            recargas.Show();
        }
    }
}

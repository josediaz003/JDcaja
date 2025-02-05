using CapaEntidad;
using CapaNegocio;
using JDcaja;
using JDcaja.Modales;
using JDcaja.Utilidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDcaja
{
    public partial class Ventas : Form
    {
        private Usuario _Usuario;

        public Ventas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIdProducto.Text = "0";

            txtpagarcon.Text = "";
            txtcambio.Text = "";
            txttotalapagar.Text = "0";
        }

        private void btnbuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtdocCliente.Text = modal._Cliente.Documento;
                    txtnombrecompleto.Text = modal._Cliente.NombreCompleto;
                    txtCodProducto.Select();
                }
                else
                {
                    txtdocCliente.Select();
                }
            }
        }

        private void btnbuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal._Producto.IdProducto.ToString();
                    txtCodProducto.Text = modal._Producto.Codigo;
                    txtProducto.Text = modal._Producto.Nombre;
                    txtPrecioVenta.Text = modal._Producto.PrecioVenta.ToString("0.00");
                    txtStock.Text = modal._Producto.Stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtCodProducto.Select();
                }
            }
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtCodProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodProducto.BackColor = System.Drawing.Color.Honeydew;
                    txtIdProducto.Text = oProducto.IdProducto.ToString();
                    txtProducto.Text = oProducto.Nombre;
                    txtPrecioVenta.Text = oProducto.PrecioVenta.ToString("0.00");
                    txtStock.Text = oProducto.Stock.ToString();
                    txtcantidad.Select();
                }
                else
                {
                    txtCodProducto.BackColor = System.Drawing.Color.MistyRose;
                    txtIdProducto.Text = "0";
                    txtProducto.Text = "";
                    txtPrecioVenta.Text = "";
                    txtStock.Text = "";
                    txtcantidad.Value = 1;
                }
            }
        }

        private void btnAgregarproducto_Click(object sender, EventArgs e)
        {
            decimal precioventa = 0;
            bool producto_existe = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(txtPrecioVenta.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVenta.Select();
                return;
            }
            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(txtcantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al Stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdProducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {
                dgvdata.Rows.Add(new object[]
                {
                    txtIdProducto.Text,
                    txtProducto.Text,
                    precioventa.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    (txtcantidad.Value * precioventa).ToString("0.00")
                });
                calcularTotal();
                limpiarProducto();
                calcularcambio();
                txtCodProducto.Select();
            }
        }

        private void limpiarProducto()
        {
            txtIdProducto.Text = "0";
            txtCodProducto.Text = "";
            txtProducto.Text = "";
            txtPrecioVenta.Text = "";
            txtStock.Text = "";
            txtcantidad.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
            }
            txttotalapagar.Text = total.ToString("0.00");
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete_12319540.Width;
                var h = Properties.Resources.delete_12319540.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete_12319540, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    calcularTotal();
                    calcularcambio();
                }
            }
        }

        private void txtpagarcon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagarcon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void calcularcambio()
        {
            if (txttotalapagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalapagar.Text);
            if (txtpagarcon.Text.Trim() == "")
            {
                txtpagarcon.Text = "0";
            }
            if (decimal.TryParse(txtpagarcon.Text, out pagacon))
            {
                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txtpagarcon_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    calcularcambio();
            //}
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
        }

        private void txtpagarcon_TextChanged(object sender, EventArgs e)
        {
            calcularcambio();
        }

        //        if (idestatus == 3)
        //                    {
        //                        clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

        //        Ticket1.TextoCentro("Distribuidora de Botella y Plastica");
        //                        Ticket1.TextoCentro("   ByM   ");//imprime una linea de descripcion
        //                        Ticket1.TextoCentro("RNC: 00103213708");//imprime una linea de descripcion

        //                        Ticket1.TextoIzquierda("Dirc: Presidente Estrella Urena 528");
        //                        Ticket1.TextoIzquierda("Tel: 809-234-0959");
        //                        Ticket1.TextoIzquierda("");
        //                        Ticket1.TextoCentro("Factura de Consumo"); //imprime una linea de descripcion
        //                        Ticket1.TextoIzquierda("No NCF: " + txtNCF.Text);
        //                        //Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
        //                        Ticket1.TextoIzquierda("Fecha:" + dateTimePicker1.Text);
        //                        Ticket1.TextoIzquierda("Le Atendio:" + txtUsuario.Text);
        //                        Ticket1.TextoIzquierda("");
        //                        clsFunciones.CreaTicket.LineasGuion();
        //                        clsFunciones.CreaTicket.EncabezadoVenta2();
        //                        clsFunciones.CreaTicket.EncabezadoVenta();
        //                        clsFunciones.CreaTicket.LineasGuion();
        //                        foreach (DataGridViewRow r in dataGridView1.Rows)
        //                        {
        //                            // Articulo                     //Precio                                    cantidad                            Subtotal
        //                            Ticket1.TextoIzquierda(r.Cells[1].Value.ToString());
        //                            Ticket1.AgregaArticulo(r.Cells[0].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[2].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
        //                        }
        //    clsFunciones.CreaTicket.LineasGuion();
        //                        Ticket1.TextoIzquierda(" ");
        //                        Ticket1.AgregaTotales("Total", double.Parse(txtTotal.Text)); // imprime linea con total
        //                        Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtPagado.Text));
        //                        Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(txtBalance.Text));
        //                        Ticket1.TextoIzquierda(" ");
        //                        clsFunciones.CreaTicket.LineasGuion();
        //                        Ticket1.TextoCentro("Gracias por visitar");
        //                        Ticket1.TextoCentro("Distribuidora de Botella y Plastica");
        //                        Ticket1.TextoCentro("   ByM   ");//imprime una linea de descripcion
        //                        Ticket1.TextoCentro(" - ");
        //                        Ticket1.TextoCentro(" - ");
        //                        clsFunciones.CreaTicket.LineasGuion();
        //                        Ticket1.TextoCentro("");
        //                        Ticket1.TextoCentro("");
        //                        Ticket1.TextoCentro("");
        //                        Ticket1.TextoCentro("");
        //                        Ticket1.TextoIzquierda(" ");
        //                        string impresora = "Generic / Text Only";
        //    Ticket1.ImprimirTiket(impresora);

        //                        var confirmResult = MessageBox.Show
        //                                ("Desea imprimir una copia de la factura",
        //                                 "Confirmación?",
        //                                   MessageBoxButtons.YesNo);
        //                        if (confirmResult == DialogResult.No)
        //                        {
        //                            Fila = 0;
        //                            while (dataGridView1.RowCount > 0)//limpia el dgv
        //                            { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
        ////LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
        //txtTotal.Text = "";
        //txtPagado.Text = "";
        //txtBalance.Text = "";

        //txtprod.Focus();
        //btnAgregarProd.Enabled = true;
        //btnBorrarprodt.Enabled = true;
        //btnCobrar.Enabled = true;
        //btnQuitarPrd.Enabled = true;
        //btnGuardarFact.Enabled = true;
        //btnSalir.Enabled = true;
        //btnBscProd.Enabled = true;
        //return;
        //                        }

        //                        Ticket1.TextoCentro("Distribuidora de Botella y Plastica");
        //Ticket1.TextoCentro("   ByM   ");//imprime una linea de descripcion
        //Ticket1.TextoCentro("RNC: 00103213708");//imprime una linea de descripcion

        //Ticket1.TextoIzquierda("Dirc: Presidente Estrella Urena 528");
        //Ticket1.TextoIzquierda("Tel: 809-234-0959");
        //Ticket1.TextoIzquierda("");
        //Ticket1.TextoCentro("Copia Factura de Consumo"); //imprime una linea de descripcion
        //Ticket1.TextoIzquierda("No NCF: " + txtNCF.Text);
        ////Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
        //Ticket1.TextoIzquierda("Fecha:" + dateTimePicker1.Text);
        //Ticket1.TextoIzquierda("Le Atendio:" + txtUsuario.Text);
        //Ticket1.TextoIzquierda("");
        //clsFunciones.CreaTicket.LineasGuion();
        //clsFunciones.CreaTicket.EncabezadoVenta2();
        //clsFunciones.CreaTicket.EncabezadoVenta();
        //clsFunciones.CreaTicket.LineasGuion();
        //foreach (DataGridViewRow r in dataGridView1.Rows)
        //{
        //    // Articulo                     //Precio                                    cantidad                            Subtotal
        //    Ticket1.TextoIzquierda(r.Cells[1].Value.ToString());
        //    Ticket1.AgregaArticulo(r.Cells[0].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[2].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
        //}

        //clsFunciones.CreaTicket.LineasGuion();
        ////Ticket1.AgregaTotales("Sub-Total", double.Parse("000")); // imprime linea con Subtotal
        ////Ticket1.AgregaTotales("Menos Descuento", double.Parse("000")); // imprime linea con decuento total
        ////Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
        //Ticket1.TextoIzquierda(" ");
        //Ticket1.AgregaTotales("Total", double.Parse(txtTotal.Text)); // imprime linea con total
        //                                                             //Ticket1.TextoIzquierda(" ");
        //Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtPagado.Text));
        //Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(txtBalance.Text));

        //// Ticket1.LineasTotales(); // imprime linea

        //Ticket1.TextoIzquierda(" ");
        //clsFunciones.CreaTicket.LineasGuion();
        //Ticket1.TextoCentro("Gracias por visitar");
        //Ticket1.TextoCentro("Distribuidora de Botella y Plastica");
        //Ticket1.TextoCentro("   ByM   ");//imprime una linea de descripcion
        //Ticket1.TextoCentro(" - ");
        //Ticket1.TextoCentro(" - ");
        //clsFunciones.CreaTicket.LineasGuion();
        //Ticket1.TextoCentro("-");
        //Ticket1.TextoCentro("-");
        //Ticket1.TextoCentro("-");
        //Ticket1.TextoCentro("");
        //Ticket1.TextoIzquierda(" ");
        ////string impresora = "Generic / Text Only";
        //Ticket1.ImprimirTiket(impresora);
        //                    }
    }
}
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
using static JDcaja.Productos;

namespace JDcaja
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        public string _host = System.Configuration.ConfigurationSettings.AppSettings["host"];
        public string Nombre;
        public string token;
        public int ID;
        private int cantidad = 1;

        public class respuesta_completarJugada
        {
            public bool Estatus { get; set; }
            public string Mensaje { get; set; }
            public int idfactura { get; set; }
        }

        public class resumenProductos
        {
            //Entrada
            public int ID { get; set; }

            public string token { get; set; }

            //Salida

            public string codigo { get; set; }
            public string nombre { get; set; }
            public string categoria { get; set; }
            public string comentario { get; set; }
            public string precio { get; set; }
            public bool Estatus { get; set; }
            public string Mensaje { get; set; }
        }

        private class respuesta
        {
            public bool Estatus { get; set; }
            public string Mensaje { get; set; }
            public List<resumenProductos> Data { get; set; }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double Balance = 0;
            txtBalance.Text = "0";
            try
            {
                Balance = double.Parse(txtPagado.Text) - double.Parse(txtTotal.Text);
                txtBalance.Text = Balance.ToString();
            }
            catch
            {
                txtBalance.Text = "0";
            }
        }

        public async void loadjugada()
        {
            txtCantidad.Text = cantidad.ToString();
            //var obj = JsonConvert.SerializeObject(new resumenProductos()
            //{
            //    token = this.token,
            //    ID = this.ID
            //});

            //using (HttpClient Client = new HttpClient())
            //{
            //    var content = new StringContent(obj, Encoding.UTF8, "application/json");
            //    var result = await Client.PostAsync(_host + "/api/Productos", content);
            //    respuesta rs = JsonConvert.DeserializeObject<respuesta>(await result.Content.ReadAsStringAsync());
            //    if (rs.Estatus == false)
            //    {
            //        MessageBox.Show(rs.Mensaje);
            //        return;
            //    }
            //    listBox2.Items.Clear();
            //    if (string.IsNullOrEmpty(this.txtprod.Text))
            //    {
            //        foreach (resumenProductos item in rs.Data)
            //        {
            //            listBox2.Items.Add(item: string.Format("{0} -{1}-{2}- Precio= $-{3}"
            //                                , item.categoria, item.codigo, item.nombre, item.precio));

            //        }
            //    }
            //    else
            //    {
            //        foreach (resumenProductos item in rs.Data.Where(x => x.codigo.ToLower().Contains(this.txtprod.Text.ToString()) ||
            //                                                        x.nombre.ToLower().Contains(this.txtprod.Text.ToString())))
            //        {
            //            listBox2.Items.Add(item: string.Format("{0} -{1}-{2}- Precio= $-{3}"
            //                                            , item.categoria, item.codigo, item.nombre, item.precio));

            //        }
            //        //this.Premios = new ObservableCollection<MensajesList>(
            //        //    this.mensajesList.Where(
            //        //        l => l.Titulo.ToLower().Contains(this.Filter.ToLower()) ||
            //        //             l.Comentario.ToLower().Contains(this.Filter.ToLower())));
            //    }

            //}
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            btnGuardarFact.Visible = false;
            btnBscProd.Visible = false;
            txtprod.Visible = false;
            label3.Visible = false;
            //loadjugada();
            txtUsuario.Text = Nombre;
            listBox2.Items.Add(string.Format("{0} -{1}- Precio= $-{2}"
                                            , "1001", "Fardos de Botellas 12oz", "1,300"));
            listBox2.Items.Add(string.Format("{0} -{1}- Precio= $-{2}"
                                            , "1002", "Fardos de Botellas 16oz", "1,300"));
        }

        private void btnBscProd_Click(object sender, EventArgs e)
        {
            loadjugada();
            //this.Hide();
            //Productos productos = new Productos();
            ////productos.MdiParent = this;
            //productos.Nombre = this.Nombre;
            //productos.token = this.token;
            //productos.ID = this.ID;
            //productos.Show();
        }

        public void CostoApagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            for (int i = 0; i < Conteo; i++)
            {
                CostoTotal += float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }

            txtTotal.Text = CostoTotal.ToString();
        }

        private int indexDetalleSelected = -1;
        private string[,] ListaCompra = new string[200, 8];
        private int Fila = 0;

        public void agregarproductos()
        {
            try
            {
                btnAgregarProd.Enabled = false;
                btnBorrarprodt.Enabled = false;
                btnCobrar.Enabled = false;
                btnQuitarPrd.Enabled = false;
                btnGuardarFact.Enabled = false;
                btnSalir.Enabled = false;
                btnBscProd.Enabled = false;

                indexDetalleSelected = listBox2.SelectedIndex;

                if (indexDetalleSelected < 0)
                {
                    MessageBox.Show("Seleccione un Producto");
                    btnAgregarProd.Enabled = true;
                    btnBorrarprodt.Enabled = true;
                    btnCobrar.Enabled = true;
                    btnQuitarPrd.Enabled = true;
                    btnGuardarFact.Enabled = true;
                    btnSalir.Enabled = true;
                    btnBscProd.Enabled = true;
                    return;
                }

                if (int.Parse(txtCantidad.Text) < 0)
                {
                    MessageBox.Show("Debe Digitar la cantidad");
                    btnAgregarProd.Enabled = true;
                    btnBorrarprodt.Enabled = true;
                    btnCobrar.Enabled = true;
                    btnQuitarPrd.Enabled = true;
                    btnGuardarFact.Enabled = true;
                    btnSalir.Enabled = true;
                    btnBscProd.Enabled = true;
                    return;
                }

                var data = listBox2.Items[listBox2.SelectedIndex];
                double Total = 0;
                string[] respuestas = data.ToString().Split(new Char[] { '-' });
                if (respuestas[0] == "")
                {
                    MessageBox.Show("Debe Digitar la cantidad");
                    btnAgregarProd.Enabled = true;
                    btnBorrarprodt.Enabled = true;
                    btnCobrar.Enabled = true;
                    btnQuitarPrd.Enabled = true;
                    btnGuardarFact.Enabled = true;
                    btnSalir.Enabled = true;
                    btnBscProd.Enabled = true;
                    return;
                    //Total = (double.Parse(respuestas[4]) * double.Parse(txtCantidad.Text));
                    //listBox1.Items.Add(item: respuestas[2] + "  -  " + respuestas[4] + "  -  " + txtCantidad.Text + "  -  " + Total);
                }
                if (txtCantidad.Text != "")
                {
                    ListaCompra[Fila, 0] = respuestas[0];
                    ListaCompra[Fila, 1] = respuestas[3];
                    ListaCompra[Fila, 2] = txtCantidad.Text;
                    ListaCompra[Fila, 3] = (float.Parse(txtCantidad.Text) * float.Parse(respuestas[3])).ToString();
                    ListaCompra[Fila, 4] = respuestas[1];

                    dataGridView1.Rows.Add(ListaCompra[Fila, 0], ListaCompra[Fila, 4], ListaCompra[Fila, 2], ListaCompra[Fila, 1], ListaCompra[Fila, 3]);
                    Fila++;// se le agrega uno a la fila para futuras generaciones jejeje

                    txtPagado.Focus();
                }
            }
            catch
            {
            }

            CostoApagar();
            btnAgregarProd.Enabled = true;
            btnBorrarprodt.Enabled = true;
            btnCobrar.Enabled = true;
            btnQuitarPrd.Enabled = true;
            btnGuardarFact.Enabled = true;
            btnSalir.Enabled = true;
            btnBscProd.Enabled = true;
            //ttotal();

            //string j =  txtProducto.Text + " - " + txtPrecio.Text + " - " + txtCantidad.Text +" - " + Total;
        }

        public void ttotal()
        {
            //txtTotal.Text = "0";

            ////var data = listBox1.Items;
            //double Total = 0;

            //foreach (string item in listBox1.Items)
            //{
            //    string[] respuestas = item.ToString().Split(new Char[] { '-' });
            //    Total = double.Parse( respuestas[3]) + Total;
            //    //txtTotal.Text = Total;

            //}
            //txtTotal.Text = Total.ToString();
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            agregarproductos();
        }

        private void btnQuitarPrd_Click(object sender, EventArgs e)
        {
            Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            if (Conteo != 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                CostoApagar();
            }
            else
            {
                MessageBox.Show("Debe seleccional un Productos");
                return;
            }
        }

        private void btnBorrarprodt_Click(object sender, EventArgs e)
        {
            Fila = 0;
            while (dataGridView1.RowCount > 0)//limpia el dgv
            { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
            //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
            txtTotal.Text = "";
            txtPagado.Text = "";
            txtBalance.Text = "";
            txtCliente.Text = "";

            txtprod.Focus();
            //listBox1.Items.Clear();
            //txtTotal.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
            //this.Close();
        }

        public async void RegistrarCompra(int idestatus)
        {
            string Cliente = "Anonimo";
            btnAgregarProd.Enabled = false;
            btnBorrarprodt.Enabled = false;
            btnCobrar.Enabled = false;
            btnQuitarPrd.Enabled = false;
            btnGuardarFact.Enabled = false;
            btnSalir.Enabled = false;
            btnBscProd.Enabled = false;
            if (txtPagado.Text == "")
            {
                txtPagado.Text = "0";
            }

            Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            if (Conteo != 0)
            {
                try
                {
                    if (idestatus == 3)
                    {
                        if (int.Parse(txtPagado.Text) < int.Parse(txtTotal.Text))
                        {
                            MessageBox.Show("Debe Realizar el Pago Completo");
                            btnAgregarProd.Enabled = true;
                            btnBorrarprodt.Enabled = true;
                            btnCobrar.Enabled = true;
                            btnQuitarPrd.Enabled = true;
                            btnGuardarFact.Enabled = true;
                            btnSalir.Enabled = true;
                            btnBscProd.Enabled = true;
                            return;
                        }
                    }

                    if (txtCliente.Text == "")
                    {
                        txtCliente.Text = Cliente;
                    }

                    List<detallesfacturas> detallesfacturas = new List<detallesfacturas>();

                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        detallesfacturas.Add(new detallesfacturas()
                        {
                            producto = r.Cells[0].Value.ToString(),
                            precio = float.Parse(r.Cells[3].Value.ToString()),
                            cantidad = r.Cells[2].Value.ToString(),
                            totalpago = float.Parse(r.Cells[4].Value.ToString())
                        });
                    }

                    if (detallesfacturas.Count <= 0)
                    {
                        MessageBox.Show("Debe Agregar sus Productos");
                        btnAgregarProd.Enabled = true;
                        btnBorrarprodt.Enabled = true;
                        btnCobrar.Enabled = true;
                        btnQuitarPrd.Enabled = true;
                        btnGuardarFact.Enabled = true;
                        btnSalir.Enabled = true;
                        btnBscProd.Enabled = true;
                        return;
                    }

                    //Completarfactura model = new Completarfactura()
                    //{
                    //    cliente = txtCliente.Text,
                    //    detallesfacturas = detallesfacturas,
                    //    idestatus = idestatus,
                    //    toke_usuario = token,
                    //    totalpago = float.Parse(txtTotal.Text)
                    //};

                    //using (HttpClient Client = new HttpClient())
                    //{
                    //    var serialmodel = JsonConvert.SerializeObject(model);
                    //    var content = new StringContent(serialmodel, Encoding.UTF8, "application/json");
                    //    var result = await Client.PostAsync(_host + "/api/RegistroFactura", content);
                    //    respuesta_completarJugada rs = JsonConvert.DeserializeObject<respuesta_completarJugada>(await result.Content.ReadAsStringAsync());

                    //    if (rs.Estatus == true)
                    //    {
                    if (idestatus == 3)
                    {
                        clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

                        Ticket1.TextoCentro("Distribuidora de Botella y Plastica");
                        Ticket1.TextoCentro("   ByM   ");//imprime una linea de descripcion
                        Ticket1.TextoCentro("RNC: 00103213708");//imprime una linea de descripcion

                        Ticket1.TextoIzquierda("Dirc: Presidente Estrella Urena 528");
                        Ticket1.TextoIzquierda("Tel: 809-234-0959");
                        Ticket1.TextoIzquierda("");
                        Ticket1.TextoCentro("Factura de Consumo"); //imprime una linea de descripcion
                        Ticket1.TextoIzquierda("No Fac: " + txtNCF.Text);
                        Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                        Ticket1.TextoIzquierda("Le Atendio:" + txtUsuario.Text);
                        Ticket1.TextoIzquierda("");
                        clsFunciones.CreaTicket.LineasGuion();
                        clsFunciones.CreaTicket.EncabezadoVenta2();
                        clsFunciones.CreaTicket.EncabezadoVenta();
                        clsFunciones.CreaTicket.LineasGuion();
                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            // Articulo                     //Precio                                    cantidad                            Subtotal
                            Ticket1.TextoIzquierda(r.Cells[1].Value.ToString());
                            Ticket1.AgregaArticulo(r.Cells[0].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[2].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
                        }
                        clsFunciones.CreaTicket.LineasGuion();
                        Ticket1.TextoIzquierda(" ");
                        Ticket1.AgregaTotales("Total", double.Parse(txtTotal.Text)); // imprime linea con total
                        Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtPagado.Text));
                        Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(txtBalance.Text));
                        Ticket1.TextoIzquierda(" ");
                        clsFunciones.CreaTicket.LineasGuion();
                        Ticket1.TextoCentro("Gracias por visitar Lendy's Tropical");
                        clsFunciones.CreaTicket.LineasGuion();
                        Ticket1.TextoCentro("");
                        Ticket1.TextoCentro("");
                        Ticket1.TextoCentro("");
                        Ticket1.TextoCentro("");
                        Ticket1.TextoIzquierda(" ");
                        string impresora = "Generic / Text Only";
                        Ticket1.ImprimirTiket(impresora);

                        var confirmResult = MessageBox.Show
                                ("Desea imprimir una copia de la factura",
                                 "Confirmación?",
                                   MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.No)
                        {
                            Fila = 0;
                            while (dataGridView1.RowCount > 0)//limpia el dgv
                            { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
                            //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
                            txtTotal.Text = "";
                            txtPagado.Text = "";
                            txtBalance.Text = "";

                            txtprod.Focus();
                            btnAgregarProd.Enabled = true;
                            btnBorrarprodt.Enabled = true;
                            btnCobrar.Enabled = true;
                            btnQuitarPrd.Enabled = true;
                            btnGuardarFact.Enabled = true;
                            btnSalir.Enabled = true;
                            btnBscProd.Enabled = true;
                            return;
                        }

                        Ticket1.TextoCentro("Distribuidora de Botellas");
                        Ticket1.TextoCentro(" Bym ");//imprime una linea de descripcion

                        Ticket1.TextoIzquierda("Dirc: Presidente Estrella Ure;a");
                        Ticket1.TextoIzquierda("Tel: 809-919-9012");
                        Ticket1.TextoIzquierda("");
                        Ticket1.TextoCentro("Copia Factura de Venta"); //imprime una linea de descripcion
                        //Ticket1.TextoIzquierda("No Fac: " + rs.idfactura);
                        Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                        Ticket1.TextoIzquierda("Le Atendio:" + txtUsuario.Text);
                        Ticket1.TextoIzquierda("");
                        clsFunciones.CreaTicket.LineasGuion();
                        clsFunciones.CreaTicket.EncabezadoVenta2();
                        clsFunciones.CreaTicket.EncabezadoVenta();
                        clsFunciones.CreaTicket.LineasGuion();
                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            // Articulo                     //Precio                                    cantidad                            Subtotal
                            Ticket1.TextoIzquierda(r.Cells[1].Value.ToString());
                            Ticket1.AgregaArticulo(r.Cells[0].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[2].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
                        }

                        clsFunciones.CreaTicket.LineasGuion();
                        //Ticket1.AgregaTotales("Sub-Total", double.Parse("000")); // imprime linea con Subtotal
                        //Ticket1.AgregaTotales("Menos Descuento", double.Parse("000")); // imprime linea con decuento total
                        //Ticket1.AgregaTotales("Mas ITBIS", double.Parse("000")); // imprime linea con ITBis total
                        Ticket1.TextoIzquierda(" ");
                        Ticket1.AgregaTotales("Total", double.Parse(txtTotal.Text)); // imprime linea con total
                                                                                     //Ticket1.TextoIzquierda(" ");
                        Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtPagado.Text));
                        Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(txtBalance.Text));

                        // Ticket1.LineasTotales(); // imprime linea

                        Ticket1.TextoIzquierda(" ");
                        clsFunciones.CreaTicket.LineasGuion();
                        Ticket1.TextoCentro("Gracias por visitar Lendy's Tropical");
                        clsFunciones.CreaTicket.LineasGuion();
                        Ticket1.TextoCentro("");
                        Ticket1.TextoCentro("");
                        Ticket1.TextoCentro("");
                        Ticket1.TextoCentro("");
                        Ticket1.TextoIzquierda(" ");
                        //string impresora = "Generic / Text Only";
                        Ticket1.ImprimirTiket(impresora);
                    }

                    Fila = 0;
                    while (dataGridView1.RowCount > 0)//limpia el dgv
                    { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
                    //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
                    txtTotal.Text = "";
                    txtPagado.Text = "";
                    txtBalance.Text = "";

                    txtprod.Focus();
                    btnAgregarProd.Enabled = true;
                    btnBorrarprodt.Enabled = true;
                    btnCobrar.Enabled = true;
                    btnQuitarPrd.Enabled = true;
                    btnGuardarFact.Enabled = true;
                    btnSalir.Enabled = true;
                    btnBscProd.Enabled = true;
                    return;
                    // }
                    //}
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                    btnAgregarProd.Enabled = true;
                    btnBorrarprodt.Enabled = true;
                    btnCobrar.Enabled = true;
                    btnQuitarPrd.Enabled = true;
                    btnGuardarFact.Enabled = true;
                    btnSalir.Enabled = true;
                    btnBscProd.Enabled = true;
                    return;
                }
                //MessageBox.Show("no se pudo completar la Venta");
                //btnAgregarProd.Enabled = true;
                //btnBorrarprodt.Enabled = true;
                //btnCobrar.Enabled = true;
                //btnQuitarPrd.Enabled = true;
                //btnGuardarFact.Enabled = true;
                //btnSalir.Enabled = true;
                //btnBscProd.Enabled = true;
                //return;
            }
            Fila = 0;
            while (dataGridView1.RowCount > 0)//limpia el dgv
            { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
            //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
            txtTotal.Text = "";
            txtPagado.Text = "";
            txtBalance.Text = "";
            txtCliente.Text = "";

            txtprod.Focus();
        }

        private int Conteo;

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (txtNCF.Text == "" || txtNCF.Text == null)
            {
                MessageBox.Show("Debe Agregar el NCF de la factura");
                btnAgregarProd.Enabled = true;
                btnBorrarprodt.Enabled = true;
                btnCobrar.Enabled = true;
                btnQuitarPrd.Enabled = true;
                btnGuardarFact.Enabled = true;
                btnSalir.Enabled = true;
                btnBscProd.Enabled = true;
                return;
            }
            var confirmResult = MessageBox.Show
                ("Esta segura que desea cobrar esa factura",
               "Confirmación?",
               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for

            if (Conteo != 0)
            {
                RegistrarCompra(3);
            }
            else
            {
                MessageBox.Show("Debe agregar los productos");
            }
        }

        private void txtprod_TextChanged(object sender, EventArgs e)
        {
            loadjugada();
        }

        private void btnGuardarFact_Click(object sender, EventArgs e)
        {
            RegistrarCompra(4);
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
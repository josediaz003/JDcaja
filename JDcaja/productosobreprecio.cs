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
    public partial class productosobreprecio : Form
    {
        public productosobreprecio()
        {
            InitializeComponent();
        }

        private void productosobreprecio_Load(object sender, EventArgs e)
        {
            loadjugada();
        }
        public string _host = System.Configuration.ConfigurationSettings.AppSettings["host"];
        public string Nombre;
        public string token;
        public int ID;
        class ListItem
        {
            public string Texto { get; set; }
            public string Valor { get; set; }
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
        class respuesta
        {
            public bool Estatus { get; set; }
            public string Mensaje { get; set; }
            public List<resumenProductos> Data { get; set; }
            public int ID { get; set; }

        }
        public class datosobreprecio
        {
            public int ID { get; set; }
            public string token { get; set; }
            public string cliente { get; set; }
            public string producto { get; set; }
            public float precio { get; set; }
            public string cantidad { get; set; }
            public string usuario { get; set; }
            public string clave { get; set; }
        }
        public async void loadjugada()
        {
            var obj = JsonConvert.SerializeObject(new resumenProductos()
            {

                token = this.token,
                ID = this.ID

            });

            using (HttpClient Client = new HttpClient())
            {

                var content = new StringContent(obj, Encoding.UTF8, "application/json");
                var result = await Client.PostAsync(_host + "/api/Productos", content);
                respuesta rs = JsonConvert.DeserializeObject<respuesta>(await result.Content.ReadAsStringAsync());
                if (rs.Estatus == false)
                {
                    MessageBox.Show(rs.Mensaje);
                    return;
                }
                listBox1.Items.Clear();
                if (string.IsNullOrEmpty(this.txtprod.Text))
                {
                    foreach (resumenProductos item in rs.Data)
                    {

                        listBox1.Items.Add(item: string.Format("{0} -{1}-{2}- Precio= ${3}"
                                            , item.categoria, item.codigo, item.nombre, item.precio));

                    }
                }
                else
                {
                    foreach (resumenProductos item in rs.Data.Where(x => x.codigo.ToLower().Contains(this.txtprod.Text.ToString()) ||
                                                                    x.nombre.ToLower().Contains(this.txtprod.Text.ToString())))
                    {

                        listBox1.Items.Add(item: string.Format("{0} -{1}-{2}- Precio= ${3}"
                                            , item.categoria, item.codigo, item.nombre, item.precio));

                    }
                    //this.Premios = new ObservableCollection<MensajesList>(
                    //    this.mensajesList.Where(
                    //        l => l.Titulo.ToLower().Contains(this.Filter.ToLower()) ||
                    //             l.Comentario.ToLower().Contains(this.Filter.ToLower())));
                }






            }

        }

        private async void btnCobrar_Click(object sender, EventArgs e)
        {
            btnCobrar.Enabled = false;
            var data = listBox1.Items[listBox1.SelectedIndex];
            string[] respuestas = data.ToString().Split(new Char[] { '-' });
            if (respuestas[0] == "")
            {
                MessageBox.Show("Debe Seleccionar el producto");
                btnCobrar.Enabled = true;
                return;

            }
            var confirmResult = MessageBox.Show
                ("Esta segura que desea vender un"+ respuestas[2]+ "a un precio de "+txbPrecio.Text,
               "Confirmación?",
               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                btnCobrar.Enabled = true;
                return;
            }
            try
            {
                
                if (txbCliente.Text == "")
                {
                    MessageBox.Show("Debe indicar el cliente");
                    btnCobrar.Enabled = true;
                    return;
                }
                if (txbPrecio.Text == "")
                {
                    MessageBox.Show("Debe indicar el precio");
                    btnCobrar.Enabled = true;
                    return;
                }
                if (txbUsuario.Text == "")
                {
                    MessageBox.Show("Debe indicar el usuario administrador");
                    btnCobrar.Enabled = true;
                    return;
                }
                if (txbClave.Text == "")
                {
                    MessageBox.Show("Debe indicar la clave del usuario administrador");
                    btnCobrar.Enabled = true;
                    return;
                }
                var obj = JsonConvert.SerializeObject(new datosobreprecio()
                {

                    ID = ID,
                    token = token,
                    cliente = txbCliente.Text,
                    producto = respuestas[1],
                    precio = float.Parse(txtTotal.Text),
                    cantidad = txbCantidad.Text,
                    usuario = txbUsuario.Text,
                    clave = txbClave.Text


                });
                double total = 0;

                using (HttpClient Client = new HttpClient())
                {

                    var content = new StringContent(obj, Encoding.UTF8, "application/json");
                    var result = await Client.PostAsync(_host + "/api/sobreprecio", content);
                    respuesta rs = JsonConvert.DeserializeObject<respuesta>(await result.Content.ReadAsStringAsync());
                    if (rs.Estatus == false)
                    {
                        MessageBox.Show(rs.Mensaje);
                        txbUsuario.Text = "";
                        txbClave.Text = "";
                        btnCobrar.Enabled = true;
                        return;
                    }

                    clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

                    Ticket1.TextoCentro(" Lendy's Tropical ");
                    Ticket1.TextoCentro("Restaurant y Car Wash ");//imprime una linea de descripcion
                    Ticket1.TextoIzquierda("        Factura de Venta especial       "); //imprime una linea de descripcion
                    Ticket1.TextoIzquierda("Dirc: Avenida Venezuela");
                    Ticket1.TextoIzquierda("Tel: 809-919-9012");
                    Ticket1.TextoIzquierda("No Fac: "+rs.ID);
                    Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                    Ticket1.TextoIzquierda("Le Atendio:" + txbUsuario.Text);
                    Ticket1.TextoIzquierda("");
                    clsFunciones.CreaTicket.LineasGuion();
                    clsFunciones.CreaTicket.EncabezadoVenta2();
                    clsFunciones.CreaTicket.EncabezadoVenta();
                    clsFunciones.CreaTicket.LineasGuion();


                    // Articulo                     //Precio                                    cantidad                            Subtotal
                    Ticket1.TextoIzquierda(respuestas[2]);
                    Ticket1.AgregaArticulo(respuestas[1], double.Parse(txbPrecio.Text), int.Parse(txbCantidad.Text), double.Parse(txtTotal.Text)); //imprime una linea de descripcion



                    clsFunciones.CreaTicket.LineasGuion();
                    Ticket1.TextoIzquierda(" ");
                    Ticket1.AgregaTotales("Total", double.Parse(txtTotal.Text)); // imprime linea con total
                    Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtTotal.Text));
                    Ticket1.AgregaTotales("Efectivo Devuelto:", 0);
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



                    var copia = MessageBox.Show
                            ("Desea imprimir una copia de la factura",
                             "Confirmación?",
                               MessageBoxButtons.YesNo);
                    if (copia == DialogResult.No)
                    {
                        txbCliente.Text = "";
                        txbPrecio.Text = "0";
                        txbCantidad.Text = "1";
                        txbUsuario.Text = "";
                        txbClave.Text = "";
                        btnCobrar.Enabled = true;
                        return;
                    }


                    Ticket1.TextoCentro(" Lendy's Tropical ");
                    Ticket1.TextoCentro("Restaurant y Car Wash ");//imprime una linea de descripcion
                    Ticket1.TextoIzquierda("    Copia Factura de Venta especial     "); //imprime una linea de descripcion
                    Ticket1.TextoIzquierda("Dirc: Avenida Venezuela");
                    Ticket1.TextoIzquierda("Tel: 809-919-9012");
                    Ticket1.TextoIzquierda("No Fac: " + rs.ID);
                    Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                    Ticket1.TextoIzquierda("Le Atendio:" + txbUsuario.Text);
                    Ticket1.TextoIzquierda("");
                    clsFunciones.CreaTicket.LineasGuion();
                    clsFunciones.CreaTicket.EncabezadoVenta2();
                    clsFunciones.CreaTicket.EncabezadoVenta();
                    clsFunciones.CreaTicket.LineasGuion();


                    // Articulo                     //Precio                                    cantidad                            Subtotal
                    Ticket1.TextoIzquierda(respuestas[2]);
                    Ticket1.AgregaArticulo(respuestas[1], double.Parse(txbPrecio.Text), int.Parse(txbCantidad.Text), double.Parse(txtTotal.Text)); //imprime una linea de descripcion



                    clsFunciones.CreaTicket.LineasGuion();
                    Ticket1.TextoIzquierda(" ");
                    Ticket1.AgregaTotales("Total", double.Parse(txtTotal.Text)); // imprime linea con total
                    Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtTotal.Text));
                    Ticket1.AgregaTotales("Efectivo Devuelto:", 0);
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




                    MessageBox.Show(rs.Mensaje);
                    txbCliente.Text = "";
                    txbPrecio.Text = "0";
                    txbCantidad.Text = "1";
                    txbUsuario.Text = "";
                    txbClave.Text = "";
                    btnCobrar.Enabled = true;
                    return;

                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                txbCliente.Text = "";
                txbPrecio.Text = "0";
                txbCantidad.Text = "1";
                txbUsuario.Text = "";
                txbClave.Text = "";
                btnCobrar.Enabled = true;
                return;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double Balance = 0;
            txtTotal.Text = "0";
            try
            {
                Balance = double.Parse(txbPrecio.Text) * double.Parse(txbCantidad.Text);
                txtTotal.Text = Balance.ToString();
            }
            catch
            {

                txtTotal.Text = "0";
            }
        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            double Balance = 0;
            txtTotal.Text = "0";
            try
            {
                Balance = double.Parse(txbPrecio.Text) * double.Parse(txbCantidad.Text);
                txtTotal.Text = Balance.ToString();
            }
            catch
            {

                txtTotal.Text = "0";
            }
        }
    }
}

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
using static JDcaja.Agregar_Productos;

namespace JDcaja
{
    public partial class Pantalla_Factura : Form
    {
        public Pantalla_Factura()
        {
            InitializeComponent();
        }
        public string _host = System.Configuration.ConfigurationSettings.AppSettings["host"];
        public string Nombre;
        public string token;
        public int ID;
        public string Usuario;
        public string codigo;
        public string produto;
        public string cantidad;
        public string precio;
        public class respuesta_completarJugada
        {
            public bool Estatus { get; set; }
            public string Mensaje { get; set; }
        }
        public class Completarfactura
        {
            //public List<detallesfacturas> detallesfacturas { get; set; }
            public int ID { get; set; }
            public string usuario { get; set; }
            public DateTime fecha { get; set; }
            public string cliente { get; set; }
            public double totalpago { get; set; }
            public string estatus { get; set; }

        }
        //public List<detallesfacturas> productos { get; set; }
        public class resumenFacturas
        {
            //Entrada
            public int ID { get; set; }
            public string token { get; set; }
            public int idfactura { get; set; }


        }

        class respuesta
        {
            public bool Estatus { get; set; }
            public string Mensaje { get; set; }
            public List<Completarfactura> Data { get; set; }
            public List<detallesfacturas> detalle { get; set; }

        }
        private List<detallesfacturas> detalle;
        private void Pantalla_Factura_Load(object sender, EventArgs e)
        {
            LoadDatos();
        }

        public async void LoadDatos()
        {


            var obj = JsonConvert.SerializeObject(new resumenFacturas()
            {
                token = token,
                ID = ID

            });

            using (HttpClient Client = new HttpClient())
            {

                var content = new StringContent(obj, Encoding.UTF8, "application/json");
                var result = await Client.PostAsync(_host + "/api/Facturaspendientes", content);
                respuesta rs = JsonConvert.DeserializeObject<respuesta>(await result.Content.ReadAsStringAsync());
                if (rs.Estatus == false)
                {
                    MessageBox.Show(rs.Mensaje);
                    return;
                }

                detalle = rs.detalle;
                listBox2.Items.Clear();
                if (string.IsNullOrEmpty(this.txtfact.Text))
                {
                    foreach (Completarfactura item in rs.Data)
                    {

                        listBox2.Items.Add(item: string.Format("{0}- {1}  - {2}-{3}  - Precio= $-{4} - {5}"
                                            , item.usuario, item.cliente, item.fecha, item.ID, item.totalpago, item.estatus));

                    }
                }
                else
                {
                    foreach (Completarfactura item in rs.Data.Where(x => x.usuario.ToLower().Contains(this.txtfact.Text.ToString()) ||
                                                                    x.cliente.ToLower().Contains(this.txtfact.Text.ToString())))
                    {
                        listBox2.Items.Add(item: string.Format("{0}- {1}  - {2} - {3}  - Precio= $-{4} - {5}"
                                           , item.usuario, item.cliente, item.fecha, item.ID, item.totalpago, item.estatus));
                    }
                    //this.Premios = new ObservableCollection<MensajesList>(
                    //    this.mensajesList.Where(
                    //        l => l.Titulo.ToLower().Contains(this.Filter.ToLower()) ||
                    //             l.Comentario.ToLower().Contains(this.Filter.ToLower())));
                }



            }
        }
        public void CostoApagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            for (int i = 0; i < Conteo; i++)
            {

                CostoTotal += float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());



            }

            txtTotal.Text = CostoTotal.ToString();



        }
        private int indexDetalleSelected = -1;
        string[,] ListaCompra = new string[200, 8];
        int Fila = 0;
        int idfact;
        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                btnAgregar.Enabled = false;
                btnBorrar.Enabled = false;
                btnCobrar.Enabled = false;
                btnQuitarPrd.Enabled = false;
                btnVer.Enabled = false;
                Fila = 0;
                while (dataGridView1.RowCount > 0)//limpia el dgv
                { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
                //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();

                indexDetalleSelected = listBox2.SelectedIndex;

                if (indexDetalleSelected < 0)
                {
                    MessageBox.Show("Seleccione un Producto");
                    btnAgregar.Enabled = true;
                    btnBorrar.Enabled = true;
                    btnCobrar.Enabled = true;
                    btnQuitarPrd.Enabled = true;
                    btnVer.Enabled = true;
                    return;
                }



                var data = listBox2.Items[listBox2.SelectedIndex];
                //double Total = 0;
                string[] respuestas = data.ToString().Split(new Char[] { '-' });

                Usuario = respuestas[0];
                idfact = int.Parse(respuestas[3]);
                foreach (detallesfacturas item in detalle.Where(x => x.idfactura == int.Parse(respuestas[3])))
                {

                    ListaCompra[Fila, 0] = item.producto;
                    ListaCompra[Fila, 1] = item.cantidad.ToString();
                    ListaCompra[Fila, 2] = item.precio.ToString();
                    ListaCompra[Fila, 3] = item.totalpago.ToString();
                    ListaCompra[Fila, 4] = respuestas[3];
                    ListaCompra[Fila, 5] = item.NombreProducto;



                    dataGridView1.Rows.Add(ListaCompra[Fila, 4], ListaCompra[Fila, 0], ListaCompra[Fila, 5], ListaCompra[Fila, 1], ListaCompra[Fila, 2], ListaCompra[Fila, 3]);
                    Fila++;// se le agrega uno a la fila para futuras generaciones


                }


                txtTotal.Text = "0";
                txtPagado.Text = "";
                txtBalance.Text = "0";

                txtPagado.Focus();
                btnAgregar.Enabled = true;
                btnBorrar.Enabled = true;
                btnCobrar.Enabled = true;
                btnQuitarPrd.Enabled = true;
                btnVer.Enabled = true;

            }
            catch
            {

            }
            CostoApagar();
        }
        int Conteo;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            if (Conteo == 0)
            {
                MessageBox.Show("Debe ver alguna factura para poder agregarles productos");
                return;

            }
            Agregar_Productos agregar_Productos = new Agregar_Productos();
            agregar_Productos.Nombre = Nombre;
            agregar_Productos.idfactura = idfact.ToString();

            agregar_Productos.token = token;
            agregar_Productos.ID = ID;
            agregar_Productos.agregar = this;


            agregar_Productos.ShowDialog();
            CostoApagar();
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                indexDetalleSelected = listBox2.SelectedIndex;

                if (indexDetalleSelected < 0)
                {
                    MessageBox.Show("Seleccione un Producto");
                    return;
                }


                var data = listBox2.Items[listBox2.SelectedIndex];
                //double Total = 0;
                string[] respuestas = data.ToString().Split(new Char[] { '-' });

                //  int.Parse(respuestas[3]

                resumenFacturas resumenFacturas = new resumenFacturas()
                {

                    ID = ID,
                    token = token,
                    idfactura = int.Parse(respuestas[3])

                };

                using (HttpClient Client = new HttpClient())
                {
                    var obj = JsonConvert.SerializeObject(resumenFacturas);
                    var content = new StringContent(obj, Encoding.UTF8, "application/json");
                    var result = await Client.PostAsync(_host + "/api/CancelaFactura", content);
                    respuesta rs = JsonConvert.DeserializeObject<respuesta>(await result.Content.ReadAsStringAsync());

                    if (rs.Estatus == true)
                    {
                        LoadDatos();
                        MessageBox.Show(rs.Mensaje);
                        return;
                    }
                }





            }
            catch
            {


            }
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
        

        private async void btnCobrar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
            btnCobrar.Enabled = false;
            btnQuitarPrd.Enabled = false;
            btnVer.Enabled = false;
            
            var confirmResult = MessageBox.Show
                ("Esta segura que desea cobrar esa factura",
               "Confirmación?",
               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                btnAgregar.Enabled = true;
                btnBorrar.Enabled = true;
                btnCobrar.Enabled = true;
                btnQuitarPrd.Enabled = true;
                btnVer.Enabled = true;
                return;
            }
            if (txtPagado.Text == "")
            {
                txtPagado.Text = "0";
            }

            Conteo = dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            if (Conteo != 0)
            {
                try
                {
                    
                    if (int.Parse(txtPagado.Text) < int.Parse(txtTotal.Text))
                    {
                        MessageBox.Show("Debe Realizar el Pago Completo");
                        btnAgregar.Enabled = true;
                        btnBorrar.Enabled = true;
                        btnCobrar.Enabled = true;
                        btnQuitarPrd.Enabled = true;
                        btnVer.Enabled = true;
                        return;
                    }
                    
                    List<detallesfacturas> detallesfacturas = new List<detallesfacturas>();


                    foreach (DataGridViewRow r in dataGridView1.Rows)
                    {
                        detallesfacturas.Add(new detallesfacturas()
                        {
                            idfactura = int.Parse(r.Cells[0].Value.ToString()),
                            producto = r.Cells[1].Value.ToString(),
                            precio = float.Parse(r.Cells[4].Value.ToString()),
                            cantidad = r.Cells[3].Value.ToString(),
                            totalpago = float.Parse(r.Cells[5].Value.ToString())
                        });

                    }


                    if (detallesfacturas.Count <= 0)
                    {
                        MessageBox.Show("Debe Agregar sus Productos");
                        btnAgregar.Enabled = true;
                        btnBorrar.Enabled = true;
                        btnCobrar.Enabled = true;
                        btnQuitarPrd.Enabled = true;
                        btnVer.Enabled = true;
                        return;
                    }


                    cobrarfactura model = new cobrarfactura()
                    {
                        
                        detallesfacturas = detallesfacturas,
                        toke_usuario = token,
                        idfactura = idfact

                    };


                    using (HttpClient Client = new HttpClient())
                    {
                        var serialmodel = JsonConvert.SerializeObject(model);
                        var content = new StringContent(serialmodel, Encoding.UTF8, "application/json");
                        var result = await Client.PostAsync(_host + "/api/EditFacturas", content);
                        respuesta_completarJugada rs = JsonConvert.DeserializeObject<respuesta_completarJugada>(await result.Content.ReadAsStringAsync());


                        if (rs.Estatus == true)
                        {

                            
                            clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

                            Ticket1.TextoCentro(" Lendy's Tropical ");
                            Ticket1.TextoCentro("Restaurant y Car Wash ");//imprime una linea de descripcion
                            Ticket1.TextoIzquierda("Dirc: Avenida Venezuela");
                            Ticket1.TextoIzquierda("Tel: 809-919-9012");
                            Ticket1.TextoIzquierda("");
                            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                            Ticket1.TextoIzquierda("No Fac: " + idfact);
                            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                            Ticket1.TextoIzquierda("Cajera: " + Nombre);
                            Ticket1.TextoIzquierda("Le Atendio: " + Usuario);
                            Ticket1.TextoIzquierda("");
                            clsFunciones.CreaTicket.LineasGuion();
                            clsFunciones.CreaTicket.EncabezadoVenta2();
                            clsFunciones.CreaTicket.EncabezadoVenta();
                            clsFunciones.CreaTicket.LineasGuion();
                            foreach (DataGridViewRow r in dataGridView1.Rows)
                            {
                                // Articulo                     //Precio                                    cantidad                            Subtotal
                                Ticket1.TextoIzquierda(r.Cells[2].Value.ToString());
                                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[4].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[5].Value.ToString())); //imprime una linea de descripcion
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


                            var copiaFactura = MessageBox.Show
                                        ("Desea imprimir una copia de la factura",
                                         "Confirmación?",
                                           MessageBoxButtons.YesNo);
                            if (copiaFactura == DialogResult.No)
                            {
                                Fila = 0;
                                while (dataGridView1.RowCount > 0)//limpia el dgv
                                { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
                                //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
                                txtTotal.Text = "";
                                txtPagado.Text = "";
                                txtBalance.Text = "";
                                LoadDatos();
                                txtfact.Focus();
                                btnAgregar.Enabled = true;
                                btnBorrar.Enabled = true;
                                btnCobrar.Enabled = true;
                                btnQuitarPrd.Enabled = true;
                                btnVer.Enabled = true;

                                return;
                            }
                            Ticket1.TextoCentro(" Lendy's Restaurant ");
                            Ticket1.TextoCentro("Restaurant y Car Wash ");//imprime una linea de descripcion
                            Ticket1.TextoIzquierda("Dirc: Avenida Venezuela");
                            Ticket1.TextoIzquierda("Tel: 809-919-9012");
                            Ticket1.TextoIzquierda("");
                            Ticket1.TextoCentro("Copia Factura de Venta"); //imprime una linea de descripcion
                            Ticket1.TextoIzquierda("No Fac: " + idfact);
                            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                            Ticket1.TextoIzquierda("Cajera: " + Nombre);
                            Ticket1.TextoIzquierda("Le Atendio: " + Usuario);
                            Ticket1.TextoIzquierda("");
                            clsFunciones.CreaTicket.LineasGuion();
                            clsFunciones.CreaTicket.EncabezadoVenta2();
                            clsFunciones.CreaTicket.EncabezadoVenta();
                            clsFunciones.CreaTicket.LineasGuion();
                            foreach (DataGridViewRow r in dataGridView1.Rows)
                            {
                                // Articulo                     //Precio                                    cantidad                            Subtotal
                                Ticket1.TextoIzquierda(r.Cells[2].Value.ToString());
                                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[4].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[5].Value.ToString())); //imprime una linea de descripcion
                            }
                            clsFunciones.CreaTicket.LineasGuion();
                            Ticket1.TextoIzquierda(" ");
                            Ticket1.AgregaTotales("Total", double.Parse(txtTotal.Text)); // imprime linea con total
                            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtPagado.Text));
                            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(txtBalance.Text));
                            Ticket1.TextoIzquierda(" ");
                            clsFunciones.CreaTicket.LineasGuion();
                            Ticket1.TextoCentro("Gracias por visitar Lendy's Restaurant");
                            clsFunciones.CreaTicket.LineasGuion();
                            Ticket1.TextoCentro("");
                            Ticket1.TextoCentro("");
                            Ticket1.TextoCentro("");
                            Ticket1.TextoCentro("");
                            Ticket1.TextoIzquierda(" ");
                            Ticket1.ImprimirTiket(impresora);





                            Fila = 0;
                            while (dataGridView1.RowCount > 0)//limpia el dgv
                            { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
                            //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
                            txtTotal.Text = "";
                            txtPagado.Text = "";
                            txtBalance.Text = "";
                            LoadDatos();
                            txtfact.Focus();
                            btnAgregar.Enabled = true;
                            btnBorrar.Enabled = true;
                            btnCobrar.Enabled = true;
                            btnQuitarPrd.Enabled = true;
                            btnVer.Enabled = true;
                            return;
                        }


                        MessageBox.Show(rs.Mensaje);
                        btnAgregar.Enabled = true;
                        btnBorrar.Enabled = true;
                        btnCobrar.Enabled = true;
                        btnQuitarPrd.Enabled = true;
                        btnVer.Enabled = true;

                    }




                }
                catch (Exception a)
                {

                    MessageBox.Show(a.Message);
                    btnAgregar.Enabled = true;
                    btnBorrar.Enabled = true;
                    btnCobrar.Enabled = true;
                    btnQuitarPrd.Enabled = true;
                    btnVer.Enabled = true;
                    return;
                }

            }
           
        

        }

        private void txtPagado_TextChanged(object sender, EventArgs e)
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

        private void txtfact_TextChanged(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
            btnGuardar.Enabled = false;
            btnQuitarPrd.Enabled = false;
            btnSalir.Enabled = false;
            List<detallesfacturas> detallesfacturas = new List<detallesfacturas>();


            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                detallesfacturas.Add(new detallesfacturas()
                {
                    idfactura = idfact,
                    producto = r.Cells[1].Value.ToString(),
                    precio = float.Parse(r.Cells[4].Value.ToString()),
                    cantidad = r.Cells[3].Value.ToString(),
                    totalpago = float.Parse(r.Cells[5].Value.ToString())
                });

            }


            if (detallesfacturas.Count <= 0)
            {
                MessageBox.Show("Debe Agregar sus Productos");

                btnAgregar.Enabled = true;
                btnBorrar.Enabled = true;
                btnGuardar.Enabled = true;
                btnQuitarPrd.Enabled = true;
                btnSalir.Enabled = true;
                return;
            }


            cobrarfactura model = new cobrarfactura()
            {

                detallesfacturas = detallesfacturas,
                toke_usuario = token,
                idfactura = idfact

            };


            using (HttpClient Client = new HttpClient())
            {
                var serialmodel = JsonConvert.SerializeObject(model);
                var content = new StringContent(serialmodel, Encoding.UTF8, "application/json");
                var result = await Client.PostAsync(_host + "/api/CamareroFacturas", content);
                respuesta_completarJugada rs = JsonConvert.DeserializeObject<respuesta_completarJugada>(await result.Content.ReadAsStringAsync());


                if (rs.Estatus == true)
                {


                    Fila = 0;
                    while (dataGridView1.RowCount > 0)//limpia el dgv
                    { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
                    //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();
                    txtTotal.Text = "";
                    txtPagado.Text = "";
                    txtBalance.Text = "";
                    LoadDatos();
                    txtfact.Focus();
                    btnAgregar.Enabled = true;
                    btnBorrar.Enabled = true;
                    btnCobrar.Enabled = true;
                    btnQuitarPrd.Enabled = true;
                    btnVer.Enabled = true;
                    return;
                }
                else
                {
                    btnAgregar.Enabled = true;
                    btnBorrar.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnQuitarPrd.Enabled = true;
                    btnSalir.Enabled = true;
                    MessageBox.Show(rs.Mensaje);
                    return;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadDatos();
        }
    }
}

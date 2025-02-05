using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace JDcaja
{
    public partial class FacturasCompletadasPage : Form
    {
        public FacturasCompletadasPage()
        {
            InitializeComponent();
        }

        //public string _host = System.Configuration.ConfigurationSettings.AppSettings["host"];
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

        private class respuesta
        {
            public bool Estatus { get; set; }
            public string Mensaje { get; set; }
            public List<Completarfactura> Data { get; set; }
            public List<detallesfacturas> detalle { get; set; }
        }

        private List<detallesfacturas> detalle;

        public void LoadDatos()
        {
            var obj = JsonConvert.SerializeObject(new resumenFacturas()
            {
                token = token,
                ID = ID
            });

            //using (HttpClient Client = new HttpClient())
            //{
            //    var content = new StringContent(obj, Encoding.UTF8, "application/json");
            //    var result = await Client.PostAsync(_host + "/api/FacturasCompletas", content);
            //    respuesta rs = JsonConvert.DeserializeObject<respuesta>(await result.Content.ReadAsStringAsync());
            //    if (rs.Estatus == false)
            //    {
            //        MessageBox.Show(rs.Mensaje);
            //        return;
            //    }

            //    detalle = rs.detalle;
            //    listBox2.Items.Clear();
            //    if (string.IsNullOrEmpty(this.txtfact.Text))
            //    {
            //        foreach (Completarfactura item in rs.Data)
            //        {
            //            listBox2.Items.Add(item: string.Format("{0}- {1}  - {2}-{3}  - Precio= $-{4}- {5}"
            //                                , item.usuario, item.cliente, item.fecha, item.ID, item.totalpago, item.estatus));

            //        }
            //    }
            //    else
            //    {
            //        foreach (Completarfactura item in rs.Data.Where(x => x.usuario.ToLower().Contains(this.txtfact.Text.ToString()) ||
            //                                                        x.cliente.ToLower().Contains(this.txtfact.Text.ToString())))
            //        {
            //            listBox2.Items.Add(item: string.Format("{0}- {1}  - {2} - {3}  - Precio= $-{4}- {5}"
            //                               , item.usuario, item.cliente, item.fecha, item.ID, item.totalpago, item.estatus));
            //        }
            //        //this.Premios = new ObservableCollection<MensajesList>(
            //        //    this.mensajesList.Where(
            //        //        l => l.Titulo.ToLower().Contains(this.Filter.ToLower()) ||
            //        //             l.Comentario.ToLower().Contains(this.Filter.ToLower())));
            //    }

            //}
        }

        private void FacturasCompletadasPage_Load(object sender, EventArgs e)
        {
            LoadDatos();
        }

        private int indexDetalleSelected = -1;
        private string[,] ListaCompra = new string[200, 8];
        private int Fila = 0;
        private int idfact;
        private double total;

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                Fila = 0;
                while (dataGridView1.RowCount > 0)//limpia el dgv
                { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
                //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();

                indexDetalleSelected = listBox2.SelectedIndex;

                if (indexDetalleSelected < 0)
                {
                    MessageBox.Show("Seleccione un Producto");
                    return;
                }

                var data = listBox2.Items[listBox2.SelectedIndex];
                //double Total = 0;
                string[] respuestas = data.ToString().Split(new Char[] { '-' });

                Usuario = respuestas[0];
                idfact = int.Parse(respuestas[3]);
                total = double.Parse(respuestas[5]);
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

                txtfact.Focus();
            }
            catch
            {
            }
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            Fila = 0;
            while (dataGridView1.RowCount > 0)//limpia el dgv
            { dataGridView1.Rows.Remove(dataGridView1.CurrentRow); }
            //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();

            indexDetalleSelected = listBox2.SelectedIndex;

            if (indexDetalleSelected < 0)
            {
                MessageBox.Show("Seleccione un Producto");
                return;
            }

            var data = listBox2.Items[listBox2.SelectedIndex];
            //double Total = 0;
            string[] respuestas = data.ToString().Split(new Char[] { '-' });

            var confirmResult = MessageBox.Show
                (string.Format("Esta segura que desea Reimprimir la factura No. {0}", respuestas[3]),
               "Confirmación?",
               MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }
            Usuario = respuestas[0];
            idfact = int.Parse(respuestas[3]);
            total = double.Parse(respuestas[5]);
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
            Ticket1.AgregaTotales("Total", total); // imprime linea con total
            Ticket1.AgregaTotales("Efectivo Entregado:", total);
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
        }
    }
}
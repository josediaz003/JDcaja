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
using static JDcaja.clsFunciones;

namespace JDcaja
{
    public partial class Pantalla_Reportes : Form
    {
        public Pantalla_Reportes()
        {
            InitializeComponent();
        }
        public string _host = System.Configuration.ConfigurationSettings.AppSettings["host"];
        public string Nombre;
        public string token;
        public int ID;
        public class Reportesfactura
        {
            public DateTime Fechadesde { get; set; }
            public DateTime Fechahasta { get; set; }
            public string Token { get; set; }
        }
        class respuesta_Reportesfactura
        {
            public bool Estatus { get; set; }
            public string Mensaje { get; set; }
            public List<rpt> Data { get; set; }

        }
        class rpt
        {
            
            public DateTime Fecha { get; set; }
            public int factura { get; set; }
            public double precio { get; set; }
            public string cliente { get; set; }
        }
        private List<rpt> detalle;
        public async void procesar_reporteAsync(string obj)
        {
            using (HttpClient Client = new HttpClient())
            {

                var content = new StringContent(obj, Encoding.UTF8, "application/json");
                var result = await Client.PostAsync(_host + "/api/ReporteFacturas", content);
                respuesta_Reportesfactura rs = JsonConvert.DeserializeObject<respuesta_Reportesfactura>(await result.Content.ReadAsStringAsync());
                if (rs.Estatus == false)
                {
                    MessageBox.Show(rs.Mensaje);
                    return;
                }

                double total = 0;
                textBox1.Text = "";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Reporte de venta");
                sb.AppendLine(sp(3) + Nombre + sp(3));
                sb.AppendLine(sp(1) + System.DateTime.Now + sp(1));
                
                sb.AppendLine();
                sb.AppendLine(string.Concat("factura-----", "---Cliente---", "---------Fecha---------", "--------Monto"));

                foreach (rpt item in rs.Data)
                {

                    sb.AppendLine(string.Concat(item.factura, " - ",item.cliente,"-", item.Fecha, " $ ", item.precio));
                    total = total + item.precio;
                }
                sb.AppendLine();
                sb.AppendLine("total: " + total.ToString());
                textBox1.Text = sb.ToString();


                detalle = rs.Data;
                total2 = total;
            }

        }
        double total2 = 0;
        string sp(int n)
        {
            string s = " ";

            for (var i = 0; i <= n; i++)
            {
                s = s + s;
            }
            return s;
        }
        public void ImprimirTiket(string stringimpresora)
        {
        }
       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var obj = JsonConvert.SerializeObject(new Reportesfactura()
            {
                Fechadesde = dateTimePicker1.Value,
                Fechahasta = dateTimePicker2.Value,
                Token = token,
                
            });

            procesar_reporteAsync(obj);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //string impresora = "Generic / Text Only";
            //ImprimirTiket(impresora);

            clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

            Ticket1.TextoCentro(" Lendy's Tropical ");
            Ticket1.TextoCentro("Restaurant y Car Wash ");//imprime una linea de descripcion
            Ticket1.TextoIzquierda("Reporte de Venta");
            Ticket1.TextoIzquierda("Desde:"+dateTimePicker1.Text.ToString());
            Ticket1.TextoIzquierda("Hasta:" + dateTimePicker2.Text.ToString());
            Ticket1.TextoIzquierda("Fecha de Imprecion");
            Ticket1.TextoIzquierda(DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            clsFunciones.CreaTicket.LineasGuion();
            foreach (rpt r in detalle)
            {
                // Articulo                     //Precio                                    cantidad                            Subtotal
                Ticket1.TextoIzquierda(r.cliente);
                Ticket1.TextoIzquierda(r.factura.ToString() +"  "+r.Fecha.ToString()+ "    Total:"+r.precio);
                //Ticket1.AgregaArticulo(r.Cells[0].Value.ToString(), double.Parse(r.Cells[3].Value.ToString()), int.Parse(r.Cells[2].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }
            clsFunciones.CreaTicket.LineasGuion();

            Ticket1.TextoIzquierda("total: " + total2.ToString());
            Ticket1.TextoCentro("");
            Ticket1.TextoCentro("");
            Ticket1.TextoCentro("");
            Ticket1.TextoCentro("");
            Ticket1.TextoCentro("");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Generic / Text Only";
            Ticket1.ImprimirTiket(impresora);

        }

        private void Pantalla_Reportes_Load(object sender, EventArgs e)
        {

        }
    }
}

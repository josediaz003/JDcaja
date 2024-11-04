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
    public partial class Recargas : Form
    {
        public Recargas()
        {
            InitializeComponent();
        }
        public string _host = System.Configuration.ConfigurationSettings.AppSettings["host"];
        public string Nombre;
        public string token;
        public int ID;
        public class postRecargas
        {
            public string Token { get; set; }
            public string Password { get; set; }
            public int idusuarios { get; set; }
            public int idCompaniaRecargas { get; set; }
            public string MontoSolicitado { get; set; }
            public string CodigoTransacion { get; set; }
        }
        public class Response
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
            public object Result { get; set; }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void btnRecargar_Click(object sender, EventArgs e)
        {
            
            if (comboBox1 == null)
            {
                MessageBox.Show("Debe seleccional una Compañia");
                return;
            }
            string compa = comboBox1.Text;
            if (txbNumero.Text == "")
            {
                MessageBox.Show("Debe Digitar el numero de Telefono");
                return;
            }
            if (txbPrecio.Text == "")
            {
                MessageBox.Show("Debe indicar el precio de la Recarga");
                return;
            }
            if (txbClave.Text == "")
            {
                MessageBox.Show(string.Format("Digite la clave del usuario {0}", Nombre));
                return;
            }


            var confirmacion = MessageBox.Show
                                        (string.Format("Esta seguro que desea realizar una Recarga de {0} a el numero {1} con un monto de {2}", comboBox1.Text , txbNumero.Text, txbPrecio.Text),
                                         "Confirmación?",
                                           MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.No)
            {

                txbNumero.Text = "";
                txbPrecio.Text = "";
                txbClave.Text = "";
                return;
            }

            postRecargas postRecargas = new postRecargas
            {
                Token = token,
                Password = txbClave.Text,
                idusuarios = ID,
                idCompaniaRecargas = int.Parse(comboBox1.SelectedValue.ToString()),
                MontoSolicitado = txbPrecio.Text,
                CodigoTransacion = txbNumero.Text
            }; 

            using (HttpClient Client = new HttpClient())
            {
                
                var obj = JsonConvert.SerializeObject(postRecargas);
                var content = new StringContent(obj, Encoding.UTF8, "application/json");
                var result = await Client.PostAsync(_host + "/api/Recargas", content);
                Response rs = JsonConvert.DeserializeObject<Response>(await result.Content.ReadAsStringAsync());

                if (rs.IsSuccess == true)
                {

                    MessageBox.Show(rs.Message);

                    if (rs.Message == "Solicitud completada")
                    {
                        clsFunciones.CreaTicket Ticket1 = new clsFunciones.CreaTicket();

                        Ticket1.TextoCentro(" Lendy's Restaurant ");
                        Ticket1.TextoCentro("Restaurant y Car Wash ");//imprime una linea de descripcion
                        Ticket1.TextoIzquierda("Dirc: Avenida Venezuela");
                        Ticket1.TextoIzquierda("Tel: 809-919-9012");
                        Ticket1.TextoIzquierda("");
                        Ticket1.TextoCentro("Venta de Recarga"); //imprime una linea de descripcion
                        Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                        Ticket1.TextoIzquierda("Cajera: " + Nombre);
                        Ticket1.TextoIzquierda("");
                        clsFunciones.CreaTicket.LineasGuion();
                        clsFunciones.CreaTicket.EncabezadoVenta2();
                        clsFunciones.CreaTicket.EncabezadoVenta();
                        clsFunciones.CreaTicket.LineasGuion();
                        Ticket1.TextoIzquierda("Compañia: "+ compa);
                        Ticket1.TextoIzquierda("Tel: "+ txbNumero.Text);
                        Ticket1.TextoIzquierda("Monto: "+ txbPrecio.Text);
                        clsFunciones.CreaTicket.LineasGuion();
                        Ticket1.TextoIzquierda(" ");
                        Ticket1.TextoCentro("Gracias por visitar Lendy's Restaurant");
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
                            txbNumero.Text = string.Empty;
                            txbPrecio.Text = string.Empty;
                            txbClave.Text = string.Empty;

                            return;
                        }
                        Ticket1.TextoCentro(" Lendy's Restaurant ");
                        Ticket1.TextoCentro("Restaurant y Car Wash ");//imprime una linea de descripcion
                        Ticket1.TextoIzquierda("Dirc: Avenida Venezuela");
                        Ticket1.TextoIzquierda("Tel: 809-919-9012");
                        Ticket1.TextoIzquierda("");
                        Ticket1.TextoCentro("Copia Venta de Recarga"); //imprime una linea de descripcion
                        Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                        Ticket1.TextoIzquierda("Cajera: " + Nombre);
                        Ticket1.TextoIzquierda("");
                        clsFunciones.CreaTicket.LineasGuion();
                        clsFunciones.CreaTicket.EncabezadoVenta2();
                        clsFunciones.CreaTicket.EncabezadoVenta();
                        clsFunciones.CreaTicket.LineasGuion();
                        Ticket1.TextoIzquierda("Compañia: " + compa);
                        Ticket1.TextoIzquierda("Telefono: " + txbNumero.Text);
                        Ticket1.TextoIzquierda("Monto: " + txbPrecio.Text);
                        clsFunciones.CreaTicket.LineasGuion();
                        Ticket1.TextoIzquierda(" ");
                        Ticket1.TextoCentro("Gracias por visitar Lendy's Tropical");
                        Ticket1.TextoCentro("");
                        Ticket1.TextoCentro("");
                        Ticket1.TextoCentro("");
                        Ticket1.TextoCentro("");
                        Ticket1.TextoIzquierda(" ");
                        Ticket1.ImprimirTiket(impresora);

                    }

                    txbNumero.Text = string.Empty;
                    txbPrecio.Text = string.Empty;
                    txbClave.Text = string.Empty;
                    return;

                }
                else
                {
                    MessageBox.Show(rs.Message);


                    txbNumero.Text = string.Empty;
                    txbPrecio.Text = string.Empty;
                    txbClave.Text = string.Empty;
                    return;

                }
            }
        }

        private void Recargas_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            var items = new[] {
                new { Text = "BalanceApp", Value = "1" },
                new { Text = "Claro", Value = "4" },
                new { Text = "Altice", Value = "5" },
                new { Text = "Tricom", Value = "6" },
                new { Text = "Viva", Value = "7" },
                new { Text = "Moun", Value = "8" },
                new { Text = "DigiCel", Value = "9" }
                
                };

            comboBox1.DataSource = items;
        }
    }
}

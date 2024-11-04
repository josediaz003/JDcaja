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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        public string _host = System.Configuration.ConfigurationSettings.AppSettings["host"];
        public string Nombre;
        public string token;
        public int ID;
        public Ventas Ventas;
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

                        listBox1.Items.Add(item: string.Format("{0} - {1}  - {2}  - Precio= $-{3}"
                                            ,item.categoria, item.codigo, item.nombre, item.precio));
                       
                    }
                }
                else
                {
                    foreach (resumenProductos item in rs.Data.Where(x=> x.codigo.ToLower().Contains(this.txtprod.Text.ToString()) ||
                                                                    x.nombre.ToLower().Contains(this.txtprod.Text.ToString())))
                    {
                        listBox1.Items.Add(item: string.Format(" {0}  - {1}  - Precio= $-{2}", item.codigo, item.nombre, item.precio));

                    }
                    //this.Premios = new ObservableCollection<MensajesList>(
                    //    this.mensajesList.Where(
                    //        l => l.Titulo.ToLower().Contains(this.Filter.ToLower()) ||
                    //             l.Comentario.ToLower().Contains(this.Filter.ToLower())));
                }

                
              



            }

        }
        private void Productos_Load(object sender, EventArgs e)
        {
            loadjugada();
        }

        private void txtprod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            loadjugada();
        }
        private int indexDetalleSelected = -1;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            indexDetalleSelected = listBox1.SelectedIndex;

            if (indexDetalleSelected < 0)
            {
                MessageBox.Show("Seleccione una jugada anteriro");
                return;
            }
            var data = listBox1.Items[listBox1.SelectedIndex];

            string[] respuestas = data.ToString().Split(new Char[] { '-' });
            if (respuestas[0] != "")
            {
                this.Hide();
                Ventas ventas = new Ventas();
                ventas.Nombre = Nombre;
                ventas.token = token;
                ventas.ID = ID;
                //ventas.Ventas_Load();
                ventas.Show();
            }
            
        }
    }
}

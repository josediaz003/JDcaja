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
    public partial class Agregar_Productos : Form
    {
        public Agregar_Productos()
        {
            InitializeComponent();
        }

        public string _host = System.Configuration.ConfigurationSettings.AppSettings["host"];
        public string Nombre;
        public string token;
        public int ID;
        public Pantalla_Factura agregar;



        public string idfactura;
        public string produto;
        public string cantidad;
        public string precio;


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
        public async void cargarProductos()
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

                        listBox1.Items.Add(item: string.Format("{0} -{1}-{2}- Precio= $-{3}"
                                            , item.categoria, item.codigo, item.nombre, item.precio));

                    }
                }
                else
                {
                    foreach (resumenProductos item in rs.Data.Where(x => x.codigo.ToLower().Contains(this.txtprod.Text.ToString()) ||
                                                                    x.nombre.ToLower().Contains(this.txtprod.Text.ToString())))
                    {
                        listBox1.Items.Add(item: string.Format("{0} -{1}-{2}- Precio= $-{3}"
                                            , item.categoria, item.codigo, item.nombre, item.precio));

                    }

                }

            }

        }

        private void Agregar_Productos_Load(object sender, EventArgs e)
        {
            cargarProductos();
            txtCantidad.Text = "1";
        }

        private void txtprod_TextChanged(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void CostoApagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Pantalla_Factura factura = new Pantalla_Factura();

            Conteo = factura.dataGridView1.RowCount; // se cuenta los productos y se utilisa el conteo como limite del for
            for (int i = 0; i < Conteo; i++)
            {

                CostoTotal += float.Parse(factura.dataGridView1.Rows[i].Cells[3].Value.ToString());



            }

            factura.txtTotal.Text = CostoTotal.ToString();



        }


        private int indexDetalleSelected = -1;
        string[,] ListaCompra = new string[200, 8];
        int Fila = 0;
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //this.Hide();
            //Pantalla_Factura pantalla_ = new Pantalla_Factura();
            //pantalla_.codigo = "hola";

            try
            {
                this.Hide();
                indexDetalleSelected = listBox1.SelectedIndex;

                if (indexDetalleSelected < 0)
                {
                    MessageBox.Show("Seleccione un Producto");
                    return;
                }

                if (int.Parse(txtCantidad.Text) < 0)
                {
                    MessageBox.Show("Debe Digitar la cantidad");
                    return;

                }

                var data = listBox1.Items[listBox1.SelectedIndex];
                double Total = 0;
                string[] respuestas = data.ToString().Split(new Char[] { '-' });
                if (respuestas[0] == "")
                {
                    MessageBox.Show("Debe Digitar la cantidad");
                    return;
                    //Total = (double.Parse(respuestas[4]) * double.Parse(txtCantidad.Text));
                    //listBox1.Items.Add(item: respuestas[2] + "  -  " + respuestas[4] + "  -  " + txtCantidad.Text + "  -  " + Total);

                }
                if (txtCantidad.Text == "")
                {
                    MessageBox.Show("Debe Digitar la cantidad");
                    return;

                }


                //Pantalla_Factura pantalla_ = new Pantalla_Factura();
                ListaCompra[Fila, 0] = respuestas[1];
                ListaCompra[Fila, 1] = respuestas[4];
                ListaCompra[Fila, 2] = txtCantidad.Text;
                ListaCompra[Fila, 3] = (float.Parse(txtCantidad.Text) * float.Parse(respuestas[4])).ToString();
                ListaCompra[Fila, 4] = idfactura;
                ListaCompra[Fila, 5] = respuestas[2];



                agregar.dataGridView1.Rows.Add(ListaCompra[Fila, 4], ListaCompra[Fila, 0], ListaCompra[Fila, 5], ListaCompra[Fila, 2], ListaCompra[Fila, 1], ListaCompra[Fila, 3]);
                Fila++;// se le agrega uno a la fila para futuras generaciones jejeje

            }
            catch
            {

            }

            //CostoApagar();
            this.Close();


            //ttotal();


            //string j =  txtProducto.Text + " - " + txtPrecio.Text + " - " + txtCantidad.Text +" - " + Total;







        }








    }
    
}

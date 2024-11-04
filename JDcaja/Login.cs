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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string _host = System.Configuration.ConfigurationSettings.AppSettings["host"];

        public class UsuarioLogin
        {
            public string usuario { get; set; }
            public string password { get; set; }
        }

        public class responseLgin
        {
            public int ID { get; set; }
            public string user_token { get; set; }
            public string Nombre { get; set; }
            public bool Estatus { get; set; }
            public string Mensaje { get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Boolean validImput(Boolean go = true)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Focus();
                return false;
            }
            if (txtpassword.Text == "")
            {
                txtpassword.Focus();
                return false;
            }
            if (go == true)
            {
                button1_Click(this, new EventArgs());
            }
            return true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (validImput(false) == false)
            {
                return;
            }
            btninicial.Text = "Espere...";
            btninicial.Enabled = false;
            btnsalir.Enabled = false;
            if (txtusuario.Text == "Buenaventura" && txtpassword.Text == "1234")
            {
                this.Hide();
                Ventas ventas = new Ventas();
                ventas.Nombre = "Buenaventura Sanchez";
                //pantalla_Principal.token = rs.user_token;
                //pantalla_Principal.ID = rs.ID;
                ventas.Show();
            }
            else
            {
                MessageBox.Show("El nombre de usuario y/o la clave es Invalido");
                btninicial.Text = "Inicial";
                btninicial.Enabled = true;
                btnsalir.Enabled = true;
            }
            //this.Hide();
            //Pantalla_Principal pantalla_Principal = new Pantalla_Principal();
            //pantalla_Principal.Nombre = rs.Nombre;
            //pantalla_Principal.token = rs.user_token;
            //pantalla_Principal.ID = rs.ID;
            //pantalla_Principal.Show();
            //UsuarioLogin login = new UsuarioLogin()
            //{
            //    usuario = txtusuario.Text,
            //    password = txtpassword.Text
            //};
            //using (HttpClient Client = new HttpClient())
            //{
            //    var serialLogin = JsonConvert.SerializeObject(login);
            //    var content = new StringContent(serialLogin, Encoding.UTF8, "application/json");
            //    var result = await Client.PostAsync(_host + "/api/LoginPC", content);
            //    responseLgin rs = JsonConvert.DeserializeObject<responseLgin>(await result.Content.ReadAsStringAsync());

            //    if (rs.Estatus == true)
            //    {
            //        this.Hide();
            //        Pantalla_Principal pantalla_Principal = new Pantalla_Principal();
            //        pantalla_Principal.Nombre = rs.Nombre;
            //        pantalla_Principal.token = rs.user_token;
            //        pantalla_Principal.ID = rs.ID;
            //        pantalla_Principal.Show();

            //    }
            //    else
            //    {
            //        MessageBox.Show(rs.Mensaje);
            //    }
            //    txtpassword.Text = "";
            //    txtusuario.Text = "";
            //    btninicial.Text = "Entrar";
            //    btninicial.Enabled = true;
            //    btnsalir.Enabled = true;
            //    txtusuario.Focus();

            //}
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtusuario.Focus();
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validImput();
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validImput();
            }
        }
    }
}
using CapaEntidad;
using CapaNegocio;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace JDcaja
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //public string _host = System.Configuration.ConfigurationSettings.AppSettings["host"];

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (validImput(false) == false)
            {
                return;
            }

            Usuario ousuario = new CN_Usuario().Listar().Where(u => u.Documento == txtusuario.Text && u.Clave == txtpassword.Text).FirstOrDefault();

            if (ousuario != null)
            {
                this.Hide();
                Menu form = new Menu(ousuario);
                form.Show();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("El nombre de usuario y/o la clave es Invalido");
                txtusuario.Text = "";
                txtpassword.Text = "";
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtpassword.Text = "";
            Show();
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

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
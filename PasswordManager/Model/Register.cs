using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using PasswordManager.Model;

namespace PasswordManager
{
    public partial class Register : Form
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017");
        static IMongoDatabase db = client.GetDatabase("PasswordHashing");
        static IMongoCollection<User> collection = db.GetCollection<User>("Users");
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(txtEmail.Text, txtUser0.Text, txtPassword0.Text);
            collection.InsertOneAsync(user);
            MessageBox.Show("Registro exitoso");

            Login login = new Login();
            // Mostrar el formulario
            login.Show();
  
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtUser0_Enter(object sender, EventArgs e)
        {
            if (txtUser0.Text == "Usuario")
            {
                txtUser0.Text = "";
                txtUser0.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword0_Enter(object sender, EventArgs e)
        {
            if (txtPassword0.Text == "Contraseña")
            {
                txtPassword0.Text = "";
                txtPassword0.ForeColor = Color.LightGray;
            }
        }

        
    }
}

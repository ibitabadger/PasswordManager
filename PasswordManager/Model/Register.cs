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
using PasswordManager.Controller;
using PasswordManager.Model;

namespace PasswordManager
{
    public partial class Register : Form
    {
        private readonly IMongoCollection<User> collection;
        public Register(Login loginForm)
        {
            InitializeComponent();
            this.Select();
            collection = MongoDBContext.GetCollection();

        }

        private bool findUser(string username)
        {
            var filter = Builders<User>.Filter.Eq("Username", username);
            var result = collection.Find(filter).ToList();
            bool userExists = result.Count != 0;
            return userExists;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool emailCondition = txtEmail.Text.Contains("@")&&txtEmail.Text.Contains(".com");
            bool userCondition = txtUser0.Text.Length > 0;
            bool passwordCondition = txtPassword0.Text.Length > 0;
            bool userExist = findUser(txtUser0.Text);
            bool condition = emailCondition && userCondition && !userExist && passwordCondition;
            if(!condition)
            {
                if(!emailCondition)
                {
                    MessageBox.Show("El email no existe");
                }
                else if(!userCondition || !passwordCondition){
                    MessageBox.Show("Hay campos vacíos");
                }
                else if(userExist)
                {
                    MessageBox.Show("El usuario ya existe");
                }
            }
            else
            {
                PasswordHasher hasher = new PasswordHasher();
                string encryptedPassword = hasher.Hash(txtPassword0.Text);
                User user = new User(txtEmail.Text, txtUser0.Text, encryptedPassword);
                collection.InsertOneAsync(user);
                MessageBox.Show("Registro exitoso");

                Login login = new Login();
                // Mostrar el formulario
                this.Close();
            }
            

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

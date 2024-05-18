using MongoDB.Driver;
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
    public partial class Login : Form
    {
        static MongoClient client = new MongoClient("mongodb://localhost:27017");
        static IMongoDatabase db = client.GetDatabase("PasswordHashing");
        static IMongoCollection<User> collection = db.GetCollection<User>("Users");

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register(this);
            register.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private List<string> takeLoginInfo()
        {
            List<string> list = new List<string>();
            if (!(txtUser.Text.Trim() == "") || !(txtPassword.Text.Trim() == ""))
            {
                list.Add(txtUser.Text);
                list.Add(txtPassword.Text);
                return list;
            }
            return list;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<string> loginInfo = takeLoginInfo();
            if (loginInfo.Count == 0)
            {
                string message = "Las credenciales no son correctas";
                MessageBox.Show(message);
            }
            else
            {
                var userFinded = collection.Find(user => (user.Username == loginInfo[0]) && (user.Password == loginInfo[1])).FirstOrDefault();
                if (userFinded != null)
                {
                    Home homeForm = new Home(this);
                    homeForm.ShowDialog();
                }
                else
                {
                    string message = "Las credenciales no son correctas";
                    MessageBox.Show(message);
                }

            }
            
        }
    }
}

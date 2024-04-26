using PasswordManager.Controller;
using PasswordManager.Model;
using System.Collections;
using System.Drawing.Text;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json;

namespace AddAccount
{
    public partial class newAccountForm : Form
    {
        private HashTable1 hashtable;


        public newAccountForm(HashTable1 hashtable)
        {
            InitializeComponent();
            this.hashtable = hashtable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ultimoId = 1;


            string webSite = textBox1.Text;
            string userName = textBox2.Text;
            string password = textBox3.Text;

            string key = "1234567891234567";
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            AESManager aesManager = new AESManager(bytes);
            byte[] encryptedData = aesManager.Encrypt(password);

            hashtable.Insert(webSite, encryptedData);

            Account account = new Account(ultimoId, webSite, userName, encryptedData);
            

            ultimoId++;

            string json = JsonSerializer.Serialize(account, new JsonSerializerOptions { WriteIndented = true });

           
            string path = @"..\..\..\Model\accounts.json";
            File.WriteAllText(path, json);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

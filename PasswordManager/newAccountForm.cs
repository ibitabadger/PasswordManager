using Newtonsoft.Json.Linq;
using PasswordManager;
using PasswordManager.Controller;
using PasswordManager.Model;
using System.Collections;
using System.Drawing.Text;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using static PasswordManager.Model.HashTable1;

namespace AddAccount
{
    public partial class newAccountForm : Form
    {
        private HashTable1 hashtable;
        public delegate void DataAddedEventHandler();
        public event DataAddedEventHandler DataAddedEvent;


        public newAccountForm(HashTable1 hashtable)
        {
            InitializeComponent();
            this.hashtable = hashtable;
            centerForm(this);


        }

        private void centerForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string webSite = textBox1.Text;
            string userName = textBox2.Text;
            string password = textBox3.Text;

            string key = "1234567891234567";
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            AESManager aesManager = new AESManager(bytes);
            byte[] encryptedData = aesManager.Encrypt(password);

            Account account = new Account(userName, encryptedData);

            hashtable.Insert(webSite, account);

            List<KeyValuePair<string, Account>>[] tableList = hashtable.GetTable();

            string json = JsonSerializer.Serialize(tableList, new JsonSerializerOptions { WriteIndented = true });

            string path = @"..\..\..\Model\accounts.json";
            File.WriteAllText(path, json);

            DataAddedEvent?.Invoke();

            
            this.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}

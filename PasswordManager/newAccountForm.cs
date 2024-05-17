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
            setWindowSize(this, 315, 377);
            textBoxWeb.RoundedCorners(10);
            textBoxUser.RoundedCorners(10);
            textBoxPassword.RoundedCorners(10);
            buttonAddAccount.RoundedCorners(10);
        }

        private void centerForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        private void setWindowSize(Form form, int width, int height)
        {
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = true;
            form.Size = new Size(width, height);
            form.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string webSite = textBoxWeb.Text;
            string userName = textBoxUser.Text;
            string password = textBoxPassword.Text;

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

            textBoxWeb.Text = "";
            textBoxUser.Text = "";
            textBoxPassword.Text = "";

            this.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void newAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxWeb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Driver;
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
using User = PasswordManager.Model.User;

namespace AddAccount
{
    public partial class newAccountForm : Form
    {
        private readonly IMongoCollection<User> collection;
        private HashTable1 hashtable;
        public delegate void DataAddedEventHandler();
        public event DataAddedEventHandler DataAddedEvent;
        private User user;



        public newAccountForm(HashTable1 hashtable, User user)
        {
            InitializeComponent();
            collection = MongoDBContext.GetCollection();
            this.hashtable = hashtable;
            this.user = user;
            InitializeFormAppearance();
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

            EncryptAndSaveData(webSite, userName, password);
            CloseForm();
        }

        private void EncryptAndSaveData(string webSite, string userName, string password)
        {
            AESManager aesManager = new AESManager(user.Key);
            byte[] encryptedData = aesManager.Encrypt(password);

            Account account = new Account(userName, encryptedData);
            hashtable.Insert(webSite, account);

            UpdateUserJsonData();
            NotifyDataAdded();
        }
        private void UpdateUserJsonData()
        {
            var tableList = hashtable.GetTable();
            string json = JsonSerializer.Serialize(tableList, new JsonSerializerOptions { WriteIndented = true });

            var update = Builders<User>.Update.Set(u => u.DataJson, json);
            collection.UpdateOneAsync(u => u.Id == user.Id, update);
        }

        private void NotifyDataAdded()
        {
            DataAddedEvent?.Invoke();
        }

        private void CloseForm()
        {
            textBoxWeb.Text = "";
            textBoxUser.Text = "";
            textBoxPassword.Text = "";
            Close();
        }

        private void InitializeFormAppearance()
        {
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = true;
            Size = new Size(315, 377);
            BackColor = Color.FromArgb(36, 36, 36);

            textBoxWeb.RoundedCorners(10);
            textBoxUser.RoundedCorners(10);
            textBoxPassword.RoundedCorners(10);
            buttonAddAccount.RoundedCorners(10);
        }

        private void newAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}

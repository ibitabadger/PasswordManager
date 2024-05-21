using MongoDB.Driver;
using PasswordManager.Controller;
using PasswordManager.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Edit : Form
    {

        private HashTable1 hashTable;
        private string index;
        public delegate void DataAddedEventHandler();
        public event DataAddedEventHandler DataAddedEvent;
        private User usuario;

        private readonly IMongoCollection<User> collection;

        public Edit(string index, HashTable1 hashTable, User usuario)
        {
            InitializeComponent();
            collection = MongoDBContext.GetCollection();
            this.hashTable = hashTable;
            this.index = index;
            this.usuario = usuario;
            centerForm(this);
            setWindowSize(this, 315, 377);
        }

        private void centerForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        private void setWindowSize(Form form, int width, int height)
        {
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Size = new Size(width, height);
            form.BackColor = Color.FromArgb(36, 36, 36);
            form.Select();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            Account userData = loadData();
            textBoxWeb.Text = index;
            textBoxWeb.ReadOnly = true;
            textBoxUser.Text = userData.Username;
            textBoxUser.ReadOnly = true;
            textBoxPassword.Text = decrypt(userData);
        }

        public string decrypt(Account userData)
        {
            
            AESManager aesManager = new AESManager(usuario.Key);
            string decryptedData = aesManager.Decrypt(userData.Password);

            return decryptedData;
        }

        private byte[] encrypt(string password)
        {
            
            AESManager aesManager = new AESManager(usuario.Key);
            byte[] encryptedData = aesManager.Encrypt(password);

            return encryptedData;
        }

        public Account editAccount(Account userData, string password)
        {
            byte[] encryptedPassword = encrypt(password);
            Account newUserData = new Account(userData.Username, encryptedPassword);

            return newUserData;
        }

        public void savePassword(string index) {
            string newPassword = textBoxPassword.Text;
            Account userData = loadData();
            Account newUserData = editAccount(userData, newPassword);

            hashTable.Insert(index, newUserData);
        }

        private void Btn_Save_CLick(object sender, EventArgs e)
        {
            savePassword(index);
            reWrite();

            DataAddedEvent?.Invoke();

            this.Close();
        }

        private void reWrite()
        {
            List<KeyValuePair<string, Account>>[] tableList = hashTable.GetTable();

            string json = JsonSerializer.Serialize(tableList, new JsonSerializerOptions { WriteIndented = true });

            var update = Builders<User>.Update.Set(u => u.DataJson, json);

            collection.UpdateOneAsync(u => u.Id == usuario.Id, update);
        }

        private Account loadData()
        {
            Account userData = hashTable.Search(index);

            return userData; 
        }

    }
}

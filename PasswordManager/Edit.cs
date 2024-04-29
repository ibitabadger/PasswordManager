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

        public Edit(string index, HashTable1 hashTable)
        {
            this.hashTable = hashTable;
            this.index = index;
            InitializeComponent();
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
            string key = "1234567891234567";
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            AESManager aesManager = new AESManager(bytes);
            string decryptedData = aesManager.Decrypt(userData.Password);

            return decryptedData;
        }

        private byte[] encrypt(string password)
        {
            string key = "1234567891234567";
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            AESManager aesManager = new AESManager(bytes);
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

            string path = @"..\..\..\Model\accounts.json";
            File.WriteAllText(path, json);

        }

        private Account loadData()
        {
            Account userData = hashTable.Search(index);

            return userData; 
        }

    }
}

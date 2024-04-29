using AddAccount;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PasswordManager.Controller;
using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PasswordManager
{
    public partial class Home : Form
    {
        newAccountForm AccountForm;
        HashTable1 hashtable = new HashTable1(10);


        public Home()
        {
            
            InitializeComponent();
            setWindowSize(this, 850, 600);
            loadTable(hashtable);
            AccountForm = new newAccountForm(hashtable);
            centerForm(this);
            this.BackColor = Color.Black;
        }
        private void Form2_DataAddedEvent()
        {
            clearForm(this);
            this.Select();
            Panel mainPanel = addScrollToForm(this);
            loadWindow(mainPanel, hashtable);
            createButton("Add Account", 12, 35, 10, 150, 30, mainPanel, Button_Click);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            clearForm(this);
            this.Select();
            Panel mainPanel = addScrollToForm(this);
            loadWindow(mainPanel, hashtable);
            createButton("Add Account", 12, 35, 10, 150, 30, mainPanel, Button_Click);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            AccountForm.DataAddedEvent += Form2_DataAddedEvent;
            AccountForm.ShowDialog();
        }

        //ADD COMPONENTS TO FORM
        private Panel createPanel(int posX, int posY, Panel mainPanel)
        {
            Panel panel = new Panel();
            panel.Size = new Size(170, 197);
            panel.Location = new Point(posX, posY);
            panel.BackColor = Color.FromArgb(45, 45, 45);
            panel.RoundedCorners(10);
            mainPanel.Controls.Add(panel);

            return panel;
        }

        private void createLabel(string text, int fontSize, int posX, int posY, Panel container)
        {
            Label label = new Label();
            label.Text = text;
            label.Font = new Font("Arial", fontSize);
            label.ForeColor = Color.FromArgb(255, 255, 255);
            label.Location = new Point(posX, posY);
            label.AutoSize = true;
            container.Controls.Add(label);
        }

        private void createLabel(string text, int fontSize, int posX, int posY, int width, int height
            , Panel container)
        {
            Label label = new Label();
            label.Text = text;
            label.Font = new Font("Arial", fontSize);
            label.ForeColor = Color.FromArgb(255, 255, 255);
            label.Location = new Point(posX, posY);
            label.Size = new Size(width, height);
            label.TextAlign = ContentAlignment.MiddleCenter;
            container.Controls.Add(label);
        }

        private void createTextBox(string text, int fontSize, int posX, int posY, int width, int height,
            bool isEnabled, Panel container)
        {
            TextBox textBox = new TextBox();
            textBox.Size = new Size(width, height);
            textBox.Text = text;
            textBox.Font = new Font("Arial", fontSize);
            textBox.BackColor = Color.White;
            textBox.ReadOnly = isEnabled;
            textBox.Enabled = isEnabled;
            textBox.Location = new Point(posX, posY + 16);
            textBox.RoundedCorners(10);
            container.Controls.Add(textBox);
        }

        private void createButton(string text, int fontSize, int posX, int posY, int width, int height, Panel container, EventHandler clickEvent)
        {
            Button button = new Button();
            button.Text = text;
            button.Font = new Font("Arial", fontSize);
            button.BackColor = Color.Teal;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Popup;
            button.Location = new Point(posX, posY);
            button.Size = new Size(width, height);
            button.Click += clickEvent; // Asigna el evento de clic que deseas manejar
            button.RoundedCorners(10);
            container.Controls.Add(button);
        }

        //UTILITIES

        private void centerForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        private void clearForm(Form form)
        {
            while (form.Controls.Count > 0)
            {
                form.Controls[0].Dispose();
            }
        }

        private Panel addScrollToForm(Form form)
        {
            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(36, 36, 36);
            panel.Dock = DockStyle.Fill;
            panel.AutoScroll = true;
            form.Controls.Add(panel);

            return panel;
        }

        private void setWindowSize(Form form, int width, int height)
        {
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.MaximizeBox = false;
            form.Size = new Size(width, height);
        }

        private void loadTable(HashTable1 hashtable)
        {
            string path = @"..\..\..\Model\accounts.json";
            try
            {
                string json = File.ReadAllText(path);

                List<KeyValuePair<string, Account>>[] loadedTable = JsonConvert.DeserializeObject<List<KeyValuePair<string, Account>>[]>(json);

                List<KeyValuePair<string, Account>>[] table = hashtable.GetTable();
                
                foreach (var bucket in loadedTable)
                {
                    if (bucket != null)
                    {
                        foreach (var kvp in bucket)
                        {
                            string key = kvp.Key;
                            Account account = kvp.Value;

                            // Insertar en tu tabla hash
                            int hash = hashtable.Hash(key);
                            if (table[hash] == null)
                            {
                                table[hash] = new List<KeyValuePair<string, Account>>();
                            }
                            table[hash].Add(new KeyValuePair<string, Account>(key, account));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo JSON: {ex.Message}");
            }
        }


        //LOAD WINDOW
        private void loadWindow(Panel mainPanel, HashTable1 hashtable)
        {
            List<KeyValuePair<string, Account>>[] table = hashtable.GetTable();

            int yPosPanel = 42;
            int xPosPanel = 37;
            int spaceBetweenPanels = 192;
            int yPosLabel = 67;
            int xPosLabel = 16;
            int contElementRow = 0;

            foreach (List<KeyValuePair<string, Account>> bucket in table)
            {
                if (bucket != null)
                {
                    foreach (KeyValuePair<string, Account> kvp in bucket)
                    {
                        string url = kvp.Key;
                        string username = kvp.Value.Username;
                        byte[] password = kvp.Value.Password;

                        // Decrypt the password directly from the hashtable
                        string key = "1234567891234567";
                        byte[] bytes = Encoding.UTF8.GetBytes(key);
                        AESManager aesManager = new AESManager(bytes);
                        string decryptedData = aesManager.Decrypt(password);

                        Panel panel = createPanel(xPosPanel, yPosPanel, mainPanel);

                        int panelWidth = panel.Width;

                        createLabel(url, 15, 0, 34, panelWidth, 24, panel);

                        createLabel("User", 8, xPosLabel, yPosLabel, panel);
                        createTextBox(username, 8, xPosLabel, yPosLabel, 132, 20, true, panel);

                        createLabel("Password", 8, xPosLabel, yPosLabel + 49, panel);
                        createTextBox(decryptedData, 8, xPosLabel, yPosLabel + 49, 132, 20, true, panel);

                        contElementRow++;
                        xPosPanel += spaceBetweenPanels;

                        if (contElementRow == 4)
                        {
                            yPosPanel += 220;
                            xPosPanel = 37;
                            contElementRow = 0;
                        }

                        
                    }
                }
            }
        }
    }
}


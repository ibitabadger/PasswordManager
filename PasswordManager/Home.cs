using AddAccount;
using PasswordManager.Model;
using System.Collections;


namespace PasswordManager
{
    public partial class Home : Form
    {
        newAccountForm AccountForm;

        public Home()
        {
            InitializeComponent();
            
            HashTable1 hashtable = new HashTable1(40);
            AccountForm = new newAccountForm(hashtable);

        }


        



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AccountForm.ShowDialog();
        }
    }
}

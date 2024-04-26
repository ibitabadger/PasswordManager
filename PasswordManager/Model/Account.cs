using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model
{
    public class Account {
    
        private int id;
        private string website;
        private string username;
        private byte[] password;

        public Account(int id, string website, string username, byte[] password)
        {
            this.id = id ;
            this.website = website;
            this.username = username;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Website { get => website; set => website = value; }
        public string Username { get => username; set => username = value; }
        public byte[] Password { get => password; set => password = value; }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model
{
    public class Account {
    
        
        
        private string username;
        private byte[] password;

        public Account( string username, byte[] password)
        {
            
            this.username = username;
            this.password = password;
        }
        public string Username { get => username; set => username = value; }
        public byte[] Password { get => password; set => password = value; }
    }
    
}

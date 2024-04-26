using AddAccount.Controller;
using System;
using System.Security.Cryptography;
using System.Text;




namespace PasswordManager.Controller
{
    public class PasswordHasher : IPasswordHasher
    {

        public string Hash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public bool Verify(string password, string hashedPassword)
        {
            string hashOfInput = Hash(password);
            return string.Equals(hashOfInput, hashedPassword);
        }
    }
}
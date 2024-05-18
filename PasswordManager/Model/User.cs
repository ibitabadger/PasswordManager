using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model
{
    class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("username")]
        public string Username { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("key")]
        public byte[] Key { get; set; }



        public User(string email,string username, string password)
        {
            Username = username;
            Password = password;
            Email = email;
            Key = GenerateRandomKey();
        }


        private static byte[] GenerateRandomKey()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] stringChars = new char[16];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string randomString = new string(stringChars);
            return Encoding.UTF8.GetBytes(randomString);
        }
    }
}

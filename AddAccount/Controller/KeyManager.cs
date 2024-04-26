using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Controller
{
    public class KeyManager
    {
        private byte[] encryptionKey;

        public KeyManager()
        {
            encryptionKey = LoadOrGenerateKey();
        }

        private byte[] LoadOrGenerateKey()
        {
            byte[] key = GetStoredKey();

            if (key == null || key.Length == 0)
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.GenerateKey();
                    key = aesAlg.Key;
                    StoreKey(key);
                }
            }

            return key;
        }

        public byte[] GetKey()
        {
            return encryptionKey;
        }

        private byte[] GetStoredKey()
        {
            // Load the key 
            throw new NotImplementedException();
        }

        private void StoreKey(byte[] key)
        {
            // Store the key 
            throw new NotImplementedException();
        }
    }



}
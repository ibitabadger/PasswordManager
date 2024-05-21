using System;
using TechTalk.SpecFlow;
using PasswordManager.Model;
using PasswordManager.Controller;
using NUnit.Framework;

namespace PasswordManager.Tests
{
    [Binding]
    public class HashTableSteps
    {
        private HashTable1 hashTable;
        private Account account;
        private Account retrievedAccount;
        private AESManager aesManager;
        private User user;

        [Given(@"una tabla hash de tamaño (.*)")]
        public void GivenHashTable(int size)
        {
            hashTable = new HashTable1(size);
        }

        [Given(@"un usuario con email ""(.*)"", nombre de usuario ""(.*)"" y contraseña ""(.*)""")]
        public void GivenUser(string email, string username, string password)
        {
            user = new User(email, username, password);
            aesManager = new AESManager(user.Key);
        }

        [Given(@"una cuenta con sitio web ""(.*)"", nombre de usuario ""(.*)"" y contraseña ""(.*)""")]
        public void GivenAccount(string site, string username, string password)
        {
            byte[] encryptedPassword = aesManager.Encrypt(password);
            account = new Account(username, encryptedPassword);
        }

        [Given(@"una cuenta con sitio web ""(.*)"", nombre de usuario ""(.*)"" y contraseña ""(.*)"" indexada")]
        public void GivenIndexedAccount(string site, string username, string password)
        {
            byte[] encryptedPassword = aesManager.Encrypt(password);
            var indexedAccount = new Account(username, encryptedPassword);
            hashTable.Insert(site, indexedAccount);
        }

        [When(@"se inserta la cuenta con sitio web ""(.*)"" en la tabla hash")]
        public void WhenInsertAccount(string site)
        {
            hashTable.Insert(site, account);
        }

        [When(@"se busca la cuenta con sitio web ""(.*)"" en la tabla hash")]
        public void WhenSearchAccount(string site)
        {
            retrievedAccount = hashTable.Search(site);
        }

        [When(@"se elimina la cuenta con sitio web ""(.*)"" de la tabla hash")]
        public void WhenDeleteAccount(string site)
        {
            hashTable.Delete(site);
        }

        [When(@"se actualiza la cuenta con sitio web ""(.*)"" con nombre de usuario ""(.*)"" y contraseña ""(.*)""")]
        public void WhenUpdateAccount(string site, string username, string password)
        {
            byte[] encryptedPassword = aesManager.Encrypt(password);
            var updatedAccount = new Account(username, encryptedPassword);
            hashTable.Insert(site, updatedAccount);
        }

        [Then(@"la cuenta con sitio web ""(.*)"" debe estar indexada en la tabla hash")]
        public void ThenAccountIndexed(string site)
        {
            var retrieved = hashTable.Search(site);
            Assert.IsNotNull(retrieved, $"La cuenta con sitio web {site} no está indexada en la tabla hash.");
        }

        [Then(@"la cuenta con sitio web ""(.*)"" debe ser gestionada correctamente en la tabla hash")]
        public void ThenAccountManaged(string site)
        {
            var retrieved = hashTable.Search(site);
            Assert.IsNotNull(retrieved, $"La cuenta con sitio web {site} no fue gestionada correctamente en la tabla hash.");
        }

        [Then(@"la cuenta con sitio web ""(.*)"" debe ser recuperada con nombre de usuario ""(.*)"" y contraseña ""(.*)""")]
        public void ThenAccountRetrieved(string site, string username, string password)
        {
            Assert.IsNotNull(retrievedAccount, $"La cuenta con sitio web {site} no fue encontrada.");
            Assert.AreEqual(username, retrievedAccount.Username, "El nombre de usuario no coincide.");
            string decryptedPassword = aesManager.Decrypt(retrievedAccount.Password);
            Assert.AreEqual(password, decryptedPassword, "La contraseña no coincide.");
        }

        [Then(@"la cuenta con sitio web ""(.*)"" ya no debe existir en la tabla hash")]
        public void ThenAccountDeleted(string site)
        {
            var retrieved = hashTable.Search(site);
            Assert.IsNull(retrieved, $"La cuenta con sitio web {site} aún existe en la tabla hash.");
        }

        [Then(@"la cuenta con sitio web ""(.*)"" debe tener el nombre de usuario ""(.*)"" y la contraseña ""(.*)"" en la tabla hash")]
        public void ThenAccountUpdated(string site, string username, string password)
        {
            var retrieved = hashTable.Search(site);
            Assert.IsNotNull(retrieved, $"La cuenta con sitio web {site} no fue encontrada.");
            Assert.AreEqual(username, retrieved.Username, "El nombre de usuario no coincide.");
            string decryptedPassword = aesManager.Decrypt(retrieved.Password);
            Assert.AreEqual(password, decryptedPassword, "La contraseña no coincide.");
        }

        [Given(@"una cuenta con sitio web ""(.*)"", nombre de usuario ""(.*)"" y contraseña ""(.*)"" que produce una colisión")]
        public void GivenCollidingAccount(string site, string username, string password)
        {
            byte[] encryptedPassword = aesManager.Encrypt(password);
            account = new Account(username, encryptedPassword);
        }
    }
}

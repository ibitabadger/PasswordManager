using MongoDB.Bson;
using MongoDB.Driver;
using PasswordManager.Model;

namespace PasswordManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //Application.Run(new Home());
            Application.Run(new Login());
            //Conexión base de datos

            //var client = new MongoClient("mongodb://localhost:27017"); // Cambia localhost y el puerto si es necesario

            //// Crea un cliente de MongoDB
            //var database = client.GetDatabase("PasswordHashing");

            //// Obtiene una colección dentro de la base de datos
            ////IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("Password");
            //var passwordDB = database.GetCollection<Login>("Password");
            //// Crea un documento para insertar en la colección

            //var document = new Login()
            //{
            //    Id = "1",
            //    User = "papitas",
            //    Password = "jiji"
            //};

            //// Inserta el documento en la colección
            //passwordDB.InsertOne(document);

            //// Muestra un mensaje de éxito
            //Console.WriteLine("Documento insertado exitosamente.");

            //Fin de conexión
        }
    }
}
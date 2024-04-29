using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Model
{
    public class HashTable1
    {
        private int size;
        private List<KeyValuePair<string, Account>>[] table;

        public HashTable1(int size)
        {
            this.size = size;
            table = new List<KeyValuePair<string, Account>>[size];
        }

        

        public int Hash(string key)
        {
            return Math.Abs(key.GetHashCode() % size);
        }

        public List<KeyValuePair<string, Account>>[] GetTable()
        {
            return table;
        }

        public void Insert(string key, Account account)
        {
            int hashValue = Hash(key);
            if (table[hashValue] == null)
            {
                table[hashValue] = new List<KeyValuePair<string, Account>>();
            }
            else
            {
                // Buscar y eliminar el par clave-valor existente
                for (int i = 0; i < table[hashValue].Count; i++)
                {
                    if (table[hashValue][i].Key == key)
                    {
                        table[hashValue].RemoveAt(i);
                        break;
                    }
                }
            }
            table[hashValue].Add(new KeyValuePair<string, Account>(key, account));
            PrintTable("insertando");
        }


        public Account Search(string key)
        {
            int hashValue = Hash(key);
            if (table[hashValue] != null)
            {
                foreach (KeyValuePair<string, Account> pair in table[hashValue])
                {
                    if (pair.Key == key)
                    {
                        return pair.Value;
                    }
                }
            }
            return null;
        }

        public void Delete(string key)
        {
            int hashValue = Hash(key);
            if (table[hashValue] != null)
            {
                for (int i = 0; i < table[hashValue].Count; i++)
                {
                    if (table[hashValue][i].Key == key)
                    {
                        table[hashValue].RemoveAt(i);
                        //PrintTable("eliminando");
                        //Console.WriteLine($"Tabla después de eliminar {key}: {string.Join(", ", table)}");
                        return;
                    }
                }
            }
        }


        public void PrintTable(string name)
        {
            // Iniciar un StringBuilder para acumular el contenido de la tabla
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Contenido de la tabla {name}:");

            for (int i = 0; i < table.Length; i++)
            {
                // Agregar el índice actual al StringBuilder
                sb.AppendFormat("Índice {0}: ", i);

                if (table[i] != null && table[i].Count > 0)
                {
                    // Agregar cada objeto Account en el índice actual
                    foreach (KeyValuePair<string, Account> kvp in table[i])
                    {
                        sb.AppendLine($"Usuario: {kvp.Value.Username}, Contraseña: {BitConverter.ToString(kvp.Value.Password)}");
                    }
                }
                else
                {
                    sb.AppendLine("Lista vacía.");
                }
            }

            // Mostrar el contenido acumulado en un MessageBox
            MessageBox.Show(sb.ToString(), "Contenido de HashTable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

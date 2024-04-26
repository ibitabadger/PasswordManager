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
        private List<KeyValuePair<string, object>>[] table;

        public HashTable1(int size)
        {
            this.size = size;
            table = new List<KeyValuePair<string, object>>[size];
        }

        private int Hash(string key)
        {
            return Math.Abs(key.GetHashCode() % size);
        }

        public void Insert(string key, object value)
        {
            int hashValue = Hash(key);
            if (table[hashValue] == null)
            {
                table[hashValue] = new List<KeyValuePair<string, object>>();
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
            table[hashValue].Add(new KeyValuePair<string, object>(key, value));
            PrintTable("insertando");
        }

        public object Search(string key)
        {
            int hashValue = Hash(key);
            if (table[hashValue] != null)
            {
                foreach (KeyValuePair<string, object> pair in table[hashValue])
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
                    // Agregar cada par clave-valor en el índice actual
                    foreach (KeyValuePair<string, object> kvp in table[i])
                    {
                        sb.AppendLine($"{kvp.Key}: {kvp.Value}");
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

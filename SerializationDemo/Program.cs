using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationDemo
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //SerializationDemo();

            JsonIgnoreDemo();
        }

        private static void JsonIgnoreDemo()
        {
            // Create a new Product instance
            Product product = new Product
            {
                Name = "Laptop",
                Price = 999.99m,
                StockQuantity = 50, // This field will be ignored during serialization
                Category = "Electronics"
            };

            string filePath = "product.json";

            // Serialize the Product object to JSON
            string jsonString = JsonSerializer.Serialize(product, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(jsonString);

            // Deserialize the JSON back to a Product object
            jsonString = File.ReadAllText(filePath);
            Product deserializedProduct = JsonSerializer.Deserialize<Product>(jsonString);
            Console.WriteLine("\nDeserialized Product:");
            Console.WriteLine($"Name: {deserializedProduct.Name}");
            Console.WriteLine($"Price: {deserializedProduct.Price}");
            Console.WriteLine($"StockQuantity: {deserializedProduct.StockQuantity} (This will be default value as it's not serialized)");
            Console.WriteLine($"Category: {deserializedProduct.Category}");

            // Clean up
            File.Delete(filePath);
        }

        private static void SerializationDemo()
        {
            //What to serialize
            Person person = new Person { Name = "John", Age = 30 };
           

            //how to serialize
            //BinaryFormatter serializer = new BinaryFormatter();
            XmlSerializer serializer = new XmlSerializer(typeof(Person));


            //Where to serialize
            string filePath = "person.xml";
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, person);
            }

            // Deserialize
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                Person deserializedPerson = (Person)serializer.Deserialize(fs);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            }
        }

    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        [JsonIgnore]
        public int StockQuantity { get; set; } // This field will not be serialized

        public string Category { get; set; }
    }
}

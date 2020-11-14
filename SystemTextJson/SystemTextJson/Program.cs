using System.Text.Json;
using System.IO;
using System;

namespace SystemTextJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var objVolume = new Book();

            string jsonSource = Directory.GetParent                             //getting the root directory 
                (Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string jsonString = File.ReadAllText($"{jsonSource}/response.json");   //getting path

            var book = JsonSerializer.Deserialize<Book>(jsonString,
              new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            Console.WriteLine(book.kind);
            Console.WriteLine(book.totalItems);
            foreach ( var item in book.items)
            {
                Console.WriteLine(item.etag);
                foreach (var author in item.volumeInfo.authors)
                {
                    Console.WriteLine(author);
                }
            }

            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(jsonString, serializeOptions);

            Console.WriteLine(json);




        }
    }
}

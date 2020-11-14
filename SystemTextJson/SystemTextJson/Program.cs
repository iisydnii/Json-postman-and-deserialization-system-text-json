using System.Text.Json;
using System.IO;
using System;
using System.Collections.Generic;

namespace SystemTextJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var objVolume = new VolumeInfo();

            string jsonSource = Directory.GetParent                             //getting the root directory 
                (Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string jsonString = File.ReadAllText($"{jsonSource}/response.json");   //getting path

            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(jsonString, serializeOptions);

            //Console.WriteLine(json);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var items = JsonSerializer.Deserialize<VolumeInfo>(jsonString, options);


            foreach ( var i in items)
            {
                Console.WriteLine(items.authors);
            }
            
            
            

        }
    }
}

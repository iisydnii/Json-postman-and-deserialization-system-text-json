using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace SystemTextJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonSource = Directory.GetParent                             //getting the root directory 
                (Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string jsonString = $"Data Source ={jsonSource}" +
                @"/Google Books API.postman_collection.json";                   //getting path 

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            Books books = new Books(jsonString, options, "Deserialize");


        }
    }
}

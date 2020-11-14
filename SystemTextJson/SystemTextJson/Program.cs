////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
// Project: SystemTextJson
// File Name: Program.cs
// Description: Driver
// Course: CSCI-2910-940
// Author: Sydni Ward
// Created: 11/14/2020
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Text.Json;
using System.IO;
using System;

namespace SystemTextJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonSource = Directory.GetParent                             //getting the root directory 
                (Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string jsonString = File.ReadAllText($"{jsonSource}/response.json");//getting path And Read text
            string fileName = $"{jsonSource}/book.json";                        //Set path

            var serializeOptions = new JsonSerializerOptions                    //Set JsonSerializerOptions 
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            //Deserialize
            var book = JsonSerializer.Deserialize<Book>(jsonString,
              new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            //Proof Deserialize works
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

            //Serialize
            string json = JsonSerializer.Serialize(jsonString,
                serializeOptions);
            //Write to file book.json
            File.WriteAllText(fileName, jsonString);

            //Proof Serialize works
            //Console.WriteLine(json);
        }
    }
}

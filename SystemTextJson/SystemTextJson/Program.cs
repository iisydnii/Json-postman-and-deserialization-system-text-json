using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace SystemTextJson
{
    class Program
    {
        private static string fileName;

        static void Main(string[] args)
        {
            var kind = "";
            var id = "";
            var etag = "";
            var selfLink = "";
            var title = "";
            var authors = "";
            var publisher = "";
            var publishedDate = "";
            var description = "";
            var pageCount = "";

            VolumeInfo volumeInfo = new VolumeInfo();
            Items items = new Items();

            string jsonSource = Directory.GetParent                             //getting the root directory 
                (Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string jsonString = $"Data Source ={jsonSource}" +
                @"/Google Books API.postman_collection.json";                   //getting path 

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };

            var volumes = JsonSerializer.Deserialize<VolumeInfo>(jsonString, options);
            var item = JsonSerializer.Deserialize<Items>(jsonString, options);

            foreach (var item1 in item.kind)
            {
                kind = item1.ToString();
            }
            foreach (var item1 in item.id)
            {
                id = item1.ToString();
            }
            foreach (var item1 in item.etag)
            {
                etag = item1.ToString();
            }
            foreach (var item1 in item.selfLink)
            {
                selfLink = item1.ToString();
            }

            
            foreach (var volume in volumes.title)
            {
                title = volume.ToString();
            }
            foreach (var volume in volumes.authors)
            {
                authors = volume.ToString();
            }
            foreach (var volume in volumes.publisher)
            {
                publisher = volume.ToString();
            }
            foreach (var volume in volumes.publishedDate)
            {
                publishedDate = volume.ToString();
            }
            foreach (var volume in volumes.description)
            {
                description = volume.ToString();
            }
            foreach (var volume in volumes.pageCount)
            {
                pageCount = volume.ToString();
            }
            VolumeInfo volumeInfo1 = new VolumeInfo(title, authors, publisher, publishedDate, description, pageCount);
            Items items1 = new Items(kind, id, etag, selfLink, volumeInfo1);
            Books books = new Books(items1);

        }
    }
}

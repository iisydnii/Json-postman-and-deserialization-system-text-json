using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace SystemTextJson
{
    public class Books
    {
        Items items;
        List<Items> books;
        public Books(string jsonString, JsonSerializerOptions options,
            string position)
        {
            items = new Items(jsonString, options, position);
            books = new List<Items>();
            books.Add(items);
        }
    }
}

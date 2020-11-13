using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace SystemTextJson
{
    public class Items
    {
        Items item;
        string path;
        string pos;
        JsonSerializerOptions option;

        public Items(string jsonString, JsonSerializerOptions options, string position)
        {
            path = jsonString;
            option = options;
            pos = position;
            Position(jsonString, options, position);
            this.kind = kind;
            this.id = id;
            this.etag = etag;
            this.selfLink = selfLink;
            this.volumeInfo = volumeInfo;
        }
        
        public string kind
        {
            get { return kind; }
            set
            {
                foreach (var item1 in item.kind)
                {
                    kind = item1.ToString();
                }
            }
        }
        public string id
        {
            get { return id; }
            set
            {
                foreach (var item1 in item.id)
                {
                    id = item1.ToString();
                }
            }
        }
        public string etag
        {
            get { return etag; }
            set
            {
                foreach (var item1 in item.etag)
                {
                    etag = item1.ToString();
                }
            }
        }
        public string selfLink
        {
            get { return selfLink; }
            set
            {
                foreach (var item1 in item.selfLink)
                {
                    selfLink = item1.ToString();
                }
            }
        }
        public VolumeInfo volumeInfo
        {
            get{ return volumeInfo; }
            set
            {
                VolumeInfo volumeInfo1 = new VolumeInfo(path, option, pos);
            }
        }
        public void Position(string jsonString, JsonSerializerOptions options,
            string position)
        {
            if (position == "Deserialize")
            {
                item = JsonSerializer.Deserialize<Items>(jsonString, options);
            }
            else if (position == "Serialize")
            {

            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}

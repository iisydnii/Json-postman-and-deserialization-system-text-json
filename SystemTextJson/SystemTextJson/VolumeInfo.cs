using System;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace SystemTextJson
{
    public class VolumeInfo
    {
        VolumeInfo volumes;

        public VolumeInfo(string jsonString, JsonSerializerOptions options,
            String position)
        {
            Position(jsonString, options, position);
            this.title = title;
            this.authors = authors;
            this.publisher = publisher;
            this.publishedDate = publishedDate;
            this.description = description;
            this.pageCount = pageCount;
        }

        public string title
        {
            get { return title; }
            set
            {
                foreach (var volume in volumes.title)
                {
                    title = volume.ToString();
                }
            }
        }
        public string authors
        {
            get { return authors; }
            set
            {
                foreach (var volume in volumes.authors)
                {
                    authors = volume.ToString();
                }
            }
        }
        public string publisher
        {
            get { return publisher; }
            set
            {
                foreach (var volume in volumes.publisher)
                {
                    publisher = volume.ToString();
                }
            }
        }
        public string publishedDate
        {
            get { return publishedDate; }
            set
            {
                foreach (var volume in volumes.publishedDate)
                {
                    publishedDate = volume.ToString();
                }
            }
        }
        public string description
        {
            get { return description; }
            set
            {
                foreach (var volume in volumes.description)
                {
                    description = volume.ToString();
                }
            }
        }
        public string pageCount
        {
            get { return pageCount; }
            set
            {
                foreach (var volume in volumes.pageCount)
                {
                    pageCount = volume.ToString();
                }
            }
        }

        public void Position(string jsonString, JsonSerializerOptions options,
            string position)
        {
            if( position == "Deserialize")
            {
                volumes = JsonSerializer.Deserialize<VolumeInfo>(jsonString, options);
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

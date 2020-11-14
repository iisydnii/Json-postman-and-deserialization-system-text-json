////////////////////////////////////////////////////////////////////////////////////////////////////////////////// //
// Project: SystemTextJson
// File Name: Items.cs
// Description: To represent Items in json file
// Course: CSCI-2910-940
// Author: Sydni Ward
// Created: 11/14/2020
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace SystemTextJson
{
    public class Items
    {
        public string kind { get; set; }
        public string id { get; set; }
        public string etag { get; set; }
        public string selfLink { get; set; }
        public VolumeInfo volumeInfo { get; set; }
    }
}

﻿using System;
using System.Text.Json;

namespace SystemTextJson
{
    public class Items
    {
        //public string kind { get; set; }
        public string id { get; set; }
        public string etag { get; set; }
        public string selfLink { get; set; }
        public VolumeInfo volumeInfo { get; set; }
    }
}

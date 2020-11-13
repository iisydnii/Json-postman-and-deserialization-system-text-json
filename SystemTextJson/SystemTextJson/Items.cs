using System;
using System.Collections.Generic;

namespace SystemTextJson
{
    public class Items
    {
        List<Items> list;
        public Items()
        {
            this.Kind = Kind;
            this.Id = Id;
            this.Etag = Etag;
            this.SelfLink = SelfLink;
            this.volumeInfo = volumeInfo;
            list = new List<Items>();
        }
        public string Kind { get; set; }
        public string Id { get; set; }
        public string Etag { get; set; }
        public string SelfLink { get; set; }
        public VolumeInfo volumeInfo { get; set; }
        

    }
}

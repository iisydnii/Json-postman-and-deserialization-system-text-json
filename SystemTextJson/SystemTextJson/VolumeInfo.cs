using System;
using System.Collections.Generic;

namespace SystemTextJson
{
    public class VolumeInfo
    {
        List<VolumeInfo> volumeInfo;

        public VolumeInfo()
        {
            this.Title = Title;
            this.Authors = Authors;
            this.Publisher = Publisher;
            this.PublishedDate = PublishedDate;
            this.Description = Description;
            this.PageCount = PageCount;
            volumeInfo = new List<VolumeInfo>();
        }

        public string Title { get; set; }
        public string Authors { get; set; }
        public string Publisher { get; set; }
        public string PublishedDate { get; set; }
        public string Description { get; set; }
        public string PageCount { get; set; }
        
            
    }
}

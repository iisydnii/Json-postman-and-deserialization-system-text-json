using System.Collections;
using System.Text.Json;

namespace SystemTextJson
{
    public class VolumeInfo : IEnumerable
    {
        public string title { get; set; }
        public string authors { get; set; }
        public string publisher { get; set; }
        public string publishedDate { get; set; }
        public string description { get; set; }
        public string pageCount { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}

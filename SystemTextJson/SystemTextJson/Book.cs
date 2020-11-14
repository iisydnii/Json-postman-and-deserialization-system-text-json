using System.Collections.Generic;

namespace SystemTextJson
{
    class Book
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public IList<Items> items { get; set; }
    }
}
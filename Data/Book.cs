using System;
using System.Collections.Generic;

namespace SecondServer.Data
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int? AuthorIdId { get; set; }
        public DateTime PublishedAt { get; set; }
        public double Price { get; set; }
        public bool Avaialbe { get; set; }
        public string CoverImg { get; set; }

        public virtual Author AuthorId { get; set; }
    }
}

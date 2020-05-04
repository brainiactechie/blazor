using System;
using System.Collections.Generic;

namespace SecondServer.Data
{
    public partial class Author
    {
        public Author()
        {
            Book = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime Avialable { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}

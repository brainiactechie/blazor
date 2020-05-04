using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecondServer.models
{
    public partial class LocalityType
    {
        public LocalityType()
        {
            Surah = new HashSet<Surah>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public virtual ICollection<Surah> Surah { get; set; }
    }
}

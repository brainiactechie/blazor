using System;
using System.Collections.Generic;

namespace SecondServer.models
{
    public partial class Surah
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? VersesCount { get; set; }
        public int Locality { get; set; }
        public string Verses { get; set; }
        public bool? Basmala { get; set; }
        public string BasmalaStr { get; set; }

        public virtual LocalityType LocalityNavigation { get; set; }
    }
}

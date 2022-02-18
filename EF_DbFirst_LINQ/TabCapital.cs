using System;
using System.Collections.Generic;

#nullable disable

namespace EF_DbFirst_LINQ
{
    public partial class TabCapital
    {
        public TabCapital()
        {
            TabCountries = new HashSet<TabCountry>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

        public virtual ICollection<TabCountry> TabCountries { get; set; }
    }
}

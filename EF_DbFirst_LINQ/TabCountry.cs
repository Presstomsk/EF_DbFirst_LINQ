using System;
using System.Collections.Generic;

#nullable disable

namespace EF_DbFirst_LINQ
{
    public partial class TabCountry
    {
        public TabCountry()
        {
            TabCities = new HashSet<TabCity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CapitalId { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }
        public string PartOfTheWorld { get; set; }

        public virtual TabCapitals Capital { get; set; }
        public virtual ICollection<TabCity> TabCities { get; set; }
    }
}

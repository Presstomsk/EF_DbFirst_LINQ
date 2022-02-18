using System;
using System.Collections.Generic;

#nullable disable

namespace EF_DbFirst_LINQ
{
    public partial class TabCity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int CountryId { get; set; }

        public virtual TabCountry Country { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NationalParksLinq.Models
{
    public class NationalPark
    {
        public string Name { get; set; }
        public string State { get; set; }
        public int AreaInAcres { get; set; }
        public int AnnualVisitors { get; set; }
        public int YearFounded { get; set; }
    }
}

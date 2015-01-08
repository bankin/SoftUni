using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NightlifeEntertainment
{
    class Opera : Venue
    {
        public Opera(string name, string location, int numberOfSeats)
            : base(
                name, location, numberOfSeats,
                new List<PerformanceType> {PerformanceType.Opera, PerformanceType.Theatre})
        {
            
        }
    }
}

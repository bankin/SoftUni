using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NightlifeEntertainment
{
    class ConcertHall : Venue
    {
        public ConcertHall(string name, string location, int numberOfSeats)
            : base(
                name, location, numberOfSeats,
                new List<PerformanceType> {PerformanceType.Opera, PerformanceType.Theatre, PerformanceType.Concert})
        {
            
        }
    }
}

using NationalParksLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NationalParksLinq
{
    internal class SetQueries
    {
        private static List<NationalPark> _nationalParks = DataGenerator.GetNationalParkData();

        public static void AnyAndAllLinq()
        {
            var anyParksInWashington = _nationalParks.Any(p => p.State == "Washington");
            Console.WriteLine(anyParksInWashington);

            var anyParksInIllinois = _nationalParks.Any(p => p.State == "Illinois");
            Console.WriteLine(anyParksInIllinois);

            var allParksFounded = _nationalParks.All(park => park.YearFounded >= 1872);
            Console.WriteLine(allParksFounded);

            var californiaFoundedParks = _nationalParks.Where(p => p.State == "California")
                .All(park => park.YearFounded >= 1900);
            Console.WriteLine(californiaFoundedParks);

        }

        public static void ExceptLinq()
        {
            var firstPark = _nationalParks.FirstOrDefault();
            var lastPark = _nationalParks.LastOrDefault();
            var parkArray = new List<NationalPark> { firstPark, lastPark };

            var parksNotRemoved = _nationalParks.Except(parkArray).ToList();
            parksNotRemoved.ForEach(Console.WriteLine);

            //var parksToRemove = _nationalParks.Where(p => p.State == "California");
            //var parksNotRemoved = _nationalParks.Except(parksToRemove).ToList();
            //parksNotRemoved.ForEach(Console.WriteLine);
        }
    }
}

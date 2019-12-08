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

            var parksInIllinois = _nationalParks.Any(p => p.State == "Illinois");
            Console.WriteLine(parksInIllinois);

            var parkInWashington = false;
            foreach (var park in _nationalParks)
            {
                if (park.State == "Washington")
                {
                    parkInWashington = true;
                    break;
                }
            }

            var allParksFounded = _nationalParks.All(park => park.YearFounded >= 1872);
            Console.WriteLine(allParksFounded);

            var californiaFoundedParks = _nationalParks.Where(p => p.State == "California")
                .All(park => park.YearFounded >= 1900);
            Console.WriteLine(californiaFoundedParks);


        }
    }
}

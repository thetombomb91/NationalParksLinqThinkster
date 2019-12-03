using NationalParksLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NationalParksLinq
{
    internal class PagingQueries
    {
        private static List<NationalPark> _nationalParks = DataGenerator.GetNationalParkData();

        public static void ElementAtLinq()
        {
            //var thirdElement = _nationalParks.ElementAt(2);
            //Console.WriteLine(thirdElement);
            //thirdElement.AreaInAcres = 5;
            //Console.WriteLine(_nationalParks);

            //var californiaParks = _nationalParks.Where(p => p.State =="California");
            //var singleCaliforniaPark = californiaParks.ElementAt(2);
            //Console.WriteLine(singleCaliforniaPark);

            //var singleCaliforniaPark = _nationalParks.Where(p => p.State == "California").ElementAt(2);
            //Console.WriteLine(singleCaliforniaPark);
        }

    }
}

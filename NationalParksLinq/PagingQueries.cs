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
            //thirdElement.AreaInAcres = 5;
            ////Console.WriteLine(thirdElement);
            //_nationalParks.ForEach(Console.WriteLine);
        }

        public static void FirstLinq()
        {
            //var firstElement = _nationalParks.First();
            //Console.WriteLine(firstElement);

            //var firstElement = _nationalParks.FirstOrDefault();
            //Console.WriteLine(firstElement);

            //var firstElement = _nationalParks.Where(p => p.State == "Illinois").First();
            //Console.WriteLine(firstElement);

            var firstElement = _nationalParks.Where(p => p.State == "Illinois").FirstOrDefault();
            Console.WriteLine(firstElement);

        }

    }
}
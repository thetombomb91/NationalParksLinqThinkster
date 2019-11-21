using NationalParksLinq.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NationalParksLinq
{
    internal class ProjectionQueries
    {
        private static List<NationalPark> _nationalParks = DataGenerator.GetNationalParkData();

        public static void SelectLinq()
        {
            //var result = _nationalParks.Select(p => p).ToList();
            //result.ForEach(Console.WriteLine);

            //var result = _nationalParks.Select(p => p.Name).ToList();
            //result.ForEach(Console.WriteLine);

            //var result = _nationalParks.Select(p => p.Name.Length).ToList();
            //result.ForEach(Console.WriteLine);

            //var result = _nationalParks.Select(p => $"{p.Name}, {p.State}").ToList();
            //result.ForEach(Console.WriteLine);
        }

        public static void WhereLinq()
        {
            //var result = _nationalParks.Where(park => true).ToList();
            //result.ForEach(Console.WriteLine);

            //var result = _nationalParks.Where(park => park.State == "California").ToList();
            //result.ForEach(Console.WriteLine);

            //var result = _nationalParks.Where(park => park.State == "California" && park.YearFounded > 2020).ToList();
            //result.ForEach(Console.WriteLine);

            //var result = _nationalParks.Where(park => park.YearFounded > 1950 && park.YearFounded < 1980).ToList();
            //result.ForEach(Console.WriteLine);
        }
    }
}

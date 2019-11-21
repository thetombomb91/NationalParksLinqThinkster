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
            //result = _nationalParks.Select(p => p).ToList();
            //result.ForEach(Console.WriteLine);

            //var result = _nationalParks.Select(p => p.Name).ToList();
            //result.ForEach(Console.WriteLine);

            //var result = _nationalParks.Select(p => p.Name.Length).ToList();
            //result.ForEach(Console.WriteLine);

            var result = _nationalParks.Select(p => $"{p.Name}, {p.State}").ToList();
            result.ForEach(Console.WriteLine);
        }
    }
}

using NationalParksLinq.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace NationalParksLinq.Tests
{
    public class ProjectionQueryTests
    {
        public List<NationalPark> NationalParks { get; set; }
        [SetUp]
        public void Setup()
        {
            NationalParks = DataGenerator.GetNationalParkData();
        }

        [Test]
        public void Test1()
        {
        }
    }
}
using NationalParksLinq.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NationalParksLinq.Tests
{
    [TestFixture]
    //[Ignore("")]
    public class ProjectionQueryTests
    {
        public List<NationalPark> NationalParks { get; set; }
        [SetUp]
        public void Setup()
        {
            NationalParks = DataGenerator.GetNationalParkData();
        }

        /* Use a Select LINQ statement to make the below test pass.
         * Your result should be a List<int> that contains only the 
         * year that each park was founded. Don't forget to use the
         * ToList() methods.
         */
        [Test]
        public void TestSelectTheYearEachParkWasFounded()
        {
            var result = NationalParks.Select(p => p.YearFounded).ToList();

            Assert.AreEqual(61, result.Count());
            Assert.AreEqual(1919, result[0]);
            Assert.AreEqual(1919, result[60]);
        }


        /* Use a Select LINQ statement to make the below test pass.
         * Your result should be a List<string> that contains the 
         * formatted string of National Park Name followed by the 
         * year the park was founded. Don't forget to use the
         * ToList() methods.
         */
        [Test]
        public void TestSelectTheNameOfParkAndYearFounded()
        {
            var result = NationalParks.Select(p => $"{p.Name} {p.YearFounded}").ToList();

            Assert.AreEqual(61, result.Count());
            Assert.AreEqual("Acadia 1919", result[0]);
            Assert.AreEqual("Zion 1919", result[60]);
        }


        /* Use a Where LINQ statement to make the below test pass.
         * Your result should be a List<NationalPark> that contains
         * only the National Parks located on the West Coast.
         * (California, Oregon, Washington). Don't forget to use the
         * ToList() methods.
         */
        [Test]
        public void TestReturnAllNationalParksOnWestCoast()
        {
            var result = NationalParks.Where(p => p.State == "California"
            || p.State == "Oregon"
            || p.State == "Washington").ToList();

            Assert.AreEqual(13, result.Count());
            Assert.AreEqual("Channel Islands", result[0].Name);
            Assert.AreEqual("Lassen Volcanic", result[5].Name);
            Assert.AreEqual("Yosemite", result[12].Name);
        }

        /* Use a Where LINQ statement to make the below test pass.
         * Your result should be a List<NationalPark> that contains
         * only the National Parks less than 50,000 acres in size and have
         * more than 250,000 annual visitors. Don't forget to use the
         * ToList() methods.
         */
        [Test]
        public void TestReturnAllNationalParksSmallerThan50000AcresAndMoreThan250000Visitors()
        {
            var result = NationalParks.Where(p => p.AreaInAcres < 50000
            && p.AnnualVisitors > 250000).ToList();

            Assert.AreEqual(10, result.Count());
            Assert.AreEqual("Acadia", result[0].Name);
            Assert.AreEqual("Gateway Arch", result[5].Name);
            Assert.AreEqual("Wind Cave", result[9].Name);
        }
    }
}
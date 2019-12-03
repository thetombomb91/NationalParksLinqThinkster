using NationalParksLinq.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleToAttribute("NationalParksLinq.Tests")]
namespace NationalParksLinq
{
    internal class DataGenerator
    {
        public static List<NationalPark> GetNationalParkData()
        {
            var nationalParkData = new List<NationalPark>()
            {
                new NationalPark
                {
                    Name = "Acadia",
                    State = "Maine",
                    AreaInAcres = 49075,
                    AnnualVisitors = 3537575,
                    YearFounded = 1919
                },
                new NationalPark
                {
                    Name = "American Samoa",
                    State = "American Samoa",
                    AreaInAcres = 8256,
                    AnnualVisitors = 28626,
                    YearFounded = 1988
                },
                new NationalPark
                {
                    Name = "Arches",
                    State = "Utah",
                    AreaInAcres = 76678,
                    AnnualVisitors = 1663557,
                    YearFounded = 1971
                },
                new NationalPark
                {
                    Name = "Badlands",
                    State = "South Dakota",
                    AreaInAcres = 242755,
                    AnnualVisitors = 1008942,
                    YearFounded = 1978
                },
                new NationalPark
                {
                    Name = "Big Bend",
                    State = "Texas",
                    AreaInAcres = 801163,
                    AnnualVisitors = 440091,
                    YearFounded = 1944
                },
                new NationalPark
                {
                    Name = "Biscayne",
                    State = "Florida",
                    AreaInAcres = 172971,
                    AnnualVisitors = 469253,
                    YearFounded = 1980
                },
                new NationalPark
                {
                    Name = "Black Canyon of the Gunnison",
                    State = "Colorado",
                    AreaInAcres = 30779,
                    AnnualVisitors = 308962,
                    YearFounded = 1999
                },
                new NationalPark
                {
                    Name = "Bryce Canyon",
                    State = "Utah",
                    AreaInAcres = 35835,
                    AnnualVisitors = 2679478,
                    YearFounded = 1928
                },
                new NationalPark
                {
                    Name = "Cayonlands",
                    State = "Utah",
                    AreaInAcres = 337597,
                    AnnualVisitors = 739449,
                    YearFounded = 1964
                },
                new NationalPark
                {
                    Name = "Capital Reef",
                    State = "Utah",
                    AreaInAcres = 241904,
                    AnnualVisitors = 1227627,
                    YearFounded = 1971
                },
                new NationalPark
                {
                    Name = "Carlsbad Caverns",
                    State = "New Mexico",
                    AreaInAcres = 46766,
                    AnnualVisitors = 465912,
                    YearFounded = 1930
                },
                new NationalPark
                {
                    Name = "Channel Islands",
                    State = "California",
                    AreaInAcres = 249561,
                    AnnualVisitors = 366250,
                    YearFounded = 1980
                },
                new NationalPark
                {
                    Name = "Congaree",
                    State = "South Carolina",
                    AreaInAcres = 26639,
                    AnnualVisitors = 145929,
                    YearFounded = 2003
                },
                new NationalPark
                {
                    Name = "Crater Lake",
                    State = "Oregon",
                    AreaInAcres = 183224,
                    AnnualVisitors = 720659,
                    YearFounded = 1902
                },
                new NationalPark
                {
                    Name = "Cuyahoga Valley",
                    State = "Ohio",
                    AreaInAcres = 32571,
                    AnnualVisitors = 2096053,
                    YearFounded = 2000
                },
                new NationalPark
                {
                    Name = "Death Valley",
                    State = "California",
                    AreaInAcres = 3372981,
                    AnnualVisitors = 1678660,
                    YearFounded = 1994
                },
                new NationalPark
                {
                    Name = "Denali",
                    State = "Alaska",
                    AreaInAcres = 4740911,
                    AnnualVisitors = 594660,
                    YearFounded = 1917
                },
                new NationalPark
                {
                    Name = "Dry Tortugas",
                    State = "Florida",
                    AreaInAcres = 64701,
                    AnnualVisitors = 56810,
                    YearFounded = 1992
                },
                new NationalPark
                {
                    Name = "Everglades",
                    State = "Florida",
                    AreaInAcres = 1508938,
                    AnnualVisitors = 597124,
                    YearFounded = 1934
                },
                new NationalPark
                {
                    Name = "Gates of the Arctic",
                    State = "Alaska",
                    AreaInAcres = 7523897,
                    AnnualVisitors = 9591,
                    YearFounded = 1980
                },
                new NationalPark
                {
                    Name = "Gateway Arch",
                    State = "Missouri",
                    AreaInAcres = 192,
                    AnnualVisitors = 2016180,
                    YearFounded = 2018
                },
                new NationalPark
                {
                    Name = "Glacier",
                    State = "Montana",
                    AreaInAcres = 1013125,
                    AnnualVisitors = 2965309,
                    YearFounded = 1910
                },
                new NationalPark
                {
                    Name = "Glacier Bay",
                    State = "Alaska",
                    AreaInAcres = 1201647,
                    AnnualVisitors = 597915,
                    YearFounded = 1980
                },
                new NationalPark
                {
                    Name = "Grand Canyon",
                    State = "Arizona",
                    AreaInAcres = 1201647,
                    AnnualVisitors = 6380495,
                    YearFounded = 1919
                },
                new NationalPark
                {
                    Name = "Grand Teton",
                    State = "Wyoming",
                    AreaInAcres = 310044,
                    AnnualVisitors = 3491151,
                    YearFounded = 1929
                },
                new NationalPark
                {
                    Name = "Great Basin",
                    State = "Nevada",
                    AreaInAcres = 77180,
                    AnnualVisitors = 153094,
                    YearFounded = 1986
                },
                new NationalPark
                {
                    Name = "Great Sand Dunes",
                    State = "Colorado",
                    AreaInAcres = 107341,
                    AnnualVisitors = 442905,
                    YearFounded = 2004
                },
                new NationalPark
                {
                    Name = "Great Smoky Mountains",
                    State = "Tennessee",
                    AreaInAcres = 522426,
                    AnnualVisitors = 11421200,
                    YearFounded = 1934
                },
                new NationalPark
                {
                    Name = "Guadalupe Mountains",
                    State = "Texas",
                    AreaInAcres = 86367,
                    AnnualVisitors = 172347,
                    YearFounded = 1966
                },
                new NationalPark
                {
                    Name = "Haleakala",
                    State = "Hawaii",
                    AreaInAcres = 33264,
                    AnnualVisitors = 1044084,
                    YearFounded = 1916
                },
                new NationalPark
                {
                    Name = "Hawaii Volcanoes",
                    State = "Hawaii",
                    AreaInAcres = 325605,
                    AnnualVisitors = 1116891,
                    YearFounded = 1916
                },
                new NationalPark
                {
                    Name = "Hot Springs",
                    State = "Arkansas",
                    AreaInAcres = 5551,
                    AnnualVisitors = 1506887,
                    YearFounded = 1921
                },
                new NationalPark
                {
                    Name = "Indiana Dunes",
                    State = "Indiana",
                    AreaInAcres = 15348,
                    AnnualVisitors = 1756079,
                    YearFounded = 2019
                },
                new NationalPark
                {
                    Name = "Isle Royale",
                    State = "Michigan",
                    AreaInAcres = 571790,
                    AnnualVisitors = 25798,
                    YearFounded = 1940
                },
                new NationalPark
                {
                    Name = "Joshua Tree",
                    State = "California",
                    AreaInAcres = 790635,
                    AnnualVisitors = 1942382,
                    YearFounded = 1994
                },
                new NationalPark
                {
                    Name = "Katmai",
                    State = "Alaska",
                    AreaInAcres = 3674529,
                    AnnualVisitors = 37818,
                    YearFounded = 1980
                },
                new NationalPark
                {
                    Name = "Kenai Fjords",
                    State = "Alaska",
                    AreaInAcres = 669650,
                    AnnualVisitors = 321596,
                    YearFounded = 1980
                },
                new NationalPark
                {
                    Name = "Kings Canyon",
                    State = "California",
                    AreaInAcres = 461901,
                    AnnualVisitors = 699023,
                    YearFounded = 1940
                },
                new NationalPark
                {
                    Name = "Kobuk Valley",
                    State = "Alaska",
                    AreaInAcres = 1750716,
                    AnnualVisitors = 14937,
                    YearFounded = 1980
                },
                new NationalPark
                {
                    Name = "Lake Clark",
                    State = "Alaska",
                    AreaInAcres = 2619816,
                    AnnualVisitors = 14479,
                    YearFounded = 1980
                },
                new NationalPark
                {
                    Name = "Lassen Volcanic",
                    State = "California",
                    AreaInAcres = 106589,
                    AnnualVisitors = 499435,
                    YearFounded = 1916
                },
                new NationalPark
                {
                    Name = "Mammoth Cave",
                    State = "Kentucky",
                    AreaInAcres = 54011,
                    AnnualVisitors = 533206,
                    YearFounded = 1941
                },
                new NationalPark
                {
                    Name = "Mesa Verde",
                    State = "Colorado",
                    AreaInAcres = 52485,
                    AnnualVisitors = 563420,
                    YearFounded = 1906
                },
                new NationalPark
                {
                    Name = "Mount Rainier",
                    State = "Washington",
                    AreaInAcres = 52485,
                    AnnualVisitors = 1518491,
                    YearFounded = 1899
                },
                new NationalPark
                {
                    Name = "North Cascades",
                    State = "Washington",
                    AreaInAcres = 504780,
                    AnnualVisitors = 30085,
                    YearFounded = 1968
                },
                new NationalPark
                {
                    Name = "Olympic",
                    State = "Washington",
                    AreaInAcres = 922649,
                    AnnualVisitors = 3104455,
                    YearFounded = 1938
                },
                new NationalPark
                {
                    Name = "Petrified Forest",
                    State = "Arizona",
                    AreaInAcres = 221390,
                    AnnualVisitors = 644922,
                    YearFounded = 1962
                },
                new NationalPark
                {
                    Name = "Pinnacles",
                    State = "California",
                    AreaInAcres = 26685,
                    AnnualVisitors = 222152,
                    YearFounded = 2013
                },
                new NationalPark
                {
                    Name = "Redwood",
                    State = "California",
                    AreaInAcres = 138999,
                    AnnualVisitors = 482536,
                    YearFounded = 1968
                },
                new NationalPark
                {
                    Name = "Rocky Mountain",
                    State = "Colorado",
                    AreaInAcres = 265807,
                    AnnualVisitors = 4590493,
                    YearFounded = 1915
                },
                new NationalPark
                {
                    Name = "Saguaro",
                    State = "Arizona",
                    AreaInAcres = 91715,
                    AnnualVisitors = 957405,
                    YearFounded = 1994
                },
                new NationalPark
                {
                    Name = "Sequoia",
                    State = "California",
                    AreaInAcres = 404062,
                    AnnualVisitors = 1229594,
                    YearFounded = 1890
                },
                new NationalPark
                {
                    Name = "Shenandoah",
                    State = "Virginia",
                    AreaInAcres = 199223,
                    AnnualVisitors = 1264800,
                    YearFounded = 1935
                },
                new NationalPark
                {
                    Name = "Theodore Roosevelt",
                    State = "North Dakota",
                    AreaInAcres = 70446,
                    AnnualVisitors = 749389,
                    YearFounded = 1978
                },
                new NationalPark
                {
                    Name = "Virgin Islands",
                    State = "Virgin Islands",
                    AreaInAcres = 14944,
                    AnnualVisitors = 112287,
                    YearFounded = 1956
                },
                new NationalPark
                {
                    Name = "Voyageurs",
                    State = "Minnesota",
                    AreaInAcres = 218200,
                    AnnualVisitors = 239656,
                    YearFounded = 1971
                },
                new NationalPark
                {
                    Name = "Wind Cave",
                    State = "South Dakota",
                    AreaInAcres = 33970,
                    AnnualVisitors = 656397,
                    YearFounded = 1903
                },
                new NationalPark
                {
                    Name = "Wrangell St. Elias",
                    State = "Alaska",
                    AreaInAcres = 8323146,
                    AnnualVisitors = 79450,
                    YearFounded = 1980
                },
                new NationalPark
                {
                    Name = "Yellowstone",
                    State = "Wyoming",
                    AreaInAcres = 2219790,
                    AnnualVisitors = 4115000,
                    YearFounded = 1872
                },
                new NationalPark
                {
                    Name = "Yosemite",
                    State = "California",
                    AreaInAcres = 761747,
                    AnnualVisitors = 4009436,
                    YearFounded = 1890
                },
                new NationalPark
                {
                    Name = "Zion",
                    State = "Utah",
                    AreaInAcres = 147242,
                    AnnualVisitors = 4320033,
                    YearFounded = 1919
                },

            };

            return nationalParkData;
        }
    }
}

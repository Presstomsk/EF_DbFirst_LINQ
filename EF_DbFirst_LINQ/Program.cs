

using System;
using System.Linq;

namespace EF_DbFirst_LINQ
{
    class Program
    {
        static void Main()
        {
            using (var db = new host1323541_sbd06Context())
            {
                var countriesInfo = from Capital in db.TabCapitals
                                    join Country in db.TabCountries on Capital.Id equals Country.CapitalId
                                    join City in db.TabCities on Capital.Id equals City.CountryId
                                    select new
                                    {
                                        Name = Country.Name,
                                        CountryPopulation = Country.Population,
                                        Area = Country.Area,
                                        PathOfTheWorld = Country.PartOfTheWorld,
                                        Capital = Capital.Name,
                                        CapitalPopulation = Capital.Population,
                                        BigCity = City.Name,
                                        BigCityPopulation = City.Population
                                    };

                foreach (var item in countriesInfo)
                {
                    Console.WriteLine($"Страна: {item.Name}");
                    Console.WriteLine($"Население: {item.CountryPopulation}");
                    Console.WriteLine($"Площадь: {item.Area}");
                    Console.WriteLine($"Часть света: {item.PathOfTheWorld}");
                    Console.WriteLine($"Столица: {item.Capital}");
                    Console.WriteLine($"Население столицы: {item.CapitalPopulation}");
                    Console.WriteLine($"Крупный город: {item.BigCity}");
                    Console.WriteLine($"Население крупного города: {item.BigCityPopulation}");
                    Console.WriteLine();
                }

                var countriesNames = from Country in db.TabCountries
                                     select Country.Name;
                Console.WriteLine( $"Названия всех стран: {string.Join(",", countriesNames)}");
                Console.WriteLine();

                var capitalsNames = from Capital in db.TabCapitals
                                     select Capital.Name;
                Console.WriteLine($"Названия всех столиц: {string.Join(",", capitalsNames)}");
                Console.WriteLine();

                var bigCityOfCountry = from City in db.TabCities
                                       join Country in db.TabCountries on City.CountryId equals Country.Id
                                       where Country.Name=="Russia"
                                       select City.Name;
                Console.WriteLine($"Крупный город в России - {string.Join(",", bigCityOfCountry)}");
                Console.WriteLine();

                var capitalsWithBigPopulation = from Capital in db.TabCapitals                                                
                                                where Capital.Population > 5000000
                                                select Capital.Name;
                Console.WriteLine($"Столицы с населением более 5000000 человек: {string.Join(",", capitalsWithBigPopulation)}");
                Console.WriteLine();

                var euroCountries = from Country in db.TabCountries
                                    where Country.PartOfTheWorld =="Europe"
                                    select Country.Name;
                Console.WriteLine($"Страны Европы: {string.Join(",", euroCountries)}");
                Console.WriteLine();

                var сountriesWithAreaMoreThen = from Country in db.TabCountries
                                                where Country.Area > 300000
                                                select Country.Name;
                Console.WriteLine($"Страны c площадью более 300000: {string.Join(",", сountriesWithAreaMoreThen)}");
                Console.WriteLine();

            };
        }
    }
}

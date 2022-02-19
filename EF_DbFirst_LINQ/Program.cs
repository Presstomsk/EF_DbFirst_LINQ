

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
            using (var db = new host1323541_sbd06Context())
            {
                var capitalsWith_a_and_i = from Capital in db.TabCapitals
                                           where (Capital.Name.Contains("a") && Capital.Name.Contains("i"))
                                           select Capital.Name;
                

                Console.WriteLine($"Столицы, у которых в названии есть буквы a, i: {string.Join(",", capitalsWith_a_and_i)}");
                Console.WriteLine();

               //var capitalsStartWith_k = db.TabCapitals.Where(Capital => Capital.Name.StartsWith("k")).Select(Capital => Capital.Name);   //TO DO                                       
                                          


               // Console.WriteLine($"Столицы, у которых название начи­нается с буквы k: {string.Join(",", capitalsStartWith_k)}");
               // Console.WriteLine();


                var areaCoutry = from Country in db.TabCountries
                                 where Country.Area > 500000 && Country.Area < 3000000
                                 select Country.Name;

                Console.WriteLine($"Страны, у которых площадь находится в указанном диапазоне: {string.Join(",", areaCoutry)}");
                Console.WriteLine();

                var populationCoutry = from Country in db.TabCountries
                                       where Country.Population >15000000
                                       select Country.Name;

                Console.WriteLine($"Страны, у которых количество жителей больше указанного числа: {string.Join(",", populationCoutry)}");
                Console.WriteLine();


            };
            using (var db = new host1323541_sbd06Context())
            {

                var topAreaCountries = (from Country in db.TabCountries
                                   orderby Country.Area descending
                                   select Country.Name).Take(5);

                Console.WriteLine($"Топ-5 стран по площади: {string.Join(",", topAreaCountries)}");
                Console.WriteLine();

                var topPopulationCities = (from Capital in db.TabCapitals
                                              orderby Capital.Population descending
                                              select Capital.Name).Take(5);

                Console.WriteLine($"Топ-5 столиц по количеству жителей: {string.Join(",", topPopulationCities)}");
                Console.WriteLine();

                var mostBigAreaCountry = (from Country in db.TabCountries
                                        orderby Country.Area descending
                                        select Country.Name).First();

                Console.WriteLine($"Страна с самой большой площадью: {mostBigAreaCountry}");
                Console.WriteLine();

                var mostBigPopulationCity = (from Capital in db.TabCapitals
                                             orderby Capital.Population descending
                                             select Capital.Name).First();

                Console.WriteLine($"Столица с самым большим количеством жителей: {mostBigPopulationCity}");
                Console.WriteLine();

                var mostSmallAreaEuropeCountry = (from Country in db.TabCountries
                                                  orderby Country.Area descending
                                                  select Country.Name).Last();

                Console.WriteLine($"Cтрана с самой маленькой площадью в Европе: {mostSmallAreaEuropeCountry}");
                Console.WriteLine();

                var middleAreaEuropeCountries = (from Country in db.TabCountries
                                                 where Country.PartOfTheWorld=="Europe"
                                                 select Country.Area).Average();

                Console.WriteLine($"Cредняя площадь стран в Европе: {middleAreaEuropeCountries}");
                Console.WriteLine();

                var allCountries = ((db.TabCountries.
                    GroupBy(p => p.PartOfTheWorld).
                    Select(p => new { PartOfTheWorld = p.Key, Count = p.Count() })).
                    OrderBy(p => p.Count).
                    Last()).PartOfTheWorld;

                Console.WriteLine($"Часть света с максимальным количеством стран: {allCountries}");
                Console.WriteLine();

                var Countries = db.TabCountries.
                    GroupBy(p => p.PartOfTheWorld).
                    Select(p => new { PartOfTheWorld = p.Key, Count = p.Count() });

                Console.WriteLine("Количество стран в каждой части света:");

                foreach (var item in Countries)
                {
                    Console.WriteLine($"{item.PartOfTheWorld} : {item.Count}");
                }
                
                Console.WriteLine();

            };
        }
    }
}

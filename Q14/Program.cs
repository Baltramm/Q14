using System;
using System.Collections.Generic;
using System.Linq;

namespace Q14
{
    class Program
    {

        static void Main(string[] args)
        {
            // Добавим Россию с её городами
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));


            var bigCities = from russianCity in russianCities
                            where russianCity.Population > 1000000
                            orderby russianCity.Population descending
                            select russianCity;

            foreach (var bigCity in bigCities)
                Console.WriteLine(bigCity.Name + " - " + bigCity.Population);


            var bigCitiess = russianCities.Where(c => c.Population > 1000000)
  .OrderByDescending(c => c.Population);
            var tenCities = from tenCitiess in russianCities where tenCitiess.Name.Length <= 10 orderby tenCitiess.Name.Length select tenCitiess;
        }

        // Создадим модель класс для города
        public class City
        {
            public City(string name, long population)
            {
                Name = name;
                Population = population;
            }

            public string Name { get; set; }
            public long Population { get; set; }
        }
    }
}

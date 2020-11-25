using System.Collections.Generic;

namespace Caching.Test.Model
{
    public class CarFactory
    {
        public static IEnumerable<Car> Create()
        {
            var cars = new List<Car>
            {
                new Car() { Brand = "BMW", Model = "3-Series", Year = 2012 },
                new Car() { Brand = "BMW", Model = "5-Series", Year = 2017 },
                new Car() { Brand = "Mercedes-Benz", Model = "CLA 63", Year = 2016 }
            };

            return cars;
        }
    }
}

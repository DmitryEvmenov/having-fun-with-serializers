using System.Collections.Generic;
using Cars;

namespace HavingFunWithSerializators
{
    static class CarsDataProvider
    {
        public static List<Car> GetCars()
            => new List<Car>
            {
                new LuxuryCar
                {
                    BrandName = "Limousine",
                    Color = CarColor.Black,
                    Weight = 2400
                },
                new LuxuryCar
                {
                    BrandName = "Mercedes",
                    Color = CarColor.White,
                    Weight = 2050
                },
                new SportCar
                {
                    BrandName = "BMW",
                    Color = CarColor.Blue,
                    Weight = 1600
                },
                new SportCar
                {
                    BrandName = "Porsche",
                    Color = CarColor.Red,
                    Weight = 1550
                },
                new Truck
                {
                    BrandName = "Iveco",
                    Color = CarColor.Black,
                    Weight = 4900
                }
            };
    }
}

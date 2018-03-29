using System;

namespace Cars
{
    [Serializable]
    public class SportCar : Car
    {
        public SportCar() : base(CarType.Sports)
        {
        }
    }
}

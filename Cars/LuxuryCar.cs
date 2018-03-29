using System;

namespace Cars
{
    [Serializable]
    public class LuxuryCar : Car
    {
        public LuxuryCar() : base(CarType.Luxury)
        {
        }
    }
}

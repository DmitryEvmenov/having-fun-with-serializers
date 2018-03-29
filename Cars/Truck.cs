using System;

namespace Cars
{
    [Serializable]
    public class Truck : Car
    {
        public Truck() : base(CarType.Truck)
        {
        }
    }
}

using System;
using System.Xml.Serialization;

namespace Cars
{
    [XmlInclude(typeof(LuxuryCar))]
    [XmlInclude(typeof(SportCar))]
    [XmlInclude(typeof(Truck))]
    [Serializable]
    public class Car
    {
        public CarType Type { get; set; }
        public int Weight { get; set; }
        public string BrandName { get; set; }
        public CarColor Color { get; set; }

        public Car()
        {
            
        }

        protected Car(CarType type)
        {
            Type = type;
        }
    }
}

using System.Xml.Serialization;

namespace Cars
{
    [XmlInclude(typeof(LuxuryCar))]
    [XmlInclude(typeof(SportCar))]
    [XmlInclude(typeof(Truck))]
    public abstract class Car
    {
        public CarType Type { get; }
        public int Weight { get; set; }
        public string BrandName { get; set; }
        public CarColor Color { get; set; }

        protected Car(CarType type)
        {
            Type = type;
        }
    }
}

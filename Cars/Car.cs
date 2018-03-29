namespace Cars
{
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

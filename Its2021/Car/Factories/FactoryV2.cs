namespace Its2021.Car
{
    public class FactoryV2 : CarFactory
    {
        public override Car Create(string plate, CarType type)
        {
            switch (type)
            {
                case CarType.Coupe:
                    return new Coupe(plate);
                case CarType.Suv:
                    return new Suv(plate);
                case CarType.Sportive:
                    return new Sportive(plate);
                default:
                    return default;
            }
        }
    }
}

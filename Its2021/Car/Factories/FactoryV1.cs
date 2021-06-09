namespace Its2021.Car
{
    public class FactoryV1 : CarFactory
    {
        public override Car Create(string plate, CarType type)
        {
            switch (type)
            {
                case CarType.Coupe:
                    return new Coupe(plate);
                case CarType.Suv:
                    return new Suv(plate);
                default:
                    return default;
            }
        }
    }
}

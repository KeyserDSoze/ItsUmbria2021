using System;

namespace Its2021.Builder
{
    public class BuilderWithDirector
    {
        public static void GetIstance()
        {
            Console.WriteLine("Airline");
            Console.WriteLine(AirplaneDirector.ConstructorAirLiner(2, 1, "white").ToString());
            Console.WriteLine("AirFighter");
            Console.WriteLine(AirplaneDirector.CostructorAirFighter(2, 2, 8, "black").ToString());
        }
    }

    public class AirplaneDirector {

        public static Airplane ConstructorAirLiner(int wings, int engines, string color) 
        {
            IAirplaneBuilder airplaneBuilder = new AirLineBuilder();
            airplaneBuilder.BuildChassis(color);
            airplaneBuilder.BuildEnginers(engines);
            airplaneBuilder.BuildWings(wings);
            airplaneBuilder.BuildWeapons(0);
            return airplaneBuilder.airplane;
        }

        public static Airplane CostructorAirFighter(int wings, int engines, int weapons, string color)
        {
            IAirplaneBuilder airplaneBuilder = new AirLineBuilder();
            airplaneBuilder.BuildChassis(color);
            airplaneBuilder.BuildEnginers(engines);
            airplaneBuilder.BuildWings(wings);
            airplaneBuilder.BuildWeapons(weapons);
            return airplaneBuilder.airplane;
        }
    }

    public class AirFighterBuilder : IAirplaneBuilder 
    {
        public Airplane airplane { get; set; } = new Airplane();

        public void BuildChassis(string color)
        {
            this.airplane.Color = color;
        }

        public void BuildWings(int numberOfWings)
        {
            this.airplane.NumberOfWings = numberOfWings;
        }

        public void BuildEnginers(int numberOfEnginers)
        {
            this.airplane.NumberOfEnginers = numberOfEnginers;
        }

        public void BuildWeapons(int numberOfWeapons)
        {
            this.airplane.NumberOfWeapons = numberOfWeapons;
        }


    }

    public class AirLineBuilder : IAirplaneBuilder
    {
        public Airplane airplane { get; set; } = new Airplane();

        public void BuildChassis(string color)
        {
            this.airplane.Color = color;
        }

        public void BuildWings(int numberOfWings)
        {
            this.airplane.NumberOfWings = numberOfWings;
        }

        public void BuildEnginers(int numberOfEnginers)
        {
            this.airplane.NumberOfEnginers = numberOfEnginers;
        }

        public void BuildWeapons(int numberOfWeapons)
        {
            this.airplane.NumberOfWeapons = numberOfWeapons;
        }
    }

    public interface IAirplaneBuilder
    {
        Airplane airplane { get; set; }

        void BuildWings(int numberOfWings);
        void BuildEnginers(int numberOfEnginers);
        void BuildWeapons(int numberOfWeapons);
        void BuildChassis(string color);
    }

    public class Airplane
    {
        public int NumberOfWings { get; set; }
        public int NumberOfWeapons { get; set; }
        public int NumberOfEnginers { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"This airplane has {this.NumberOfWings} wings, {this.NumberOfEnginers } engines, {this.NumberOfWeapons} weapons, {this.Color} color.";
        }
    }
}

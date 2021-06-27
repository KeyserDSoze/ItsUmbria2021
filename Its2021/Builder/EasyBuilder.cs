using System;

namespace Its2021.Builder
{
    public class EasyBuilder
    {
        public static Car GetIstance()
        {

            Car car = CarBuilder.CreateCar("superpower", 2500, 128);
            Console.WriteLine(car.ToString());
            return car;

        }

    }

    public class Car
    {
        private Engine _engine;
        private Wheel[] _wheels;
        private Chassis _chassis;

        public Engine Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        public Chassis Chassis
        {
            get { return _chassis; }
            set { _chassis = value; }
        }

        public Wheel WheelFrontLeft
        {
            get { return _wheels[0]; }
            set { _wheels[0] = value; }
        }
        public Wheel WheelFrontRight
        {
            get { return _wheels[1]; }
            set { _wheels[1] = value; }
        }
        public Wheel WheelBackLeft
        {
            get { return _wheels[2]; }
            set { _wheels[2] = value; }
        }
        public Wheel WheelBackRight
        {
            get { return _wheels[3]; }
            set { _wheels[3] = value; }
        }

        public Car()
        {
            _wheels = new Wheel[4];
        }

        public override string ToString()
        {
            return _wheels[0].ToString() + " / " +
                _wheels[1].ToString() + " / " +
                _wheels[2].ToString() + " / " +
                _wheels[3].ToString() + " / " +
                _engine.ToString() + " / " +
                _chassis.ToString();
        }
    }

    public class Engine
    {
        private string _name;
        private int _power;

        public Engine(string name, int power)
        {
            _name = name;
            _power = power;
        }

        public override string ToString()
        {
            return "Engine " + _name + " with power " + _power;
        }
    }

    public class Chassis
    {
        public Chassis() { }

        public override string ToString()
        {
            return "Chassis ";
        }
    }

    public class Wheel
    {
        private int _size;

        public Wheel(int size)
        {
            _size = size;
        }
        public override string ToString()
        {
            return "Wheel " + _size;
        }
    }

    public class CarBuilder
    {
        public static Car CreateCar(string engineName, int enginePower, int wheelsSize)
        {
            Car c = new Car();
            c.WheelFrontLeft = new Wheel(wheelsSize);
            c.WheelFrontRight = new Wheel(wheelsSize);
            c.WheelBackLeft = new Wheel(wheelsSize);
            c.WheelBackRight = new Wheel(wheelsSize);

            c.Engine = new Engine(engineName, enginePower);

            c.Chassis = new Chassis();

            return c;
        }
    }
}

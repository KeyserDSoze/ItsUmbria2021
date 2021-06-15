using Its2021.Car;
using Its2021.FlyWeightUML;
using Its2021.Geometry;
using Its2021.MultitonColor;
using Its2021.Noe;
using Its2021.SingletonColor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Its2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //GeometryRunner.Run();
            //NoeRunner.Run();
            //CarRunner.Run();
            //MultitonColorValue.Instance("sito1");
            //MultitonColorValue.Instance("sito2");
            //MultitonColorValue.Instance("sito3");
            //MultitonColorValue.Instance("sito4");
            FlyWeightRunner.Run();
            ////string aa = "";
            ////DateTime start = DateTime.UtcNow;
            ////StringBuilder a = new StringBuilder();
            ////for (int i = 0; i < 1_000_000; i++)
            ////{
            ////    a.Append("aaaaaa");
            ////}
            ////Console.WriteLine(DateTime.UtcNow.Subtract(start).TotalSeconds);
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.BackgroundColor = ColorValue.Instance().Background;
            //    Console.ForegroundColor = ColorValue.Instance().Foreground;
            //    //NoExpiringColorValue.Instance.Background;
            //    Console.WriteLine("dsadsadsadda");
            //}
            //UsersList usersList = new NosqlUsersList();
            //foreach(var user in usersList.Users)
            //{
            //    Console.BackgroundColor = ConsoleColor.Red;
            //    Console.WriteLine(user);
            //}
        }
    }
    public abstract class UsersList
    {
        public List<string> Users { get; set; }
    }
    public class MockedUsersList : UsersList
    {
        public MockedUsersList()
        {
            Users = new List<string>()
            {
                "Alessio",
                "Fabio",
                "Giovanni"
            };
        }
    }
    public class DbUsersList : UsersList
    {
        public DbUsersList()
        {
            //Request to DB
            Users = new List<string>()
            {
                "Alessio DB",
                "Fabio DB",
                "Giovanni DB"
            };
        }
    }
    public class NosqlUsersList : UsersList
    {
        public NosqlUsersList()
        {
            //Request to Nosql
            Users = new List<string>()
            {
                "Alessio Nosql",
                "Fabio Nosql",
                "Giovanni Nosql"
            };
        }
    }
}

using System;

namespace Its2021.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string.Compare("", "");
            //string c = string.Empty;
            //string e = "fffff";
            //Identity identity = new Identity();
            //Console.WriteLine("Dimmi il tuo nome: ");
            //identity.Name = Console.ReadLine();
            //Console.WriteLine("Dimmi il tuo cognome: ");
            //identity.Surname = Console.ReadLine();
            //Console.WriteLine("Dimmi la tua data di nascita: ");
            //identity.BirthDate = DateTime.Parse(Console.ReadLine());
            //identity.Show();

            DateTime start = DateTime.UtcNow;
            for (int i = 0; i < 100; i++)
                SingletonTest.Instance();
            Console.WriteLine(DateTime.UtcNow.Subtract(start).TotalSeconds);
        }
    }
}
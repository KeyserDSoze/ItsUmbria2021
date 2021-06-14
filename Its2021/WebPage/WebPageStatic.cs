using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Its2021.WebPage
{
    static class Output
    {
        static string[] Test = new string[4] { "FirstPage", "SecondPage", "ThirdPage", "FourthPage" };
        private static readonly object Semaphore = new object();
        public static void Run()
        {
            Console.WriteLine("Inserisci la frase che andrà nel div");
            string input = Console.ReadLine();
            Parallel.For(0, 100, i =>
            {
                lock (Semaphore)
                {
                    Console.BackgroundColor = Styling.Instance(Test[i % 4]).BackgroundColor;
                    Console.ForegroundColor = Styling.Instance(Test[i % 4]).ConsoleColor;
                    Console.WriteLine(string.Format(Styling.Instance(Test[i % 4]).Html, input, i.ToString()));
                }
            });
            Console.WriteLine(Styling.Counter);
        }
    }
}
static class StylingDatabase
{
    private static Styling FirstPage { get; } = new Styling(ConsoleColor.Black, ConsoleColor.White, "<div>{0}</div><div>{1}<div><div>{0}<div>");
    private static Styling SecondPage { get; } = new Styling(ConsoleColor.Blue, ConsoleColor.Red, "<h1>{0}</h1><div>{1}<div>");
    private static Styling ThirdPage { get; } = new Styling(ConsoleColor.Cyan, ConsoleColor.Green, "<h2>{0}</h2><div>{1}<div>");
    private static Styling FourthPage { get; } = new Styling(ConsoleColor.Yellow, ConsoleColor.DarkMagenta, "<h2>{1}</h2>");
    public static Styling GetStyling(string key)
    {
        Thread.Sleep(1000);
        if (key == "FirstPage")
            return FirstPage;
        else if (key == "SecondPage")
            return SecondPage;
        else if (key == "ThirdPage")
            return ThirdPage;
        else if (key == "FourthPage")
            return FourthPage;
        return null;
    }
}
class Styling
{
    public ConsoleColor ConsoleColor { get; }
    public ConsoleColor BackgroundColor { get; }
    public string Html { get; }
    public Styling(ConsoleColor consoleColor, ConsoleColor backgroundColor, string html)
    {
        this.ConsoleColor = consoleColor;
        this.BackgroundColor = backgroundColor;
        this.Html = html;
    }
}

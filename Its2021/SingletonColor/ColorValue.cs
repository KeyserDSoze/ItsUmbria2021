using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Its2021.SingletonColor
{
    public class Aa
    {
        public string A { get; }
        public string B { get; }
        public string C { get; }
        public Aa(string a, string b, string c)
        {
            A = a;
            B = b;
            C = c;
        }
    }
    public record Bb(string A, string B, string C);
    public class NoExpiringColorValue
    {
        public static NoExpiringColorValue Instance { get; } = new NoExpiringColorValue(ConsoleColor.Red, ConsoleColor.Yellow);
        private NoExpiringColorValue(ConsoleColor background, ConsoleColor foreground)
        {
            Background = background;
            Foreground = foreground;
        }
        public ConsoleColor Background { get; }
        public ConsoleColor Foreground { get; }
    }
    public class ColorValue
    {
        private static ColorValue instance;
        private ColorValue(ConsoleColor background, ConsoleColor foreground)
        {
            Background = background;
            Foreground = foreground;
        }
        private static DateTime ExpiringTime;
        private static readonly object Semaphore = new object();
        public ConsoleColor Background { get; }
        public ConsoleColor Foreground { get; }
        public static ColorValue Instance()
        {
            if (instance == null || DateTime.UtcNow > ExpiringTime)
            {
                lock (Semaphore)
                {
                    if (instance == null || DateTime.UtcNow > ExpiringTime)
                    {
                        //simulazione di richiesta ad un DB
                        Thread.Sleep(2000);
                        instance = new ColorValue(ConsoleColor.Red, ConsoleColor.Yellow);
                        ExpiringTime = DateTime.UtcNow.AddMinutes(1);
                    }
                }
            }
            return instance;
        }
    }
}

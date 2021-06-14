using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Its2021.MultitonColor
{
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
    public class MultitonColorValue
    {
        private static Dictionary<string, MultitonColorValue> instances = new Dictionary<string, MultitonColorValue>();
        private MultitonColorValue(ConsoleColor background, ConsoleColor foreground)
        {
            Background = background;
            Foreground = foreground;
        }
        //private static DateTime ExpiringTime;
        private static object Semaphore = new object();
        public ConsoleColor Background { get; }
        public ConsoleColor Foreground { get; }
        public static MultitonColorValue Instance(string key)
        {
            if (!instances.ContainsKey(key)/* || DateTime.UtcNow > ExpiringTime*/)
            {
                lock (Semaphore)
                {
                    if (!instances.ContainsKey(key)/* || DateTime.UtcNow > ExpiringTime*/)
                    {
                        //simulazione di richiesta ad un DB
                        Thread.Sleep(2000);
                        instances.Add(key, new MultitonColorValue(ConsoleColor.Red, ConsoleColor.Yellow));
                        //ExpiringTime = DateTime.UtcNow.AddMinutes(1);
                    }
                }
            }
            return instances[key];
        }
    }
}

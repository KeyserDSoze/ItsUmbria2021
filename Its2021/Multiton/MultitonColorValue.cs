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
        private static readonly Dictionary<string, MultitonColorValue> instances = new Dictionary<string, MultitonColorValue>();
        private MultitonColorValue(ConsoleColor background, ConsoleColor foreground)
        {
            Background = background;
            Foreground = foreground;
            ExpiringTime = DateTime.UtcNow.AddMinutes(1);
        }
        private readonly DateTime ExpiringTime;
        private static readonly object Semaphore = new object();
        public ConsoleColor Background { get; }
        public ConsoleColor Foreground { get; }
        public static MultitonColorValue Instance(string key)
        {
            if (!instances.ContainsKey(key) || DateTime.UtcNow > instances[key].ExpiringTime)
            {
                lock (Semaphore)
                {
                    if (!instances.ContainsKey(key) || DateTime.UtcNow > instances[key].ExpiringTime)
                    {
                        //simulazione di richiesta ad un DB
                        Thread.Sleep(2000);
                        if (instances.ContainsKey(key))
                            instances[key] = new MultitonColorValue(ConsoleColor.Red, ConsoleColor.Yellow);
                        else
                            instances.Add(key, new MultitonColorValue(ConsoleColor.Red, ConsoleColor.Yellow));
                    }
                }
            }
            return instances[key];
        }
    }
}

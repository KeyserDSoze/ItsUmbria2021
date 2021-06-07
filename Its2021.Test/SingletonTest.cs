using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Its2021.Test
{
    public class SingletonTest
    {
        private static SingletonTest Test;
        private SingletonTest() { }
        private static DateTime ExpiringTime;
        private static object Semaphore = new object();
        public ConsoleColor Background;
        public static SingletonTest Instance()
        {
            if (Test == null || DateTime.UtcNow > ExpiringTime)
            {
                lock (Semaphore)
                {
                    if (Test == null || DateTime.UtcNow > ExpiringTime)
                    {
                        //simulazione di richiesta ad un DB
                        Thread.Sleep(2000);
                        Test = new SingletonTest();
                        Test.Background = ConsoleColor.Red;
                        ExpiringTime = DateTime.UtcNow.AddMinutes(1);
                    }
                }
            }
            return Test;
        }
    }
}

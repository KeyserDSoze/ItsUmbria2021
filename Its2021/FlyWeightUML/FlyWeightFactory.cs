using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its2021.FlyWeightUML
{
    public static class FlyWeightRunner
    {
        public static void Run()
        {
            var client1 = new ClientFlyWeight();
            var a1 = client1.GetFlyWeight("a");
            var a2 = client1.GetFlyWeight("a");
            var b = client1.GetFlyWeight("b");
            var a3 = client1.GetFlyWeight("a");

            var client2 = new ClientFlyWeight();
            var a1Client2 = client2.GetFlyWeight("a");
            var a2Client2 = client2.GetFlyWeight("a");
            var a3Client2 = client2.GetFlyWeight("a");
            var a4Client2 = client2.GetFlyWeight("a");
        }
    }
    public abstract class FlyWeightFactory
    {
        public abstract FlyWeight GetFlyWeight(string key);
    }
    public abstract class FlyWeight
    {

    }
    public class MyFlyWeightObject : FlyWeight
    {

    }
    public class ClientFlyWeight : FlyWeightFactory
    {
        private readonly Dictionary<string, FlyWeight> FlyWeights = new Dictionary<string, FlyWeight>();
        private readonly object Semaphore = new object();
        public override FlyWeight GetFlyWeight(string key)
        {
            if (!FlyWeights.ContainsKey(key))
            {
                lock (Semaphore)
                {
                    if (!FlyWeights.ContainsKey(key))
                    {
                        FlyWeights.Add(key, new MyFlyWeightObject());
                    }
                }
            }
            return FlyWeights[key];
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS2021.DI.Test.Services
{
    public class FlyweightedService
    {
        private string Id { get; }
        public string Added { get; set; }
        public FlyweightedService()
            => Id = Guid.NewGuid().ToString("N");
        public override string ToString()
            => $"{Id}";
    }
}

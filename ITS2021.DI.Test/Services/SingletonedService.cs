using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS2021.DI.Test.Services
{
    public class SingletonedService
    {
        private string Id { get; }
        public SingletonedService()
            => Id = Guid.NewGuid().ToString("N");
        public override string ToString()
            => Id;
    }
}
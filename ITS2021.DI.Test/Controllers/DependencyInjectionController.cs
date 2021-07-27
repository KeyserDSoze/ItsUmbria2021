using ITS2021.DI.Test.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS2021.DI.Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DependencyInjectionController : ControllerBase
    {
        private readonly SingletonedService Singletoned1;
        private readonly SingletonedService Singletoned2;
        private readonly FlyweightedService Flyweighted1;
        private readonly FlyweightedService Flyweighted2;
        private readonly FactoriedService Factoried1;
        private readonly FactoriedService Factoried2;
        private readonly MyMiddleware MyMiddleware;
        public DependencyInjectionController(SingletonedService singletoned, FlyweightedService flyweighted, FactoriedService factoried,
            SingletonedService singletoned2, FlyweightedService flyweighted2, FactoriedService factoried2, MyMiddleware myMiddleware)
        {
            Singletoned1 = singletoned;
            Singletoned2 = singletoned2;
            Flyweighted1 = flyweighted;
            Flyweighted2 = flyweighted2;
            Factoried1 = factoried;
            Factoried2 = factoried2;
            MyMiddleware = myMiddleware;
        }

        [HttpGet]
        public string Get()
        {
            return $"Singleton: {Singletoned1}, Singleton2: {Singletoned2}, Flyweight: {Flyweighted1}, Flyweight2: {Flyweighted2}, Factory: {Factoried1}, Factory2: {Factoried2}, MyMiddleware: {MyMiddleware.A}";
        }
    }
}

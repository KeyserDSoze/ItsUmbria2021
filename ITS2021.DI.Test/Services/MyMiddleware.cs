using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS2021.DI.Test.Services
{
    public class MyMiddleware : IMiddleware
    {
        private readonly FlyweightedService Flyweighted;
        public string A { get; private set; }
        public MyMiddleware(FlyweightedService flyweighted)
        {
            Flyweighted = flyweighted;
            A = "aassasasa";
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (context.Request.Scheme == "https")
                Flyweighted.Added = "Sto aggiungendo un valore";
            await next.Invoke(context);
            A = "cambiamo valore";
        }
    }
    public class MyHttpsRedirection : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (context.Request.Scheme == "https")
                await next.Invoke(context);
            else
                context.Response.Redirect($"https://{context.Request.Host}");
        }
    }
}

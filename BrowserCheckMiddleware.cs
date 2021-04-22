using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetowyFizzBuzzv2
{
    public class BrowserCheckMiddleware
    {
        private RequestDelegate _next;
        public BrowserCheckMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IBrowserDetector browserDetector)
        {
            var browser = browserDetector.Browser;

            if (browser.Name== BrowserNames.EdgeChromium || browser.Name == BrowserNames.Edge || browser.Name == BrowserNames.InternetExplorer)
            {
                await context.Response.WriteAsync("Przeglądarka nie jest obsługiwana!!!");
            }
            else
            {
                await _next.Invoke(context);
            }
            //context.Response.WriteAsync("Orzech");
            //return _next(context);
        }
    }

    //public static class BrowserCheckMiddleExtension
    //{
    //    public static IApplicationBuilder UseMyMiddelware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<BrowserCheckMiddleware>();
    //    }
    //}
}

using Microsoft.AspNetCore.Hosting;
using System;

namespace WebHerokuPort
{
    public static class WeHostBuilderExtensions
    {
        /// <summary>
        /// Try use the port setting in enviroment heroku ($PORT) if exist.
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IWebHostBuilder UseHerokuPort(this IWebHostBuilder builder)
        {
            string port = Environment.GetEnvironmentVariable("PORT");

            if (string.IsNullOrEmpty(port))
            {
                return builder;
            }

            return builder.UseUrls($"http://+:{port}");
        }
    }
}

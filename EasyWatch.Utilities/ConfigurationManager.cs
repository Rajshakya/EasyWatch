using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace EasyWatch.Utilities
{
    public static class ConfigurationManager
    {
        static ConfigurationManager()
        {
            IConfigurationBuilder builder = new Microsoft.Extensions.Configuration.ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            //.AddJsonFile("appsettings." + environmentName + ".json", optional: false, reloadOnChange: true);
            _Configuration = builder.Build();
        }

        private static readonly IConfiguration _Configuration;
        //JobsDbContext
        public static string iEdPlanConnectionString => _Configuration["ConnectionStrings:iEasyWatchContext"];

        public static long LogischOrganizationId => Convert.ToInt64(_Configuration["LogischOrganizationId"]);
        //
        public static string PasswordSecret => _Configuration["PasswordSecret"];
        public static string DatawareHouseApiUrl => _Configuration["DatawareHouseApiUrl"];
    }
}

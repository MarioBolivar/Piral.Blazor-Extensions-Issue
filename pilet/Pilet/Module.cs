﻿using Microsoft.Extensions.DependencyInjection;

namespace Pilet
{
    public class Module
    {
        public static void Main()
        {
            // this entrypoint shold remain empty
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            // configure (local) dependency injection here
            //services.AddLocalization();
        }

        public static void ConfigureShared(IServiceCollection services)
        {
            // configure (globally shared) dependency injection here
        }
    }
}

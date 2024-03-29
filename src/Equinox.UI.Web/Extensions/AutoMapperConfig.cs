﻿using System;
using AutoMapper;
using Equinox.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Equinox.UI.Web.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            // services.AddAutoMapper();

            services.AddAutoMapper(typeof(Startup));

            // Registering Mappings automatically only works if the 
            // Automapper Profile classes are in ASP.NET project
            AutoMapperConfig.RegisterMappings();
        }
    }
}
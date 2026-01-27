// <copyright file="ServiceCollectionExtensions.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Registration
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.DependencyInjection;
    using NMediation.Dependencies;
    using System.Reflection;

    /// <summary>
    /// Extension methods for easy registration of Mediation Buddy.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Registers all assemblies for both NMediation and Mediation Buddy.
        /// </summary>
        /// <param name="services">An instance of the <see cref="IServiceCollection"/> interface.</param>
        /// <param name="assemblies">An <see cref="IEnumerable{T}"/> of Assemblies to register from.</param>
        /// <returns>The <see cref="IServiceCollection"/> to continue with.</returns>
        public static IServiceCollection AddMediationBuddy(this IServiceCollection services, params Assembly[] assemblies)
        {
            services.Configure<ApiBehaviorOptions>(options => options.SuppressModelStateInvalidFilter = true);

            services.AddNMediation(assemblies);

            return services;
        }
    }
}
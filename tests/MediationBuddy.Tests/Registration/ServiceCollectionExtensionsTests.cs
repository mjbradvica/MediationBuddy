// <copyright file="ServiceCollectionExtensionsTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Registration
{
    using MediationBuddy.AspNet.Registration;
    using Microsoft.Extensions.DependencyInjection;
    using NMediation.Abstractions;
    using System.Reflection;

    /// <summary>
    /// Tests for the <see cref="ServiceCollectionExtensions"/> class.
    /// </summary>
    [TestClass]
    public class ServiceCollectionExtensionsTests
    {
        /// <summary>
        /// Service registration is correct.
        /// </summary>
        [TestMethod]
        public void AddMediationBuddyRegistersCorrectly()
        {
            var services = new ServiceCollection();

            services.AddMediationBuddy(Assembly.GetExecutingAssembly());

            var provider = services.BuildServiceProvider();

            var mediation = provider.GetRequiredService<IMediation>();

            Assert.IsNotNull(mediation);
        }
    }
}
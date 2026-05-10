// <copyright file="TestApiController.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Controllers
{
    using MediationBuddy.AspNet.Controllers;
    using MediationBuddy.AspNet.ErrorHandling;
    using MediationBuddy.Tests.Common;
    using Microsoft.AspNetCore.Mvc;
    using NMediation.Abstractions;

    /// <inheritdoc />
    internal class TestApiController : MediationBuddyApiController
    {
        /// <inheritdoc />
        public TestApiController(IMediation mediation, ErrorTypes? errorTypes = null, Func<ApiErrorWrapper, IActionResult?>? extraOptions = null)
            : base(mediation, errorTypes, extraOptions)
        {
        }

        /// <summary>
        /// A test action used for controller testing.
        /// </summary>
        /// <param name="request">A test request object.</param>
        /// <returns>An IActionResult from the controller operation.</returns>
        [HttpPost]
        public async Task<IActionResult> Handle(TestObjectRequest request)
        {
            return await ExecuteOkObject(request);
        }
    }
}
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
    internal sealed class TestApiController : MediationBuddyApiController
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

        /// <summary>
        /// Test ok result.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpGet("ok-result")]
        public async Task<IActionResult> OkResult()
        {
            return await ExecuteOk(new TestObjectRequest());
        }

        /// <summary>
        /// Test ok object result.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpGet("ok-object-result")]
        public async Task<IActionResult> OkObjectResult()
        {
            return await ExecuteOkObject(new TestObjectRequest());
        }

        /// <summary>
        /// Test accepted result.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpPost("accepted-result")]
        public async Task<IActionResult> AcceptedResult()
        {
            return await ExecuteAccepted(new TestObjectRequest());
        }

        /// <summary>
        /// Test accepted object result.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpPost("accepted-object-result")]
        public async Task<IActionResult> AcceptedObjectResult()
        {
            return await ExecuteAcceptedObject(new TestObjectRequest(), _ => new Uri("https://www.test.com"));
        }

        /// <summary>
        /// Test created object result.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpPost("created-object-result")]
        public async Task<IActionResult> CreatedObjectResult()
        {
            return await ExecuteCreatedObject(new TestObjectRequest(), _ => new Uri("https://www.test.com"));
        }

        /// <summary>
        /// Test no content result.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpDelete("no-content-result")]
        public async Task<IActionResult> NoContentResult()
        {
            return await ExecuteNoContent(new TestObjectRequest());
        }
    }
}
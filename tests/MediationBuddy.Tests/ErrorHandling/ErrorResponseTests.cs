// <copyright file="ErrorResponseTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.ErrorHandling
{
    using MediationBuddy.AspNet.ErrorHandling;
    using MediationBuddy.Tests.Common;
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Tests the <see cref="ErrorResponse"/> class capabilities.
    /// </summary>
    [TestClass]
    public class ErrorResponseTests
    {
        /// <summary>
        /// Ensures the validation error properties are correct.
        /// </summary>
        [TestMethod]
        public void ValidationErrorHasCorrectProperties()
        {
            var type = new Uri("/errors/validation", UriKind.Relative);
            const string title = "Validation Error";
            var errors = new List<string> { "A validation constraint was not met." };
            const string detail = "The following errors were present: A validation constraint was not met.";
            var instance = new Uri("/people", UriKind.Relative);

            var errorResponse = ErrorResponse.ValidationError(type, errors, instance);

            Assert.AreEqual(type, errorResponse.Type);
            Assert.AreEqual(title, errorResponse.Title);
            Assert.AreEqual(StatusCodes.Status400BadRequest, errorResponse.Status);
            Assert.AreEqual(detail, errorResponse.Detail);
            Assert.AreEqual(instance, errorResponse.Instance);
        }

        /// <summary>
        /// Ensures the method returns an instance with the correct properties.
        /// </summary>
        [TestMethod]
        public void FromEnvelopeHasCorrectProperties()
        {
            var type = new Uri("/errors/general", UriKind.Relative);
            const string title = "error";
            const int status = 304;
            const string detail = "an error occurred";
            var instance = new Uri("/people", UriKind.Relative);

            var errorResponse = ErrorResponse.FromEnvelope(type, status, EnvelopeFactory.Failure<TestResponse>(status, title, detail), instance);

            Assert.AreEqual(type, errorResponse.Type);
            Assert.AreEqual(title, errorResponse.Title);
            Assert.AreEqual(status, errorResponse.Status);
            Assert.AreEqual(detail, errorResponse.Detail);
            Assert.AreEqual(instance, errorResponse.Instance);
        }

        /// <summary>
        /// Internal error response has the correct properties.
        /// </summary>
        [TestMethod]
        public void InternalErrorHasCorrectProperties()
        {
            var type = new Uri("/Error/GeneralError", UriKind.Relative);

            var instance = new Uri("/people", UriKind.Relative);

            var errorResponse = ErrorResponse.InternalError(type, instance);

            Assert.AreEqual(type, errorResponse.Type);
            Assert.AreEqual(500, errorResponse.Status);
            Assert.AreEqual(instance, errorResponse.Instance);
        }
    }
}
// <copyright file="ApiErrorWrapperTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.ErrorHandling
{
    using MediationBuddy.AspNet.ErrorHandling;
    using System;

    /// <summary>
    /// Tests for the customer error wrapper.
    /// </summary>
    [TestClass]
    public class ApiErrorWrapperTests
    {
        /// <summary>
        /// Ensures the wrapper properties are correct.
        /// </summary>
        [TestMethod]
        public void WrapperHasCorrectProperties()
        {
            const int status = 829;
            const string title = "title";
            const string detail = "detail";
            var instance = new Uri("Error/Custom", UriKind.Relative);

            var wrapper = ApiErrorWrapper.Instantiate(status, title, detail, instance, new ErrorTypes());

            Assert.AreEqual(status, wrapper.Status);
            Assert.AreEqual(title, wrapper.Title);
            Assert.AreEqual(detail, wrapper.Detail);
            Assert.AreEqual(instance, wrapper.Instance);
            Assert.IsNotNull(wrapper.ErrorTypes);
        }
    }
}
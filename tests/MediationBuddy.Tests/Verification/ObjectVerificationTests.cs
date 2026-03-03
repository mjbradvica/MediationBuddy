// <copyright file="ObjectVerificationTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Verification
{
    using MediationBuddy.AspNet.Verification;

    /// <summary>
    /// Tests for the <see cref="ObjectVerification"/> class.
    /// </summary>
    [TestClass]
    public class ObjectVerificationTests
    {
        /// <summary>
        /// Ensures an object with field fields returns a failure response.
        /// </summary>
        [TestMethod]
        public void EntityWithFailedFieldsReturnsFailure()
        {
            var result = ObjectVerification.Validate(new TestVerificationObject());

            Assert.IsTrue(result.Failed);
        }

        /// <summary>
        /// Ensures an object with all valid fields returns a success response.
        /// </summary>
        [TestMethod]
        public void EntityWithValidFieldsReturnsSuccess()
        {
            var testObject = new TestVerificationObject { Value = "value", };

            var result = ObjectVerification.Validate(testObject);

            Assert.IsFalse(result.Failed);
        }
    }
}
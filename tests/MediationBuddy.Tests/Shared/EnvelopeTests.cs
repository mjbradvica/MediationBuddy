// <copyright file="EnvelopeTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Shared
{
    /// <summary>
    /// Tests for the <see cref="Envelope{TResponse}"/> class.
    /// </summary>
    [TestClass]
    public class EnvelopeTests
    {
        /// <summary>
        /// Success envelope has correct properties.
        /// </summary>
        [TestMethod]
        public void SuccessEnvelopeHasCorrectProperties()
        {
            var response = string.Empty;

            var envelope = new Envelope<string>(response);

            Assert.AreEqual(response, envelope.Response);
            Assert.AreEqual(ApplicationStatus.Success, envelope.Status);
            Assert.AreEqual(string.Empty, envelope.Title);
            Assert.AreEqual(string.Empty, envelope.Detail);
        }

        /// <summary>
        /// Error envelope has correct properties.
        /// </summary>
        [TestMethod]
        public void ErrorEnvelopeHasCorrectProperties()
        {
            const int status = ApplicationStatus.AccountHasNotBeenVerified;
            const string title = "title";
            const string detail = "detail";

            var envelope = new Envelope<string>(status, title, detail);

            Assert.AreEqual(status, envelope.Status);
            Assert.AreEqual(title, envelope.Title);
            Assert.AreEqual(detail, envelope.Detail);
        }
    }
}
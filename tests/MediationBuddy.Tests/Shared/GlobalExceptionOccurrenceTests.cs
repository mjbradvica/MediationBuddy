// <copyright file="GlobalExceptionOccurrenceTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Shared
{
    /// <summary>
    /// Tests for the <see cref="GlobalExceptionOccurrence"/> class.
    /// </summary>
    [TestClass]
    public class GlobalExceptionOccurrenceTests
    {
        /// <summary>
        /// Occurrence has the correct properties.
        /// </summary>
        [TestMethod]
        public void GlobalExceptionOccurrenceHasCorrectProperties()
        {
            var exception = new ArgumentNullException();

            var occurrence = new GlobalExceptionOccurrence(exception);

            Assert.AreEqual(exception, occurrence.Exception);
            Assert.AreEqual(occurrence.DateTimeOffset.Date, DateTime.UtcNow.Date);
        }
    }
}
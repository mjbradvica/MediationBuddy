// <copyright file="GlobalExceptionOccurrence.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy
{
    using NMediation.Abstractions;

    /// <inheritdoc />
    public class GlobalExceptionOccurrence : IOccurrence
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalExceptionOccurrence"/> class.
        /// </summary>
        /// <param name="exception">A global exception occurrence.</param>
        public GlobalExceptionOccurrence(Exception exception)
        {
            Exception = exception;
            DateTimeOffset = DateTimeOffset.UtcNow;
        }

        /// <summary>
        /// Gets the exception that occurred during a request.
        /// </summary>
        public Exception Exception { get; }

        /// <summary>
        /// Gets a time stamp when the exception occurred.
        /// </summary>
        public DateTimeOffset DateTimeOffset { get; }
    }
}
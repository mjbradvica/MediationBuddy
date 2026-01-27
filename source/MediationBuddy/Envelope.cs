// <copyright file="Envelope.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy
{
    /// <summary>
    /// A class to wrap response in.
    /// </summary>
    /// <typeparam name="TResponse">The type of the response object.</typeparam>
    public class Envelope<TResponse> : IEnvelope<TResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Envelope{TResponse}"/> class.
        /// </summary>
        /// <param name="response">The response object.</param>
        public Envelope(TResponse response)
        {
            Response = response;
            Status = ApplicationStatus.Success;
            Title = string.Empty;
            Detail = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Envelope{TResponse}"/> class.
        /// </summary>
        /// <param name="statusCode">The status code of the failure.</param>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        public Envelope(int statusCode, string title, string detail)
        {
            Status = statusCode;
            Response = default!;
            Title = title;
            Detail = detail;
        }

        /// <inheritdoc/>
        public int Status { get; }

        /// <inheritdoc/>
        public string Title { get; }

        /// <inheritdoc/>
        public string Detail { get; }

        /// <inheritdoc/>
        public TResponse Response { get; }
    }
}
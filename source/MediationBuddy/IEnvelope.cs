// <copyright file="IEnvelope.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy
{
    /// <summary>
    /// Base interface for all application responses.
    /// </summary>
    /// <typeparam name="TResponse">The response type.</typeparam>
    public interface IEnvelope<out TResponse>
    {
        /// <summary>
        /// Gets a value indicating what status code is present.
        /// </summary>
        int Status { get; }

        /// <summary>
        /// Gets a brief description of the error, if one exists.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Gets the details of the error, if one exists.
        /// </summary>
        string Detail { get; }

        /// <summary>
        /// Gets a value indicating the Response.
        /// </summary>
        TResponse Response { get; }
    }
}
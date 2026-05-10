// <copyright file="ErrorResponse.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.ErrorHandling
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    /// <summary>
    /// A standardized error response based off the RFC 7807 standard.
    /// </summary>
    public class ErrorResponse
    {
        private ErrorResponse(Uri type, string title, int status, string detail, Uri instance)
        {
            Type = type;
            Title = title;
            Status = status;
            Detail = detail;
            Instance = instance;
        }

        /// <summary>
        /// Gets a Uri identifier that categorizes the error.
        /// </summary>
        [Required]
        public Uri Type { get; init; }

        /// <summary>
        /// Gets a human read-able message about the error.
        /// </summary>
        [Required]
        public string Title { get; init; }

        /// <summary>
        /// Gets the HTTP status code.
        /// </summary>
        [Required]
        public int Status { get; init; }

        /// <summary>
        /// Gets a detailed explanation of the error.
        /// </summary>
        [Required]
        public string Detail { get; init; }

        /// <summary>
        /// Gets a Uri that identifies where the error occurred.
        /// </summary>
        [Required]
        public Uri Instance { get; init; }

        /// <summary>
        /// Instantiates an instance of the <see cref="ErrorResponse"/> class or a specified error.
        /// </summary>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="type">The error type uri.</param>
        /// <param name="statusCode">The http status code.</param>
        /// <param name="envelope">The response envelope.</param>
        /// <param name="instance">The action uri.</param>
        /// <returns>A new ErrorResponse instance.</returns>
        public static ErrorResponse FromEnvelope<TResponse>(Uri type, int statusCode, IEnvelope<TResponse> envelope, Uri instance)
        {
            return new ErrorResponse(type, envelope.Title, statusCode, envelope.Detail, instance);
        }

        /// <summary>
        /// Instantiates an instance of the <see cref="ErrorResponse"/> class for a validation error.
        /// </summary>
        /// <param name="type">The error type uri.</param>
        /// <param name="errors">A list of validation errors.</param>
        /// <param name="instance">The action uri.</param>
        /// <returns>A new ErrorResponse instance.</returns>
        public static ErrorResponse ValidationError(Uri type, IEnumerable<string> errors, Uri instance)
        {
            var aggregateErrors = errors.Aggregate((final, next) => $"{final} {next}");

            return new ErrorResponse(
                type,
                "Validation Error",
                StatusCodes.Status400BadRequest,
                $"The following errors were present: {aggregateErrors}",
                instance);
        }

        /// <summary>
        /// Instantiates an instance of the <see cref="ErrorResponse"/> for an internal error.
        /// </summary>
        /// <param name="type">The error type uri.</param>
        /// <param name="instance">The action uri.</param>
        /// <returns>A new Error Response instance.</returns>
        public static ErrorResponse InternalError(Uri type, Uri instance)
        {
            return new ErrorResponse(
                type,
                "An internal error occurred",
                StatusCodes.Status500InternalServerError,
                "An error occurred during the operation. It's not you, it's me.",
                instance);
        }
    }
}
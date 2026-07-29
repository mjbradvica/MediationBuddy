// <copyright file="TestObjectRequest.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Common
{
    using System.ComponentModel.DataAnnotations;

    /// <inheritdoc />
    internal sealed class TestObjectRequest : IEnvelopePayload<TestResponse>
    {
        /// <summary>
        /// Gets the request instance property.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        public string RequestInstance { get; init; } = string.Empty;
    }
}
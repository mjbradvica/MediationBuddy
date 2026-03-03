// <copyright file="TestVerificationObject.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Verification
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Tests class for object verification.
    /// </summary>
    public class TestVerificationObject
    {
        /// <summary>
        /// Gets value to be verified by the validation methods.
        /// </summary>
        [Required(AllowEmptyStrings = false)]
        public string Value { get; init; } = string.Empty;
    }
}
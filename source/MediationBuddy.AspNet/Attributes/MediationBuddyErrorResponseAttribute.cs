// <copyright file="MediationBuddyErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using MediationBuddy.AspNet.ErrorHandling;
    using Microsoft.AspNetCore.Mvc;

    /// <inheritdoc />
    public class MediationBuddyErrorResponseAttribute : ProducesResponseTypeAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddyErrorResponseAttribute"/> class.
        /// </summary>
        /// <param name="statusCode">A status code for the response.</param>
        public MediationBuddyErrorResponseAttribute(int statusCode)
            : base(typeof(ErrorResponse), statusCode)
        {
        }
    }
}
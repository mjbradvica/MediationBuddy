// <copyright file="MediationBuddy500ErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using Microsoft.AspNetCore.Http;

    /// <inheritdoc />
    public class MediationBuddy500ErrorResponseAttribute : MediationBuddyErrorResponseAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddy500ErrorResponseAttribute"/> class.
        /// </summary>
        public MediationBuddy500ErrorResponseAttribute()
            : base(StatusCodes.Status500InternalServerError)
        {
        }
    }
}
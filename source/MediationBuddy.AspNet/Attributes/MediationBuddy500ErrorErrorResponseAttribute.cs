// <copyright file="MediationBuddy500ErrorErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using Microsoft.AspNetCore.Http;

    /// <inheritdoc />
    public class MediationBuddy500ErrorErrorResponseAttribute : MediationBuddyErrorResponseAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddy500ErrorErrorResponseAttribute"/> class.
        /// </summary>
        public MediationBuddy500ErrorErrorResponseAttribute()
            : base(StatusCodes.Status500InternalServerError)
        {
        }
    }
}
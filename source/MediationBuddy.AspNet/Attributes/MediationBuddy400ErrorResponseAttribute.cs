// <copyright file="MediationBuddy400ErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using Microsoft.AspNetCore.Http;

    /// <inheritdoc />
    public class MediationBuddy400ErrorResponseAttribute : MediationBuddyErrorResponseAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddy400ErrorResponseAttribute"/> class.
        /// </summary>
        public MediationBuddy400ErrorResponseAttribute()
            : base(StatusCodes.Status400BadRequest)
        {
        }
    }
}
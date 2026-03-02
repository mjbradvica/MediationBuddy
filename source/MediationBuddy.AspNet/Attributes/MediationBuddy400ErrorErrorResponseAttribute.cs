// <copyright file="MediationBuddy400ErrorErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using Microsoft.AspNetCore.Http;

    /// <inheritdoc />
    public class MediationBuddy400ErrorErrorResponseAttribute : MediationBuddyErrorResponseAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddy400ErrorErrorResponseAttribute"/> class.
        /// </summary>
        public MediationBuddy400ErrorErrorResponseAttribute()
            : base(StatusCodes.Status400BadRequest)
        {
        }
    }
}
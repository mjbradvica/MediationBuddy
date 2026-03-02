// <copyright file="MediationBuddy401ErrorErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using Microsoft.AspNetCore.Http;

    /// <inheritdoc />
    public class MediationBuddy401ErrorErrorResponseAttribute : MediationBuddyErrorResponseAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddy401ErrorErrorResponseAttribute"/> class.
        /// </summary>
        public MediationBuddy401ErrorErrorResponseAttribute()
            : base(StatusCodes.Status401Unauthorized)
        {
        }
    }
}
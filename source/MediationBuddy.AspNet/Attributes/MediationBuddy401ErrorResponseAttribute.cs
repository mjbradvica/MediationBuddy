// <copyright file="MediationBuddy401ErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using Microsoft.AspNetCore.Http;

    /// <inheritdoc />
    public class MediationBuddy401ErrorResponseAttribute : MediationBuddyErrorResponseAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddy401ErrorResponseAttribute"/> class.
        /// </summary>
        public MediationBuddy401ErrorResponseAttribute()
            : base(StatusCodes.Status401Unauthorized)
        {
        }
    }
}
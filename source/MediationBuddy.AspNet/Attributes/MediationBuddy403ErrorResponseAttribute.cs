// <copyright file="MediationBuddy403ErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using Microsoft.AspNetCore.Http;

    /// <inheritdoc />
    public class MediationBuddy403ErrorResponseAttribute : MediationBuddyErrorResponseAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddy403ErrorResponseAttribute"/> class.
        /// </summary>
        public MediationBuddy403ErrorResponseAttribute()
            : base(StatusCodes.Status403Forbidden)
        {
        }
    }
}
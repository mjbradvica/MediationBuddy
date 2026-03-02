// <copyright file="MediationBuddy403ErrorErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using Microsoft.AspNetCore.Http;

    /// <inheritdoc />
    public class MediationBuddy403ErrorErrorResponseAttribute : MediationBuddyErrorResponseAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddy403ErrorErrorResponseAttribute"/> class.
        /// </summary>
        public MediationBuddy403ErrorErrorResponseAttribute()
            : base(StatusCodes.Status403Forbidden)
        {
        }
    }
}
// <copyright file="MediationBuddy404ErrorErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using Microsoft.AspNetCore.Http;

    /// <inheritdoc />
    public class MediationBuddy404ErrorErrorResponseAttribute : MediationBuddyErrorResponseAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddy404ErrorErrorResponseAttribute"/> class.
        /// </summary>
        public MediationBuddy404ErrorErrorResponseAttribute()
            : base(StatusCodes.Status404NotFound)
        {
        }
    }
}
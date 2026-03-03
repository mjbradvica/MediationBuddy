// <copyright file="MediationBuddy404ErrorResponseAttribute.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Attributes
{
    using Microsoft.AspNetCore.Http;

    /// <inheritdoc />
    public class MediationBuddy404ErrorResponseAttribute : MediationBuddyErrorResponseAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddy404ErrorResponseAttribute"/> class.
        /// </summary>
        public MediationBuddy404ErrorResponseAttribute()
            : base(StatusCodes.Status404NotFound)
        {
        }
    }
}
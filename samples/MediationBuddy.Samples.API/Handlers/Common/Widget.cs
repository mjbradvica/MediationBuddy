// <copyright file="Widget.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.Common
{
    /// <summary>
    /// Sample object.
    /// </summary>
    public class Widget
    {
        /// <summary>
        /// Gets the widget identifier.
        /// </summary>
        public Guid Id { get; init; } = Guid.NewGuid();

        /// <summary>
        /// Gets the widget name.
        /// </summary>
        public string Name { get; init; } = string.Empty;
    }
}
// <copyright file="UpdateWidgetPayload.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.UpdateWidget
{
    using MediationBuddy.Samples.API.Handlers.Common;

    /// <inheritdoc />
    public class UpdateWidgetPayload : IEnvelopePayload<WidgetResponse>
    {
        /// <summary>
        /// Gets the identifier of the resource to update.
        /// </summary>
        public Guid Id { get; init; }

        /// <summary>
        /// Gets the updated name for the resource.
        /// </summary>
        public string UpdatedName { get; init; } = string.Empty;
    }
}
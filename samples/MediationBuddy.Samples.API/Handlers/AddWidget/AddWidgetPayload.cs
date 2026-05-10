// <copyright file="AddWidgetPayload.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.AddWidget
{
    using MediationBuddy.Samples.API.Handlers.Common;

    /// <inheritdoc />
    public class AddWidgetPayload : IEnvelopePayload<WidgetResponse>
    {
        /// <summary>
        /// Gets the widget name.
        /// </summary>
        public string Name { get; init; } = string.Empty;
    }
}
// <copyright file="GetWidgetByIdPayload.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.GetWidgetById
{
    using MediationBuddy.Samples.API.Handlers.Common;

    /// <inheritdoc />
    public class GetWidgetByIdPayload : IEnvelopePayload<WidgetResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetWidgetByIdPayload"/> class.
        /// </summary>
        /// <param name="id">A widget identifier.</param>
        public GetWidgetByIdPayload(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        public Guid Id { get; }
    }
}
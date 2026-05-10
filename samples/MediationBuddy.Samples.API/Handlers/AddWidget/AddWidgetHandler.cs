// <copyright file="AddWidgetHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.AddWidget
{
    using MediationBuddy.Samples.API.Handlers.Common;

    /// <inheritdoc />
    public class AddWidgetHandler : EnvelopeHandler<AddWidgetPayload, WidgetResponse>
    {
        /// <inheritdoc/>
        public override Task<IEnvelope<WidgetResponse>> Handle(AddWidgetPayload payload, CancellationToken cancellationToken)
        {
            var response = new WidgetResponse
            {
                Details = Guid.NewGuid().ToString(),
            };

            return Task.FromResult(Success(response));
        }
    }
}
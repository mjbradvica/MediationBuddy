// <copyright file="UpdateWidgetHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.UpdateWidget
{
    using MediationBuddy.Samples.API.Handlers.Common;

    /// <inheritdoc />
    public class UpdateWidgetHandler : EnvelopeHandler<UpdateWidgetPayload, WidgetResponse>
    {
        /// <inheritdoc/>
        public override Task<IEnvelope<WidgetResponse>> Handle(UpdateWidgetPayload payload, CancellationToken cancellationToken)
        {
            var response = new WidgetResponse
            {
                Details = $"{payload.Id} - {payload.UpdatedName}",
            };

            return Task.FromResult(Success(response));
        }
    }
}
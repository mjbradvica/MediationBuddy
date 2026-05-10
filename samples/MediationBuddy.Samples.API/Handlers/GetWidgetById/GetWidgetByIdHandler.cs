// <copyright file="GetWidgetByIdHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.GetWidgetById
{
    using MediationBuddy.Samples.API.Handlers.Common;

    /// <inheritdoc />
    public class GetWidgetByIdHandler : EnvelopeHandler<GetWidgetByIdPayload, WidgetResponse>
    {
        /// <inheritdoc/>
        public override Task<IEnvelope<WidgetResponse>> Handle(GetWidgetByIdPayload payload, CancellationToken cancellationToken)
        {
            var response = new WidgetResponse
            {
                Details = payload.Id.ToString(),
            };

            return Task.FromResult(Success(response));
        }
    }
}
// <copyright file="GetAllWidgetsHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.GetAllWidgets
{
    using MediationBuddy.Samples.API.Handlers.Common;

    /// <inheritdoc />
    public class GetAllWidgetsHandler : EnvelopeHandler<GetAllWidgetsPayload, IEnumerable<WidgetResponse>>
    {
        /// <inheritdoc/>
        public override Task<IEnvelope<IEnumerable<WidgetResponse>>> Handle(GetAllWidgetsPayload payload, CancellationToken cancellationToken)
        {
            var response = Enumerable.Range(0, 5)
                .Select(_ => new WidgetResponse { Details = Guid.NewGuid().ToString() })
                .ToList();

            return Task.FromResult(Success(response));
        }
    }
}
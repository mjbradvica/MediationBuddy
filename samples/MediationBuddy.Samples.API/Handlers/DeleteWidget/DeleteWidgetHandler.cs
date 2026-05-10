// <copyright file="DeleteWidgetHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.DeleteWidget
{
    using NMediation.Abstractions;

    /// <inheritdoc />
    public class DeleteWidgetHandler : EmptyEnvelopeHandler<DeleteWidgetPayload>
    {
        /// <inheritdoc/>
        public override Task<IEnvelope<Empty>> Handle(DeleteWidgetPayload payload, CancellationToken cancellationToken)
        {
            // Delete from persistence.
            return Task.FromResult(Success());
        }
    }
}
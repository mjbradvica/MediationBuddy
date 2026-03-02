// <copyright file="IEnvelopeHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy
{
    using NMediation.Abstractions;

    /// <inheritdoc />
    public interface IEnvelopeHandler<in TPayload, TResponse> : IPayloadHandler<TPayload, IEnvelope<TResponse>>
        where TPayload : IEnvelopePayload<TResponse>
    {
    }

    /// <inheritdoc />
    public interface IEnvelopeHandler<in TPayload> : IPayloadHandler<TPayload, IEnvelope<Empty>>
        where TPayload : IEnvelopePayload
    {
    }
}
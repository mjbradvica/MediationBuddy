// <copyright file="IEnvelopePayload.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy
{
    using NMediation.Abstractions;

    /// <summary>
    /// Designates a payload that will yield an envelope response.
    /// </summary>
    /// <typeparam name="TResponse">The type fo the response.</typeparam>
    public interface IEnvelopePayload<TResponse> : IPayload<IEnvelope<TResponse>>
    {
    }

    /// <summary>
    /// Designated a payload that will yield a void envelope.
    /// </summary>
    public interface IEnvelopePayload : IPayload<IEnvelope<Empty>>
    {
    }
}
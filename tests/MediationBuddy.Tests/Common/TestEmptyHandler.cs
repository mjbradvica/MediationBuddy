// <copyright file="TestEmptyHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Common
{
    using NMediation.Abstractions;
    using System;
    using System.Threading.Tasks;

    /// <inheritdoc />
    internal class TestEmptyHandler : EmptyEnvelopeHandler<TestEmptyRequest>
    {
        /// <inheritdoc/>
        public override Task<IEnvelope<Empty>> Handle(TestEmptyRequest payload, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
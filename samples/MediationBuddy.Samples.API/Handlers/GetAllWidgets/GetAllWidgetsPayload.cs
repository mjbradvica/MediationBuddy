// <copyright file="GetAllWidgetsPayload.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.GetAllWidgets
{
    using MediationBuddy.Samples.API.Handlers.Common;

    /// <inheritdoc />
    public class GetAllWidgetsPayload : IEnvelopePayload<IEnumerable<WidgetResponse>>
    {
    }
}
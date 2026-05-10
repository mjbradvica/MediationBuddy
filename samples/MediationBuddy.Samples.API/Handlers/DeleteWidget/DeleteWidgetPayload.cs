// <copyright file="DeleteWidgetPayload.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Handlers.DeleteWidget
{
    /// <inheritdoc />
    public class DeleteWidgetPayload : IEnvelopePayload
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteWidgetPayload"/> class.
        /// </summary>
        /// <param name="id">A widget identifier.</param>
        public DeleteWidgetPayload(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets the identifier of the resource to delete.
        /// </summary>
        public Guid Id { get; }
    }
}
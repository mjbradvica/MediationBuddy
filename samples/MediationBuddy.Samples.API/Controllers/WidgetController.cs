// <copyright file="WidgetController.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Controllers
{
    using MediationBuddy.AspNet.Attributes;
    using MediationBuddy.AspNet.Controllers;
    using MediationBuddy.Samples.API.Handlers.AddWidget;
    using MediationBuddy.Samples.API.Handlers.Common;
    using MediationBuddy.Samples.API.Handlers.DeleteWidget;
    using MediationBuddy.Samples.API.Handlers.GetAllWidgets;
    using MediationBuddy.Samples.API.Handlers.GetWidgetById;
    using MediationBuddy.Samples.API.Handlers.UpdateWidget;
    using Microsoft.AspNetCore.Mvc;
    using NMediation.Abstractions;

    /// <summary>
    /// Sample controller.
    /// </summary>
    [Route("widget")]
    [MediationBuddy500ErrorResponse]
    public class WidgetController : MediationBuddyApiController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetController"/> class.
        /// </summary>
        /// <param name="mediation">An instance of the <see cref="IMediation"/> interface.</param>
        public WidgetController(IMediation mediation)
            : base(mediation)
        {
        }

        /// <summary>
        /// Adds a widget to the persistence model.
        /// </summary>
        /// <param name="payload">A <see cref="AddWidgetPayload"/> object.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpPost("", Name = "AddWidget")]
        [ProducesResponseType<WidgetResponse>(StatusCodes.Status200OK)]
        public async Task<IActionResult> AddWidget(
            AddWidgetPayload payload,
            CancellationToken cancellationToken = default)
        {
            return await ExecuteCreatedObject(payload, response => new Uri(response.Details, UriKind.Relative), cancellationToken);
        }

        /// <summary>
        /// Attempts to retrieve a widget by an identifier.
        /// </summary>
        /// <param name="id">A widget identifier.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpGet("{id:guid}", Name = "GetWidgetById")]
        [MediationBuddy404ErrorResponse]
        [ProducesResponseType<WidgetResponse>(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetWidgetById(Guid id, CancellationToken cancellationToken = default)
        {
            return await ExecuteOkObject(new GetWidgetByIdPayload(id), cancellationToken);
        }

        /// <summary>
        /// Retrieves all widgets.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpGet("", Name = "GetAllWidgets")]
        public async Task<IActionResult> GetAllWidgets(CancellationToken cancellationToken = default)
        {
            return await ExecuteOkObject(new GetAllWidgetsPayload(), cancellationToken);
        }

        /// <summary>
        /// Updates an existing widget resource.
        /// </summary>
        /// <param name="payload">A <see cref="UpdateWidgetPayload"/> object.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpPut("", Name = "UpdateWidget")]
        [MediationBuddy404ErrorResponse]
        [ProducesResponseType<WidgetResponse>(StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateWidget(UpdateWidgetPayload payload, CancellationToken cancellationToken = default)
        {
            return await ExecuteOkObject(payload, cancellationToken);
        }

        /// <summary>
        /// Removes a widget from the persistence model.
        /// </summary>
        /// <param name="id">A widget identifier.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpDelete("{id:guid}")]
        [MediationBuddy404ErrorResponse]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteWidget(Guid id, CancellationToken cancellationToken = default)
        {
            return await ExecuteNoContent(new DeleteWidgetPayload(id), cancellationToken);
        }
    }
}
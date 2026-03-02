// <copyright file="MediationBuddyApiController.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.AspNet.Controllers
{
    using MediationBuddy.AspNet.ErrorHandling;
    using MediationBuddy.AspNet.Verification;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using NMediation.Abstractions;

    /// <summary>
    /// Base controller for passing and returning <see cref="IEnvelopePayload{T}"/> instances.
    /// </summary>
    public class MediationBuddyApiController : ControllerBase
    {
        private readonly ErrorTypes _errorTypes;
        private readonly Func<ApiErrorWrapper, IActionResult?>? _extraOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddyApiController"/> class.
        /// </summary>
        /// <param name="mediation">An instance of the <see cref="IMediation"/> interface.</param>
        /// <param name="errorTypes">An instance of the <see cref="ErrorTypes"/> class.</param>
        /// <param name="extraOptions">A <see cref="Func{TResult}"/> that will yield a custom <see cref="IActionResult"/> result.</param>
        public MediationBuddyApiController(IMediation mediation, ErrorTypes? errorTypes = null, Func<ApiErrorWrapper, IActionResult?>? extraOptions = null)
        {
            Mediation = mediation;
            _errorTypes = errorTypes ?? new ErrorTypes();
            _extraOptions = extraOptions;
        }

        /// <summary>
        /// Gets the Mediation instance.
        /// </summary>
        protected IMediation Mediation { get; }

        /// <summary>
        /// Handles a request with a pre-defined <see cref="OkResult"/>.
        /// </summary>
        /// <typeparam name="TResponse">The type of the envelope response.</typeparam>
        /// <param name="payload">A <see cref="IPayload{TResponse}"/> that returns an <see cref="IEnvelope{TResponse}"/> instance.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that yields a <see cref="IActionResult"/>.</returns>
        protected async Task<IActionResult> ExecuteOk<TResponse>(IPayload<IEnvelope<TResponse>> payload, CancellationToken cancellationToken = default)
        {
            return await ExecuteRequest(payload, _ => new OkResult(), cancellationToken);
        }

        /// <summary>
        /// Handles a request with a pre-defined <see cref="OkObjectResult"/>.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="payload">A <see cref="IPayload{TResponse}"/> that returns an <see cref="IEnvelope{TResponse}"/> instance.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that yields a <see cref="IActionResult"/>.</returns>
        protected async Task<IActionResult> ExecuteOkObject<TResponse>(IPayload<IEnvelope<TResponse>> payload, CancellationToken cancellationToken = default)
        {
            return await ExecuteRequest(payload, response => new OkObjectResult(response), cancellationToken);
        }

        /// <summary>
        /// Handles a request with a pre-defined <see cref="AcceptedResult"/>.
        /// </summary>
        /// <typeparam name="TResponse">The type of the envelope response.</typeparam>
        /// <param name="payload">A <see cref="IPayload{TResponse}"/> that returns an <see cref="IEnvelope{TResponse}"/> instance.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that yields a <see cref="IActionResult"/>.</returns>
        protected async Task<IActionResult> ExecuteAccepted<TResponse>(IPayload<IEnvelope<TResponse>> payload, CancellationToken cancellationToken = default)
        {
            return await ExecuteRequest(payload, _ => new AcceptedResult(), cancellationToken);
        }

        /// <summary>
        /// Handles a request with a pre-defined <see cref="AcceptedResult"/>.
        /// </summary>
        /// <typeparam name="TResponse">The type of the envelope response.</typeparam>
        /// <param name="payload">A <see cref="IPayload{TResponse}"/> that returns an <see cref="IEnvelope{TResponse}"/> instance.</param>
        /// <param name="responseFunc">A <see cref="Func{TResult}"/> that yields a <see cref="Uri"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that yields a <see cref="IActionResult"/>.</returns>
        protected async Task<IActionResult> ExecuteAccepted<TResponse>(IPayload<IEnvelope<TResponse>> payload, Func<TResponse, Uri> responseFunc, CancellationToken cancellationToken = default)
        {
            return await ExecuteRequest(payload, response => new AcceptedResult(responseFunc.Invoke(response), null), cancellationToken);
        }

        /// <summary>
        /// Handles a request with a pre-defined <see cref="AcceptedResult"/>.
        /// </summary>
        /// <typeparam name="TResponse">The type of the envelope response.</typeparam>
        /// <param name="payload">A <see cref="IPayload{TResponse}"/> that returns an <see cref="IEnvelope{TResponse}"/> instance.</param>
        /// <param name="responseFunc">A <see cref="Func{TResult}"/> that yields a <see cref="Uri"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that yields a <see cref="IActionResult"/>.</returns>
        protected async Task<IActionResult> ExecuteAcceptedObject<TResponse>(IPayload<IEnvelope<TResponse>> payload, Func<TResponse, Uri> responseFunc, CancellationToken cancellationToken = default)
        {
            return await ExecuteRequest(payload, response => new AcceptedResult(responseFunc.Invoke(response), response), cancellationToken);
        }

        /// <summary>
        /// Handles a request with a pre-defined <see cref="CreatedResult"/>.
        /// </summary>
        /// <typeparam name="TResponse">The type of the envelope response.</typeparam>
        /// <param name="payload">A <see cref="IPayload{TResponse}"/> that returns an <see cref="IEnvelope{TResponse}"/> instance.</param>
        /// <param name="responseFunc">A <see cref="Func{TResult}"/> that yields a <see cref="Uri"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that yields a <see cref="IActionResult"/>.</returns>
        protected async Task<IActionResult> ExecuteCreatedObject<TResponse>(IPayload<IEnvelope<TResponse>> payload, Func<TResponse, Uri> responseFunc, CancellationToken cancellationToken = default)
        {
            return await ExecuteRequest(payload, response => new CreatedResult(responseFunc.Invoke(response), response), cancellationToken);
        }

        /// <summary>
        /// Handles a request with a pre-defined <see cref="NoContentResult"/>.
        /// </summary>
        /// <typeparam name="TResponse">The type of the envelope response.</typeparam>
        /// <param name="payload">A <see cref="IPayload{TResponse}"/> that returns an <see cref="IEnvelope{TResponse}"/> instance.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation that yields a <see cref="IActionResult"/>.</returns>
        protected async Task<IActionResult> ExecuteNoContent<TResponse>(IPayload<IEnvelope<TResponse>> payload, CancellationToken cancellationToken = default)
        {
            return await ExecuteRequest(payload, _ => new NoContentResult(), cancellationToken);
        }

        /// <summary>
        /// Accepts a request and executes it alongside common tasks used in a web request pipeline.
        /// </summary>
        /// <typeparam name="TResponse">The response type being returned from the controller action.</typeparam>
        /// <param name="request">The request object being sent to the execution pipeline.</param>
        /// <param name="responseFunc">A function that will accept a response object and return a web response.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/>.</param>
        /// <returns>A <see cref="Task"/> of type <see cref="IActionResult"/> representing the end successResult of the request object.</returns>
        protected async Task<IActionResult> ExecuteRequest<TResponse>(
            IPayload<IEnvelope<TResponse>> request,
            Func<TResponse, IActionResult> responseFunc,
            CancellationToken cancellationToken = default)
        {
            IActionResult response;

            var currentRoute = new Uri(HttpContext.Request.Path.Value ?? _errorTypes.General.ToString(), UriKind.Relative);

            var validationResult = ObjectVerification.Validate(request);
            if (validationResult.Failed)
            {
                return BadRequest(ErrorResponse.ValidationError(_errorTypes.ValidationConstraintNotMet, validationResult.Errors, currentRoute));
            }

            try
            {
                var envelope = await Mediation.Mediate(request, cancellationToken);

                response = DetermineResponse(envelope, responseFunc.Invoke(envelope.Response), currentRoute, _extraOptions);
            }
            catch (Exception exception)
            {
                await Mediation.Publish(new GlobalExceptionOccurrence(exception), cancellationToken);

                return StatusCode(StatusCodes.Status500InternalServerError, ErrorResponse.InternalError(_errorTypes.General, currentRoute));
            }

            return response;
        }

        private IActionResult DetermineResponse<TResponse>(IEnvelope<TResponse> envelope, IActionResult successResult, Uri currentRoute, Func<ApiErrorWrapper, IActionResult?>? additionalOptions = null)
        {
            var result = additionalOptions?.Invoke(ApiErrorWrapper.Instantiate(envelope.Status, envelope.Title, envelope.Detail, currentRoute, _errorTypes));

            if (result != null)
            {
                return result;
            }

            return envelope.Status switch
            {
                ApplicationStatus.Success => successResult,
                ApplicationStatus.GeneralError => StatusCode(StatusCodes.Status500InternalServerError, ErrorResponse.FromEnvelope(_errorTypes.General, StatusCodes.Status500InternalServerError, envelope, currentRoute)),
                ApplicationStatus.OperationCouldNotBeCompleted => StatusCode(StatusCodes.Status500InternalServerError, ErrorResponse.FromEnvelope(_errorTypes.OperationCouldNotBeCompleted, StatusCodes.Status500InternalServerError, envelope, currentRoute)),
                ApplicationStatus.EntityWasNotFound => NotFound(ErrorResponse.FromEnvelope(_errorTypes.EntityWasNotFound, StatusCodes.Status404NotFound, envelope, currentRoute)),
                ApplicationStatus.ConflictWithOtherResource => Conflict(ErrorResponse.FromEnvelope(_errorTypes.ConflictWithOtherResource, StatusCodes.Status409Conflict, envelope, currentRoute)),
                ApplicationStatus.ValidationConstraintNotMet => BadRequest(ErrorResponse.FromEnvelope(_errorTypes.ValidationConstraintNotMet, StatusCodes.Status400BadRequest, envelope, currentRoute)),
                ApplicationStatus.PreConditionNotMet => BadRequest(ErrorResponse.FromEnvelope(_errorTypes.PreConditionNotMet, StatusCodes.Status400BadRequest, envelope, currentRoute)),
                ApplicationStatus.PostConditionNotMet => BadRequest(ErrorResponse.FromEnvelope(_errorTypes.PostConditionNotMet, StatusCodes.Status400BadRequest, envelope, currentRoute)),
                ApplicationStatus.CouldNotProcessRequest => UnprocessableEntity(ErrorResponse.FromEnvelope(_errorTypes.CouldNotProcessRequest, StatusCodes.Status422UnprocessableEntity, envelope, currentRoute)),
                ApplicationStatus.UserDoesNotExist => NotFound(ErrorResponse.FromEnvelope(_errorTypes.UserDoesNotExist, StatusCodes.Status404NotFound, envelope, currentRoute)),
                ApplicationStatus.UserCouldNotBeCreated => StatusCode(StatusCodes.Status500InternalServerError, ErrorResponse.FromEnvelope(_errorTypes.UserCouldNotBeCreated, StatusCodes.Status500InternalServerError, envelope, currentRoute)),
                ApplicationStatus.UsernameAlreadyExists => Conflict(ErrorResponse.FromEnvelope(_errorTypes.UsernameAlreadyExists, StatusCodes.Status409Conflict, envelope, currentRoute)),
                ApplicationStatus.EmailIsAlreadyUsed => Conflict(ErrorResponse.FromEnvelope(_errorTypes.EmailIsAlreadyUsed, StatusCodes.Status409Conflict, envelope, currentRoute)),
                ApplicationStatus.PasswordIsIncorrect => BadRequest(ErrorResponse.FromEnvelope(_errorTypes.PasswordIsIncorrect, StatusCodes.Status400BadRequest, envelope, currentRoute)),
                ApplicationStatus.PasswordDoesNotMeetRequirements => BadRequest(ErrorResponse.FromEnvelope(_errorTypes.PasswordDoesNotMeetRequirements, StatusCodes.Status400BadRequest, envelope, currentRoute)),
                ApplicationStatus.TooManyRecentAttempts => StatusCode(StatusCodes.Status429TooManyRequests, ErrorResponse.FromEnvelope(_errorTypes.TooManyRecentAttempts, StatusCodes.Status429TooManyRequests, envelope, currentRoute)),
                ApplicationStatus.AccountIsLockedOut => StatusCode(StatusCodes.Status423Locked, ErrorResponse.FromEnvelope(_errorTypes.AccountIsLockedOut, StatusCodes.Status423Locked, envelope, currentRoute)),
                ApplicationStatus.AccountHasNotBeenVerified => StatusCode(StatusCodes.Status403Forbidden, ErrorResponse.FromEnvelope(_errorTypes.AccountHasNotBeenVerified, StatusCodes.Status403Forbidden, envelope, currentRoute)),
                ApplicationStatus.EmailHasNotBeenVerified => StatusCode(StatusCodes.Status403Forbidden, ErrorResponse.FromEnvelope(_errorTypes.EmailHasNotBeenVerified, StatusCodes.Status403Forbidden, envelope, currentRoute)),
                ApplicationStatus.TwoFactorCodeIncorrect => BadRequest(ErrorResponse.FromEnvelope(_errorTypes.TwoFactorCodeIncorrect, StatusCodes.Status400BadRequest, envelope, currentRoute)),
                ApplicationStatus.UnauthorizedUser => StatusCode(StatusCodes.Status401Unauthorized, ErrorResponse.FromEnvelope(_errorTypes.UnauthorizedUser, StatusCodes.Status401Unauthorized, envelope, currentRoute)),
                ApplicationStatus.ContentIsForbidden => StatusCode(StatusCodes.Status403Forbidden, ErrorResponse.FromEnvelope(_errorTypes.ContentIsForbidden, StatusCodes.Status403Forbidden, envelope, currentRoute)),
                ApplicationStatus.GeneralAuthError => StatusCode(StatusCodes.Status401Unauthorized, ErrorResponse.FromEnvelope(_errorTypes.GeneralAuthError, StatusCodes.Status401Unauthorized, envelope, currentRoute)),
                ApplicationStatus.AuthenticationChallenged => StatusCode(StatusCodes.Status401Unauthorized, ErrorResponse.FromEnvelope(_errorTypes.AuthenticationChallenged, StatusCodes.Status401Unauthorized, envelope, currentRoute)),
                _ => StatusCode(StatusCodes.Status500InternalServerError, ErrorResponse.InternalError(_errorTypes.General, currentRoute)),
            };
        }
    }
}
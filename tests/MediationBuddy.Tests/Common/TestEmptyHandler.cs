// <copyright file="TestEmptyHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Common
{
    using NMediation.Abstractions;
    using System;
    using System.Threading.Tasks;

    /// <inheritdoc />
    internal sealed class TestEmptyHandler : EmptyEnvelopeHandler<TestEmptyRequest>
    {
        /// <inheritdoc/>
        public override Task<IEnvelope<Empty>> Handle(TestEmptyRequest payload, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Test success response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> SuccessResponse()
        {
            return Success();
        }

        /// <summary>
        /// Test failure response.
        /// </summary>
        /// <param name="statusCode">A status code to pass.</param>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> FailureResponse(int statusCode)
        {
            return Failure(statusCode);
        }

        /// <summary>
        /// Test general error response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> GeneralErrorResponse()
        {
            return GeneralError();
        }

        /// <summary>
        /// Test operation could not be completed response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> OperationCouldNotBeCompletedResponse()
        {
            return OperationCouldNotBeCompleted();
        }

        /// <summary>
        /// Test entity was not found response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> EntityWasNotFoundResponse()
        {
            return EntityWasNotFound();
        }

        /// <summary>
        /// Test conflict with other resource response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> ConflictWithOtherResourceResponse()
        {
            return ConflictWithOtherResource();
        }

        /// <summary>
        /// Test validation constraint not met response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> ValidationConstraintNotMetResponse()
        {
            return ValidationConstraintNotMet();
        }

        /// <summary>
        /// Test pre-condition not met response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> PreConditionNotMetResponse()
        {
            return PreConditionNotMet();
        }

        /// <summary>
        /// Post-condition not met response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> PostConditionNotMetResponse()
        {
            return PostConditionNotMet();
        }

        /// <summary>
        /// Could not process request response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> CouldNotProcessRequestResponse()
        {
            return CouldNotProcessRequest();
        }

        /// <summary>
        /// User does not exist response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> UserDoesNotExistResponse()
        {
            return UserDoesNotExist();
        }

        /// <summary>
        /// User could not be created response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> UserCouldNotBeCreatedResponse()
        {
            return UserCouldNotBeCreated();
        }

        /// <summary>
        /// Username already exists response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> UsernameAlreadyExistsResponse()
        {
            return UsernameAlreadyExists();
        }

        /// <summary>
        /// Email is already used response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> EmailIsAlreadyUsedResponse()
        {
            return EmailIsAlreadyUsed();
        }

        /// <summary>
        /// Password is incorrect response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> PasswordIsIncorrectResponse()
        {
            return PasswordIsIncorrect();
        }

        /// <summary>
        /// Password does not meet requirements response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> PasswordDoesNotMeetRequirementsResponse()
        {
            return PasswordDoesNotMeetRequirements();
        }

        /// <summary>
        /// Too many recent attempts response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> TooManyRecentAttemptsResponse()
        {
            return TooManyRecentAttempts();
        }

        /// <summary>
        /// Account is locked out response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> AccountIsLockedOutResponse()
        {
            return AccountIsLockedOut();
        }

        /// <summary>
        /// Account has not been verified response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> AccountHasNotBeenVerifiedResponse()
        {
            return AccountHasNotBeenVerified();
        }

        /// <summary>
        /// Email has not been verified response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> EmailHasNotBeenVerifiedResponse()
        {
            return EmailHasNotBeenVerified();
        }

        /// <summary>
        /// Two factory code is incorrect response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> TwoFactorCodeIsIncorrectResponse()
        {
            return TwoFactorCodeIsIncorrect();
        }

        /// <summary>
        /// Unauthorized user response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> UnauthorizedUserResponse()
        {
            return UnauthorizedUser();
        }

        /// <summary>
        /// Content is forbidden response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> ContentIsForbiddenResponse()
        {
            return ContentIsForbidden();
        }

        /// <summary>
        /// General auth code response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> GeneralAuthErrorResponse()
        {
            return GeneralAuthError();
        }

        /// <summary>
        /// Authentication challenged response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<Empty> AuthenticationChallengedResponse()
        {
            return AuthenticationChallenged();
        }
    }
}
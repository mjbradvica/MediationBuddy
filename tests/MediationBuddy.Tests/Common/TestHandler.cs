// <copyright file="TestHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Common
{
    /// <inheritdoc />
    internal sealed class TestHandler : EnvelopeHandler<TestObjectRequest, TestResponse>
    {
        /// <inheritdoc/>
        public override Task<IEnvelope<TestResponse>> Handle(TestObjectRequest payload, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Test success response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> SuccessResponse()
        {
            return Success(new TestResponse());
        }

        /// <summary>
        /// Test failure response.
        /// </summary>
        /// <param name="statusCode">A status code to pass.</param>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> FailureResponse(int statusCode)
        {
            return Failure(statusCode);
        }

        /// <summary>
        /// Test general error response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> GeneralErrorResponse()
        {
            return GeneralError();
        }

        /// <summary>
        /// Test operation could not be completed response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> OperationCouldNotBeCompletedResponse()
        {
            return OperationCouldNotBeCompleted();
        }

        /// <summary>
        /// Test entity was not found response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> EntityWasNotFoundResponse()
        {
            return EntityWasNotFound();
        }

        /// <summary>
        /// Test conflict with other resource response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> ConflictWithOtherResourceResponse()
        {
            return ConflictWithOtherResource();
        }

        /// <summary>
        /// Test validation constraint not met response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> ValidationConstraintNotMetResponse()
        {
            return ValidationConstraintNotMet();
        }

        /// <summary>
        /// Test pre-condition not met response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> PreConditionNotMetResponse()
        {
            return PreConditionNotMet();
        }

        /// <summary>
        /// Post-condition not met response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> PostConditionNotMetResponse()
        {
            return PostConditionNotMet();
        }

        /// <summary>
        /// Could not process request response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> CouldNotProcessRequestResponse()
        {
            return CouldNotProcessRequest();
        }

        /// <summary>
        /// User does not exist response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> UserDoesNotExistResponse()
        {
            return UserDoesNotExist();
        }

        /// <summary>
        /// User could not be created response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> UserCouldNotBeCreatedResponse()
        {
            return UserCouldNotBeCreated();
        }

        /// <summary>
        /// Username already exists response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> UsernameAlreadyExistsResponse()
        {
            return UsernameAlreadyExists();
        }

        /// <summary>
        /// Email is already used response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> EmailIsAlreadyUsedResponse()
        {
            return EmailIsAlreadyUsed();
        }

        /// <summary>
        /// Password is incorrect response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> PasswordIsIncorrectResponse()
        {
            return PasswordIsIncorrect();
        }

        /// <summary>
        /// Password does not meet requirements response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> PasswordDoesNotMeetRequirementsResponse()
        {
            return PasswordDoesNotMeetRequirements();
        }

        /// <summary>
        /// Too many recent attempts response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> TooManyRecentAttemptsResponse()
        {
            return TooManyRecentAttempts();
        }

        /// <summary>
        /// Account is locked out response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> AccountIsLockedOutResponse()
        {
            return AccountIsLockedOut();
        }

        /// <summary>
        /// Account has not been verified response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> AccountHasNotBeenVerifiedResponse()
        {
            return AccountHasNotBeenVerified();
        }

        /// <summary>
        /// Email has not been verified response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> EmailHasNotBeenVerifiedResponse()
        {
            return EmailHasNotBeenVerified();
        }

        /// <summary>
        /// Two factory code is incorrect response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> TwoFactorCodeIsIncorrectResponse()
        {
            return TwoFactorCodeIsIncorrect();
        }

        /// <summary>
        /// Unauthorized user response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> UnauthorizedUserResponse()
        {
            return UnauthorizedUser();
        }

        /// <summary>
        /// Content is forbidden response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> ContentIsForbiddenResponse()
        {
            return ContentIsForbidden();
        }

        /// <summary>
        /// General auth code response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> GeneralAuthErrorResponse()
        {
            return GeneralAuthError();
        }

        /// <summary>
        /// Authentication challenged response.
        /// </summary>
        /// <returns>An <see cref="IEnvelope{TResponse}"/>.</returns>
        public IEnvelope<TestResponse> AuthenticationChallengedResponse()
        {
            return AuthenticationChallenged();
        }
    }
}
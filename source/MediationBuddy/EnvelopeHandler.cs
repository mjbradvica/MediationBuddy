// <copyright file="EnvelopeHandler.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy
{
    /// <summary>
    /// An Envelope handler that will yield an envelope response.
    /// </summary>
    /// <typeparam name="TPayload">The type of the payload.</typeparam>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    public abstract class EnvelopeHandler<TPayload, TResponse> : IEnvelopeHandler<TPayload, TResponse>
        where TPayload : IEnvelopePayload<TResponse>
    {
        /// <inheritdoc />
        public abstract Task<IEnvelope<TResponse>> Handle(TPayload payload, CancellationToken cancellationToken);

        /// <summary>
        /// Factory function for success Envelope.
        /// </summary>
        /// <param name="response">The response object.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> Success(TResponse response)
        {
            return EnvelopeFactory.Success(response);
        }

        /// <summary>
        /// Factory function for a failed Envelope.
        /// </summary>
        /// <param name="statusCode">The status code of the failure.</param>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> Failure(int statusCode, string title = "A failure occurred.", string detail = "No details are available for the failure.")
        {
            return new Envelope<TResponse>(statusCode, title, detail);
        }

        /// <summary>
        /// Function to return a general error of no real description.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> GeneralError(
            string title = "General error occurred.",
            string detail = "A non-description fault happened somewhere along the process.")
        {
            return EnvelopeFactory.GeneralError<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return an operation could not be completed error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> OperationCouldNotBeCompleted(
            string title = "Operation could not be completed.",
            string detail = "The operation was unable to finish in its entirety.")
        {
            return EnvelopeFactory.OperationCouldNotBeCompleted<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return an entity not found error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> EntityWasNotFound(
            string title = "The entity could not be found.",
            string detail = "The system was unable to find the requested entity with the given information.")
        {
            return EnvelopeFactory.EntityWasNotFound<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return a conflict with other resource error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> ConflictWithOtherResource(
            string title = "A conflict exists with another resource.",
            string detail = "Another resource or entity already has conflict with another resource that prohibits this operation.")
        {
            return EnvelopeFactory.ConflictWithOtherResource<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return a validation constraint not met error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> ValidationConstraintNotMet(
            string title = "A validation constraint was not met.",
            string detail = "An entity or request did not match the specified parameters and the operation could not continue.")
        {
            return EnvelopeFactory.ValidationConstraintNotMet<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return a pre-condition constraint error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> PreConditionNotMet(
            string title = "A pre-condition was not met.",
            string detail = "A validation constraint before the operation could be started was not fulfilled.")
        {
            return EnvelopeFactory.PreConditionNotMet<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return a post-condition constraint error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> PostConditionNotMet(
            string title = "A post-condition was not met.",
            string detail = "A validation constraint after the operation finished was not fulfilled.")
        {
            return EnvelopeFactory.PostConditionNotMet<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return a request could not be processed error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> CouldNotProcessRequest(
            string title = "Could not process request.",
            string detail = "The request could not be processed at this time.")
        {
            return EnvelopeFactory.CouldNotProcessRequest<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return a user does not error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> UserDoesNotExist(
            string title = "User does not exist.",
            string detail = "The user given the current information could not be found.")
        {
            return EnvelopeFactory.UserDoesNotExist<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return user could not be created error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> UserCouldNotBeCreated(
            string title = "User could not be created.",
            string detail = "A user could not be created given the current information.")
        {
            return EnvelopeFactory.UserCouldNotBeCreated<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return UserName already exists error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> UsernameAlreadyExists(
            string title = "UserName already exists.",
            string detail = "That username is already in use and may not be duplicated.")
        {
            return EnvelopeFactory.UsernameAlreadyExists<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return email is already used error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> EmailIsAlreadyUsed(
            string title = "Email is already used.",
            string detail = "The email given is already being used by an existing user.")
        {
            return EnvelopeFactory.EmailIsAlreadyUsed<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return password is incorrect error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> PasswordIsIncorrect(
            string title = "Password is not correct.",
            string detail = "The password given is incorrect for the specified user.")
        {
            return EnvelopeFactory.PasswordIsIncorrect<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return password does not meet requirements error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> PasswordDoesNotMeetRequirements(
            string title = "Password does not make requirements.",
            string detail = "The password does not have the correct number of strength modifiers.")
        {
            return EnvelopeFactory.PasswordDoesNotMeetRequirements<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return too many recent attempts error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> TooManyRecentAttempts(
            string title = "Too many recent attempts.",
            string detail = "User has attempted too many login attempts recently.")
        {
            return EnvelopeFactory.TooManyRecentAttempts<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return account is locked out error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> AccountIsLockedOut(
            string title = "Account is locked out.",
            string detail = "The account is currently locked out due to suspicious activity.")
        {
            return EnvelopeFactory.AccountIsLockedOut<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return account has not been verified error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> AccountHasNotBeenVerified(
            string title = "Account has not been verified.",
            string detail = "The account has not been verified and has reduced capabilities.")
        {
            return EnvelopeFactory.AccountHasNotBeenVerified<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return email has not been verified error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> EmailHasNotBeenVerified(
            string title = "Email has not been verified.",
            string detail = "The email has not been verified, reducing the account capabilities.")
        {
            return EnvelopeFactory.EmailHasNotBeenVerified<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return two-factor code is incorrect error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> TwoFactorCodeIsIncorrect(
            string title = "Two factor code is incorrect.",
            string detail = "The two factor code did not match what was expected.")
        {
            return EnvelopeFactory.TwoFactorCodeIsIncorrect<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return an unauthorized user error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> UnauthorizedUser(
            string title = "The current user in question is unauthorized.",
            string detail = "The user must first provide credentials before they may access specific content.")
        {
            return EnvelopeFactory.UnauthorizedUser<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return a content is forbidden error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> ContentIsForbidden(
            string title = "The content is forbidden.",
            string detail = "The current user does not have the proper credentials to access the content.")
        {
            return EnvelopeFactory.ContentIsForbidden<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return a general auth error.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> GeneralAuthError(
            string title = "General auth error.",
            string detail = "A non-descriptive error related to the auth process occurred.")
        {
            return EnvelopeFactory.GeneralAuthError<TResponse>(title, detail);
        }

        /// <summary>
        /// Function to return an authentication challenge.
        /// </summary>
        /// <param name="title">The title of the failure.</param>
        /// <param name="detail">The detail of the failure.</param>
        /// <returns>A <see cref="IEnvelope{TResponse}"/>.</returns>
        protected IEnvelope<TResponse> AuthenticationChallenged(
            string title = "The authentication scheme was challenged.",
            string detail = "The authentication is being questioned. The server is unable to verify the identity of the user; please verify the user.")
        {
            return EnvelopeFactory.AuthenticationChallenged<TResponse>(title, detail);
        }
    }
}
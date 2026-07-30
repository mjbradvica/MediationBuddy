// <copyright file="EnvelopeHandlerTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Handlers
{
    using MediationBuddy.Tests.Common;

    /// <summary>
    /// Tests for the <see cref="EnvelopeHandler{TPayload,TResponse}"/> class.
    /// </summary>
    [TestClass]
    public class EnvelopeHandlerTests
    {
        private readonly TestHandler _handler;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeHandlerTests"/> class.
        /// </summary>
        public EnvelopeHandlerTests()
        {
            _handler = new TestHandler();
        }

        /// <summary>
        /// Success method has correct response.
        /// </summary>
        [TestMethod]
        public void SuccessHasCorrectResponse()
        {
            var result = _handler.SuccessResponse();

            Assert.AreEqual(ApplicationStatus.Success, result.Status);
        }

        /// <summary>
        /// Failure method has correct response.
        /// </summary>
        [TestMethod]
        public void FailureHasCorrectResponse()
        {
            const int expected = 999;

            var result = _handler.FailureResponse(expected);

            Assert.AreEqual(expected, result.Status);
        }

        /// <summary>
        /// General error has correct response.
        /// </summary>
        [TestMethod]
        public void GeneralErrorHasCorrectResponse()
        {
            var result = _handler.GeneralErrorResponse();

            Assert.AreEqual(ApplicationStatus.GeneralError, result.Status);
        }

        /// <summary>
        /// Operation could not be completed has correct response.
        /// </summary>
        [TestMethod]
        public void OperationCouldNotBeCompletedHasCorrectResponse()
        {
            var result = _handler.OperationCouldNotBeCompletedResponse();

            Assert.AreEqual(ApplicationStatus.OperationCouldNotBeCompleted, result.Status);
        }

        /// <summary>
        /// Entity was not found has correct response.
        /// </summary>
        [TestMethod]
        public void EntityWasNotFoundHasCorrectResponse()
        {
            var result = _handler.EntityWasNotFoundResponse();

            Assert.AreEqual(ApplicationStatus.EntityWasNotFound, result.Status);
        }

        /// <summary>
        /// Conflict with other resource has correct response.
        /// </summary>
        [TestMethod]
        public void ConflictWithOtherResourceHasCorrectResponse()
        {
            var result = _handler.ConflictWithOtherResourceResponse();

            Assert.AreEqual(ApplicationStatus.ConflictWithOtherResource, result.Status);
        }

        /// <summary>
        /// Validation constraint not met has correct response.
        /// </summary>
        [TestMethod]
        public void ValidationConstrainNotMetHasCorrectResponse()
        {
            var result = _handler.ValidationConstraintNotMetResponse();

            Assert.AreEqual(ApplicationStatus.ValidationConstraintNotMet, result.Status);
        }

        /// <summary>
        /// Pre-condition not met has correct response.
        /// </summary>
        [TestMethod]
        public void PreConditionNotMetHasCorrectResponse()
        {
            var result = _handler.PreConditionNotMetResponse();

            Assert.AreEqual(ApplicationStatus.PreConditionNotMet, result.Status);
        }

        /// <summary>
        /// Post-condition not met has correct response.
        /// </summary>
        [TestMethod]
        public void PostConditionNotMetHasCorrectResponse()
        {
            var result = _handler.PostConditionNotMetResponse();

            Assert.AreEqual(ApplicationStatus.PostConditionNotMet, result.Status);
        }

        /// <summary>
        /// Could not process response has correct response.
        /// </summary>
        [TestMethod]
        public void CouldNotProcessResponseHasCorrectResponse()
        {
            var result = _handler.CouldNotProcessRequestResponse();

            Assert.AreEqual(ApplicationStatus.CouldNotProcessRequest, result.Status);
        }

        /// <summary>
        /// User does not exist has correct response.
        /// </summary>
        [TestMethod]
        public void UserDoesNotExistHasCorrectResponse()
        {
            var result = _handler.UserDoesNotExistResponse();

            Assert.AreEqual(ApplicationStatus.UserDoesNotExist, result.Status);
        }

        /// <summary>
        /// User could not be created has correct response.
        /// </summary>
        [TestMethod]
        public void UserCouldNotBeCreatedHasCorrectResponse()
        {
            var result = _handler.UserCouldNotBeCreatedResponse();

            Assert.AreEqual(ApplicationStatus.UserCouldNotBeCreated, result.Status);
        }

        /// <summary>
        /// Username already exists has correct response.
        /// </summary>
        [TestMethod]
        public void UsernameAlreadyExistsHasCorrectResponse()
        {
            var result = _handler.UsernameAlreadyExistsResponse();

            Assert.AreEqual(ApplicationStatus.UsernameAlreadyExists, result.Status);
        }

        /// <summary>
        /// Email is already used has correct response.
        /// </summary>
        [TestMethod]
        public void EmailIsAlreadyUsedHasCorrectResponse()
        {
            var result = _handler.EmailIsAlreadyUsedResponse();

            Assert.AreEqual(ApplicationStatus.EmailIsAlreadyUsed, result.Status);
        }

        /// <summary>
        /// Password is incorrect has correct response.
        /// </summary>
        [TestMethod]
        public void PasswordIsIncorrectHasCorrectResponse()
        {
            var result = _handler.PasswordIsIncorrectResponse();

            Assert.AreEqual(ApplicationStatus.PasswordIsIncorrect, result.Status);
        }

        /// <summary>
        /// Password does not meet requirements has correct response.
        /// </summary>
        [TestMethod]
        public void PasswordDoesNotMeetRequirementsHasCorrectResponse()
        {
            var result = _handler.PasswordDoesNotMeetRequirementsResponse();

            Assert.AreEqual(ApplicationStatus.PasswordDoesNotMeetRequirements, result.Status);
        }

        /// <summary>
        /// Too many recent attempts has correct response.
        /// </summary>
        [TestMethod]
        public void TooManyRecentAttemptsHasCorrectResponse()
        {
            var result = _handler.TooManyRecentAttemptsResponse();

            Assert.AreEqual(ApplicationStatus.TooManyRecentAttempts, result.Status);
        }

        /// <summary>
        /// Account is locked out has correct response.
        /// </summary>
        [TestMethod]
        public void AccountIsLockedOutHasCorrectResponse()
        {
            var result = _handler.AccountIsLockedOutResponse();

            Assert.AreEqual(ApplicationStatus.AccountIsLockedOut, result.Status);
        }

        /// <summary>
        /// Account has not been verified has correct response.
        /// </summary>
        [TestMethod]
        public void AccountHasNotBeenVerifiedHasCorrectResponse()
        {
            var result = _handler.AccountHasNotBeenVerifiedResponse();

            Assert.AreEqual(ApplicationStatus.AccountHasNotBeenVerified, result.Status);
        }

        /// <summary>
        /// Email has not been verified has correct response.
        /// </summary>
        [TestMethod]
        public void EmailHasNotBeenVerifiedHasCorrectResponse()
        {
            var result = _handler.EmailHasNotBeenVerifiedResponse();

            Assert.AreEqual(ApplicationStatus.EmailHasNotBeenVerified, result.Status);
        }

        /// <summary>
        /// Two factory code is incorrect has correct response.
        /// </summary>
        [TestMethod]
        public void TwoFactorCodeIsIncorrectHasCorrectResponse()
        {
            var result = _handler.TwoFactorCodeIsIncorrectResponse();

            Assert.AreEqual(ApplicationStatus.TwoFactorCodeIncorrect, result.Status);
        }

        /// <summary>
        /// Unauthorized user has correct response.
        /// </summary>
        [TestMethod]
        public void UnauthorizedUserHasCorrectResponse()
        {
            var result = _handler.UnauthorizedUserResponse();

            Assert.AreEqual(ApplicationStatus.UnauthorizedUser, result.Status);
        }

        /// <summary>
        /// Content is forbidden has correct response.
        /// </summary>
        [TestMethod]
        public void ContentIsForbiddenHasCorrectResponse()
        {
            var result = _handler.ContentIsForbiddenResponse();

            Assert.AreEqual(ApplicationStatus.ContentIsForbidden, result.Status);
        }

        /// <summary>
        /// General auth error has correct response.
        /// </summary>
        [TestMethod]
        public void GeneralAuthErrorHasCorrectResponse()
        {
            var result = _handler.GeneralAuthErrorResponse();

            Assert.AreEqual(ApplicationStatus.GeneralAuthError, result.Status);
        }

        /// <summary>
        /// Authentication challenged has correct response.
        /// </summary>
        [TestMethod]
        public void AuthenticationChallengedHasCorrectResponse()
        {
            var result = _handler.AuthenticationChallengedResponse();

            Assert.AreEqual(ApplicationStatus.AuthenticationChallenged, result.Status);
        }
    }
}
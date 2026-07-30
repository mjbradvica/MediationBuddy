// <copyright file="EmptyEnvelopeHandlerTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Handlers
{
    using MediationBuddy.Tests.Common;

    /// <summary>
    /// Tests for the <see cref="EmptyEnvelopeHandler{TPayload}"/> class.
    /// </summary>
    [TestClass]
    public class EmptyEnvelopeHandlerTests
    {
        private readonly TestEmptyHandler _empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyEnvelopeHandlerTests"/> class.
        /// </summary>
        public EmptyEnvelopeHandlerTests()
        {
            _empty = new TestEmptyHandler();
        }

        /// <summary>
        /// Success method has correct response.
        /// </summary>
        [TestMethod]
        public void SuccessHasCorrectResponse()
        {
            var result = _empty.SuccessResponse();

            Assert.AreEqual(ApplicationStatus.Success, result.Status);
        }

        /// <summary>
        /// Failure method has correct response.
        /// </summary>
        [TestMethod]
        public void FailureHasCorrectResponse()
        {
            const int expected = 999;

            var result = _empty.FailureResponse(expected);

            Assert.AreEqual(expected, result.Status);
        }

        /// <summary>
        /// General error has correct response.
        /// </summary>
        [TestMethod]
        public void GeneralErrorHasCorrectResponse()
        {
            var result = _empty.GeneralErrorResponse();

            Assert.AreEqual(ApplicationStatus.GeneralError, result.Status);
        }

        /// <summary>
        /// Operation could not be completed has correct response.
        /// </summary>
        [TestMethod]
        public void OperationCouldNotBeCompletedHasCorrectResponse()
        {
            var result = _empty.OperationCouldNotBeCompletedResponse();

            Assert.AreEqual(ApplicationStatus.OperationCouldNotBeCompleted, result.Status);
        }

        /// <summary>
        /// Entity was not found has correct response.
        /// </summary>
        [TestMethod]
        public void EntityWasNotFoundHasCorrectResponse()
        {
            var result = _empty.EntityWasNotFoundResponse();

            Assert.AreEqual(ApplicationStatus.EntityWasNotFound, result.Status);
        }

        /// <summary>
        /// Conflict with other resource has correct response.
        /// </summary>
        [TestMethod]
        public void ConflictWithOtherResourceHasCorrectResponse()
        {
            var result = _empty.ConflictWithOtherResourceResponse();

            Assert.AreEqual(ApplicationStatus.ConflictWithOtherResource, result.Status);
        }

        /// <summary>
        /// Validation constraint not met has correct response.
        /// </summary>
        [TestMethod]
        public void ValidationConstrainNotMetHasCorrectResponse()
        {
            var result = _empty.ValidationConstraintNotMetResponse();

            Assert.AreEqual(ApplicationStatus.ValidationConstraintNotMet, result.Status);
        }

        /// <summary>
        /// Pre-condition not met has correct response.
        /// </summary>
        [TestMethod]
        public void PreConditionNotMetHasCorrectResponse()
        {
            var result = _empty.PreConditionNotMetResponse();

            Assert.AreEqual(ApplicationStatus.PreConditionNotMet, result.Status);
        }

        /// <summary>
        /// Post-condition not met has correct response.
        /// </summary>
        [TestMethod]
        public void PostConditionNotMetHasCorrectResponse()
        {
            var result = _empty.PostConditionNotMetResponse();

            Assert.AreEqual(ApplicationStatus.PostConditionNotMet, result.Status);
        }

        /// <summary>
        /// Could not process response has correct response.
        /// </summary>
        [TestMethod]
        public void CouldNotProcessResponseHasCorrectResponse()
        {
            var result = _empty.CouldNotProcessRequestResponse();

            Assert.AreEqual(ApplicationStatus.CouldNotProcessRequest, result.Status);
        }

        /// <summary>
        /// User does not exist has correct response.
        /// </summary>
        [TestMethod]
        public void UserDoesNotExistHasCorrectResponse()
        {
            var result = _empty.UserDoesNotExistResponse();

            Assert.AreEqual(ApplicationStatus.UserDoesNotExist, result.Status);
        }

        /// <summary>
        /// User could not be created has correct response.
        /// </summary>
        [TestMethod]
        public void UserCouldNotBeCreatedHasCorrectResponse()
        {
            var result = _empty.UserCouldNotBeCreatedResponse();

            Assert.AreEqual(ApplicationStatus.UserCouldNotBeCreated, result.Status);
        }

        /// <summary>
        /// Username already exists has correct response.
        /// </summary>
        [TestMethod]
        public void UsernameAlreadyExistsHasCorrectResponse()
        {
            var result = _empty.UsernameAlreadyExistsResponse();

            Assert.AreEqual(ApplicationStatus.UsernameAlreadyExists, result.Status);
        }

        /// <summary>
        /// Email is already used has correct response.
        /// </summary>
        [TestMethod]
        public void EmailIsAlreadyUsedHasCorrectResponse()
        {
            var result = _empty.EmailIsAlreadyUsedResponse();

            Assert.AreEqual(ApplicationStatus.EmailIsAlreadyUsed, result.Status);
        }

        /// <summary>
        /// Password is incorrect has correct response.
        /// </summary>
        [TestMethod]
        public void PasswordIsIncorrectHasCorrectResponse()
        {
            var result = _empty.PasswordIsIncorrectResponse();

            Assert.AreEqual(ApplicationStatus.PasswordIsIncorrect, result.Status);
        }

        /// <summary>
        /// Password does not meet requirements has correct response.
        /// </summary>
        [TestMethod]
        public void PasswordDoesNotMeetRequirementsHasCorrectResponse()
        {
            var result = _empty.PasswordDoesNotMeetRequirementsResponse();

            Assert.AreEqual(ApplicationStatus.PasswordDoesNotMeetRequirements, result.Status);
        }

        /// <summary>
        /// Too many recent attempts has correct response.
        /// </summary>
        [TestMethod]
        public void TooManyRecentAttemptsHasCorrectResponse()
        {
            var result = _empty.TooManyRecentAttemptsResponse();

            Assert.AreEqual(ApplicationStatus.TooManyRecentAttempts, result.Status);
        }

        /// <summary>
        /// Account is locked out has correct response.
        /// </summary>
        [TestMethod]
        public void AccountIsLockedOutHasCorrectResponse()
        {
            var result = _empty.AccountIsLockedOutResponse();

            Assert.AreEqual(ApplicationStatus.AccountIsLockedOut, result.Status);
        }

        /// <summary>
        /// Account has not been verified has correct response.
        /// </summary>
        [TestMethod]
        public void AccountHasNotBeenVerifiedHasCorrectResponse()
        {
            var result = _empty.AccountHasNotBeenVerifiedResponse();

            Assert.AreEqual(ApplicationStatus.AccountHasNotBeenVerified, result.Status);
        }

        /// <summary>
        /// Email has not been verified has correct response.
        /// </summary>
        [TestMethod]
        public void EmailHasNotBeenVerifiedHasCorrectResponse()
        {
            var result = _empty.EmailHasNotBeenVerifiedResponse();

            Assert.AreEqual(ApplicationStatus.EmailHasNotBeenVerified, result.Status);
        }

        /// <summary>
        /// Two factory code is incorrect has correct response.
        /// </summary>
        [TestMethod]
        public void TwoFactorCodeIsIncorrectHasCorrectResponse()
        {
            var result = _empty.TwoFactorCodeIsIncorrectResponse();

            Assert.AreEqual(ApplicationStatus.TwoFactorCodeIncorrect, result.Status);
        }

        /// <summary>
        /// Unauthorized user has correct response.
        /// </summary>
        [TestMethod]
        public void UnauthorizedUserHasCorrectResponse()
        {
            var result = _empty.UnauthorizedUserResponse();

            Assert.AreEqual(ApplicationStatus.UnauthorizedUser, result.Status);
        }

        /// <summary>
        /// Content is forbidden has correct response.
        /// </summary>
        [TestMethod]
        public void ContentIsForbiddenHasCorrectResponse()
        {
            var result = _empty.ContentIsForbiddenResponse();

            Assert.AreEqual(ApplicationStatus.ContentIsForbidden, result.Status);
        }

        /// <summary>
        /// General auth error has correct response.
        /// </summary>
        [TestMethod]
        public void GeneralAuthErrorHasCorrectResponse()
        {
            var result = _empty.GeneralAuthErrorResponse();

            Assert.AreEqual(ApplicationStatus.GeneralAuthError, result.Status);
        }

        /// <summary>
        /// Authentication challenged has correct response.
        /// </summary>
        [TestMethod]
        public void AuthenticationChallengedHasCorrectResponse()
        {
            var result = _empty.AuthenticationChallengedResponse();

            Assert.AreEqual(ApplicationStatus.AuthenticationChallenged, result.Status);
        }
    }
}
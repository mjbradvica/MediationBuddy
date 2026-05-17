// <copyright file="EnvelopeFactoryTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Common
{
    /// <summary>
    /// Tests for the <see cref="EnvelopeFactory"/>.
    /// </summary>
    [TestClass]
    public class EnvelopeFactoryTests
    {
        /// <summary>
        /// Typed success is correct.
        /// </summary>
        [TestMethod]
        public void SuccessWithResponseIsCorrect()
        {
            var envelope = EnvelopeFactory.Success(string.Empty);

            Assert.AreEqual(ApplicationStatus.Success, envelope.Status);
        }

        /// <summary>
        /// Empty success is correct.
        /// </summary>
        [TestMethod]
        public void EmptySuccessIsCorrect()
        {
            var envelope = EnvelopeFactory.Success();

            Assert.AreEqual(ApplicationStatus.Success, envelope.Status);
        }

        /// <summary>
        /// Failure is correct.
        /// </summary>
        [TestMethod]
        public void FailureIsCorrect()
        {
            const int status = 999;
            const string title = "title";
            const string detail = "detail";

            var envelope = EnvelopeFactory.Failure<string>(status, title, detail);

            Assert.AreEqual(status, envelope.Status);
            Assert.AreEqual(title, envelope.Title);
            Assert.AreEqual(detail, envelope.Detail);
        }

        /// <summary>
        /// General error is correct.
        /// </summary>
        [TestMethod]
        public void GeneralErrorIsCorrect()
        {
            var envelope = EnvelopeFactory.GeneralError<string>();

            Assert.AreEqual(ApplicationStatus.GeneralError, envelope.Status);
        }

        /// <summary>
        /// Operation could not be completed is correct.
        /// </summary>
        [TestMethod]
        public void OperationCouldNotBeCompletedIsCorrect()
        {
            var envelope = EnvelopeFactory.OperationCouldNotBeCompleted<string>();

            Assert.AreEqual(ApplicationStatus.OperationCouldNotBeCompleted, envelope.Status);
        }

        /// <summary>
        /// Entity was not found is correct.
        /// </summary>
        [TestMethod]
        public void EntityWasNotFoundIsCorrect()
        {
            var envelope = EnvelopeFactory.EntityWasNotFound<string>();

            Assert.AreEqual(ApplicationStatus.EntityWasNotFound, envelope.Status);
        }

        /// <summary>
        /// Conflict with other resource is correct.
        /// </summary>
        [TestMethod]
        public void ConflictWithOtherResourceIsCorrect()
        {
            var envelope = EnvelopeFactory.ConflictWithOtherResource<string>();

            Assert.AreEqual(ApplicationStatus.ConflictWithOtherResource, envelope.Status);
        }

        /// <summary>
        /// Validation constraint not met is correct.
        /// </summary>
        [TestMethod]
        public void ValidationConstraintNotMetIsCorrect()
        {
            var envelope = EnvelopeFactory.ValidationConstraintNotMet<string>();

            Assert.AreEqual(ApplicationStatus.ValidationConstraintNotMet, envelope.Status);
        }

        /// <summary>
        /// Pre-condition not met is correct.
        /// </summary>
        [TestMethod]
        public void PreConditionNotMetIsCorrect()
        {
            var envelope = EnvelopeFactory.PreConditionNotMet<string>();

            Assert.AreEqual(ApplicationStatus.PreConditionNotMet, envelope.Status);
        }

        /// <summary>
        /// Post-condition not met is correct.
        /// </summary>
        [TestMethod]
        public void PostConditionNotMetIsCorrect()
        {
            var envelope = EnvelopeFactory.PostConditionNotMet<string>();

            Assert.AreEqual(ApplicationStatus.PostConditionNotMet, envelope.Status);
        }

        /// <summary>
        /// Could not process request is correct.
        /// </summary>
        [TestMethod]
        public void CouldNotProcessRequest()
        {
            var envelope = EnvelopeFactory.CouldNotProcessRequest<string>();

            Assert.AreEqual(ApplicationStatus.CouldNotProcessRequest, envelope.Status);
        }

        /// <summary>
        /// User does not exist is correct.
        /// </summary>
        [TestMethod]
        public void UserDoesNotExistIsCorrect()
        {
            var envelope = EnvelopeFactory.UserDoesNotExist<string>();

            Assert.AreEqual(ApplicationStatus.UserDoesNotExist, envelope.Status);
        }

        /// <summary>
        /// User could not be created is correct.
        /// </summary>
        [TestMethod]
        public void UserCouldNotBeCreatedIsCorrect()
        {
            var envelope = EnvelopeFactory.UserCouldNotBeCreated<string>();

            Assert.AreEqual(ApplicationStatus.UserCouldNotBeCreated, envelope.Status);
        }

        /// <summary>
        /// Username already exists is correct.
        /// </summary>
        [TestMethod]
        public void UsernameAlreadyExists()
        {
            var envelope = EnvelopeFactory.UsernameAlreadyExists<string>();

            Assert.AreEqual(ApplicationStatus.UsernameAlreadyExists, envelope.Status);
        }

        /// <summary>
        /// Email is already used is correct.
        /// </summary>
        [TestMethod]
        public void EmailIsAlreadyUsedIsCorrect()
        {
            var envelope = EnvelopeFactory.EmailIsAlreadyUsed<string>();

            Assert.AreEqual(ApplicationStatus.EmailIsAlreadyUsed, envelope.Status);
        }

        /// <summary>
        /// Password is incorrect is correct.
        /// </summary>
        [TestMethod]
        public void PasswordIsIncorrectIsCorrect()
        {
            var envelope = EnvelopeFactory.PasswordIsIncorrect<string>();

            Assert.AreEqual(ApplicationStatus.PasswordIsIncorrect, envelope.Status);
        }

        /// <summary>
        /// Password does not meet requirements is correct.
        /// </summary>
        [TestMethod]
        public void PasswordDoesNotMeetRequirementsIsCorrect()
        {
            var envelope = EnvelopeFactory.PasswordDoesNotMeetRequirements<string>();

            Assert.AreEqual(ApplicationStatus.PasswordDoesNotMeetRequirements, envelope.Status);
        }

        /// <summary>
        /// Too many recent attempts is correct.
        /// </summary>
        [TestMethod]
        public void TooManyRecentAttemptsIsCorrect()
        {
            var envelope = EnvelopeFactory.TooManyRecentAttempts<string>();

            Assert.AreEqual(ApplicationStatus.TooManyRecentAttempts, envelope.Status);
        }

        /// <summary>
        /// Account is locked out is correct.
        /// </summary>
        [TestMethod]
        public void AccountIsLockedOutIsCorrect()
        {
            var envelope = EnvelopeFactory.AccountIsLockedOut<string>();

            Assert.AreEqual(ApplicationStatus.AccountIsLockedOut, envelope.Status);
        }

        /// <summary>
        /// Account has not been verified is correct.
        /// </summary>
        [TestMethod]
        public void AccountHasNotBeenVerifiedIsCorrect()
        {
            var envelope = EnvelopeFactory.AccountHasNotBeenVerified<string>();

            Assert.AreEqual(ApplicationStatus.AccountHasNotBeenVerified, envelope.Status);
        }

        /// <summary>
        /// Email has not been verified is correct.
        /// </summary>
        [TestMethod]
        public void EmailHasNotBeenVerifiedIsCorrect()
        {
            var envelope = EnvelopeFactory.EmailHasNotBeenVerified<string>();

            Assert.AreEqual(ApplicationStatus.EmailHasNotBeenVerified, envelope.Status);
        }

        /// <summary>
        /// Two-factor code is incorrect is correct.
        /// </summary>
        [TestMethod]
        public void TwoFactorCodeIsIncorrectIsCorrect()
        {
            var envelope = EnvelopeFactory.TwoFactorCodeIsIncorrect<string>();

            Assert.AreEqual(ApplicationStatus.TwoFactorCodeIncorrect, envelope.Status);
        }

        /// <summary>
        /// Unauthorized user is correct.
        /// </summary>
        [TestMethod]
        public void UnauthorizedUserIsCorrect()
        {
            var envelope = EnvelopeFactory.UnauthorizedUser<string>();

            Assert.AreEqual(ApplicationStatus.UnauthorizedUser, envelope.Status);
        }

        /// <summary>
        /// Content is forbidden is correct.
        /// </summary>
        [TestMethod]
        public void ContentIsForbiddenIsCorrect()
        {
            var envelope = EnvelopeFactory.ContentIsForbidden<string>();

            Assert.AreEqual(ApplicationStatus.ContentIsForbidden, envelope.Status);
        }

        /// <summary>
        /// General auth error is correct.
        /// </summary>
        [TestMethod]
        public void GeneralAuthErrorIsCorrect()
        {
            var envelope = EnvelopeFactory.GeneralAuthError<string>();

            Assert.AreEqual(ApplicationStatus.GeneralAuthError, envelope.Status);
        }

        /// <summary>
        /// Authentication challenged is correct.
        /// </summary>
        [TestMethod]
        public void AuthenticationChallengedIsCorrect()
        {
            var envelope = EnvelopeFactory.AuthenticationChallenged<string>();

            Assert.AreEqual(ApplicationStatus.AuthenticationChallenged, envelope.Status);
        }
    }
}
// <copyright file="BaseApiErrorControllerTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Controllers
{
    using MediationBuddy.AspNet.Controllers;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Tests for the <see cref="BaseApiErrorController"/> class.
    /// </summary>
    [TestClass]
    public class BaseApiErrorControllerTests
    {
        private readonly TestApiErrorController _errorController;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApiErrorControllerTests"/> class.
        /// </summary>
        public BaseApiErrorControllerTests()
        {
            _errorController = new TestApiErrorController();
        }

        /// <summary>
        /// Ensures GeneralError is correct.
        /// </summary>
        [TestMethod]
        public void GeneralErrorIsCorrectType()
        {
            AssertCorrect(_errorController.GeneralError());
        }

        /// <summary>
        /// Ensures OperationCouldNotBeCompleted is correct.
        /// </summary>
        [TestMethod]
        public void OperationCouldNotBeCompletedIsCorrectType()
        {
            AssertCorrect(_errorController.OperationCouldNotBeCompleted());
        }

        /// <summary>
        /// Ensures EntityWasNotFound is correct.
        /// </summary>
        [TestMethod]
        public void EntityWasNotFoundIsCorrectType()
        {
            AssertCorrect(_errorController.EntityWasNotFound());
        }

        /// <summary>
        /// Ensures ConflictWithOtherResource is correct.
        /// </summary>
        [TestMethod]
        public void ConflictWithOtherResourceIsCorrectType()
        {
            AssertCorrect(_errorController.ConflictWithOtherResource());
        }

        /// <summary>
        /// Ensures ValidationConstraintNotMet is correct.
        /// </summary>
        [TestMethod]
        public void ValidationConstraintNotMetIsCorrectType()
        {
            AssertCorrect(_errorController.ValidationConstraintNotMet());
        }

        /// <summary>
        /// Ensures PreConditionNotMet is correct.
        /// </summary>
        [TestMethod]
        public void PreConditionNotMetIsCorrectType()
        {
            AssertCorrect(_errorController.PreConditionNotMet());
        }

        /// <summary>
        /// Ensures PostConditionNotMet is correct.
        /// </summary>
        [TestMethod]
        public void PostConditionNotMetIsCorrectType()
        {
            AssertCorrect(_errorController.PostConditionNotMet());
        }

        /// <summary>
        /// Ensures CouldNotProcessRequest is correct.
        /// </summary>
        [TestMethod]
        public void CouldNotProcessRequestIsCorrectType()
        {
            AssertCorrect(_errorController.CouldNotProcessRequest());
        }

        /// <summary>
        /// Ensures UserDoesNotExist is correct.
        /// </summary>
        [TestMethod]
        public void UserDoesNotExistIsCorrectType()
        {
            AssertCorrect(_errorController.UserDoesNotExist());
        }

        /// <summary>
        /// Ensures UserCouldNotBeCreated is correct.
        /// </summary>
        [TestMethod]
        public void UserCouldNotBeCreatedIsCorrectType()
        {
            AssertCorrect(_errorController.UserCouldNotBeCreated());
        }

        /// <summary>
        /// Ensures UsernameAlreadyExists is correct.
        /// </summary>
        [TestMethod]
        public void UsernameAlreadyExistsIsCorrectType()
        {
            AssertCorrect(_errorController.UsernameAlreadyExists());
        }

        /// <summary>
        /// Ensures EmailIsAlreadyUsed is correct.
        /// </summary>
        [TestMethod]
        public void EmailIsAlreadyUsedIsCorrectType()
        {
            AssertCorrect(_errorController.EmailIsAlreadyUsed());
        }

        /// <summary>
        /// Ensures PasswordIsIncorrect is correct.
        /// </summary>
        [TestMethod]
        public void PasswordIsIncorrectIsCorrectType()
        {
            AssertCorrect(_errorController.PasswordIsIncorrect());
        }

        /// <summary>
        /// Ensures PasswordDoesNotMeetRequirements is correct.
        /// </summary>
        [TestMethod]
        public void PasswordDoesNotMeetRequirementsIsCorrectType()
        {
            AssertCorrect(_errorController.PasswordDoesNotMeetRequirements());
        }

        /// <summary>
        /// Ensures TooManyRecentAttempts is correct.
        /// </summary>
        [TestMethod]
        public void TooManyRecentAttemptsIsCorrectType()
        {
            AssertCorrect(_errorController.TooManyRecentAttempts());
        }

        /// <summary>
        /// Ensures AccountIsLockedOut is correct.
        /// </summary>
        [TestMethod]
        public void AccountIsLockedOutIsCorrectType()
        {
            AssertCorrect(_errorController.AccountIsLockedOut());
        }

        /// <summary>
        /// Ensures AccountHasNotBeenVerified is correct.
        /// </summary>
        [TestMethod]
        public void AccountHasNotBeenVerifiedIsCorrectType()
        {
            AssertCorrect(_errorController.AccountHasNotBeenVerified());
        }

        /// <summary>
        /// Ensures EmailHasNotBeenVerified is correct.
        /// </summary>
        [TestMethod]
        public void EmailHasNotBeenVerifiedIsCorrectType()
        {
            AssertCorrect(_errorController.EmailHasNotBeenVerified());
        }

        /// <summary>
        /// Ensures TwoFactoryCodeIncorrect is correct.
        /// </summary>
        [TestMethod]
        public void TwoFactorCodeIncorrectIsCorrectType()
        {
            AssertCorrect(_errorController.TwoFactorCodeIncorrect());
        }

        /// <summary>
        /// Ensures UnauthorizedUser is correct.
        /// </summary>
        [TestMethod]
        public void UnauthorizedUserIsCorrectType()
        {
            AssertCorrect(_errorController.UnauthorizedUser());
        }

        /// <summary>
        /// Ensures ContentIsForbidden is correct.
        /// </summary>
        [TestMethod]
        public void ContentIsForbiddenIsCorrectType()
        {
            AssertCorrect(_errorController.ContentIsForbidden());
        }

        /// <summary>
        /// Ensures GeneralAuthError is correct.
        /// </summary>
        [TestMethod]
        public void GeneralAuthErrorIsCorrectType()
        {
            AssertCorrect(_errorController.GeneralAuthError());
        }

        /// <summary>
        /// Ensures AuthenticationChallenged is correct.
        /// </summary>
        [TestMethod]
        public void AuthenticationChallengedIsCorrectType()
        {
            AssertCorrect(_errorController.AuthenticationChallenged());
        }

        private static void AssertCorrect(IActionResult result)
        {
            Assert.IsInstanceOfType<OkObjectResult>(result);
            Assert.IsInstanceOfType<string>((result as OkObjectResult)?.Value);
        }
    }
}
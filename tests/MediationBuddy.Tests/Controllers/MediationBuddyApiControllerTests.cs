// <copyright file="MediationBuddyApiControllerTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Controllers
{
    using MediationBuddy.AspNet.Controllers;
    using MediationBuddy.AspNet.ErrorHandling;
    using MediationBuddy.Tests.Common;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using NMediation.Abstractions;

    /// <summary>
    /// Tests for the <see cref="MediationBuddyApiController"/> class.
    /// </summary>
    [TestClass]
    public class MediationBuddyApiControllerTests
    {
        private readonly Mock<IMediation> _mediator;
        private readonly TestApiController _apiController;

        /// <summary>
        /// Initializes a new instance of the <see cref="MediationBuddyApiControllerTests"/> class.
        /// </summary>
        public MediationBuddyApiControllerTests()
        {
            _mediator = new Mock<IMediation>();
            _apiController = new TestApiController(_mediator.Object)
            {
                ControllerContext = new ControllerContext
                {
                    HttpContext = new DefaultHttpContext(),
                },
            };
        }

        /// <summary>
        /// Ensures that general errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task GeneralErrorIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.GeneralError<TestResponse>());
        }

        /// <summary>
        /// Ensures that operation could not be completed errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task OperationCouldNotBeCompletedIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.OperationCouldNotBeCompleted<TestResponse>());
        }

        /// <summary>
        /// Ensures that conflict with other resource errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task ConflictWithOtherResourceIsCorrect()
        {
            await AssertStatusCorrect<ConflictObjectResult>(EnvelopeFactory.ConflictWithOtherResource<TestResponse>());
        }

        /// <summary>
        /// Ensures that entity was not found errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task EntityWasNotFoundIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.EntityWasNotFound<TestResponse>());
        }

        /// <summary>
        /// Ensures that validation constraint not met errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task ValidationConstraintNotMetIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.ValidationConstraintNotMet<TestResponse>());
        }

        /// <summary>
        /// Ensures that pre-condition not met errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task PreConditionNotMetIsCorrect()
        {
            await AssertStatusCorrect<BadRequestObjectResult>(EnvelopeFactory.PreConditionNotMet<TestResponse>());
        }

        /// <summary>
        /// Ensures that post condition not met errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task PostConditionNotMetIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.PostConditionNotMet<TestResponse>());
        }

        /// <summary>
        /// Ensures that could not process request errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task CouldNotProcessRequestIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.CouldNotProcessRequest<TestResponse>());
        }

        /// <summary>
        /// Ensures that user does not exist errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task UserDoesNotExistIsCorrect()
        {
            await AssertStatusCorrect<NotFoundObjectResult>(EnvelopeFactory.UserDoesNotExist<TestResponse>());
        }

        /// <summary>
        /// Ensures that user could not be created errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task UserCouldNotBeCreatedIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.UserCouldNotBeCreated<TestResponse>());
        }

        /// <summary>
        /// Ensures that username already exists errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task UsernameAlreadyExistsIsCorrect()
        {
            await AssertStatusCorrect<ConflictObjectResult>(EnvelopeFactory.UsernameAlreadyExists<TestResponse>());
        }

        /// <summary>
        /// Ensures that email is already used errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task EmailIsAlreadyUsedIsCorrect()
        {
            await AssertStatusCorrect<ConflictObjectResult>(EnvelopeFactory.EmailIsAlreadyUsed<TestResponse>());
        }

        /// <summary>
        /// Ensures that password is incorrect errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task PasswordIsIncorrectIsCorrect()
        {
            await AssertStatusCorrect<BadRequestObjectResult>(EnvelopeFactory.PasswordIsIncorrect<TestResponse>());
        }

        /// <summary>
        /// Ensures that password does not meet requirements errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task PasswordDoesNotMeetRequirementsIsCorrect()
        {
            await AssertStatusCorrect<BadRequestObjectResult>(EnvelopeFactory.PasswordDoesNotMeetRequirements<TestResponse>());
        }

        /// <summary>
        /// Ensures that too many recent attempts errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task TooManyRecentAttemptsIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.TooManyRecentAttempts<TestResponse>());
        }

        /// <summary>
        /// Ensures that account is locked out errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task AccountIsLockedOutIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.AccountIsLockedOut<TestResponse>());
        }

        /// <summary>
        /// Ensures that account has not been verified errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task AccountHasNotBeenVerifiedIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.AccountHasNotBeenVerified<TestResponse>());
        }

        /// <summary>
        /// Ensures that email has not been verified errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task EmailHasNotBeenVerifiedIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.EmailHasNotBeenVerified<TestResponse>());
        }

        /// <summary>
        /// Ensures that two-factor code incorrect errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task TwoFactorCodeIncorrectIsCorrect()
        {
            await AssertStatusCorrect<BadRequestObjectResult>(EnvelopeFactory.TwoFactorCodeIsIncorrect<TestResponse>());
        }

        /// <summary>
        /// Ensures that unauthorized user errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task UnauthorizedUserIsCorrect()
        {
            await AssertStatusCorrect<UnauthorizedObjectResult>(EnvelopeFactory.UnauthorizedUser<TestResponse>());
        }

        /// <summary>
        /// Ensures that content is forbidden errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task ContentIsForbiddenIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(EnvelopeFactory.ContentIsForbidden<TestResponse>());
        }

        /// <summary>
        /// Ensures that general auth errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task GeneralAuthErrorIsCorrect()
        {
            await AssertStatusCorrect<UnauthorizedObjectResult>(EnvelopeFactory.GeneralAuthError<TestResponse>());
        }

        /// <summary>
        /// Ensures that authentication challenged errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task AuthenticationChallengedIsCorrect()
        {
            await AssertStatusCorrect<UnauthorizedObjectResult>(EnvelopeFactory.AuthenticationChallenged<TestResponse>());
        }

        /// <summary>
        /// Ensures that anonymous errors are correct.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task AnonymousErrorsIsCorrect()
        {
            await AssertStatusCorrect<ObjectResult>(new Envelope<TestResponse>(999, string.Empty, string.Empty));
        }

        /// <summary>
        /// Ok has the correct response type.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task ExecuteOkHasCorrectResponseType()
        {
            _mediator.Setup(x => x.Mediate(It.IsAny<TestObjectRequest>(), CancellationToken.None))
                .ReturnsAsync(EnvelopeFactory.Success(new TestResponse()));

            var result = await _apiController.OkResult();

            Assert.IsInstanceOfType<OkResult>(result);
        }

        /// <summary>
        /// Ok Object has the correct response type.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task ExecuteOkObjectHasCorrectResponseType()
        {
            _mediator.Setup(x => x.Mediate(It.IsAny<TestObjectRequest>(), CancellationToken.None))
                .ReturnsAsync(EnvelopeFactory.Success(new TestResponse()));

            var result = await _apiController.OkObjectResult();

            Assert.IsInstanceOfType<OkObjectResult>(result);
        }

        /// <summary>
        /// Accepted has the correct response type.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task ExecuteAcceptedHasCorrectResponseType()
        {
            _mediator.Setup(x => x.Mediate(It.IsAny<TestObjectRequest>(), CancellationToken.None))
                .ReturnsAsync(EnvelopeFactory.Success(new TestResponse()));

            var result = await _apiController.AcceptedResult();

            Assert.IsInstanceOfType<AcceptedResult>(result);
        }

        /// <summary>
        /// Accepted object has the correct response type.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task ExecuteAcceptedObjectHasCorrectResponseType()
        {
            _mediator.Setup(x => x.Mediate(It.IsAny<TestObjectRequest>(), CancellationToken.None))
                .ReturnsAsync(EnvelopeFactory.Success(new TestResponse()));

            var result = await _apiController.AcceptedObjectResult();

            Assert.IsInstanceOfType<AcceptedResult>(result);
        }

        /// <summary>
        /// Created object has the correct response type.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task ExecuteCreatedObjectHasCorrectResponseType()
        {
            _mediator.Setup(x => x.Mediate(It.IsAny<TestObjectRequest>(), CancellationToken.None))
                .ReturnsAsync(EnvelopeFactory.Success(new TestResponse()));

            var result = await _apiController.CreatedObjectResult();

            Assert.IsInstanceOfType<CreatedResult>(result);
        }

        /// <summary>
        /// No content has the correct response type.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task ExecuteNoContentHasCorrectResponseType()
        {
            _mediator.Setup(x => x.Mediate(It.IsAny<TestObjectRequest>(), CancellationToken.None))
                .ReturnsAsync(EnvelopeFactory.Success(new TestResponse()));

            var result = await _apiController.NoContentResult();

            Assert.IsInstanceOfType<NoContentResult>(result);
        }

        /// <summary>
        /// On Exception has the correct response type.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task OnExceptionHasCorrectResponseType()
        {
            _mediator.Setup(x => x.Mediate(It.IsAny<TestObjectRequest>(), CancellationToken.None))
                .ThrowsAsync(new ArgumentNullException());

            var result = await _apiController.NoContentResult();

            Assert.IsInstanceOfType<ObjectResult>(result);
        }

        /// <summary>
        /// Validation failure returns correct response type.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [TestMethod]
        public async Task OnValidationFailureHasCorrectResponseType()
        {
            var result = await _apiController.Handle(new TestObjectRequest
            {
                RequestInstance = null!,
            });

            Assert.IsInstanceOfType<BadRequestObjectResult>(result);
        }

        private async Task AssertStatusCorrect<TResponseType>(IEnvelope<TestResponse> response)
            where TResponseType : ObjectResult
        {
            _mediator.Setup(x => x.Mediate(It.IsAny<TestObjectRequest>(), CancellationToken.None))
                .ReturnsAsync(response);

            var result = await _apiController.Handle(new TestObjectRequest());

            var errorResponse = result as ObjectResult;

            Assert.IsInstanceOfType<TResponseType>(result);
            Assert.IsInstanceOfType<ErrorResponse>(errorResponse?.Value);
            Assert.AreEqual(errorResponse.StatusCode, (errorResponse.Value as ErrorResponse)?.Status);
        }
    }
}
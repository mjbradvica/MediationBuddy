// <copyright file="AttributeTests.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Tests.Attributes
{
    using MediationBuddy.AspNet.Attributes;
    using MediationBuddy.AspNet.ErrorHandling;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Tests for attributes.
    /// </summary>
    [TestClass]
    public class AttributeTests
    {
        /// <summary>
        /// Base attribute has correct properties.
        /// </summary>
        [TestMethod]
        public void BaseResponseAttributeIsCorrect()
        {
            const int expected = 400;

            var attribute = new MediationBuddyErrorResponseAttribute(expected);

            AttributeTestBase(attribute, expected);
        }

        /// <summary>
        /// 400 code response is correct.
        /// </summary>
        [TestMethod]
        public void FourHundredErrorResponseIsCorrect()
        {
            var attribute = new MediationBuddy400ErrorResponseAttribute();

            AttributeTestBase(attribute, StatusCodes.Status400BadRequest);
        }

        /// <summary>
        /// 401 code response is correct.
        /// </summary>
        [TestMethod]
        public void FourHundredOneErrorResponseIsCorrect()
        {
            var attribute = new MediationBuddy401ErrorResponseAttribute();

            AttributeTestBase(attribute, StatusCodes.Status401Unauthorized);
        }

        /// <summary>
        /// 403 code response is correct.
        /// </summary>
        [TestMethod]
        public void FourHundredThreeErrorResponseIsCorrect()
        {
            var attribute = new MediationBuddy403ErrorResponseAttribute();

            AttributeTestBase(attribute, StatusCodes.Status403Forbidden);
        }

        /// <summary>
        /// 404 code response is correct.
        /// </summary>
        [TestMethod]
        public void FourHundredFourErrorResponseAttribute()
        {
            var attribute = new MediationBuddy404ErrorResponseAttribute();

            AttributeTestBase(attribute, StatusCodes.Status404NotFound);
        }

        /// <summary>
        /// 500 code response is correct.
        /// </summary>
        [TestMethod]
        public void FiveHundredErrorResponseAttribute()
        {
            var attribute = new MediationBuddy500ErrorResponseAttribute();

            AttributeTestBase(attribute, StatusCodes.Status500InternalServerError);
        }

        private static void AttributeTestBase(ProducesResponseTypeAttribute attribute, int expected)
        {
            Assert.AreEqual(typeof(ErrorResponse), attribute.Type);
            Assert.AreEqual(expected, attribute.StatusCode);
        }
    }
}
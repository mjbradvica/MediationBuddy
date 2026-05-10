// <copyright file="ErrorController.cs" company="Simplex Software LLC">
// Copyright (c) Simplex Software LLC. All rights reserved.
// </copyright>

namespace MediationBuddy.Samples.API.Controllers
{
    using MediationBuddy.AspNet.Controllers;
    using Microsoft.AspNetCore.Mvc;

    /// <inheritdoc />
    [Route("error")]
    public class ErrorController : BaseApiErrorController
    {
    }
}
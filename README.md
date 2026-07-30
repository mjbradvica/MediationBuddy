# MediationBuddy

An opinionated implementation for the [NMediation](https://github.com/mjbradvica/NMediation) library.

![TempBuddy](https://i.imgur.com/Un435IL.png)

![build-status](https://github.com/mjbradvica/MediationBuddy/workflows/main/badge.svg) ![downloads](https://img.shields.io/nuget/dt/MediationBuddy) ![downloads](https://img.shields.io/nuget/v/MediationBuddy) ![activity](https://img.shields.io/github/last-commit/mjbradvica/MediationBuddy/master)

## Overview

What does MediatorBuddy give you?

- :telephone: A consistent interface for communication between your presentation and application layer.
- :clipboard: An implementation of the [RFC 9457](https://www.rfc-editor.org/rfc/rfc9457.txt) spec for user-friendly API error responses.
- :construction_worker: A base controller that handles generic boilerplate for you. Far fewer unit tests.
- :hammer: Extendable: You can define custom application status states and return a specific status code.
- :currency_exchange: Modifiable: Override a status return code, title, or detail message.

## Samples

If you prefer code samples in addition to documentation, there are full samples available for each framework type that can be [viewed here](https://github.com/mjbradvica/MediationBuddy/tree/master/samples).

> It is recommended to look at the samples if this is your first time using MediationBuddy.

### Built-In Http Status Code Support

This is the current list of HTTP non-error status codes supported by the library. These are based on this [method list](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.controllerbase?view=aspnetcore-8.0#methods).

| Codes | Supported          |
| ----- | ------------------ |
| 100s  | 100 - 102          |
| 200s  | 200 - 226          |
| 300s  | 301, 302, 307, 308 |

## Dependencies

- MediationBuddy has a dependency on [NMediation](https://www.nuget.org/packages/NMediation/)
- MediationBuddy.AspNet has a dependency on Microsoft.AspNetCore.App framework.

## Installation

The easiest way to get started is to: [Install with NuGet](https://www.nuget.org/).

In your application layer:

```bash
Install-Package MediationBuddy
```

In your presentation layer:

```bash
Install-Package MediationBuddy.AspNet
```

## What is implied by an "opinionated" library?

If you are familiar with the [Prettier](https://prettier.io/docs/en/option-philosophy) format library for front-end frameworks-then the idea of an "opinionated" library should be familiar.

MediatorBuddy has a very specific way of handling requests and responses. The advantage you gain is up to 100% less unit testing in your presentation layer alongside a consistent way of handling failures.

MediatorBuddy assumes that you prefer to use the built-in [validation attributes](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-7.0#validation-attributes) that Microsoft provides out of the box.

> Attribute validators are highly recommended, especially if you are utilizing Swagger.

You may use a separate library such as [FluentValidation](https://www.nuget.org/packages/FluentValidation)-however you will need to validate request objects in your handlers.

A quick sample using FluentValidation is available [in their docs.](https://github.com/mjbradvica/MediatorBuddy/tree/master/samples/MediatorBuddy.Samples.Api/FluentValidationExample)

## Setup

While MediatorBuddy has nothing it needs to register with the dependency injection framework, it does need to turn off the default model state filter.

For convenience, pass your NMediation configuration setup, and MediatorBuddy will set up NMediation in the same call.

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMediationBuddy(Assembly.GetExecutingAssembly());

        // Continue setup below
    }
}
```

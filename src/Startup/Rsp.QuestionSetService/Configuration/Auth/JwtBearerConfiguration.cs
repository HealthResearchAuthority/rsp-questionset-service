﻿using System.Diagnostics.CodeAnalysis;
using Rsp.QuestionSetService.Application.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using NetDevPack.Security.JwtExtensions;

namespace Rsp.QuestionSetService.Configuration.Auth;

/// <summary>
/// JwtBearer Configuration
/// </summary>
[ExcludeFromCodeCoverage]
public static class JwtBearerConfiguration
{
    /// <summary>
    /// Jwt Bearer Configuration
    /// </summary>
    /// <param name="authOptions"><see cref="JwtBearerOptions"/></param>
    /// <param name="appSettings">Application Settings</param>
    /// <param name="jwtBearerEvents"><see cref="JwtBearerEvents"/></param>
    public static void Configure(JwtBearerOptions authOptions, AppSettings appSettings, JwtBearerEvents jwtBearerEvents)
    {
        authOptions.SetJwksOptions(new JwkOptions(appSettings.AuthSettings.JwksUri));

        // Set a valid audience value for any received OpenIdConnect token.
        // This value is passed into TokenValidationParameters.ValidAudience if that property is empty.
        // Alternatively, set the value below in TokenValidationParameters.ValidAudience
        // or TokenValidationParameters.ValidAudiences (if more than one audience)
        authOptions.Audience = appSettings.AuthSettings.ClientId;
        authOptions.RequireHttpsMetadata = true;
        authOptions.SaveToken = true;

        // Specify token validation parameters.
        // Note: TokenValidationParameters.ClockSkew has default value of 300 seconds (5 minutes) which can be changed by setting ClockSkew below.
        authOptions.TokenValidationParameters = new TokenValidationParameters
        {
            ValidIssuers = appSettings.AuthSettings.Issuers,
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            ValidateLifetime = true
        };

        // Add event handlers
        authOptions.Events = jwtBearerEvents;
    }
}
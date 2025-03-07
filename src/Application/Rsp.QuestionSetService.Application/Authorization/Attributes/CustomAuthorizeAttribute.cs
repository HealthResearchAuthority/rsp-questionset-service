﻿using Microsoft.AspNetCore.Authorization;
using Rsp.QuestionSetService.Application.Authorization.Requirements;

namespace Rsp.QuestionSetService.Application.Authorization.Attributes;

/// <summary>
/// Custom Authorization Attribute with links to authorization requirements.
/// Each authorization requirement is associated with an AuthorizationHandler for
/// the requirement. Handlers are mutally exclusive, if one succeed, we ignore the other ones
/// The AND behaviour can be enabled by failing the requirement in all handlers.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class CustomAuthorizeAttribute() : AuthorizeAttribute, IAuthorizationRequirementData
{
    public IEnumerable<IAuthorizationRequirement> GetRequirements()
    {
        return
        [
            // provide the requirement here to link it to the CustomAuthorizeAttribute
            // change the name of the attribute and requirement

            /// this requirement is linked to the <see cref="AuthorizeRequirementHandler"/>
            new AuthorizeRequirement()
        ];
    }
}
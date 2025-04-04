﻿using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

namespace Rsp.QuestionSetService.WebApi.Controllers;

[ExcludeFromCodeCoverage]
[ApiController]
[Route("[controller]")]
public class ProbesController : ControllerBase
{
    [HttpGet("liveness")]
    public IActionResult Liveness()
    {
        return Ok();
    }

    [HttpGet("readiness")]
    public IActionResult Readiness()
    {
        return Ok();
    }

    [HttpGet("startup")]
    public IActionResult Startup()
    {
        return Ok();
    }
}
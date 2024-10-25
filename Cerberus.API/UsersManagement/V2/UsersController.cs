using Asp.Versioning;
using Cerberus.API.Common.Constants;
using Microsoft.AspNetCore.Mvc;

namespace Cerberus.API.UsersManagement.V2;

[ApiController]
[ApiVersion("2.0")]
[Route(ApiEndpoints.UserMgmt.Users)]
public class UsersController : ControllerBase
{
    public IActionResult Test()
    {
        return Ok("Return From V2");
    }
}
using Asp.Versioning;
using Cerberus.API.Common.Constants;
using Microsoft.AspNetCore.Mvc;

namespace Cerberus.API.UsersManagement.V1;

[ApiController]
[ApiVersion("1.0")]
[Route(ApiEndpoints.UserMgmt.Users)]
public class UsersController : ControllerBase
{
    public IActionResult Test()
    {
        return Ok("Return From V1");
    }
}
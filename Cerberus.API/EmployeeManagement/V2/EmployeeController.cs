using Asp.Versioning;
using Cerberus.API.Common.Constants;
using Microsoft.AspNetCore.Mvc;

namespace Cerberus.API.EmployeeManagement.V2;

[ApiController]
[ApiVersion("2.0")]
[Route(ApiEndpoints.EmployeeMgmt.Users)]
public class EmployeeController : ControllerBase
{
    public IActionResult Test()
    {
        return Ok("Return From V2");
    }
}
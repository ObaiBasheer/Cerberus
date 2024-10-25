using Asp.Versioning;
using Cerberus.API.Common.Constants;
using Microsoft.AspNetCore.Mvc;

namespace Cerberus.API.EmployeeManagement.V1;

[ApiController]
[ApiVersion("1.0")]
[Route(ApiEndpoints.EmployeeMgmt.Users)]
public class EmployeeController : ControllerBase
{
    public IActionResult Test()
    {
        return Ok("Return From V1");
    }
}
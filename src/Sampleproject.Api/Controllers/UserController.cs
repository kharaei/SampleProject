using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Application.Contracts;
using SampleProject.Application.DTOs;

namespace SampleProject.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Insert(RegistrationDTO request)
    {
        await userService.Registration(request);
        return Ok();
    }
}